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
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.panelMain = new System.Windows.Forms.Panel();
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
            this.panelFlashingMessage = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarFlash = new System.Windows.Forms.TrackBar();
            this.txtFlash2 = new System.Windows.Forms.TextBox();
            this.txtFlash1 = new System.Windows.Forms.TextBox();
            this.btnFlash = new System.Windows.Forms.CheckBox();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.radioLeft2Right = new System.Windows.Forms.RadioButton();
            this.radioRight2Left = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarScroll = new System.Windows.Forms.TrackBar();
            this.txtScroll2 = new System.Windows.Forms.TextBox();
            this.txtScroll1 = new System.Windows.Forms.TextBox();
            this.btnScroll = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).BeginInit();
            this.panelFlashingMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFlash)).BeginInit();
            this.panelScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScroll)).BeginInit();
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
            this.radioMainMode.Size = new System.Drawing.Size(100, 40);
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
            this.radioFlashingMessage.Location = new System.Drawing.Point(1, 46);
            this.radioFlashingMessage.Name = "radioFlashingMessage";
            this.radioFlashingMessage.Size = new System.Drawing.Size(100, 40);
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
            this.radioScrollingMessage.Location = new System.Drawing.Point(1, 89);
            this.radioScrollingMessage.Name = "radioScrollingMessage";
            this.radioScrollingMessage.Size = new System.Drawing.Size(100, 40);
            this.radioScrollingMessage.TabIndex = 73;
            this.radioScrollingMessage.Text = "Scrolling message";
            this.radioScrollingMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioScrollingMessage.UseVisualStyleBackColor = true;
            this.radioScrollingMessage.CheckedChanged += new System.EventHandler(this.radioScrollingMessage_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.FlatAppearance.BorderSize = 3;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Location = new System.Drawing.Point(1, 132);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(100, 40);
            this.radioButton4.TabIndex = 74;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.FlatAppearance.BorderSize = 3;
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton5.Location = new System.Drawing.Point(1, 175);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(100, 40);
            this.radioButton5.TabIndex = 75;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
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
            this.cboxCharset.Location = new System.Drawing.Point(354, 117);
            this.cboxCharset.MaxDropDownItems = 99;
            this.cboxCharset.Name = "cboxCharset";
            this.cboxCharset.Size = new System.Drawing.Size(138, 21);
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
            // panelFlashingMessage
            // 
            this.panelFlashingMessage.Controls.Add(this.label4);
            this.panelFlashingMessage.Controls.Add(this.label1);
            this.panelFlashingMessage.Controls.Add(this.trackBarFlash);
            this.panelFlashingMessage.Controls.Add(this.txtFlash2);
            this.panelFlashingMessage.Controls.Add(this.txtFlash1);
            this.panelFlashingMessage.Controls.Add(this.btnFlash);
            this.panelFlashingMessage.Location = new System.Drawing.Point(103, 3);
            this.panelFlashingMessage.Name = "panelFlashingMessage";
            this.panelFlashingMessage.Size = new System.Drawing.Size(500, 212);
            this.panelFlashingMessage.TabIndex = 97;
            this.panelFlashingMessage.Visible = false;
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
            // trackBarFlash
            // 
            this.trackBarFlash.Location = new System.Drawing.Point(148, 109);
            this.trackBarFlash.Minimum = 1;
            this.trackBarFlash.Name = "trackBarFlash";
            this.trackBarFlash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarFlash.Size = new System.Drawing.Size(212, 45);
            this.trackBarFlash.TabIndex = 92;
            this.trackBarFlash.Value = 10;
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
            this.panelScroll.Controls.Add(this.radioLeft2Right);
            this.panelScroll.Controls.Add(this.radioRight2Left);
            this.panelScroll.Controls.Add(this.label3);
            this.panelScroll.Controls.Add(this.label5);
            this.panelScroll.Controls.Add(this.trackBarScroll);
            this.panelScroll.Controls.Add(this.txtScroll2);
            this.panelScroll.Controls.Add(this.txtScroll1);
            this.panelScroll.Controls.Add(this.btnScroll);
            this.panelScroll.Location = new System.Drawing.Point(103, 3);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(500, 212);
            this.panelScroll.TabIndex = 98;
            this.panelScroll.Visible = false;
            // 
            // radioLeft2Right
            // 
            this.radioLeft2Right.AutoSize = true;
            this.radioLeft2Right.Location = new System.Drawing.Point(35, 129);
            this.radioLeft2Right.Name = "radioLeft2Right";
            this.radioLeft2Right.Size = new System.Drawing.Size(78, 17);
            this.radioLeft2Right.TabIndex = 99;
            this.radioLeft2Right.Text = "Left to right";
            this.radioLeft2Right.UseVisualStyleBackColor = true;
            // 
            // radioRight2Left
            // 
            this.radioRight2Left.AutoSize = true;
            this.radioRight2Left.Checked = true;
            this.radioRight2Left.Location = new System.Drawing.Point(35, 108);
            this.radioRight2Left.Name = "radioRight2Left";
            this.radioRight2Left.Size = new System.Drawing.Size(79, 17);
            this.radioRight2Left.TabIndex = 98;
            this.radioRight2Left.TabStop = true;
            this.radioRight2Left.Text = "Right to left";
            this.radioRight2Left.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Fast";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Slow";
            // 
            // trackBarScroll
            // 
            this.trackBarScroll.LargeChange = 2;
            this.trackBarScroll.Location = new System.Drawing.Point(221, 110);
            this.trackBarScroll.Minimum = 1;
            this.trackBarScroll.Name = "trackBarScroll";
            this.trackBarScroll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarScroll.Size = new System.Drawing.Size(212, 45);
            this.trackBarScroll.TabIndex = 95;
            this.trackBarScroll.Value = 10;
            // 
            // txtScroll2
            // 
            this.txtScroll2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScroll2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtScroll2.Location = new System.Drawing.Point(9, 61);
            this.txtScroll2.MaxLength = 20;
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
            this.txtScroll1.MaxLength = 20;
            this.txtScroll1.Name = "txtScroll1";
            this.txtScroll1.Size = new System.Drawing.Size(484, 43);
            this.txtScroll1.TabIndex = 92;
            this.txtScroll1.Text = "abcdefghij";
            this.txtScroll1.WordWrap = false;
            // 
            // btnScroll
            // 
            this.btnScroll.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnScroll.Location = new System.Drawing.Point(212, 179);
            this.btnScroll.Name = "btnScroll";
            this.btnScroll.Size = new System.Drawing.Size(76, 24);
            this.btnScroll.TabIndex = 3;
            this.btnScroll.Text = "Start";
            this.btnScroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScroll.UseVisualStyleBackColor = true;
            this.btnScroll.CheckedChanged += new System.EventHandler(this.btnScroll_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 218);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioScrollingMessage);
            this.Controls.Add(this.radioFlashingMessage);
            this.Controls.Add(this.radioMainMode);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFlashingMessage);
            this.Controls.Add(this.panelScroll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VFD control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).EndInit();
            this.panelFlashingMessage.ResumeLayout(false);
            this.panelFlashingMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFlash)).EndInit();
            this.panelScroll.ResumeLayout(false);
            this.panelScroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScroll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioMainMode;
        private System.Windows.Forms.RadioButton radioFlashingMessage;
        private System.Windows.Forms.RadioButton radioScrollingMessage;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
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
        private System.Windows.Forms.Panel panelFlashingMessage;
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
        private System.Windows.Forms.TrackBar trackBarScroll;
        private System.Windows.Forms.RadioButton radioLeft2Right;
        private System.Windows.Forms.RadioButton radioRight2Left;
    }
}

