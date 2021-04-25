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

        void Move(int deltaX, int deltaY);
    }
}
