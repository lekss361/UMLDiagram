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

        public override Point StartPoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Draw(Graphics graphics, Pen pen, List<Point> points)
        {
            
            base.RealisationDraw(graphics, pen, GetPoints(StartPoint));
        }

        public override List<Point> GetPoints(Point startPoint)
        {
            
            return base.RealisationGetPoints(startPoint);
        }
    }
}
