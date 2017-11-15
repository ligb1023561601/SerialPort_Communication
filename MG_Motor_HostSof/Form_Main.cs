using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.XSSF.Model;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace MG_Motor_HostSof
{
    public partial class Form_Main : Form
    {
        SerialPort sp = new SerialPort();
        Command cmd = new Command();
        ReceData ReceiveProcess=new ReceData();
        List<float> SpdRefList = new List<float>();

        float Spd = 0;                  //速度
        float Torque = 0;               //转矩
        float PF = 0;                   //功角
        float Force = 0;                //力

        public int ReceCnt = 0;         //接收计数
        public int SendCnt = 0;         //发送计数

        /// <summary>
        /// 初始化chart
        /// </summary>
        public Form_Main()
        {
            InitializeComponent();
            chart_Spd.Titles.Add("转速曲线");
            chart_Spd.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
            chart_Spd.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
            chart_Spd.ChartAreas[0].AxisX.Name = "时间";
            chart_Spd.ChartAreas[0].AxisY.Name = "实际转速";
            chart_Spd.ChartAreas[0].AxisX.Title = "时间";
            chart_Spd.ChartAreas[0].AxisY.Title = "实际转速 °/s";
            chart_Spd.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_Spd.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_Spd.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            chart_Spd.ChartAreas[0].CursorX.AutoScroll = true;
            chart_Spd.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart_Spd.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart_Spd.ChartAreas[0].CursorX.LineColor = Color.Blue;
            chart_Spd.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart_Spd.ChartAreas[0].CursorY.AutoScroll = true;
            chart_Spd.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart_Spd.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart_Spd.ChartAreas[0].CursorY.LineColor = Color.Blue;

            chart_Torqe.Titles.Add("转矩曲线");
            chart_Torqe.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
            chart_Torqe.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
            chart_Torqe.ChartAreas[0].AxisX.Name = "时间";
            chart_Torqe.ChartAreas[0].AxisY.Name = "转矩";
            chart_Torqe.ChartAreas[0].AxisX.Title = "时间";
            chart_Torqe.ChartAreas[0].AxisY.Title = "转矩 /N·m";
            chart_Torqe.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_Torqe.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_Torqe.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            chart_Torqe.ChartAreas[0].CursorX.AutoScroll = true;
            chart_Torqe.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart_Torqe.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart_Torqe.ChartAreas[0].CursorX.LineColor = Color.Blue;

            chart_Torqe.ChartAreas[0].CursorY.AutoScroll = true;
            chart_Torqe.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart_Torqe.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart_Torqe.ChartAreas[0].CursorY.LineColor = Color.Blue;

            chart_Angle.Titles.Add("功角曲线");
            chart_Angle.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
            chart_Angle.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
            chart_Angle.ChartAreas[0].AxisX.Name = "时间";
            chart_Angle.ChartAreas[0].AxisY.Name = "功角";
            chart_Angle.ChartAreas[0].AxisX.Title = "时间";
            chart_Angle.ChartAreas[0].AxisY.Title = "功角 °";
            chart_Angle.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_Angle.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_Angle.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            chart_Angle.ChartAreas[0].CursorX.AutoScroll = true;
            chart_Angle.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart_Angle.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart_Angle.ChartAreas[0].CursorX.LineColor = Color.Blue;
            chart_Angle.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart_Angle.ChartAreas[0].CursorY.AutoScroll = true;
            chart_Angle.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart_Angle.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart_Angle.ChartAreas[0].CursorY.LineColor = Color.Blue;

            chart_Force.Titles.Add("力曲线");
            chart_Force.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
            chart_Force.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
            chart_Force.ChartAreas[0].AxisX.Name = "时间";
            chart_Force.ChartAreas[0].AxisY.Name = "力";
            chart_Force.ChartAreas[0].AxisX.Title = "时间";
            chart_Force.ChartAreas[0].AxisY.Title = "力 N";
            chart_Force.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_Force.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_Force.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            chart_Force.ChartAreas[0].CursorX.AutoScroll = true;
            chart_Force.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart_Force.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart_Force.ChartAreas[0].CursorX.LineColor = Color.Blue;
            chart_Force.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart_Force.ChartAreas[0].CursorY.AutoScroll = true;
            chart_Force.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart_Force.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart_Force.ChartAreas[0].CursorY.LineColor = Color.Blue;

            sp.DataReceived += sp_DataReceived;
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 设置串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PortSet_Click(object sender, EventArgs e)
        {
            Form_Com fm = new Form_Com();
            fm.StartPosition = FormStartPosition.CenterScreen;
            fm.ShowDialog();
        }

        /// <summary>
        /// 连接/断开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PortConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_PortConn.Text == "连接串口") 
	            {
                    sp.PortName = Form_Com.PortName;
                    sp.BaudRate = Convert.ToInt32(Form_Com.Baud);
                    sp.DataBits = Convert.ToInt32(Form_Com.Databits);
                    sp.StopBits = StopBits.One;
                    sp.Parity = Parity.None;

                    sp.Open();
                    if (sp.IsOpen == true)
                    {
                        btn_PortConn.Text = "断开连接";
                        ts_label_PortState.Text = sp.PortName + " Conneced " + sp.BaudRate.ToString();
                    }

                    btn_ModeSelect.Enabled = true;
                    btn_EnableMotor.Enabled = true;
                    btn_DataRecord.Enabled = true;
                    btn_SetOrigin.Enabled = true;
                    btn_back_origin.Enabled = true;
	             }
                else if (btn_PortConn.Text == "断开连接")
	            {
                    timer_RefreshChart.Enabled = false;

                    timerListen.Enabled = false;
                    timerListen.Interval = 800;

                    timer_Combine.Enabled = false;

                    btn_EnableMotor.Text = "电机使能";
                    sp.Close();
                    if (sp.IsOpen==false)
                    {
                        btn_PortConn.Text = "连接串口";
                        ts_label_PortState.Text = "Disconnected";
                    }
                    btn_ModeSelect.Enabled = false;
                    btn_EnableMotor.Enabled = false;
                    btn_DataRecord.Enabled = false;
                    btn_SetOrigin.Enabled = false;
                    Form_Mode.RunningMode = 0;                  //恢复监听状态
            	}

            }
            catch (Exception)
            {
                MessageBox.Show("请先设置串口！", "Warning");
            }

        }

        /// <summary>
        /// 串口接收事件 注：不要将整个接收线程都invoke，这样在界面线程进行其他操作，如定时器刷新界面时会导致接收的事件被影响到，即可能漏收许多数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int PortReceDataLengthOneTime = 0;              //一次接收的帧长度
            int PortDataCnt = 0;
            byte[] ReceBuffer = null;                         //接收一次的帧缓冲
            byte[] PortDataBuffer = new byte[12];
            byte PortByteBuffer = new byte();                 //用于判断的单个字节
            byte[] SpdDataBffer = new byte[4];
            byte[] TorqueDataBuffer = new byte[4];
            byte[] PFDataBuffer = new byte[4];

            try
            {
                if (sp.BytesToRead > 0)
                {
                    ReceBuffer = new byte[sp.BytesToRead];
                    PortReceDataLengthOneTime = sp.Read(ReceBuffer, 0, sp.BytesToRead);
                }

                Array.Copy(ReceBuffer, 0, ReceiveProcess.PortReceivedDataBuffer, ReceiveProcess.PortReceivdCnt, ReceBuffer.Length);//目标处从0开始应该也行，相当于直接把错的包全扔了

                ReceiveProcess.PortReceivdCnt += PortReceDataLengthOneTime;

                //接收完一帧后进行处理
                if (ReceiveProcess.PortReceivdCnt > ReceData.RECEFRAMELENGTH - 1)
                {
                    for (int i = 0; i < ReceiveProcess.PortReceivdCnt; i++)
                    {
                        PortByteBuffer = ReceiveProcess.PortReceivedDataBuffer[i];
                        switch (ReceiveProcess.ReceState)
                        {
                            case ReceData.RECE_HEADER1:
                                if (PortByteBuffer == 0x22)
                                {
                                    ReceiveProcess.ReceState = ReceData.RECE_HEADER2;
                                }
                                break;
                            case ReceData.RECE_HEADER2:
                                if (PortByteBuffer == 0x23)
                                {
                                    ReceiveProcess.ReceState = ReceData.RECE_DATA;
                                }
                                else
                                {
                                    ReceiveProcess.ReceState = ReceData.RECE_HEADER1;
                                }
                                break;
                            case ReceData.RECE_DATA:
                                PortDataBuffer[PortDataCnt] = PortByteBuffer;
                                PortDataCnt++;
                                if (PortDataCnt > 11)
                                {
                                    ReceiveProcess.ReceState = ReceData.RECE_END1;
                                    PortDataCnt = 0;
                                }
                                break;
                            case ReceData.RECE_END1:
                                if (PortByteBuffer == 0x26)
                                {
                                    ReceiveProcess.ReceState = ReceData.RECE_END2;
                                }
                                else
                                {
                                    ReceiveProcess.ReceState = ReceData.RECE_HEADER1;
                                }
                                break;
                            case ReceData.RECE_END2:
                                if (PortByteBuffer == 0x27)
                                {
                                    ReceiveProcess.PortReceivdCnt = 0;                      //整帧数据无误则从缓冲区0处开始

                                    PFDataBuffer[0] = PortDataBuffer[0];                    //低字节在前
                                    PFDataBuffer[1] = PortDataBuffer[1];
                                    PFDataBuffer[2] = PortDataBuffer[2];
                                    PFDataBuffer[3] = PortDataBuffer[3];

                                    SpdDataBffer[0] = PortDataBuffer[4];
                                    SpdDataBffer[1] = PortDataBuffer[5];
                                    SpdDataBffer[2] = PortDataBuffer[6];
                                    SpdDataBffer[3] = PortDataBuffer[7];

                                    TorqueDataBuffer[0] = PortDataBuffer[8];
                                    TorqueDataBuffer[1] = PortDataBuffer[9];
                                    TorqueDataBuffer[2] = PortDataBuffer[10];
                                    TorqueDataBuffer[3] = PortDataBuffer[11];

                                    //数据添加至全局list,必须得lock，因为这些数据跨线程会调用了，不lock会产生枚举值已变化的异常
                                    lock (ReceiveProcess)
                                    {
                                        this.PF = BitConverter.ToInt32(PFDataBuffer, 0)/1000f;
                                        ReceiveProcess.RECE_PFList.Add(this.PF);

                                        this.Spd = BitConverter.ToInt32(SpdDataBffer, 0)/1000f;
                                        ReceiveProcess.RECE_SpdList.Add(this.Spd);

                                        this.Torque = BitConverter.ToInt32(TorqueDataBuffer, 0)/1000f;
                                        ReceiveProcess.RECE_TorqueList.Add(this.Torque);

                                        this.Force = (BitConverter.ToInt32(TorqueDataBuffer, 0))/50f;
                                        ReceiveProcess.RECE_ForceList.Add(this.Force);

                                        //横坐标用string，用datetime型不能进行缩放
                                        ReceiveProcess.RECE_SpdTimeList.Add(DateTime.Now.ToString("HH:mm:ss:fff"));
                                        ReceiveProcess.RECE_TorqueTimeList.Add(DateTime.Now.ToString("HH:mm:ss:fff"));
                                        ReceiveProcess.RECE_SpdTimeList1.Add(DateTime.Now.ToString("HH:mm:ss:fff"));
                                        ReceiveProcess.RECE_PFTimeList.Add(DateTime.Now.ToString("HH:mm:ss:fff"));

                                        //this.SpdRefList.Add(Convert.ToSingle(Form_Mode.SpdRef));       //将速度参考加入曲线，作为对比

                                        ReceiveProcess.ReceState = ReceData.RECE_HEADER1;
                                        this.ReceCnt++;
                                        
                                    }                                  
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ReceBuffer = null;
                ReceiveProcess.PortReceivedDataBuffer = new byte[1000];
                ReceiveProcess.PortReceivdCnt = 0;
                sp.DiscardInBuffer();
                //MessageBox.Show(ex.ToString(), "Warning"); 
            }
                
        }

        /// <summary>
        /// 将list中的数据移除
        /// </summary>
        private void RemoveData()
        {
            ReceiveProcess.RECE_SpdList.RemoveAt(0);
            ReceiveProcess.RECE_PFList.RemoveAt(0);
            ReceiveProcess.RECE_ForceList.RemoveAt(0);
            ReceiveProcess.RECE_TorqueList.RemoveAt(0);
            ReceiveProcess.RECE_SpdTimeList.RemoveAt(0);
            ReceiveProcess.RECE_PFTimeList.RemoveAt(0);
            ReceiveProcess.RECE_TorqueTimeList.RemoveAt(0);
            //this.SpdRefList.RemoveAt(0);
        }

        /// <summary>
        /// 打开帮助文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ReadMe.txt");
        }

        /// <summary>
        /// 定时刷新chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_RefreshChart_Tick(object sender, EventArgs e)
        {
            try
            {
                float AngleAfterOffset = 0;
                
                AngleAfterOffset = this.PF - Form_Origin.OriginAngle;
                
                
                if (AngleAfterOffset>=0)
                {
                    label_PF.Text = AngleAfterOffset.ToString() + "°";
                }
                else
                {
                    AngleAfterOffset += 360;
                    label_PF.Text = AngleAfterOffset.ToString() + "°";
                }
                label_Spd.Text = this.Spd.ToString()+" °/s";
                label_Torque.Text = this.Torque.ToString() + " N·m";
                label_Force.Text = this.Force.ToString() + " N";

            ts_label_ReceCnt.Text = "收到数据帧：" + ReceCnt.ToString();

            //绑定速度
            lock (ReceiveProcess)
            {
                chart_Spd.Series[0].Points.DataBindXY(ReceiveProcess.RECE_SpdTimeList, ReceiveProcess.RECE_SpdList);
                //chart_Spd.Series[1].Points.DataBindXY(ReceiveProcess.RECE_SpdTimeList, this.SpdRefList);
                chart_Spd.DataBind();
            }


            //避免在数据量为0时的异常
            if (ReceiveProcess.RECE_SpdList.Count>0)
            {
                chart_Spd.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                //chart_Spd.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            }
            
            //绑定转矩
            lock (ReceiveProcess)
            {
                chart_Torqe.Series[0].Points.DataBindXY(ReceiveProcess.RECE_TorqueTimeList, ReceiveProcess.RECE_TorqueList);
                chart_Torqe.DataBind();
            }


            if (ReceiveProcess.RECE_SpdList.Count>0)
            {
                //chart_Torqe.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                chart_Torqe.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }

            lock(ReceiveProcess)
            {
                chart_Angle.Series[0].Points.DataBindXY(ReceiveProcess.RECE_PFTimeList, ReceiveProcess.RECE_PFList);
                chart_Angle.DataBind();
            }

            if (ReceiveProcess.RECE_PFList.Count>0)
            {
                chart_Angle.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }

            //绑定力
            lock(ReceiveProcess)
            {
                chart_Force.Series[0].Points.DataBindXY(ReceiveProcess.RECE_PFTimeList, ReceiveProcess.RECE_ForceList);
                chart_Force.DataBind();
            }

            if (ReceiveProcess.RECE_ForceList.Count>0)
            {
                chart_Force.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }
            lock (ReceiveProcess)
            {
                while (ReceiveProcess.RECE_SpdList.Count>2000)
                {
                    RemoveData();
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
              
            }

        }

        /// <summary>
        /// 使能电机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EnableMotor_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_EnableMotor.Text=="电机使能")
                {
                    if (Form_Mode.RunningMode==4)
                    {
                        timerListen.Interval = Convert.ToInt32(Form_Mode.SwitchTime);//为了将模式切换定时器与监听计时器对应起来，不然某些指令会多发
                    }
                    
                    timerListen.Enabled = true;
                    //timerListen.Start();
                    timer_RefreshChart.Enabled = true;
                    //timer_RefreshChart.Start();
                    btn_ModeSelect.Enabled = false;
                    btn_SetOrigin.Enabled = false;
                    btn_back_origin.Enabled = false;

                    sp.DiscardOutBuffer();

                    byte[] command = cmd.StartCommand();
                    sp.Write(command, 0, command.Length);
                    this.SendCnt++;
                    ts_label_SendCnt.Text = "发送数据帧：" + SendCnt.ToString();
                    btn_EnableMotor.Text = "关闭电机";
                    label6.ForeColor = Color.Green;

                }
                else if (btn_EnableMotor.Text=="关闭电机")
                {

                    timerListen.Stop();
                    timerListen.Enabled = false;
                    timerListen.Interval = 800;         //恢复至默认的800ms

                    timer_RefreshChart.Stop();
                    timer_RefreshChart.Enabled = false;

                    timer_Combine.Stop();
                    timer_Combine.Enabled = false;

                    sp.DiscardOutBuffer();

                    //连发10条停止
                    for (int i = 0; i < 10; i++)
                    {
                        byte[] command = cmd.StopCommand();
                        sp.Write(command, 0, command.Length);
                    }
                     
                    this.SendCnt++;
                    Form_Origin.OriginAngle = 0;
                    Form_Origin.AngleOffSetBuf = 0;
                    lock (ReceiveProcess)
                    {
                        if (this.ReceiveProcess.RECE_PFList.Count > 0)
                        {
                            Form_Origin.AngleOffSetBuf = this.ReceiveProcess.RECE_PFList[this.ReceiveProcess.RECE_PFList.Count - 1];
                        }
                
                    }
                    ts_label_SendCnt.Text = "发送数据帧：" + SendCnt.ToString();
                    btn_EnableMotor.Text = "电机使能";
                    label6.ForeColor = Color.Red;


                    btn_SetOrigin.Enabled = true;
                    btn_ModeSelect.Enabled = true;
                    btn_back_origin.Enabled = true;
                    Form_Mode.RunningMode = 0;                  //恢复监听状态
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Warning");
            }
        }

        /// <summary>
        /// 模式选择窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ModeSelect_Click(object sender, EventArgs e)
        {
            Form_Mode fm = new Form_Mode();
            fm.StartPosition = FormStartPosition.CenterScreen;
            fm.ShowDialog();
        }

        /// <summary>
        /// 定时对下位机进行监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerListen_Tick(object sender, EventArgs e)
        {
//#if false
            try
            {   
                byte[] command=null;
                switch (Form_Mode.RunningMode)
                {
                    case 0:                     //纯监听
                        command= cmd.ListenCommand();
                        sp.Write(command,0,command.Length);
                        this.SendCnt++;
                        ts_label_SendCnt.Text = "发送数据帧：" + SendCnt.ToString();
                        break;
                    case 1:                     //匀速
                        command = cmd.ListenCommand(1);
                        sp.Write(command, 0, command.Length);
                        this.SendCnt++;
                        ts_label_SendCnt.Text = "发送数据帧：" + SendCnt.ToString();
                        break;
                    case 2:                     //加速
                        command = cmd.ListenCommand(2);
                        sp.Write(command, 0, command.Length);
                        this.SendCnt++;
                        ts_label_SendCnt.Text = "发送数据帧：" + SendCnt.ToString();
                        break;
                    case 3:                     //sin
                        command = cmd.ListenCommand(3);
                        sp.Write(command, 0, command.Length);
                        this.SendCnt++;
                        ts_label_SendCnt.Text = "发送数据帧：" + SendCnt.ToString();
                        break;
                    case 4:                     //组合定时器开始
                        
                        timer_Combine.Interval = Convert.ToInt32(Form_Mode.SwitchTime);
                        timer_Combine.Enabled = true;
                        timer_Combine.Start();                            
                        break;
                    case 5:                     //发送停止指令，即给定为0 
                        command = cmd.ListenCommand(5);
                        sp.Write(command, 0, command.Length);
                        this.SendCnt++;
                        ts_label_SendCnt.Text = "发送数据帧：" + SendCnt.ToString();
                        break;
                    default:
                        break;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
//#endif
            //测试用代码
#if false
            byte[] test = new byte[16];
            test[0] = 0x22;
            test[1] = 0x23;
            test[2] = 0x19;//25
            test[3] = 0x00;
            test[4] = 0x00;
            test[5] = 0x00;
            test[6] = 0x30;//560
            test[7] = 0x02;
            test[8] = 0x00;
            test[9] = 0x00;
            test[10] = 0x98;//920
            test[11] = 0x03;
            test[12] = 0x00;
            test[13] = 0x00;
            test[14] = 0x26;
            test[15] = 0x27;
            sp.Write(test, 0, test.Length);
            this.SendCnt++;
            ts_label_SendCnt.Text="发送数据帧：" + SendCnt.ToString();
#endif
}

        /// <summary>
        /// 记录数据，保存为Excel07以上版本，保存最近1000组数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DataRecord_Click(object sender, EventArgs e)
        {
            try
            {
                XSSFWorkbook SaveDataToExcel= this.CreateExcelHeader();
                string filename = "";

                if (ReceiveProcess.RECE_SpdList.Count<1)
                {
                    MessageBox.Show("当前没有可以保存的数据！", "Warning");
                    return;
                }

                saveFileDialog1.Filter = "Excel文件(07以上)（*.xlsx）|*.xlsx";

                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    filename = saveFileDialog1.FileName.TrimEnd((".xlsx").ToArray()) + "_" + DateTime.Now.ToString("yyyy-MM-dd")+".xlsx";
                    ISheet sheet1 = SaveDataToExcel.GetSheetAt(0);

                    lock (ReceiveProcess)
                    {
                        for (int i = 1; i < ReceiveProcess.RECE_SpdList.Count; i++)
                        {
                            IRow datarow = sheet1.CreateRow(i);
                            datarow.CreateCell(0).SetCellValue(ReceiveProcess.RECE_SpdTimeList[i - 1]);
                            datarow.CreateCell(1).SetCellValue(ReceiveProcess.RECE_SpdList[i - 1]);
                            datarow.CreateCell(2).SetCellValue(ReceiveProcess.RECE_TorqueList[i - 1]);
                            datarow.CreateCell(3).SetCellValue(ReceiveProcess.RECE_PFList[i - 1]);
                            datarow.CreateCell(4).SetCellValue(ReceiveProcess.RECE_ForceList[i - 1]);
                        }

                        using (FileStream fs = new FileStream(filename, FileMode.Create))
                        {
                            SaveDataToExcel.Write(fs);
                            fs.Close();
                        }
                        MessageBox.Show("保存完毕！");
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning");
            }
        }

        /// <summary>
        /// 新建表头
        /// </summary>
        /// <returns></returns>
        private XSSFWorkbook CreateExcelHeader()
        {
            XSSFWorkbook xssfwb = new XSSFWorkbook();

            ISheet sheet1= xssfwb.CreateSheet("Sheet1");
            IRow FirstRow = sheet1.CreateRow(0);

            FirstRow.CreateCell(0).SetCellValue("时间");
            FirstRow.CreateCell(1).SetCellValue("转速");
            FirstRow.CreateCell(2).SetCellValue("力矩");
            FirstRow.CreateCell(3).SetCellValue("功角");
            FirstRow.CreateCell(4).SetCellValue("力");
            return xssfwb;

        }

        /// <summary>
        /// 将所有数据恢复至初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 清除数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_PF.Text = " -- °";
            label_Spd.Text = " -- rpm";
            label_Torque.Text = " -- N·m";
            label_Force.Text = " -- N";

            ReceiveProcess.RECE_SpdList.Clear();
            ReceiveProcess.RECE_SpdTimeList.Clear();
            ReceiveProcess.RECE_SpdTimeList1.Clear();
            ReceiveProcess.RECE_TorqueList.Clear();
            ReceiveProcess.RECE_TorqueTimeList.Clear();
            ReceiveProcess.RECE_PFList.Clear();
            ReceiveProcess.RECE_PFTimeList.Clear();
            ReceiveProcess.RECE_ForceList.Clear();
            this.SpdRefList.Clear();

            chart_Spd.Series[0].Points.DataBindXY(ReceiveProcess.RECE_SpdTimeList, ReceiveProcess.RECE_SpdList);
            //chart_Spd.Series[1].Points.DataBindXY(ReceiveProcess.RECE_SpdTimeList, this.SpdRefList);
            chart_Spd.DataBind();

            chart_Torqe.Series[0].Points.DataBindXY(ReceiveProcess.RECE_TorqueTimeList, ReceiveProcess.RECE_TorqueList);
            chart_Torqe.DataBind();

            chart_Angle.Series[0].Points.DataBindXY(ReceiveProcess.RECE_PFTimeList, ReceiveProcess.RECE_PFList);
            chart_Angle.DataBind();

            chart_Force.Series[0].Points.DataBindXY(ReceiveProcess.RECE_PFTimeList, ReceiveProcess.RECE_ForceList);
            chart_Force.DataBind();

            this.SendCnt = 0;
            this.ReceCnt = 0;
            ts_label_SendCnt.Text = "发送数据帧：" + SendCnt.ToString();
            ts_label_ReceCnt.Text = "接收数据帧：" +  ReceCnt.ToString();
            Form_Mode.RunningMode = 0;          //恢复监听状态

        }

        /// <summary>
        /// 对chart进行缩放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 返回上一级缩放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart_Spd.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chart_Spd.ChartAreas[0].AxisY.ScaleView.ZoomReset();
            chart_Torqe.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chart_Torqe.ChartAreas[0].AxisY.ScaleView.ZoomReset();
            chart_Angle.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chart_Angle.ChartAreas[0].AxisY.ScaleView.ZoomReset();
            chart_Force.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chart_Force.ChartAreas[0].AxisY.ScaleView.ZoomReset();
        }

        /// <summary>
        /// 组合模式切换计时器,定时的切换模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Combine_Tick(object sender, EventArgs e)
        {
            try
            {
                switch (Form_Mode.CombineSequence)
                {
                case "1023":
                    if (Form_Mode.CombineStateCnt==0)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt==1)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt==2)
                    {
                        Form_Mode.RunningMode =2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt = 0;
                    }


                    break;
                case "1032":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt = 0;
                    }

                    break;
                case "1203":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt = 0;
                    }

                    break;
                case "1230":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt = 0;
                    }

                    break;
                case "1302":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt = 0;
                    }

                    break;
                case "1320":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "2013":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "2031":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "2103":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 0;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "2130":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "2301":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "2310":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "3201":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "3102":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "3021":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "3012":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "3210":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "3120":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "0123":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "0132":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "0231":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "0213":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "0312":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                case "0321":
                    if (Form_Mode.CombineStateCnt == 0)
                    {
                        Form_Mode.RunningMode = 5;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 1)
                    {
                        Form_Mode.RunningMode = 3;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 2)
                    {
                        Form_Mode.RunningMode = 2;
                        Form_Mode.CombineStateCnt++;
                    }
                    else if (Form_Mode.CombineStateCnt == 3)
                    {
                        Form_Mode.RunningMode = 1;
                        Form_Mode.CombineStateCnt = 0;
                    }
                    break;
                default:
                    break;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning");
            }
        }
        /// <summary>
        /// 显示点的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chart_Spd_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                HitTestResult hit = chart_Spd.HitTest(e.X, e.Y);

                if (hit.ChartElementType == ChartElementType.DataPoint)
                {
                    this.Cursor = Cursors.Cross;
                    DataPoint dp_spd = hit.Series.Points[hit.PointIndex];
                    
                    toolTip_spd.SetToolTip(chart_Spd, "时间 ：" + dp_spd.AxisLabel + Environment.NewLine + "转速 ：" + Math.Round(dp_spd.YValues[0], 4));
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    toolTip_spd.Hide(chart_Spd);
                }
            }
            catch (Exception)
            {
                
                throw;
            }

        }
        /// <summary>
        /// 显示点的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chart_Torqe_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                HitTestResult hit = chart_Torqe. HitTest(e.X, e.Y);

                if (hit.ChartElementType == ChartElementType.DataPoint)
                {
                    this.Cursor = Cursors.Cross;
                    DataPoint dp_torque = hit.Series.Points[hit.PointIndex];
                    //保留四位小数
                    
                    toolTip_torque.SetToolTip(chart_Torqe, "时间 ：" + dp_torque.AxisLabel + Environment.NewLine + "转矩 ：" + Math.Round(dp_torque.YValues[0], 4));
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    toolTip_torque.Hide(chart_Torqe);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 将当前位置设为原点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SetOrigin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReceiveProcess.RECE_SpdList.Count<1)
                {
                    MessageBox.Show("当前没有数据！", "Warning");
                    return;
                }

                Form fm_origin = new Form_Origin(Form_Origin.AngleOffSetBuf);

                fm_origin.ShowDialog(this);
            }
            catch (Exception)
            {
                MessageBox.Show("当前没有数据！", "Warning");
                throw;
            }
            
        }
        /// <summary>
        /// 显示点的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chart_Angle_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                HitTestResult hit = chart_Angle.HitTest(e.X, e.Y);

                if (hit.ChartElementType == ChartElementType.DataPoint)
                {
                    this.Cursor = Cursors.Cross;
                    DataPoint dp_angle = hit.Series.Points[hit.PointIndex];
                    //保留四位小数

                    toolTip_Angle.SetToolTip(chart_Angle, "时间 ：" + dp_angle.AxisLabel + Environment.NewLine + "功角 ：" + Math.Round(dp_angle.YValues[0], 4));
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    toolTip_Angle.Hide(chart_Angle);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 显示点的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chart_Force_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                HitTestResult hit = chart_Force.HitTest(e.X, e.Y);

                if (hit.ChartElementType == ChartElementType.DataPoint)
                {
                    this.Cursor = Cursors.Cross;
                    DataPoint dp_force = hit.Series.Points[hit.PointIndex];
                    //保留四位小数

                    toolTip_Force.SetToolTip(chart_Force, "时间 ：" + dp_force.AxisLabel + Environment.NewLine + "力 ：" + Math.Round(dp_force.YValues[0], 4));
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    toolTip_Force.Hide(chart_Force);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 回到原点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            sp.DiscardInBuffer();
            byte[] command = cmd.StartCommand();
            sp.Write(command, 0, command.Length);
            this.SendCnt++;
            ts_label_SendCnt.Text = "发送数据帧：" + SendCnt.ToString();

            sp.DiscardInBuffer();
            command = cmd.OriginCommand();
            sp.Write(command, 0, command.Length);
            this.SendCnt++;
            ts_label_SendCnt.Text = "发送数据帧：" + SendCnt.ToString();
        }

    }
}
