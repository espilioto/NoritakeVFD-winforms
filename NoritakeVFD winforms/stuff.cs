﻿using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreAudioApi;

namespace NoritakeVFD_winforms
{

    class Stuff
    {
        public static byte leftByte = 0, rightByte = 0;
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
                left = curPos + 48;             //...just convert it to ascii 
                if (left == 58)                 //if the position is 9, the ascii equivalent isn't 0 but ':'
                {
                    left = 49;                  //time to fix that, and make the values '1''0'.
                    right = 48;
                }
            }
            else if (curPos > 9 && curPos < 20) //if the value is between 10 and 19
            {
                left = 49;                      //one element remains stable
                right = (curPos % 10) + 48;     //while the other one is easily calculable
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

            Stuff.leftByte = (byte)left;
            Stuff.rightByte = (byte)right;
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
                    System.Windows.Forms.MessageBox.Show(ex.Message + '\n' + "Is the display connected?");
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
            public static List<byte[]> VUMeterBufferBars = new List<byte[]>
            {
                new byte [] { 0xDB },
                new byte [] { 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB }, //5
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB }, //10
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB }, //15
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB }, //20
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB }, //25
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB }, //30
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB }, //35
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB },
                new byte [] { 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB, 0xDB }
            };

            public static List < string > VUMeterBufferSpaces = new List<string>(new string[] {
                "                    ", //20
                "                   ", 
                "                  ",
                "                 ",
                "                ",
                "               ", //15
                "              ",
                "             ",
                "            ",
                "           ",
                "          ", //10
                "         ",
                "        ",
                "       ",
                "      ",
                "     ", //5
                "    ",
                "   ",
                "  ",
                " "
            });

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

            public static int type = 0;
            public enum Type
            {
                TwentyByTwo = 2,
                TwentyByFour = 4
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
            /// <summary>
            /// This command deletes all characters from the first till the specified column number on the current line.
            /// </summary>
            /// <param name="col">Column number, starting from 1.</param>
            public static void DeleteFromStartToColumn(int col)
            {
                SetCurPos(1);
                for (int i = 0; i < col; i++)
                {
                    Serial.uart.Write(" ");
                }

            }
            /// <summary>
            /// The command moves the cursor one space to the left.
            /// If there is a character in the position to which the cursor moves, it is deleted. 
            /// This command is ignored if the cursor is already at the very start of the line.
            /// </summary>
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
            /// <summary>
            /// The BS command (hexadecimal 08) moves the cursor one space to the left.
            /// If there is a character in the position to which the cursor moves, it is not
            /// deleted. This command is ignored if the cursor is already at the very start of the line.
            /// </summary>
            public static void BackspaceNoDelete()
            {
                byte[] command = new byte[1] { 0x08 };

                Serial.uart.Write(command, 0, 1);
            }
            /// <summary>
            /// Set the cursor to the selected column of the current line.
            /// </summary>
            public static void SetCurPos(int col)
            {
                CurPos2Hex(col);

                byte[] command1 = new byte[5] { 0x1B, 0x5B, 0x3B, leftByte, 0x48 }; //command: ESC[<line>;<column number>H
                byte[] command2 = new byte[6] { 0x1B, 0x5B, 0x3B, leftByte, rightByte, 0x48 }; //command: ESC[<line>;<column number 1><column number 2>H

                if (rightByte == 0)
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

                byte[] command1 = new byte[6] { 0x1B, 0x5B, line, 0x3B, leftByte, 0x48 }; //command: ESC[<line>;<column number>H
                byte[] command2 = new byte[7] { 0x1B, 0x5B, line, 0x3B, leftByte, rightByte, 0x48 }; //command: ESC[<line>;<column number 1><column number 2>H

                if (rightByte == 0)
                {
                    Serial.uart.Write(command1, 0, 6);
                }
                else
                {
                    Serial.uart.Write(command2, 0, 7);
                }
            }
            /// <summary>
            /// Clears the entire display and sets the cursor to line 1 column 1.
            /// </summary>
            public static void ClearScreen()
            {
                byte[] command = new byte[4] { 0x1B, 0x5B, 0x32, 0x4A };
                try
                {
                    Serial.uart.Write(command, 0, 4);
                    SetCursorToLine1();
                }
                catch (Exception)
                {                    
                }

                Form1.form1.textBox1.Clear();
                Form1.form1.textBox2.Clear();

                Form1.form1.textBox1.Focus();
            }
            /// <summary>
            /// Sets the cursor to line 1 column 1.
            /// </summary>
            public static void SetCursorToLine1()
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, (byte)Line.one, 0x3B, 0x31, 0x48 };
                Serial.uart.Write(command, 0, 6);

                Form1.form1.textBox1.Focus();
            }
            /// <summary>
            /// Sets the cursor to line 2 column 1.
            /// </summary>
            public static void SetCursorToLine2()
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, (byte)Line.two, 0x3B, 0x31, 0x48 };
                Serial.uart.Write(command, 0, 6);

                Form1.form1.textBox2.Focus();
            }
            /// <summary>
            /// Sets the cursor to line 3 column 1.
            /// </summary>
            public static void SetCursorToLine3()
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, (byte)Line.three, 0x3B, 0x31, 0x48 };
                Serial.uart.Write(command, 0, 6);

                Form1.form1.textBox2.Focus();
            }
            /// <summary>
            /// Sets the cursor to line 4 column 1.
            /// </summary>
            public static void SetCursorToLine4()
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, (byte)Line.four, 0x3B, 0x31, 0x48 };
                Serial.uart.Write(command, 0, 6);

                Form1.form1.textBox2.Focus();
            }
            /// <summary>
            /// The LF command (hexadecimal 0A) moves the invisible cursor down a line
            /// if it is positioned in one of the first three lines of the display. The column
            /// position remains unchanged.
            /// The position of the cursor remains unchanged if it is already in the last line.
            /// The contents of the last line are copied to the first line and the last line is
            /// deleted.
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
                bool done = false;
                int line1len = 0, line2len = 0;

                ClearScreen();

                for (int i = 20; i > -1; i--)
                {
                    if (!scrolling)
                        break;

                    if (!(string.IsNullOrWhiteSpace(Line1Message)) && i > 1) //LINE 1
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

                    if (!(string.IsNullOrWhiteSpace(Line2Message)) && i > 1) //LINE 2
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

                    if (i == 1) // when the message finally reaches the first column start omitting chars
                    {
                        for (int j = 0; j < (Math.Max(Line1Message.Length, Line2Message.Length) + 1); j++) //count till the length of the longest string
                        {
                            if (!scrolling)
                                break;

                            if (!(string.IsNullOrWhiteSpace(Line1Message))) //LINE 1
                            {
                                if (j <= Line1Message.Length)
                                {
                                    SetCursorToLine1();
                                    Serial.uart.Write(Line1Message.Substring(j));
                                }
                                if ((j + 20) > Line1Message.Length)//if the string that was printed is shorter than the screen, delete the rest
                                {
                                    DeleteToEndOfLine();
                                }

                            }

                            if (!(string.IsNullOrWhiteSpace(Line2Message))) //LINE 2
                            {
                                if (j <= Line2Message.Length)
                                {
                                    SetCursorToLine2();
                                    Serial.uart.Write(Line2Message.Substring(j));
                                }
                                if ((j + 20) > Line2Message.Length)
                                {
                                    DeleteToEndOfLine();
                                }
                            }

                            await Task.Delay(scrollSpeed);
                        }
                        done = true;
                    }

                    if (done) // reset the loop
                    {
                        line1len = 0;
                        line2len = 0;
                        i = 21;
                        done = !done;

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
            public static async void ScrollMessageL2R(int scrollSpeed, int replaySpeed, string Line1Message, string Line2Message) //left to right ->
            {
                bool done = false;
                int line1Len = Line1Message.Length, line2Len = Line2Message.Length;
                int L1CursorPos = 1, L2CursorPos = 1;
                ClearScreen();

                for (int i = 1; i < 21; i++)
                {
                    if (!scrolling)
                        break;

                    if (line1Len <= Line1Message.Length)
                    {
                        line1Len--;
                    }
                    if (line2Len <= Line2Message.Length)
                    {
                        line2Len--;
                    }

                    if (i > Line1Message.Length)
                    {
                        SetCurPos(++L1CursorPos);
                    }
                    else
                    {
                        SetCurPos(1);
                    }

                    if (!(string.IsNullOrWhiteSpace(Line1Message))) //LINE 1
                    {

                        if (i > Line1Message.Length)
                        {
                            SetCurPos(++L1CursorPos);
                        }
                        else
                        {
                            SetCurPos(1);
                        }

                        if (line1Len < 0)
                        {
                            Serial.uart.Write(Line1Message);
                            DeleteFromStartToColumn(L1CursorPos - 1);
                        }
                        else if (line1Len > (L1CursorPos + Line1Message.Length))
                        {
                            //Serial.uart.Write(Line1Message.Substring());
                        }
                        else
                        {
                            Serial.uart.Write(Line1Message.Substring(line1Len));
                        }
                    }

                    if (!(string.IsNullOrWhiteSpace(Line2Message))) //LINE 2
                    {

                        if (i > Line2Message.Length)
                        {
                            SetCurPos(++L2CursorPos);
                        }
                        else
                        {
                            SetCurPos(1);
                        }

                        if (line2Len < 0)
                        {
                            Serial.uart.Write(Line2Message);
                            DeleteFromStartToColumn(L2CursorPos - 1);
                        }
                        else if (line2Len > (L2CursorPos + Line2Message.Length))
                        {
                            //Serial.uart.Write(Line1Message.Substring());
                        }
                        else
                        {
                            Serial.uart.Write(Line2Message.Substring(line2Len));
                        }
                    }

                    await Task.Delay(scrollSpeed);
                }

                //if (done) // reset the loop
                //{
                //    line1len = 0;
                //    line2len = 0;
                //    i = 21;
                //    done = !done;

                //    await Task.Delay(replaySpeed);
                //}

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
            /// <summary>
            /// Flashes all the pixels on and off quickly to get the user's attention.
            /// </summary>
            public static void Notify()
            {
                byte[] com = new byte[1] { 0xDB };

                for (int j = 0; j < 2; j++)
                {
                    SetCursorToLine1();
                    for (int i = 0; i < 20; i++)
                        Serial.uart.Write(com, 0, 1);

                    SetCursorToLine2();
                    for (int i = 0; i < 20; i++)
                        Serial.uart.Write(com, 0, 1);

                    Thread.Sleep(50);
                    ClearScreen();

                    if (type == (int)Display.Type.TwentyByFour)
                    {
                        SetCursorToLine3();
                        for (int i = 0; i < 20; i++)
                            Serial.uart.Write(com, 0, 1);

                        SetCursorToLine4();
                        for (int i = 0; i < 20; i++)
                            Serial.uart.Write(com, 0, 1);
                    }
                    Thread.Sleep(50);
                    ClearScreen();
                }
            }
        }

        public class Audio
        {
            static MMDevice device;
                   
            public static void InitAudioStuff()
            {
                MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
                device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
            }

            public static void UpdateVUMeter(ProgressBar left, ProgressBar right)
            {
                int l, r;

                left.Value = (int)(device.AudioMeterInformation.PeakValues[0] * 100);
                //right.Value = (int)(device.AudioMeterInformation.PeakValues[1] * 100);

                l = (int)(device.AudioMeterInformation.PeakValues[0] * 20);
                //rChannel = (int)(device.AudioMeterInformation.PeakValues[1] * 20);
                
                Serial.uart.Write(Display.VUMeterBufferBars[l], 0, l);
                Serial.uart.Write(Display.VUMeterBufferSpaces[l]);
                Display.SetCursorToLine1();
                //Serial.uart.Write(Display.VUMeterBufferBars[rChannel], 0, rChannel);
                //Serial.uart.Write(Display.VUMeterBufferSpaces[rChannel]);
                //Display.SetCursorToLine2();
            }
        }

    }
}
/*
 
 * TODOS
 * 
 * L2R!
 * Option to send a notify before activating a mode or sending a message
 * Repetition count for modes
 * Select display type 20x2 / 20x4
 * write 20x4 options in methods
 *
 * VUMeter 
 * date/time
 * 
 * email notifications? 
 * HKEY_CURRENT_USER\Software\Microsoft\Windows\Curre ntVersion\UnreadMail\MessageCount
 * detected accounts
 * option: select corner on which the mail icon will appear
 * 
 * openhardwaremonitor
 * cpu util Win32_Processor / LoadPercentage  
 * ram util etc graphs? 
 * 
 */