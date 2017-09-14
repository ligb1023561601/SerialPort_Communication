using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace MG_Motor_HostSof
{
    public partial class Form_Com : Form
    {
        public static string PortName;
        public static string Baud;
        public static string Databits;
        public static string Stopbits;
        public static string Odd;

        public Form_Com()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化串口的基本信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Com_Load(object sender, EventArgs e)
        {
            try
            {
                string[] PortsName = SerialPort.GetPortNames();
                foreach (string item in PortsName)
                {
                    cbx_PortNumber.Items.Add(item);
                }
                cbx_PortNumber.SelectedIndex = 0;

                cbx_Baud.Items.Add("9600");
                cbx_Baud.Items.Add("19200");
                cbx_Baud.Items.Add("38400");
                cbx_Baud.Items.Add("115200");
                cbx_Baud.SelectedIndex = 3;

                cbx_DataBit.Items.Add("5");
                cbx_DataBit.Items.Add("6");
                cbx_DataBit.Items.Add("7");
                cbx_DataBit.Items.Add("8");
                cbx_DataBit.SelectedIndex = 3;

                cbx_Stopbit.Items.Add("0");
                cbx_Stopbit.Items.Add("1");
                cbx_Stopbit.Items.Add("1.5");
                cbx_Stopbit.SelectedIndex = 1;

                cbx_Odd.Items.Add("奇校验");
                cbx_Odd.Items.Add("偶校验");
                cbx_Odd.Items.Add("无校验");
                cbx_Odd.SelectedIndex = 2;
            }
            catch (Exception)
            {
                MessageBox.Show("请检查串口连接！", "Warning");
            }
            

        }

        /// <summary>
        /// 将设置应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SetupPort_Click(object sender, EventArgs e)
        {
            if (CheckSet())
            {
                PortName = cbx_PortNumber.Text;
                Baud = cbx_Baud.Text;
                Databits = cbx_DataBit.Text;
                Stopbits = cbx_Stopbit.Text;
                Odd = cbx_Odd.Text;
                this.Close();
            }
        }

        /// <summary>
        /// 检查串口是否设置好
        /// </summary>
        /// <returns></returns>
        private bool CheckSet()
        {
            if (cbx_PortNumber.Text=="")
            {
                MessageBox.Show("串口号未设置！", "Warning");
                return false;
            }
            else if (cbx_Baud.Text=="" )
            {
                MessageBox.Show("波特率未设置！", "Warning");
                return false;
            }
            else if (cbx_DataBit.Text=="")
            {
                MessageBox.Show("数据位未设置！", "Warning");
                return false;
            }
            else if (cbx_Stopbit.Text=="")
            {
                MessageBox.Show("停止位未设置！", "Warning");
                return false;
            }
            else if (cbx_Odd.Text=="")
            {
                MessageBox.Show("奇偶校验未设置！", "Warning");
                return false;
            }
            return true;
        }
    }
}
