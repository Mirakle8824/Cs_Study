using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _14_Override_And_Overload
{
    class COneCycle : CBase
    {
        public Rectangle _rtCircle1;
        public Rectangle _rtSquare1;

        public COneCycle(string sName)
        {
            strName = sName;
            _Pen = new Pen(Color.WhiteSmoke, 3);

            _rtCircle1 = new Rectangle(120, 150, 120, 120);
            _rtSquare1 = new Rectangle(150, 30, 60, 120);
        }

        public virtual void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fSquare1Move(iMove);
        }

        /// <summary>
        /// 바퀴1의 위치를 가져와서 X 위치값을 이동 시키고 다시 바퀴1에 위치 정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fCircle1Move(int iMove)
        {
            Point oPoint = _rtCircle1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle1.Location = oPoint;
        }

        /// <summary>
        /// 몸통1의 위치를 가져와서 X 위치값을 이동 시키고 다시 바퀴1에 위치 정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fSquare1Move(int iMove)
        {
            Point oPoint = _rtSquare1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare1.Location = oPoint;
        }

        public Pen fPneInfo()
        {
            return _Pen;
        }

        public Pen fPneInfo(Color oColor)
        {
            _Pen = new Pen(oColor);
            return _Pen;
        }

        public Pen fPneInfo(Color oColor, int iWidth)
        {
            _Pen = new Pen(oColor, iWidth);

            return _Pen;
        }

    }
}
