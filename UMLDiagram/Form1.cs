using UMLDiagram.Arrows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UMLDiagram
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        Pen MinePen = new Pen(Color.Black, 3);

        private bool IsMouseDown = false;
        private Point m_Start;
        private Point m_Cur;

        ArrowLineType arrowType;

        private List<LineList> MyLines = new List<LineList>();

        AssociationArrow _associationArrow;
        AddictionArrow _addictionArrow;
        InheritanceArrow inheritanceArrow;
        AggregationArrow _aggregationArrow;
        ImplementationArrow _implementationArrow;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;

            m_Start = e.Location;

            switch (arrowType)
            {
                case ArrowLineType.inheritanceArrow:
                    inheritanceArrow = new InheritanceArrow();
                    break;
                case ArrowLineType.associationArrow:
                    _associationArrow = new AssociationArrow();
                    break;
                case ArrowLineType.addictionArrow:
                    _addictionArrow = new AddictionArrow();
                    break;
                case ArrowLineType.aggregationArrow:
                    _aggregationArrow = new AggregationArrow();
                    break;
                case ArrowLineType.implementationArrow:
                    _implementationArrow = new ImplementationArrow();
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                m_Cur = new Point(e.X, e.Y);

                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                switch (arrowType)
                {
                    case ArrowLineType.inheritanceArrow:
                        inheritanceArrow.Draw(m_Cur, m_Start, _graphics, MinePen);
                        break;
                    case ArrowLineType.associationArrow:
                        _associationArrow.Draw(m_Cur, m_Start, _graphics, MinePen);
                        break;
                    case ArrowLineType.addictionArrow:
                        _addictionArrow.Draw(m_Cur, m_Start, _graphics, MinePen);
                        break;
                    case ArrowLineType.aggregationArrow:
                        _aggregationArrow.Draw(m_Cur, m_Start,  _graphics, MinePen);
                        break;
                    case ArrowLineType.implementationArrow:
                        _implementationArrow.Draw(m_Cur, m_Start, _graphics, MinePen);
                        break;
                    default:
                        break;
                }

                pictureBox1.Image = _tmpBitmap;

                GC.Collect();
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            _mainBitmap = _tmpBitmap;
        }

        private void SwitchColorPaintig(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();          

            MinePen.Color = colorDialog1.Color;
        }

        private void SwitchWeightPaintig(object sender, EventArgs e)
        {
            MinePen.Width = trackBarWidth.Value;
        }




        private void associationButton_Click(object sender, EventArgs e)
        {
            arrowType = ArrowLineType.associationArrow;
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            arrowType = ArrowLineType.aggregationArrow;
        }

        private void InheritanceArrow_Click(object sender, EventArgs e)
        {
            arrowType = ArrowLineType.inheritanceArrow;
        }       

        private void implementationButton_Click(object sender, EventArgs e)
        {
            arrowType = ArrowLineType.implementationArrow;
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            arrowType = ArrowLineType.composition;
        }

        private void addictionButton_Click(object sender, EventArgs e)
        {
            arrowType = ArrowLineType.addictionArrow;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }
    }
}
