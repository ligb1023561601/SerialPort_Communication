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
            this.label7 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_even_amp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_tri_amp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rb_even_posi = new System.Windows.Forms.RadioButton();
            this.rb_even_neg = new System.Windows.Forms.RadioButton();
            this.rb_even_whole = new System.Windows.Forms.RadioButton();
            this.rb_tri_whole = new System.Windows.Forms.RadioButton();
            this.rb_tri_neg = new System.Windows.Forms.RadioButton();
            this.rb_tri_pos = new System.Windows.Forms.RadioButton();
            this.rb_sine_whole = new System.Windows.Forms.RadioButton();
            this.rb_sine_neg = new System.Windows.Forms.RadioButton();
            this.rb_sine_pos = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.Controls.Add(this.rb_even_whole);
            this.groupBox1.Controls.Add(this.rb_even_neg);
            this.groupBox1.Controls.Add(this.rb_even_posi);
            this.groupBox1.Controls.Add(this.tbx_even_amp);
            this.groupBox1.Controls.Add(this.label8);
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
            this.btn_SpdRef.Location = new System.Drawing.Point(679, 48);
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
            this.groupBox2.Controls.Add(this.rb_tri_whole);
            this.groupBox2.Controls.Add(this.tbx_tri_amp);
            this.groupBox2.Controls.Add(this.rb_tri_neg);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.rb_tri_pos);
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
            this.btn_Acc.Location = new System.Drawing.Point(679, 39);
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
            this.groupBox3.Controls.Add(this.rb_sine_whole);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.rb_sine_neg);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.rb_sine_pos);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "以2π为基频进行分频";
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
            "6"});
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
            this.btn_Sin.Location = new System.Drawing.Point(679, 45);
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
            this.groupBox4.Controls.Add(this.label10);
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
            this.groupBox4.Visible = false;
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
            this.btn_Combine.Location = new System.Drawing.Point(679, 45);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "给定幅值";
            // 
            // tbx_even_amp
            // 
            this.tbx_even_amp.Location = new System.Drawing.Point(309, 50);
            this.tbx_even_amp.Name = "tbx_even_amp";
            this.tbx_even_amp.Size = new System.Drawing.Size(100, 21);
            this.tbx_even_amp.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "给定幅值";
            // 
            // tbx_tri_amp
            // 
            this.tbx_tri_amp.Location = new System.Drawing.Point(309, 50);
            this.tbx_tri_amp.Name = "tbx_tri_amp";
            this.tbx_tri_amp.Size = new System.Drawing.Size(100, 21);
            this.tbx_tri_amp.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "以毫秒";
            // 
            // rb_even_posi
            // 
            this.rb_even_posi.AutoSize = true;
            this.rb_even_posi.Location = new System.Drawing.Point(512, 20);
            this.rb_even_posi.Name = "rb_even_posi";
            this.rb_even_posi.Size = new System.Drawing.Size(59, 16);
            this.rb_even_posi.TabIndex = 5;
            this.rb_even_posi.TabStop = true;
            this.rb_even_posi.Text = "正半轴";
            this.rb_even_posi.UseVisualStyleBackColor = true;
            // 
            // rb_even_neg
            // 
            this.rb_even_neg.AutoSize = true;
            this.rb_even_neg.Location = new System.Drawing.Point(512, 46);
            this.rb_even_neg.Name = "rb_even_neg";
            this.rb_even_neg.Size = new System.Drawing.Size(59, 16);
            this.rb_even_neg.TabIndex = 6;
            this.rb_even_neg.TabStop = true;
            this.rb_even_neg.Text = "负半轴";
            this.rb_even_neg.UseVisualStyleBackColor = true;
            // 
            // rb_even_whole
            // 
            this.rb_even_whole.AutoSize = true;
            this.rb_even_whole.Location = new System.Drawing.Point(512, 68);
            this.rb_even_whole.Name = "rb_even_whole";
            this.rb_even_whole.Size = new System.Drawing.Size(59, 16);
            this.rb_even_whole.TabIndex = 7;
            this.rb_even_whole.TabStop = true;
            this.rb_even_whole.Text = "正负轴";
            this.rb_even_whole.UseVisualStyleBackColor = true;
            // 
            // rb_tri_whole
            // 
            this.rb_tri_whole.AutoSize = true;
            this.rb_tri_whole.Location = new System.Drawing.Point(512, 68);
            this.rb_tri_whole.Name = "rb_tri_whole";
            this.rb_tri_whole.Size = new System.Drawing.Size(59, 16);
            this.rb_tri_whole.TabIndex = 10;
            this.rb_tri_whole.TabStop = true;
            this.rb_tri_whole.Text = "正负轴";
            this.rb_tri_whole.UseVisualStyleBackColor = true;
            // 
            // rb_tri_neg
            // 
            this.rb_tri_neg.AutoSize = true;
            this.rb_tri_neg.Location = new System.Drawing.Point(512, 46);
            this.rb_tri_neg.Name = "rb_tri_neg";
            this.rb_tri_neg.Size = new System.Drawing.Size(59, 16);
            this.rb_tri_neg.TabIndex = 9;
            this.rb_tri_neg.TabStop = true;
            this.rb_tri_neg.Text = "负半轴";
            this.rb_tri_neg.UseVisualStyleBackColor = true;
            // 
            // rb_tri_pos
            // 
            this.rb_tri_pos.AutoSize = true;
            this.rb_tri_pos.Location = new System.Drawing.Point(512, 20);
            this.rb_tri_pos.Name = "rb_tri_pos";
            this.rb_tri_pos.Size = new System.Drawing.Size(59, 16);
            this.rb_tri_pos.TabIndex = 8;
            this.rb_tri_pos.TabStop = true;
            this.rb_tri_pos.Text = "正半轴";
            this.rb_tri_pos.UseVisualStyleBackColor = true;
            // 
            // rb_sine_whole
            // 
            this.rb_sine_whole.AutoSize = true;
            this.rb_sine_whole.Location = new System.Drawing.Point(512, 68);
            this.rb_sine_whole.Name = "rb_sine_whole";
            this.rb_sine_whole.Size = new System.Drawing.Size(59, 16);
            this.rb_sine_whole.TabIndex = 13;
            this.rb_sine_whole.TabStop = true;
            this.rb_sine_whole.Text = "正负轴";
            this.rb_sine_whole.UseVisualStyleBackColor = true;
            // 
            // rb_sine_neg
            // 
            this.rb_sine_neg.AutoSize = true;
            this.rb_sine_neg.Location = new System.Drawing.Point(512, 46);
            this.rb_sine_neg.Name = "rb_sine_neg";
            this.rb_sine_neg.Size = new System.Drawing.Size(59, 16);
            this.rb_sine_neg.TabIndex = 12;
            this.rb_sine_neg.TabStop = true;
            this.rb_sine_neg.Text = "负半轴";
            this.rb_sine_neg.UseVisualStyleBackColor = true;
            // 
            // rb_sine_pos
            // 
            this.rb_sine_pos.AutoSize = true;
            this.rb_sine_pos.Location = new System.Drawing.Point(512, 20);
            this.rb_sine_pos.Name = "rb_sine_pos";
            this.rb_sine_pos.Size = new System.Drawing.Size(59, 16);
            this.rb_sine_pos.TabIndex = 11;
            this.rb_sine_pos.TabStop = true;
            this.rb_sine_pos.Text = "正半轴";
            this.rb_sine_pos.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.RadioButton rb_even_whole;
        private System.Windows.Forms.RadioButton rb_even_neg;
        private System.Windows.Forms.RadioButton rb_even_posi;
        private System.Windows.Forms.TextBox tbx_even_amp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_tri_whole;
        private System.Windows.Forms.TextBox tbx_tri_amp;
        private System.Windows.Forms.RadioButton rb_tri_neg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rb_tri_pos;
        private System.Windows.Forms.RadioButton rb_sine_whole;
        private System.Windows.Forms.RadioButton rb_sine_neg;
        private System.Windows.Forms.RadioButton rb_sine_pos;
        private System.Windows.Forms.Label label10;
    }
}