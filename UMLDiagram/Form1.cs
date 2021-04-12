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
        string action = "";

        private bool IsMouseDown = false;
        private Point m_Start;
        private Point m_Cur;


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

            _associationArrow = new AssociationArrow();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;

            m_Start = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                m_Cur = new Point(e.X, e.Y);

                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);



                //_graphics.DrawLine(pen, start, cur);
                //pen1.DashStyle = DashStyle.Dash;
                switch (action)
                {
                    case "inheritanceArrow":
                        inheritanceArrow.Draw(m_Cur, m_Start, IsMouseDown, _graphics, MinePen);
                        break;
                    case "associationArrow":
                        _associationArrow.Draw(m_Cur, m_Start, IsMouseDown, _graphics, MinePen);
                        break;
                    case "addictionArrow":
                        _addictionArrow.Draw(m_Cur, m_Start, IsMouseDown, _graphics, MinePen);
                        break;
                    case "aggregationArrow":
                        _aggregationArrow.Draw(m_Cur, m_Start, IsMouseDown, _graphics, MinePen);
                        break;
                    case "implementationArrow":
                        _implementationArrow.Draw(m_Cur, m_Start, IsMouseDown, _graphics, MinePen);
                        break;
                    default:
                        break;
                }
                //Ag.Draw(cur, start, isClicked, _graphics, pen);




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
            _associationArrow = new AssociationArrow();
            action = "associationArrow";
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            _aggregationArrow = new AggregationArrow();
            action = "aggregationArrow";
        }
        private void InheritanceArrow_Click(object sender, EventArgs e)
        {
            inheritanceArrow = new InheritanceArrow();


            action = "inheritanceArrow";

        }
       

        private void implementationButton_Click(object sender, EventArgs e)
        {
            _implementationArrow = new ImplementationArrow();
            action = "implementationArrow";
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {

        }

        private void addictionButton_Click(object sender, EventArgs e)
        {
            _addictionArrow = new AddictionArrow();
            action = "addictionArrow";
        }
    }
}
