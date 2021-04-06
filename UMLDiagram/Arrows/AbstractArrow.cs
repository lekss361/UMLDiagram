using System.Drawing;

namespace UMLDiagram.Arrows
{
   public abstract class AbstractArrow
    {
        public  Point StartPoint { get; set; }
        public  Point EndPoint { get; set; }

        public abstract void Draw(Graphics graphics);
    }
}
