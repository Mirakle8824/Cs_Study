using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_If_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn1_Click(object sender, EventArgs e)
        {
            int iNum1 = (int)num_updown1.Value;
            int iNum2 = (int)num_updown2.Value;
            
            lbl_count.Text = string.Format("{0} {1}", iNum1, iNum2);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string strSelect = cbox_day.Text;

            switch(strSelect)
            {
                case "월":
                    lbl_days.Text = "월요일입니다.";
                    break;
                default:
                    lbl_days.Text = "다른 요일입니다.";
                    break;
            }
        }
    }
}
