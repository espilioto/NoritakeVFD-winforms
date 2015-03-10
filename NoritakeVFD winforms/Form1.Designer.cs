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
            this.openport = new System.Windows.Forms.CheckBox();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.baudBox = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnResetCursor1 = new System.Windows.Forms.Button();
            this.btnClearScreen = new System.Windows.Forms.Button();
            this.btnResetCursor2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openport
            // 
            this.openport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openport.Appearance = System.Windows.Forms.Appearance.Button;
            this.openport.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.openport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.openport.Location = new System.Drawing.Point(294, 171);
            this.openport.Name = "openport";
            this.openport.Size = new System.Drawing.Size(70, 25);
            this.openport.TabIndex = 0;
            this.openport.Text = "Connect";
            this.openport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openport.UseVisualStyleBackColor = true;
            this.openport.CheckedChanged += new System.EventHandler(this.openport_CheckedChanged);
            // 
            // portBox
            // 
            this.portBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.portBox.BackColor = System.Drawing.SystemColors.Window;
            this.portBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(145, 174);
            this.portBox.MaxDropDownItems = 50;
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(75, 21);
            this.portBox.TabIndex = 64;
            // 
            // baudBox
            // 
            this.baudBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.baudBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.baudBox.Location = new System.Drawing.Point(226, 174);
            this.baudBox.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.baudBox.Name = "baudBox";
            this.baudBox.Size = new System.Drawing.Size(62, 21);
            this.baudBox.TabIndex = 65;
            this.baudBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.baudBox.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 43);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.Location = new System.Drawing.Point(12, 64);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(484, 43);
            this.textBox2.TabIndex = 2;
            this.textBox2.WordWrap = false;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btnResetCursor1
            // 
            this.btnResetCursor1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnResetCursor1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnResetCursor1.Location = new System.Drawing.Point(12, 113);
            this.btnResetCursor1.Name = "btnResetCursor1";
            this.btnResetCursor1.Size = new System.Drawing.Size(75, 33);
            this.btnResetCursor1.TabIndex = 66;
            this.btnResetCursor1.Text = "Reset cursor l1";
            this.btnResetCursor1.UseVisualStyleBackColor = true;
            this.btnResetCursor1.Click += new System.EventHandler(this.btnResetCursor1_Click);
            // 
            // btnClearScreen
            // 
            this.btnClearScreen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearScreen.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnClearScreen.Location = new System.Drawing.Point(217, 113);
            this.btnClearScreen.Name = "btnClearScreen";
            this.btnClearScreen.Size = new System.Drawing.Size(75, 33);
            this.btnClearScreen.TabIndex = 67;
            this.btnClearScreen.Text = "Clear screen";
            this.btnClearScreen.UseVisualStyleBackColor = true;
            this.btnClearScreen.Click += new System.EventHandler(this.btnClearScreen_Click);
            // 
            // btnResetCursor2
            // 
            this.btnResetCursor2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnResetCursor2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnResetCursor2.Location = new System.Drawing.Point(93, 113);
            this.btnResetCursor2.Name = "btnResetCursor2";
            this.btnResetCursor2.Size = new System.Drawing.Size(75, 33);
            this.btnResetCursor2.TabIndex = 68;
            this.btnResetCursor2.Text = "Reset cursor l2";
            this.btnResetCursor2.UseVisualStyleBackColor = true;
            this.btnResetCursor2.Click += new System.EventHandler(this.btnResetCursor2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(375, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Charset";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnResetCursor2);
            this.Controls.Add(this.btnClearScreen);
            this.Controls.Add(this.btnResetCursor1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.openport);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.baudBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VFD control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox openport;
        public System.Windows.Forms.ComboBox portBox;
        public System.Windows.Forms.NumericUpDown baudBox;
        private System.Windows.Forms.Button btnResetCursor1;
        private System.Windows.Forms.Button btnClearScreen;
        private System.Windows.Forms.Button btnResetCursor2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

