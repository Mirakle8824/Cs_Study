using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ArrayTest();
        }

        private void ArrayTest()
        {
            int[] iArrayText2 = { 1, 2, 3, 4, 5};

            int i = iArrayText2.Length;

            Array.Clear(iArrayText2, 2, 2);

            Array.Resize(ref iArrayText2, 10);

            int iSearch30 = Array.IndexOf(iArrayText2, 50);



        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            dgday.Rows.Clear();

            int[] iArrayText2 = { 1, 2, 3, 4, 5, 6, 7 };

            lblArrayCount.Text = String.Format("전체 자료 수 {0}", iArrayText2.Length.ToString());

            dgday["colDay1", 0].Value = iArrayText2[0];
            dgday["colDay2", 0].Value = iArrayText2[1];
            dgday["colDay3", 0].Value = iArrayText2[2];
            dgday["colDay4", 0].Value = iArrayText2[3];
            dgday["colDay5", 0].Value = iArrayText2[4];
            dgday["colDay6", 0].Value = iArrayText2[5];
            dgday["colDay7", 0].Value = iArrayText2[6];
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            dgday.Rows.Clear();

            int[,] iArrayText2 = { { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 } };

            lblArrayCount.Text = String.Format("전체 자료 수 {0}", iArrayText2.Length.ToString());

            dgday.Rows.Add();

            dgday["colDay1", 0].Value = iArrayText2[0, 0];
            dgday["colDay2", 0].Value = iArrayText2[0, 1];

            dgday["colDay1", 1].Value = iArrayText2[1, 0];
            dgday["colDay2", 1].Value = iArrayText2[1, 1];

        }
    }
}
