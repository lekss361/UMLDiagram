using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;
using System.Drawing;
using System.Collections.Generic;
using System;


namespace UMLDiagram
{
    public interface IFigure : IMoveable
    {        
        Pen PenFigure { get; set; }
        void Draw(Graphics graphics, Pen pen);
    }
}
