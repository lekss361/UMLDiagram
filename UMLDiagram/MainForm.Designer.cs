﻿namespace UMLDiagram
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRemoveTheLast = new System.Windows.Forms.Button();
            this.addictionButton = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            this.buttonStack = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
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
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Controls.Add(this.buttonRemoveTheLast);
            this.groupBox1.Controls.Add(this.addictionButton);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBarWidth);
            this.groupBox1.Controls.Add(this.buttonStack);
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
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(12, 473);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(109, 23);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
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
            // buttonStack
            // 
            this.buttonStack.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStack.Location = new System.Drawing.Point(12, 106);
            this.buttonStack.Name = "buttonStack";
            this.buttonStack.Size = new System.Drawing.Size(112, 23);
            this.buttonStack.TabIndex = 9;
            this.buttonStack.Text = "Стек";
            this.buttonStack.UseVisualStyleBackColor = false;
            this.buttonStack.Click += new System.EventHandler(this.buttonStack_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
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

        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonStack;
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
        private System.Windows.Forms.Button buttonRemove;
    }
}

