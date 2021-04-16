using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;
using System.Drawing;

namespace UMLDiagram
{
    public abstract class AbstractArrow
    {
        protected AbstractCap cap;
        protected AbstractLine line;

        public Point _startPoint { get; set; } // like mCur
        public Point _endPoint { get; set; }

        public AbstractArrow(AbstractCap absCap, AbstractLine absLine)
        {
            cap = absCap;
            line = absLine;
        }

        public abstract void Draw(Graphics graphics, Pen pen, Point end,Point start);
        //public List<Point> GetPoints(Point _startPoint)
        //{
        //    return new List<Point>(CalculatePoints(_startPoint));

        //}
        //private List<Point> CalculatePoints(Point _startPoint)
        //{
        //    List<Point> points = new List<Point>();

        //    double arrow_lenght = 15;
        //    double arrow_degrees = 300;

        //    double x1, y1, x2, y2, x3, y3, x4, y4;


        //    double angle = Math.Atan2(_startPoint.Y - _endPoint.Y, _startPoint.X - _endPoint.X) + Math.PI; // угол поворота линии

        //    x1 = _startPoint.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
        //    y1 = _startPoint.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);

        //    x2 = _startPoint.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
        //    y2 = _startPoint.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);

        //    x3 = _startPoint.X - 30 * Math.Cos(angle);
        //    y3 = _startPoint.Y - 30 * Math.Sin(angle);

        //    x4 = _startPoint.X + 30 * Math.Cos(angle);
        //    y4 = _startPoint.Y + 30 * Math.Sin(angle);

        //    points.Add(new Point(Convert.ToInt32(x1), Convert.ToInt32(y1)));
        //    points.Add(new Point(Convert.ToInt32(x3), Convert.ToInt32(y3)));
        //    points.Add(new Point(Convert.ToInt32(x2), Convert.ToInt32(y2)));
        //    points.Add(new Point(Convert.ToInt32(x4), Convert.ToInt32(y4)));

        //    return points;
        //}
    }
}
