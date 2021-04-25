using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Modules
{
    class AbstractModule
    {
        protected Rectangle _rectangle;
        public string DefaultText { get; set; }
        public Pen Pen { get; set; }
        public Size Size
        {
            get
            {
                return _rectangle.Size;
            }
            private set
            {
                _rectangle.Size = value;
            }
        }
        public Point Location
        {
            get
            {
                return _rectangle.Location;
            }
            set
            {
                _rectangle.Location = value;
            }
        }



    }
}
