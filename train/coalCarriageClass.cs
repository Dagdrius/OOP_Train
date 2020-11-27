using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace train
{
    class coalCarriageClass: carriageClass
    {
        coalLoadClass coal;
        public coalCarriageClass(int x, int y, int w, int h, int l) : base(x, y, w, h, l)
        {
            base.x = x;
            base.y = y;
            base.w = w;
            base.h = h;
            this.load = l;
        }

        
        public override void visualize(Graphics g)
        {
            coal = new coalLoadClass(x, y, w, load);
            base.visualize(g);
            coal.visualize(g);
        }
    }
}
