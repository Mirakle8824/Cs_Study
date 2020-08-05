﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Capsulation_And_PartialClass
{
    public partial class Form1 : Form
    {
        cData _Data = new cData();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Enumitem[] ei = (Enumitem[])Enum.GetValues(typeof(Enumitem));

            foreach (Enumitem eitem in ei)
            {
                cbox_item.Items.Add(eitem.ToString());
            }

            foreach (EnumRate eitem in (Enumitem[])Enum.GetValues(typeof(EnumRate)))
            {
                cbox_disc.Items.Add(eitem.ToString());
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            _Data.fDataResult();  // cData에 있는 변수 값들을 초기화 시킴

            _Data.Stritem = cbox_item.Text;
            _Data.IRate = (int)Enum.Parse(typeof(EnumRate), cbox_disc.Text);  // 문자 형태로 가지고 있는 Enum 값을 int 형태로 변환 시킴 (Enum을 많이 쓰시면 자주 사용 됩니다.)
            _Data.ICount = (int)num_updown.Value;

            if (!String.IsNullOrEmpty(_Data.StrErrorName))   // Error Data가 있을 경우 tboxErrorMsg에 Error 내용을 보여주고 종료
            {
                tbox_error.Text = _Data.StrErrorName;
                return;
            }

            //Error가 없을 경우 아래 할인 가격을 계산하는 Logic을 수행 후 ListBox에 값을 뿌려줌.

            double dPrice = _Data.fItemPrice();
            lbox_item.Items.Add(_Data.fResult(dPrice));

            _Data.DTotalPrice = dPrice;
            tbox_result.Text = _Data.DTotalPrice.ToString() + "원";

        }
    }
}
