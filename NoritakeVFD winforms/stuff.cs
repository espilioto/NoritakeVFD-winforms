using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoritakeVFD_winforms
{
    class stuff
    {
        public static byte left = 0, right = 0;
        public static int cursorPosition = 0;

        //stores the cursor position in dec ascii format. example: 1 = 49 / 15 = 49, 53
        public static void CurPos2Hex(int curPos)
        {
            int left = 0, right = 0;

            if (curPos < 9)
            {
                left = (curPos + 49);

                stuff.left = (byte)left;
                stuff.right = 0;
            }
            else
            {
                right = (curPos % 10) + 49;

                if (right > 57) //if the second digit is greater than 9... 
                {
                    left = 50;  //...the cursor is in column 20, so the left digit is 2
                }
                else
                {
                    left = 49; //else, it's between 10 and 19, so make the first digit 1
                }

                if (right == 58) //if right is supposed to be 0 (aka column 20), make it actually 0 and not ':' (dec 58 in ascii)
                {
                    right = 48;
                }


                stuff.left = (byte)left;
                stuff.right = (byte)right;
                cursorPosition = curPos++;
            }
        }

        public class Serial
        {
            public static bool connected = false;
            public static SerialPort uart = new SerialPort();
            public static System.Collections.ArrayList portlist = new System.Collections.ArrayList();

            public static void GetPorts()
            {
                foreach (var port in SerialPort.GetPortNames())
                {
                    portlist.Add(port);
                }
            }

            public static void Connect()
            {
                Form1.form1.portBox.Enabled = false;
                Form1.form1.baudBox.Enabled = false;
                Form1.form1.openport.Text = "Close Port";
                try
                {
                    uart.PortName = Form1.form1.portBox.Text;            //open port and send "ping"
                    uart.BaudRate = int.Parse(Form1.form1.baudBox.Text);
                    uart.Open();

                    Form1.form1.openport.BackColor = System.Drawing.Color.LightGreen;

                    connected = true;
                }

                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message + '\n' + "Is the display connected in port " + uart.PortName + "?");
                }
            }

            public static void Disconnect()
            {
                uart.Close();
                Form1.form1.openport.BackColor = System.Drawing.Color.Transparent;
                Form1.form1.portBox.Enabled = true;
                Form1.form1.baudBox.Enabled = true;
                Form1.form1.openport.Text = "Connect";
                connected = false;
            }

            public static void DisplayWriteBackspace()
            {
                byte[] command = new byte[1] { 0x08 };

                if (cursorPosition == 20)
                {
                    uart.Write(" ");
                }
                else
                {
                    uart.Write(command, 0, 1);
                    uart.Write(" ");
                    uart.Write(command, 0, 1);
                }
            }
            public static void DisplayCurPos(byte line, byte col)
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, line, 0x3B, col, 0x48 }; //command: ESC[<line>;<column number>H
                uart.Write(command, 0, 6);
            }
            public static void Display(byte line, byte colH, byte colL)
            {
                byte[] command = new byte[7] { 0x1B, 0x5B, line, 0x3B, colH, colL, 0x48 }; //command: ESC[<line>;<column number 1><column number 2>H
                uart.Write(command, 0, 7);
            }
            public static void DisplayClearScreen()
            {
                byte[] command = new byte[4] { 0x1B, 0x5B, 0x32, 0x4A };
                uart.Write(command, 0, 4);
                DisplaySetCursorToLine1();

                Form1.form1.textBox1.Clear();
                Form1.form1.textBox2.Clear();

                Form1.form1.textBox1.Focus();
            }
            public static void DisplaySetCursorToLine1()
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, 0x31, 0x3B, 0x31, 0x48 };
                uart.Write(command, 0, 6);

                Form1.form1.textBox1.Focus();
            }
            public static void DisplaySetCursorToLine2()
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, 0x32, 0x3B, 0x31, 0x48 };
                uart.Write(command, 0, 6);

                Form1.form1.textBox2.Focus();
            }
        }
    }
}
