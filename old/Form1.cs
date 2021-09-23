using System;
using System.Diagnostics;
using Binarysharp.MemoryManagement;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace ExternalTrainerDebugForm
{
    public partial class Form1 : Form
    {
        MemorySharp m = null;
        bool ProcessConnected = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            Process[] M3M_D3BUG = Process.GetProcessesByName(SelectProcess_textBox.Text);
            if (M3M_D3BUG.Length > 0)
            {
                ProcStatus_Label.Text = "PROCESS CONNECTED";
                ProcessConnected = true;
                ProcStatus_Label.ForeColor = Color.FromArgb(0, 169, 0);
                ProcStatus_Label.BackColor = Color.FromArgb(32, 32, 35);
                m = new MemorySharp(Process.GetProcessesByName(SelectProcess_textBox.Text).First());
                return;
            }
            ProcStatus_Label.Text = "PROCESS NOT DETECTED";
            ProcStatus_Label.ForeColor = Color.FromArgb(255, 255, 255);
            ProcStatus_Label.BackColor = Color.FromArgb(100, 0, 0);
            ProcessConnected = false;
        }

        private void ReadValue_Button_Click(object sender, EventArgs e)
        {
            if (!ProcessConnected)
            {
                return;
            }

            if (ProcAddress_textBox.Text != "")
            {
                string AddressLabel = ProcAddress_textBox.Text;
                IntPtr Address = new IntPtr(Convert.ToInt32(ProcAddress_textBox.Text, 16));
                var AddressValue = m.Read<int>(Address, false);
                var AddressValueFloat = m.Read<float>(Address, false);
                OffsetAddress_Label.Text = AddressLabel.ToUpper() + " = ";

                #region STATIC ADDRESSES
                //Prints Decimal Value
                if ((!ReadFloatValue_checkBox.Checked) && (!OffsetValue2Hex_CheckBox.Checked))
                { 
                    ProcAddressValu_Label.Text = AddressValue.ToString(); 
                }
                //Prints Hex Value to label
                if (OffsetValue2Hex_CheckBox.Checked)
                {
                    ProcAddressValu_Label.Text = AddressValue.ToString("X");
                }
                //Prints Float value to label
                if (ReadFloatValue_checkBox.Checked)
                { 
                    ProcAddressValu_Label.Text = AddressValueFloat.ToString();
                }
                #endregion

                #region OFFSETS
                
                ///OFFSET 1
                if (AddrOffset_textBox.Text != "")
                {
                    //Turns Address Value into Its own Address
                    var PointerOffset = new IntPtr(AddressValue);

                    //Parses the Textbox input to Hex
                    var Offset = int.Parse(AddrOffset_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                    
                    //Do math
                    var NewAddress = PointerOffset + Offset;

                    //Get Value of our new address
                    var OffsetAddressValue = m.Read<int>(NewAddress, false);
                    float OffsetFloatValue = m.Read<float>(NewAddress, false);

                    //Print Offset Address to label
                    OffsetAddress_Label.Text = NewAddress.ToString("X") + " = ";


                    //Print Decimal Value to label
                    if ((!OffsetValue2Hex_CheckBox.Checked) && (!ReadFloatValue_checkBox.Checked))
                    {
                        ProcAddressValu_Label.Text = OffsetAddressValue.ToString();
                    }
                    
                    //Print 4byte HEX Value to label
                    if (OffsetValue2Hex_CheckBox.Checked)
                    {
                        ProcAddressValu_Label.Text = OffsetAddressValue.ToString("X");
                    }

                    //Print Float Value to Label
                    if (ReadFloatValue_checkBox.Checked)
                    {
                        ProcAddressValu_Label.Text = OffsetFloatValue.ToString();
                    }


                    ///OFFSET 2
                    if ((AddrOffset_textBox.Text != "") && (AddressOffset2_textBox.Text != ""))
                    {
                        var PointerOffset2 = new IntPtr(OffsetAddressValue);
                        var Offset2 = int.Parse(AddressOffset2_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                        var NewAddress2 = PointerOffset2 + Offset2;
                        var OffsetAddress2Value = m.Read<int>(NewAddress2, false);
                        var OffsetAddress2FloatValue = m.Read<float>(NewAddress2, false);
                        OffsetAddress_Label.Text = NewAddress2.ToString("X") + " = ";
                        if ((!OffsetValue2Hex_CheckBox.Checked) && (!ReadFloatValue_checkBox.Checked))
                        {
                            ProcAddressValu_Label.Text = OffsetAddress2Value.ToString();
                        }
                        if (OffsetValue2Hex_CheckBox.Checked)
                        {
                            ProcAddressValu_Label.Text = OffsetAddress2Value.ToString("X");
                        }
                        if (ReadFloatValue_checkBox.Checked)
                        {
                            ProcAddressValu_Label.Text = OffsetAddress2FloatValue.ToString();
                        }
                    }
                }

                #endregion

            }
        }

        private void WriteValue_Button_Click(object sender, EventArgs e)
        {
            if (ProcAddrValue_textBox.Text != "")
            {
                ///WRITE TO OFFSETS
                if ((OffsetAddress_Label.Text != "") && (ChangeOffsetValue_checkBox.Checked))
                {
                    string OffsetLabel = OffsetAddress_Label.Text;
                    string OffsetAddressConversion = OffsetAddress_Label.Text.Replace(" = ", "").Replace(" ", "");
                    IntPtr OffsetAddress = new IntPtr(Convert.ToUInt32(OffsetAddressConversion, 16));
                    OffsetAddress_Label2.Text = OffsetLabel;

                    if ((!WriteFloatValue_checkBox.Checked) && (!WriteHexValue_checkBox.Checked))
                    {
                        var OffsetValue = int.Parse(ProcAddrValue_textBox.Text);
                        m.Write<int>(OffsetAddress, OffsetValue, false);
                        ProcAddrNewValue_Label.Text = OffsetValue.ToString();
                    }

                    if (WriteHexValue_checkBox.Checked)
                    {
                        //Parses the Textbox input to Hex
                        var HexValue = int.Parse(ProcAddrValue_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                        m.Write<int>(OffsetAddress, HexValue, false);
                        ProcAddrNewValue_Label.Text = HexValue.ToString("X");
                    }

                    if (WriteFloatValue_checkBox.Checked)
                    {
                        float FloatValue = int.Parse(ProcAddrValue_textBox.Text);
                        m.Write<float>(OffsetAddress, FloatValue, false);
                        ProcAddrNewValue_Label.Text = FloatValue.ToString();
                    }
                    
                }
                else if (AddrOffset_textBox.Text == "")
                {
                    ///WRITE TO STATIC ADDRESSES
                    string AddressLabel = OffsetAddress_Label.Text;
                    IntPtr Address = new IntPtr(Convert.ToInt32(ProcAddress_textBox.Text, 16));
                    OffsetAddress_Label2.Text = AddressLabel;

                    ///Write Decimal Value
                    if ((!WriteHexValue_checkBox.Checked) && (!WriteFloatValue_checkBox.Checked))
                    {
                        var Value = int.Parse(ProcAddrValue_textBox.Text);
                        m.Write<int>(Address, Value, false);
                        ProcAddrNewValue_Label.Text = Value.ToString();
                    }

                    ///Write 4byte Hex Value
                    if (WriteHexValue_checkBox.Checked)
                    {
                        var HexValue = int.Parse(ProcAddrValue_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                        m.Write<int>(Address, HexValue, false);
                        ProcAddrNewValue_Label.Text = HexValue.ToString("X");
                    }

                    ///Write Float Value
                    if (WriteFloatValue_checkBox.Checked)
                    {
                        float FloatValue = int.Parse(ProcAddrValue_textBox.Text);
                        m.Write<float>(Address, FloatValue, false);
                        ProcAddrNewValue_Label.Text = FloatValue.ToString();
                    }
                }
            }
        }
    }
}
