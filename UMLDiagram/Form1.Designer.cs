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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пунктирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сплошToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aggregationButton = new System.Windows.Forms.Button();
            this.associationButton = new System.Windows.Forms.Button();
            this.compositionButton = new System.Windows.Forms.Button();
            this.implementationButton = new System.Windows.Forms.Button();
            this.inheritanceButton = new System.Windows.Forms.Button();
            this.colorLineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(206, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 470);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.linesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem1.Text = "Width";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.SwitchWeightPaintig);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "5";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.SwitchWeightPaintig);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "10";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.SwitchWeightPaintig);
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пунктирToolStripMenuItem,
            this.сплошToolStripMenuItem});
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.linesToolStripMenuItem.Text = "Lines";
            // 
            // пунктирToolStripMenuItem
            // 
            this.пунктирToolStripMenuItem.Name = "пунктирToolStripMenuItem";
            this.пунктирToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.пунктирToolStripMenuItem.Text = "Solid";
            this.пунктирToolStripMenuItem.Click += new System.EventHandler(this.SwitchtTypesLinePaintig);
            // 
            // сплошToolStripMenuItem
            // 
            this.сплошToolStripMenuItem.Name = "сплошToolStripMenuItem";
            this.сплошToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.сплошToolStripMenuItem.Text = "Dash";
            this.сплошToolStripMenuItem.Click += new System.EventHandler(this.SwitchtTypesLinePaintig);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.aggregationButton);
            this.groupBox1.Controls.Add(this.associationButton);
            this.groupBox1.Controls.Add(this.compositionButton);
            this.groupBox1.Controls.Add(this.implementationButton);
            this.groupBox1.Controls.Add(this.inheritanceButton);
            this.groupBox1.Controls.Add(this.colorLineButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 476);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagram tools";
            // 
            // aggregationButton
            // 
            this.aggregationButton.Location = new System.Drawing.Point(12, 137);
            this.aggregationButton.Name = "aggregationButton";
            this.aggregationButton.Size = new System.Drawing.Size(158, 23);
            this.aggregationButton.TabIndex = 5;
            this.aggregationButton.Text = "Агрегация";
            this.aggregationButton.UseVisualStyleBackColor = true;
            // 
            // associationButton
            // 
            this.associationButton.Location = new System.Drawing.Point(12, 77);
            this.associationButton.Name = "associationButton";
            this.associationButton.Size = new System.Drawing.Size(158, 23);
            this.associationButton.TabIndex = 4;
            this.associationButton.Text = "Ассоциация";
            this.associationButton.UseVisualStyleBackColor = true;
            // 
            // compositionButton
            // 
            this.compositionButton.Location = new System.Drawing.Point(12, 108);
            this.compositionButton.Name = "compositionButton";
            this.compositionButton.Size = new System.Drawing.Size(158, 23);
            this.compositionButton.TabIndex = 3;
            this.compositionButton.Text = "Композиция";
            this.compositionButton.UseVisualStyleBackColor = true;
            // 
            // implementationButton
            // 
            this.implementationButton.Location = new System.Drawing.Point(12, 48);
            this.implementationButton.Name = "implementationButton";
            this.implementationButton.Size = new System.Drawing.Size(158, 23);
            this.implementationButton.TabIndex = 2;
            this.implementationButton.Text = "Имплементация";
            this.implementationButton.UseVisualStyleBackColor = true;
            // 
            // inheritanceButton
            // 
            this.inheritanceButton.Location = new System.Drawing.Point(12, 19);
            this.inheritanceButton.Name = "inheritanceButton";
            this.inheritanceButton.Size = new System.Drawing.Size(158, 23);
            this.inheritanceButton.TabIndex = 1;
            this.inheritanceButton.Text = "Наследование";
            this.inheritanceButton.UseVisualStyleBackColor = true;
            // 
            // colorLineButton
            // 
            this.colorLineButton.Location = new System.Drawing.Point(12, 253);
            this.colorLineButton.Name = "colorLineButton";
            this.colorLineButton.Size = new System.Drawing.Size(158, 23);
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
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пунктирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сплошToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button colorLineButton;
        private System.Windows.Forms.Button aggregationButton;
        private System.Windows.Forms.Button associationButton;
        private System.Windows.Forms.Button compositionButton;
        private System.Windows.Forms.Button implementationButton;
        private System.Windows.Forms.Button inheritanceButton;
    }
}

