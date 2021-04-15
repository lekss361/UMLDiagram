using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDiagram.Arrows.LineTypes
{
    public class DashLine : AbstractLine
    {
        public override void DrawLine(Graphics graphics, Pen pen)
        {
            Pen dashPen = new Pen(pen.Color, pen.Width);
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            graphics.DrawLine(dashPen, aFigure.StartPoint, aFigure.EndPoint);
        }
    }
}
