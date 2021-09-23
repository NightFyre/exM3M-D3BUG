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

            if (ProcAddress_textBox.Text != "")
            {
                byte[] lpBuffer = new byte[8];
                string AddressLabel = ProcAddress_textBox.Text;
                var address = ProcAddress_textBox.Text;
                int textAddress = (int)(Convert.ToInt64(ProcAddress_textBox.Text, 16));
                var AddressValue = mem.ReadProcessMemory(hProc, (UIntPtr)((int)/*mainModule.BaseAddress + */textAddress), lpBuffer, 4L, IntPtr.Zero);   //PCSX2 does not require module base
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
                    var otextINPUT = int.Parse(AddrOffset_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                    var newAddress = baseAddr + otextINPUT;
                    var OffsetAddressValue = mem.ReadProcessMemory(hProc, (UIntPtr)((int)newAddress), lpBuffer, 4L, IntPtr.Zero);
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
                if ((AddrOffset_textBox.Text != "") && (AddressOffset2_textBox.Text != ""))
                {
                    //OFFSET 1
                    var otextINPUT = int.Parse(AddrOffset_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                    var otextINPUT2 = int.Parse(AddressOffset2_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                    var newAddress = baseAddr + otextINPUT;
                    var OffsetAddressValue = mem.ReadProcessMemory(hProc, (UIntPtr)((int)newAddress), lpBuffer, 4L, IntPtr.Zero);
                    uint offset1 = BitConverter.ToUInt32(lpBuffer, 0);
                    var NewAddress2 = offset1 + otextINPUT2;

                    //OFFSET 2
                    var OffsetAddress2Value = mem.ReadProcessMemory(hProc, (UIntPtr)((int)NewAddress2), lpBuffer, 4L, IntPtr.Zero);
                    uint offset2 = BitConverter.ToUInt32(lpBuffer, 0);
                    float offset2Float = BitConverter.ToSingle(lpBuffer, 0);    //FLOAT PATCH
                    OffsetAddress_Label.Text = NewAddress2.ToString("X") + " = ";

                    //Been a little bit , but after working with C++ some more I was able to come back to this and easily spot the error.
                    //I will be coming back to make some further adjustments but I Might as well push this with the updated method.
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
                #endregion

            }
        }

        private void WriteValue_Button_Click(object sender, EventArgs e)
        {
            //Write to Offsets
            if (ProcAddrValue_textBox.Text != "")
            {
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
                        var Value = int.Parse(ProcAddrValue_textBox.Text);
                        mem.WriteProcessMemory(hProc, (IntPtr)textAddress, Value, 4L, out lpNumberOfBytesWritten);
                        ProcAddrNewValue_Label.Text = Value.ToString();
                    }

                    if (WriteHexValue_checkBox.Checked)
                    {
                        mem.ReadProcessMemory(hProc, (UIntPtr)((int)textAddress), Address, 4L, IntPtr.Zero);
                        var Value = int.Parse(ProcAddrValue_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                        mem.WriteProcessMemory(hProc, (IntPtr)textAddress, Value, 4L, out lpNumberOfBytesWritten);
                        ProcAddrNewValue_Label.Text = Value.ToString("X8");
                    }

                    if (WriteFloatValue_checkBox.Checked)
                    {
                        mem.ReadProcessMemory(hProc, (UIntPtr)((int)textAddress), Address, 4L, IntPtr.Zero);
                        var Value = float.Parse(ProcAddrValue_textBox.Text);
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
                        var Value = int.Parse(ProcAddrValue_textBox.Text);
                        mem.WriteProcessMemory(hProc, (IntPtr)textAddress, Value, 4L, out lpNumberOfBytesWritten);
                        ProcAddrNewValue_Label.Text = Value.ToString();
                    }

                    if (WriteHexValue_checkBox.Checked)
                    {
                        mem.ReadProcessMemory(hProc, (UIntPtr)((int)textAddress), Address, 4L, IntPtr.Zero);
                        var Value = int.Parse(ProcAddrValue_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                        mem.WriteProcessMemory(hProc, (IntPtr)textAddress, Value, 4L, out lpNumberOfBytesWritten);
                        ProcAddrNewValue_Label.Text = Value.ToString("X8");
                    }

                    if (WriteFloatValue_checkBox.Checked)
                    {
                        mem.ReadProcessMemory(hProc, (UIntPtr)((int)textAddress), Address, 4L, IntPtr.Zero);
                        var Value = float.Parse(ProcAddrValue_textBox.Text);
                        mem.WriteProcessMemory(hProc, (IntPtr)textAddress, Value, 4L, out lpNumberOfBytesWritten);
                        ProcAddrNewValue_Label.Text = Value.ToString("F3");
                    }
                }
            }
        }
    }
}