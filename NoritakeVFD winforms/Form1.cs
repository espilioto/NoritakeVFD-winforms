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

            stuff.Serial.GetPorts();
            foreach (var port in stuff.Serial.portlist)
            {
                portBox.Items.Add(port);
            }
            portBox.SelectedIndex = 0;
        }


        private void openport_CheckedChanged(object sender, EventArgs e)
        {
            if (openport.Checked)
            {
                stuff.Serial.Connect();
                stuff.Serial.uart.Parity = System.IO.Ports.Parity.Odd; //vfd controller specific
            }
            else
            {
                stuff.Serial.Disconnect();
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')      //if backspace is pressed...
            {
                stuff.Serial.WriteBackspace();
            }
            //if you write more than 20 chars on the display, the cursor stays in the last place and updates the last char, 
            //even if it can't be written in the textBox.
            else if (textBox1.Text.Length == 20)
            {
                stuff.Serial.uart.Write("");
            }
            else
            {
                stuff.Serial.uart.Write(e.KeyChar.ToString());
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                stuff.Serial.WriteBackspace();
            }
            else if (textBox1.Text.Length == 20)
            {
                stuff.Serial.uart.Write("");
            }
            else
            {
                stuff.Serial.uart.Write(e.KeyChar.ToString());
            }
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            //TODO move display cursor on click
            //stuff.Serial.CursorPosition(0x31, (textBox1.Text.Length+1));
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            //stuff.Serial.CursorPosition(0x32, textBox2.Text.Length);
        }

        private void btnResetCursor1_Click(object sender, EventArgs e)
        {
            stuff.Serial.SetCursorToLine1();
        }
        private void btnResetCursor2_Click(object sender, EventArgs e)
        {
            stuff.Serial.SetCursorToLine2();
        }
        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            stuff.Serial.ClearScreen();
        }


    }
}
