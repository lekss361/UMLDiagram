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
        Bitmap bitmap;
        Bitmap tmpBitmap;
        Graphics graphics;
        Pen MinePen = new Pen(Color.Black, 9);
        Pen tmpPen = new Pen(Color.Black, 100);
        private bool IsMouseDown = false;
        private Point m_Start;
        private Point m_Cur;

        private List<LineList> MyLines = new List<LineList>();
        //public Point MouseDownLocation;
        //private string DrawCase = "Line";
        //Point Point1 = new Point();
        //Point Point2 = new Point();
        //Point StartDownLocation = new Point();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            tmpBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;

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
                m_Cur = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            IsMouseDown = false;
            graphics.DrawLine(MinePen, m_Start, e.Location);
            //MinePen.Width = 100f;
            //MinePen.EndCap = LineCap.Triangle;
            //MinePen.Width = 9f;
            //PaintingTriangle(MinePen, m_Cur);
            MyLines.Add(new LineList(m_Start,m_Cur,MinePen.Color,MinePen.Width, MinePen.DashStyle));        
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (IsMouseDown == true)
            {
                e.Graphics.DrawLine(MinePen, m_Start, m_Cur);
                //MinePen.Width = 100f;
                //MinePen.EndCap = LineCap.Triangle;
                //MinePen.Width = 9f;
                //PaintingTriangle(MinePen, m_Cur,e);
                //inheritanceButton_Click(MinePen, start, end);

                MinePen.DashStyle = DashStyle.Solid;
                MinePen.Width = 3;
                DrawLineTriangleCap(e,m_Cur,m_Start);

                // полая стрелка
                //

                // ромб

            }
        }

        private void DrawLineTriangleCap(PaintEventArgs e , Point mCur, Point mStart)
        {
            double angle;
            double arrow_lenght =15;
            double arrow_degrees = 300; // размах крыльев или острота угла 
            double x1, y1, x2, y2, x3, y3;


            int hightTriangle;

            hightTriangle = Convert.ToInt32(arrow_lenght * Math.Sqrt(3) / 2) ;

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
            //x1y1.X += 30;
            //x1y1.Y += 30;
            //x2y2.Y += 30;
            //x2y2.X += 30;
            //mCur.X += 30;
            //mCur.Y += 30;

            e.Graphics.DrawLine(MinePen, x3y3, x1y1);
            e.Graphics.DrawLine(MinePen, x3y3, x2y2);
            e.Graphics.DrawLine(MinePen, x1y1, x2y2);
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
                // MinePen.DashStyle = toolStripMenuItem.Text;
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

    }
}
