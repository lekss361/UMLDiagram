using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UMLDiagram
{
    public interface IMoveable
    {
        bool SelectFigure(Point point);

        void MoveStartPoint(int deltaX, int deltaY);
        void MoveEndPoint(int deltaX, int deltaY);
    }
}
