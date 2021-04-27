using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UMLDiagram;
using UMLDiagram.Arrows.CapTypes;

namespace UMLDiagramTests
{
    public class AbstractCapTests
    {
        
        [TestCaseSource(typeof(CalculatePointsTestSource))]
        public void CalculatePoints(Point _startPoint, Point _endPoint, List<Point> expected)
        {
            ArrowCap _arrowCap = new ArrowCap();
            List<Point> actual = _arrowCap.CalculatePoints(_startPoint, _endPoint);

            Assert.AreEqual(expected, actual);
        }
    }

    public class CalculatePointsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {


            yield return new object[]
            {
                new Point(50,50),
                new Point(60, 60),
                new List<Point>(){ new Point(39, 60), new Point(29,29), new Point(60,39), new Point(71, 71) } ,
            };

            yield return new object[]
            {
                new Point(50,50),
                new Point(50,50),
                new List<Point>(){ new Point(50, 35), new Point(80,50), new Point(50,65), new Point(20, 50) }
            };

            yield return new object[]
            {
                new Point(-10,-10),
                new Point(-50,-50),
                new List<Point>(){ new Point(1, -20), new Point(11,11), new Point(-20,1), new Point(-31,-31) }
            };
        }


    }
}
