using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string st_text = lbl_text.Text;

            lbl_contain.Text = st_text.Contains("Text").ToString();        // Contain 반환형식이 string이 아니라 Tostring으로 변환
            lbl_equals.Text = st_text.Equals("Text").ToString();
            lbl_length.Text = st_text.Length.ToString();
            lbl_replace.Text = st_text.Replace("Text", "I Can");

            string[] strSplit = st_text.Split(',');
            lbl_split1.Text = strSplit[0].Trim();
            lbl_split2.Text = strSplit[1].Trim();
            lbl_split3.Text = strSplit[2].Trim();

            lbl_substring.Text = st_text.Substring(3, 5);
            lbl_tolower.Text = st_text.ToLower();
            lbl_toupper.Text = st_text.ToUpper();
            lbl_trim.Text = st_text.Trim();

        }
    }
}
