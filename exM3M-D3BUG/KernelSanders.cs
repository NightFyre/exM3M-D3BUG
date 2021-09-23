using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace KernalAccess
{
    public partial class KernelSanders : Form
    {
        public Process gameProc;
        public Int32 gamePID;
        public IntPtr hProc;
        public IntPtr baseAddress = IntPtr.Zero;
        public ProcessModule mainModule;
        bool gameRunning;

        public KernelSanders()
        {
            InitializeComponent();
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            Process[] PID = Process.GetProcessesByName(SelectProcess_textBox.Text);
            if (PID.Length > 0)
            {
                gameProc = PID[0];
                gamePID = gameProc.Id;
                hProc = mem.OpenProcess(0x1F0FFF, bInheritHandle: false, gameProc.Id);
                mainModule = gameProc.MainModule;
                baseAddress = mainModule.BaseAddress;
                gameRunning = true;
                ProcStatus_Label.ForeColor = Color.FromArgb(0, 169, 0);
                ProcStatus_Label.BackColor = Color.FromArgb(32, 32, 35);
                ProcStatus_Label.Text = "PROCESS CONNECTED";
                return;
            }
            ProcStatus_Label.Text = "PROCESS NOT DETECTED";
            ProcStatus_Label.ForeColor = Color.FromArgb(255, 255, 255);
            ProcStatus_Label.BackColor = Color.FromArgb(100, 0, 0);
            gameRunning = false;
        }

        private void ReadValue_Button_Click(object sender, EventArgs e)
        {
            if (!gameRunning)
            {
                return;
            }

            //Text Input
            if (ProcAddress_textBox.Text != "")
            {
                //Assign Variables
                byte[] lpBuffer = new byte[8];                                              //Empty 4byte variable for reading
                string AddressLabel = ProcAddress_textBox.Text;                             //User input base address
                int textAddress = (int)(Convert.ToInt64(ProcAddress_textBox.Text, 16));     //Convert our text input to int
                
                //Read memory based on text input
                //Note , this was used for testing with pcsx2. Using static memory
                // remove the comment around "mainModule.Base +"
                mem.ReadProcessMemory(hProc, (UIntPtr)((int)/*mainModule.BaseAddress + */textAddress), lpBuffer, 4L, IntPtr.Zero);   //PCSX2 does not require module base
                
                //Establish variables for text display
                uint baseAddr = BitConverter.ToUInt32(lpBuffer, 0);
                float testFloatAddress = BitConverter.ToSingle(lpBuffer, 0); //FLOAT PATCH
                OffsetAddress_Label.Text = AddressLabel.ToUpper() + " = ";

                if ((!OffsetValue2Hex_CheckBox.Checked) && (!ReadFloatValue_checkBox.Checked))
                {
                    ProcAddressValu_Label.Text = baseAddr.ToString();
                }

                if (OffsetValue2Hex_CheckBox.Checked)
                {
                    ProcAddressValu_Label.Text = baseAddr.ToString("X8");
                }

                if (ReadFloatValue_checkBox.Checked)
                {
                    ProcAddressValu_Label.Text = testFloatAddress.ToString();
                }

                #region OFFSETS

                ///OFFSET 1
                if (AddrOffset_textBox.Text != "")
                {
                    //Convert our input offset from string to int
                    int otextINPUT = int.Parse(AddrOffset_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                    
                    //Add offset + value to get our new base address
                    Int64 newAddress = baseAddr + otextINPUT;
                    
                    //Read memory
                    mem.ReadProcessMemory(hProc, (UIntPtr)((int)newAddress), lpBuffer, 4L, IntPtr.Zero);
                    
                    //Conversions for text display
                    uint offset1 = BitConverter.ToUInt32(lpBuffer, 0);
                    float testFloatOffset = BitConverter.ToSingle(lpBuffer, 0); //FLOAT PATCH
                    OffsetAddress_Label.Text = newAddress.ToString("X") + " = ";

                    if ((!OffsetValue2Hex_CheckBox.Checked) && (!ReadFloatValue_checkBox.Checked))
                    {
                        ProcAddressValu_Label.Text = offset1.ToString();
                    }

                    if (OffsetValue2Hex_CheckBox.Checked)
                    {
                        ProcAddressValu_Label.Text = offset1.ToString("X8");
                    }

                    if (ReadFloatValue_checkBox.Checked)
                    {
                        ProcAddressValu_Label.Text = testFloatOffset.ToString();
                    }
                }

                ///OFFSET 2
                //I figure there is no need to comment this section
                if ((AddrOffset_textBox.Text != "") && (AddressOffset2_textBox.Text != ""))
                {
                    //OFFSET 1
                    int otextINPUT = int.Parse(AddrOffset_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                    int otextINPUT2 = int.Parse(AddressOffset2_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                    Int64 newAddress = baseAddr + otextINPUT;
                    bool OffsetAddressValue = mem.ReadProcessMemory(hProc, (UIntPtr)((int)newAddress), lpBuffer, 4L, IntPtr.Zero);
                    uint offset1 = BitConverter.ToUInt32(lpBuffer, 0);
                    Int64 NewAddress2 = offset1 + otextINPUT2;

                    //OFFSET 2
                    var OffsetAddress2Value = mem.ReadProcessMemory(hProc, (UIntPtr)((int)NewAddress2), lpBuffer, 4L, IntPtr.Zero);
                    uint offset2 = BitConverter.ToUInt32(lpBuffer, 0);
                    float offset2Float = BitConverter.ToSingle(lpBuffer, 0);    //FLOAT PATCH
                    OffsetAddress_Label.Text = NewAddress2.ToString("X") + " = ";

                    if ((!OffsetValue2Hex_CheckBox.Checked) && (!ReadFloatValue_checkBox.Checked))
                    {
                        ProcAddressValu_Label.Text = offset2.ToString();
                    }

                    if (OffsetValue2Hex_CheckBox.Checked)
                    {
                        ProcAddressValu_Label.Text = offset2.ToString("X8");
                    }

                    if (ReadFloatValue_checkBox.Checked)
                    {

                        ProcAddressValu_Label.Text = offset2Float.ToString("F3");
                    }
                }

                //By this point you should understand how to add more if you require it, this is a debug tool
                //However My form design does have some issues , being that you cannot adjust the labels and text inside the panels ( i have not found a way that is)
                //Rhis is due to my removing the text from all labels inside panel to make things look cleaner. .. . this is a very bad practice and thankfully i have learned from it
                //Maybe in the future i will overhaul the form so that it is much easier to adjust, now that i think about it , i could have just made text blank on form load. Live and learn
                #endregion

            }
        }

        private void WriteValue_Button_Click(object sender, EventArgs e)
        {

            if (ProcAddrValue_textBox.Text != "")
            {
                //Write to Offsets
                if ((OffsetAddress_Label.Text != "") && (ChangeOffsetValue_checkBox.Checked))
                {
                    IntPtr lpNumberOfBytesWritten;
                    byte[] Address = new byte[4];
                    string OffsteAddressConversion = OffsetAddress_Label.Text.Replace(" = ", "").Replace(" ", "");
                    int textAddress = (int)(Convert.ToInt32(OffsteAddressConversion, 16));
                    OffsetAddress_Label2.Text = OffsetAddress_Label.Text;

                    if ((!WriteFloatValue_checkBox.Checked) && (!WriteHexValue_checkBox.Checked))
                    {
                        mem.ReadProcessMemory(hProc, (UIntPtr)((int)textAddress), Address, 4L, IntPtr.Zero);
                        int Value = int.Parse(ProcAddrValue_textBox.Text);
                        mem.WriteProcessMemory(hProc, (IntPtr)textAddress, Value, 4L, out lpNumberOfBytesWritten);
                        ProcAddrNewValue_Label.Text = Value.ToString();
                    }

                    if (WriteHexValue_checkBox.Checked)
                    {
                        mem.ReadProcessMemory(hProc, (UIntPtr)((int)textAddress), Address, 4L, IntPtr.Zero);
                        int Value = int.Parse(ProcAddrValue_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                        mem.WriteProcessMemory(hProc, (IntPtr)textAddress, Value, 4L, out lpNumberOfBytesWritten);
                        ProcAddrNewValue_Label.Text = Value.ToString("X8");
                    }

                    if (WriteFloatValue_checkBox.Checked)
                    {
                        mem.ReadProcessMemory(hProc, (UIntPtr)((int)textAddress), Address, 4L, IntPtr.Zero);
                        float Value = float.Parse(ProcAddrValue_textBox.Text);
                        mem.WriteProcessMemory(hProc, (IntPtr)textAddress, Value, 4L, out lpNumberOfBytesWritten);
                        ProcAddrNewValue_Label.Text = Value.ToString("F3");
                    }
                }

                //Write to base address
                else if (AddrOffset_textBox.Text == "")
                {
                    IntPtr lpNumberOfBytesWritten;
                    byte[] Address = new byte[4];
                    int textAddress = (int)(Convert.ToInt32(ProcAddress_textBox.Text, 16));
                    OffsetAddress_Label2.Text = OffsetAddress_Label.Text;

                    if ((!WriteHexValue_checkBox.Checked) && (!WriteFloatValue_checkBox.Checked))
                    {
                        mem.ReadProcessMemory(hProc, (UIntPtr)((int)textAddress), Address, 4L, IntPtr.Zero);
                        int Value = int.Parse(ProcAddrValue_textBox.Text);
                        mem.WriteProcessMemory(hProc, (IntPtr)textAddress, Value, 4L, out lpNumberOfBytesWritten);
                        ProcAddrNewValue_Label.Text = Value.ToString();
                    }

                    if (WriteHexValue_checkBox.Checked)
                    {
                        mem.ReadProcessMemory(hProc, (UIntPtr)((int)textAddress), Address, 4L, IntPtr.Zero);
                        int Value = int.Parse(ProcAddrValue_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                        mem.WriteProcessMemory(hProc, (IntPtr)textAddress, Value, 4L, out lpNumberOfBytesWritten);
                        ProcAddrNewValue_Label.Text = Value.ToString("X8");
                    }

                    if (WriteFloatValue_checkBox.Checked)
                    {
                        mem.ReadProcessMemory(hProc, (UIntPtr)((int)textAddress), Address, 4L, IntPtr.Zero);
                        float Value = float.Parse(ProcAddrValue_textBox.Text);
                        mem.WriteProcessMemory(hProc, (IntPtr)textAddress, Value, 4L, out lpNumberOfBytesWritten);
                        ProcAddrNewValue_Label.Text = Value.ToString("F3");
                    }
                }
            }
        }
    }
}