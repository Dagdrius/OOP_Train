using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace train
{
    class rectangleClass: figureClass
    {
        protected int h;
        SolidBrush paint = new SolidBrush(Color.Gray);

        public rectangleClass (int x, int y, int w, int h): base(x, y, w)
        {
            base.x = x;
            base.y = y;
            base.w = w;
            this.h = h;
        }

        public override void visualize(Graphics g)
        {
            g.FillRectangle(this.paint, x, y, w, h);
        }
    }
}
