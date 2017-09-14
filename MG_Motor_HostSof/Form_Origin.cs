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
    public partial class Form_Origin : Form
    {
        public static float AngleOffSetBuf;
        public static float OriginAngle;
        public Form_Origin(float AngleOffSet)
        {
            InitializeComponent();
            AngleOffSetBuf = AngleOffSet;
            label1.Text = "当前的角度是：" + AngleOffSet + "°";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OriginAngle = AngleOffSetBuf;
            
            this.Close();
        }
    }
}
