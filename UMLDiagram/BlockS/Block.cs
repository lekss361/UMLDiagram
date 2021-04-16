using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.BlockS
{
    public class Block : AbstractBlock
    {
        int weigth;
        int heigth;
        public override void DrawBlock(Graphics graphics, Pen pen, Point end, Point start)
        {
            weigth = end.X - start.X;
            heigth = start.Y - end.Y;

            graphics.DrawRectangle(pen, start.X, end.Y,100,100);
        }
    }
}
