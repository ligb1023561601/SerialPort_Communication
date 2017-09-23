namespace MG_Motor_HostSof
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chart_Spd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清除数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回上一级缩放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts_label_PortState = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_label_ReceCnt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_label_SendCnt = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_PortSet = new System.Windows.Forms.Button();
            this.btn_PortConn = new System.Windows.Forms.Button();
            this.btn_ModeSelect = new System.Windows.Forms.Button();
            this.btn_EnableMotor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DataRecord = new System.Windows.Forms.Button();
            this.label_Force = new System.Windows.Forms.Label();
            this.label_Torque = new System.Windows.Forms.Label();
            this.label_PF = new System.Windows.Forms.Label();
            this.label_Spd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer_RefreshChart = new System.Windows.Forms.Timer(this.components);
            this.timerListen = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer_Combine = new System.Windows.Forms.Timer(this.components);
            this.chart_Torqe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip_spd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_torque = new System.Windows.Forms.ToolTip(this.components);
            this.btn_SetOrigin = new System.Windows.Forms.Button();
            this.chart_Angle = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Force = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip_Angle = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Force = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_back_origin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Spd)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Torqe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Force)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1387, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("方正等线", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "水翼实验系统操作界面";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Location = new System.Drawing.Point(1353, -2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(32, 30);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Help.BackgroundImage")));
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Help.Location = new System.Drawing.Point(1324, -2);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(32, 30);
            this.btn_Help.TabIndex = 3;
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // chart_Spd
            // 
            this.chart_Spd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_Spd.BackColor = System.Drawing.Color.Gainsboro;
            this.chart_Spd.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.Interval = 1E-05D;
            chartArea1.Name = "ChartArea1";
            this.chart_Spd.ChartAreas.Add(chartArea1);
            this.chart_Spd.ContextMenuStrip = this.contextMenuStrip1;
            legend1.Name = "Legend1";
            this.chart_Spd.Legends.Add(legend1);
            this.chart_Spd.Location = new System.Drawing.Point(3, 3);
            this.chart_Spd.Name = "chart_Spd";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "转速";
            series1.Name = "Series1";
            this.chart_Spd.Series.Add(series1);
            this.chart_Spd.Size = new System.Drawing.Size(502, 362);
            this.chart_Spd.TabIndex = 5;
            this.chart_Spd.Text = "chart1";
            this.chart_Spd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_Spd_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除数据ToolStripMenuItem,
            this.返回上一级缩放ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 48);
            // 
            // 清除数据ToolStripMenuItem
            // 
            this.清除数据ToolStripMenuItem.Name = "清除数据ToolStripMenuItem";
            this.清除数据ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.清除数据ToolStripMenuItem.Text = "清除数据";
            this.清除数据ToolStripMenuItem.Click += new System.EventHandler(this.清除数据ToolStripMenuItem_Click);
            // 
            // 返回上一级缩放ToolStripMenuItem
            // 
            this.返回上一级缩放ToolStripMenuItem.Name = "返回上一级缩放ToolStripMenuItem";
            this.返回上一级缩放ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.返回上一级缩放ToolStripMenuItem.Text = "返回上一级缩放";
            this.返回上一级缩放ToolStripMenuItem.Click += new System.EventHandler(this.返回上一级缩放ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_label_PortState,
            this.ts_label_ReceCnt,
            this.ts_label_SendCnt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 879);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1386, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts_label_PortState
            // 
            this.ts_label_PortState.Name = "ts_label_PortState";
            this.ts_label_PortState.Size = new System.Drawing.Size(86, 17);
            this.ts_label_PortState.Text = "Disconnected";
            // 
            // ts_label_ReceCnt
            // 
            this.ts_label_ReceCnt.Name = "ts_label_ReceCnt";
            this.ts_label_ReceCnt.Size = new System.Drawing.Size(99, 17);
            this.ts_label_ReceCnt.Text = "已接收数据帧：0";
            // 
            // ts_label_SendCnt
            // 
            this.ts_label_SendCnt.Name = "ts_label_SendCnt";
            this.ts_label_SendCnt.Size = new System.Drawing.Size(99, 17);
            this.ts_label_SendCnt.Text = "已发送数据帧：0";
            // 
            // btn_PortSet
            // 
            this.btn_PortSet.Location = new System.Drawing.Point(238, 179);
            this.btn_PortSet.Name = "btn_PortSet";
            this.btn_PortSet.Size = new System.Drawing.Size(75, 23);
            this.btn_PortSet.TabIndex = 8;
            this.btn_PortSet.Text = "串口设置";
            this.btn_PortSet.UseVisualStyleBackColor = true;
            this.btn_PortSet.Click += new System.EventHandler(this.btn_PortSet_Click);
            // 
            // btn_PortConn
            // 
            this.btn_PortConn.Location = new System.Drawing.Point(238, 221);
            this.btn_PortConn.Name = "btn_PortConn";
            this.btn_PortConn.Size = new System.Drawing.Size(75, 23);
            this.btn_PortConn.TabIndex = 9;
            this.btn_PortConn.Text = "连接串口";
            this.btn_PortConn.UseVisualStyleBackColor = true;
            this.btn_PortConn.Click += new System.EventHandler(this.btn_PortConn_Click);
            // 
            // btn_ModeSelect
            // 
            this.btn_ModeSelect.Enabled = false;
            this.btn_ModeSelect.Location = new System.Drawing.Point(31, 335);
            this.btn_ModeSelect.Name = "btn_ModeSelect";
            this.btn_ModeSelect.Size = new System.Drawing.Size(102, 52);
            this.btn_ModeSelect.TabIndex = 10;
            this.btn_ModeSelect.Text = "模式选择";
            this.btn_ModeSelect.UseVisualStyleBackColor = true;
            this.btn_ModeSelect.Click += new System.EventHandler(this.btn_ModeSelect_Click);
            // 
            // btn_EnableMotor
            // 
            this.btn_EnableMotor.Enabled = false;
            this.btn_EnableMotor.Location = new System.Drawing.Point(238, 335);
            this.btn_EnableMotor.Name = "btn_EnableMotor";
            this.btn_EnableMotor.Size = new System.Drawing.Size(102, 52);
            this.btn_EnableMotor.TabIndex = 11;
            this.btn_EnableMotor.Text = "电机使能";
            this.btn_EnableMotor.UseVisualStyleBackColor = true;
            this.btn_EnableMotor.Click += new System.EventHandler(this.btn_EnableMotor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(57, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "转速";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(57, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "功角";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(57, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "力";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(57, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "转矩";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btn_DataRecord);
            this.groupBox1.Controls.Add(this.label_Force);
            this.groupBox1.Controls.Add(this.label_Torque);
            this.groupBox1.Controls.Add(this.label_PF);
            this.groupBox1.Controls.Add(this.label_Spd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 461);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态栏";
            // 
            // btn_DataRecord
            // 
            this.btn_DataRecord.Enabled = false;
            this.btn_DataRecord.Location = new System.Drawing.Point(226, 13);
            this.btn_DataRecord.Name = "btn_DataRecord";
            this.btn_DataRecord.Size = new System.Drawing.Size(114, 38);
            this.btn_DataRecord.TabIndex = 20;
            this.btn_DataRecord.Text = "记录数据";
            this.btn_DataRecord.UseVisualStyleBackColor = true;
            this.btn_DataRecord.Click += new System.EventHandler(this.btn_DataRecord_Click);
            // 
            // label_Force
            // 
            this.label_Force.AutoSize = true;
            this.label_Force.Location = new System.Drawing.Point(188, 392);
            this.label_Force.Name = "label_Force";
            this.label_Force.Size = new System.Drawing.Size(54, 21);
            this.label_Force.TabIndex = 19;
            this.label_Force.Text = "-- N";
            // 
            // label_Torque
            // 
            this.label_Torque.AutoSize = true;
            this.label_Torque.Location = new System.Drawing.Point(188, 288);
            this.label_Torque.Name = "label_Torque";
            this.label_Torque.Size = new System.Drawing.Size(86, 21);
            this.label_Torque.TabIndex = 18;
            this.label_Torque.Text = "-- N·m";
            // 
            // label_PF
            // 
            this.label_PF.AutoSize = true;
            this.label_PF.Location = new System.Drawing.Point(188, 184);
            this.label_PF.Name = "label_PF";
            this.label_PF.Size = new System.Drawing.Size(64, 21);
            this.label_PF.TabIndex = 17;
            this.label_PF.Text = "-- °";
            // 
            // label_Spd
            // 
            this.label_Spd.AutoSize = true;
            this.label_Spd.Location = new System.Drawing.Point(188, 80);
            this.label_Spd.Name = "label_Spd";
            this.label_Spd.Size = new System.Drawing.Size(76, 21);
            this.label_Spd.TabIndex = 16;
            this.label_Spd.Text = "-- rpm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(146, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "●";
            // 
            // timer_RefreshChart
            // 
            this.timer_RefreshChart.Interval = 200;
            this.timer_RefreshChart.Tick += new System.EventHandler(this.timer_RefreshChart_Tick);
            // 
            // timerListen
            // 
            this.timerListen.Interval = 800;
            this.timerListen.Tick += new System.EventHandler(this.timerListen_Tick);
            // 
            // timer_Combine
            // 
            this.timer_Combine.Tick += new System.EventHandler(this.timer_Combine_Tick);
            // 
            // chart_Torqe
            // 
            this.chart_Torqe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_Torqe.BackColor = System.Drawing.Color.Gainsboro;
            this.chart_Torqe.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorY.Interval = 1E-05D;
            chartArea2.Name = "ChartArea1";
            this.chart_Torqe.ChartAreas.Add(chartArea2);
            this.chart_Torqe.ContextMenuStrip = this.contextMenuStrip1;
            legend2.Name = "Legend1";
            this.chart_Torqe.Legends.Add(legend2);
            this.chart_Torqe.Location = new System.Drawing.Point(3, 371);
            this.chart_Torqe.Name = "chart_Torqe";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.LegendText = "转矩";
            series2.Name = "Series1";
            this.chart_Torqe.Series.Add(series2);
            this.chart_Torqe.Size = new System.Drawing.Size(502, 362);
            this.chart_Torqe.TabIndex = 18;
            this.chart_Torqe.Text = "chart1";
            this.chart_Torqe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_Torqe_MouseMove);
            // 
            // btn_SetOrigin
            // 
            this.btn_SetOrigin.Enabled = false;
            this.btn_SetOrigin.Location = new System.Drawing.Point(139, 335);
            this.btn_SetOrigin.Name = "btn_SetOrigin";
            this.btn_SetOrigin.Size = new System.Drawing.Size(42, 52);
            this.btn_SetOrigin.TabIndex = 19;
            this.btn_SetOrigin.Text = "定位原点";
            this.btn_SetOrigin.UseVisualStyleBackColor = true;
            this.btn_SetOrigin.Click += new System.EventHandler(this.btn_SetOrigin_Click);
            // 
            // chart_Angle
            // 
            this.chart_Angle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_Angle.BackColor = System.Drawing.Color.Gainsboro;
            this.chart_Angle.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea3.CursorX.IsUserEnabled = true;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.CursorY.Interval = 1E-05D;
            chartArea3.Name = "ChartArea1";
            this.chart_Angle.ChartAreas.Add(chartArea3);
            this.chart_Angle.ContextMenuStrip = this.contextMenuStrip1;
            legend3.Name = "Legend1";
            this.chart_Angle.Legends.Add(legend3);
            this.chart_Angle.Location = new System.Drawing.Point(511, 3);
            this.chart_Angle.Name = "chart_Angle";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Lime;
            series3.Legend = "Legend1";
            series3.LegendText = "功角";
            series3.Name = "Series1";
            this.chart_Angle.Series.Add(series3);
            this.chart_Angle.Size = new System.Drawing.Size(514, 362);
            this.chart_Angle.TabIndex = 20;
            this.chart_Angle.Text = "chart1";
            this.chart_Angle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_Angle_MouseMove);
            // 
            // chart_Force
            // 
            this.chart_Force.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_Force.BackColor = System.Drawing.Color.Gainsboro;
            this.chart_Force.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea4.CursorX.IsUserEnabled = true;
            chartArea4.CursorX.IsUserSelectionEnabled = true;
            chartArea4.CursorY.Interval = 1E-05D;
            chartArea4.Name = "ChartArea1";
            this.chart_Force.ChartAreas.Add(chartArea4);
            this.chart_Force.ContextMenuStrip = this.contextMenuStrip1;
            legend4.Name = "Legend1";
            this.chart_Force.Legends.Add(legend4);
            this.chart_Force.Location = new System.Drawing.Point(511, 371);
            this.chart_Force.Name = "chart_Force";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Orange;
            series4.Legend = "Legend1";
            series4.LegendText = "力";
            series4.Name = "Series1";
            this.chart_Force.Series.Add(series4);
            this.chart_Force.Size = new System.Drawing.Size(514, 362);
            this.chart_Force.TabIndex = 21;
            this.chart_Force.Text = "chart1";
            this.chart_Force.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_Force_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.50787F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.49213F));
            this.tableLayoutPanel1.Controls.Add(this.chart_Spd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart_Force, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart_Torqe, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart_Angle, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(358, 140);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 736);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // btn_back_origin
            // 
            this.btn_back_origin.Enabled = false;
            this.btn_back_origin.Location = new System.Drawing.Point(190, 335);
            this.btn_back_origin.Name = "btn_back_origin";
            this.btn_back_origin.Size = new System.Drawing.Size(42, 52);
            this.btn_back_origin.TabIndex = 24;
            this.btn_back_origin.Text = "回到原点";
            this.btn_back_origin.UseVisualStyleBackColor = true;
            this.btn_back_origin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1386, 901);
            this.Controls.Add(this.btn_back_origin);
            this.Controls.Add(this.btn_SetOrigin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_EnableMotor);
            this.Controls.Add(this.btn_ModeSelect);
            this.Controls.Add(this.btn_PortConn);
            this.Controls.Add(this.btn_PortSet);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试系统";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Spd)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Torqe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Force)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Spd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts_label_PortState;
        private System.Windows.Forms.Button btn_PortSet;
        private System.Windows.Forms.Button btn_PortConn;
        private System.Windows.Forms.Button btn_ModeSelect;
        private System.Windows.Forms.Button btn_EnableMotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Force;
        private System.Windows.Forms.Label label_Torque;
        private System.Windows.Forms.Label label_PF;
        private System.Windows.Forms.Label label_Spd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_DataRecord;
        private System.Windows.Forms.Timer timer_RefreshChart;
        private System.Windows.Forms.ToolStripStatusLabel ts_label_ReceCnt;
        private System.Windows.Forms.ToolStripStatusLabel ts_label_SendCnt;
        private System.Windows.Forms.Timer timerListen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清除数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返回上一级缩放ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer_Combine;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Torqe;
        private System.Windows.Forms.ToolTip toolTip_spd;
        private System.Windows.Forms.ToolTip toolTip_torque;
        private System.Windows.Forms.Button btn_SetOrigin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Angle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Force;
        private System.Windows.Forms.ToolTip toolTip_Angle;
        private System.Windows.Forms.ToolTip toolTip_Force;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_back_origin;
    }
}

