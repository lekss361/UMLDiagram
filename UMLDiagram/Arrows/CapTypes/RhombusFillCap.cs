using System.Drawing;


namespace UMLDiagram.Arrows.CapTypes
{
    public class RhombusFillCap : AbstractCap
    {
        public override void DrawCap(Graphics graphics, Pen pen)
        {
            //graphics.DrawLines(pen, GetPoints().ToArray());
            Point[] capPoints = GetPoints().ToArray();
            graphics.DrawLine(pen, capPoints[2], capPoints[0]);
            graphics.DrawLine(pen, capPoints[2], capPoints[1]);
            graphics.DrawLine(pen, capPoints[0], capPoints[3]);
            graphics.DrawLine(pen, capPoints[1], capPoints[3]);

            SolidBrush solidBrush = new SolidBrush(pen.Color); // кисть для закрашивания треуголника
            Point[] pointF = new Point[] { capPoints[2], capPoints[1], capPoints[0], capPoints[3], capPoints[1], capPoints[0] }; // массив точек для закрашивания треугольника 
            graphics.FillPolygon(solidBrush, pointF); // закрашиваем треуголник 
        }
    }
}
