using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DrawSystem;
using LSystem;


namespace LGS
{
    public partial class CommandEditorForm : Form
    {
        public LSystemForm MainForm;

        private char currentSymbol;

        private double oldDistribution, oldPenHueShift, oldPenSaturationScale;
        private float oldTurnDegrees, oldMoveAmount,
                      oldTurnScale, oldMoveScale,
                      oldPenWidthScale, oldPenBrightnessScale;


        public CommandEditorForm()
        {
            InitializeComponent();
        }

        private void CommandEditorForm_Load(object sender, EventArgs e)
        {
            commandChoices.Items.Clear();
            foreach (Command c in MainForm.Commands)
                commandChoices.Items.Add(c);

            currentSymbol = symbolTextBox.Text[0];

            if (MainForm.RulePriorities is PrioritySystem_Random)
            {
                oldDistribution = double.Parse(distributionTextBox.Text);
                uniformRandomChoiceOption.Checked = true;
            }
            else
            {
                oldDistribution = ((PrioritySystem_Order)MainForm.RulePriorities).Distribution;
                distributionTextBox.Text = oldDistribution.ToString();
                biasedChoiceOption.Checked = true;
            }

            oldTurnDegrees = float.Parse(turnDegreesValue.Text);
            oldMoveAmount = float.Parse(moveForwardValue.Text);
            oldTurnScale = float.Parse(scaleTurnValue.Text);
            oldPenWidthScale = float.Parse(scalePenWidthAmount.Text);
            oldPenBrightnessScale = float.Parse(scalePenBrightnessValue.Text);
            oldPenHueShift = double.Parse(shiftHueAmount.Text);
            oldPenSaturationScale = double.Parse(scaleSaturationAmount.Text);

            if (commandChoices.Items.Count > 0)
                commandChoices.SelectedIndex = 0;
        }

        private void uniformRandomChoiceOption_CheckedChanged(object sender, EventArgs e)
        {
            if (uniformRandomChoiceOption.Checked)
            {
                MainForm.RulePriorities = new PrioritySystem_Random();
            }
        }
        private void biasedChoiceOption_CheckedChanged(object sender, EventArgs e)
        {
            if (biasedChoiceOption.Checked)
            {
                MainForm.RulePriorities = new PrioritySystem_Order(double.Parse(distributionTextBox.Text));
            }
        }
        private void distributionTextBox_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(distributionTextBox.Text, out val) && biasedChoiceOption.Checked)
            {
                PrioritySystem_Order pso = (PrioritySystem_Order)MainForm.RulePriorities;
                pso.Distribution = val;
                oldDistribution = val;
            }
        }

        private bool isAutoChanging = false;
        private void commandChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAutoChanging || commandChoices.SelectedIndex == -1)
            {
                return;
            }

            Command c = (Command)commandChoices.SelectedItem;
            symbolTextBox.Text = c.Symbol.ToString();

            isAutoChanging = true;
            if (c is Command_PushState)
            {
                pushStackOption.Checked = true;
            }
            else if (c is Command_PopState)
            {
                popStackOption.Checked = true;
            }
            else if (c is Command_MoveForward)
            {
                moveForwardOption.Checked = true;
                moveForwardValue.Text = ((Command_MoveForward)c).Amount.ToString();
            }
            else if (c is Command_Turn)
            {
                turnDegreesOption.Checked = true;
                turnDegreesValue.Text = ((Command_Turn)c).Amount.ToString();
            }
            else if (c is Command_ScaleMove)
            {
                scaleMoveOption.Checked = true;
                scaleMoveValue.Text = ((Command_ScaleMove)c).Scale.ToString();
            }
            else if (c is Command_ScaleTurn)
            {
                scaleTurnOption.Checked = true;
                scaleTurnValue.Text = ((Command_ScaleTurn)c).Scale.ToString();
            }
            else if (c is Command_ScalePen)
            {
                scalePenWidthOption.Checked = true;
                scalePenWidthAmount.Text = ((Command_ScalePen)c).Scale.ToString();
            }
            else if (c is Command_BrightenPen)
            {
                scalePenBrightnessOption.Checked = true;
                scalePenBrightnessValue.Text = ((Command_BrightenPen)c).BrightnessScale.ToString();
            }
            else if (c is Command_ShiftHue)
            {
                shiftPenHueOption.Checked = true;
                shiftHueAmount.Text = ((Command_ShiftHue)c).Amount.ToString();
            }
            else if (c is Command_ScaleSaturation)
            {
                scaleSaturationOption.Checked = true;
                scaleSaturationAmount.Text = ((Command_ScaleSaturation)c).Scale.ToString();
            }
            else
            {
                throw new NotImplementedException("Unknown command type " + c.GetType().ToString());
            }
            commandChoices.Items[commandChoices.SelectedIndex] = c;

            isAutoChanging = false;
        }


        private void symbolTextBox_TextChanged(object sender, EventArgs e)
        {
            if (symbolTextBox.Text.Length == 0)
            {
                symbolTextBox.Text = currentSymbol.ToString();
            }
            else if (symbolTextBox.Text.Length > 1)
            {
                if (symbolTextBox.Text[0] == currentSymbol)
                    symbolTextBox.Text = symbolTextBox.Text[1].ToString();
                else
                    symbolTextBox.Text = symbolTextBox.Text[0].ToString();
            }

            currentSymbol = symbolTextBox.Text[0];
            if (commandChoices.SelectedItem != null)
            {
                ((Command)commandChoices.SelectedItem).Symbol = currentSymbol;
            }
        }


        private delegate void UpdateCommandValue<T, N>(T command, N val);
        private void UpdateFloatBox<T>(ref string boxText, ref float outVal,
                                       UpdateCommandValue<T, float> updater)
            where T : Command
        {
            float val;
            if (float.TryParse(boxText, out val) &&
                commandChoices.SelectedItem != null &&
                commandChoices.SelectedItem is T)
            {
                updater((T)commandChoices.SelectedItem, val);
                outVal = val;
            }
        }
        private void UpdateDoubleBox<T>(ref string boxText, ref double outVal,
                                       UpdateCommandValue<T, double> updater)
            where T : Command
        {
            double val;
            if (double.TryParse(boxText, out val) &&
                commandChoices.SelectedItem != null &&
                commandChoices.SelectedItem is T)
            {
                updater((T)commandChoices.SelectedItem, val);
                outVal = val;
            }
        }

        private void turnDegreesValue_TextChanged(object sender, EventArgs e)
        {
            string t = turnDegreesValue.Text;
            UpdateFloatBox<Command_Turn>(ref t, ref oldTurnDegrees,
                                         (c, v) => { c.Amount = v; });
            turnDegreesValue.Text = t;
        }
        private void moveForwardValue_TextChanged(object sender, EventArgs e)
        {
            string t = moveForwardValue.Text;
            UpdateFloatBox<Command_MoveForward>(ref t, ref oldMoveAmount,
                                                (c, v) => { c.Amount = v; });
            moveForwardValue.Text = t;
        }
        private void scaleTurnValue_TextChanged(object sender, EventArgs e)
        {
            string t = scaleTurnValue.Text;
            UpdateFloatBox<Command_ScaleTurn>(ref t, ref oldTurnScale,
                                              (c, v) => { c.Scale = v; });
            scaleTurnValue.Text = t;
        }
        private void scaleMoveValue_TextChanged(object sender, EventArgs e)
        {
            string t = scaleMoveValue.Text;
            UpdateFloatBox<Command_ScaleMove>(ref t, ref oldMoveScale,
                                              (c, v) => { c.Scale = v; });
            scaleMoveValue.Text = t;
        }
        private void scalePenWidthAmount_TextChanged(object sender, EventArgs e)
        {
            string t = scalePenWidthAmount.Text;
            UpdateFloatBox<Command_ScalePen>(ref t, ref oldPenWidthScale,
                                             (c, v) => { c.Scale = v; });
            scalePenWidthAmount.Text = t;
        }
        private void scalePenBrightnessValue_TextChanged(object sender, EventArgs e)
        {
            string t = scalePenBrightnessValue.Text;
            UpdateFloatBox<Command_BrightenPen>(ref t, ref oldPenBrightnessScale,
                                                (c, v) => { c.BrightnessScale = v; });
            scalePenBrightnessValue.Text = t;
        }
        private void shiftHueAmount_TextChanged(object sender, EventArgs e)
        {
            string t = shiftHueAmount.Text;
            UpdateDoubleBox<Command_ShiftHue>(ref t, ref oldPenHueShift,
                                              (c, v) => { c.Amount = v; });
            shiftHueAmount.Text = t;
        }
        private void scaleSaturationAmount_TextChanged(object sender, EventArgs e)
        {
            string t = scaleSaturationAmount.Text;
            UpdateDoubleBox<Command_ScaleSaturation>(ref t, ref oldPenSaturationScale,
                                                     (c, v) => { c.Scale = v; });
            scaleSaturationAmount.Text = t;
        }


        private void OnRadioButtonChecked<T>(System.Func<T> commandCreator, RadioButton button)
            where T : Command
        {
            if (!isAutoChanging && button.Checked && commandChoices.SelectedIndex != -1)
            {
                int i = commandChoices.SelectedIndex;
                MainForm.Commands[i] = commandCreator();
                commandChoices.Items[i] = MainForm.Commands[i];
            }
        }

        private void turnDegreesOption_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioButtonChecked<Command_Turn>(() => new Command_Turn(currentSymbol, oldTurnDegrees),
                                               turnDegreesOption);
        }
        private void moveForwardOption_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioButtonChecked<Command_MoveForward>(() => new Command_MoveForward(currentSymbol,
                                                                                    oldMoveAmount),
                                                      moveForwardOption);
        }
        private void pushStackOption_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioButtonChecked<Command_PushState>(() => new Command_PushState(currentSymbol),
                                                    pushStackOption);
        }
        private void popStackOption_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioButtonChecked<Command_PopState>(() => new Command_PopState(currentSymbol),
                                                   popStackOption);
        }
        private void scaleTurnOption_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioButtonChecked<Command_ScaleTurn>(() => new Command_ScaleTurn(currentSymbol,
                                                                                oldTurnScale),
                                                    scaleTurnOption);
        }
        private void scaleMoveOption_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioButtonChecked<Command_ScaleMove>(() => new Command_ScaleMove(currentSymbol,
                                                                                oldMoveScale),
                                                    scaleMoveOption);
        }
        private void scalePenWidthOption_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioButtonChecked<Command_ScalePen>(() => new Command_ScalePen(currentSymbol,
                                                                              oldPenWidthScale),
                                                   scalePenWidthOption);
        }
        private void scalePenBrightnessOption_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioButtonChecked<Command_BrightenPen>(() => new Command_BrightenPen(currentSymbol,
                                                                                    oldPenBrightnessScale),
                                                      scalePenBrightnessOption);
        }
        private void shiftHueOption_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioButtonChecked<Command_ShiftHue>(() => new Command_ShiftHue(currentSymbol,
                                                                              oldPenHueShift),
                                                   shiftPenHueOption);
        }
        private void scaleSaturationOption_CheckedChanged(object sender, EventArgs e)
        {
            OnRadioButtonChecked<Command_ScaleSaturation>(() => new Command_ScaleSaturation(currentSymbol,
                                                                                            oldPenSaturationScale),
                                                          scaleSaturationOption);
        }


        private void newCommandButton_Click(object sender, EventArgs e)
        {
            Command c = null;
            if (turnDegreesOption.Checked)
            {
                c = new Command_Turn(currentSymbol, float.Parse(turnDegreesValue.Text));
            }
            else if (moveForwardOption.Checked)
            {
                c = new Command_MoveForward(currentSymbol, float.Parse(moveForwardValue.Text));
            }
            else if (pushStackOption.Checked)
            {
                c = new Command_PushState(currentSymbol);
            }
            else if (popStackOption.Checked)
            {
                c = new Command_PopState(currentSymbol);
            }
            else if (scalePenWidthOption.Checked)
            {
                c = new Command_ScalePen(currentSymbol, float.Parse(scalePenWidthAmount.Text));
            }
            else if (scalePenBrightnessOption.Checked)
            {
                c = new Command_BrightenPen(currentSymbol, float.Parse(scalePenBrightnessValue.Text));
            }
            else if (shiftPenHueOption.Checked)
            {
                c = new Command_ShiftHue(currentSymbol, double.Parse(shiftHueAmount.Text));
            }
            else if (scaleSaturationOption.Checked)
            {
                c = new Command_ScaleSaturation(currentSymbol, double.Parse(scaleSaturationAmount.Text));
            }
            else
            {
                throw new NotImplementedException("No idea which radio button is checked!");
            }

            MainForm.Commands.Add(c);
            commandChoices.Items.Add(c);
            commandChoices.SelectedItem = c;

            commandChoices.Invalidate();
        }
        private void removeCommandButton_Click(object sender, EventArgs e)
        {
            if (commandChoices.Items.Count > 1 &&
                commandChoices.SelectedIndex != -1)
            {
                MainForm.Commands.Remove((Command)commandChoices.SelectedItem);
                commandChoices.Items.RemoveAt(commandChoices.SelectedIndex);
                commandChoices.Invalidate();
            }
        }
    }
}
