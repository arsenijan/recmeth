using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recmeth
{
    public partial class Form1 : Form
    {
        private int _centr_x = Screen.PrimaryScreen.Bounds.Width / 2;
        private int _centr_y = Screen.PrimaryScreen.Bounds.Height / 2;
        private int _hypotenuse = 0;
        private int _leftPointx = 0;
        private int _leftPointy = 0;
        private void MyDraw(Graphics g, int N, int x, int y)
        {
            if (N == 0) { return; }
            else
            {
                _hypotenuse = Convert.ToInt32(Math.Round(x * (Math.Pow(2, 1 / 2)) / 2, 0).ToString());
                _leftPointx = _centr_x - _hypotenuse;
                _leftPointy = _centr_y - _hypotenuse;
                g.DrawRectangle(new Pen(Brushes.Blue, 2), _leftPointx, _leftPointy, x, y);
                x += 50;
                y += 50;
                N--;
                MyDraw(g, N, x, y);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MyDraw(g, 7, 50, 50);
        }
    }
}
