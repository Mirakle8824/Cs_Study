using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enumDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thusday,
            Friday,
            Saturday,
            Sunday,
        }

        enum enumTime
        {
            Morning,
            Afternoon,
            Evening,
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lboxDay.Items.Add(enumDay.Monday).ToString();
            lboxDay.Items.Add(enumDay.Tuesday).ToString();
            lboxDay.Items.Add(enumDay.Wednesday).ToString();
            lboxDay.Items.Add(enumDay.Thusday).ToString();
            lboxDay.Items.Add(enumDay.Friday).ToString();
            lboxDay.Items.Add(enumDay.Sunday).ToString();

            lboxTime.Items.Add(enumTime.Morning).ToString();
            lboxTime.Items.Add(enumTime.Afternoon).ToString();
            lboxTime.Items.Add(enumTime.Evening).ToString();
        }


        private void btn_result1_Click(object sender, EventArgs e)
        {
            string strResult = tbox_name.Text + "와" + lboxDay.SelectedItem.ToString() + "(요일)" + lboxTime.SelectedItem.ToString() + "에 보기로 했습니다." ;

            tboxresult.Text = strResult;
        }

        private void btn_result2_Click(object sender, EventArgs e)
        {


            tboxresult.Text = Textload(tbox_name.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString()); // String.Format("{0}와 {1} {2}에 보기로 했습니다.", tbox_name.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());
        }

        /// <summary>
        /// 문자열 정렬
        /// </summary>
        /// <param name="strName">이름</param>
        /// <param name="strday">날짜</param>
        /// <param name="strTime">시간</param>
        /// <returns>문자열 반환</returns>
        private string Textload(string strName, string strday, string strTime)
        {
            string strtext = String.Format("{0}와 {1} {2}에 보기로 했습니다.", strName, strday, strTime);

            return strtext;
        }
        
    }
}
