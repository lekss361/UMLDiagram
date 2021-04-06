using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Arrows
{
    public class InheritanceArrow : AbstractArrow
    {
        List<Point> Points = new List<Point>();
        Pen penLine=new Pen(Color.Black, 9);
        Pen penCap;
        
        double arrow_lenght = 15;
        double arrow_degrees = 300;
        double angle;

        private void SetPointsLine(Point startpoint, Point endpoint)
        {
           angle = Math.Atan2(endpoint.Y - startpoint.Y, endpoint.X - startpoint.X) + Math.PI;
            Points.Add(startpoint);
            Point tmpPoint = new Point(endpoint.X,endpoint.Y);
            tmpPoint.X = (int)(endpoint.X - 30 * Math.Cos(angle));
            tmpPoint.Y = (int)(endpoint.X - 30 * Math.Sin(angle));
            Points.Add(tmpPoint);
        }

        private void SetPointsCap(Point endPoint)
        {
            Point fPoint=new Point(endPoint.X,endPoint.Y);
            Point twoPoint=new Point(fPoint.X,fPoint.Y);
            Point threePoint=new Point(twoPoint.X,twoPoint.Y);

            fPoint.X= (int)(endPoint.X - 15 * Math.Cos(90));
            fPoint.Y= (int)(endPoint.Y - 15 * Math.Sin(90));
            twoPoint.X= (int)(fPoint.X - 30 * Math.Cos(60));
            twoPoint.Y= (int)(fPoint.X - 30 * Math.Sin(60));
            threePoint.X= (int)(twoPoint.X - 30 * Math.Cos(60));
            threePoint.Y= (int)(twoPoint.X - 30 * Math.Sin(60));
            Points.Add(fPoint);
            Points.Add(twoPoint);
            Points.Add(threePoint);
            Points.Add(endPoint);
        }
        public override void Draw(Graphics graphics)
        {
            SetPointsLine(StartPoint, EndPoint);
            //SetPointsCap(EndPoint);
            graphics.DrawLines(penLine, Points.ToArray());
        }
    }
}
