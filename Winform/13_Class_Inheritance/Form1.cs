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
        COneCycle _cOC;
        CCycles _cC;
        CCar _cCar;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발 자전거");
            _cC = new CCycles("자전거");
            _cCar = new CCar("자동차");
        }

        private void btn_st1_Click(object sender, EventArgs e)
        {
            fClearPanel();
            OneCycleDraw();
        }

        private void OneCycleDraw()
        {
            lbl_item.Text = _cOC.strName;

            Graphics g = panel1.CreateGraphics();
            Pen p = _cOC.fPneInfo();
            g.DrawRectangle(p, _cOC._rtSquare1);
            g.DrawEllipse(p, _cOC._rtCircle1);
        }

        private void btn_st2_Click(object sender, EventArgs e)
        {
            fClearPanel();
            CyclesDraw();
        }

        private void CyclesDraw()
        {
            lbl_item.Text = _cC.strName;

            Graphics g = panel1.CreateGraphics();
            Pen p = _cC.fPneInfo();
            g.DrawRectangle(p, _cC._rtSquare1);
            g.DrawEllipse(p, _cC._rtCircle1);
            g.DrawEllipse(p, _cC._rtCircle2);
        }

        private void btn_st3_Click(object sender, EventArgs e)
        {
            fClearPanel();
            CarDraw();
        }

        private void CarDraw()
        {
            lbl_item.Text = _cCar.strName;

            Graphics g = panel1.CreateGraphics();
            Pen p = _cCar.fPneInfo();
            g.DrawRectangle(p, _cCar._rtSquare1);
            g.DrawRectangle(p, _cCar._rtSquare2);
            g.DrawEllipse(p, _cCar._rtCircle1);
            g.DrawEllipse(p, _cCar._rtCircle2);
        }




        private void fClearPanel()
        {
            panel1.Invalidate();
            Refresh();
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            fClearPanel();

            switch (lbl_item.Text)
            {
                case "외발 자전거":
                    _cOC.fMove(5);
                    OneCycleDraw();
                    break;
                case "자전거":
                    _cC.fMove(5);
                    CyclesDraw();
                    break;
                case "자동차":
                    _cCar.fMove(5);
                    CarDraw();
                    break;
                default:
                    break;
            }

        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            fClearPanel();
            switch (lbl_item.Text)
            {
                case "외발 자전거":
                    _cOC.fMove(-5);
                    OneCycleDraw();
                    break;
                case "자전거":
                    _cC.fMove(-5);
                    CyclesDraw();
                    break;
                case "자동차":
                    _cCar.fMove(-5);
                    CarDraw();
                    break;
                default:
                    break;
            }
        }
    }
}
