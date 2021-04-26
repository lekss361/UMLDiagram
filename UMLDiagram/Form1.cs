using System.Drawing.Imaging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UMLDiagram.Factory;


using UMLDiagram.BlockS;
using System.Diagnostics;

namespace UMLDiagram
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        
        Pen MinePen = new Pen(Color.Black, 3);

        private bool IsMouseDown = false;
        
        ArrowsBuilder builder;
        AbstractArrow aArrow;

        ArrowLineType typeOfLine;
        ArrowCapType typeOfCap;
        FigureType typeOfFigure;

        SettingFigure settingFigure;
        IFigure SelectFigure;

        Block block1=new Block();
        public static float  width1{ get; set; }
        public static float height1 { get; set; }

        public static int LinesAtr { get; set; }
        public static int LinesMet { get; set; }

        List<IFigure> listOfFigure = new List<IFigure>();

        Point p;
        bool isMove = false;


        public Form1()
        {
            InitializeComponent();
            settingFigure = new SettingFigure(trackBarSettingFigure,colorDialog1,SelectTypeArrow,LayoutPanelSelectSettingFigure,LayoutPanelSelectSettingArrow,LayoutPanelSelectSettingBlock);
        }

        public void SetPropety(string nameF, string atributF,string methodsF,Font font)
        {
            block1.NameField = nameF;

            block1.AtribureField = atributF;
            block1.MethodField = methodsF;
            block1.drawFont = font;

        }

        public void SetWidthAndHeist(float wid, float heig)
        {
            block1.WidthRect = wid;
            block1.HeigthFont = heig;
        }

        public void SetCountLines(int atr, int met)
        {
            block1.NumOfAtributeLines = atr;
            block1.NumOfMethodLines = met;
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
            //block1.SetPointForLines(e.Location);
            IsMouseDown = true;

            switch (typeOfFigure)
            {
                case FigureType.Class:
                    block1.PenFigure = MinePen;
                    block1.SetPointForLines(e.Location);
                    break;

                case FigureType.Arrow:
                    if (isMove)
                    {
                        builder = new ArrowsBuilder();
                        aArrow = builder.CreateArrow(typeOfCap, typeOfLine);
                        aArrow.PenFigure = new Pen(MinePen.Color, MinePen.Width);
                        foreach (AbstractArrow a in listOfFigure)
                        {
                            if (a.SelectFigure(e.Location))
                            {
                                settingFigure.SetSettingFigure(a);
                                aArrow = a;
                                break;
                            }
                        }

                        if (aArrow != null)
                        {
                            listOfFigure.Remove(aArrow);

                            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            _graphics = Graphics.FromImage(_mainBitmap);
                            _graphics.Clear(Color.White);

                            foreach (IFigure a in listOfFigure)
                            {
                                a.Draw(_graphics,a.PenFigure);
                            }

                            pictureBox1.Image = _mainBitmap;

                            p = e.Location;
                        }
                    }
                    else
                    {
                        builder = new ArrowsBuilder();
                        aArrow = builder.CreateArrow(typeOfCap, typeOfLine);
                        aArrow.PenFigure = new Pen(MinePen.Color, MinePen.Width);
                        aArrow._startPoint = e.Location;
                    }                 
                break;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                if (isMove && aArrow != null)
                {
                    aArrow.Move(e.X - p.X, e.Y - p.Y);
                    p = e.Location;
                }
                else
                {
                    aArrow._endPoint = e.Location;
                }

                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);


                switch (typeOfFigure)
                {
                    case FigureType.Class:
                        block1.startPoint = e.Location;
                        block1.SetPointForLines(e.Location);
                        //block1.DrawBlock(_graphics, MinePen, e.Location);
                        block1.Draw(_graphics, block1.PenFigure);
                       
                        break;
                    case FigureType.Arrow:
                        aArrow.Draw(_graphics,aArrow.PenFigure);
                        break;
                }
                

                //block1.SetPointForLines(e.Location);
                //block1.DrawBlock(_graphics, MinePen, e.Location, nameClass, atributes , methods,width1 , height1, LinesAtr, LinesMet);
                //block1.DrawBlock(_graphics, MinePen, e.Location);

                pictureBox1.Image = _tmpBitmap;

                if (GC.GetTotalMemory(true) > 1073741824)
                {
                    GC.Collect();
                }
            }else
            {
                builder = new ArrowsBuilder();
                aArrow = builder.CreateArrow(typeOfCap, typeOfLine);
                aArrow.PenFigure = new Pen(MinePen.Color,MinePen.Width);

                foreach (IFigure a in listOfFigure)
                {
                    if (a.SelectFigure(e.Location))
                    {
                        _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                        _graphics = Graphics.FromImage(_tmpBitmap);
                        
                        Pen FocusPen = new Pen(Color.Red, 3);
                        _graphics.DrawEllipse(FocusPen, e.Location.X - 5, e.Location.Y - 5, 10, 10);

                        pictureBox1.Image = _tmpBitmap;
                        GC.Collect();
                        break;
                    }
                }
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            _mainBitmap = _tmpBitmap;

            switch (typeOfFigure)
            {
                case FigureType.Class:
                    block1.NameField = null;
                    block1.AtribureField = null;
                    block1.MethodField = null;

                    listOfFigure.Add(block1);

                    break;
                case FigureType.Arrow:

                    listOfFigure.Add(aArrow);

                    break;
            }
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
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.ArrowCap;
            isMove = false;
            typeOfFigure = FigureType.Arrow;
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.RhombusCap;
            isMove = false;
            typeOfFigure = FigureType.Arrow;
        }

        private void InheritanceArrow_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.TriangleCap;
            isMove = false;
            typeOfFigure = FigureType.Arrow;
        }

        private void implementationButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.DashLine;
            typeOfCap = ArrowCapType.TriangleCap;
            isMove = false;
            typeOfFigure = FigureType.Arrow;
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.RhombusFillCap;
            isMove = false;
            typeOfFigure = FigureType.Arrow;
        }

        private void addictionButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.TriangleFillCap;
            isMove = false;
            typeOfFigure = FigureType.Arrow;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
            var form = new PropertyForBlock(this);
            form.Show();
            
            typeOfFigure = FigureType.Class;
            isMove = false;


        }
            

        private void button2_Click(object sender, EventArgs e)
        {
            //var form = new PropertyForBlock(this);
            //form.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Class Diagram Files|*.umldiagram|JPeg Image|*.jpg";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        _mainBitmap.Save(saveFileDialog1.FileName);
                        break;

                    case 2:
                        _mainBitmap.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                _mainBitmap = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = _mainBitmap;
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            aArrow = null;
            isMove = true;
        }

        private void buttonStack_Click(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);

            foreach (IFigure a in listOfFigure)
            {
                a.Draw(_graphics, MinePen);
            }

            pictureBox1.Image = _mainBitmap;
        }

        private void buttonRemoveTheLast_Click(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);

            listOfFigure.RemoveAt(listOfFigure.Count - 1);

            foreach (IFigure a in listOfFigure)
            {
                a.Draw(_graphics, MinePen);
            }

            pictureBox1.Image = _mainBitmap;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // delete ???
        }

        private void SettingFigure_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ColorSelectFigure_Click(object sender, EventArgs e)
        {

                colorDialog1.ShowDialog();

                MinePen.Color = colorDialog1.Color;
            
        }
    }
}
