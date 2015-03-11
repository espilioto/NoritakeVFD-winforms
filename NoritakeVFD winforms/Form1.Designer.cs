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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.radioMainMode = new System.Windows.Forms.RadioButton();
            this.radioFlashingMessage = new System.Windows.Forms.RadioButton();
            this.radioScrollingMessage = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openport = new System.Windows.Forms.CheckBox();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.baudBox = new System.Windows.Forms.NumericUpDown();
            this.panelFlashingMessage = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnFlashing = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).BeginInit();
            this.panelFlashingMessage.SuspendLayout();
            this.panelScroll.SuspendLayout();
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
            this.panelMain.Controls.Add(this.comboBox2);
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
            this.label2.Location = new System.Drawing.Point(410, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Charset";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(371, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 95;
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
            this.textBox2.Location = new System.Drawing.Point(8, 57);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(484, 43);
            this.textBox2.TabIndex = 89;
            this.textBox2.WordWrap = false;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(8, 5);
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
            this.openport.TabIndex = 87;
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
            this.panelFlashingMessage.Controls.Add(this.textBox3);
            this.panelFlashingMessage.Controls.Add(this.btnFlashing);
            this.panelFlashingMessage.Controls.Add(this.label1);
            this.panelFlashingMessage.Location = new System.Drawing.Point(103, 3);
            this.panelFlashingMessage.Name = "panelFlashingMessage";
            this.panelFlashingMessage.Size = new System.Drawing.Size(500, 212);
            this.panelFlashingMessage.TabIndex = 97;
            this.panelFlashingMessage.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 43);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 20);
            this.textBox3.TabIndex = 3;
            // 
            // btnFlashing
            // 
            this.btnFlashing.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnFlashing.Location = new System.Drawing.Point(212, 156);
            this.btnFlashing.Name = "btnFlashing";
            this.btnFlashing.Size = new System.Drawing.Size(76, 24);
            this.btnFlashing.TabIndex = 2;
            this.btnFlashing.Text = "Start";
            this.btnFlashing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFlashing.UseVisualStyleBackColor = true;
            this.btnFlashing.CheckedChanged += new System.EventHandler(this.btnFlashing_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "flash";
            // 
            // panelScroll
            // 
            this.panelScroll.Controls.Add(this.label3);
            this.panelScroll.Location = new System.Drawing.Point(103, 3);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(500, 212);
            this.panelScroll.TabIndex = 98;
            this.panelScroll.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "scroll";
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
            this.Controls.Add(this.panelFlashingMessage);
            this.Controls.Add(this.panelScroll);
            this.Controls.Add(this.panelMain);
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
            this.panelScroll.ResumeLayout(false);
            this.panelScroll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RadioButton radioMainMode;
        private System.Windows.Forms.RadioButton radioFlashingMessage;
        private System.Windows.Forms.RadioButton radioScrollingMessage;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.CheckBox btnFlashing;
    }
}

