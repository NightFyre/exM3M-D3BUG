
namespace ExternalTrainerDebugForm
{
    partial class Form1
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
            this.SelectProcess_textBox = new System.Windows.Forms.TextBox();
            this.PROCESS_TEXT = new System.Windows.Forms.Label();
            this.ProcStatus_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcAddress_textBox = new System.Windows.Forms.TextBox();
            this.ReadValue_Button = new System.Windows.Forms.Button();
            this.ProcAddressValu_Label = new System.Windows.Forms.Label();
            this.ProcAddrNewValue_Label = new System.Windows.Forms.Label();
            this.WriteValue_Button = new System.Windows.Forms.Button();
            this.ProcAddrValue_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SelectProcess_textBox
            // 
            this.SelectProcess_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SelectProcess_textBox.Location = new System.Drawing.Point(12, 22);
            this.SelectProcess_textBox.Name = "SelectProcess_textBox";
            this.SelectProcess_textBox.Size = new System.Drawing.Size(100, 20);
            this.SelectProcess_textBox.TabIndex = 1;
            // 
            // PROCESS_TEXT
            // 
            this.PROCESS_TEXT.AutoSize = true;
            this.PROCESS_TEXT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROCESS_TEXT.ForeColor = System.Drawing.Color.Red;
            this.PROCESS_TEXT.Location = new System.Drawing.Point(12, 6);
            this.PROCESS_TEXT.Name = "PROCESS_TEXT";
            this.PROCESS_TEXT.Size = new System.Drawing.Size(64, 15);
            this.PROCESS_TEXT.TabIndex = 2;
            this.PROCESS_TEXT.Text = "PROCESS ?";
            // 
            // ProcStatus_Label
            // 
            this.ProcStatus_Label.AutoSize = true;
            this.ProcStatus_Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcStatus_Label.ForeColor = System.Drawing.Color.Red;
            this.ProcStatus_Label.Location = new System.Drawing.Point(118, 25);
            this.ProcStatus_Label.Name = "ProcStatus_Label";
            this.ProcStatus_Label.Size = new System.Drawing.Size(0, 15);
            this.ProcStatus_Label.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADDRESS ?";
            // 
            // ProcAddress_textBox
            // 
            this.ProcAddress_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProcAddress_textBox.Location = new System.Drawing.Point(12, 71);
            this.ProcAddress_textBox.Name = "ProcAddress_textBox";
            this.ProcAddress_textBox.Size = new System.Drawing.Size(100, 20);
            this.ProcAddress_textBox.TabIndex = 6;
            // 
            // ReadValue_Button
            // 
            this.ReadValue_Button.Location = new System.Drawing.Point(118, 69);
            this.ReadValue_Button.Name = "ReadValue_Button";
            this.ReadValue_Button.Size = new System.Drawing.Size(75, 23);
            this.ReadValue_Button.TabIndex = 7;
            this.ReadValue_Button.Text = "READ";
            this.ReadValue_Button.UseVisualStyleBackColor = true;
            this.ReadValue_Button.Click += new System.EventHandler(this.ReadValue_Button_Click);
            // 
            // ProcAddressValu_Label
            // 
            this.ProcAddressValu_Label.AutoSize = true;
            this.ProcAddressValu_Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcAddressValu_Label.ForeColor = System.Drawing.Color.Red;
            this.ProcAddressValu_Label.Location = new System.Drawing.Point(199, 75);
            this.ProcAddressValu_Label.Name = "ProcAddressValu_Label";
            this.ProcAddressValu_Label.Size = new System.Drawing.Size(0, 15);
            this.ProcAddressValu_Label.TabIndex = 8;
            // 
            // ProcAddrNewValue_Label
            // 
            this.ProcAddrNewValue_Label.AutoSize = true;
            this.ProcAddrNewValue_Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcAddrNewValue_Label.ForeColor = System.Drawing.Color.Red;
            this.ProcAddrNewValue_Label.Location = new System.Drawing.Point(199, 125);
            this.ProcAddrNewValue_Label.Name = "ProcAddrNewValue_Label";
            this.ProcAddrNewValue_Label.Size = new System.Drawing.Size(0, 15);
            this.ProcAddrNewValue_Label.TabIndex = 12;
            // 
            // WriteValue_Button
            // 
            this.WriteValue_Button.Location = new System.Drawing.Point(118, 119);
            this.WriteValue_Button.Name = "WriteValue_Button";
            this.WriteValue_Button.Size = new System.Drawing.Size(75, 23);
            this.WriteValue_Button.TabIndex = 11;
            this.WriteValue_Button.Text = "WRITE";
            this.WriteValue_Button.UseVisualStyleBackColor = true;
            this.WriteValue_Button.Click += new System.EventHandler(this.WriteValue_Button_Click);
            // 
            // ProcAddrValue_textBox
            // 
            this.ProcAddrValue_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProcAddrValue_textBox.Location = new System.Drawing.Point(12, 121);
            this.ProcAddrValue_textBox.Name = "ProcAddrValue_textBox";
            this.ProcAddrValue_textBox.Size = new System.Drawing.Size(100, 20);
            this.ProcAddrValue_textBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "CHANGE VALUE ?";
            // 
            // ProcessTimer
            // 
            this.ProcessTimer.Enabled = true;
            this.ProcessTimer.Tick += new System.EventHandler(this.ProcessTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(258, 151);
            this.Controls.Add(this.ProcAddrNewValue_Label);
            this.Controls.Add(this.WriteValue_Button);
            this.Controls.Add(this.ProcAddrValue_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProcAddressValu_Label);
            this.Controls.Add(this.ReadValue_Button);
            this.Controls.Add(this.ProcAddress_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcStatus_Label);
            this.Controls.Add(this.PROCESS_TEXT);
            this.Controls.Add(this.SelectProcess_textBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "exM3M D3BUG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SelectProcess_textBox;
        private System.Windows.Forms.Label PROCESS_TEXT;
        private System.Windows.Forms.Label ProcStatus_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProcAddress_textBox;
        private System.Windows.Forms.Button ReadValue_Button;
        private System.Windows.Forms.Label ProcAddressValu_Label;
        private System.Windows.Forms.Label ProcAddrNewValue_Label;
        private System.Windows.Forms.Button WriteValue_Button;
        private System.Windows.Forms.TextBox ProcAddrValue_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer ProcessTimer;
    }
}

