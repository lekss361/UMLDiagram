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

                double angle, arrow_lenght = 15, arrow_degrees = 0.5, x1, y1, x2, y2;
                int hightTriangle;

                hightTriangle = Convert.ToInt32(arrow_lenght * Math.Sqrt(3) / 2);

                angle = Math.Atan2(m_Cur.Y - m_Start.Y, m_Cur.X - m_Start.X) + Math.PI;

                x1 = m_Cur.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
                y1 = m_Cur.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);
                x2 = m_Cur.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
                y2 = m_Cur.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);

                Point x1y1 = new Point(Convert.ToInt32(x1), Convert.ToInt32(y1));
                Point x2y2 = new Point(Convert.ToInt32(x2), Convert.ToInt32(y2));
           
                e.Graphics.DrawLine(MinePen, m_Cur, x1y1);
                e.Graphics.DrawLine(MinePen, m_Cur, x2y2);

                // полая стрелка
                //e.Graphics.DrawLine(MinePen, x1y1, x2y2); 

                // ромб

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
                // MinePen.DashStyle = toolStripMenuItem.Text;
            }
        }

    }
}
