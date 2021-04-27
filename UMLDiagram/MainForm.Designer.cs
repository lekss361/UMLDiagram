namespace UMLDiagram
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveTheLast = new System.Windows.Forms.Button();
            this.addictionButton = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            this.buttonInterface = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.aggregationButton = new System.Windows.Forms.Button();
            this.associationButton = new System.Windows.Forms.Button();
            this.compositionButton = new System.Windows.Forms.Button();
            this.implementationButton = new System.Windows.Forms.Button();
            this.inheritanceButton = new System.Windows.Forms.Button();
            this.colorLineButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LayoutPanelSelectSetting = new System.Windows.Forms.GroupBox();
            this.LayoutPanelSelectSettingBlock = new System.Windows.Forms.TableLayoutPanel();
            this.SelectMethodField = new System.Windows.Forms.TextBox();
            this.SelectAtribureFieldText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectNameField = new System.Windows.Forms.TextBox();
            this.LayoutPanelSelectSettingArrow = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectTypeArrow = new System.Windows.Forms.ComboBox();
            this.LayoutPanelSelectSettingFigure = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarSettingFigure = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
            this.LayoutPanelSelectSetting.SuspendLayout();
            this.LayoutPanelSelectSettingBlock.SuspendLayout();
            this.LayoutPanelSelectSettingArrow.SuspendLayout();
            this.LayoutPanelSelectSettingFigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSettingFigure)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(3500, 3500);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(1500, 1500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1500, 1500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.buttonRemoveTheLast);
            this.groupBox1.Controls.Add(this.addictionButton);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBarWidth);
            this.groupBox1.Controls.Add(this.buttonInterface);
            this.groupBox1.Controls.Add(this.buttonClass);
            this.groupBox1.Controls.Add(this.buttonMove);
            this.groupBox1.Controls.Add(this.aggregationButton);
            this.groupBox1.Controls.Add(this.associationButton);
            this.groupBox1.Controls.Add(this.compositionButton);
            this.groupBox1.Controls.Add(this.implementationButton);
            this.groupBox1.Controls.Add(this.inheritanceButton);
            this.groupBox1.Controls.Add(this.colorLineButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 725);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // buttonRemoveTheLast
            // 
            this.buttonRemoveTheLast.Location = new System.Drawing.Point(12, 427);
            this.buttonRemoveTheLast.Name = "buttonRemoveTheLast";
            this.buttonRemoveTheLast.Size = new System.Drawing.Size(109, 40);
            this.buttonRemoveTheLast.TabIndex = 3;
            this.buttonRemoveTheLast.Text = "Удалить последний";
            this.buttonRemoveTheLast.UseVisualStyleBackColor = true;
            this.buttonRemoveTheLast.Click += new System.EventHandler(this.buttonRemoveTheLast_Click);
            // 
            // addictionButton
            // 
            this.addictionButton.Location = new System.Drawing.Point(12, 280);
            this.addictionButton.Name = "addictionButton";
            this.addictionButton.Size = new System.Drawing.Size(112, 23);
            this.addictionButton.TabIndex = 12;
            this.addictionButton.Text = "Зависимость";
            this.addictionButton.UseVisualStyleBackColor = true;
            this.addictionButton.Click += new System.EventHandler(this.addictionButton_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 522);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(109, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Толщина";
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.LargeChange = 1;
            this.trackBarWidth.Location = new System.Drawing.Point(12, 389);
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.Size = new System.Drawing.Size(112, 45);
            this.trackBarWidth.TabIndex = 10;
            this.trackBarWidth.Scroll += new System.EventHandler(this.SwitchWeightPaintig);
            // 
            // buttonInterface
            // 
            this.buttonInterface.BackColor = System.Drawing.SystemColors.Control;
            this.buttonInterface.Location = new System.Drawing.Point(12, 77);
            this.buttonInterface.Name = "buttonInterface";
            this.buttonInterface.Size = new System.Drawing.Size(112, 23);
            this.buttonInterface.TabIndex = 8;
            this.buttonInterface.Text = "Интерфейс";
            this.buttonInterface.UseVisualStyleBackColor = false;
            this.buttonInterface.Click += new System.EventHandler(this.buttonInterface_Click);
            // 
            // buttonClass
            // 
            this.buttonClass.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClass.Location = new System.Drawing.Point(12, 48);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Size = new System.Drawing.Size(112, 23);
            this.buttonClass.TabIndex = 7;
            this.buttonClass.Text = "Класс";
            this.buttonClass.UseVisualStyleBackColor = false;
            this.buttonClass.Click += new System.EventHandler(this.buttonClass_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMove.Location = new System.Drawing.Point(12, 19);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(112, 23);
            this.buttonMove.TabIndex = 6;
            this.buttonMove.Text = "Переместить";
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // aggregationButton
            // 
            this.aggregationButton.Location = new System.Drawing.Point(12, 251);
            this.aggregationButton.Name = "aggregationButton";
            this.aggregationButton.Size = new System.Drawing.Size(112, 23);
            this.aggregationButton.TabIndex = 5;
            this.aggregationButton.Text = "Агрегация";
            this.aggregationButton.UseVisualStyleBackColor = true;
            this.aggregationButton.Click += new System.EventHandler(this.aggregationButton_Click);
            // 
            // associationButton
            // 
            this.associationButton.Location = new System.Drawing.Point(12, 193);
            this.associationButton.Name = "associationButton";
            this.associationButton.Size = new System.Drawing.Size(112, 23);
            this.associationButton.TabIndex = 4;
            this.associationButton.Text = "Ассоциация";
            this.associationButton.UseVisualStyleBackColor = true;
            this.associationButton.Click += new System.EventHandler(this.associationButton_Click);
            // 
            // compositionButton
            // 
            this.compositionButton.Location = new System.Drawing.Point(12, 222);
            this.compositionButton.Name = "compositionButton";
            this.compositionButton.Size = new System.Drawing.Size(112, 23);
            this.compositionButton.TabIndex = 3;
            this.compositionButton.Text = "Композиция";
            this.compositionButton.UseVisualStyleBackColor = true;
            this.compositionButton.Click += new System.EventHandler(this.compositionButton_Click);
            // 
            // implementationButton
            // 
            this.implementationButton.Location = new System.Drawing.Point(12, 164);
            this.implementationButton.Name = "implementationButton";
            this.implementationButton.Size = new System.Drawing.Size(112, 23);
            this.implementationButton.TabIndex = 2;
            this.implementationButton.Text = "Имплементация";
            this.implementationButton.UseVisualStyleBackColor = true;
            this.implementationButton.Click += new System.EventHandler(this.implementationButton_Click);
            // 
            // inheritanceButton
            // 
            this.inheritanceButton.Location = new System.Drawing.Point(12, 135);
            this.inheritanceButton.Name = "inheritanceButton";
            this.inheritanceButton.Size = new System.Drawing.Size(112, 23);
            this.inheritanceButton.TabIndex = 1;
            this.inheritanceButton.Text = "Наследование";
            this.inheritanceButton.UseVisualStyleBackColor = true;
            this.inheritanceButton.Click += new System.EventHandler(this.InheritanceArrow_Click);
            // 
            // colorLineButton
            // 
            this.colorLineButton.Location = new System.Drawing.Point(12, 339);
            this.colorLineButton.Name = "colorLineButton";
            this.colorLineButton.Size = new System.Drawing.Size(112, 23);
            this.colorLineButton.TabIndex = 0;
            this.colorLineButton.Text = "Цвет";
            this.colorLineButton.UseMnemonic = false;
            this.colorLineButton.UseVisualStyleBackColor = true;
            this.colorLineButton.Click += new System.EventHandler(this.SwitchColorPaintig);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LayoutPanelSelectSetting
            // 
            this.LayoutPanelSelectSetting.AutoSize = true;
            this.LayoutPanelSelectSetting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LayoutPanelSelectSetting.Controls.Add(this.LayoutPanelSelectSettingBlock);
            this.LayoutPanelSelectSetting.Controls.Add(this.LayoutPanelSelectSettingArrow);
            this.LayoutPanelSelectSetting.Controls.Add(this.LayoutPanelSelectSettingFigure);
            this.LayoutPanelSelectSetting.Location = new System.Drawing.Point(1158, 27);
            this.LayoutPanelSelectSetting.MinimumSize = new System.Drawing.Size(200, 100);
            this.LayoutPanelSelectSetting.Name = "LayoutPanelSelectSetting";
            this.LayoutPanelSelectSetting.Size = new System.Drawing.Size(212, 319);
            this.LayoutPanelSelectSetting.TabIndex = 3;
            this.LayoutPanelSelectSetting.TabStop = false;
            this.LayoutPanelSelectSetting.Text = "Параметры фигуры";
            // 
            // LayoutPanelSelectSettingBlock
            // 
            this.LayoutPanelSelectSettingBlock.ColumnCount = 2;
            this.LayoutPanelSelectSettingBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanelSelectSettingBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanelSelectSettingBlock.Controls.Add(this.SelectMethodField, 1, 2);
            this.LayoutPanelSelectSettingBlock.Controls.Add(this.SelectAtribureFieldText, 1, 1);
            this.LayoutPanelSelectSettingBlock.Controls.Add(this.label7, 0, 2);
            this.LayoutPanelSelectSettingBlock.Controls.Add(this.label5, 0, 0);
            this.LayoutPanelSelectSettingBlock.Controls.Add(this.label6, 0, 1);
            this.LayoutPanelSelectSettingBlock.Controls.Add(this.SelectNameField, 1, 0);
            this.LayoutPanelSelectSettingBlock.Location = new System.Drawing.Point(6, 200);
            this.LayoutPanelSelectSettingBlock.Name = "LayoutPanelSelectSettingBlock";
            this.LayoutPanelSelectSettingBlock.RowCount = 3;
            this.LayoutPanelSelectSettingBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutPanelSelectSettingBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutPanelSelectSettingBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutPanelSelectSettingBlock.Size = new System.Drawing.Size(200, 100);
            this.LayoutPanelSelectSettingBlock.TabIndex = 2;
            // 
            // SelectMethodField
            // 
            this.SelectMethodField.Location = new System.Drawing.Point(103, 71);
            this.SelectMethodField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.SelectMethodField.Name = "SelectMethodField";
            this.SelectMethodField.Size = new System.Drawing.Size(94, 20);
            this.SelectMethodField.TabIndex = 21;
            // 
            // SelectAtribureFieldText
            // 
            this.SelectAtribureFieldText.Location = new System.Drawing.Point(103, 38);
            this.SelectAtribureFieldText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.SelectAtribureFieldText.Name = "SelectAtribureFieldText";
            this.SelectAtribureFieldText.Size = new System.Drawing.Size(94, 20);
            this.SelectAtribureFieldText.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Текст Методов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Название Блока";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Текст Признаков";
            // 
            // SelectNameField
            // 
            this.SelectNameField.Location = new System.Drawing.Point(103, 5);
            this.SelectNameField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.SelectNameField.Name = "SelectNameField";
            this.SelectNameField.Size = new System.Drawing.Size(94, 20);
            this.SelectNameField.TabIndex = 19;
            // 
            // LayoutPanelSelectSettingArrow
            // 
            this.LayoutPanelSelectSettingArrow.ColumnCount = 2;
            this.LayoutPanelSelectSettingArrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanelSelectSettingArrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanelSelectSettingArrow.Controls.Add(this.label4, 0, 0);
            this.LayoutPanelSelectSettingArrow.Controls.Add(this.SelectTypeArrow, 1, 0);
            this.LayoutPanelSelectSettingArrow.Location = new System.Drawing.Point(6, 125);
            this.LayoutPanelSelectSettingArrow.Name = "LayoutPanelSelectSettingArrow";
            this.LayoutPanelSelectSettingArrow.RowCount = 1;
            this.LayoutPanelSelectSettingArrow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanelSelectSettingArrow.Size = new System.Drawing.Size(200, 59);
            this.LayoutPanelSelectSettingArrow.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Тип стрелки";
            // 
            // SelectTypeArrow
            // 
            this.SelectTypeArrow.FormattingEnabled = true;
            this.SelectTypeArrow.Items.AddRange(new object[] {
            "inheritanceArrow",
            "associationArrow",
            "addictionArrow",
            "aggregationArrow",
            "implementationArrow",
            "composition"});
            this.SelectTypeArrow.Location = new System.Drawing.Point(103, 15);
            this.SelectTypeArrow.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.SelectTypeArrow.Name = "SelectTypeArrow";
            this.SelectTypeArrow.Size = new System.Drawing.Size(94, 21);
            this.SelectTypeArrow.TabIndex = 15;
            // 
            // LayoutPanelSelectSettingFigure
            // 
            this.LayoutPanelSelectSettingFigure.ColumnCount = 2;
            this.LayoutPanelSelectSettingFigure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanelSelectSettingFigure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanelSelectSettingFigure.Controls.Add(this.trackBarSettingFigure, 1, 0);
            this.LayoutPanelSelectSettingFigure.Controls.Add(this.label2, 0, 0);
            this.LayoutPanelSelectSettingFigure.Controls.Add(this.label3, 0, 1);
            this.LayoutPanelSelectSettingFigure.Controls.Add(this.button1, 1, 1);
            this.LayoutPanelSelectSettingFigure.Location = new System.Drawing.Point(6, 19);
            this.LayoutPanelSelectSettingFigure.Name = "LayoutPanelSelectSettingFigure";
            this.LayoutPanelSelectSettingFigure.RowCount = 2;
            this.LayoutPanelSelectSettingFigure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanelSelectSettingFigure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanelSelectSettingFigure.Size = new System.Drawing.Size(200, 100);
            this.LayoutPanelSelectSettingFigure.TabIndex = 0;
            // 
            // trackBarSettingFigure
            // 
            this.trackBarSettingFigure.LargeChange = 1;
            this.trackBarSettingFigure.Location = new System.Drawing.Point(103, 3);
            this.trackBarSettingFigure.Name = "trackBarSettingFigure";
            this.trackBarSettingFigure.Size = new System.Drawing.Size(94, 44);
            this.trackBarSettingFigure.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Толщина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Цвет";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Цвет";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SwitchColorPaintig);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.LayoutPanelSelectSetting);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "UML Diagram";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
            this.LayoutPanelSelectSetting.ResumeLayout(false);
            this.LayoutPanelSelectSettingBlock.ResumeLayout(false);
            this.LayoutPanelSelectSettingBlock.PerformLayout();
            this.LayoutPanelSelectSettingArrow.ResumeLayout(false);
            this.LayoutPanelSelectSettingArrow.PerformLayout();
            this.LayoutPanelSelectSettingFigure.ResumeLayout(false);
            this.LayoutPanelSelectSettingFigure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSettingFigure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ColorDialog colorDialog1;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Button colorLineButton;

        private System.Windows.Forms.Button aggregationButton;

        private System.Windows.Forms.Button associationButton;

        private System.Windows.Forms.Button compositionButton;

        private System.Windows.Forms.Button implementationButton;

        private System.Windows.Forms.Button inheritanceButton;

        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonInterface;
        private System.Windows.Forms.Button buttonClass;

        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarWidth;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button addictionButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonRemoveTheLast;
        private System.Windows.Forms.GroupBox LayoutPanelSelectSetting;
        private System.Windows.Forms.TableLayoutPanel LayoutPanelSelectSettingFigure;
        private System.Windows.Forms.TableLayoutPanel LayoutPanelSelectSettingArrow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SelectTypeArrow;
        private System.Windows.Forms.TrackBar trackBarSettingFigure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel LayoutPanelSelectSettingBlock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SelectMethodField;
        private System.Windows.Forms.TextBox SelectAtribureFieldText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SelectNameField;
    }
}

