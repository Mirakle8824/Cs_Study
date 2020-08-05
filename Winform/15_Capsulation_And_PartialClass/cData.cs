﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Capsulation_And_PartialClass
{


    partial class cData
    {

        private double _dTotalPrice = 0.0;
        public double DTotalPrice
        {
            get
            {
                return _dTotalPrice;
            }

            set
            {
                _dTotalPrice = _dTotalPrice + value;
            }
        }

        private string _strItem = string.Empty;

        public string Stritem
        {
            //get
            //{
            //    return stritem;
            //}

            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    _strErrorName = "물건이 선택되지 않았습니다.";
                }
                else
                {
                    _strItem = value;
                }
            }
        }




        private int _iRate = 0;
        public int IRate
        {
            //get => _iRate;
            set
            {
                if (value > 20)   // 값이 들어 올 경우 정합성 확인 후 사용
                {
                    _strErrorName = "사장님만 가능 한 할인 입니다.";
                }
                else
                {
                    _iRate = value;
                }
            }
        }




        private int _iCount = 0;
        public int ICount
        {
            //get => _iCount;
            set
            {
                if (value > 5)   // 값이 들어 올 경우 정합성 확인 후 사용
                {
                    _strErrorName = "개별 물품은 5개이상 살수 없습니다.";
                }
                else if (value == 0)
                {
                    _strErrorName = "물품의 개수가 0개 입니다.";
                }
                else
                {
                    _iCount = value;
                }
            }
        }


        private string _strErrorName = string.Empty;
        public string StrErrorName
        {
            get
            {
                return _strErrorName;
            }

            //set
            //{
            //    _strErrorName = value;
            //}
        }

        
    }

    /// <summary>
    /// 수식 계산
    /// </summary>
    partial class cData
    {
        /// <summary>
        /// 가지고 있는 내부 값들을 가지고 할인된 가격을 반환
        /// </summary>
        /// <returns></returns>
        public double fItemPrice()
        {
            double dPrice = 0;

            int iItemPrice = 0;

            if (String.IsNullOrEmpty(_strErrorName))  // Error 가 없으면 정상 값들을 받았다
            {
                iItemPrice = (int)Enum.Parse(typeof(Enumitem), _strItem);

                dPrice = iItemPrice - Math.Round((double)iItemPrice * (double)_iRate / 100, 2);
            }

            return dPrice * _iCount;
        }
    }

    /// <summary>
    /// 문자열
    /// </summary>
    partial class cData
    {
        /// <summary>
        /// 화면에 값을 보여주기 위해서 문자열을 생성
        /// </summary>
        /// <param name="dPrice"></param>
        /// <returns></returns>
        public string fResult(double dPrice)
        {
            if (_iRate == 0)
            {
                return string.Format("{0} X {1} : {2}원", _strItem, _iCount, dPrice);
            }
            else
            {
                return string.Format("{0} X {1} : {2}원 (할인율 : {3}%)", _strItem, _iCount, dPrice, _iRate);
            }
        }

        /// <summary>
        /// 내부 변수값들을 초기화 시킴 (외부에서 초기화를 못시키도록 만들어 놓았기 때문에 초기화 하는 함수를 만들어서 사용)
        /// </summary>
        public void fDataResult()
        {
            _strErrorName = string.Empty;
            _strItem = string.Empty;
            _iRate = 0;
            _iCount = 0;
        }
    }



}
