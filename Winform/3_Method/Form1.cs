using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tbox_Num1.Text);
            int iNumB = int.Parse(tbox_Num2.Text);

            //int iResult = iNumA + iNumB;
            //tbox_result.Text = iResult.ToString();

            tbox_result.Text = fPlus(iNumA, iNumB).ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tbox_Num1.Text);
            int iNumB = int.Parse(tbox_Num2.Text);

            int iResult = iNumA - iNumB;

            tbox_result.Text = iResult.ToString();
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tbox_Num1.Text);
            int iNumB = int.Parse(tbox_Num2.Text);

            int iResult = iNumA * iNumB;

            tbox_result.Text = iResult.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tbox_Num1.Text);
            int iNumB = int.Parse(tbox_Num2.Text);

            int iResult = iNumA / iNumB;

            //int iResultB = iNumA % iNumB;

            tbox_result.Text = iResult.ToString();
        }

        private int fPlus(int iA, int iB)
        {
            //int iResult = 0;

            int iResult = iA + iB;
            return iResult;
        } 
    }
}
