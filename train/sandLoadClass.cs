using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace train
{
    class sandLoadClass: figureClass
    {
        protected int load;
        SolidBrush paint = new SolidBrush(Color.Yellow);
        public sandLoadClass (int x, int y, int w, int l): base(x, y, w)
        {
            base.x = x;
            base.y = y;
            base.w = w;
            this.load = l;
        }

        public override void visualize(Graphics g)
        {
            Point l = new Point(x + 3, y);
            Point m = new Point(x + w / 2, y - load / 5);
            Point r = new Point(x + w - 3, y);
            Point[] triangle = { l, m, r };
            g.FillPolygon(this.paint, triangle);
        }
    }
}
