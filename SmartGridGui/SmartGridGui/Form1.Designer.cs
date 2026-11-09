namespace SmartGridGui
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssSources = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssStability = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpAddSource = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPanelEfficiency = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSunlight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudWindSpeed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudBladeLength = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMaxCapacity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCharge = new System.Windows.Forms.NumericUpDown();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnAddSource = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lvSources = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalGen = new System.Windows.Forms.Label();
            this.nudDemand = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpAddSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPanelEfficiency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSunlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBladeLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDemand)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportJSONToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fileToolStripMenuItem.Text = "File ";
            // 
            // exportJSONToolStripMenuItem
            // 
            this.exportJSONToolStripMenuItem.Name = "exportJSONToolStripMenuItem";
            this.exportJSONToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportJSONToolStripMenuItem.Text = "Export JSON";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSources,
            this.tssStability});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssSources
            // 
            this.tssSources.Name = "tssSources";
            this.tssSources.Size = new System.Drawing.Size(75, 20);
            this.tssSources.Text = "Sources: 0";
            this.tssSources.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tssStability
            // 
            this.tssStability.Name = "tssStability";
            this.tssStability.Size = new System.Drawing.Size(76, 20);
            this.tssStability.Text = "Stability: -";
            // 
            // grpAddSource
            // 
            this.grpAddSource.Controls.Add(this.btnClear);
            this.grpAddSource.Controls.Add(this.btnAddSource);
            this.grpAddSource.Controls.Add(this.chkActive);
            this.grpAddSource.Controls.Add(this.nudCharge);
            this.grpAddSource.Controls.Add(this.label7);
            this.grpAddSource.Controls.Add(this.nudMaxCapacity);
            this.grpAddSource.Controls.Add(this.label6);
            this.grpAddSource.Controls.Add(this.nudBladeLength);
            this.grpAddSource.Controls.Add(this.label5);
            this.grpAddSource.Controls.Add(this.nudWindSpeed);
            this.grpAddSource.Controls.Add(this.label4);
            this.grpAddSource.Controls.Add(this.nudSunlight);
            this.grpAddSource.Controls.Add(this.label3);
            this.grpAddSource.Controls.Add(this.nudPanelEfficiency);
            this.grpAddSource.Controls.Add(this.label2);
            this.grpAddSource.Controls.Add(this.label1);
            this.grpAddSource.Controls.Add(this.nudCapacity);
            this.grpAddSource.Controls.Add(this.txtName);
            this.grpAddSource.Controls.Add(this.cmbType);
            this.grpAddSource.Location = new System.Drawing.Point(0, 31);
            this.grpAddSource.Name = "grpAddSource";
            this.grpAddSource.Size = new System.Drawing.Size(370, 460);
            this.grpAddSource.TabIndex = 2;
            this.grpAddSource.TabStop = false;
            this.grpAddSource.Text = "Add Power Source";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Solar Panel",
            "Wind Turbine",
            "Battery Storage"});
            this.cmbType.Location = new System.Drawing.Point(12, 21);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name:";
            // 
            // nudCapacity
            // 
            this.nudCapacity.DecimalPlaces = 2;
            this.nudCapacity.Location = new System.Drawing.Point(172, 99);
            this.nudCapacity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(120, 22);
            this.nudCapacity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Capacity (kW):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Panel Efficiency (%):";
            // 
            // nudPanelEfficiency
            // 
            this.nudPanelEfficiency.DecimalPlaces = 2;
            this.nudPanelEfficiency.Location = new System.Drawing.Point(172, 135);
            this.nudPanelEfficiency.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPanelEfficiency.Name = "nudPanelEfficiency";
            this.nudPanelEfficiency.Size = new System.Drawing.Size(120, 22);
            this.nudPanelEfficiency.TabIndex = 5;
            this.nudPanelEfficiency.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sunlight (lux):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nudSunlight
            // 
            this.nudSunlight.DecimalPlaces = 2;
            this.nudSunlight.Location = new System.Drawing.Point(172, 175);
            this.nudSunlight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSunlight.Name = "nudSunlight";
            this.nudSunlight.Size = new System.Drawing.Size(120, 22);
            this.nudSunlight.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wind Speed (m/s):";
            // 
            // nudWindSpeed
            // 
            this.nudWindSpeed.DecimalPlaces = 2;
            this.nudWindSpeed.Location = new System.Drawing.Point(172, 210);
            this.nudWindSpeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudWindSpeed.Name = "nudWindSpeed";
            this.nudWindSpeed.Size = new System.Drawing.Size(120, 22);
            this.nudWindSpeed.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Blade Length (m):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nudBladeLength
            // 
            this.nudBladeLength.DecimalPlaces = 2;
            this.nudBladeLength.Location = new System.Drawing.Point(172, 251);
            this.nudBladeLength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBladeLength.Name = "nudBladeLength";
            this.nudBladeLength.Size = new System.Drawing.Size(120, 22);
            this.nudBladeLength.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Max Capacity (kWh):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // nudMaxCapacity
            // 
            this.nudMaxCapacity.DecimalPlaces = 2;
            this.nudMaxCapacity.Location = new System.Drawing.Point(172, 288);
            this.nudMaxCapacity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMaxCapacity.Name = "nudMaxCapacity";
            this.nudMaxCapacity.Size = new System.Drawing.Size(120, 22);
            this.nudMaxCapacity.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Current Charge (kWh):";
            // 
            // nudCharge
            // 
            this.nudCharge.DecimalPlaces = 2;
            this.nudCharge.Location = new System.Drawing.Point(172, 332);
            this.nudCharge.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCharge.Name = "nudCharge";
            this.nudCharge.Size = new System.Drawing.Size(120, 22);
            this.nudCharge.TabIndex = 15;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(13, 377);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(66, 20);
            this.chkActive.TabIndex = 16;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnAddSource
            // 
            this.btnAddSource.Location = new System.Drawing.Point(12, 412);
            this.btnAddSource.Name = "btnAddSource";
            this.btnAddSource.Size = new System.Drawing.Size(94, 23);
            this.btnAddSource.TabIndex = 17;
            this.btnAddSource.Text = "Add Source";
            this.btnAddSource.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(124, 412);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lvSources
            // 
            this.lvSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvSources.FullRowSelect = true;
            this.lvSources.GridLines = true;
            this.lvSources.HideSelection = false;
            this.lvSources.Location = new System.Drawing.Point(390, 40);
            this.lvSources.MultiSelect = false;
            this.lvSources.Name = "lvSources";
            this.lvSources.Size = new System.Drawing.Size(480, 320);
            this.lvSources.TabIndex = 3;
            this.lvSources.UseCompatibleStateImageBehavior = false;
            this.lvSources.View = System.Windows.Forms.View.Details;
            this.lvSources.SelectedIndexChanged += new System.EventHandler(this.lvSources_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cappacity (KW)";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Output(KW)";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Efficiency";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Load Demand (kW):";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblTotalGen
            // 
            this.lblTotalGen.AutoSize = true;
            this.lblTotalGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGen.Location = new System.Drawing.Point(387, 408);
            this.lblTotalGen.Name = "lblTotalGen";
            this.lblTotalGen.Size = new System.Drawing.Size(189, 16);
            this.lblTotalGen.TabIndex = 20;
            this.lblTotalGen.Text = "Total Generation : 0.00 kW";
            // 
            // nudDemand
            // 
            this.nudDemand.DecimalPlaces = 2;
            this.nudDemand.Location = new System.Drawing.Point(520, 376);
            this.nudDemand.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDemand.Name = "nudDemand";
            this.nudDemand.Size = new System.Drawing.Size(120, 22);
            this.nudDemand.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(667, 371);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 23);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(667, 406);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 23);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(667, 443);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(94, 23);
            this.btnEvaluate.TabIndex = 19;
            this.btnEvaluate.Text = "Evaluate Stability";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(776, 371);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 23);
            this.btnConnect.TabIndex = 22;
            this.btnConnect.Text = "Connect Grid";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(776, 405);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(94, 23);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(776, 443);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 23);
            this.btnExport.TabIndex = 24;
            this.btnExport.Text = "Export JSON";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 573);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudDemand);
            this.Controls.Add(this.lblTotalGen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvSources);
            this.Controls.Add(this.grpAddSource);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Grid & Renewable Energy Monitoring";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpAddSource.ResumeLayout(false);
            this.grpAddSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPanelEfficiency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSunlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBladeLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDemand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssSources;
        private System.Windows.Forms.ToolStripStatusLabel tssStability;
        private System.Windows.Forms.GroupBox grpAddSource;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPanelEfficiency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSunlight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudWindSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudBladeLength;
        private System.Windows.Forms.Button btnAddSource;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.NumericUpDown nudCharge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMaxCapacity;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lvSources;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalGen;
        private System.Windows.Forms.NumericUpDown nudDemand;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnExport;
    }
}

