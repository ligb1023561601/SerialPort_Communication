using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Motor_HostSof
{
    public class Command
    {
        public static byte[] Order = new byte[10];
        /// <summary>
        /// 包头包尾，固定值
        /// </summary>
        public  Command()
        {
            Order[0] = 0xAA;
            Order[1] = 0xBB;
            Order[8] = 0xCC;
            Order[9] = 0xDD;
        }
        /// <summary>
        /// 电机使能指令
        /// </summary>
        /// <returns></returns>
        public byte[] StartCommand()
        {
            Order[2] = 0x11;
            return Order;
        }
        /// <summary>
        /// 电机停机指令
        /// </summary>
        /// <returns></returns>
        public byte[] StopCommand()
        {
            Order[2] = 0x00;
            return Order;
        }
        /// <summary>
        /// 查询指令
        /// </summary>
        /// <returns></returns>
        public byte[] ListenCommand()
        {
            Order[2] = 0xFF;
            return Order;
        }
        public byte[] OriginCommand()
        {
            Order[2] = 0xFF;
            Order[3] = 0x25;
            return Order;
        }
        /// <summary>
        /// 查询并切换模式
        /// </summary>
        /// <param name="mode">工作模式</param>
        /// <returns></returns>
        public byte[] ListenCommand(int mode)
        {
            Order[2] = 0xFF;

            byte[] SpdRef = new byte[2];
            byte[] EvenDir = new byte[2];
            byte[] EvenAmp = new byte[2];
            byte[] Acc = new byte[2];
            byte[] TriDir = new byte[2];
            byte[] TriAmp = new byte[2];
            byte[] SinPeak = new byte[2];
            byte[] SinFre = new byte[2];
            byte[] SinDir = new byte[2];

            switch (mode)
            {
                case 1:                     //匀速 0~32767:-1500~0;0~1500，32781~33030
                    //SpdRef=BitConverter.GetBytes(Convert.ToUInt16((Convert.ToInt16(Form_Mode.SpdRef)*0.6+1500) /0.0457763671875));
                    //0-20代表反转，20-40代表正转
                    if (Convert.ToInt16(Form_Mode.SpdRef)<0)
                    {
                        SpdRef = BitConverter.GetBytes(Math.Abs(Convert.ToInt16(Form_Mode.SpdRef)));
                    }
                    else
                    {
                        SpdRef = BitConverter.GetBytes(Convert.ToInt16(Form_Mode.SpdRef) + 20);
                    }

                    EvenDir = BitConverter.GetBytes(Form_Mode.EvenDirection);
                    EvenAmp=BitConverter.GetBytes(Form_Mode.EvenAmp);

                    Order[3] = 0x22;
                    Order[4] = SpdRef[0];  //低位在前
                    Order[5] = SpdRef[1];
                    Order[6] = EvenDir[0];
                    Order[7] = EvenAmp[0];
                    break;
                case 2:                     //加速，大于等于32768为加速，小于32768为减速 ，32771.6~32950
                    //Acc = BitConverter.GetBytes(Convert.ToUInt16((Convert.ToInt16(Form_Mode.Acc)*0.16666666667 + 1500) / 0.0457763671875));
                    
                    Acc = BitConverter.GetBytes(Convert.ToInt16(Form_Mode.Acc));
                    TriAmp = BitConverter.GetBytes(Form_Mode.TriAmp);
                    TriDir = BitConverter.GetBytes(Form_Mode.TriDirection);
                    Order[3] = 0x23;
                    Order[4] = Acc[0];
                    Order[5] = Acc[1];
                    Order[6] = TriDir[0];
                    Order[7] = TriAmp[0];
                    break;
                case 3:                    //正弦
                    //SinPeak = BitConverter.GetBytes((UInt16)(1500/(Convert.ToInt16(Form_Mode.SinPeak)*0.1666666666666667 )));
                    //SinFre = BitConverter.GetBytes((UInt16)(1/(Convert.ToInt16(Form_Mode.SinFre)*0.01273239544735)));

                    SinPeak = BitConverter.GetBytes(Form_Mode.SinPeak);
                    SinFre = BitConverter.GetBytes(Convert.ToInt16(Form_Mode.SinFre));
                    SinDir = BitConverter.GetBytes(Form_Mode.SineDir);
                    Order[3] = 0x24;
                    Order[4] = SinPeak[0];
                    Order[5] = SinDir[0];
                    Order[6] = SinFre[0];
                    Order[7] = SinFre[1];
                    break;
                case 5:                     //给定转速为0，32768
                    Order[3] = 0x22;
                    Order[4] = 0x00;           //低位在前
                    Order[5] = 0x00;
                    break;
                default:
                    break;
            }
            return Order;
        }
    }
}
