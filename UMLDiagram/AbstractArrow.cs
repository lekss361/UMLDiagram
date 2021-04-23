using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;
using System.Drawing;
using System.Collections.Generic;
using System;

namespace UMLDiagram
{
    public abstract class AbstractArrow : IMoveable
    {
        protected AbstractCap cap;
        protected AbstractLine line;

        public Point _startPoint { get; set; }
        public Point _endPoint { get; set; }

        //public List<Point> GetStartAndEndPoints()
        //{
        //    List<Point> startAndEndLinePoints = new List<Point>();
        //    startAndEndLinePoints.Add(_startPoint);
        //    startAndEndLinePoints.Add(_endPoint);
        //    return startAndEndLinePoints;
        //}


        public AbstractArrow(AbstractCap absCap, AbstractLine absLine)
        {
            cap = absCap;
            line = absLine;
        }

        public abstract void Draw(Graphics graphics, Pen pen);

        public bool SelectPointLine(Point point)
        {
            //bool pointFocused = false;
            //List<Point> stEndPoints = GetStartAndEndPoints();

            //for (int i = 0; i < GetStartAndEndPoints().Count; i++)
            //{

            //    if (Math.Abs(stEndPoints[i].X - point.X) < 2
            //        && Math.Abs(stEndPoints[i].Y - point.Y) < 2)
            //    //if (startAndEndLinePoints.Contains(e.Location))
            //    {
            //        pointFocused = true;
            //    }
            //}
            //return pointFocused;

            int xMax;
            int xMin;
            int yMax;
            int yMin;

            if (_startPoint.X > _endPoint.X)
            {
                xMax = _startPoint.X;
                xMin = _endPoint.X;
            }
            else
            {
                xMin = _startPoint.X;
                xMax = _endPoint.X;
            }

            if (_startPoint.Y > _endPoint.Y)
            {
                yMax = _startPoint.Y;
                yMin = _endPoint.Y;
            }
            else
            {
                yMin = _startPoint.Y;
                yMax = _endPoint.Y;
            }

            if (point.X <= xMax && point.X >= xMin
             && point.Y <= yMax && point.Y >= yMin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(int deltaX, int deltaY)
        {
            _startPoint = new Point(_startPoint.X + deltaX, _startPoint.Y + deltaY);
            _endPoint = new Point(_endPoint.X + deltaX, _endPoint.Y + deltaY);
        }
    }
}
