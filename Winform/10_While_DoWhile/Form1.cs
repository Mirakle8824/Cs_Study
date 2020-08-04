using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_While_DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // 1 ~ 45 7개 번호

            int[] iArray = new int[6];
            int iCount = 0;

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            while (Array.IndexOf(iArray, 0) != -1)
            {
                int iNum = rd.Next(1, 46);

                if(Array.IndexOf(iArray, iNum) == -1)
                {
                    iArray[iCount] = iNum;
                    sb.Append(string.Format("{0}, ", iNum));
                    iCount++;
                }
            }

            // 배열 sort
            // 배열 있는 값을 문자로

            lbl_result.Text = sb.ToString();
            lbox_result.Items.Add(sb.ToString());
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int iNum = int.Parse(tbox1.Text);

            if(iNum < 1 || iNum > 101)
            {
                MessageBox.Show("범위를 다시 입력하세요.");
                return;
            }

            int iCheckNum = 0;
            int iCount = 0;

            do
            {
                iCheckNum = rd.Next(1, 101);
                iCount++;


            } while (iNum != iCheckNum);

            lbl_random.Text = string.Format("- 뽑은 숫자{0}를 {1} 회만에 뽑았다", iCheckNum, iCount);
        }
    }
}
