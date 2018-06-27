namespace LZRConfigTool
{
    partial class MForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelConfigVer = new System.Windows.Forms.Label();
            this.labelSoftVer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDevConnect = new System.Windows.Forms.Label();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonWriteFile = new System.Windows.Forms.Button();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.labelFileCheck = new System.Windows.Forms.Label();
            this.textBoxInputFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonWriteConfig = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBoxOutputConfig = new System.Windows.Forms.TextBox();
            this.textBoxFieldRedirection = new System.Windows.Forms.TextBox();
            this.textBoxMountSide = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDownFieldWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFieldHeight = new System.Windows.Forms.NumericUpDown();
            this.comboBoxActiveDetectCurtains = new System.Windows.Forms.ComboBox();
            this.comboBoxImmunityFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxUncoveredZone = new System.Windows.Forms.ComboBox();
            this.comboBoxObjectSize = new System.Windows.Forms.ComboBox();
            this.comboBoxActivationDelay = new System.Windows.Forms.ComboBox();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 612);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(571, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabel1.Text = "Welcome!";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.AutoSize = false;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelConfigVer);
            this.panel1.Controls.Add(this.labelSoftVer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 67);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SOFTWARE VERSION:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelConfigVer
            // 
            this.labelConfigVer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelConfigVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelConfigVer.Location = new System.Drawing.Point(466, 43);
            this.labelConfigVer.Name = "labelConfigVer";
            this.labelConfigVer.Size = new System.Drawing.Size(100, 13);
            this.labelConfigVer.TabIndex = 4;
            // 
            // labelSoftVer
            // 
            this.labelSoftVer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSoftVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSoftVer.Location = new System.Drawing.Point(466, 21);
            this.labelSoftVer.Name = "labelSoftVer";
            this.labelSoftVer.Size = new System.Drawing.Size(100, 13);
            this.labelSoftVer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONFIGURATION VERSION:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelDevConnect);
            this.groupBox1.Controls.Add(this.comboBoxDevice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelDevConnect
            // 
            this.labelDevConnect.AutoSize = true;
            this.labelDevConnect.Location = new System.Drawing.Point(66, 55);
            this.labelDevConnect.Name = "labelDevConnect";
            this.labelDevConnect.Size = new System.Drawing.Size(116, 13);
            this.labelDevConnect.TabIndex = 1;
            this.labelDevConnect.Text = "Device Not Connected";
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(69, 27);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(460, 21);
            this.comboBoxDevice.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Device:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonWriteFile);
            this.groupBox2.Controls.Add(this.buttonBrowseFile);
            this.groupBox2.Controls.Add(this.labelFileCheck);
            this.groupBox2.Controls.Add(this.textBoxInputFilePath);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Write config from file";
            // 
            // buttonWriteFile
            // 
            this.buttonWriteFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonWriteFile.Enabled = false;
            this.buttonWriteFile.Location = new System.Drawing.Point(457, 54);
            this.buttonWriteFile.Name = "buttonWriteFile";
            this.buttonWriteFile.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteFile.TabIndex = 3;
            this.buttonWriteFile.Text = "Write";
            this.buttonWriteFile.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonBrowseFile.Location = new System.Drawing.Point(457, 24);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFile.TabIndex = 2;
            this.buttonBrowseFile.Text = "Browse";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            // 
            // labelFileCheck
            // 
            this.labelFileCheck.AutoSize = true;
            this.labelFileCheck.Location = new System.Drawing.Point(77, 53);
            this.labelFileCheck.Name = "labelFileCheck";
            this.labelFileCheck.Size = new System.Drawing.Size(50, 13);
            this.labelFileCheck.TabIndex = 2;
            this.labelFileCheck.Text = "File error!";
            // 
            // textBoxInputFilePath
            // 
            this.textBoxInputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputFilePath.Location = new System.Drawing.Point(77, 26);
            this.textBoxInputFilePath.Name = "textBoxInputFilePath";
            this.textBoxInputFilePath.Size = new System.Drawing.Size(370, 20);
            this.textBoxInputFilePath.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Input File:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.comboBoxActivationDelay);
            this.groupBox3.Controls.Add(this.comboBoxObjectSize);
            this.groupBox3.Controls.Add(this.comboBoxUncoveredZone);
            this.groupBox3.Controls.Add(this.comboBoxImmunityFilter);
            this.groupBox3.Controls.Add(this.comboBoxActiveDetectCurtains);
            this.groupBox3.Controls.Add(this.numericUpDownFieldHeight);
            this.groupBox3.Controls.Add(this.numericUpDownFieldWidth);
            this.groupBox3.Controls.Add(this.buttonWriteConfig);
            this.groupBox3.Controls.Add(this.buttonExport);
            this.groupBox3.Controls.Add(this.buttonRead);
            this.groupBox3.Controls.Add(this.textBoxOutputConfig);
            this.groupBox3.Controls.Add(this.textBoxFieldRedirection);
            this.groupBox3.Controls.Add(this.textBoxMountSide);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(13, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 283);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Config";
            // 
            // buttonWriteConfig
            // 
            this.buttonWriteConfig.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonWriteConfig.Location = new System.Drawing.Point(457, 252);
            this.buttonWriteConfig.Name = "buttonWriteConfig";
            this.buttonWriteConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteConfig.TabIndex = 16;
            this.buttonWriteConfig.Text = "Write";
            this.buttonWriteConfig.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonExport.Location = new System.Drawing.Point(457, 223);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 15;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // buttonRead
            // 
            this.buttonRead.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRead.Location = new System.Drawing.Point(457, 194);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 14;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputConfig
            // 
            this.textBoxOutputConfig.Enabled = false;
            this.textBoxOutputConfig.Location = new System.Drawing.Point(158, 253);
            this.textBoxOutputConfig.Name = "textBoxOutputConfig";
            this.textBoxOutputConfig.Size = new System.Drawing.Size(100, 20);
            this.textBoxOutputConfig.TabIndex = 13;
            this.textBoxOutputConfig.Text = "3";
            this.textBoxOutputConfig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxFieldRedirection
            // 
            this.textBoxFieldRedirection.Enabled = false;
            this.textBoxFieldRedirection.Location = new System.Drawing.Point(158, 224);
            this.textBoxFieldRedirection.Name = "textBoxFieldRedirection";
            this.textBoxFieldRedirection.Size = new System.Drawing.Size(100, 20);
            this.textBoxFieldRedirection.TabIndex = 12;
            this.textBoxFieldRedirection.Text = "1";
            this.textBoxFieldRedirection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMountSide
            // 
            this.textBoxMountSide.Enabled = false;
            this.textBoxMountSide.Location = new System.Drawing.Point(158, 22);
            this.textBoxMountSide.Name = "textBoxMountSide";
            this.textBoxMountSide.Size = new System.Drawing.Size(100, 20);
            this.textBoxMountSide.TabIndex = 4;
            this.textBoxMountSide.Text = "3";
            this.textBoxMountSide.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Output Configuration:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Detection Field Redirection:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Output Activation Delay:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Min.Object Size:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Uncovered Zone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Immunity Filter:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Active Detection Curtains:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(495, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "m";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(262, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "m";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(326, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Field Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Field Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mounting Side:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // numericUpDownFieldWidth
            // 
            this.numericUpDownFieldWidth.DecimalPlaces = 1;
            this.numericUpDownFieldWidth.Location = new System.Drawing.Point(158, 50);
            this.numericUpDownFieldWidth.Name = "numericUpDownFieldWidth";
            this.numericUpDownFieldWidth.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownFieldWidth.TabIndex = 5;
            this.numericUpDownFieldWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownFieldHeight
            // 
            this.numericUpDownFieldHeight.DecimalPlaces = 1;
            this.numericUpDownFieldHeight.Location = new System.Drawing.Point(393, 50);
            this.numericUpDownFieldHeight.Name = "numericUpDownFieldHeight";
            this.numericUpDownFieldHeight.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownFieldHeight.TabIndex = 6;
            this.numericUpDownFieldHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxActiveDetectCurtains
            // 
            this.comboBoxActiveDetectCurtains.FormattingEnabled = true;
            this.comboBoxActiveDetectCurtains.Location = new System.Drawing.Point(158, 79);
            this.comboBoxActiveDetectCurtains.Name = "comboBoxActiveDetectCurtains";
            this.comboBoxActiveDetectCurtains.Size = new System.Drawing.Size(100, 21);
            this.comboBoxActiveDetectCurtains.TabIndex = 7;
            // 
            // comboBoxImmunityFilter
            // 
            this.comboBoxImmunityFilter.FormattingEnabled = true;
            this.comboBoxImmunityFilter.Location = new System.Drawing.Point(158, 108);
            this.comboBoxImmunityFilter.Name = "comboBoxImmunityFilter";
            this.comboBoxImmunityFilter.Size = new System.Drawing.Size(100, 21);
            this.comboBoxImmunityFilter.TabIndex = 8;
            // 
            // comboBoxUncoveredZone
            // 
            this.comboBoxUncoveredZone.FormattingEnabled = true;
            this.comboBoxUncoveredZone.Location = new System.Drawing.Point(158, 137);
            this.comboBoxUncoveredZone.Name = "comboBoxUncoveredZone";
            this.comboBoxUncoveredZone.Size = new System.Drawing.Size(100, 21);
            this.comboBoxUncoveredZone.TabIndex = 9;
            // 
            // comboBoxObjectSize
            // 
            this.comboBoxObjectSize.FormattingEnabled = true;
            this.comboBoxObjectSize.Location = new System.Drawing.Point(158, 166);
            this.comboBoxObjectSize.Name = "comboBoxObjectSize";
            this.comboBoxObjectSize.Size = new System.Drawing.Size(100, 21);
            this.comboBoxObjectSize.TabIndex = 10;
            // 
            // comboBoxActivationDelay
            // 
            this.comboBoxActivationDelay.FormattingEnabled = true;
            this.comboBoxActivationDelay.Location = new System.Drawing.Point(158, 195);
            this.comboBoxActivationDelay.Name = "comboBoxActivationDelay";
            this.comboBoxActivationDelay.Size = new System.Drawing.Size(100, 21);
            this.comboBoxActivationDelay.TabIndex = 11;
            // 
            // MForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(571, 634);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Name = "MForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEA LZR Config Tool (trial)";
            this.Load += new System.EventHandler(this.MForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelConfigVer;
        private System.Windows.Forms.Label labelSoftVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.Label labelDevConnect;
        private System.Windows.Forms.Button buttonWriteFile;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.Label labelFileCheck;
        private System.Windows.Forms.TextBox textBoxInputFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOutputConfig;
        private System.Windows.Forms.TextBox textBoxFieldRedirection;
        private System.Windows.Forms.TextBox textBoxMountSide;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonWriteConfig;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ComboBox comboBoxActivationDelay;
        private System.Windows.Forms.ComboBox comboBoxObjectSize;
        private System.Windows.Forms.ComboBox comboBoxUncoveredZone;
        private System.Windows.Forms.ComboBox comboBoxImmunityFilter;
        private System.Windows.Forms.ComboBox comboBoxActiveDetectCurtains;
        private System.Windows.Forms.NumericUpDown numericUpDownFieldHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownFieldWidth;
    }
}

