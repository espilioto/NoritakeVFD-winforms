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
        public class Serial
        {
            public static bool connected = false;
            public static SerialPort uart = new SerialPort(); //commands:     ping ;  off ;   rgb r,g,b;  out,bit,0/1;    sta,;   man ;/help ;    
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

            public static void WriteBackspace()
            {
                byte[] command = new byte[1] { 0x08 };
                uart.Write(command, 0, 1);                
                uart.Write(" ");
                uart.Write(command, 0, 1);

            }
            //public static void CursorPosition(byte line, int cursorPosition)
            //{
            //    byte[] command = new byte[6] { 0x1B, 0x5B, line, 0x3B, cursorPosition, 0x48 };
            //    uart.Write(command, 0, 6);
            //}
            public static void ClearScreen()
            {
                byte[] command = new byte[4] { 0x1B, 0x5B, 0x32, 0x4A };
                uart.Write(command, 0, 4);
                SetCursorToLine1();

                Form1.form1.textBox1.Clear();
                Form1.form1.textBox2.Clear();

                Form1.form1.textBox1.Focus();
            }
            public static void SetCursorToLine1()
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, 0x31, 0x3B, 0x31, 0x48 };
                uart.Write(command, 0, 6);

                Form1.form1.textBox1.Focus();
            }
            public static void SetCursorToLine2()
            {
                byte[] command = new byte[6] { 0x1B, 0x5B, 0x32, 0x3B, 0x31, 0x48 };
                uart.Write(command, 0, 6);

                Form1.form1.textBox2.Focus();
            }
        }
    }
}
