using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aversisale
{
    public partial class Form1 : Form
    {
        static Bitmap bmp;
        static Graphics g;

        private Point a, b, c, d, a1, b1, c1, d1, lhorizontal1, lhorizontal2, lvertical1, lvertical2;
        private Point a11, b11, c11, d11;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int grado;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            grado = int.Parse(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp); 
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new Point(0, 0);
            b = new Point(0, 100);
            c = new Point(100, 100);
            d = new Point(100, 0);
            int Sx = (bmp.Width / 2);
            int Sy = (bmp.Height / 2);
            int Sx1 = (bmp.Width / 2) - 50;
            int Sy1 = (bmp.Height / 2) - 50;
            lhorizontal1 = new Point(0, Sy);
            lhorizontal2 = new Point(bmp.Width, Sy);
            lvertical1 = new Point(Sx, 0);
            lvertical2 = new Point(Sx, bmp.Height);


            a1 = new Point(Sx + a.X, Sy + a.Y);
            b1 = new Point(Sx + b.X, Sy + b.Y);
            c1 = new Point(Sx + c.X, Sy + c.Y);
            d1 = new Point(Sx + d.X, Sy + d.Y);

            a11 = new Point((Sx1 + a.X), (Sy1 + a.Y));
            b11 = new Point((Sx1 + b.X), (Sy1 + b.Y));
            c11 = new Point((Sx1 + c.X), (Sy1 + c.Y));
            d11 = new Point((Sx1 + d.X), (Sy1 + d.Y));

            g.DrawLine(Pens.Yellow, lvertical1, lvertical2);
            g.DrawLine(Pens.Yellow, lhorizontal1, lhorizontal2);

           g.DrawLine(Pens.Blue, a11, b11);
           g.DrawLine(Pens.Blue, b11, c11);
           g.DrawLine(Pens.Blue, c11, d11);
           g.DrawLine(Pens.Blue, d11, a11);

            a1.X = (int)(Sx + (float)((a.X * Math.Cos(grado)) - (a.Y * Math.Sin(grado))));
            a1.Y = (int)(Sy - (float)((a.X * Math.Sin(grado)) + (a.Y * Math.Cos(grado))));
            b1.X = (int)(Sx + (float)((b.X * Math.Cos(grado)) - (b.Y * Math.Sin(grado))));
            b1.Y = (int)(Sy - (float)((b.X * Math.Sin(grado)) + (b.Y * Math.Cos(grado))));
            c1.X = (int)(Sx + (float)((c.X * Math.Cos(grado)) - (c.Y * Math.Sin(grado))));
            c1.Y = (int)(Sy - (float)((c.X * Math.Sin(grado)) + (c.Y * Math.Cos(grado))));
            d1.X = (int)(Sx + (float)((d.X * Math.Cos(grado)) - (d.Y * Math.Sin(grado))));
            d1.Y = (int)(Sy - (float)((d.X * Math.Sin(grado)) + (d.Y * Math.Cos(grado))));
           

            g.DrawLine(Pens.Red, a1, b1);
            g.DrawLine(Pens.Red, b1, c1);
            g.DrawLine(Pens.Red, c1, d1);
            g.DrawLine(Pens.Red, d1, a1);
            
            pictureBox1.Invalidate();
            
        }
    }
}
