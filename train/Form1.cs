using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace train
{
    public partial class Form : System.Windows.Forms.Form
    {
        trainClass train;
        Graphics g;
        public Form()
        {
            InitializeComponent();
            g = panel.CreateGraphics();
        }

        private void vizualizeB_Click(object sender, EventArgs e)
        {
            panel.Refresh();
            train = new trainClass(10, 50, 100, 50);
            train.vizualizeTrain(g);
            label.Text = train.info();
        }

        
    }
}
