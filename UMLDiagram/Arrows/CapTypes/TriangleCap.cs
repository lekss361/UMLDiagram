using System.Drawing;


namespace UMLDiagram.Arrows.CapTypes
{
    public class TriangleCap : AbstractCap
    {
        public override void DrawCap(Graphics graphics, Pen pen)
        {
            ////graphics.DrawLines(pen, GetPoints().ToArray());
            Point[] capPoints = GetPoints().ToArray();
            graphics.DrawLine(pen, capPoints[2], capPoints[0]);
            graphics.DrawLine(pen, capPoints[2], capPoints[1]);
            graphics.DrawLine(pen, capPoints[0], capPoints[1]);
        }
    }
}
