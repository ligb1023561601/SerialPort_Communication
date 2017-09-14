namespace MG_Motor_HostSof
{
    partial class Form_Mode
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SpdRef = new System.Windows.Forms.Button();
            this.tbx_SpdRef = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Acc = new System.Windows.Forms.Button();
            this.tbx_Acc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Sin = new System.Windows.Forms.Button();
            this.tbx_SinPeak = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbx_SpdRefTime = new System.Windows.Forms.TextBox();
            this.btn_Combine = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_Combine = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider_SpdRef = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Fre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Acc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Combine = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_SpdRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Fre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Combine)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_SpdRef);
            this.groupBox1.Controls.Add(this.tbx_SpdRef);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "匀速模式（1）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "给定转速";
            // 
            // btn_SpdRef
            // 
            this.btn_SpdRef.Location = new System.Drawing.Point(285, 48);
            this.btn_SpdRef.Name = "btn_SpdRef";
            this.btn_SpdRef.Size = new System.Drawing.Size(75, 23);
            this.btn_SpdRef.TabIndex = 1;
            this.btn_SpdRef.Text = "匀速工作";
            this.btn_SpdRef.UseVisualStyleBackColor = true;
            this.btn_SpdRef.Click += new System.EventHandler(this.btn_SpdRef_Click);
            // 
            // tbx_SpdRef
            // 
            this.tbx_SpdRef.Location = new System.Drawing.Point(116, 50);
            this.tbx_SpdRef.Name = "tbx_SpdRef";
            this.tbx_SpdRef.Size = new System.Drawing.Size(100, 21);
            this.tbx_SpdRef.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_Acc);
            this.groupBox2.Controls.Add(this.tbx_Acc);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "匀加/减速模式（2）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "给定加速度";
            // 
            // btn_Acc
            // 
            this.btn_Acc.Location = new System.Drawing.Point(285, 50);
            this.btn_Acc.Name = "btn_Acc";
            this.btn_Acc.Size = new System.Drawing.Size(75, 23);
            this.btn_Acc.TabIndex = 1;
            this.btn_Acc.Text = "匀加/减速工作";
            this.btn_Acc.UseVisualStyleBackColor = true;
            this.btn_Acc.Click += new System.EventHandler(this.btn_Acc_Click);
            // 
            // tbx_Acc
            // 
            this.tbx_Acc.Location = new System.Drawing.Point(116, 50);
            this.tbx_Acc.Name = "tbx_Acc";
            this.tbx_Acc.Size = new System.Drawing.Size(100, 21);
            this.tbx_Acc.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btn_Sin);
            this.groupBox3.Controls.Add(this.tbx_SinPeak);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "正弦跟踪模式（3）";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox1.Location = new System.Drawing.Point(309, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "给定频率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "给定幅值";
            // 
            // btn_Sin
            // 
            this.btn_Sin.Location = new System.Drawing.Point(464, 48);
            this.btn_Sin.Name = "btn_Sin";
            this.btn_Sin.Size = new System.Drawing.Size(75, 23);
            this.btn_Sin.TabIndex = 1;
            this.btn_Sin.Text = "正弦跟踪";
            this.btn_Sin.UseVisualStyleBackColor = true;
            this.btn_Sin.Click += new System.EventHandler(this.btn_Sin_Click);
            // 
            // tbx_SinPeak
            // 
            this.tbx_SinPeak.Location = new System.Drawing.Point(116, 50);
            this.tbx_SinPeak.Name = "tbx_SinPeak";
            this.tbx_SinPeak.Size = new System.Drawing.Size(100, 21);
            this.tbx_SinPeak.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbx_SpdRefTime);
            this.groupBox4.Controls.Add(this.btn_Combine);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbx_Combine);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(780, 110);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "组合模式";
            // 
            // tbx_SpdRefTime
            // 
            this.tbx_SpdRefTime.Location = new System.Drawing.Point(330, 47);
            this.tbx_SpdRefTime.Name = "tbx_SpdRefTime";
            this.tbx_SpdRefTime.Size = new System.Drawing.Size(100, 21);
            this.tbx_SpdRefTime.TabIndex = 8;
            // 
            // btn_Combine
            // 
            this.btn_Combine.Location = new System.Drawing.Point(464, 48);
            this.btn_Combine.Name = "btn_Combine";
            this.btn_Combine.Size = new System.Drawing.Size(75, 23);
            this.btn_Combine.TabIndex = 1;
            this.btn_Combine.Text = "组合工作";
            this.btn_Combine.UseVisualStyleBackColor = true;
            this.btn_Combine.Click += new System.EventHandler(this.btn_Combine_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "切换间隔";
            // 
            // tbx_Combine
            // 
            this.tbx_Combine.Location = new System.Drawing.Point(116, 50);
            this.tbx_Combine.Name = "tbx_Combine";
            this.tbx_Combine.Size = new System.Drawing.Size(100, 21);
            this.tbx_Combine.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "组合顺序";
            // 
            // errorProvider_SpdRef
            // 
            this.errorProvider_SpdRef.ContainerControl = this;
            // 
            // errorProvider_Fre
            // 
            this.errorProvider_Fre.ContainerControl = this;
            // 
            // errorProvider_Acc
            // 
            this.errorProvider_Acc.ContainerControl = this;
            // 
            // errorProvider_Combine
            // 
            this.errorProvider_Combine.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "以1.85π为基频进行分频";
            // 
            // Form_Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 459);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Mode";
            this.Text = "Form_Mode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_SpdRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Fre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Combine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SpdRef;
        private System.Windows.Forms.TextBox tbx_SpdRef;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Acc;
        private System.Windows.Forms.TextBox tbx_Acc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Sin;
        private System.Windows.Forms.TextBox tbx_SinPeak;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Combine;
        private System.Windows.Forms.TextBox tbx_SpdRefTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_Combine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider_SpdRef;
        private System.Windows.Forms.ErrorProvider errorProvider_Fre;
        private System.Windows.Forms.ErrorProvider errorProvider_Acc;
        private System.Windows.Forms.ErrorProvider errorProvider_Combine;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}