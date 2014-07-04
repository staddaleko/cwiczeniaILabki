using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIMP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IRysuj rysuj = new Elipsa();

        private void Utworz_Figure_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem c = (ToolStripMenuItem)sender;
            switch (c.Tag.ToString())
            {
                case "elipsa": rysuj = new Elipsa();
                    break;
                case "prostokąt": rysuj = new Prostokat();
                    break;
                
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            rysuj.Rysuj(g ,new Point (e.X, e.Y));
            g.Dispose();
        }
    }
}
