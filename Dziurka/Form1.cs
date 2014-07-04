using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace Dziurka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath sciezka = new GraphicsPath();
            sciezka.AddEllipse(0, 0, this.Width, this.Height);
            sciezka.AddEllipse(40, 40, Width-80, Height-80);
            Region = new Region(sciezka);
        }
    }
}
