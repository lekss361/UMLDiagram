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

namespace UMLDiagram
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        Pen MinePen = new Pen(Color.Black, 9);
        Pen _penForArrow;
        
        private bool IsMouseDown = false;
        private Point m_Start;
        private Point m_Cur;

        private List<LineList> MyLines = new List<LineList>();
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            m_Start = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

               m_Cur = e.Location;
             
               DrawLineTriangleCap(m_Cur, m_Start,IsMouseDown);
                pictureBox1.Image = _tmpBitmap;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            IsMouseDown = false;
            
            _mainBitmap = _tmpBitmap;
            MyLines.Add(new LineList(m_Start,m_Cur,MinePen.Color,MinePen.Width, MinePen.DashStyle));        
        }

        private void DrawLineTriangleCap(Point mCur, Point mStart, bool mouseDown)
        {
            double angle;
            double arrow_lenght = 15;
            double arrow_degrees = 300; // размах крыльев или острота угла 
            double x1, y1, x2, y2, x3, y3;


            int hightTriangle;

            hightTriangle = Convert.ToInt32(arrow_lenght * Math.Sqrt(3) / 2);

            angle = Math.Atan2(mCur.Y - mStart.Y, mCur.X - mStart.X) + Math.PI; // угол поворота линии


            x1 = mCur.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
            y1 = mCur.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);
            x2 = mCur.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
            y2 = mCur.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);
            x3 = mCur.X - 30 * Math.Cos(angle);
            y3 = mCur.Y - 30 * Math.Sin(angle);


            Point x1y1 = new Point(Convert.ToInt32(x1), Convert.ToInt32(y1));
            Point x2y2 = new Point(Convert.ToInt32(x2), Convert.ToInt32(y2));
            Point x3y3 = new Point(Convert.ToInt32(x3), Convert.ToInt32(y3));
            
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 255, 0, 0)); // кисть для закрашивания треуголника

            if (mouseDown == true)
            {
                _graphics.DrawLine(MinePen, mCur, mStart); // тут рисуем линию 
                _graphics.DrawLine(MinePen, x3y3, x1y1);
                _graphics.DrawLine(MinePen, x3y3, x2y2);
                _graphics.DrawLine(MinePen, x1y1, x2y2);
                Point[] pointF = new Point[] { x3y3, x2y2, x1y1 }; // массив точек для закрашивания треугольника 
                _graphics.FillPolygon(solidBrush, pointF); // закрашиваем треуголник 

            }

        }
        private void DrawImplementationLine(Point mCur, Point mStart, bool mouseDown)
        {
            double angle;
            double arrow_lenght = 15;
            double arrow_degrees = 300; // размах крыльев или острота угла 
            double x1, y1, x2, y2, x3, y3;
            int hightTriangle;

            hightTriangle = Convert.ToInt32(arrow_lenght * Math.Sqrt(3) / 2);
            angle = Math.Atan2(mCur.Y - mStart.Y, mCur.X - mStart.X) + Math.PI; // угол поворота линии


            x1 = mCur.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
            y1 = mCur.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);
            x2 = mCur.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
            y2 = mCur.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);
            x3 = mCur.X - 30 * Math.Cos(angle);
            y3 = mCur.Y - 30 * Math.Sin(angle);


            Point x1y1 = new Point(Convert.ToInt32(x1), Convert.ToInt32(y1));
            Point x2y2 = new Point(Convert.ToInt32(x2), Convert.ToInt32(y2));
            Point x3y3 = new Point(Convert.ToInt32(x3), Convert.ToInt32(y3));

            if (mouseDown == true)
            {
                _penForArrow= new Pen (Color.Black,MinePen.Width);
                _penForArrow.DashStyle = DashStyle.Dash;
                _graphics.DrawLine(_penForArrow, mCur, mStart); // тут рисуем линию . От другого метода тут меняется только кисть для рисования линии
                _graphics.DrawLine(MinePen, x3y3, x1y1);
               _graphics.DrawLine(MinePen, x3y3, x2y2);
                _graphics.DrawLine(MinePen, x1y1, x2y2);
               

            }

        }

        private void SwitchColorPaintig(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            MinePen.Color = colorDialog1.Color;
            colorLineButton.BackColor = colorDialog1.Color;
        }

        private void SwitchWeightPaintig(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
                MinePen.Width = Convert.ToInt32(toolStripMenuItem.Text);
            }
        }
        private void SwitchtTypesLinePaintig(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
                switch (toolStripMenuItem.Text)
                {
                    case ("Solid"):
                        MinePen.DashStyle = DashStyle.Solid;
                    break;
                    case ("Dash"):
                        MinePen.DashStyle = DashStyle.Dash;
                    break;
                    default:
                        break;
                }
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void PaintingTriangle(Pen pen, Point point, PaintEventArgs e)
        {
            Pen tmpPen = new Pen(pen.Color,pen.Width);
            tmpPen.Color = Color.Red;
            Point point1 = new Point(point.X, point.Y - 50);
            Point point2 = new Point(point.X, point.Y + 50);
            Point point3 = new Point(point.X+50, point.Y);
            Point[] trianglePoints =
            {
                point1,point2,point3,point1
            };
           //e.Graphics.DrawLine(tmpPen, point.X, point.Y,point.X,point.Y+30);
           //e.Graphics.DrawLine(tmpPen, point.X, point.Y+30,point.X+40,point.Y);
           //e.Graphics.DrawLine(tmpPen, point.X+40, point.Y,point.X,point.Y-30);
           //e.Graphics.DrawLine(tmpPen, point.X, point.Y-30,point.X,point.Y);
           
            
             

            // Draw polygon to screen.
           // e.Graphics.DrawPolygon(tmpPen, trianglePoints);
        }

        private void implementationButton_Click(object sender, EventArgs e)
        {
            DrawImplementationLine(m_Cur, m_Start, IsMouseDown);
        }
    }
}
