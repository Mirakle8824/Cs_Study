using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Class_Create
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
            
        }

        structPlayer stPlayer1;
        structPlayer stPlayer2;

        Random _rd = new Random();

        CPlayer _clPlayer = new CPlayer();


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
        }

        private void pbox_4_Click(object sender, EventArgs e)
        {
            // skip

            Result();
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

                stPlayer1.iCardSum = _clPlayer.cardsum(stPlayer1.iSun, stPlayer1.iMoon, stPlayer1.iStar);

                strResult = _clPlayer.resultText(stPlayer1.iCount, stPlayer1.iSun, stPlayer1.iMoon, stPlayer1.iStar, stPlayer1.iCardSum);

                lbox_result1.Items.Add(strResult);
            }
            else
            {
                stPlayer2.iCount++;

                stPlayer2.iCardSum = _clPlayer.cardsum(stPlayer2.iSun, stPlayer2.iMoon, stPlayer2.iStar);

                strResult = _clPlayer.resultText(stPlayer2.iCount, stPlayer2.iSun, stPlayer2.iMoon, stPlayer2.iStar, stPlayer2.iCardSum);

                lbox_result2.Items.Add(strResult);
            }

            iCheckChange();

            if(stPlayer1.iCount == stPlayer2.iCount)
            {
                lbox_status.Items.Add(_clPlayer.PlayerPair(stPlayer2.iCount, stPlayer1.iCardSum, stPlayer2.iCardSum));

                if(stPlayer2.iCount >= 5)
                {
                    lbox_status.Items.Add(_clPlayer.PlayerResult(stPlayer1.iCardSum, stPlayer2.iCardSum));
                }
            }
        }
    }
}
