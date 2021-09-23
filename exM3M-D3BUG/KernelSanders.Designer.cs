
namespace KernalAccess
{
    partial class KernelSanders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.ReadFloatValue_checkBox = new System.Windows.Forms.CheckBox();
            this.WriteHexValue_checkBox = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PROCESS_TEXT = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OffsetAddress_Label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProcAddrNewValue_Label = new System.Windows.Forms.Label();
            this.WriteValue_Button = new System.Windows.Forms.Button();
            this.ChangeOffsetValue_checkBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressOffset2_textBox = new System.Windows.Forms.TextBox();
            this.OffsetAddress_Label = new System.Windows.Forms.Label();
            this.WriteFloatValue_checkBox = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ProcAddressValu_Label = new System.Windows.Forms.Label();
            this.OffsetValue2Hex_CheckBox = new System.Windows.Forms.CheckBox();
            this.AddrOffset_textBox = new System.Windows.Forms.TextBox();
            this.ProcAddrValue_textBox = new System.Windows.Forms.TextBox();
            this.ReadValue_Button = new System.Windows.Forms.Button();
            this.ProcAddress_textBox = new System.Windows.Forms.TextBox();
            this.ProcStatus_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectProcess_textBox = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessTimer
            // 
            this.ProcessTimer.Enabled = true;
            this.ProcessTimer.Tick += new System.EventHandler(this.ProcessTimer_Tick);
            // 
            // ReadFloatValue_checkBox
            // 
            this.ReadFloatValue_checkBox.AutoSize = true;
            this.ReadFloatValue_checkBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadFloatValue_checkBox.ForeColor = System.Drawing.Color.Red;
            this.ReadFloatValue_checkBox.Location = new System.Drawing.Point(198, 126);
            this.ReadFloatValue_checkBox.Name = "ReadFloatValue_checkBox";
            this.ReadFloatValue_checkBox.Size = new System.Drawing.Size(67, 19);
            this.ReadFloatValue_checkBox.TabIndex = 45;
            this.ReadFloatValue_checkBox.Text = "FLOAT ?";
            this.ReadFloatValue_checkBox.UseVisualStyleBackColor = true;
            // 
            // WriteHexValue_checkBox
            // 
            this.WriteHexValue_checkBox.AutoSize = true;
            this.WriteHexValue_checkBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteHexValue_checkBox.ForeColor = System.Drawing.Color.Red;
            this.WriteHexValue_checkBox.Location = new System.Drawing.Point(11, 200);
            this.WriteHexValue_checkBox.Name = "WriteHexValue_checkBox";
            this.WriteHexValue_checkBox.Size = new System.Drawing.Size(56, 19);
            this.WriteHexValue_checkBox.TabIndex = 43;
            this.WriteHexValue_checkBox.Text = "HEX ?";
            this.WriteHexValue_checkBox.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.PROCESS_TEXT);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 20);
            this.panel5.TabIndex = 42;
            // 
            // PROCESS_TEXT
            // 
            this.PROCESS_TEXT.AutoSize = true;
            this.PROCESS_TEXT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROCESS_TEXT.ForeColor = System.Drawing.Color.Red;
            this.PROCESS_TEXT.Location = new System.Drawing.Point(8, 1);
            this.PROCESS_TEXT.Name = "PROCESS_TEXT";
            this.PROCESS_TEXT.Size = new System.Drawing.Size(64, 15);
            this.PROCESS_TEXT.TabIndex = 2;
            this.PROCESS_TEXT.Text = "PROCESS ?";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(-24, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 20);
            this.panel4.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(31, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "CHANGE VALUE ?";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-15, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 20);
            this.panel3.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADDRESS ?";
            // 
            // OffsetAddress_Label2
            // 
            this.OffsetAddress_Label2.AutoSize = true;
            this.OffsetAddress_Label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffsetAddress_Label2.ForeColor = System.Drawing.Color.Red;
            this.OffsetAddress_Label2.Location = new System.Drawing.Point(0, 4);
            this.OffsetAddress_Label2.Name = "OffsetAddress_Label2";
            this.OffsetAddress_Label2.Size = new System.Drawing.Size(0, 15);
            this.OffsetAddress_Label2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.OffsetAddress_Label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ProcAddrNewValue_Label);
            this.panel2.Location = new System.Drawing.Point(198, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 35);
            this.panel2.TabIndex = 39;
            // 
            // ProcAddrNewValue_Label
            // 
            this.ProcAddrNewValue_Label.AutoSize = true;
            this.ProcAddrNewValue_Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcAddrNewValue_Label.ForeColor = System.Drawing.Color.Blue;
            this.ProcAddrNewValue_Label.Location = new System.Drawing.Point(0, 20);
            this.ProcAddrNewValue_Label.Name = "ProcAddrNewValue_Label";
            this.ProcAddrNewValue_Label.Size = new System.Drawing.Size(0, 15);
            this.ProcAddrNewValue_Label.TabIndex = 12;
            // 
            // WriteValue_Button
            // 
            this.WriteValue_Button.Location = new System.Drawing.Point(117, 172);
            this.WriteValue_Button.Name = "WriteValue_Button";
            this.WriteValue_Button.Size = new System.Drawing.Size(75, 47);
            this.WriteValue_Button.TabIndex = 31;
            this.WriteValue_Button.Text = "WRITE";
            this.WriteValue_Button.UseVisualStyleBackColor = true;
            this.WriteValue_Button.Click += new System.EventHandler(this.WriteValue_Button_Click);
            // 
            // ChangeOffsetValue_checkBox
            // 
            this.ChangeOffsetValue_checkBox.AutoSize = true;
            this.ChangeOffsetValue_checkBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeOffsetValue_checkBox.ForeColor = System.Drawing.Color.Red;
            this.ChangeOffsetValue_checkBox.Location = new System.Drawing.Point(117, 225);
            this.ChangeOffsetValue_checkBox.Name = "ChangeOffsetValue_checkBox";
            this.ChangeOffsetValue_checkBox.Size = new System.Drawing.Size(68, 19);
            this.ChangeOffsetValue_checkBox.TabIndex = 38;
            this.ChangeOffsetValue_checkBox.Text = "Offset ?";
            this.ChangeOffsetValue_checkBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(11, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "OFFSET 2";
            // 
            // AddressOffset2_textBox
            // 
            this.AddressOffset2_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddressOffset2_textBox.Location = new System.Drawing.Point(75, 125);
            this.AddressOffset2_textBox.Name = "AddressOffset2_textBox";
            this.AddressOffset2_textBox.Size = new System.Drawing.Size(36, 20);
            this.AddressOffset2_textBox.TabIndex = 36;
            // 
            // OffsetAddress_Label
            // 
            this.OffsetAddress_Label.AutoSize = true;
            this.OffsetAddress_Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffsetAddress_Label.ForeColor = System.Drawing.Color.Red;
            this.OffsetAddress_Label.Location = new System.Drawing.Point(0, 3);
            this.OffsetAddress_Label.Name = "OffsetAddress_Label";
            this.OffsetAddress_Label.Size = new System.Drawing.Size(0, 15);
            this.OffsetAddress_Label.TabIndex = 6;
            // 
            // WriteFloatValue_checkBox
            // 
            this.WriteFloatValue_checkBox.AutoSize = true;
            this.WriteFloatValue_checkBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteFloatValue_checkBox.ForeColor = System.Drawing.Color.Red;
            this.WriteFloatValue_checkBox.Location = new System.Drawing.Point(11, 225);
            this.WriteFloatValue_checkBox.Name = "WriteFloatValue_checkBox";
            this.WriteFloatValue_checkBox.Size = new System.Drawing.Size(67, 19);
            this.WriteFloatValue_checkBox.TabIndex = 44;
            this.WriteFloatValue_checkBox.Text = "FLOAT ?";
            this.WriteFloatValue_checkBox.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.Controls.Add(this.OffsetAddress_Label);
            this.panel6.Controls.Add(this.ProcAddressValu_Label);
            this.panel6.Location = new System.Drawing.Point(198, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(82, 35);
            this.panel6.TabIndex = 35;
            // 
            // ProcAddressValu_Label
            // 
            this.ProcAddressValu_Label.AutoSize = true;
            this.ProcAddressValu_Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcAddressValu_Label.ForeColor = System.Drawing.Color.Blue;
            this.ProcAddressValu_Label.Location = new System.Drawing.Point(0, 18);
            this.ProcAddressValu_Label.Name = "ProcAddressValu_Label";
            this.ProcAddressValu_Label.Size = new System.Drawing.Size(0, 15);
            this.ProcAddressValu_Label.TabIndex = 8;
            // 
            // OffsetValue2Hex_CheckBox
            // 
            this.OffsetValue2Hex_CheckBox.AutoSize = true;
            this.OffsetValue2Hex_CheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffsetValue2Hex_CheckBox.ForeColor = System.Drawing.Color.Red;
            this.OffsetValue2Hex_CheckBox.Location = new System.Drawing.Point(198, 107);
            this.OffsetValue2Hex_CheckBox.Name = "OffsetValue2Hex_CheckBox";
            this.OffsetValue2Hex_CheckBox.Size = new System.Drawing.Size(56, 19);
            this.OffsetValue2Hex_CheckBox.TabIndex = 34;
            this.OffsetValue2Hex_CheckBox.Text = "HEX ?";
            this.OffsetValue2Hex_CheckBox.UseVisualStyleBackColor = true;
            // 
            // AddrOffset_textBox
            // 
            this.AddrOffset_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddrOffset_textBox.Location = new System.Drawing.Point(75, 99);
            this.AddrOffset_textBox.Name = "AddrOffset_textBox";
            this.AddrOffset_textBox.Size = new System.Drawing.Size(36, 20);
            this.AddrOffset_textBox.TabIndex = 32;
            // 
            // ProcAddrValue_textBox
            // 
            this.ProcAddrValue_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProcAddrValue_textBox.Location = new System.Drawing.Point(11, 174);
            this.ProcAddrValue_textBox.Name = "ProcAddrValue_textBox";
            this.ProcAddrValue_textBox.Size = new System.Drawing.Size(100, 20);
            this.ProcAddrValue_textBox.TabIndex = 30;
            // 
            // ReadValue_Button
            // 
            this.ReadValue_Button.Location = new System.Drawing.Point(117, 71);
            this.ReadValue_Button.Name = "ReadValue_Button";
            this.ReadValue_Button.Size = new System.Drawing.Size(75, 55);
            this.ReadValue_Button.TabIndex = 29;
            this.ReadValue_Button.Text = "READ";
            this.ReadValue_Button.UseVisualStyleBackColor = true;
            this.ReadValue_Button.Click += new System.EventHandler(this.ReadValue_Button_Click);
            // 
            // ProcAddress_textBox
            // 
            this.ProcAddress_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProcAddress_textBox.Location = new System.Drawing.Point(11, 73);
            this.ProcAddress_textBox.Name = "ProcAddress_textBox";
            this.ProcAddress_textBox.Size = new System.Drawing.Size(100, 20);
            this.ProcAddress_textBox.TabIndex = 28;
            // 
            // ProcStatus_Label
            // 
            this.ProcStatus_Label.AutoSize = true;
            this.ProcStatus_Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcStatus_Label.ForeColor = System.Drawing.Color.Red;
            this.ProcStatus_Label.Location = new System.Drawing.Point(117, 26);
            this.ProcStatus_Label.Name = "ProcStatus_Label";
            this.ProcStatus_Label.Size = new System.Drawing.Size(0, 15);
            this.ProcStatus_Label.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(11, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "OFFSET 1";
            // 
            // SelectProcess_textBox
            // 
            this.SelectProcess_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SelectProcess_textBox.Location = new System.Drawing.Point(11, 23);
            this.SelectProcess_textBox.Name = "SelectProcess_textBox";
            this.SelectProcess_textBox.Size = new System.Drawing.Size(100, 20);
            this.SelectProcess_textBox.TabIndex = 26;
            // 
            // KernelSanders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 246);
            this.Controls.Add(this.ReadFloatValue_checkBox);
            this.Controls.Add(this.WriteHexValue_checkBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.WriteValue_Button);
            this.Controls.Add(this.ChangeOffsetValue_checkBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddressOffset2_textBox);
            this.Controls.Add(this.WriteFloatValue_checkBox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.OffsetValue2Hex_CheckBox);
            this.Controls.Add(this.AddrOffset_textBox);
            this.Controls.Add(this.ProcAddrValue_textBox);
            this.Controls.Add(this.ReadValue_Button);
            this.Controls.Add(this.ProcAddress_textBox);
            this.Controls.Add(this.ProcStatus_Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SelectProcess_textBox);
            this.MaximizeBox = false;
            this.Name = "KernelSanders";
            this.Text = "KernelSanders";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer ProcessTimer;
        private System.Windows.Forms.CheckBox ReadFloatValue_checkBox;
        private System.Windows.Forms.CheckBox WriteHexValue_checkBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label PROCESS_TEXT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OffsetAddress_Label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ProcAddrNewValue_Label;
        private System.Windows.Forms.Button WriteValue_Button;
        private System.Windows.Forms.CheckBox ChangeOffsetValue_checkBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressOffset2_textBox;
        private System.Windows.Forms.Label OffsetAddress_Label;
        private System.Windows.Forms.CheckBox WriteFloatValue_checkBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label ProcAddressValu_Label;
        private System.Windows.Forms.CheckBox OffsetValue2Hex_CheckBox;
        private System.Windows.Forms.TextBox AddrOffset_textBox;
        private System.Windows.Forms.TextBox ProcAddrValue_textBox;
        private System.Windows.Forms.Button ReadValue_Button;
        private System.Windows.Forms.TextBox ProcAddress_textBox;
        private System.Windows.Forms.Label ProcStatus_Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SelectProcess_textBox;
    }
}

