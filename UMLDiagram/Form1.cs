using UMLDiagram.Arrows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UMLDiagram.Arrows.ArrowConection;

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
        InheritanceArrow _inheritanceArrow;
        AggregationArrow _aggregationArrow;
        ImplementationArrow _implementationArrow;
        CompositionArrow _compositionArrow;

        AbstractFigure _abstractFigure;

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

            _associationArrow = new AssociationArrow();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;

            m_Start = e.Location;
            _abstractFigure.StartPoint = e.Location;

            switch (arrowType)
            {
                case ArrowLineType.inheritanceArrow:
                    _inheritanceArrow = new InheritanceArrow();
                    _inheritanceArrow.StartPoint = e.Location;
                    break;
                case ArrowLineType.associationArrow:
                    _associationArrow = new AssociationArrow();
                    _associationArrow.StartPoint = e.Location;
                    break;
                case ArrowLineType.addictionArrow:
                    _addictionArrow = new AddictionArrow();
                    _addictionArrow.StartPoint = e.Location;
                    break;
                case ArrowLineType.aggregationArrow:
                    _aggregationArrow = new AggregationArrow();
                    _aggregationArrow.StartPoint = e.Location;
                    break;
                case ArrowLineType.implementationArrow:
                    _implementationArrow = new ImplementationArrow();
                    _implementationArrow.StartPoint = e.Location;
                    break;
                case ArrowLineType.composition:
                    _compositionArrow = new CompositionArrow();
                    _compositionArrow.StartPoint = e.Location;
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                m_Cur = e.Location;                

                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                _abstractFigure.EndPoint = e.Location;
                
                //associationConection.DrawAssociationConection(_graphics, MinePen);

                switch (arrowType)
                {
                    case ArrowLineType.inheritanceArrow:
                        _inheritanceArrow.Draw(_graphics, MinePen);
                        _inheritanceArrow.EndPoint = e.Location;
                        break;
                    case ArrowLineType.associationArrow:
                        _associationArrow.Draw( _graphics, MinePen);
                        _associationArrow.EndPoint = e.Location;
                        break;
                    case ArrowLineType.addictionArrow:
                        _addictionArrow.Draw( _graphics, MinePen);
                        _addictionArrow.EndPoint = e.Location;
                        break;
                    case ArrowLineType.aggregationArrow:
                        _aggregationArrow.Draw(_graphics, MinePen);
                        _aggregationArrow.EndPoint = e.Location;
                        break;
                    case ArrowLineType.implementationArrow:
                        _implementationArrow.Draw(_graphics, MinePen);
                        _implementationArrow.EndPoint = e.Location;
                        break;
                    case ArrowLineType.composition:
                        _compositionArrow.Draw(_graphics, MinePen);
                        _compositionArrow.EndPoint = e.Location;
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
            //associationConection = new AssociationConection();
            
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
