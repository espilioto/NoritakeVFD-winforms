using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoritakeVFD_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Form1 form1 = new Form1();

        private void Form1_Load(object sender, EventArgs e)
        {
            form1 = this;

            Stuff.Display.type = (int)Stuff.Display.Type.TwentyByFour; //set the display type 

            Stuff.Serial.GetPorts();
            foreach (var port in Stuff.Serial.portlist)
            {
                portBox.Items.Add(port);
            }
            portBox.SelectedIndex = 0;

            cboxCharset.SelectedIndex = 2;

        }

        private void openport_CheckedChanged(object sender, EventArgs e)
        {
            if (openport.Checked)
            {
                Stuff.Serial.uart.Parity = System.IO.Ports.Parity.Odd; //vfd controller specific
                Stuff.Serial.Connect();

                Stuff.Display.ClearScreen();
            }
            else
            {
                Stuff.Serial.Disconnect();
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Stuff.CurPos2Hex(textBox1.Text.Length);

            if (e.KeyChar == '\b')      //if backspace is pressed...
            {
                Stuff.Display.Backspace();
            }
            //if you write more than 20 chars on the display, the cursor stays in the last place and updates the last char, 
            //even if it can't be written in the textBox. Let's fix that.
            else if (textBox1.Text.Length == 20)
            {
                Stuff.Serial.uart.Write("");
            }
            else
            {
                Stuff.Serial.uart.Write(e.KeyChar.ToString());
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Stuff.CurPos2Hex(textBox2.Text.Length);

            if (e.KeyChar == '\b')
            {
                Stuff.Display.Backspace();
            }
            else if (textBox2.Text.Length == 20)
            {
                Stuff.Serial.uart.Write("");
            }
            else
            {
                Stuff.Serial.uart.Write(e.KeyChar.ToString());
            }
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            Stuff.Display.SetCurPos((byte)Stuff.Display.Line.one, textBox1.SelectionStart);
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            Stuff.Display.SetCurPos((byte)Stuff.Display.Line.two, textBox2.SelectionStart);
        }

        private void btnResetCursor1_Click(object sender, EventArgs e)
        {
            Stuff.Display.SetCursorToLine1();
        }
        private void btnResetCursor2_Click(object sender, EventArgs e)
        {
            Stuff.Display.SetCursorToLine2();
        }
        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            Stuff.Display.ClearScreen();
        }

        private void cboxCharset_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stuff.Serial.uart.Write(Stuff.Display.charsets[cboxCharset.SelectedIndex], 0, 3);
        }

        #region radio buttons and panels
        private void radioMainMode_CheckedChanged(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelFlash.Visible = false;
            panelScroll.Visible = false;
            panelCpuRam.Visible = false;
        }
        private void radioFlashingMessage_CheckedChanged(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelFlash.Visible = true;
            panelScroll.Visible = false;
            panelCpuRam.Visible = false;
        }
        private void radioScrollingMessage_CheckedChanged(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelFlash.Visible = false;
            panelScroll.Visible = true;
            panelCpuRam.Visible = false;
        }
        private void radioCpuRam_CheckedChanged(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelFlash.Visible = false;
            panelScroll.Visible = false;
            panelCpuRam.Visible = true;
        }
        #endregion

        private void btnFlash_CheckedChanged(object sender, EventArgs e) //FLASH
        {
            if (btnFlash.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtFlash1.Text) && string.IsNullOrWhiteSpace(txtFlash2.Text)) //check if there's text first
                {
                    btnFlash.Checked = false;
                    MessageBox.Show("Some text would help.");
                }
                btnFlash.Text = "Stop";
                timer.Enabled = true;
                timer.Interval = trackBarFlash.Value * 100;
                timer.Start();
            }
            else
            {
                timer.Stop();
                timer.Enabled = false;

                Stuff.Display.ClearScreen();
                btnFlash.Text = "Start";
            }
        }
        private void btnScroll_CheckedChanged(object sender, EventArgs e)  //SCROLL
        {
            if (btnScroll.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtScroll1.Text) && string.IsNullOrWhiteSpace(txtScroll2.Text)) //check if there's text first
                {
                    btnFlash.Checked = false;
                    MessageBox.Show("Some text would help.");
                }
                btnScroll.Text = "Stop";

                if (radioRight2Left.Checked)
                {
                    Stuff.scrolling = true;
                    Stuff.Display.ScrollMessageR2L(trackBarScroll.Value * 25, (int)ReplayDelay.Value * 1000, txtScroll1.Text, txtScroll2.Text);
                }
                else
                {
                    Stuff.scrolling = true;
                    Stuff.Display.ScrollMessageL2R(trackBarScroll.Value * 25, (int)ReplayDelay.Value * 1000, txtScroll1.Text, txtScroll2.Text);
                }
            }
            else
            {
                Stuff.scrolling = false;

                Stuff.Display.ClearScreen();
                btnScroll.Text = "Start";
            }
        }
        private void btnCpuRam_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCpuRam.Checked)
            {
                MessageBox.Show("Get out of here stalker.", "whacha lookin at nigguh");
                btnCpuRam.Checked = false;
            }
            //if (btnCpuRam.Checked)
            //{
            //    btnCpuRam.Text = "Stop";
            //    timer.Enabled = true;
            //    timer.Interval = 100;
            //    timer.Start();
            //}
            //else
            //{
            //    timer.Stop();
            //    timer.Enabled = false;

            //    Stuff.Display.ClearScreen();
            //    btnCpuRam.Text = "Start";
            //}
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (btnFlash.Checked)
            {
                timer.Interval = trackBarFlash.Value * 100;
                Stuff.Display.FlashMessage(txtFlash1.Text, txtFlash2.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Stuff.Serial.uart.IsOpen)
            {
                Stuff.Display.ClearScreen();
                Stuff.Serial.Disconnect();
            }
        }

        private void button4_Click(object sender, EventArgs e) //test stuff
        {
            //byte[] com = new byte[] { 0xDB, 0xDC, 0xDD, 0xDE, 0xDF };
            //Stuff.Serial.uart.Write(com, 0, com.Length);
            Stuff.Display.Notify();
        }

    }
}
