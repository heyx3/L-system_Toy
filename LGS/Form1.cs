using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LSystem;
using DrawSystem;


namespace LGS
{
    public partial class LSystemForm : Form
    {
        public LSystemForm()
        {
            InitializeComponent();
        }


        public Color BackgroundCol = Color.Black;
        public State InitialState = new State(new PointF(150.0f, 150.0f), 0.0,
                                              Color.White, 5.0f, 1.0f, 1.0f);
        public PrioritySystem RulePriorities = new PrioritySystem_Random();
        public List<Command> Commands = new List<Command>()
        {
            new Command_MoveForward('F', 10.0f),
            new Command_Turn('+', 35.0f),
            new Command_Turn('-', -35.0f),
            new Command_PushState('['),
            new Command_PopState(']'),
            new Command_ScaleMove('<', 0.5f),
            new Command_ScaleTurn('V', 0.75f),
        };

        
        private Graphics graphics;
        private Bitmap bmp;


        public int DrawAreaWidth { get { return renderedImage.Width; } }
        public int DrawAreaHeight { get { return renderedImage.Height; } }


        private void LSystemForm_Load(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                bmp = new Bitmap(renderedImage.Width, renderedImage.Height);
            }
            renderedImage.Image = bmp;

            graphics = Graphics.FromImage(bmp);
            graphics.Clear(BackgroundCol);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (graphics != null)
                graphics.Dispose();
            graphics = null;

            if (bmp != null)
                bmp.Dispose();
            bmp = null;
        }

        private void regenButton_Click(object sender, EventArgs e)
        {
            //Create the rules.
            LSystem.Rule[] rules = new Rule[rulesTriggerText.Lines.Length];
            for (int i = 0; i < rules.Length; ++i)
            {
                if (rulesTriggerText.Lines[i].Length > 0)
                {
                    rules[i] = new Rule(rulesTriggerText.Lines[i][0],
                                        rulesValText.Lines[i]);
                }
            }
            //Run the evaluator.
            LSystem.Evaluator eval = new Evaluator(seedText.Text, rules, RulePriorities);
            int nIters = (int)nIterationsBox.Value;
            for (int i = 0; i < nIters; ++i)
            {
                eval = eval.Evaluate();
            }

            //Draw the result.
            if (renderedImage.Width != bmp.Width || renderedImage.Height != bmp.Height)
            {
                graphics.Dispose();
                bmp.Dispose();
                bmp = new Bitmap(renderedImage.Width, renderedImage.Height);
                graphics = Graphics.FromImage(bmp);
            }
            PointF oldPos = InitialState.Pos;
            InitialState.Pos = new PointF(InitialState.Pos.X * DrawAreaWidth,
                                          InitialState.Pos.Y * DrawAreaHeight);
            new Drawer(InitialState, BackgroundCol, Commands).Run(graphics, eval.Value);
            InitialState.Pos = oldPos;
            renderedImage.Image = bmp;
        }
        private void setCommandsButton_Click(object sender, EventArgs e)
        {
            CommandEditorForm cef = new CommandEditorForm();
            cef.MainForm = this;
            cef.Show();
        }


        private IEnumerable<T> ResizeE<T>(IEnumerable<T> inCollection, int newSize, T defaultVal = default(T))
        {
            int nTotal = 0;
            foreach (T t in inCollection)
            {
                if (nTotal >= newSize)
                {
                    break;
                }

                yield return t;
                nTotal += 1;
            }

            while (nTotal < newSize)
            {
                yield return defaultVal;
                nTotal += 1;
            }
        }

        private void rulesValText_TextChanged(object sender, EventArgs e)
        {
            if (rulesValText.Lines.Length != rulesTriggerText.Lines.Length)
            {
                rulesTriggerText.Lines = ResizeE(rulesTriggerText.Lines,
                                                 rulesValText.Lines.Length,
                                                 "A").ToArray();
            }
        }
        private void rulesTriggerText_TextChanged(object sender, EventArgs e)
        {
            if (rulesValText.Lines.Length != rulesTriggerText.Lines.Length)
            {
                rulesValText.Lines = ResizeE(rulesValText.Lines,
                                             rulesTriggerText.Lines.Length,
                                             "").ToArray();
            }
        }

        private void saveImgButton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveImgDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                bmp.Save(saveImgDialog.FileName);
            }
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            new OptionsForm(this).Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveSettingsDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string err = FileSerializer.ToFile(seedText.Text,
                                                   rulesTriggerText.Lines, rulesValText.Lines,
                                                   Commands, RulePriorities, (int)nIterationsBox.Value,
                                                   BackgroundCol, InitialState.PenCol,
                                                   InitialState.Pos, InitialState.PenWidth,
                                                   saveSettingsDialog.FileName);
                if (err.Length > 0)
                {
                    MessageBox.Show("Couldn't save file: " + err);
                }
            }
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (loadSettingsDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string seed = "";
                int nIters = 0;
                List<char> triggers = new List<char>();
                List<string> values = new List<string>();

                Commands.Clear();

                string err = FileSerializer.FromFile(ref seed, triggers, values, Commands,
                                                     ref RulePriorities, ref nIters, ref BackgroundCol,
                                                     ref InitialState.PenCol, ref InitialState.Pos,
                                                     ref InitialState.PenWidth,
                                                     loadSettingsDialog.FileName);

                if (err.Length == 0)
                {
                    seedText.Text = seed;
                    nIterationsBox.Value = nIters;
                    rulesTriggerText.Lines = triggers.Select(c => c.ToString()).ToArray();
                    rulesValText.Lines = values.ToArray();

                    regenButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Couldn't load file: " + err);
                }
            }
        }
    }
}
