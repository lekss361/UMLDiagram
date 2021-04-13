using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows;

namespace UMLDiagram.Arrows
{
    public class InheritanceArrow : AssociationArrow
    {
        public InheritanceArrow()// пустой конструктор
        {

        }
        public InheritanceArrow(Pen pen) // конструтор с 1 карандашом 
        {
            _penForLine = pen;
        }
        public InheritanceArrow(Pen pen1, Pen pen2) // c2 
        {
            _penForLine = pen1;
            _penForArrow = pen2;

        }


        private void DrawInheritanceArrow(Point mCur, Point mStart, Graphics graphics)
        {
            Point x1y1, x2y2, x3y3;
            СalculationOfAngles(ref mCur, ref mStart, out x1y1, out x2y2, out x3y3);

                graphics.DrawLine(_penForArrow, mCur, mStart); // тут рисуем линию 
                graphics.DrawLine(_penForLine, x3y3, x1y1);
                graphics.DrawLine(_penForLine, x3y3, x2y2);
                graphics.DrawLine(_penForLine, x1y1, x2y2);
        }
        private void DrawInheritanceArrow(Point mCur, Point mStart, Graphics graphics, Pen pen)
        {
            Point x1y1, x2y2, x3y3;
            СalculationOfAngles(ref mCur, ref mStart, out x1y1, out x2y2, out x3y3);

                graphics.DrawLine(pen, mCur, mStart); // тут рисуем линию 
                graphics.DrawLine(pen, x3y3, x1y1);
                graphics.DrawLine(pen, x3y3, x2y2);
                graphics.DrawLine(pen, x1y1, x2y2);
        }

        private void DrawInheritanceArrow(Point mCur, Point mStart, Graphics graphics, Pen penForLine, Pen penForF)
        {
            Point x1y1, x2y2, x3y3;
            СalculationOfAngles(ref mCur, ref mStart, out x1y1, out x2y2, out x3y3);

                graphics.DrawLine(penForF, mCur, mStart); // тут рисуем линию 
                graphics.DrawLine(_penForLine, x3y3, x1y1);
                graphics.DrawLine(_penForLine, x3y3, x2y2);
                graphics.DrawLine(_penForLine, x1y1, x2y2);
        }

        public override void Draw(Point mCur, Point mStart, Graphics graphics, Pen pen)
        {
            DrawInheritanceArrow(mCur, mStart,  graphics, pen);
        }
        public override void Draw(Point mCur, Point mStart,  Graphics graphics, Pen penForLine, Pen penForF)
        {
            DrawInheritanceArrow(mCur, mStart, graphics, penForLine, penForF);
        }

        public override void DrawCurvedLine(Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}
