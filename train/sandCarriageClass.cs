using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class sandCarriageClass: carriageClass
    {
        sandLoadClass sand;
        public sandCarriageClass (int x, int y,int w, int h, int l): base(x, y, w, h, l)
        {
            base.x = x;
            base.y = y;
            base.w = w;
            base.h = h;
            this.load = l;
        }

        public override void visualize(Graphics g)
        {
            sand = new sandLoadClass(x, y, w, load);
            base.visualize(g);
            sand.visualize(g);
        }
    }
}
