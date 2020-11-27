using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class circleClass: figureClass
    {
        protected int r;
        Pen line = new Pen(Color.Gray, 3);
        public circleClass(int x, int y, int r): base(x,y,r)
        {
            base.x = x;
            base.y = y;
            this.r = r;
        }

        public override void visualize(Graphics g)
        {
            g.DrawEllipse(this.line, x, y, r, r);
            
        }
    }
}
