using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Arrows
{
    class AddictionArrow : InheritanceArrow
    {

        public override void Draw(Point mCur, Point mStart, bool mouseDown, Graphics graphics, Pen pen)
        {
            DrawAddictionArrow(mCur, mStart, mouseDown, graphics, pen);
        }
        private void DrawAddictionArrow(Point mCur, Point mStart, bool mouseDown, Graphics graphics)
        {

            SolidBrush solidBrush = new SolidBrush(Color.Black); // кисть для закрашивания треуголника

            if (mouseDown == true)
            {
                //base.Draw(mCur, mStart, mouseDown, graphics);
                Point x1y1 = new Point(Convert.ToInt32(x1), Convert.ToInt32(y1));
                Point x2y2 = new Point(Convert.ToInt32(x2), Convert.ToInt32(y2));
                Point x3y3 = new Point(Convert.ToInt32(x3), Convert.ToInt32(y3));
                Point[] pointF = new Point[] { x3y3, x2y2, x1y1 }; // массив точек для закрашивания треугольника 
                graphics.FillPolygon(solidBrush, pointF); // закрашиваем треуголник 
            }

        }
        private void DrawAddictionArrow(Point mCur, Point mStart, bool mouseDown, Graphics graphics, Pen pen)
        {

            SolidBrush solidBrush = new SolidBrush(pen.Color); // кисть для закрашивания треуголника

            if (mouseDown == true)
            {
                base.Draw(mCur, mStart, mouseDown, graphics, pen);
                Point x1y1 = new Point(Convert.ToInt32(x1), Convert.ToInt32(y1));
                Point x2y2 = new Point(Convert.ToInt32(x2), Convert.ToInt32(y2));
                Point x3y3 = new Point(Convert.ToInt32(x3), Convert.ToInt32(y3));
                Point[] pointF = new Point[] { x3y3, x2y2, x1y1 }; // массив точек для закрашивания треугольника 
                graphics.FillPolygon(solidBrush, pointF); // закрашиваем треуголник 
            }

        }
    }
}
