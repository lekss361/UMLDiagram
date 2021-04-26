using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;
using System.Drawing;
using System.Collections.Generic;
using System;

namespace UMLDiagram
{
    public abstract class AbstractArrow : IFigure
    {
        protected AbstractCap cap;
        protected AbstractLine line;

        public Point _startPoint { get; set; }
        public Point _endPoint { get; set; }
        public Pen PenFigure { get; set; }

        protected List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            points.Add(_startPoint);
            int middleX = (_endPoint.X + _startPoint.X) / 2;
            points.Add(new Point(middleX, _startPoint.Y));
            points.Add(new Point(middleX, _endPoint.Y));
            points.Add(_endPoint);
            return points;
        }

        //public void NewPoints(Point point)
        //{
        //    List<Point> stEndPoints = GetStartAndEndPoints();

        //    Point newStartPointFocus;
        //    Point newEndPointFocus;

        //    for (int i = 0; i < stEndPoints.Count; i++)
        //    {
        //        if (Math.Abs(stEndPoints[i].X - point.X) < 5
        //                && Math.Abs(stEndPoints[i].Y - point.Y) < 5)
        //        {
        //            if (i % 2 == 0)
        //            {
        //                newStartPointFocus = point;
        //            }
        //            else
        //            {
        //                newEndPointFocus = point;
        //            }
        //        }
        //    }
        //}

        public AbstractArrow(AbstractCap absCap, AbstractLine absLine)
        {
            cap = absCap;
            line = absLine;
        }

        public abstract void Draw(Graphics graphics, Pen pen);

        public bool SelectFigure(Point point)
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

            //int xMax;
            //int xMin;
            //int yMax;
            //int yMin;

            //if (_startPoint.X > _endPoint.X)
            //{
            //    xMax = _startPoint.X;
            //    xMin = _endPoint.X;
            //}
            //else
            //{
            //    xMin = _startPoint.X;
            //    xMax = _endPoint.X;
            //}

            //if (_startPoint.Y > _endPoint.Y)
            //{
            //    yMax = _startPoint.Y;
            //    yMin = _endPoint.Y;
            //}
            //else
            //{
            //    yMin = _startPoint.Y;
            //    yMax = _endPoint.Y;
            //}


            //if (point.X <= xMax && point.X >= xMin
            // && point.Y <= yMax && point.Y >= yMin)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            List<Point> stEndPoints = GetPoints();
            bool pointFocused = false;

            for (int i = 0; i < stEndPoints.Count; i++)
            {
                if (Math.Abs(stEndPoints[i].X - point.X) < 5
                        && Math.Abs(stEndPoints[i].Y - point.Y) < 5)
                {
                    pointFocused = true;
                }
            }

            return pointFocused;
        }

        public void Move(int deltaX, int deltaY)
        {
            _startPoint = new Point(_startPoint.X + deltaX, _startPoint.Y + deltaY);
            _endPoint = new Point(_endPoint.X + deltaX, _endPoint.Y + deltaY);
        }
    }
}
