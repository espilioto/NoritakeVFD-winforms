using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoritakeVFD_winforms
{
    class Stuff
    {
        public static byte left = 0, right = 0;
        public static int cursorPosition = 0;


        //converts the cursor position in dec ascii format, based on the textbox's length. 
        //example: 1 = 49 / 15 = 49, 53
        public static void CurPos2Hex(int curPos)
        {
            int left = 0, right = 0;

            if (curPos < 10)    //if the length is less than 9...
            {
                left = curPos + 49; //...convert it to ascii 
                if (left == 58)     //if the position is 9, the ascii equivalent isn't 0 but ':'
                {
                    left = 49;      //time to fix that 
                    right = 48;
                }
            }
            else if (curPos > 9 && curPos < 20)
            {
                left = 49;
                right = (curPos % 10) + 49;
                if (right == 58)
                {
                    left = 50;
                    right = 48;
                }
            }
            else
            {
                left = 50;
                right = 48;

            }

            Stuff.left = (byte)left;
            Stuff.right = (byte)right;
            cursorPosition = curPos++;
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

            public static void DisplayBackspace()
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
            public static void DisplaySetCurPos(byte line, byte col)
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, line, 0x3B, col, 0x48 }; //command: ESC[<line>;<column number>H
                uart.Write(command, 0, 6);
            }
            public static void DisplaySetCurPos(byte line, byte colH, byte colL)
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
            /// <param name="line">Which line of the display you want to use. 0x31 for line 1, 0x32 for line 2 etc.</param>
            /// <param name="spaces">Number of " " between messages.</param>
            /// <param name="direction">true for left to right, false for the opposite.</param>
            /// <param name="speed">Scrolling speed. Characters/sec.</param>
            public static void DisplayScrollMessage(int line, int spaces, int speed, bool direction, string message)
            {

            }
            /// <param name="message">Include the spaces in the string plox.</param>
            public static void DisplayFlashMessage(int line, int speed, string message)
            {
                while (Form1.form1.btnFlashing.Checked)
                {
                    DisplayClearScreen();
                    System.Threading.Thread.Sleep(500);
                    uart.Write(message);
                    System.Threading.Thread.Sleep(500);
                }
            }

        }
    }
}
