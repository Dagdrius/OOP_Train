using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;

namespace train
{
    class trainClass
    {
        int count, x, y, w, h;
        carriageClass[] train;
        Random random;
        int[] type;
        public trainClass(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        public void vizualizeTrain( Graphics g)
        {
            random = new Random();
            count = random.Next(1, 8);
            train = new carriageClass[count];
            type = new int[train.Length];
            for (int i = 0; i < train.Length; i++)
            {
                int carriageType = random.Next(0, 3);
                switch (carriageType)
                {
                    case 0:
                        {
                            train[i] = new carriageClass(x, y, w, h, 0);
                            train[i].visualize(g);
                            type[i] = 0;
                            x = x + w + 15;
                            break;
                        }

                    case 1:
                        {
                            train[i] = new coalCarriageClass(x, y, w, h, random.Next(1, 101));
                            train[i].visualize(g);
                            type[i] = 1;
                            x = x + w + 15;
                            break;
                        }

                    case 2:
                        {
                            train[i] = new sandCarriageClass(x, y, w, h, random.Next(1, 101));
                            train[i].visualize(g);
                            type[i] = 2;
                            x = x + w + 15;
                            break;
                        }
                }
            }
        }

        public string info()
        {
            string information;
            int[] ar = new int[3];
            for (int i = 0; i < type.Length; i++)
            {
                if (type[i] == 0) ar[0]++ ;
                if (type[i] == 1) ar[1]++;
                if (type[i] == 2) ar[2]++;
            }

            information = "empty carriages: " + ar[0] + Environment.NewLine + "carriages with coal: " + ar[1] + Environment.NewLine + "carriages with sand: " + ar[2];
            return information;
        }


    }
}
