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
        public static string _nameText { get; set; }
        public static string _atributesText { get; set; }
        public static string _methodsText { get; set; }



        public PropertyForBlock()
        {
            InitializeComponent();
        }

        private void NameProperty_TextChanged(object sender, EventArgs e)
        {
            _nameText = nameTextBox.Text;
        }

        private void AtributesProperty_TextChanged(object sender, EventArgs e)
        {
            _atributesText = atributesTextBox.Text;
        }

        private void MethodsProterty_TextChanged(object sender, EventArgs e)
        {
            _methodsText = methodsTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();

        }
        public string GetName()
        {
            return _nameText;
        }
    }
}
