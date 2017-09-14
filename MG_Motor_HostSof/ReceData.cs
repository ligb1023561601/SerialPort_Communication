using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Motor_HostSof
{
    public class ReceData
    {
        public int ReceState { get; set; }

        //每收到一帧数后放置在缓冲区的索引
        public int PortReceivdCnt { get; set; }

        //接受的数据缓冲
        public byte[] PortReceivedDataBuffer = new byte[1000];

        public const int RECEFRAMELENGTH=16;
        public const int RECE_HEADER1=0;
        public const int RECE_HEADER2=1;
        public const int RECE_DATA = 2;
        public const int RECE_CHECKSUM=3;
        public const int RECE_END1=4;
        public const int RECE_END2=5;

        public List<float> RECE_SpdList=new List<float>();
        public List<float> RECE_TorqueList = new List<float>();
        public List<float> RECE_PFList = new List<float>();
        public List<float> RECE_ForceList = new List<float>();

        //反馈转速的横坐标
        public List<string > RECE_SpdTimeList = new List<string>();
        //给定转速的横坐标
        public List<string> RECE_SpdTimeList1 = new List<string>();
        public List<string> RECE_TorqueTimeList = new List<string>();

    }
}
