namespace LGS
{
    partial class LSystemForm
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.saveImgButton = new System.Windows.Forms.Button();
            this.nIterationsBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rulesValText = new System.Windows.Forms.TextBox();
            this.regenButton = new System.Windows.Forms.Button();
            this.rulesTriggerText = new System.Windows.Forms.TextBox();
            this.setCommandsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seedText = new System.Windows.Forms.TextBox();
            this.renderedImage = new System.Windows.Forms.PictureBox();
            this.saveImgDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveSettingsDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadSettingsDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIterationsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renderedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.loadButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.saveButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.optionsButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.saveImgButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.nIterationsBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.label2);
            this.mainSplitContainer.Panel1.Controls.Add(this.label3);
            this.mainSplitContainer.Panel1.Controls.Add(this.rulesValText);
            this.mainSplitContainer.Panel1.Controls.Add(this.regenButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.rulesTriggerText);
            this.mainSplitContainer.Panel1.Controls.Add(this.setCommandsButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.label1);
            this.mainSplitContainer.Panel1.Controls.Add(this.seedText);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.renderedImage);
            this.mainSplitContainer.Size = new System.Drawing.Size(1017, 729);
            this.mainSplitContainer.SplitterDistance = 312;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(26, 652);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(261, 31);
            this.loadButton.TabIndex = 13;
            this.loadButton.Text = "Load Settings";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(26, 615);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(261, 31);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save Settings";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsButton.Location = new System.Drawing.Point(26, 541);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(261, 31);
            this.optionsButton.TabIndex = 11;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // saveImgButton
            // 
            this.saveImgButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveImgButton.Location = new System.Drawing.Point(26, 497);
            this.saveImgButton.Name = "saveImgButton";
            this.saveImgButton.Size = new System.Drawing.Size(261, 31);
            this.saveImgButton.TabIndex = 10;
            this.saveImgButton.Text = "Save as image";
            this.saveImgButton.UseVisualStyleBackColor = true;
            this.saveImgButton.Click += new System.EventHandler(this.saveImgButton_Click);
            // 
            // nIterationsBox
            // 
            this.nIterationsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nIterationsBox.Location = new System.Drawing.Point(168, 432);
            this.nIterationsBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nIterationsBox.Name = "nIterationsBox";
            this.nIterationsBox.Size = new System.Drawing.Size(62, 22);
            this.nIterationsBox.TabIndex = 9;
            this.nIterationsBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Iterations:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rules:";
            // 
            // rulesValText
            // 
            this.rulesValText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesValText.Location = new System.Drawing.Point(95, 63);
            this.rulesValText.Multiline = true;
            this.rulesValText.Name = "rulesValText";
            this.rulesValText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rulesValText.Size = new System.Drawing.Size(214, 257);
            this.rulesValText.TabIndex = 6;
            this.rulesValText.Text = "F[[+F][-F]]";
            this.rulesValText.TextChanged += new System.EventHandler(this.rulesValText_TextChanged);
            // 
            // regenButton
            // 
            this.regenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regenButton.Location = new System.Drawing.Point(26, 460);
            this.regenButton.Name = "regenButton";
            this.regenButton.Size = new System.Drawing.Size(261, 31);
            this.regenButton.TabIndex = 5;
            this.regenButton.Text = "Regenerate";
            this.regenButton.UseVisualStyleBackColor = true;
            this.regenButton.Click += new System.EventHandler(this.regenButton_Click);
            // 
            // rulesTriggerText
            // 
            this.rulesTriggerText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rulesTriggerText.Location = new System.Drawing.Point(12, 63);
            this.rulesTriggerText.Multiline = true;
            this.rulesTriggerText.Name = "rulesTriggerText";
            this.rulesTriggerText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rulesTriggerText.Size = new System.Drawing.Size(60, 257);
            this.rulesTriggerText.TabIndex = 4;
            this.rulesTriggerText.Text = "F";
            this.rulesTriggerText.TextChanged += new System.EventHandler(this.rulesTriggerText_TextChanged);
            // 
            // setCommandsButton
            // 
            this.setCommandsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setCommandsButton.Location = new System.Drawing.Point(26, 326);
            this.setCommandsButton.Name = "setCommandsButton";
            this.setCommandsButton.Size = new System.Drawing.Size(261, 31);
            this.setCommandsButton.TabIndex = 3;
            this.setCommandsButton.Text = "Set Commands";
            this.setCommandsButton.UseVisualStyleBackColor = true;
            this.setCommandsButton.Click += new System.EventHandler(this.setCommandsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seed:";
            // 
            // seedText
            // 
            this.seedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seedText.Location = new System.Drawing.Point(60, 12);
            this.seedText.Name = "seedText";
            this.seedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.seedText.Size = new System.Drawing.Size(251, 22);
            this.seedText.TabIndex = 0;
            this.seedText.Text = "F";
            // 
            // renderedImage
            // 
            this.renderedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderedImage.Location = new System.Drawing.Point(0, 0);
            this.renderedImage.Name = "renderedImage";
            this.renderedImage.Size = new System.Drawing.Size(701, 729);
            this.renderedImage.TabIndex = 0;
            this.renderedImage.TabStop = false;
            // 
            // saveImgDialog
            // 
            this.saveImgDialog.FileName = "LSystem";
            this.saveImgDialog.Filter = "BMP files|*.bmp";
            // 
            // saveSettingsDialog
            // 
            this.saveSettingsDialog.FileName = "MySetting";
            this.saveSettingsDialog.Filter = "Text files|*.txt";
            // 
            // loadSettingsDialog
            // 
            this.loadSettingsDialog.FileName = "MySetting";
            this.loadSettingsDialog.Filter = "Text Files|*.txt";
            // 
            // LSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 729);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "LSystemForm";
            this.Text = "L-System";
            this.Load += new System.EventHandler(this.LSystemForm_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nIterationsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renderedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Button setCommandsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox seedText;
        private System.Windows.Forms.TextBox rulesTriggerText;
        private System.Windows.Forms.Button regenButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rulesValText;
        private System.Windows.Forms.NumericUpDown nIterationsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveImgButton;
        private System.Windows.Forms.PictureBox renderedImage;
        private System.Windows.Forms.SaveFileDialog saveImgDialog;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveSettingsDialog;
        private System.Windows.Forms.OpenFileDialog loadSettingsDialog;
    }
}

