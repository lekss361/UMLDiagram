using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMLDiagram
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Bitmap Savebitmap;
        Graphics graphics;
        Pen pen;
        Point startPoint;
        Point endPoint;
        bool mouseDown = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pen = new Pen(Color.Red, 10);
            //pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            Savebitmap = bitmap;
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            startPoint = e.Location;
            mouseDown = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            endPoint = e.Location;
            mouseDown = false;
            graphics.DrawLine(pen, startPoint, endPoint);
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                graphics.Clear(Color.White);
                pictureBox1.Image = Savebitmap;
                endPoint = e.Location;
                graphics.DrawLine(pen, startPoint, endPoint);
                pictureBox1.Image = bitmap;
            }
                Savebitmap = bitmap;
            if (true)
            {

            }
        }
    }
}
