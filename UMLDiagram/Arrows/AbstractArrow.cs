using System.Drawing;
using System.Windows.Forms;

namespace UMLDiagram.Arrows
{
    public abstract class AbstractArrow
    {
        public Pen _penForLine { get; set; }
        public Pen _penForArrow { get; set; }

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public double angle { get; set; }
        public double arrow_lenght { get; set; }

        public double arrow_degrees { get; set; }// размах крыльев или острота угла 

        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double x3 { get; set; }
        public double y3 { get; set; }
        public double x4 { get; set; }
        public double y4 { get; set; }

        //int hightTriangle;

        protected bool isClicked { get; set; }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            StartPoint = new Point(e.X, e.Y);
        }
        //public abstract void Draw(Point mCur, Point mStart, bool mouseDown, Graphics graphics);
        public abstract void Draw(Point mCur, Point mStart, bool mouseDown, Graphics graphics, Pen pen);
        public abstract void Draw(Point mCur, Point mStart, bool mouseDown, Graphics graphics, Pen penForLine, Pen penForF);

        public abstract void DrawCurvedLine(Graphics graphics);


    }
}
