using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMLDiagram.BlockS;

namespace UMLDiagram
{
    class SettingFigure
    {
        public IFigure Figure;
        TrackBar SettingtrackBar;
        ColorDialog SettingColorDialog;
        ComboBox SettingTypeArrow;
        TableLayoutPanel TableLayoutMain;
        TableLayoutPanel TableLayoutArrow;
        TableLayoutPanel TableLayoutBlock;
        TextBox SelectNameField;
        TextBox SelectAtributeField;
        TextBox SelectMetodField;
        Button ConfirmButton;
        AbstractArrow selectArrow;
        AbstractBlock selectBlock;

        public SettingFigure(TrackBar settingtrackBar, ColorDialog settingColorDialog, ComboBox settingTypeArrow,
            TableLayoutPanel tableLayoutMain, TableLayoutPanel tableLayoutArrow, TableLayoutPanel tableLayoutBlock,
            TextBox selectNameField, TextBox selectAtributeField, TextBox selectMetodField)
        {
            SettingtrackBar = settingtrackBar;
            SettingColorDialog = settingColorDialog;
            SettingTypeArrow = settingTypeArrow;
            TableLayoutMain = tableLayoutMain;
            TableLayoutArrow = tableLayoutArrow;
            TableLayoutBlock = tableLayoutBlock;
            SelectNameField = selectNameField;
            SelectMetodField = selectMetodField;
            SelectAtributeField = selectAtributeField;
        }

        public void SetSettingFigure(IFigure figure)
        {
            Figure = figure;
            if (Figure.GetType() == typeof(Arrow))
            {
                selectArrow = (AbstractArrow)Figure;
                TableLayoutArrow.Enabled = true;
                TableLayoutArrow.Visible = true;
                TableLayoutBlock.Enabled = false;
                TableLayoutBlock.Visible = false;
                SettingtrackBar.Value = (int)Figure.PenFigure.Width;
                SettingColorDialog.Color = Figure.PenFigure.Color;
                int indexComboBox = SettingTypeArrow.FindString(Convert.ToString(selectArrow.arrowType));
                SettingTypeArrow.SelectedIndex = indexComboBox;

            }
            else
            {
                selectBlock = (AbstractBlock)Figure;
                TableLayoutArrow.Enabled = false;
                TableLayoutArrow.Visible = false;
                TableLayoutBlock.Enabled = true;
                TableLayoutBlock.Visible = true;
                SelectNameField.Text = selectBlock.NameField;
                SelectAtributeField.Text = selectBlock.AtribureField;
                SelectNameField.Text = selectBlock.MethodField;

            }
        }

        public void ChangedWidth()
        {
            Figure.PenFigure.Width = SettingtrackBar.Value;
        }

        public void ChangedColor()
        {
            Figure.PenFigure.Color = SettingColorDialog.Color;
        }

        public void ChangedTypeArrow()
        {
            selectArrow.arrowType = (ArrowType)SettingTypeArrow.SelectedItem;
        }

        public void ChangedTextBlock()
        {
            selectBlock.AtribureField = SelectAtributeField.Text;
            selectBlock.NameField = SelectNameField.Text;
            selectBlock.MethodField = SelectMetodField.Text;
        }

        public IFigure GetSettingFigure()
        {
            if (Figure.GetType() == typeof(Arrow))
            {
                selectArrow.PenFigure = new Pen(Figure.PenFigure.Color, Figure.PenFigure.Width);
                return selectArrow;
            }
            else
            {
                selectBlock.PenFigure = new Pen(Figure.PenFigure.Color, Figure.PenFigure.Width);
                return selectBlock;
            }
        }
    }
}
