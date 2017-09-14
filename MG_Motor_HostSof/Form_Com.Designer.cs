namespace MG_Motor_HostSof
{
    partial class Form_Com
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
            this.label_PortNumber = new System.Windows.Forms.Label();
            this.label_Baud = new System.Windows.Forms.Label();
            this.label_DataBit = new System.Windows.Forms.Label();
            this.label_StopBit = new System.Windows.Forms.Label();
            this.label_Odd = new System.Windows.Forms.Label();
            this.cbx_PortNumber = new System.Windows.Forms.ComboBox();
            this.cbx_Baud = new System.Windows.Forms.ComboBox();
            this.cbx_DataBit = new System.Windows.Forms.ComboBox();
            this.cbx_Stopbit = new System.Windows.Forms.ComboBox();
            this.cbx_Odd = new System.Windows.Forms.ComboBox();
            this.btn_SetupPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_PortNumber
            // 
            this.label_PortNumber.AutoSize = true;
            this.label_PortNumber.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_PortNumber.Location = new System.Drawing.Point(57, 47);
            this.label_PortNumber.Name = "label_PortNumber";
            this.label_PortNumber.Size = new System.Drawing.Size(66, 19);
            this.label_PortNumber.TabIndex = 0;
            this.label_PortNumber.Text = "串口号";
            // 
            // label_Baud
            // 
            this.label_Baud.AutoSize = true;
            this.label_Baud.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Baud.Location = new System.Drawing.Point(57, 92);
            this.label_Baud.Name = "label_Baud";
            this.label_Baud.Size = new System.Drawing.Size(66, 19);
            this.label_Baud.TabIndex = 1;
            this.label_Baud.Text = "波特率";
            // 
            // label_DataBit
            // 
            this.label_DataBit.AutoSize = true;
            this.label_DataBit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DataBit.Location = new System.Drawing.Point(57, 137);
            this.label_DataBit.Name = "label_DataBit";
            this.label_DataBit.Size = new System.Drawing.Size(66, 19);
            this.label_DataBit.TabIndex = 2;
            this.label_DataBit.Text = "数据位";
            // 
            // label_StopBit
            // 
            this.label_StopBit.AutoSize = true;
            this.label_StopBit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_StopBit.Location = new System.Drawing.Point(57, 182);
            this.label_StopBit.Name = "label_StopBit";
            this.label_StopBit.Size = new System.Drawing.Size(66, 19);
            this.label_StopBit.TabIndex = 3;
            this.label_StopBit.Text = "停止位";
            // 
            // label_Odd
            // 
            this.label_Odd.AutoSize = true;
            this.label_Odd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Odd.Location = new System.Drawing.Point(57, 227);
            this.label_Odd.Name = "label_Odd";
            this.label_Odd.Size = new System.Drawing.Size(104, 19);
            this.label_Odd.TabIndex = 4;
            this.label_Odd.Text = "奇偶校验位";
            // 
            // cbx_PortNumber
            // 
            this.cbx_PortNumber.FormattingEnabled = true;
            this.cbx_PortNumber.Location = new System.Drawing.Point(186, 46);
            this.cbx_PortNumber.Name = "cbx_PortNumber";
            this.cbx_PortNumber.Size = new System.Drawing.Size(121, 20);
            this.cbx_PortNumber.TabIndex = 5;
            // 
            // cbx_Baud
            // 
            this.cbx_Baud.FormattingEnabled = true;
            this.cbx_Baud.Location = new System.Drawing.Point(186, 91);
            this.cbx_Baud.Name = "cbx_Baud";
            this.cbx_Baud.Size = new System.Drawing.Size(121, 20);
            this.cbx_Baud.TabIndex = 6;
            // 
            // cbx_DataBit
            // 
            this.cbx_DataBit.FormattingEnabled = true;
            this.cbx_DataBit.Location = new System.Drawing.Point(186, 136);
            this.cbx_DataBit.Name = "cbx_DataBit";
            this.cbx_DataBit.Size = new System.Drawing.Size(121, 20);
            this.cbx_DataBit.TabIndex = 7;
            // 
            // cbx_Stopbit
            // 
            this.cbx_Stopbit.FormattingEnabled = true;
            this.cbx_Stopbit.Location = new System.Drawing.Point(186, 181);
            this.cbx_Stopbit.Name = "cbx_Stopbit";
            this.cbx_Stopbit.Size = new System.Drawing.Size(121, 20);
            this.cbx_Stopbit.TabIndex = 8;
            // 
            // cbx_Odd
            // 
            this.cbx_Odd.FormattingEnabled = true;
            this.cbx_Odd.Location = new System.Drawing.Point(186, 226);
            this.cbx_Odd.Name = "cbx_Odd";
            this.cbx_Odd.Size = new System.Drawing.Size(121, 20);
            this.cbx_Odd.TabIndex = 9;
            // 
            // btn_SetupPort
            // 
            this.btn_SetupPort.Location = new System.Drawing.Point(406, 44);
            this.btn_SetupPort.Name = "btn_SetupPort";
            this.btn_SetupPort.Size = new System.Drawing.Size(75, 23);
            this.btn_SetupPort.TabIndex = 10;
            this.btn_SetupPort.Text = "设置";
            this.btn_SetupPort.UseVisualStyleBackColor = true;
            this.btn_SetupPort.Click += new System.EventHandler(this.btn_SetupPort_Click);
            // 
            // Form_Com
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 286);
            this.Controls.Add(this.btn_SetupPort);
            this.Controls.Add(this.cbx_Odd);
            this.Controls.Add(this.cbx_Stopbit);
            this.Controls.Add(this.cbx_DataBit);
            this.Controls.Add(this.cbx_Baud);
            this.Controls.Add(this.cbx_PortNumber);
            this.Controls.Add(this.label_Odd);
            this.Controls.Add(this.label_StopBit);
            this.Controls.Add(this.label_DataBit);
            this.Controls.Add(this.label_Baud);
            this.Controls.Add(this.label_PortNumber);
            this.Name = "Form_Com";
            this.Text = "Form_Com";
            this.Load += new System.EventHandler(this.Form_Com_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PortNumber;
        private System.Windows.Forms.Label label_Baud;
        private System.Windows.Forms.Label label_DataBit;
        private System.Windows.Forms.Label label_StopBit;
        private System.Windows.Forms.Label label_Odd;
        private System.Windows.Forms.ComboBox cbx_PortNumber;
        private System.Windows.Forms.ComboBox cbx_Baud;
        private System.Windows.Forms.ComboBox cbx_DataBit;
        private System.Windows.Forms.ComboBox cbx_Stopbit;
        private System.Windows.Forms.ComboBox cbx_Odd;
        private System.Windows.Forms.Button btn_SetupPort;
    }
}