namespace UMLDiagram
{
  partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            this.buttonStack = new System.Windows.Forms.Button();
            this.buttonInterface = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.aggregationButton = new System.Windows.Forms.Button();
            this.associationButton = new System.Windows.Forms.Button();
            this.compositionButton = new System.Windows.Forms.Button();
            this.implementationButton = new System.Windows.Forms.Button();
            this.inheritanceButton = new System.Windows.Forms.Button();
            this.colorLineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(142, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 470);
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
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBarWidth);
            this.groupBox1.Controls.Add(this.buttonStack);
            this.groupBox1.Controls.Add(this.buttonInterface);
            this.groupBox1.Controls.Add(this.buttonClass);
            this.groupBox1.Controls.Add(this.buttonSelect);
            this.groupBox1.Controls.Add(this.aggregationButton);
            this.groupBox1.Controls.Add(this.associationButton);
            this.groupBox1.Controls.Add(this.compositionButton);
            this.groupBox1.Controls.Add(this.implementationButton);
            this.groupBox1.Controls.Add(this.inheritanceButton);
            this.groupBox1.Controls.Add(this.colorLineButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 476);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Толщина";
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.LargeChange = 1;
            this.trackBarWidth.Location = new System.Drawing.Point(12, 408);
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.Size = new System.Drawing.Size(112, 45);
            this.trackBarWidth.TabIndex = 10;
            this.trackBarWidth.Scroll += new System.EventHandler(this.SwitchWeightPaintig);
            // 
            // buttonStack
            // 
            this.buttonStack.Location = new System.Drawing.Point(12, 106);
            this.buttonStack.Name = "buttonStack";
            this.buttonStack.Size = new System.Drawing.Size(112, 23);
            this.buttonStack.TabIndex = 9;
            this.buttonStack.Text = "Стек";
            this.buttonStack.UseVisualStyleBackColor = true;
            // 
            // buttonInterface
            // 
            this.buttonInterface.Location = new System.Drawing.Point(12, 77);
            this.buttonInterface.Name = "buttonInterface";
            this.buttonInterface.Size = new System.Drawing.Size(112, 23);
            this.buttonInterface.TabIndex = 8;
            this.buttonInterface.Text = "Интерфейс";
            this.buttonInterface.UseVisualStyleBackColor = true;
            // 
            // buttonClass
            // 
            this.buttonClass.Location = new System.Drawing.Point(12, 48);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Size = new System.Drawing.Size(112, 23);
            this.buttonClass.TabIndex = 7;
            this.buttonClass.Text = "Класс";
            this.buttonClass.UseVisualStyleBackColor = true;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(12, 19);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(112, 23);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            // 
            // aggregationButton
            // 
            this.aggregationButton.Location = new System.Drawing.Point(12, 302);
            this.aggregationButton.Name = "aggregationButton";
            this.aggregationButton.Size = new System.Drawing.Size(112, 23);
            this.aggregationButton.TabIndex = 5;
            this.aggregationButton.Text = "Агрегация";
            this.aggregationButton.UseVisualStyleBackColor = true;
            // 
            // associationButton
            // 
            this.associationButton.Location = new System.Drawing.Point(12, 242);
            this.associationButton.Name = "associationButton";
            this.associationButton.Size = new System.Drawing.Size(112, 23);
            this.associationButton.TabIndex = 4;
            this.associationButton.Text = "Ассоциация";
            this.associationButton.UseVisualStyleBackColor = true;
            this.associationButton.Click += new System.EventHandler(this.associationButton_Click);
            // 
            // compositionButton
            // 
            this.compositionButton.Location = new System.Drawing.Point(12, 273);
            this.compositionButton.Name = "compositionButton";
            this.compositionButton.Size = new System.Drawing.Size(112, 23);
            this.compositionButton.TabIndex = 3;
            this.compositionButton.Text = "Композиция";
            this.compositionButton.UseVisualStyleBackColor = true;
            // 
            // implementationButton
            // 
            this.implementationButton.Location = new System.Drawing.Point(12, 213);
            this.implementationButton.Name = "implementationButton";
            this.implementationButton.Size = new System.Drawing.Size(112, 23);
            this.implementationButton.TabIndex = 2;
            this.implementationButton.Text = "Имплементация";
            this.implementationButton.UseVisualStyleBackColor = true;
            // 
            // inheritanceButton
            // 
            this.inheritanceButton.Location = new System.Drawing.Point(12, 184);
            this.inheritanceButton.Name = "inheritanceButton";
            this.inheritanceButton.Size = new System.Drawing.Size(112, 23);
            this.inheritanceButton.TabIndex = 1;
            this.inheritanceButton.Text = "Наследование";
            this.inheritanceButton.UseVisualStyleBackColor = true;
            // 
            // colorLineButton
            // 
            this.colorLineButton.Location = new System.Drawing.Point(12, 358);
            this.colorLineButton.Name = "colorLineButton";
            this.colorLineButton.Size = new System.Drawing.Size(112, 23);
            this.colorLineButton.TabIndex = 0;
            this.colorLineButton.Text = "Цвет";
            this.colorLineButton.UseMnemonic = false;
            this.colorLineButton.UseVisualStyleBackColor = true;
            this.colorLineButton.Click += new System.EventHandler(this.SwitchColorPaintig);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
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

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonStack;
        private System.Windows.Forms.Button buttonInterface;
        private System.Windows.Forms.Button buttonClass;

        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarWidth;
    }
}

