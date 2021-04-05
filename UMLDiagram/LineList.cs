
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDiagram
{
    class LineList
    {
        public static long TotalCount;
        private int _X1;
        private int _Y1;
        private int _X2;
        private int _Y2;
        private Color _color;
        private float _width;
        private DashStyle _dashStyle;
        


        public int X1
        {
            get { return _X1; }
            set { _X1 = value; }
        }

        public int Y1
        {
            get { return _Y1; }
            set { _Y1 = value; }
        }

        public int X2
        {
            get { return _X2; }
            set { _X2 = value; }
        }

        public int Y2
        {
            get { return _Y2; }
            set { _Y2 = value; }
        }

        public Color PenColor
        {
            get { return _color; }
            set { _color = value; }
        }
        public float PenWidth
        {
            get { return _width; }
            set { _width = value; }
        }
        public DashStyle PenDashStyle
        {
            get { return _dashStyle; }
            set { _dashStyle = value; }
        }

        public LineList(int _X1, int _Y1, int _X2, int _Y2,Color color, float width, DashStyle dashStyle)
        {
            X1 = _X1;
            Y1 = _Y1;
            X2 = _X2;
            Y2 = _Y2;
            PenColor = color;
            PenWidth = width;
            PenDashStyle = dashStyle;
            TotalCount += 1;
        }

        public LineList()
        {
            X1 = 0;
            Y1 = 0;
            X2 = 0;
            Y2 = 0;
            _color = Color.Black;
            _width = 9;
            _dashStyle = DashStyle.Dash;
            TotalCount += 1;
        }

        ~ LineList()
        {
            TotalCount -= 1;
        }
    }
}
