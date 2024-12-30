namespace Module_Configurator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            moduleDataGrid = new DataGridView();
            moduleName = new DataGridViewTextBoxColumn();
            baseAddress = new DataGridViewTextBoxColumn();
            entryAddress = new DataGridViewTextBoxColumn();
            moduleSize = new DataGridViewTextBoxColumn();
            checksum = new DataGridViewTextBoxColumn();
            crcHash = new DataGridViewTextBoxColumn();
            menuStrip = new MenuStrip();
            btnFile = new ToolStripMenuItem();
            btnNewWindow = new ToolStripMenuItem();
            btnExit = new ToolStripMenuItem();
            btnConnect = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            btnAbout = new ToolStripMenuItem();
            btnDonate = new ToolStripMenuItem();
            btnRefreshModules = new Button();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblNoOfModules = new ToolStripStatusLabel();
            lblDivider1 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            lblPreviousModule = new ToolStripStatusLabel();
            btnClear = new Button();
            btnInjectConsole = new Button();
            btnInjectPC = new Button();
            ButtonUnload = new Button();
            ((System.ComponentModel.ISupportInitialize)moduleDataGrid).BeginInit();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // moduleDataGrid
            // 
            moduleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moduleDataGrid.Columns.AddRange(new DataGridViewColumn[] { moduleName, baseAddress, entryAddress, moduleSize, checksum, crcHash });
            moduleDataGrid.Location = new Point(12, 31);
            moduleDataGrid.Name = "moduleDataGrid";
            moduleDataGrid.ReadOnly = true;
            moduleDataGrid.RowHeadersVisible = false;
            moduleDataGrid.RowHeadersWidth = 51;
            moduleDataGrid.ScrollBars = ScrollBars.None;
            moduleDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            moduleDataGrid.Size = new Size(964, 307);
            moduleDataGrid.TabIndex = 0;
            // 
            // moduleName
            // 
            moduleName.HeaderText = "Module Name";
            moduleName.MinimumWidth = 6;
            moduleName.Name = "moduleName";
            moduleName.ReadOnly = true;
            moduleName.Width = 250;
            // 
            // baseAddress
            // 
            baseAddress.HeaderText = "Base Address";
            baseAddress.MinimumWidth = 6;
            baseAddress.Name = "baseAddress";
            baseAddress.ReadOnly = true;
            baseAddress.Width = 200;
            // 
            // entryAddress
            // 
            entryAddress.HeaderText = "Entry Address";
            entryAddress.MinimumWidth = 6;
            entryAddress.Name = "entryAddress";
            entryAddress.ReadOnly = true;
            entryAddress.Width = 130;
            // 
            // moduleSize
            // 
            moduleSize.HeaderText = "Module Size";
            moduleSize.MinimumWidth = 6;
            moduleSize.Name = "moduleSize";
            moduleSize.ReadOnly = true;
            moduleSize.Width = 125;
            // 
            // checksum
            // 
            checksum.HeaderText = "Checksum";
            checksum.MinimumWidth = 6;
            checksum.Name = "checksum";
            checksum.ReadOnly = true;
            checksum.Width = 125;
            // 
            // crcHash
            // 
            crcHash.HeaderText = "CRC Hash";
            crcHash.MinimumWidth = 6;
            crcHash.Name = "crcHash";
            crcHash.ReadOnly = true;
            crcHash.Width = 125;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { btnFile, btnConnect, infoToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(988, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // btnFile
            // 
            btnFile.DropDownItems.AddRange(new ToolStripItem[] { btnNewWindow, btnExit });
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(46, 24);
            btnFile.Text = "File";
            // 
            // btnNewWindow
            // 
            btnNewWindow.Name = "btnNewWindow";
            btnNewWindow.Size = new Size(224, 26);
            btnNewWindow.Text = "New Window";
            btnNewWindow.Click += btnNewWindow_Click;
            // 
            // btnExit
            // 
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(224, 26);
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // btnConnect
            // 
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(154, 24);
            btnConnect.Text = "Connect To Console";
            btnConnect.Click += btnConnect_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnAbout, btnDonate });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(49, 24);
            infoToolStripMenuItem.Text = "Info";
            // 
            // btnAbout
            // 
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(224, 26);
            btnAbout.Text = "About";
            btnAbout.Click += btnAbout_Click;
            // 
            // btnDonate
            // 
            btnDonate.Name = "btnDonate";
            btnDonate.Size = new Size(224, 26);
            btnDonate.Text = "Donate";
            btnDonate.Click += btnDonate_Click;
            // 
            // btnRefreshModules
            // 
            btnRefreshModules.Location = new Point(17, 344);
            btnRefreshModules.Name = "btnRefreshModules";
            btnRefreshModules.Size = new Size(182, 50);
            btnRefreshModules.TabIndex = 2;
            btnRefreshModules.Text = "Refresh Module List";
            btnRefreshModules.UseVisualStyleBackColor = true;
            btnRefreshModules.Click += btnRefreshModules_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblNoOfModules, lblDivider1, toolStripStatusLabel3, lblPreviousModule });
            statusStrip.Location = new Point(0, 397);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(988, 26);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(114, 20);
            toolStripStatusLabel1.Text = "No. of Modules:";
            // 
            // lblNoOfModules
            // 
            lblNoOfModules.Name = "lblNoOfModules";
            lblNoOfModules.Size = new Size(134, 20);
            lblNoOfModules.Text = "<ModuleNumber>";
            // 
            // lblDivider1
            // 
            lblDivider1.Name = "lblDivider1";
            lblDivider1.Size = new Size(13, 20);
            lblDivider1.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(187, 20);
            toolStripStatusLabel3.Text = "Previously Loaded Module:";
            // 
            // lblPreviousModule
            // 
            lblPreviousModule.Name = "lblPreviousModule";
            lblPreviousModule.Size = new Size(135, 20);
            lblPreviousModule.Text = "<PreviousModule>";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(205, 344);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(187, 50);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear Module List";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnInjectConsole
            // 
            btnInjectConsole.Location = new Point(398, 344);
            btnInjectConsole.Name = "btnInjectConsole";
            btnInjectConsole.Size = new Size(187, 50);
            btnInjectConsole.TabIndex = 6;
            btnInjectConsole.Text = "Inject from Console";
            btnInjectConsole.UseVisualStyleBackColor = true;
            btnInjectConsole.Click += btnInjectConsole_Click;
            // 
            // btnInjectPC
            // 
            btnInjectPC.Location = new Point(591, 344);
            btnInjectPC.Name = "btnInjectPC";
            btnInjectPC.Size = new Size(187, 50);
            btnInjectPC.TabIndex = 5;
            btnInjectPC.Text = "Inject from PC";
            btnInjectPC.UseVisualStyleBackColor = true;
            btnInjectPC.Click += btnInjectPC_Click;
            // 
            // ButtonUnload
            // 
            ButtonUnload.Location = new Point(784, 344);
            ButtonUnload.Name = "ButtonUnload";
            ButtonUnload.Size = new Size(187, 50);
            ButtonUnload.TabIndex = 7;
            ButtonUnload.Text = "Unload Selected Module";
            ButtonUnload.UseVisualStyleBackColor = true;
            ButtonUnload.Click += ButtonUnload_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 423);
            Controls.Add(ButtonUnload);
            Controls.Add(btnInjectConsole);
            Controls.Add(btnInjectPC);
            Controls.Add(btnClear);
            Controls.Add(statusStrip);
            Controls.Add(btnRefreshModules);
            Controls.Add(moduleDataGrid);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xbox 360 Module Configurator";
            ((System.ComponentModel.ISupportInitialize)moduleDataGrid).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView moduleDataGrid;
        private MenuStrip menuStrip;
        private ToolStripMenuItem btnConnect;
        private Button btnRefreshModules;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblNoOfModules;
        private ToolStripStatusLabel lblDivider1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblPreviousModule;
        private Button btnClear;
        private Button btnInjectConsole;
        private Button btnInjectPC;
        private Button ButtonUnload;
        private ToolStripMenuItem btnFile;
        private ToolStripMenuItem btnNewWindow;
        private ToolStripMenuItem btnExit;
        private DataGridViewTextBoxColumn moduleName;
        private DataGridViewTextBoxColumn baseAddress;
        private DataGridViewTextBoxColumn entryAddress;
        private DataGridViewTextBoxColumn moduleSize;
        private DataGridViewTextBoxColumn checksum;
        private DataGridViewTextBoxColumn crcHash;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem btnAbout;
        private ToolStripMenuItem btnDonate;
    }
}