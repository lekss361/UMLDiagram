using System.Drawing;
using System.Windows.Forms;

namespace UMLDiagram.Arrows
{
    public abstract class AbstractArrow
    {

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


        public abstract void Draw( Graphics graphics, Pen pen);

    }
}
