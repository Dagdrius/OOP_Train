using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace train
{
    class coalLoadClass : figureClass
    {
        protected int load;
        SolidBrush paint = new SolidBrush(Color.Black);
        public coalLoadClass(int x, int y, int w, int l) : base(x, y, w)
        {
            base.x = x;
            base.y = y;
            base.w = w;
            this.load = l;
        }

        public override void visualize(Graphics g)
        {
            g.FillRectangle(this.paint, x + 4, y-load/5, w-8, load/5);
        }
    }
}