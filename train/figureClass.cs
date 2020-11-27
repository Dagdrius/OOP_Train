using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace train
{
    class figureClass
    {
        protected int x;
        protected int y;
        protected int w;

        public figureClass(int x, int y, int w)
        {
            this.x = x;
            this.y = y;
            this.w = w;
        }

        public virtual void visualize(Graphics g)
        {

        }
    }
}
