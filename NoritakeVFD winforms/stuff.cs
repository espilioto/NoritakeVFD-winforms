using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoritakeVFD_winforms
{
    class Stuff
    {
        public enum Display
        {
            Line1 = 0x31,
            Line2 = 0x32,
            Line3 = 0x33,
            Line4 = 0x34
        };

        public static List<byte[]> charsets = new List<byte[]>
        {
            new byte [] { 0x1B, 0x52, 0x00 },
            new byte [] { 0x1B, 0x52, 0x01 },
            new byte [] { 0x1B, 0x52, 0x02 },
            new byte [] { 0x1B, 0x52, 0x03 },
            new byte [] { 0x1B, 0x52, 0x04 },
            new byte [] { 0x1B, 0x52, 0x05 },
            new byte [] { 0x1B, 0x52, 0x06 },
            new byte [] { 0x1B, 0x52, 0x07 },
            new byte [] { 0x1B, 0x52, 0x08 },
            new byte [] { 0x1B, 0x52, 0x09 },
            new byte [] { 0x1B, 0x52, 0x0A },
            new byte [] { 0x1B, 0x52, 0x0B },
            new byte [] { 0x1B, 0x52, 0x0C },
            new byte [] { 0x1B, 0x52, 0x30 },
            new byte [] { 0x1B, 0x52, 0x31 },
            new byte [] { 0x1B, 0x52, 0x32 },
            new byte [] { 0x1B, 0x52, 0x33 },
            new byte [] { 0x1B, 0x52, 0x35 },
            new byte [] { 0x1B, 0x52, 0x37 },
            new byte [] { 0x1B, 0x52, 0x36 },
            new byte [] { 0x1B, 0x52, 0x38 },
            new byte [] { 0x1B, 0x52, 0x63 }
        };

        public static byte left = 0, right = 0;
        public static int cursorPosition = 0;
        static bool flag = true;

        /// <summary>
        /// converts the cursor position in dec ascii format, based on the textbox's contents. 
        /// example: 1 = 49       15 = 49, 53
        /// </summary>
        public static void CurPos2Hex(int curPos)
        {
            int left = 0, right = 0;

            if (curPos < 10)                    //if the value is less than 9...
            {
                left = curPos + 49;             //...just convert it to ascii 
                if (left == 58)                 //if the position is 9, the ascii equivalent isn't 0 but ':'
                {
                    left = 49;                  //time to fix that, and make the values '1''0'.
                    right = 48;
                }
            }
            else if (curPos > 9 && curPos < 20) //if the value is between 10 and 19
            {
                left = 49;                      //one element remains stable
                right = (curPos % 10) + 49;     //while the other one is easily calculable
                if (right == 58)                //if the value tries to become '1'':' ...
                {
                    left = 50;                  //...make it '2''0' instead!
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

            /// <summary>
            /// This command deletes the characters from the cursor, cursor position included, to the end of the line. 
            /// The position of the cursor remains unchanged.
            /// </summary>
            public static void DisplayDeleteToEndOfLine()
            {
                byte[] command = new byte[4] { 0x1B, 0x5B, 0x30, 0x4B };
                uart.Write(command, 0, 4);
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
            public static void DisplayBackspaceNoDelete()
            {
                byte[] command = new byte[1] { 0x08 };

                uart.Write(command, 0, 1);
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

            /// <param name="scrollSpeed">Set the character scrolling speed on the display in ms.</param>
            /// <param name="replaySpeed">Set the frequency that the message is replayed in ms.</param>
            public static void DisplayScrollMessageR2L(int scrollSpeed, int replaySpeed, string Line1Message, string Line2Message)
            {
                for (int i = 20; i > -1; i--)
                {
                    CurPos2Hex(i);              //find the cursor's position.

                    if (right == 0)
                    {
                        DisplaySetCurPos((byte)Display.Line1, left);    //if the position is 1 - 9, send only 1 byte.
                    }
                    else
                    {
                        DisplaySetCurPos((byte)Display.Line1, left, right); //if it's more than 9, send both digits tha represent the column number.
                    }

                    if (i == 0)       //if the cursor is in column 1, start not sending the string's first letters.
                    {
                        for (int j = 0; j < Line1Message.Length; j++)
                        {
                            uart.Write(Line1Message.Substring(j));
                            DisplayDeleteToEndOfLine();
                            DisplaySetCursorToLine1();
                            System.Threading.Thread.Sleep(scrollSpeed); //being a scrublord works
                         
                            if (j == Line1Message.Length - 1) //if the last letter was sent, reset the loop.
                            {
                                i = 20;
                                DisplayClearScreen();
                            }
                        }
                    }
                    else
                    {
                        if ((20 - i) <= Line1Message.Length) //if the substring is bigger than the string things blow up.
                        {
                            uart.Write(Line1Message.Substring(0, 20 - i)); //send only the part of the string that will actually be displayed.
                        }
                        else
                        {
                            uart.Write(Line1Message);
                        }
                    }

                    if (i < Line1Message.Length)
                    {
                        DisplayDeleteToEndOfLine();
                    }

                    System.Threading.Thread.Sleep(scrollSpeed);

                    Application.DoEvents();

                }
            }
            public static void DisplayScrollMessageL2R(int spaces, string Line1Message, string Line2Message)  //left to right ->
            {
                //DisplaySetCurPos((byte)Display.Line2, left, right); //set cursor to the display's last char space
                //uart.Write(Line2Message);
                //DisplayDeleteToEndOfLine();
            }
            /// <param name="message">Include the spaces in the string plox.</param>
            public static void DisplayFlashMessage(string message)
            {
                if (flag)
                {
                    uart.Write(message);

                    flag = !flag;
                }
                else
                {
                    DisplayClearScreen();

                    flag = !flag;
                }
            }
            public static void DisplayFlashMessage(string Line1Message, string Line2Message)
            {
                if (flag)
                {
                    uart.Write(Line1Message);
                    DisplaySetCursorToLine2();
                    uart.Write(Line2Message);

                    flag = !flag;
                }
                else
                {
                    DisplayClearScreen();

                    flag = !flag;
                }
            }
        }

    }
}
