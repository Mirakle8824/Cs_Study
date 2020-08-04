using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_1_Struct_And_Class
{
    public partial class Form1 : Form
    {
        struct structPlayer
        {
            public int iSun;
            public int iMoon;
            public int iStar;

            public int iCardSum;

            public int iCount;


            public int cardsum(int iSun, int iMoon, int iStar)
            {
                return iSun + iMoon + iStar;
            }

            public string resultText()
            {
                return string.Format("{0}회: 해:{1}, 달:{2}, 별: {3} => 합계는 {4} 입니다. ", iCount, iSun, iMoon, iStar, iCardSum);
            }
        }

        //class classPlayer
        //{
        //    public int iSun = 0;
        //    public int iMoon = 0;
        //    public int iStar = 0;

        //    public int iCardSum = 0;

        //    public int iCount = 0;


        //    public int cardsum(int iSun, int iMoon, int iStar)
        //    {
        //        return iSun + iMoon + iStar;
        //    }

        //    public string resultText(int iCardSum)
        //    {
        //        return string.Format("5회: 해:{0}, 달:{1}, 별: {2} => 합계는 {3} 입니다. ", iSun, iMoon, iStar);
        //    }
        //}

        structPlayer stPlayer1;
        structPlayer stPlayer2;

        Random _rd = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void pbox_1_Click(object sender, EventArgs e)
        {

            int iNum = _rd.Next(1, 21);

            if(radioButton1.Checked)
            {
                stPlayer1.iSun = iNum;
            }
            else
            {
                stPlayer2.iSun = iNum;
            }

            Result();

            iCheckChange();

        }

        private void pbox_2_Click(object sender, EventArgs e)
        {
            int iNum = _rd.Next(1, 21);

            if (radioButton1.Checked)
            {
                stPlayer1.iMoon = iNum;
            }
            else
            {
                stPlayer2.iMoon = iNum;
            }

            Result();

            iCheckChange();
        }

        private void pbox_3_Click(object sender, EventArgs e)
        {
            int iNum = _rd.Next(1, 21);

            if (radioButton1.Checked)
            {
                stPlayer1.iStar = iNum;
            }
            else
            {
                stPlayer2.iStar = iNum;
            }

            Result();

            iCheckChange();
        }

        private void pbox_4_Click(object sender, EventArgs e)
        {
            // skip

            iCheckChange();
        }

        private void iCheckChange()
        {
            if(radioButton1.Checked)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
        }

        private void Result()
        {
            string strResult = string.Empty;

            if(radioButton1.Checked)
            {
                stPlayer1.iCount++;

                stPlayer1.iCardSum = stPlayer1.cardsum(stPlayer1.iSun, stPlayer1.iMoon, stPlayer1.iStar);

                strResult = stPlayer1.resultText();

                lbox_result1.Items.Add(strResult);
            }
            else
            {
                stPlayer2.iCount++;

                stPlayer2.iCardSum = stPlayer2.cardsum(stPlayer2.iSun, stPlayer2.iMoon, stPlayer2.iStar);

                strResult = stPlayer2.resultText();

                lbox_result2.Items.Add(strResult);
            }

            if(stPlayer1.iCount >= 5 && stPlayer2.iCount >= 5)
            {
                if(stPlayer1.iCardSum > stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player1이 이겼습니다.");
                }
                else if(stPlayer1.iCardSum < stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player2이 이겼습니다.");
                }
                else
                {
                    MessageBox.Show("비겼습니다.");
                }
            }
        }
    }
}
