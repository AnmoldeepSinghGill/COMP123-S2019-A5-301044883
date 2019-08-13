namespace COMP123_S2019_A5_301044883.Views
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDTextLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionTextLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelTextLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextLabel = new System.Windows.Forms.Label();
            this.OSTextLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.PlatformTextLabel = new System.Windows.Forms.Label();
            this.TechSpecsLabel = new System.Windows.Forms.GroupBox();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUSpeedTextLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUNumberTextLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.WebCamTextLabel = new System.Windows.Forms.Label();
            this.CPUTypeTextLabel = new System.Windows.Forms.Label();
            this.GPUTypeTextLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUBrandTextLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.LCDSizeTextLabel = new System.Windows.Forms.Label();
            this.HDDTextLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.MemoryTextLabel = new System.Windows.Forms.Label();
            this.ConfirmInfoLabel = new System.Windows.Forms.Label();
            this.SelectAnotherProductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitAplication);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Select Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.Location = new System.Drawing.Point(12, 54);
            this.ProductIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(116, 33);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID :";
            this.ProductIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductIDTextLabel
            // 
            this.ProductIDTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductIDTextLabel.Location = new System.Drawing.Point(140, 54);
            this.ProductIDTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProductIDTextLabel.Name = "ProductIDTextLabel";
            this.ProductIDTextLabel.Size = new System.Drawing.Size(140, 33);
            this.ProductIDTextLabel.TabIndex = 1;
            this.ProductIDTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Location = new System.Drawing.Point(308, 54);
            this.ConditionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(116, 33);
            this.ConditionLabel.TabIndex = 1;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConditionTextLabel
            // 
            this.ConditionTextLabel.BackColor = System.Drawing.Color.White;
            this.ConditionTextLabel.Location = new System.Drawing.Point(436, 54);
            this.ConditionTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ConditionTextLabel.Name = "ConditionTextLabel";
            this.ConditionTextLabel.Size = new System.Drawing.Size(140, 33);
            this.ConditionTextLabel.TabIndex = 1;
            this.ConditionTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CostLabel
            // 
            this.CostLabel.Location = new System.Drawing.Point(567, 54);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(116, 33);
            this.CostLabel.TabIndex = 1;
            this.CostLabel.Text = "Cost";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CostTextLabel
            // 
            this.CostTextLabel.BackColor = System.Drawing.Color.White;
            this.CostTextLabel.Location = new System.Drawing.Point(655, 54);
            this.CostTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CostTextLabel.Name = "CostTextLabel";
            this.CostTextLabel.Size = new System.Drawing.Size(92, 33);
            this.CostTextLabel.TabIndex = 1;
            this.CostTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextLabel);
            this.ProductInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(23, 113);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(749, 127);
            this.ProductInfoGroupBox.TabIndex = 2;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ModelLabel
            // 
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ModelLabel.Location = new System.Drawing.Point(298, 78);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(103, 33);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelTextLabel
            // 
            this.ModelTextLabel.BackColor = System.Drawing.Color.White;
            this.ModelTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ModelTextLabel.Location = new System.Drawing.Point(417, 78);
            this.ModelTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ModelTextLabel.Name = "ModelTextLabel";
            this.ModelTextLabel.Size = new System.Drawing.Size(307, 33);
            this.ModelTextLabel.TabIndex = 1;
            this.ModelTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ManufacturerLabel.Location = new System.Drawing.Point(9, 78);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(125, 33);
            this.ManufacturerLabel.TabIndex = 1;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OSLabel
            // 
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.OSLabel.Location = new System.Drawing.Point(318, 36);
            this.OSLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(83, 33);
            this.OSLabel.TabIndex = 1;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManufacturerTextLabel
            // 
            this.ManufacturerTextLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ManufacturerTextLabel.Location = new System.Drawing.Point(146, 78);
            this.ManufacturerTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ManufacturerTextLabel.Name = "ManufacturerTextLabel";
            this.ManufacturerTextLabel.Size = new System.Drawing.Size(140, 33);
            this.ManufacturerTextLabel.TabIndex = 1;
            this.ManufacturerTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OSTextLabel
            // 
            this.OSTextLabel.BackColor = System.Drawing.Color.White;
            this.OSTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.OSTextLabel.Location = new System.Drawing.Point(417, 36);
            this.OSTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OSTextLabel.Name = "OSTextLabel";
            this.OSTextLabel.Size = new System.Drawing.Size(307, 33);
            this.OSTextLabel.TabIndex = 1;
            this.OSTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PlatformLabel.Location = new System.Drawing.Point(18, 36);
            this.PlatformLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(116, 33);
            this.PlatformLabel.TabIndex = 1;
            this.PlatformLabel.Text = "Platform ";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlatformTextLabel
            // 
            this.PlatformTextLabel.BackColor = System.Drawing.Color.White;
            this.PlatformTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PlatformTextLabel.Location = new System.Drawing.Point(146, 36);
            this.PlatformTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PlatformTextLabel.Name = "PlatformTextLabel";
            this.PlatformTextLabel.Size = new System.Drawing.Size(140, 33);
            this.PlatformTextLabel.TabIndex = 1;
            this.PlatformTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TechSpecsLabel
            // 
            this.TechSpecsLabel.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsLabel.Controls.Add(this.CPUSpeedTextLabel);
            this.TechSpecsLabel.Controls.Add(this.CPUNumberLabel);
            this.TechSpecsLabel.Controls.Add(this.WebCamLabel);
            this.TechSpecsLabel.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsLabel.Controls.Add(this.CPUNumberTextLabel);
            this.TechSpecsLabel.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsLabel.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsLabel.Controls.Add(this.WebCamTextLabel);
            this.TechSpecsLabel.Controls.Add(this.CPUTypeTextLabel);
            this.TechSpecsLabel.Controls.Add(this.GPUTypeTextLabel);
            this.TechSpecsLabel.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsLabel.Controls.Add(this.CPUBrandTextLabel);
            this.TechSpecsLabel.Controls.Add(this.HDDLabel);
            this.TechSpecsLabel.Controls.Add(this.LCDSizeTextLabel);
            this.TechSpecsLabel.Controls.Add(this.HDDTextLabel);
            this.TechSpecsLabel.Controls.Add(this.MemoryLabel);
            this.TechSpecsLabel.Controls.Add(this.MemoryTextLabel);
            this.TechSpecsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TechSpecsLabel.Location = new System.Drawing.Point(23, 255);
            this.TechSpecsLabel.Name = "TechSpecsLabel";
            this.TechSpecsLabel.Size = new System.Drawing.Size(749, 196);
            this.TechSpecsLabel.TabIndex = 2;
            this.TechSpecsLabel.TabStop = false;
            this.TechSpecsLabel.Text = "Tech Specs";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CPUSpeedLabel.Location = new System.Drawing.Point(241, 129);
            this.CPUSpeedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(120, 33);
            this.CPUSpeedLabel.TabIndex = 1;
            this.CPUSpeedLabel.Text = "CPU speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUSpeedTextLabel
            // 
            this.CPUSpeedTextLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CPUSpeedTextLabel.Location = new System.Drawing.Point(364, 129);
            this.CPUSpeedTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CPUSpeedTextLabel.Name = "CPUSpeedTextLabel";
            this.CPUSpeedTextLabel.Size = new System.Drawing.Size(102, 33);
            this.CPUSpeedTextLabel.TabIndex = 1;
            this.CPUSpeedTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CPUNumberLabel.Location = new System.Drawing.Point(241, 86);
            this.CPUNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(120, 33);
            this.CPUNumberLabel.TabIndex = 1;
            this.CPUNumberLabel.Text = "CPU number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WebCamLabel.Location = new System.Drawing.Point(468, 129);
            this.WebCamLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(98, 33);
            this.WebCamLabel.TabIndex = 1;
            this.WebCamLabel.Text = "WebCam";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CPUTypeLabel.Location = new System.Drawing.Point(9, 129);
            this.CPUTypeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(116, 33);
            this.CPUTypeLabel.TabIndex = 1;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUNumberTextLabel
            // 
            this.CPUNumberTextLabel.BackColor = System.Drawing.Color.White;
            this.CPUNumberTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CPUNumberTextLabel.Location = new System.Drawing.Point(364, 86);
            this.CPUNumberTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CPUNumberTextLabel.Name = "CPUNumberTextLabel";
            this.CPUNumberTextLabel.Size = new System.Drawing.Size(102, 33);
            this.CPUNumberTextLabel.TabIndex = 1;
            this.CPUNumberTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GPUTypeLabel.Location = new System.Drawing.Point(465, 86);
            this.GPUTypeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(101, 33);
            this.GPUTypeLabel.TabIndex = 1;
            this.GPUTypeLabel.Text = "GPU Type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CPUBrandLabel.Location = new System.Drawing.Point(9, 86);
            this.CPUBrandLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(116, 33);
            this.CPUBrandLabel.TabIndex = 1;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WebCamTextLabel
            // 
            this.WebCamTextLabel.BackColor = System.Drawing.Color.White;
            this.WebCamTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WebCamTextLabel.Location = new System.Drawing.Point(570, 129);
            this.WebCamTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WebCamTextLabel.Name = "WebCamTextLabel";
            this.WebCamTextLabel.Size = new System.Drawing.Size(167, 33);
            this.WebCamTextLabel.TabIndex = 1;
            this.WebCamTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUTypeTextLabel
            // 
            this.CPUTypeTextLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CPUTypeTextLabel.Location = new System.Drawing.Point(137, 129);
            this.CPUTypeTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CPUTypeTextLabel.Name = "CPUTypeTextLabel";
            this.CPUTypeTextLabel.Size = new System.Drawing.Size(92, 33);
            this.CPUTypeTextLabel.TabIndex = 1;
            this.CPUTypeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUTypeTextLabel
            // 
            this.GPUTypeTextLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GPUTypeTextLabel.Location = new System.Drawing.Point(568, 86);
            this.GPUTypeTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GPUTypeTextLabel.Name = "GPUTypeTextLabel";
            this.GPUTypeTextLabel.Size = new System.Drawing.Size(169, 33);
            this.GPUTypeTextLabel.TabIndex = 1;
            this.GPUTypeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LCDSizeLabel.Location = new System.Drawing.Point(258, 44);
            this.LCDSizeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(103, 33);
            this.LCDSizeLabel.TabIndex = 1;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUBrandTextLabel
            // 
            this.CPUBrandTextLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CPUBrandTextLabel.Location = new System.Drawing.Point(137, 86);
            this.CPUBrandTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CPUBrandTextLabel.Name = "CPUBrandTextLabel";
            this.CPUBrandTextLabel.Size = new System.Drawing.Size(92, 33);
            this.CPUBrandTextLabel.TabIndex = 1;
            this.CPUBrandTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HDDLabel.Location = new System.Drawing.Point(489, 44);
            this.HDDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(73, 33);
            this.HDDLabel.TabIndex = 1;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LCDSizeTextLabel
            // 
            this.LCDSizeTextLabel.BackColor = System.Drawing.Color.White;
            this.LCDSizeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LCDSizeTextLabel.Location = new System.Drawing.Point(364, 44);
            this.LCDSizeTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LCDSizeTextLabel.Name = "LCDSizeTextLabel";
            this.LCDSizeTextLabel.Size = new System.Drawing.Size(102, 33);
            this.LCDSizeTextLabel.TabIndex = 1;
            this.LCDSizeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HDDTextLabel
            // 
            this.HDDTextLabel.BackColor = System.Drawing.Color.White;
            this.HDDTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HDDTextLabel.Location = new System.Drawing.Point(570, 44);
            this.HDDTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HDDTextLabel.Name = "HDDTextLabel";
            this.HDDTextLabel.Size = new System.Drawing.Size(167, 33);
            this.HDDTextLabel.TabIndex = 1;
            this.HDDTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MemoryLabel.Location = new System.Drawing.Point(9, 44);
            this.MemoryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(116, 33);
            this.MemoryLabel.TabIndex = 1;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemoryTextLabel
            // 
            this.MemoryTextLabel.BackColor = System.Drawing.Color.White;
            this.MemoryTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MemoryTextLabel.Location = new System.Drawing.Point(137, 44);
            this.MemoryTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MemoryTextLabel.Name = "MemoryTextLabel";
            this.MemoryTextLabel.Size = new System.Drawing.Size(92, 33);
            this.MemoryTextLabel.TabIndex = 1;
            this.MemoryTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConfirmInfoLabel
            // 
            this.ConfirmInfoLabel.Location = new System.Drawing.Point(15, 464);
            this.ConfirmInfoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ConfirmInfoLabel.Name = "ConfirmInfoLabel";
            this.ConfirmInfoLabel.Size = new System.Drawing.Size(237, 60);
            this.ConfirmInfoLabel.TabIndex = 1;
            this.ConfirmInfoLabel.Text = "Click Next To Confirm Selection";
            this.ConfirmInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectAnotherProductButton
            // 
            this.SelectAnotherProductButton.Location = new System.Drawing.Point(306, 478);
            this.SelectAnotherProductButton.Name = "SelectAnotherProductButton";
            this.SelectAnotherProductButton.Size = new System.Drawing.Size(227, 33);
            this.SelectAnotherProductButton.TabIndex = 3;
            this.SelectAnotherProductButton.Text = "Select Another Product";
            this.SelectAnotherProductButton.UseVisualStyleBackColor = true;
            this.SelectAnotherProductButton.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(551, 478);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(114, 33);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.ExitAplication);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(670, 478);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(114, 33);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(571, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductOpenFileDialog
            // 
            this.ProductOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectAnotherProductButton);
            this.Controls.Add(this.TechSpecsLabel);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CostTextLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionTextLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDTextLabel);
            this.Controls.Add(this.ConfirmInfoLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Info Form";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductInfoForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.TechSpecsLabel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ProductIDTextLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ConditionTextLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CostTextLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ModelTextLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ManufacturerTextLabel;
        private System.Windows.Forms.Label OSTextLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.GroupBox TechSpecsLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUSpeedTextLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUNumberTextLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUTypeTextLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label CPUBrandTextLabel;
        private System.Windows.Forms.Label LCDSizeTextLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label MemoryTextLabel;
        private System.Windows.Forms.Label ConfirmInfoLabel;
        private System.Windows.Forms.Button SelectAnotherProductButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label GPUTypeTextLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label HDDTextLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label WebCamTextLabel;
        private System.Windows.Forms.Label PlatformTextLabel;
        private System.Windows.Forms.OpenFileDialog ProductOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog ProductSaveFileDialog;
        public System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}