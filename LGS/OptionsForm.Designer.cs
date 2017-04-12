namespace LGS
{
    partial class OptionsForm
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
            this.backgroundColorDialog = new System.Windows.Forms.ColorDialog();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.penColor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.startPosIndicator = new Microsoft.VisualBasic.PowerPacks.OvalShape();
			this.startPosChooser = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.backgroundColor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.penColorDialog = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.penSizeValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backgroundColorDialog
            // 
            this.backgroundColorDialog.Color = System.Drawing.Color.LightGray;
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
			this.penColor,
			this.startPosIndicator,
			this.startPosChooser,
			this.backgroundColor});
			this.shapeContainer1.Size = new System.Drawing.Size(349, 342);
			this.shapeContainer1.TabIndex = 0;
			this.shapeContainer1.TabStop = false;
			// 
			// penColor
			// 
			this.penColor.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.penColor.Location = new System.Drawing.Point(141, 57);
			this.penColor.Name = "penColor";
			this.penColor.Size = new System.Drawing.Size(37, 39);
			this.penColor.Click += new System.EventHandler(this.penColor_Click);
			// 
			// startPosIndicator
			// 
			this.startPosIndicator.BackColor = System.Drawing.Color.Black;
			this.startPosIndicator.BorderWidth = 4;
			this.startPosIndicator.Cursor = System.Windows.Forms.Cursors.Hand;
			this.startPosIndicator.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.startPosIndicator.FillGradientColor = System.Drawing.Color.Black;
			this.startPosIndicator.Location = new System.Drawing.Point(268, 214);
			this.startPosIndicator.Name = "startPosIndicator";
			this.startPosIndicator.Size = new System.Drawing.Size(8, 8);
			this.startPosIndicator.Click += new System.EventHandler(this.startPosIndicator_Click);
			// 
			// startPosChooser
			// 
			this.startPosChooser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.startPosChooser.BackColor = System.Drawing.Color.White;
			this.startPosChooser.BorderColor = System.Drawing.Color.Black;
			this.startPosChooser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.startPosChooser.FillColor = System.Drawing.Color.White;
			this.startPosChooser.FillGradientColor = System.Drawing.Color.White;
			this.startPosChooser.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central;
			this.startPosChooser.Location = new System.Drawing.Point(118, 168);
			this.startPosChooser.Name = "startPosChooser";
			this.startPosChooser.SelectionColor = System.Drawing.Color.White;
			this.startPosChooser.Size = new System.Drawing.Size(228, 171);
			this.startPosChooser.Click += new System.EventHandler(this.startPosChooser_Click);
			// 
			// backgroundColor
			// 
			this.backgroundColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.backgroundColor.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.backgroundColor.Location = new System.Drawing.Point(141, 12);
			this.backgroundColor.Name = "backgroundColor";
			this.backgroundColor.Size = new System.Drawing.Size(37, 39);
			this.backgroundColor.Click += new System.EventHandler(this.backgroundColor_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Background Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pen Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pen Size:";
            // 
            // penSizeValue
            // 
            this.penSizeValue.Location = new System.Drawing.Point(141, 112);
            this.penSizeValue.Name = "penSizeValue";
            this.penSizeValue.Size = new System.Drawing.Size(57, 22);
            this.penSizeValue.TabIndex = 5;
            this.penSizeValue.Text = "2.25";
            this.penSizeValue.TextChanged += new System.EventHandler(this.penSizeValue_TextChanged);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 342);
            this.Controls.Add(this.penSizeValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog backgroundColorDialog;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape backgroundColor;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape startPosChooser;
        private Microsoft.VisualBasic.PowerPacks.OvalShape startPosIndicator;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape penColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog penColorDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox penSizeValue;
    }
}