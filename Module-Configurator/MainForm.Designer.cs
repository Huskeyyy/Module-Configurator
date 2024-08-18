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
            moduleDataGrid = new DataGridView();
            moduleName = new DataGridViewTextBoxColumn();
            baseAddress = new DataGridViewTextBoxColumn();
            moduleSize = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            btnConnect = new ToolStripMenuItem();
            btnRefreshModules = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblNoOfModules = new ToolStripStatusLabel();
            lblDivider1 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            lblPreviousModule = new ToolStripStatusLabel();
            btnClear = new Button();
            btnInjectConsole = new Button();
            btnInjectPC = new Button();
            ((System.ComponentModel.ISupportInitialize)moduleDataGrid).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // moduleDataGrid
            // 
            moduleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moduleDataGrid.Columns.AddRange(new DataGridViewColumn[] { moduleName, baseAddress, moduleSize });
            moduleDataGrid.Location = new Point(12, 31);
            moduleDataGrid.Name = "moduleDataGrid";
            moduleDataGrid.RowHeadersVisible = false;
            moduleDataGrid.RowHeadersWidth = 51;
            moduleDataGrid.Size = new Size(789, 285);
            moduleDataGrid.TabIndex = 0;
            // 
            // moduleName
            // 
            moduleName.HeaderText = "Name of Module";
            moduleName.MinimumWidth = 6;
            moduleName.Name = "moduleName";
            moduleName.Width = 250;
            // 
            // baseAddress
            // 
            baseAddress.HeaderText = "Base Address";
            baseAddress.MinimumWidth = 6;
            baseAddress.Name = "baseAddress";
            baseAddress.Width = 250;
            // 
            // moduleSize
            // 
            moduleSize.HeaderText = "Module Size";
            moduleSize.MinimumWidth = 6;
            moduleSize.Name = "moduleSize";
            moduleSize.Width = 250;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnConnect });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(813, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnConnect
            // 
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(77, 24);
            btnConnect.Text = "Connect";
            btnConnect.Click += btnConnect_Click;
            // 
            // btnRefreshModules
            // 
            btnRefreshModules.Location = new Point(47, 322);
            btnRefreshModules.Name = "btnRefreshModules";
            btnRefreshModules.Size = new Size(175, 49);
            btnRefreshModules.TabIndex = 2;
            btnRefreshModules.Text = "Refresh Module List";
            btnRefreshModules.UseVisualStyleBackColor = true;
            btnRefreshModules.Click += btnRefreshModules_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblNoOfModules, lblDivider1, toolStripStatusLabel3, lblPreviousModule });
            statusStrip1.Location = new Point(0, 382);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(813, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
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
            btnClear.Location = new Point(228, 322);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(175, 49);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear Module List";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnInjectConsole
            // 
            btnInjectConsole.Location = new Point(409, 322);
            btnInjectConsole.Name = "btnInjectConsole";
            btnInjectConsole.Size = new Size(175, 49);
            btnInjectConsole.TabIndex = 6;
            btnInjectConsole.Text = "Inject Module from Console";
            btnInjectConsole.UseVisualStyleBackColor = true;
            btnInjectConsole.Click += btnInjectConsole_Click;
            // 
            // btnInjectPC
            // 
            btnInjectPC.Location = new Point(590, 322);
            btnInjectPC.Name = "btnInjectPC";
            btnInjectPC.Size = new Size(175, 49);
            btnInjectPC.TabIndex = 5;
            btnInjectPC.Text = "Inject Module from PC";
            btnInjectPC.UseVisualStyleBackColor = true;
            btnInjectPC.Click += btnInjectPC_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 408);
            Controls.Add(btnInjectConsole);
            Controls.Add(btnInjectPC);
            Controls.Add(btnClear);
            Controls.Add(statusStrip1);
            Controls.Add(btnRefreshModules);
            Controls.Add(moduleDataGrid);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Module Configurator";
            ((System.ComponentModel.ISupportInitialize)moduleDataGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView moduleDataGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnConnect;
        private Button btnRefreshModules;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblNoOfModules;
        private ToolStripStatusLabel lblDivider1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblPreviousModule;
        private Button btnClear;
        private DataGridViewTextBoxColumn moduleName;
        private DataGridViewTextBoxColumn baseAddress;
        private DataGridViewTextBoxColumn moduleSize;
        private Button btnInjectConsole;
        private Button btnInjectPC;
    }
}