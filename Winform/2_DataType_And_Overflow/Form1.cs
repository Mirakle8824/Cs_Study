using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_DataType_And_Overflow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_short_Click(object sender, EventArgs e)
        {
            try
            {
                short sNumber = short.Parse(tboxNumber.Text);

                lbl_short.Text = sNumber.ToString();

                lbl_exception.Text = "-";

            }
            catch (Exception ex)
            {
                lbl_exception.Text = ex.ToString();
            }
        }

        private void btn_int_Click(object sender, EventArgs e)
        {
            try
            {
                int sNumber = int.Parse(tboxNumber.Text);

                lbl_int.Text = sNumber.ToString();

                lbl_exception.Text = "-";

            }
            catch (Exception ex)
            {
                lbl_exception.Text = ex.ToString();
            }
        }

        private void btn_double_Click(object sender, EventArgs e)
        {
            try
            {
                double sNumber = double.Parse(tboxNumber.Text);

                lbl_double.Text = sNumber.ToString();

                lbl_exception.Text = "-";

            }
            catch (Exception ex)
            {
                lbl_exception.Text = ex.ToString();
            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            short sNumber = 0;
            int iNumber = 0;
            double dNumber = 0;

            lbl_exception.Text = "-";

            if(short.TryParse(tboxNumber.Text, out sNumber))
            {
                lbl_short.Text = sNumber.ToString();
            }
            else if(int.TryParse(tboxNumber.Text, out iNumber))
            {
                lbl_int.Text = iNumber.ToString();
            }
            else if(double.TryParse(tboxNumber.Text, out dNumber))
            {
                lbl_double.Text = dNumber.ToString();
            }
            else
            {
                lbl_exception.Text = "변환 할 수 없음";
            }
        }
    }
}
