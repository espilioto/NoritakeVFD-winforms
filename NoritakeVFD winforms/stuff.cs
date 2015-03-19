using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoritakeVFD_winforms
{
    class Stuff
    {
        public static byte left = 0, right = 0;
        public static int cursorPosition = 0;
        public static bool printed = false, scrolling = false;

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
                    Serial.uart.PortName = Form1.form1.portBox.Text;            //open port and send "ping"
                    Serial.uart.BaudRate = int.Parse(Form1.form1.baudBox.Text);
                    Serial.uart.Open();

                    Form1.form1.openport.BackColor = System.Drawing.Color.LightGreen;
                }

                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message + '\n' + "Is the display connected in port " + Serial.uart.PortName + "?");
                }
            }

            public static void Disconnect()
            {
                Serial.uart.Close();
                Form1.form1.openport.BackColor = System.Drawing.Color.Transparent;
                Form1.form1.portBox.Enabled = true;
                Form1.form1.baudBox.Enabled = true;
                Form1.form1.openport.Text = "Connect";
                connected = false;
            }
        }

        public class Display
        {

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

            public enum Line : byte
            {
                one = 0x31,
                two = 0x32,
                three = 0x33,
                four = 0x34
            };

            /// <summary>
            /// This command deletes the characters from the cursor, cursor position included, to the end of the line. 
            /// The position of the cursor remains unchanged.
            /// </summary>
            public static void DeleteToEndOfLine()
            {
                byte[] command = new byte[4] { 0x1B, 0x5B, 0x30, 0x4B };
                Serial.uart.Write(command, 0, 4);
            }
            public static void Backspace()
            {
                byte[] command = new byte[1] { 0x08 };

                if (cursorPosition == 20)
                {
                    Serial.uart.Write(" ");
                }
                else
                {
                    Serial.uart.Write(command, 0, 1);
                    Serial.uart.Write(" ");
                    Serial.uart.Write(command, 0, 1);
                }
            }
            public static void BackspaceNoDelete()
            {
                byte[] command = new byte[1] { 0x08 };

                Serial.uart.Write(command, 0, 1);
            }
            public static void SetCurPos(byte line, int col)
            {
                CurPos2Hex(col);

                byte[] command1 = new byte[6] { 0x1B, 0x5B, line, 0x3B, left, 0x48 }; //command: ESC[<line>;<column number>H
                byte[] command2 = new byte[7] { 0x1B, 0x5B, line, 0x3B, left, right, 0x48 }; //command: ESC[<line>;<column number 1><column number 2>H

                if (right == 0)
                {
                    Serial.uart.Write(command1, 0, 6);
                }
                else
                {
                    Serial.uart.Write(command2, 0, 7);
                }
            }
            public static void ClearScreen()
            {
                byte[] command = new byte[4] { 0x1B, 0x5B, 0x32, 0x4A };
                Serial.uart.Write(command, 0, 4);
                SetCursorToLine1();

                Form1.form1.textBox1.Clear();
                Form1.form1.textBox2.Clear();

                Form1.form1.textBox1.Focus();
            }
            public static void SetCursorToLine1()
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, (byte)Line.one, 0x3B, 0x31, 0x48 };
                Serial.uart.Write(command, 0, 6);

                Form1.form1.textBox1.Focus();
            }
            public static void SetCursorToLine2()
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, (byte)Line.two, 0x3B, 0x31, 0x48 };
                Serial.uart.Write(command, 0, 6);

                Form1.form1.textBox2.Focus();
            }

            /// <param name="scrollSpeed">Set the character scrolling speed on the display in ms.</param>
            /// <param name="replaySpeed">Set the frequency that the message is replayed in ms.</param>
            public static async void ScrollMessageR2L(int scrollSpeed, int replaySpeed, string Line1Message, string Line2Message) //right to left <-
            {                                                                                   //must make it warp 
                for (int i = 19; i > -1; i--)
                {

                    if (!scrolling)
                    {
                        break;
                    }

                   SetCurPos((byte)Display.Line.one, i);    //if the position is 1 - 9, send only 1 byte.
                   

                    if (i == 0)       //if the cursor is in column 1, start not sending the string's first letters.
                    {
                        for (int j = 0; j < Line1Message.Length; j++)
                        {
                            Application.DoEvents();
                            if (!scrolling)
                            {
                                break;
                            }

                            Serial.uart.Write(Line1Message.Substring(j));
                            DeleteToEndOfLine();
                            SetCursorToLine1();

                            await Task.Delay(Form1.form1.trackBarScroll.Value * 25);

                            if (j == Line1Message.Length - 1) //if the last letter was sent, reset the loop.
                            {
                                if (!scrolling)
                                {
                                    break;
                                }

                                i = 20;
                                ClearScreen();

                                await Task.Delay(replaySpeed);
                            }
                        }
                    }
                    else
                    {
                        if ((20 - i) <= Line1Message.Length) //if the substring is bigger than the string things blow up.
                        {
                            Serial.uart.Write(Line1Message.Substring(0, 20 - i)); //send only the part of the string that will actually be displayed.

                            if (!(string.IsNullOrWhiteSpace(Line2Message)) && ((20 - i) <= Line2Message.Length)) //LINE2 stuff
                            {
                                SetCurPos((byte)Display.Line.two, i);
                                Serial.uart.Write(Line2Message.Substring(0, 20 - i));
                            }

                            Application.DoEvents();
                            if (!scrolling)
                            {
                                break;
                            }
                        }
                        else
                        {
                            Application.DoEvents();
                            Serial.uart.Write(Line1Message);
                            Display.DeleteToEndOfLine();

                            if (!(string.IsNullOrWhiteSpace(Line2Message))) //LINE2 stuff
                            {
                                SetCurPos((byte)Display.Line.two, i);
                                Serial.uart.Write(Line2Message.Substring(0, 20 - i));
                            }

                            if ((20 - i) <= Line2Message.Length)
                            {
                                SetCurPos((byte)Display.Line.two, i);
                                Serial.uart.Write(" ");
                            }
                        }
                    }

                    //if (i > Line1Message.Length)
                    //{
                    //    DeleteToEndOfLine();
                    //}

                    await Task.Delay(scrollSpeed);
                }

            }
            public static void ScrollMessageL2R(int scrollSpeed, int replaySpeed, string Line1Message, string Line2Message) //left to right ->
            {
                //DisplaySetCurPos((byte)Display.Line2, left, right); //set cursor to the display's last char space
                //Serial.uart.Write(Line2Message);
                //DisplayDeleteToEndOfLine();
            }
            public static void FlashMessage(string Line1Message, string Line2Message)
            {
                if (!printed)
                {
                    Serial.uart.Write(Line1Message);
                    SetCursorToLine2();
                    Serial.uart.Write(Line2Message);

                    printed = !printed;
                }
                else
                {
                    ClearScreen();

                    printed = !printed;
                }
            }
        }

    }
}