using System;
using System.ComponentModel;
using XDevkit;
using JRPC_Client;

namespace Module_Configurator
{
    public partial class MainForm : Form
    {
        private IXboxConsole console; // Represents the Xbox console instance

        public MainForm()
        {
            InitializeComponent(); // Initializes the form components
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Attempt to connect to the console using default settings
                if (console.Connect(out console, "default"))
                {
                    // Connect to the console's debugger
                    console.DebugTarget.ConnectAsDebugger("jtag", XboxDebugConnectFlags.Force);
                    // Refresh the list of modules
                    btnRefreshModules_Click(sender, e);
                }
                else
                {
                    // Show error if connection fails
                    MessageBox.Show("Failed to connect to the console.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show($"An error occurred: {ex.Message}", "Module Configurator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close(); // Close the application if there's an error
            }
        }

        private void btnRefreshModules_Click(object sender, EventArgs e)
        {
            moduleDataGrid.Rows.Clear(); // Clear existing rows

            // Loop through each module in the console's debugger target
            foreach (IXboxModule xboxModule in console.DebugTarget.Modules)
            {
                string name = xboxModule.ModuleInfo.Name;
                string baseAddressHex = $"0x{xboxModule.ModuleInfo.BaseAddress:X}";
                string sizeHex = $"0x{xboxModule.ModuleInfo.Size:X}";

                // Create a new row for the module and add it to the data grid
                object[] row = { name, baseAddressHex, sizeHex };
                moduleDataGrid.Rows.Add(row);
            }

            // Sort the data grid by base address in ascending order
            moduleDataGrid.Sort(moduleDataGrid.Columns[1], ListSortDirection.Ascending);
            lblNoOfModules.Text = moduleDataGrid.Rows.Count.ToString(); // Update the label with the count of modules
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            moduleDataGrid.Rows.Clear(); // Clear all rows from the data grid
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
                        // Send the selected file to the Xbox console
                        console.SendFile(openFileDialog.FileName, filePath);
                        // Call the Xbox kernel to inject the module
                        console.Call<uint>("xboxkrnl.exe", 409, new object[]
                        {
                            filePath,
                            8,
                            0,
                            0
                        });

                        // Refresh the list of modules and update UI labels
                        btnRefreshModules_Click(sender, e);
                        lblNoOfModules.Text = moduleDataGrid.Rows.Count.ToString();
                        lblPreviousModule.Text = fileName; // Set the file name label
                        MessageBox.Show("Successfully injected module!");
                    }
                    catch (Exception ex)
                    {
                        // Show error message if the injection fails
                        MessageBox.Show($"Failed to inject module: {ex.Message}", "Injection Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void btnInjectConsole_Click(object sender, EventArgs e)
        {
            string modulePath = string.Empty; // Variable to hold the module path

            // Show the InputBox to get the module path
            if (InputBox.Show("Test Input Box",
                "&Enter the path of the module you would like to load:", ref modulePath) == DialogResult.OK)
            {
                try
                {
                    // Calls the Xbox kernel to inject the module using the provided path
                    console.Call<uint>("xboxkrnl.exe", 409, new object[]
                    {
                        modulePath,
                        8,
                        0,
                        0
                    });

                    // Refresh modules and update labels
                    btnRefreshModules_Click(sender, null);
                    lblNoOfModules.Text = moduleDataGrid.Rows.Count.ToString();
                    lblPreviousModule.Text = modulePath; // Update the previous module label
                    console.XNotify("Successfully injected module!");
                }
                catch (Exception)
                {
                    // Show error message if the injection fails
                    MessageBox.Show("Failed to inject module, maybe the module you want to inject does not support it.", "Injection Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                // If user cancels or closes the InputBox, exit the method
                return;
            }
        }
    }
}
