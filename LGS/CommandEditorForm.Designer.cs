namespace LGS
{
    partial class CommandEditorForm
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
			this.commandAndPrioritySplitPanel = new System.Windows.Forms.SplitContainer();
			this.label7 = new System.Windows.Forms.Label();
			this.scaleSaturationAmount = new System.Windows.Forms.TextBox();
			this.scaleSaturationOption = new System.Windows.Forms.RadioButton();
			this.shiftHueAmount = new System.Windows.Forms.TextBox();
			this.shiftPenHueOption = new System.Windows.Forms.RadioButton();
			this.scalePenBrightnessValue = new System.Windows.Forms.TextBox();
			this.scalePenBrightnessOption = new System.Windows.Forms.RadioButton();
			this.scalePenWidthAmount = new System.Windows.Forms.TextBox();
			this.scalePenWidthOption = new System.Windows.Forms.RadioButton();
			this.scaleMoveValue = new System.Windows.Forms.TextBox();
			this.scaleTurnValue = new System.Windows.Forms.TextBox();
			this.scaleMoveOption = new System.Windows.Forms.RadioButton();
			this.scaleTurnOption = new System.Windows.Forms.RadioButton();
			this.removeCommandButton = new System.Windows.Forms.Button();
			this.symbolTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.moveForwardValue = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.turnDegreesValue = new System.Windows.Forms.TextBox();
			this.popStackOption = new System.Windows.Forms.RadioButton();
			this.pushStackOption = new System.Windows.Forms.RadioButton();
			this.moveForwardOption = new System.Windows.Forms.RadioButton();
			this.turnDegreesOption = new System.Windows.Forms.RadioButton();
			this.newCommandButton = new System.Windows.Forms.Button();
			this.commandChoices = new System.Windows.Forms.ListBox();
			this.biasedChoiceOptions = new System.Windows.Forms.Panel();
			this.distributionTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.biasedChoiceOption = new System.Windows.Forms.RadioButton();
			this.uniformRandomChoiceOption = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.commandAndPrioritySplitPanel)).BeginInit();
			this.commandAndPrioritySplitPanel.Panel1.SuspendLayout();
			this.commandAndPrioritySplitPanel.Panel2.SuspendLayout();
			this.commandAndPrioritySplitPanel.SuspendLayout();
			this.biasedChoiceOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// commandAndPrioritySplitPanel
			// 
			this.commandAndPrioritySplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.commandAndPrioritySplitPanel.Location = new System.Drawing.Point(0, 0);
			this.commandAndPrioritySplitPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.commandAndPrioritySplitPanel.Name = "commandAndPrioritySplitPanel";
			// 
			// commandAndPrioritySplitPanel.Panel1
			// 
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.label7);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.scaleSaturationAmount);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.scaleSaturationOption);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.shiftHueAmount);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.shiftPenHueOption);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.scalePenBrightnessValue);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.scalePenBrightnessOption);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.scalePenWidthAmount);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.scalePenWidthOption);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.scaleMoveValue);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.scaleTurnValue);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.scaleMoveOption);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.scaleTurnOption);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.removeCommandButton);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.symbolTextBox);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.label6);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.label5);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.moveForwardValue);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.label4);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.turnDegreesValue);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.popStackOption);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.pushStackOption);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.moveForwardOption);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.turnDegreesOption);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.newCommandButton);
			this.commandAndPrioritySplitPanel.Panel1.Controls.Add(this.commandChoices);
			// 
			// commandAndPrioritySplitPanel.Panel2
			// 
			this.commandAndPrioritySplitPanel.Panel2.Controls.Add(this.biasedChoiceOptions);
			this.commandAndPrioritySplitPanel.Panel2.Controls.Add(this.biasedChoiceOption);
			this.commandAndPrioritySplitPanel.Panel2.Controls.Add(this.uniformRandomChoiceOption);
			this.commandAndPrioritySplitPanel.Panel2.Controls.Add(this.label1);
			this.commandAndPrioritySplitPanel.Size = new System.Drawing.Size(506, 487);
			this.commandAndPrioritySplitPanel.SplitterDistance = 301;
			this.commandAndPrioritySplitPanel.SplitterWidth = 3;
			this.commandAndPrioritySplitPanel.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(149, 396);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 25;
			this.label7.Text = "degrees";
			// 
			// scaleSaturationAmount
			// 
			this.scaleSaturationAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.scaleSaturationAmount.Location = new System.Drawing.Point(126, 416);
			this.scaleSaturationAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.scaleSaturationAmount.Name = "scaleSaturationAmount";
			this.scaleSaturationAmount.Size = new System.Drawing.Size(41, 20);
			this.scaleSaturationAmount.TabIndex = 24;
			this.scaleSaturationAmount.Text = "0.5";
			this.scaleSaturationAmount.TextChanged += new System.EventHandler(this.scaleSaturationAmount_TextChanged);
			// 
			// scaleSaturationOption
			// 
			this.scaleSaturationOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.scaleSaturationOption.AutoSize = true;
			this.scaleSaturationOption.Location = new System.Drawing.Point(9, 416);
			this.scaleSaturationOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.scaleSaturationOption.Name = "scaleSaturationOption";
			this.scaleSaturationOption.Size = new System.Drawing.Size(136, 17);
			this.scaleSaturationOption.TabIndex = 23;
			this.scaleSaturationOption.Text = "Scale pen saturation by";
			this.scaleSaturationOption.UseVisualStyleBackColor = true;
			this.scaleSaturationOption.CheckedChanged += new System.EventHandler(this.scaleSaturationOption_CheckedChanged);
			// 
			// shiftHueAmount
			// 
			this.shiftHueAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.shiftHueAmount.Location = new System.Drawing.Point(105, 394);
			this.shiftHueAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.shiftHueAmount.Name = "shiftHueAmount";
			this.shiftHueAmount.Size = new System.Drawing.Size(41, 20);
			this.shiftHueAmount.TabIndex = 22;
			this.shiftHueAmount.Text = "10";
			this.shiftHueAmount.TextChanged += new System.EventHandler(this.shiftHueAmount_TextChanged);
			// 
			// shiftPenHueOption
			// 
			this.shiftPenHueOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.shiftPenHueOption.AutoSize = true;
			this.shiftPenHueOption.Location = new System.Drawing.Point(9, 394);
			this.shiftPenHueOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.shiftPenHueOption.Name = "shiftPenHueOption";
			this.shiftPenHueOption.Size = new System.Drawing.Size(102, 17);
			this.shiftPenHueOption.TabIndex = 21;
			this.shiftPenHueOption.Text = "Shift pen hue by";
			this.shiftPenHueOption.UseVisualStyleBackColor = true;
			this.shiftPenHueOption.CheckedChanged += new System.EventHandler(this.shiftHueOption_CheckedChanged);
			// 
			// scalePenBrightnessValue
			// 
			this.scalePenBrightnessValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.scalePenBrightnessValue.Location = new System.Drawing.Point(149, 372);
			this.scalePenBrightnessValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.scalePenBrightnessValue.Name = "scalePenBrightnessValue";
			this.scalePenBrightnessValue.Size = new System.Drawing.Size(41, 20);
			this.scalePenBrightnessValue.TabIndex = 20;
			this.scalePenBrightnessValue.Text = "0.5";
			this.scalePenBrightnessValue.TextChanged += new System.EventHandler(this.scalePenBrightnessValue_TextChanged);
			// 
			// scalePenBrightnessOption
			// 
			this.scalePenBrightnessOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.scalePenBrightnessOption.AutoSize = true;
			this.scalePenBrightnessOption.Location = new System.Drawing.Point(9, 372);
			this.scalePenBrightnessOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.scalePenBrightnessOption.Name = "scalePenBrightnessOption";
			this.scalePenBrightnessOption.Size = new System.Drawing.Size(138, 17);
			this.scalePenBrightnessOption.TabIndex = 19;
			this.scalePenBrightnessOption.Text = "Scale pen brightness by";
			this.scalePenBrightnessOption.UseVisualStyleBackColor = true;
			this.scalePenBrightnessOption.CheckedChanged += new System.EventHandler(this.scalePenBrightnessOption_CheckedChanged);
			// 
			// scalePenWidthAmount
			// 
			this.scalePenWidthAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.scalePenWidthAmount.Location = new System.Drawing.Point(124, 349);
			this.scalePenWidthAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.scalePenWidthAmount.Name = "scalePenWidthAmount";
			this.scalePenWidthAmount.Size = new System.Drawing.Size(41, 20);
			this.scalePenWidthAmount.TabIndex = 18;
			this.scalePenWidthAmount.Text = "0.5";
			this.scalePenWidthAmount.TextChanged += new System.EventHandler(this.scalePenWidthAmount_TextChanged);
			// 
			// scalePenWidthOption
			// 
			this.scalePenWidthOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.scalePenWidthOption.AutoSize = true;
			this.scalePenWidthOption.Location = new System.Drawing.Point(9, 349);
			this.scalePenWidthOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.scalePenWidthOption.Name = "scalePenWidthOption";
			this.scalePenWidthOption.Size = new System.Drawing.Size(115, 17);
			this.scalePenWidthOption.TabIndex = 17;
			this.scalePenWidthOption.Text = "Scale pen width by";
			this.scalePenWidthOption.UseVisualStyleBackColor = true;
			this.scalePenWidthOption.CheckedChanged += new System.EventHandler(this.scalePenWidthOption_CheckedChanged);
			// 
			// scaleMoveValue
			// 
			this.scaleMoveValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.scaleMoveValue.Location = new System.Drawing.Point(142, 326);
			this.scaleMoveValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.scaleMoveValue.Name = "scaleMoveValue";
			this.scaleMoveValue.Size = new System.Drawing.Size(41, 20);
			this.scaleMoveValue.TabIndex = 16;
			this.scaleMoveValue.Text = "0.5";
			this.scaleMoveValue.TextChanged += new System.EventHandler(this.scaleMoveValue_TextChanged);
			// 
			// scaleTurnValue
			// 
			this.scaleTurnValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.scaleTurnValue.Location = new System.Drawing.Point(112, 284);
			this.scaleTurnValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.scaleTurnValue.Name = "scaleTurnValue";
			this.scaleTurnValue.Size = new System.Drawing.Size(42, 20);
			this.scaleTurnValue.TabIndex = 15;
			this.scaleTurnValue.Text = "0.5";
			this.scaleTurnValue.TextChanged += new System.EventHandler(this.scaleTurnValue_TextChanged);
			// 
			// scaleMoveOption
			// 
			this.scaleMoveOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.scaleMoveOption.AutoSize = true;
			this.scaleMoveOption.Location = new System.Drawing.Point(9, 327);
			this.scaleMoveOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.scaleMoveOption.Name = "scaleMoveOption";
			this.scaleMoveOption.Size = new System.Drawing.Size(136, 17);
			this.scaleMoveOption.TabIndex = 14;
			this.scaleMoveOption.Text = "Scale all movements by";
			this.scaleMoveOption.UseVisualStyleBackColor = true;
			this.scaleMoveOption.CheckedChanged += new System.EventHandler(this.scaleMoveOption_CheckedChanged);
			// 
			// scaleTurnOption
			// 
			this.scaleTurnOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.scaleTurnOption.AutoSize = true;
			this.scaleTurnOption.Location = new System.Drawing.Point(9, 285);
			this.scaleTurnOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.scaleTurnOption.Name = "scaleTurnOption";
			this.scaleTurnOption.Size = new System.Drawing.Size(105, 17);
			this.scaleTurnOption.TabIndex = 13;
			this.scaleTurnOption.Text = "Scale all turns by";
			this.scaleTurnOption.UseVisualStyleBackColor = true;
			this.scaleTurnOption.CheckedChanged += new System.EventHandler(this.scaleTurnOption_CheckedChanged);
			// 
			// removeCommandButton
			// 
			this.removeCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.removeCommandButton.Location = new System.Drawing.Point(142, 193);
			this.removeCommandButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.removeCommandButton.Name = "removeCommandButton";
			this.removeCommandButton.Size = new System.Drawing.Size(105, 25);
			this.removeCommandButton.TabIndex = 12;
			this.removeCommandButton.Text = "Remove command";
			this.removeCommandButton.UseVisualStyleBackColor = true;
			this.removeCommandButton.Click += new System.EventHandler(this.removeCommandButton_Click);
			// 
			// symbolTextBox
			// 
			this.symbolTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.symbolTextBox.Location = new System.Drawing.Point(51, 235);
			this.symbolTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.symbolTextBox.Name = "symbolTextBox";
			this.symbolTextBox.Size = new System.Drawing.Size(22, 20);
			this.symbolTextBox.TabIndex = 11;
			this.symbolTextBox.Text = "F";
			this.symbolTextBox.TextChanged += new System.EventHandler(this.symbolTextBox_TextChanged);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 237);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Symbol:";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(120, 308);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "pixels";
			// 
			// moveForwardValue
			// 
			this.moveForwardValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.moveForwardValue.Location = new System.Drawing.Point(94, 306);
			this.moveForwardValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.moveForwardValue.Name = "moveForwardValue";
			this.moveForwardValue.Size = new System.Drawing.Size(22, 20);
			this.moveForwardValue.TabIndex = 8;
			this.moveForwardValue.Text = "10";
			this.moveForwardValue.TextChanged += new System.EventHandler(this.moveForwardValue_TextChanged);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(76, 264);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "degrees";
			// 
			// turnDegreesValue
			// 
			this.turnDegreesValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.turnDegreesValue.Location = new System.Drawing.Point(51, 262);
			this.turnDegreesValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.turnDegreesValue.Name = "turnDegreesValue";
			this.turnDegreesValue.Size = new System.Drawing.Size(22, 20);
			this.turnDegreesValue.TabIndex = 6;
			this.turnDegreesValue.Text = "45";
			this.turnDegreesValue.TextChanged += new System.EventHandler(this.turnDegreesValue_TextChanged);
			// 
			// popStackOption
			// 
			this.popStackOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.popStackOption.AutoSize = true;
			this.popStackOption.Location = new System.Drawing.Point(9, 460);
			this.popStackOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.popStackOption.Name = "popStackOption";
			this.popStackOption.Size = new System.Drawing.Size(126, 17);
			this.popStackOption.TabIndex = 5;
			this.popStackOption.Text = "Pop state off of stack";
			this.popStackOption.UseVisualStyleBackColor = true;
			this.popStackOption.CheckedChanged += new System.EventHandler(this.popStackOption_CheckedChanged);
			// 
			// pushStackOption
			// 
			this.pushStackOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pushStackOption.AutoSize = true;
			this.pushStackOption.Location = new System.Drawing.Point(9, 438);
			this.pushStackOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pushStackOption.Name = "pushStackOption";
			this.pushStackOption.Size = new System.Drawing.Size(128, 17);
			this.pushStackOption.TabIndex = 4;
			this.pushStackOption.Text = "Push state onto stack";
			this.pushStackOption.UseVisualStyleBackColor = true;
			this.pushStackOption.CheckedChanged += new System.EventHandler(this.pushStackOption_CheckedChanged);
			// 
			// moveForwardOption
			// 
			this.moveForwardOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.moveForwardOption.AutoSize = true;
			this.moveForwardOption.Location = new System.Drawing.Point(9, 307);
			this.moveForwardOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.moveForwardOption.Name = "moveForwardOption";
			this.moveForwardOption.Size = new System.Drawing.Size(90, 17);
			this.moveForwardOption.TabIndex = 3;
			this.moveForwardOption.Text = "Move forward";
			this.moveForwardOption.UseVisualStyleBackColor = true;
			this.moveForwardOption.CheckedChanged += new System.EventHandler(this.moveForwardOption_CheckedChanged);
			// 
			// turnDegreesOption
			// 
			this.turnDegreesOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.turnDegreesOption.AutoSize = true;
			this.turnDegreesOption.Checked = true;
			this.turnDegreesOption.Location = new System.Drawing.Point(9, 262);
			this.turnDegreesOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.turnDegreesOption.Name = "turnDegreesOption";
			this.turnDegreesOption.Size = new System.Drawing.Size(47, 17);
			this.turnDegreesOption.TabIndex = 2;
			this.turnDegreesOption.TabStop = true;
			this.turnDegreesOption.Text = "Turn";
			this.turnDegreesOption.UseVisualStyleBackColor = true;
			this.turnDegreesOption.CheckedChanged += new System.EventHandler(this.turnDegreesOption_CheckedChanged);
			// 
			// newCommandButton
			// 
			this.newCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.newCommandButton.Location = new System.Drawing.Point(11, 194);
			this.newCommandButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.newCommandButton.Name = "newCommandButton";
			this.newCommandButton.Size = new System.Drawing.Size(105, 25);
			this.newCommandButton.TabIndex = 1;
			this.newCommandButton.Text = "Add new command";
			this.newCommandButton.UseVisualStyleBackColor = true;
			this.newCommandButton.Click += new System.EventHandler(this.newCommandButton_Click);
			// 
			// commandChoices
			// 
			this.commandChoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.commandChoices.FormattingEnabled = true;
			this.commandChoices.Items.AddRange(new object[] {
            "\'F\': Move forward 10 pixels",
            "\'+\': Turn right 30 degrees",
            "\'-\': Turn left 30 degrees"});
			this.commandChoices.Location = new System.Drawing.Point(2, 3);
			this.commandChoices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.commandChoices.Name = "commandChoices";
			this.commandChoices.Size = new System.Drawing.Size(284, 186);
			this.commandChoices.TabIndex = 0;
			this.commandChoices.SelectedIndexChanged += new System.EventHandler(this.commandChoices_SelectedIndexChanged);
			// 
			// biasedChoiceOptions
			// 
			this.biasedChoiceOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.biasedChoiceOptions.Controls.Add(this.distributionTextBox);
			this.biasedChoiceOptions.Controls.Add(this.label3);
			this.biasedChoiceOptions.Controls.Add(this.label2);
			this.biasedChoiceOptions.Location = new System.Drawing.Point(5, 86);
			this.biasedChoiceOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.biasedChoiceOptions.Name = "biasedChoiceOptions";
			this.biasedChoiceOptions.Size = new System.Drawing.Size(188, 81);
			this.biasedChoiceOptions.TabIndex = 3;
			// 
			// distributionTextBox
			// 
			this.distributionTextBox.Location = new System.Drawing.Point(70, 3);
			this.distributionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.distributionTextBox.Name = "distributionTextBox";
			this.distributionTextBox.Size = new System.Drawing.Size(50, 20);
			this.distributionTextBox.TabIndex = 2;
			this.distributionTextBox.Text = "1.0";
			this.distributionTextBox.TextChanged += new System.EventHandler(this.distributionTextBox_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 32);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(162, 26);
			this.label3.TabIndex = 1;
			this.label3.Text = "Between 0 and 1 for earlier rules,\r\ngreater than 1 for later rules.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 3);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Distribution:";
			// 
			// biasedChoiceOption
			// 
			this.biasedChoiceOption.AutoSize = true;
			this.biasedChoiceOption.Location = new System.Drawing.Point(5, 66);
			this.biasedChoiceOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.biasedChoiceOption.Name = "biasedChoiceOption";
			this.biasedChoiceOption.Size = new System.Drawing.Size(93, 17);
			this.biasedChoiceOption.TabIndex = 2;
			this.biasedChoiceOption.Text = "Biased Choice";
			this.biasedChoiceOption.UseVisualStyleBackColor = true;
			this.biasedChoiceOption.CheckedChanged += new System.EventHandler(this.biasedChoiceOption_CheckedChanged);
			// 
			// uniformRandomChoiceOption
			// 
			this.uniformRandomChoiceOption.AutoSize = true;
			this.uniformRandomChoiceOption.Checked = true;
			this.uniformRandomChoiceOption.Location = new System.Drawing.Point(5, 32);
			this.uniformRandomChoiceOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.uniformRandomChoiceOption.Name = "uniformRandomChoiceOption";
			this.uniformRandomChoiceOption.Size = new System.Drawing.Size(140, 17);
			this.uniformRandomChoiceOption.TabIndex = 1;
			this.uniformRandomChoiceOption.TabStop = true;
			this.uniformRandomChoiceOption.Text = "Uniform Random Choice";
			this.uniformRandomChoiceOption.UseVisualStyleBackColor = true;
			this.uniformRandomChoiceOption.CheckedChanged += new System.EventHandler(this.uniformRandomChoiceOption_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Rule Priority:";
			// 
			// CommandEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 487);
			this.Controls.Add(this.commandAndPrioritySplitPanel);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "CommandEditorForm";
			this.Text = "L-System Commands";
			this.Load += new System.EventHandler(this.CommandEditorForm_Load);
			this.commandAndPrioritySplitPanel.Panel1.ResumeLayout(false);
			this.commandAndPrioritySplitPanel.Panel1.PerformLayout();
			this.commandAndPrioritySplitPanel.Panel2.ResumeLayout(false);
			this.commandAndPrioritySplitPanel.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.commandAndPrioritySplitPanel)).EndInit();
			this.commandAndPrioritySplitPanel.ResumeLayout(false);
			this.biasedChoiceOptions.ResumeLayout(false);
			this.biasedChoiceOptions.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer commandAndPrioritySplitPanel;
        private System.Windows.Forms.RadioButton uniformRandomChoiceOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton biasedChoiceOption;
        private System.Windows.Forms.ListBox commandChoices;
        private System.Windows.Forms.Panel biasedChoiceOptions;
        private System.Windows.Forms.TextBox distributionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newCommandButton;
        private System.Windows.Forms.RadioButton turnDegreesOption;
        private System.Windows.Forms.RadioButton moveForwardOption;
        private System.Windows.Forms.RadioButton popStackOption;
        private System.Windows.Forms.RadioButton pushStackOption;
        private System.Windows.Forms.TextBox turnDegreesValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox moveForwardValue;
        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button removeCommandButton;
        private System.Windows.Forms.TextBox scaleTurnValue;
        private System.Windows.Forms.RadioButton scaleMoveOption;
        private System.Windows.Forms.RadioButton scaleTurnOption;
        private System.Windows.Forms.TextBox scaleMoveValue;
        private System.Windows.Forms.TextBox scalePenWidthAmount;
        private System.Windows.Forms.RadioButton scalePenWidthOption;
        private System.Windows.Forms.TextBox scalePenBrightnessValue;
        private System.Windows.Forms.RadioButton scalePenBrightnessOption;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox scaleSaturationAmount;
        private System.Windows.Forms.RadioButton scaleSaturationOption;
        private System.Windows.Forms.TextBox shiftHueAmount;
        private System.Windows.Forms.RadioButton shiftPenHueOption;
	}
}