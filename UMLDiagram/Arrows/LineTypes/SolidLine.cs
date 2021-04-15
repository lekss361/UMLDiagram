using System.Drawing;


namespace UMLDiagram.Arrows.LineTypes
{
    public class SolidLine : AbstractLine
    {
        public override void DrawLine(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, aFigure.StartPoint, aFigure.EndPoint);
        }
    }
}
