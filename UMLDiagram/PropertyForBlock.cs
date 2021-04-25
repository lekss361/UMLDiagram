using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMLDiagram
{
    public partial class PropertyForBlock : Form
    {
        public PropertyForBlock(Form1 form)
        {
            this.form1 = form;
            InitializeComponent();
        }
        public static string _nameOfBlock { get; set; }
        public static string _atributesOfBlock { get; set; }
        public static string _methodsOfBlock { get; set; }

        static SizeF nameSize { get; set; }
        static SizeF atributeSize { get; set; }
        static SizeF methodSize { get; set; }

        public static float widthParam { get; set; }
        public static float heightFont { get; set; }
        public static int countLinesAtr { get; set; }
        public static int countLinesMet { get; set; }

        private Form1 form1;

        public static Font fon2 { get; set; }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            _nameOfBlock = nameTextBox.Text;
           
            fon2 = nameTextBox.Font;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            _atributesOfBlock = richTextBox2.Text;
            countLinesAtr = richTextBox2.Lines.Count();
            heightFont = richTextBox2.Font.Height;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            _methodsOfBlock = richTextBox3.Text;
            countLinesMet = richTextBox3.Lines.Count();
        }
        private void PropertyForBlock_Load(object sender, EventArgs e)
        {
            

        }

        private void okey_Click(object sender, EventArgs e)
        {
            form1.SetPropety(_nameOfBlock, _atributesOfBlock, _methodsOfBlock,fon2);
            form1.SetCountLines(countLinesAtr, countLinesMet);
            Close();
        }
        private static void GetParametersForBlock(string name, string atr, string met, Font strFont, PaintEventArgs e)
        {

            Font stringFont = strFont;
            nameSize = new SizeF();
            nameSize = e.Graphics.MeasureString(name, stringFont);
            atributeSize = new SizeF();
            atributeSize = e.Graphics.MeasureString(atr, stringFont);
            methodSize = new SizeF();
            methodSize = e.Graphics.MeasureString(met, stringFont);

        }
        private static float GetWidth(SizeF name, SizeF atr, SizeF met)
        {
            float with;
            if ((name.Width >= atr.Width) && (name.Width >= met.Width)) // может быть поставить >=  ?
            {
                with = name.Width;
            }
            else if ((atr.Width >= met.Width) && (atr.Width >= name.Width))
            {
                with = atr.Width;
            }
            else
            {
                with = met.Width;
            }
            return with;
        }
        //private static float GetHeight(SizeF name, SizeF atr, SizeF met)
        //{
        //    //float height;
        //    //if ((name.Height >= atr.Height) && (name.Height >= met.Height)) // может быть поставить >=  ?
        //    //{
        //    //    height = name.Height;
        //    //}
        //    //else if ((atr.Height >= met.Height) && (atr.Height >= name.Height))
        //    //{
        //    //    height = atr.Height;
        //    //}
        //    //else
        //    //{
        //    //    height = met.Height;
        //    //}
        //    //return height;
        //}
        
        private static float CalculateWidthBlock(string name, string atr, string met, Font strFont, PaintEventArgs e)
        {
            float with;
            GetParametersForBlock(name, atr, met, strFont, e);
            with = GetWidth(nameSize, atributeSize, methodSize);
            return with;
        }
        //private static float CalculateHeightBlock(string name, string atr, string met)
        //{
        //    float height;
        //    height = GetHeight(nameSize, atributeSize, methodSize);
        //    return height;
        //}
        private void PropertyForBlock_Paint(object sender, PaintEventArgs e)
        {
            widthParam = CalculateWidthBlock(_nameOfBlock, _atributesOfBlock, _methodsOfBlock, fon2, e);
            //heightFont = heightFont;
            form1.SetWidthAndHeist(widthParam,heightFont);
            
        }

        private void chooseFont_Click(object sender, EventArgs e)
        {
            //FontDialog fontDialog1 = new FontDialog();
            
            if ( (fontDialog1.ShowDialog()== DialogResult.OK))
            {
                nameTextBox.Font = fontDialog1.Font;
                richTextBox2.Font = fontDialog1.Font;
                richTextBox3.Font = fontDialog1.Font;
                
            }
        }
    }
}
