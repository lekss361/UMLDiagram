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

        public SettingFigure( TrackBar settingtrackBar, ColorDialog settingColorDialog, ComboBox settingTypeArrow, TableLayoutPanel tableLayoutMain, TableLayoutPanel tableLayoutArrow, TableLayoutPanel tableLayoutBlock)
        {
            SettingtrackBar = settingtrackBar;
            SettingColorDialog = settingColorDialog;
            SettingTypeArrow = settingTypeArrow;
            TableLayoutMain = tableLayoutMain;
            TableLayoutArrow = tableLayoutArrow;
            TableLayoutBlock = tableLayoutBlock;
        }

        public void SetSettingFigure(IFigure figure)
        {
            Figure = figure;
            if (Figure.GetType()== typeof(Arrow))
            {
                AbstractArrow selectArrow = (AbstractArrow)Figure;
                TableLayoutArrow.Enabled = true;
                TableLayoutArrow.Visible = true;
                TableLayoutBlock.Enabled = false;
                TableLayoutBlock.Visible = false;
                SettingtrackBar.Value = (int)selectArrow.PenFigure.Width;
                SettingColorDialog.Color = selectArrow.PenFigure.Color;
                
            }
            else
            {
                TableLayoutArrow.Enabled = false;
                TableLayoutArrow.Visible = false;
                TableLayoutBlock.Enabled = true;
                TableLayoutBlock.Visible = true;
            }
           
        }
    }
}
