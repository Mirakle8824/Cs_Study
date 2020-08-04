using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _13_Class_Inheritance
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

        public Pen fPneInfo()
        {
            return _Pen;
        }
    }
}
