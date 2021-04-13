using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using UMLDiagram.Arrows.CapTypes;

namespace UMLDiagram.Arrows
{
    public class AssociationArrow : AbstractArrow
    {

        public override void Draw( Graphics graphics, Pen pen)
        {
            DrawAssociationLine(graphics, pen);
        }

        private void DrawAssociationLine(Graphics graphics, Pen pen)
        {        

            graphics.DrawLine(pen, EndPoint, StartPoint); // тут рисуем линию 
            //graphics.DrawLine(pen, x3y3, x1y1);
            //graphics.DrawLine(pen, x3y3, x2y2);
            ArrowCap arrowCap = new ArrowCap();
            arrowCap.StartPoint = StartPoint;
            arrowCap.EndPoint = EndPoint;
            arrowCap.GetPoints();
            arrowCap.Draw(graphics, pen);

            //Point[] capPoints = GetPoints().ToArray();
            //graphics.DrawLine(pen, capPoints[2], capPoints[0]);
            //graphics.DrawLine(pen, capPoints[2], capPoints[1]);

        }

    }
}
