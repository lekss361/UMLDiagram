using System;
using System.Drawing;

namespace UMLDiagram.Arrows
{
    public class AssociationArrow : AbstractArrow
    {
        public AssociationArrow()
        {
            _penForLine = new Pen(Color.Black);
        }
        public override void Draw(Point mCur, Point mStart, bool mouseDown, Graphics graphics, Pen pen)
        {
            DrawAssociationLine(mCur, mStart, mouseDown, graphics, pen);
        }
        public override void Draw(Point mCur, Point mStart, bool mouseDown, Graphics graphics, Pen penForLine, Pen penForF)
        {
            throw new NotImplementedException();
        }

        private void DrawAssociationLine(Point mCur, Point mStart, bool mouseDown, Graphics graphics)
        {
            Point x1y1, x2y2, x3y3;
            СalculationOfAngles(ref mCur, ref mStart, out x1y1, out x2y2, out x3y3);

            if (mouseDown == true)
            {
                graphics.DrawLine(_penForLine, mCur, mStart); // тут рисуем линию 
                graphics.DrawLine(_penForLine, x3y3, x1y1);
                graphics.DrawLine(_penForLine, x3y3, x2y2);

            }
        }
        private void DrawAssociationLine(Point mCur, Point mStart, bool mouseDown, Graphics graphics, Pen pen)
        {
            Point x1y1, x2y2, x3y3;
            СalculationOfAngles(ref mCur, ref mStart, out x1y1, out x2y2, out x3y3);

            if (mouseDown == true)
            {
                graphics.DrawLine(pen, mCur, mStart); // тут рисуем линию 
                graphics.DrawLine(pen, x3y3, x1y1);
                graphics.DrawLine(pen, x3y3, x2y2);

            }
        }

        public override void DrawCurvedLine(Graphics graphics)
        {
            throw new NotImplementedException();
        }


        protected void СalculationOfAngles(ref Point mCur, ref Point mStart, out Point x1y1, out Point x2y2, out Point x3y3)
        {
            arrow_lenght = 15;
            arrow_degrees = 300;
            int hightTriangle = Convert.ToInt32(arrow_lenght * Math.Sqrt(3) / 2);

            angle = Math.Atan2(mCur.Y - mStart.Y, mCur.X - mStart.X) + Math.PI; // угол поворота линии

            x1 = mCur.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
            y1 = mCur.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);
            x2 = mCur.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
            y2 = mCur.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);
            x3 = mCur.X - 30 * Math.Cos(angle);
            y3 = mCur.Y - 30 * Math.Sin(angle);

            x1y1 = new Point(Convert.ToInt32(x1), Convert.ToInt32(y1));
            x2y2 = new Point(Convert.ToInt32(x2), Convert.ToInt32(y2));
            x3y3 = new Point(Convert.ToInt32(x3), Convert.ToInt32(y3));
        }
    }
}
