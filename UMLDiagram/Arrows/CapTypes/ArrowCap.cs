using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Arrows.CapTypes
{
    class ArrowCap : AbstractCap
    {
        List<Point> points = new List<Point>();

        public override void Draw(Graphics graphics, Pen pen)
        {
            RealisationDraw(graphics, pen, points);
        }

        public override void Draws(Graphics graphics, Pen pen)
        {
            RealisationDraw(graphics, pen, points);
        }

        public override void GetPoints()
        {            
            points=RealisationGetPoints(StartPoint);
            points.RemoveAt(points.Count - 1);
        }
    }
}
