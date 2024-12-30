using JRPC_Client;
using System.ComponentModel;
using System.Diagnostics;
using XDevkit;

namespace Module_Configurator
{
    public partial class MainForm : Form
    {
        #region Function Calls and Parameters
        private IXboxConsole console; // Represents the Xbox console instance

        // Kernel function call IDs
        private const int InjectModuleCallId = 409;
        private const int UnloadModuleCallId = 0x1a1;

        // Kernel parameters
        private const int InjectParam = 8;
        private const int SysDllFlag = 0x40;
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Menu Strip Buttons

        private void btnNewWindow_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (console.Connect(out console))
                {
                    // Connects to the console's debugger
                    console.DebugTarget.ConnectAsDebugger("jtag", XboxDebugConnectFlags.Force);

                    DialogResult result = MessageBox.Show("Connection Successful, would you like to refresh the module list now?", "Module Configurator", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        btnRefreshModules_Click(sender, e);
                    }

                }
                else
                {
                    MessageBox.Show("Failed to connect to the console.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Module Configurator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Module Configurator is an open-source tool that allows you to view and manage modules on your Xbox 360 console.\n\n" +
                "Developed by Huskeyyy - https://github.com/Huskeyyy \n\n" +
                "If you find this tool useful, consider donating or contributing to support future development.", "About Module Configurator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.buymeacoffee.com/xexhuskii");
        }

        #endregion

        #region Main Event Handlers

        private void btnRefreshModules_Click(object sender, EventArgs e)
        {
            RefreshModuleList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            moduleDataGrid.Rows.Clear();
        }

        private void btnInjectConsole_Click(object sender, EventArgs e)
        {
            string modulePath = string.Empty;

            // Shows the InputBox to get the module path from the user
            if (InputBox.Show("Test Input Box", "&Enter the path of the module you would like to load:", ref modulePath) == DialogResult.OK)
            {
                try
                {
                    // Calls the Xbox kernel to inject the module using the provided path
                    console.Call<uint>("xboxkrnl.exe", InjectModuleCallId, new object[]
                    {
                        modulePath,
                        InjectParam,
                        0,
                        0
                    });

                    RefreshModuleList();
                    lblNoOfModules.Text = moduleDataGrid.Rows.Count.ToString();
                    lblPreviousModule.Text = modulePath;
                    console.XNotify("Successfully injected module!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to inject module, maybe the module you want to inject does not support it.", "Injection Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnInjectPC_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files (*.*)|*.*";
                openFileDialog.Title = "Select a File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileName(openFileDialog.FileName);
                    string filePath = Path.Combine("Hdd:\\", fileName); // Define the file path on the Xbox console

                    try
                    {
                        console.SendFile(openFileDialog.FileName, filePath);

                        // Calls the Xbox kernel to inject the module
                        console.Call<uint>("xboxkrnl.exe", InjectModuleCallId, new object[]
                        {
                            filePath,
                            InjectParam,
                            0,
                            0
                        });

                        // Refreshes the list of modules and updates UI labels
                        RefreshModuleList();
                        lblNoOfModules.Text = moduleDataGrid.Rows.Count.ToString();
                        lblPreviousModule.Text = fileName;
                        MessageBox.Show("Successfully injected module!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to inject module: {ex.Message}", "Injection Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void ButtonUnload_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (moduleDataGrid.CurrentRow != null && moduleDataGrid.CurrentRow.Index >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = moduleDataGrid.CurrentRow;

                // Gets the text from the first column (Module Name)
                string moduleName = selectedRow.Cells[0].Value.ToString();

                UnloadModule(moduleName, true);
            }
            else
            {
                MessageBox.Show("Please select a module to unload.", "No Module Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Methods

        private void RefreshModuleList()
        {
            moduleDataGrid.Rows.Clear();

            // Loops through each module in the console's debugger target and adds it to the data grid
            foreach (IXboxModule xboxModule in console.DebugTarget.Modules)
            {
                string name = xboxModule.ModuleInfo.Name;
                string baseAddressHex = $"0x{xboxModule.ModuleInfo.BaseAddress:X}";
                string entryAddressHex = $"0x{xboxModule.GetEntryPointAddress().ToString("X")}";
                string sizeInMB = Extensions.ConvertHexToMB($"0x{xboxModule.ModuleInfo.Size:X}").ToString("F2") + " MB";
                string checksum = xboxModule.ModuleInfo.CheckSum.ToString();
                string hash = xboxModule.ModuleInfo.GetHashCode().ToString();

                object[] row = { name, baseAddressHex, entryAddressHex, sizeInMB, checksum, hash };
                moduleDataGrid.Rows.Add(row);
            }

            // Sorts the grid by base address in ascending order by default
            moduleDataGrid.Sort(moduleDataGrid.Columns[1], ListSortDirection.Ascending);
            lblNoOfModules.Text = moduleDataGrid.Rows.Count.ToString();
        }

        // Retrieves the address of the specified module
        private uint GetModuleHandle(string moduleName)
        {
            object[] parameters = new object[] { moduleName };
            return console.Call<uint>("xam.xex", 1102, parameters);
        }


        private void UnloadModule(string module, bool sysdll)
        {
            try
            {
                uint moduleHandle = GetModuleHandle(module);

                if (moduleHandle != 0)
                {
                    if (sysdll)
                    {
                        console.WriteInt16(moduleHandle + SysDllFlag, 1);
                    }

                    object[] arguments = { moduleHandle };
                    console.CallVoid("xboxkrnl.exe", UnloadModuleCallId, arguments);

                    RefreshModuleList();

                    MessageBox.Show("Module unloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There was an error unloading the module. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error unloading the module: \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
