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
        Graphics graphics;
        Pen MinePen = new Pen(Color.Black, 9);
        Pen dashed_pen = new Pen(Color.Red, 7);
        Pen tmpPen;
        float width;

        private List<LineList> MyLines = new List<LineList>();
        //public Point MouseDownLocation;
        private bool IsMouseDown = false;
        private int m_StartX;
        private int m_StartY;
        private int m_CurX;
        private int m_CurY;
        //private string DrawCase = "Line";
        //Point Point1 = new Point();
        //Point Point2 = new Point();
        Point StartDownLocation = new Point();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //pen = new Pen(Color.Red, 10);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MinePen.DashStyle = DashStyle.Solid;
            IsMouseDown = true;
            m_StartX = e.X;
            m_StartY = e.Y;
            m_CurX = e.X;
            m_CurY = e.Y;
            StartDownLocation = e.Location;
            width = MinePen.Width;
            tmpPen = new Pen (MinePen.Color,MinePen.Width);

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //Pen dashed_pen = new Pen(Color.Red, 1);
            //dashed_pen.DashStyle = DashStyle.Solid;
            if (IsMouseDown == false)
            {
                return;
            }
            m_CurX = e.X;
            m_CurY = e.Y;

            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            if (e.Button == MouseButtons.Left)
            {
                LineList DrawLine = new LineList(m_StartX, m_StartY, m_CurX, m_CurY, tmpPen.Color, width, tmpPen.DashStyle);
               
                MyLines.Add(DrawLine);
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int x1, y1, x2, y2;
            for (int i = 0; i <= MyLines.Count - 1; i++)
            {
                
                tmpPen= new Pen(MyLines[i].PenColor, MyLines[i].PenWidth);
                tmpPen.DashStyle = MyLines[i].PenDashStyle;
                x1 = MyLines[i].X1;
                x2 = MyLines[i].X2;
                y1 = MyLines[i].Y1;
                y2 = MyLines[i].Y2;
                tmpPen.EndCap = LineCap.ArrowAnchor;
                e.Graphics.DrawLine(tmpPen, x1, y1, x2, y2);
            }

            if (IsMouseDown == true)
            {
                dashed_pen.DashStyle = DashStyle.Dash;
                e.Graphics.DrawLine(MinePen, m_StartX, m_StartY, m_CurX, m_CurY);
            }
        }

        private void SwitchColorPaintig(Color color, Pen pen)
        {
            pen.Color = color;
        }

        private void SwitchWeightPaintig(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
                MinePen.Width = Convert.ToInt32(toolStripMenuItem.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
                width = Convert.ToInt32(toolStripMenuItem.Name);
            }


        }
    }
}
