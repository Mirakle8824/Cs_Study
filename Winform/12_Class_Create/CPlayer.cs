using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Class_Create
{
    class CPlayer
    {
        //public int iSun = 0;
        //public int iMoon = 0;
        //public int iStar = 0;

        //public int iCardSum = 0;

        //public int iCount = 0;


        public int cardsum(int iSun, int iMoon, int iStar)
        {
            return iSun + iMoon + iStar;
        }

        public string resultText(int iCount, int iCardSum, int iSun, int iMoon, int iStar)
        {
            return string.Format("{0}회: 해:{1}, 달:{2}, 별: {3} => 합계는 {4} 입니다. ", iCount, iSun, iMoon, iStar, iCardSum);
        }

        public string PlayerPair(int iCount, int iP1CardSum, int iP2CardSum)
        {
            int iCheck = iP1CardSum - iP2CardSum;

            if(iCheck > 0)
            {
                return string.Format("{0} 회차 : Player 1이 {1} 만큼 크다.", iCount, iCheck);
            }
            else if(iCheck < 0)
            {
                return string.Format("{0} 회차 : Player 2가 {1} 만큼 크다.", iCount, Math.Abs(iCheck));
            }
            else
            {
                return string.Format("{0} 회차 : Player 1이 Player 2와 같다.", iCount);
            }

        }

        public string PlayerResult(int iP1CardSum, int iP2CardSum)
        {
            string strReturn = string.Empty;

            if (iP1CardSum > iP2CardSum)
            {
                strReturn = "Player1이 이겼습니다.";
            }
            else if (iP1CardSum < iP2CardSum)
            {
                strReturn = "Player2이 이겼습니다.";
            }
            else
            {
                strReturn = "비겼습니다.";
            }

            return strReturn;
        }
    }
}
