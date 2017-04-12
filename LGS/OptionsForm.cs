using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LGS
{
    public partial class OptionsForm : Form
    {
        public LSystemForm MainForm;

        private string oldPenSize;


        public OptionsForm(LSystemForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            backgroundColor.BackColor = MainForm.BackgroundCol;
            backgroundColorDialog.Color = MainForm.BackgroundCol;

            penColor.BackColor = MainForm.InitialState.PenCol;
            penColorDialog.Color = MainForm.InitialState.PenCol;

            penSizeValue.Text = MainForm.InitialState.PenWidth.ToString();
            oldPenSize = penSizeValue.Text;

            PointF penPosT = MainForm.InitialState.Pos;
            startPosIndicator.Location = new Point((int)(penPosT.X * startPosChooser.Width) +
                                                        (startPosIndicator.Width / 2) +
                                                        startPosChooser.Location.X,
                                                   (int)(penPosT.Y * startPosChooser.Height) +
                                                        (startPosIndicator.Height / 2) +
                                                        startPosChooser.Location.Y);
        }

        private void backgroundColor_Click(object sender, EventArgs e)
        {
            if (backgroundColorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                backgroundColor.BackColor = backgroundColorDialog.Color;
                MainForm.BackgroundCol = backgroundColor.BackColor;
            }
        }
        private void penColor_Click(object sender, EventArgs e)
        {
            if (penColorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                penColor.BackColor = penColorDialog.Color;
                MainForm.InitialState.PenCol = penColor.BackColor;
            }
        }

        private void startPosChooser_Click(object sender, EventArgs e)
        {
            Point localP = startPosChooser.PointToClient(MousePosition);
            PointF posT = new PointF((float)localP.X / startPosChooser.Width,
                                     (float)localP.Y / startPosChooser.Height);

            MainForm.InitialState.Pos = posT;
            startPosIndicator.Location = new Point((int)(posT.X * startPosChooser.Width) +
                                                        (startPosIndicator.Width / 2) +
                                                        startPosChooser.Location.X,
                                                   (int)(posT.Y * startPosChooser.Height) +
                                                        (startPosIndicator.Height / 2) +
                                                        startPosChooser.Location.Y);
        }
        private void startPosIndicator_Click(object sender, EventArgs e)
        {
            startPosChooser_Click(sender, e);
        }

        private void penSizeValue_TextChanged(object sender, EventArgs e)
        {
            float val;
            if (float.TryParse(penSizeValue.Text, out val))
            {
                MainForm.InitialState.PenWidth = val;
            }
            else
            {
                penSizeValue.Text = oldPenSize;
            }
        }
    }
}