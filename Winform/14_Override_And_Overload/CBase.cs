using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _14_Override_And_Overload
{
    class CBase
    {
        public string strName;

        protected Pen _Pen;

        public CBase()
        {
            _Pen = new Pen(Color.Blue);
        }
    }
}
