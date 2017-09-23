using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MG_Motor_HostSof
{

    public partial class Form_Mode : Form
    {

        public static string SpdRef;                    //速度给定  -1500~1500rpm
        public static string Acc;                       //加速度给定
        public static char SinPeak;                   //正弦指令幅值    ±10v
        public static string SinFre;                    //正弦指令频率    1Hz以下
        public static string CombineSequence;           //组合模式的组合顺序
        public static string SwitchTime;                //组合模式的切换时间
        public static char EvenDirection;
        public static char EvenAmp;
        public static char TriDirection;
        public static char TriAmp;
        public static char SineDir;
            
        public static int RunningMode = 0;              //0,监听；1，匀速；2，加速；3，正弦；4，组合;5,停机
        public static int CombineStateCnt;
        public static string[] Sequence ={"1023","1032","1203","1230","1302","1320",
                                         "2013","2031","2103","2130","2301","2310",
                                         "3201","3102","3021","3012","3210","3120",
                                         "0123","0132","0231","0213","0312","0321"
                                        };

        public Form_Mode()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 给定速度指令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SpdRef_Click(object sender, EventArgs e)
        {
            try
            {
                SpdRef = tbx_SpdRef.Text;
                EvenAmp = Convert.ToChar(tbx_even_amp.Text);

                if (Math.Abs(Convert.ToInt16(EvenAmp))>60)
                {
                    MessageBox.Show("输入的角度大于60°，请重新输入！");
                }

                if (Math.Abs((Convert.ToInt32(SpdRef))) > 80 || Math.Abs((Convert.ToInt32(SpdRef))) < 0)
                {
                    errorProvider_SpdRef.SetError(tbx_SpdRef, "请输入绝对值在0-80之间的数！");
                    SpdRef = null;
                    return;
                }
                else
                    errorProvider_SpdRef.Clear();

                if (rb_even_posi.Checked)
                {
                    EvenDirection = (char)0;
                }
                else if (rb_even_neg.Checked)
                {
                    EvenDirection = (char)1;
                }
                else if (rb_even_whole.Checked)
                {
                    EvenDirection = (char)2;
                }

                RunningMode = 1;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning");
            }
            

        }
        /// <summary>
        /// 给定加速度指令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Acc_Click(object sender, EventArgs e)
        {
            try
            {
                Acc = tbx_Acc.Text;
                if (Math.Abs(Convert.ToInt16(Acc))>80||Math.Abs(Convert.ToInt16(Acc))<10)
                {
                    errorProvider_Acc.SetError(tbx_Acc, "请输入绝对值在10~80之间的数");
                    Acc = null;
                    return;
                }
                else
                {
                    errorProvider_Acc.Clear();
                }
                TriAmp = Convert.ToChar(tbx_tri_amp.Text);
                if (Math.Abs(Convert.ToInt16(TriAmp))>60)
                {
                    MessageBox.Show("输入的角度大于60°，请重新输入！");
                }

                if (rb_tri_pos.Checked)
                {
                    TriDirection = (char)0;
                }
                else if (rb_tri_neg.Checked)
                {
                    TriDirection = (char)1;
                }
                else if (rb_tri_whole.Checked)
                {
                    TriDirection = (char)2;
                }
                RunningMode = 2;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning");
            }
            
        }
        /// <summary>
        /// 选择正弦工作模式，可设定幅值与频率
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sin_Click(object sender, EventArgs e)
        {
            try
            {
                SinPeak = Convert.ToChar(tbx_SinPeak.Text);
                SinFre = (comboBox1.SelectedIndex+1).ToString();

                //检查幅值范围
                if (Math.Abs(Convert.ToInt16(SinPeak)) > 60||Math.Abs(Convert.ToInt16(SinPeak))<0)
                {
                    errorProvider_SpdRef.SetError(tbx_SinPeak, "请输入在0~60之间的数！");
                    return;
                }
                else
                    errorProvider_SpdRef.Clear();

                if (rb_sine_pos.Checked)
                {
                    SineDir = (char)0;
                }
                else if (rb_sine_neg.Checked)
                {
                    SineDir = (char)1;
                }
                else if (rb_sine_whole.Checked)
                {
                    SineDir = (char)2;
                }
                RunningMode = 3;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning");
            }
        }
        /// <summary>
        /// 组合模式选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Combine_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckMode())
                {
                    CombineSequence = tbx_Combine.Text;

                    SwitchTime = tbx_SpdRefTime.Text;

                    SpdRef = tbx_SpdRef.Text;
                    Acc = tbx_Acc.Text;
                    SinPeak = Convert.ToChar(tbx_SinPeak);
                    SinFre = comboBox1.SelectedIndex.ToString();

                    if (!Sequence.Contains(CombineSequence))
                    {
                        errorProvider_Combine.SetError(tbx_Combine, "请将0123进行任意组合后输入!");
                        return;
                    }
                    else
                        errorProvider_Combine.Clear();

                    //速度指令检查
                    if (Math.Abs((Convert.ToInt32(SpdRef))) > 20 || Math.Abs((Convert.ToInt32(SpdRef))) < 1)
                    {
                        errorProvider_SpdRef.SetError(tbx_SpdRef, "请输入绝对值在1~20之间的数！");
                        SpdRef = null;
                        return;
                    }
                    else
                        errorProvider_SpdRef.Clear();

                    //加速度指令检查
                    if (Math.Abs(Convert.ToInt16(Acc)) > 50 || Math.Abs(Convert.ToInt16(Acc)) <1)
                    {
                        errorProvider_Acc.SetError(tbx_Acc, "请输入绝对值在1~50之间的数");
                        Acc = null;
                        return;
                    }
                    else
                    {
                        errorProvider_Acc.Clear();
                    }

                    //检查幅值范围
                    if (Math.Abs(Convert.ToInt16(SinPeak)) > 60)
                    {
                        errorProvider_SpdRef.SetError(tbx_SinPeak, "请输入绝对值在0~60之间的数！");
                        return;
                    }
                    else
                        errorProvider_SpdRef.Clear();


                    if (Convert.ToInt32(tbx_SpdRefTime.Text)<800)
                    {
                        MessageBox.Show("请输入大于800ms的值！", "Warning");
                    }
                    RunningMode = 4;
                    this.Close();
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// 检查组合模式下各参数是否均已给定
        /// </summary>
        /// <returns></returns>
        private bool CheckMode()
        {
            if (tbx_SpdRef.Text=="")
            {
                MessageBox.Show("速度给定未设置！", "Warning");
                return false;
            }
            else if (tbx_Acc.Text=="")
            {
                MessageBox.Show("加速度给定未设置！", "Warning");
                return false;
            }
            else if (tbx_SinPeak.Text=="")
            {
                MessageBox.Show("正弦波幅值给定未设置！", "Warning");
                return false;
            }
            else if (comboBox1.SelectedIndex== -1)
            {
                MessageBox.Show("正弦波频率给定未设置！", "Warning");
                return false;
            }
            else if (tbx_Combine.Text=="")
            {
                MessageBox.Show("组合方式未设置！", "Warning");
                return false;
            }
            else if (tbx_SpdRefTime.Text=="")
            {
                MessageBox.Show("切换未设置！", "Warning");
                return false;
            }
            return true;
        }
    }
}
