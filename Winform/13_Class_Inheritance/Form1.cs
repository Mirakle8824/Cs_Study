using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Class_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_st1_Click(object sender, EventArgs e)
        {
            COneCycle cOC = new COneCycle("외발 자전거");
            lbl_item.Text = cOC.strName;

            Graphics g = panel1.CreateGraphics();
            Pen p = cOC.fPneInfo();
            g.DrawRectangle(p, cOC._rtSquare1);
            g.DrawEllipse(p, cOC._rtCircle1);


            //CBase cb = new CBase();
            //Graphics g = panel1.CreateGraphics();
            //Pen p = new Pen(Color.Blue);
            //g.DrawRectangle(p, 50, 50, 100, 150);
        }
    }
}
