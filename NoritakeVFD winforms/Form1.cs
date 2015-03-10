using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            Stuff.Serial.GetPorts();
            foreach (var port in Stuff.Serial.portlist)
            {
                portBox.Items.Add(port);
            }
            portBox.SelectedIndex = 0;
        }


        private void openport_CheckedChanged(object sender, EventArgs e)
        {
            if (openport.Checked)
            {
                Stuff.Serial.uart.Parity = System.IO.Ports.Parity.Odd; //vfd controller specific
                Stuff.Serial.Connect();

                Stuff.Serial.DisplayClearScreen();
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
                Stuff.Serial.DisplayBackspace();
            }
            //if you write more than 20 chars on the display, the cursor stays in the last place and updates the last char, 
            //even if it can't be written in the textBox.
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
                Stuff.Serial.DisplayBackspace();
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
            Stuff.CurPos2Hex(textBox1.Text.Length);
            if (Stuff.right == 0)
            {
                Stuff.Serial.DisplaySetCurPos(0x31, Stuff.left);
            }
            else
            {
                Stuff.Serial.DisplaySetCurPos(0x31, Stuff.left, Stuff.right);
            }
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            Stuff.CurPos2Hex(textBox2.Text.Length);
            if (Stuff.right == 0)
            {
                Stuff.Serial.DisplaySetCurPos(0x32, Stuff.left);
            }
            else
            {
                Stuff.Serial.DisplaySetCurPos(0x32, Stuff.left, Stuff.right);
            }
        }

        private void btnResetCursor1_Click(object sender, EventArgs e)
        {
            Stuff.Serial.DisplaySetCursorToLine1();
        }
        private void btnResetCursor2_Click(object sender, EventArgs e)
        {
            Stuff.Serial.DisplaySetCursorToLine2();
        }
        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            Stuff.Serial.DisplayClearScreen();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO charsets
        }


    }
}
