namespace NoritakeVFD_winforms
{
    partial class Form1
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
            this.radioMainMode = new System.Windows.Forms.RadioButton();
            this.radioFlashingMessage = new System.Windows.Forms.RadioButton();
            this.radioScrollingMessage = new System.Windows.Forms.RadioButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxCharset = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openport = new System.Windows.Forms.CheckBox();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.baudBox = new System.Windows.Forms.NumericUpDown();
            this.panelFlash = new System.Windows.Forms.Panel();
            this.trackBarFlash = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFlash2 = new System.Windows.Forms.TextBox();
            this.txtFlash1 = new System.Windows.Forms.TextBox();
            this.btnFlash = new System.Windows.Forms.CheckBox();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.ReplayDelay = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioLeft2Right = new System.Windows.Forms.RadioButton();
            this.radioRight2Left = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtScroll2 = new System.Windows.Forms.TextBox();
            this.txtScroll1 = new System.Windows.Forms.TextBox();
            this.btnScroll = new System.Windows.Forms.CheckBox();
            this.trackBarScroll = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.radioCpuRam = new System.Windows.Forms.RadioButton();
            this.panelCpuRam = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRam = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.btnCpuRam = new System.Windows.Forms.CheckBox();
            this.radioVUMeter = new System.Windows.Forms.RadioButton();
            this.panelVUMeter = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressRight = new System.Windows.Forms.ProgressBar();
            this.progressLeft = new System.Windows.Forms.ProgressBar();
            this.btnVUMeter = new System.Windows.Forms.CheckBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).BeginInit();
            this.panelFlash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFlash)).BeginInit();
            this.panelScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScroll)).BeginInit();
            this.panelCpuRam.SuspendLayout();
            this.panelVUMeter.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioMainMode
            // 
            this.radioMainMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMainMode.Checked = true;
            this.radioMainMode.FlatAppearance.BorderSize = 3;
            this.radioMainMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMainMode.Location = new System.Drawing.Point(1, 3);
            this.radioMainMode.Name = "radioMainMode";
            this.radioMainMode.Size = new System.Drawing.Size(100, 33);
            this.radioMainMode.TabIndex = 71;
            this.radioMainMode.TabStop = true;
            this.radioMainMode.Text = "Main mode";
            this.radioMainMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMainMode.UseVisualStyleBackColor = true;
            this.radioMainMode.CheckedChanged += new System.EventHandler(this.radioMainMode_CheckedChanged);
            // 
            // radioFlashingMessage
            // 
            this.radioFlashingMessage.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFlashingMessage.FlatAppearance.BorderSize = 3;
            this.radioFlashingMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioFlashingMessage.Location = new System.Drawing.Point(1, 42);
            this.radioFlashingMessage.Name = "radioFlashingMessage";
            this.radioFlashingMessage.Size = new System.Drawing.Size(100, 33);
            this.radioFlashingMessage.TabIndex = 72;
            this.radioFlashingMessage.Text = "Flashing message";
            this.radioFlashingMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioFlashingMessage.UseVisualStyleBackColor = true;
            this.radioFlashingMessage.CheckedChanged += new System.EventHandler(this.radioFlashingMessage_CheckedChanged);
            // 
            // radioScrollingMessage
            // 
            this.radioScrollingMessage.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioScrollingMessage.FlatAppearance.BorderSize = 3;
            this.radioScrollingMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioScrollingMessage.Location = new System.Drawing.Point(1, 81);
            this.radioScrollingMessage.Name = "radioScrollingMessage";
            this.radioScrollingMessage.Size = new System.Drawing.Size(100, 33);
            this.radioScrollingMessage.TabIndex = 73;
            this.radioScrollingMessage.Text = "Scrolling message";
            this.radioScrollingMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioScrollingMessage.UseVisualStyleBackColor = true;
            this.radioScrollingMessage.CheckedChanged += new System.EventHandler(this.radioScrollingMessage_CheckedChanged);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.button4);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.cboxCharset);
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Controls.Add(this.button2);
            this.panelMain.Controls.Add(this.button3);
            this.panelMain.Controls.Add(this.textBox2);
            this.panelMain.Controls.Add(this.textBox1);
            this.panelMain.Controls.Add(this.openport);
            this.panelMain.Controls.Add(this.portBox);
            this.panelMain.Controls.Add(this.baudBox);
            this.panelMain.Location = new System.Drawing.Point(103, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 212);
            this.panelMain.TabIndex = 76;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(199, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 97;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Charset";
            // 
            // cboxCharset
            // 
            this.cboxCharset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxCharset.FormattingEnabled = true;
            this.cboxCharset.Items.AddRange(new object[] {
            "USA",
            "France",
            "Germany",
            "Great Britain",
            "Denmark 1",
            "Sweden",
            "Italy",
            "Spain 1",
            "Japan",
            "Norway",
            "Denmark 2",
            "Spain 2",
            "Latin America",
            "Charset Standard (437)",
            "Charset Latin 1 (850)",
            "Charset Latin 2 (852)",
            "Charset Latin 5/Turkey (857)",
            "Charset Latin/Cyrillic (866)",
            "Charset Latin/Hebrew (862)",
            "Charset Latin/Greek 2 (737)",
            "Charset Latin/Greek 2 (IBM813)",
            "Charset Latin/Katakana"});
            this.cboxCharset.Location = new System.Drawing.Point(335, 117);
            this.cboxCharset.MaxDropDownItems = 99;
            this.cboxCharset.Name = "cboxCharset";
            this.cboxCharset.Size = new System.Drawing.Size(157, 21);
            this.cboxCharset.TabIndex = 95;
            this.cboxCharset.SelectedIndexChanged += new System.EventHandler(this.cboxCharset_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(89, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 94;
            this.button1.Text = "Reset cursor l2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnResetCursor2_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.Location = new System.Drawing.Point(213, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 93;
            this.button2.Text = "Clear screen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClearScreen_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.Location = new System.Drawing.Point(8, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 92;
            this.button3.Text = "Reset cursor l1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnResetCursor1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.Location = new System.Drawing.Point(9, 61);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(484, 43);
            this.textBox2.TabIndex = 89;
            this.textBox2.TabStop = false;
            this.textBox2.WordWrap = false;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(9, 9);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 43);
            this.textBox1.TabIndex = 88;
            this.textBox1.WordWrap = false;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // openport
            // 
            this.openport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openport.Appearance = System.Windows.Forms.Appearance.Button;
            this.openport.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.openport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.openport.Location = new System.Drawing.Point(290, 183);
            this.openport.Name = "openport";
            this.openport.Size = new System.Drawing.Size(70, 25);
            this.openport.TabIndex = 0;
            this.openport.Text = "Connect";
            this.openport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openport.UseVisualStyleBackColor = true;
            this.openport.Click += new System.EventHandler(this.openport_CheckedChanged);
            // 
            // portBox
            // 
            this.portBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.portBox.BackColor = System.Drawing.SystemColors.Window;
            this.portBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(141, 186);
            this.portBox.MaxDropDownItems = 50;
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(75, 21);
            this.portBox.TabIndex = 90;
            // 
            // baudBox
            // 
            this.baudBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.baudBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.baudBox.Location = new System.Drawing.Point(222, 186);
            this.baudBox.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.baudBox.Name = "baudBox";
            this.baudBox.Size = new System.Drawing.Size(62, 21);
            this.baudBox.TabIndex = 91;
            this.baudBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.baudBox.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // panelFlash
            // 
            this.panelFlash.Controls.Add(this.trackBarFlash);
            this.panelFlash.Controls.Add(this.label4);
            this.panelFlash.Controls.Add(this.label1);
            this.panelFlash.Controls.Add(this.txtFlash2);
            this.panelFlash.Controls.Add(this.txtFlash1);
            this.panelFlash.Controls.Add(this.btnFlash);
            this.panelFlash.Location = new System.Drawing.Point(103, 3);
            this.panelFlash.Name = "panelFlash";
            this.panelFlash.Size = new System.Drawing.Size(500, 212);
            this.panelFlash.TabIndex = 97;
            this.panelFlash.Visible = false;
            // 
            // trackBarFlash
            // 
            this.trackBarFlash.LargeChange = 2;
            this.trackBarFlash.Location = new System.Drawing.Point(148, 109);
            this.trackBarFlash.Minimum = 1;
            this.trackBarFlash.Name = "trackBarFlash";
            this.trackBarFlash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarFlash.Size = new System.Drawing.Size(212, 45);
            this.trackBarFlash.TabIndex = 92;
            this.trackBarFlash.Value = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Fast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Slow";
            // 
            // txtFlash2
            // 
            this.txtFlash2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlash2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtFlash2.Location = new System.Drawing.Point(9, 61);
            this.txtFlash2.MaxLength = 20;
            this.txtFlash2.Name = "txtFlash2";
            this.txtFlash2.Size = new System.Drawing.Size(484, 43);
            this.txtFlash2.TabIndex = 91;
            this.txtFlash2.TabStop = false;
            this.txtFlash2.WordWrap = false;
            // 
            // txtFlash1
            // 
            this.txtFlash1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlash1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtFlash1.Location = new System.Drawing.Point(9, 9);
            this.txtFlash1.MaxLength = 20;
            this.txtFlash1.Name = "txtFlash1";
            this.txtFlash1.Size = new System.Drawing.Size(484, 43);
            this.txtFlash1.TabIndex = 90;
            this.txtFlash1.WordWrap = false;
            // 
            // btnFlash
            // 
            this.btnFlash.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnFlash.Location = new System.Drawing.Point(212, 179);
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.Size = new System.Drawing.Size(76, 24);
            this.btnFlash.TabIndex = 2;
            this.btnFlash.Text = "Start";
            this.btnFlash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFlash.UseVisualStyleBackColor = true;
            this.btnFlash.CheckedChanged += new System.EventHandler(this.btnFlash_CheckedChanged);
            // 
            // panelScroll
            // 
            this.panelScroll.Controls.Add(this.ReplayDelay);
            this.panelScroll.Controls.Add(this.label7);
            this.panelScroll.Controls.Add(this.label6);
            this.panelScroll.Controls.Add(this.radioLeft2Right);
            this.panelScroll.Controls.Add(this.radioRight2Left);
            this.panelScroll.Controls.Add(this.label3);
            this.panelScroll.Controls.Add(this.label5);
            this.panelScroll.Controls.Add(this.txtScroll2);
            this.panelScroll.Controls.Add(this.txtScroll1);
            this.panelScroll.Controls.Add(this.btnScroll);
            this.panelScroll.Controls.Add(this.trackBarScroll);
            this.panelScroll.Location = new System.Drawing.Point(103, 3);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(500, 212);
            this.panelScroll.TabIndex = 98;
            this.panelScroll.Visible = false;
            // 
            // ReplayDelay
            // 
            this.ReplayDelay.Location = new System.Drawing.Point(141, 183);
            this.ReplayDelay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ReplayDelay.Name = "ReplayDelay";
            this.ReplayDelay.Size = new System.Drawing.Size(42, 20);
            this.ReplayDelay.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "Scrolling speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 100;
            this.label6.Text = "Delay between scrolls";
            // 
            // radioLeft2Right
            // 
            this.radioLeft2Right.AutoSize = true;
            this.radioLeft2Right.Checked = true;
            this.radioLeft2Right.Location = new System.Drawing.Point(35, 129);
            this.radioLeft2Right.Name = "radioLeft2Right";
            this.radioLeft2Right.Size = new System.Drawing.Size(78, 17);
            this.radioLeft2Right.TabIndex = 99;
            this.radioLeft2Right.TabStop = true;
            this.radioLeft2Right.Text = "Left to right";
            this.radioLeft2Right.UseVisualStyleBackColor = true;
            // 
            // radioRight2Left
            // 
            this.radioRight2Left.AutoSize = true;
            this.radioRight2Left.Location = new System.Drawing.Point(35, 108);
            this.radioRight2Left.Name = "radioRight2Left";
            this.radioRight2Left.Size = new System.Drawing.Size(79, 17);
            this.radioRight2Left.TabIndex = 98;
            this.radioRight2Left.Text = "Right to left";
            this.radioRight2Left.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Fast";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Slow";
            // 
            // txtScroll2
            // 
            this.txtScroll2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScroll2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtScroll2.Location = new System.Drawing.Point(9, 61);
            this.txtScroll2.MaxLength = 100;
            this.txtScroll2.Name = "txtScroll2";
            this.txtScroll2.Size = new System.Drawing.Size(484, 43);
            this.txtScroll2.TabIndex = 93;
            this.txtScroll2.TabStop = false;
            this.txtScroll2.WordWrap = false;
            // 
            // txtScroll1
            // 
            this.txtScroll1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScroll1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtScroll1.Location = new System.Drawing.Point(9, 9);
            this.txtScroll1.MaxLength = 100;
            this.txtScroll1.Name = "txtScroll1";
            this.txtScroll1.Size = new System.Drawing.Size(484, 43);
            this.txtScroll1.TabIndex = 92;
            this.txtScroll1.Text = "0123456789";
            this.txtScroll1.WordWrap = false;
            // 
            // btnScroll
            // 
            this.btnScroll.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnScroll.Location = new System.Drawing.Point(354, 179);
            this.btnScroll.Name = "btnScroll";
            this.btnScroll.Size = new System.Drawing.Size(76, 24);
            this.btnScroll.TabIndex = 3;
            this.btnScroll.Text = "Start";
            this.btnScroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScroll.UseVisualStyleBackColor = true;
            this.btnScroll.CheckedChanged += new System.EventHandler(this.btnScroll_CheckedChanged);
            // 
            // trackBarScroll
            // 
            this.trackBarScroll.LargeChange = 2;
            this.trackBarScroll.Location = new System.Drawing.Point(221, 124);
            this.trackBarScroll.Maximum = 6;
            this.trackBarScroll.Minimum = 1;
            this.trackBarScroll.Name = "trackBarScroll";
            this.trackBarScroll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarScroll.Size = new System.Drawing.Size(212, 45);
            this.trackBarScroll.TabIndex = 95;
            this.trackBarScroll.Value = 6;
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // radioCpuRam
            // 
            this.radioCpuRam.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioCpuRam.FlatAppearance.BorderSize = 3;
            this.radioCpuRam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioCpuRam.Location = new System.Drawing.Point(1, 120);
            this.radioCpuRam.Name = "radioCpuRam";
            this.radioCpuRam.Size = new System.Drawing.Size(100, 33);
            this.radioCpuRam.TabIndex = 75;
            this.radioCpuRam.Text = "CPU/RAM";
            this.radioCpuRam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioCpuRam.UseVisualStyleBackColor = true;
            this.radioCpuRam.CheckedChanged += new System.EventHandler(this.radioCpuRam_CheckedChanged);
            // 
            // panelCpuRam
            // 
            this.panelCpuRam.Controls.Add(this.listBox1);
            this.panelCpuRam.Controls.Add(this.label9);
            this.panelCpuRam.Controls.Add(this.label8);
            this.panelCpuRam.Controls.Add(this.labelRam);
            this.panelCpuRam.Controls.Add(this.labelCPU);
            this.panelCpuRam.Controls.Add(this.btnCpuRam);
            this.panelCpuRam.Location = new System.Drawing.Point(103, 3);
            this.panelCpuRam.Name = "panelCpuRam";
            this.panelCpuRam.Size = new System.Drawing.Size(500, 212);
            this.panelCpuRam.TabIndex = 100;
            this.panelCpuRam.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 95);
            this.listBox1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(200, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "ram";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(200, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "cpu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRam
            // 
            this.labelRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelRam.Location = new System.Drawing.Point(200, 121);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(100, 23);
            this.labelRam.TabIndex = 4;
            this.labelRam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCPU
            // 
            this.labelCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelCPU.Location = new System.Drawing.Point(200, 60);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(100, 23);
            this.labelCPU.TabIndex = 3;
            this.labelCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCpuRam
            // 
            this.btnCpuRam.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnCpuRam.Location = new System.Drawing.Point(212, 179);
            this.btnCpuRam.Name = "btnCpuRam";
            this.btnCpuRam.Size = new System.Drawing.Size(76, 24);
            this.btnCpuRam.TabIndex = 2;
            this.btnCpuRam.Text = "Start";
            this.btnCpuRam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCpuRam.UseVisualStyleBackColor = true;
            this.btnCpuRam.CheckedChanged += new System.EventHandler(this.btnCpuRam_CheckedChanged);
            // 
            // radioVUMeter
            // 
            this.radioVUMeter.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioVUMeter.FlatAppearance.BorderSize = 3;
            this.radioVUMeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioVUMeter.Location = new System.Drawing.Point(1, 159);
            this.radioVUMeter.Name = "radioVUMeter";
            this.radioVUMeter.Size = new System.Drawing.Size(100, 33);
            this.radioVUMeter.TabIndex = 101;
            this.radioVUMeter.Text = "VU meter";
            this.radioVUMeter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioVUMeter.UseVisualStyleBackColor = true;
            this.radioVUMeter.CheckedChanged += new System.EventHandler(this.radioVUMeter_CheckedChanged);
            // 
            // panelVUMeter
            // 
            this.panelVUMeter.Controls.Add(this.label11);
            this.panelVUMeter.Controls.Add(this.label10);
            this.panelVUMeter.Controls.Add(this.progressRight);
            this.panelVUMeter.Controls.Add(this.progressLeft);
            this.panelVUMeter.Controls.Add(this.btnVUMeter);
            this.panelVUMeter.Location = new System.Drawing.Point(103, 3);
            this.panelVUMeter.Name = "panelVUMeter";
            this.panelVUMeter.Size = new System.Drawing.Size(500, 212);
            this.panelVUMeter.TabIndex = 101;
            this.panelVUMeter.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // progressRight
            // 
            this.progressRight.Location = new System.Drawing.Point(113, 69);
            this.progressRight.MarqueeAnimationSpeed = 5;
            this.progressRight.Name = "progressRight";
            this.progressRight.Size = new System.Drawing.Size(274, 23);
            this.progressRight.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressRight.TabIndex = 4;
            // 
            // progressLeft
            // 
            this.progressLeft.Location = new System.Drawing.Point(113, 20);
            this.progressLeft.MarqueeAnimationSpeed = 5;
            this.progressLeft.Name = "progressLeft";
            this.progressLeft.Size = new System.Drawing.Size(274, 23);
            this.progressLeft.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressLeft.TabIndex = 3;
            // 
            // btnVUMeter
            // 
            this.btnVUMeter.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnVUMeter.Location = new System.Drawing.Point(212, 179);
            this.btnVUMeter.Name = "btnVUMeter";
            this.btnVUMeter.Size = new System.Drawing.Size(76, 24);
            this.btnVUMeter.TabIndex = 2;
            this.btnVUMeter.Text = "Start";
            this.btnVUMeter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVUMeter.UseVisualStyleBackColor = true;
            this.btnVUMeter.CheckedChanged += new System.EventHandler(this.btnVUMeter_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 218);
            this.Controls.Add(this.radioVUMeter);
            this.Controls.Add(this.radioCpuRam);
            this.Controls.Add(this.radioScrollingMessage);
            this.Controls.Add(this.radioFlashingMessage);
            this.Controls.Add(this.radioMainMode);
            this.Controls.Add(this.panelVUMeter);
            this.Controls.Add(this.panelCpuRam);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFlash);
            this.Controls.Add(this.panelScroll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VFD control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).EndInit();
            this.panelFlash.ResumeLayout(false);
            this.panelFlash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFlash)).EndInit();
            this.panelScroll.ResumeLayout(false);
            this.panelScroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScroll)).EndInit();
            this.panelCpuRam.ResumeLayout(false);
            this.panelVUMeter.ResumeLayout(false);
            this.panelVUMeter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioMainMode;
        private System.Windows.Forms.RadioButton radioFlashingMessage;
        private System.Windows.Forms.RadioButton radioScrollingMessage;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxCharset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.CheckBox openport;
        public System.Windows.Forms.ComboBox portBox;
        public System.Windows.Forms.NumericUpDown baudBox;
        private System.Windows.Forms.Panel panelFlash;
        private System.Windows.Forms.Panel panelScroll;
        public System.Windows.Forms.CheckBox btnFlash;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.CheckBox btnScroll;
        public System.Windows.Forms.TextBox txtFlash2;
        public System.Windows.Forms.TextBox txtFlash1;
        public System.Windows.Forms.TextBox txtScroll2;
        public System.Windows.Forms.TextBox txtScroll1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarFlash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioLeft2Right;
        private System.Windows.Forms.RadioButton radioRight2Left;
        public System.Windows.Forms.TrackBar trackBarScroll;
        private System.Windows.Forms.NumericUpDown ReplayDelay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioCpuRam;
        private System.Windows.Forms.Panel panelCpuRam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelCPU;
        public System.Windows.Forms.CheckBox btnCpuRam;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioVUMeter;
        private System.Windows.Forms.Panel panelVUMeter;
        public System.Windows.Forms.CheckBox btnVUMeter;
        private System.Windows.Forms.ProgressBar progressRight;
        private System.Windows.Forms.ProgressBar progressLeft;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
    }
}

