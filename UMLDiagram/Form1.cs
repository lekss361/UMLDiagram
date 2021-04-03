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
        //Pen pen;

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
            IsMouseDown = true;
            m_StartX=e.X;
            m_StartY=e.Y;
            m_CurX=e.X;
            m_CurY=e.Y;
            StartDownLocation = e.Location;
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
                LineList DrawLine = new LineList();
                DrawLine.X1 = m_StartX;
                DrawLine.Y1 = m_StartY;                
                DrawLine.X2 = m_CurX;
                DrawLine.Y2 = m_CurY;
                MyLines.Add(DrawLine);
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int x1, y1, x2, y2;
            for (int i=0; i<= MyLines.Count-1; i++)
            {
                Pen LinePen = new Pen(Color.Black, 3);
                x1 = MyLines[i].X1;
                x2 = MyLines[i].X2;
                y1 = MyLines[i].Y1;
                y2 = MyLines[i].Y2;
                e.Graphics.DrawLine(LinePen, x1, y1, x2, y2);
            }

            if (IsMouseDown == true)
            {
                //Pen dashed_pen = new Pen(Color.Blue, 1);
                Pen dashed_pen = new Pen(Color.Red, 3);
                dashed_pen.DashStyle = DashStyle.Solid;
                e.Graphics.DrawLine(dashed_pen, m_StartX, m_StartY, m_CurX, m_CurY);
            }
        }
    }
}
