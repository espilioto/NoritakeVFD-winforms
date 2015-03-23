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
            /// <summary>
            /// Set the cursor to the selected column without changing line.
            /// </summary>
            public static void SetCurPos(int col)
            {
                CurPos2Hex(col);

                byte[] command1 = new byte[5] { 0x1B, 0x5B, 0x3B, left, 0x48 }; //command: ESC[<line>;<column number>H
                byte[] command2 = new byte[6] { 0x1B, 0x5B, 0x3B, left, right, 0x48 }; //command: ESC[<line>;<column number 1><column number 2>H

                if (right == 0)
                {
                    Serial.uart.Write(command1, 0, 5);
                }
                else
                {
                    Serial.uart.Write(command2, 0, 6);
                }
            }
            /// <summary>
            /// Set the cursor to the selected line and column.
            /// </summary>
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
            /// <summary>
            /// Set the cursor to line 1 column 1.
            /// </summary>
            public static void SetCursorToLine1()
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, (byte)Line.one, 0x3B, 0x31, 0x48 };
                Serial.uart.Write(command, 0, 6);

                Form1.form1.textBox1.Focus();
            }
            /// <summary>
            /// Set the cursor to line 2 column 1.
            /// </summary>
            public static void SetCursorToLine2()
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, (byte)Line.two, 0x3B, 0x31, 0x48 };
                Serial.uart.Write(command, 0, 6);

                Form1.form1.textBox2.Focus();
            }
            /// <summary>
            /// The LF command (hexadecimal 0A) moves the invisible cursor down a line
            ///if it is positioned in one of the first three lines of the display. The column
            ///position remains unchanged.
            ///The position of the cursor remains unchanged if it is already in the last line.
            ///The contents of the last line are copied to the first line and the last line is
            ///deleted.
            /// </summary>
            public static void LineFeed()
            {
                byte[] command = new byte[1] { 0x0A };
                Serial.uart.Write(command, 0, 1);
            }
            ///<summary>
            /// Scroll a message from right to left.
            ///</summary> 
            /// <param name="scrollSpeed">Set the character scrolling speed on the display in ms.</param>
            /// <param name="replaySpeed">Set the frequency that the message is replayed in ms.</param>
            public static async void ScrollMessageR2L(int scrollSpeed, int replaySpeed, string Line1Message, string Line2Message) //right to left <- 
            {
                int line1len = 0, line2len = 0;

                for (int i = 19; i > -1; i--)
                {
                    if (!scrolling)
                        break;

                    if (!(string.IsNullOrWhiteSpace(Line1Message))) //LINE 1
                    {
                        if (line1len < Line1Message.Length) //how many chars to write if message is smaller than the display
                            line1len++;

                        SetCurPos((byte)Line.one, i);

                        if (line1len < Line1Message.Length) //write only as many chars are able to be displayed
                        {
                            Serial.uart.Write(Line1Message.Substring(0, line1len));
                        }
                        else
                        {
                            if (Line1Message.Length > 20) //if its longer than the display
                            {
                                Serial.uart.Write(Line1Message);
                            }
                            else
                            {
                                Serial.uart.Write(Line1Message);
                                DeleteToEndOfLine();
                            }
                        }
                    }

                    if (!(string.IsNullOrWhiteSpace(Line2Message))) //LINE 2
                    {
                        if (line2len < Line2Message.Length)
                            line2len++;

                        SetCurPos((byte)Line.two, i);

                        if (line2len < Line2Message.Length)
                        {
                            Serial.uart.Write(Line2Message.Substring(0, line2len));
                        }
                        else
                        {
                            if (Line2Message.Length > 20)
                            {
                                Serial.uart.Write(Line2Message);
                            }
                            else
                            {
                                Serial.uart.Write(Line2Message);
                                DeleteToEndOfLine();
                            }
                        }
                    }

                    if (i == 0) //reset loop
                    {
                        line1len = 0;
                        line2len = 0;
                        i = 20;

                        await Task.Delay(replaySpeed);
                    }

                    await Task.Delay(scrollSpeed);

                }
            }
            ///<summary>
            /// Scroll a message from left to right.
            ///</summary> 
            /// <param name="scrollSpeed">Set the character scrolling speed on the display in ms.</param>
            /// <param name="replaySpeed">Set the frequency that the message is replayed in ms.</param>
            public static void ScrollMessageL2R(int scrollSpeed, int replaySpeed, string Line1Message, string Line2Message) //left to right ->
            {
                //TODO this 
            }
            /// <summary>
            /// Set a message that flashes at a set interval.
            /// </summary>
            /// <param name="Line1Message">Include spaces in message for -some- text formatting.</param>
            /// <param name="Line2Message">Include spaces in message for -some- text formatting.</param>
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