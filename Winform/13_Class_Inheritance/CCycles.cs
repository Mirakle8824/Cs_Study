using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Class_Inheritance
{
    class CCycles : CBase
    {
        public Rectangle _rtCircle1;
        public Rectangle _rtCircle2;
        public Rectangle _rtSquare1;

        public CCycles(string sName)
        {
            strName = sName;
            _Pen = new Pen(Color.Black, 3);

            _rtCircle1 = new Rectangle(30, 150, 120, 120);
            _rtCircle2 = new Rectangle(210, 150, 120, 120);
            _rtSquare1 = new Rectangle(60, 90, 240, 60);
        }

        public Pen fPneInfo()
        {
            return _Pen;
        }

        /// <summary>
        /// 외부에서 그림의 위치를 이동시키는 함수를 호출
        /// </summary>
        /// <param name="iMove"></param>
        public void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fCircle2Move(iMove);
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
        /// 바퀴2의 위치를 가져와서 X 위치값을 이동 시키고 다시 바퀴1에 위치 정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fCircle2Move(int iMove)
        {
            Point oPoint = _rtCircle2.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle2.Location = oPoint;
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

    }
}
