﻿using UMLDiagram.Arrows.CapTypes;
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

        protected List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            points.Add(_startPoint);

            // ломанная линия
            //int middleX = (_endPoint.X + _startPoint.X) / 2;
            //points.Add(new Point(middleX, _startPoint.Y));
            //points.Add(new Point(middleX, _endPoint.Y));

            points.Add(_endPoint);
            return points;
        }

        public AbstractArrow(AbstractCap absCap, AbstractLine absLine)
        {
            cap = absCap;
            line = absLine;
        }

        public abstract void Draw(Graphics graphics, Pen pen);

        public bool SelectFigure(Point point)
        {
            //List<Point> stEndPoints = GetPoints();
            //bool pointFocused = false;

            //for (int i = 0; i < stEndPoints.Count; i++)
            //{
            //    if (Math.Abs(stEndPoints[i].X - point.X) < 5
            //            && Math.Abs(stEndPoints[i].Y - point.Y) < 5)
            //    {
            //        pointFocused = true;
            //    }
            //}

            //return pointFocused;

            string str = GetFocusPoint(point);

            if (str == "start" || str == "end")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetFocusPoint(Point point)
        {
            List<Point> stEndPoints = GetPoints();
            string focus = "";
            for (int i = 0; i < stEndPoints.Count; i++)
            {
                if (Math.Abs(stEndPoints[i].X - point.X) < 5
                        && Math.Abs(stEndPoints[i].Y - point.Y) < 5)
                {
                    if (i % 2 == 0)
                    {
                        focus = "start";
                    }
                    else
                    {
                        focus = "end";
                    }                    
                }
            }
            return focus;
        }

        //public void Move(int deltaX, int deltaY)
        //{
        //    _startPoint = new Point(_startPoint.X + deltaX, _startPoint.Y + deltaY);
        //    _endPoint = new Point(_endPoint.X + deltaX, _endPoint.Y + deltaY);
        //}

        public void MoveStartPoint(int deltaX, int deltaY)
        {
            _startPoint = new Point(_startPoint.X + deltaX, _startPoint.Y + deltaY);
        }

        public void MoveEndPoint(int deltaX, int deltaY)
        {
            _endPoint = new Point(_endPoint.X + deltaX, _endPoint.Y + deltaY);
        }

    }
}
