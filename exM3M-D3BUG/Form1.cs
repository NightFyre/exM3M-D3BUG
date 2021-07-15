using System;
using System.Diagnostics;
using Binarysharp.MemoryManagement;
using System.Windows.Forms;
using System.Linq;

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
                m = new MemorySharp(Process.GetProcessesByName(SelectProcess_textBox.Text).First());
                return;
            }
            ProcStatus_Label.Text = "PROCESS NOT DETECTED";
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
                IntPtr Address = new IntPtr(Convert.ToInt32(ProcAddress_textBox.Text, 16));
                var AddressValue = m.Read<int>(Address, false);
                string DecimalAddressValue = m.Read<int>(Address, false).ToString();
                ProcAddressValu_Label.Text = DecimalAddressValue;


                //Added Support for Offsets
                if (AddrOffset_textBox.Text != "")
                {
                    //Turns Address Value into Its own Address
                    var PointerOffset = new IntPtr(AddressValue);

                    //Parses the Textbox input to Hex
                    var Offset = int.Parse(AddrOffset_textBox.Text, System.Globalization.NumberStyles.HexNumber);
                    
                    //Do math
                    var NewAddress = PointerOffset + Offset;
                    
                    //Get Value of our new address
                    var OffsetAddressValue = m.Read<int>(NewAddress, false).ToString();
                    
                    //Print Value to label
                    ProcAddressValu_Label.Text = OffsetAddressValue;
                }

            }
        }

        private void WriteValue_Button_Click(object sender, EventArgs e)
        {
            if (ProcAddrValue_textBox.Text != "")
            {
                IntPtr Address = new IntPtr(Convert.ToInt32(ProcAddress_textBox.Text, 16));
                var Value = int.Parse(ProcAddrValue_textBox.Text);
                m.Write<int>(Address, Value, false);
                ProcAddrNewValue_Label.Text = Value.ToString();

                //Will add support to write to offsets at a later date
            }
        }
    }
}
