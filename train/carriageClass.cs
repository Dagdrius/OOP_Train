using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace train
{
    class carriageClass: rectangleClass
    {
        protected int load;
        circleClass wheel1;
        circleClass wheel2;
        Font font = new Font("arial", 14);
        SolidBrush brush = new SolidBrush(Color.Black);
        Rectangle rectangle;
        StringFormat format = new StringFormat();
        public carriageClass (int x, int y, int w, int h, int l): base (x,y,w,h)
        {
            base.x = x;
            base.y = y;
            base.w = w;
            base.h = h;
            this.load = l;
        }

        public override void visualize(Graphics g)
        {
            int wheelY = y + h;
            int wheelD = h / 2;
            wheel1 = new circleClass(x, wheelY, wheelD);
            wheel1.visualize(g);
            wheel2 = new circleClass(x + w - wheelD, wheelY, wheelD);
            wheel2.visualize(g);
            base.visualize(g);
            format.Alignment = StringAlignment.Center;
            rectangle = new Rectangle(x + w / 2 - 20, y + h / 2 -10 , 40, 40);
            g.DrawString(Convert.ToString(load), this.font, this.brush, this.rectangle, this.format );
        }

    }
}
