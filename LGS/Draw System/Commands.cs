using System;
using System.Collections.Generic;
using System.Drawing;


//To add a command:
//1) Create the new class here.
//2) Add an option for it in the CommandEditorForm and add appropriate code for those UI elements.
//3) Add a block for it in CommandEditorForm.commandChoices_SelectedIndexChanged() and newCommandButton_Click().
//4) Add a block for it in both FileSerializer methods.


namespace DrawSystem
{
    /// <summary>
    /// Used for color operations like hue shift.
    /// Source: http://beesbuzz.biz/code/hsv_color_transforms.php
    /// </summary>
    internal struct Matrix
    {
        public static readonly Matrix RGBToHSV = new Matrix(
            0.299, 0.587, 0.114,
            0.596, -0.274, -0.321,
            0.211, -0.523, 0.311);
        public static readonly Matrix HSVToRGB = new Matrix(
            1.0, 0.956, 0.621,
            1.0, -0.272, -0.647,
            1.0, -1.107, 1.705);
        public static Matrix ShiftRGBHue(double shiftInDegrees)
        {
            double rad = shiftInDegrees * (Math.PI / 180.0);
            double u = Math.Cos(rad),
                   w = Math.Sin(rad);

            return new Matrix(0.299 + (0.701 * u) + (0.168 * w),
                              0.587 - (0.587 * u) + (0.33 * w),
                              0.114 - (0.114 * u) - (0.497 * w),
                              0.299 - (0.299 * u) - (0.328 * w),
                              0.587 + (0.413 * u) + (0.035 * w),
                              0.114 - (0.114 * u) + (0.292 * w),
                              0.299 - (0.3 * u) + (1.25 * w),
                              0.587 - (0.588 * u) - (1.05 * w),
                              0.114 + (0.886 * u) - (0.203 * w));
        }
        public static Matrix ScaleRGBSaturation(double scale)
        {
            return new Matrix(0.299 + (0.701 * scale),
                              0.587 - (0.587 * scale),
                              0.114 - (0.114 * scale),
                              0.299 - (0.299 * scale),
                              0.587 + (0.413 * scale),
                              0.114 - (0.114 * scale),
                              0.299 - (0.3 * scale),
                              0.587 - (0.588 * scale),
                              0.114 + (0.886 * scale));
        }


        public double[,] Vals;


        public Matrix(double m00, double m10, double m20,
                      double m01, double m11, double m21,
                      double m02, double m12, double m22)
        {
            Vals = new double[3, 3];
            Vals[0, 0] = m00;
            Vals[1, 0] = m10;
            Vals[2, 0] = m20;
            Vals[0, 1] = m01;
            Vals[1, 1] = m11;
            Vals[2, 1] = m21;
            Vals[0, 2] = m02;
            Vals[1, 2] = m12;
            Vals[2, 2] = m22;
        }

        public void MultiplyPoint(ref double x, ref double y, ref double z)
        {
            x = (x * Vals[0, 0]) + (y * Vals[1, 0]) + (z * Vals[2, 0]);
            y = (x * Vals[0, 1]) + (y * Vals[1, 1]) + (z * Vals[2, 1]);
            z = (x * Vals[0, 2]) + (y * Vals[1, 2]) + (z * Vals[2, 2]);
        }
        public Matrix Combine(Matrix left, Matrix right)
        {
            Matrix newM = new Matrix();
            for (int y = 0; y < 3; ++y)
            {
                for (int x = 0; x < 2; ++x)
                {
                    newM.Vals[x, y] = (left.Vals[x, 0] * right.Vals[0, y]) +
                                      (left.Vals[x, 1] * right.Vals[1, y]) +
                                      (left.Vals[x, 2] * right.Vals[2, y]);
                }
            }
            return newM;
        }
    }


    public class Command_PushState : Command
    {
        public Command_PushState(char symbol) : base(symbol) { }

        public override void Apply(Drawer drawer)
        {
            drawer.PrevStates.Push(drawer.CurrentState);
        }
        public override string ToString()
        {
            return Symbol.ToString() + ": Push state onto stack";
        }
    }
    public class Command_PopState : Command
    {
        public Command_PopState(char symbol) : base(symbol) { }

        public override void Apply(Drawer drawer)
        {
            if (drawer.PrevStates.Count > 0)
            {
                drawer.CurrentState = drawer.PrevStates.Pop();
            }
        }
        public override string ToString()
        {
            return Symbol.ToString() + ": Pop state off of stack";
        }
    }
    public class Command_MoveForward : Command
    {
        public float Amount;

        public Command_MoveForward(char symbol, float amount) : base(symbol) { Amount = amount; }

        public override void Apply(Drawer drawer)
        {
            const double converter = Math.PI / 180.0;

            PointF delta = new PointF(Amount * drawer.CurrentState.MoveScale *
                                        (float)Math.Cos(converter * drawer.CurrentState.Angle),
                                      Amount * drawer.CurrentState.MoveScale *
                                        (float)Math.Sin(converter * drawer.CurrentState.Angle));

            drawer.Move(delta);
        }
        public override string ToString()
        {
            return Symbol.ToString() + ": Move forward " + Amount + " pixels";
        }
    }
    public class Command_Turn : Command
    {
        public float Amount;

        public Command_Turn(char symbol, float amount) : base(symbol) { Amount = amount; }

        public override void Apply(Drawer drawer)
        {
            drawer.CurrentState.Angle += Amount * drawer.CurrentState.TurnScale;
            while (drawer.CurrentState.Angle >= 360.0f)
                drawer.CurrentState.Angle -= 360.0f;
            while (drawer.CurrentState.Angle < 0.0f)
                drawer.CurrentState.Angle += 360.0f;
        }
        public override string ToString()
        {
            return Symbol.ToString() + ": Turn " + Amount + " degrees";
        }
    }
    public class Command_ScaleMove : Command
    {
        public float Scale;

        public Command_ScaleMove(char symbol, float scale) : base(symbol) { Scale = scale; }

        public override void Apply(Drawer drawer)
        {
            drawer.CurrentState.MoveScale *= Scale;
        }
        public override string ToString()
        {
            return Symbol.ToString() + ": Scale all movement by " + Scale;
        }
    }
    public class Command_ScaleTurn : Command
    {
        public float Scale;

        public Command_ScaleTurn(char symbol, float scale) : base(symbol) { Scale = scale; }

        public override void Apply(Drawer drawer)
        {
            drawer.CurrentState.TurnScale *= Scale;
        }
        public override string ToString()
        {
            return Symbol.ToString() + ": Scale all turns by " + Scale;
        }
    }
    public class Command_ScalePen : Command
    {
        public float Scale;

        public Command_ScalePen(char symbol, float scale) : base(symbol) { Scale = scale; }

        public override void Apply(Drawer drawer)
        {
            drawer.CurrentState.PenWidth *= Scale;
        }
        public override string ToString()
        {
            return Symbol.ToString() + ": Scale the pen width by " + Scale;
        }
    }
    public class Command_BrightenPen : Command
    {
        public float BrightnessScale;

        public Command_BrightenPen(char symbol, float scale) : base(symbol) { BrightnessScale = scale; }

        public override void Apply(Drawer drawer)
        {
            float r = drawer.CurrentState.PenCol.R * BrightnessScale,
                  g = drawer.CurrentState.PenCol.G * BrightnessScale,
                  b = drawer.CurrentState.PenCol.B * BrightnessScale;
            drawer.CurrentState.PenCol =
                Color.FromArgb((int)Math.Round(Math.Min(255.0f, Math.Max(0.0f, r)), 0),
                               (int)Math.Round(Math.Min(255.0f, Math.Max(0.0f, g)), 0),
                               (int)Math.Round(Math.Min(255.0f, Math.Max(0.0f, b)), 0));
        }

        public override string ToString()
        {
            return Symbol.ToString() + ": Scale the pen's brightness by " + BrightnessScale;
        }
    }
    public class Command_ShiftHue : Command
    {
        public double Amount;

        public Command_ShiftHue(char symbol, double amount) : base(symbol) { Amount = amount; }

        public override void Apply(Drawer drawer)
        {
            //Get the color from 0 to 1.
            const double denom = 1.0 / 255.0;
            double r = drawer.CurrentState.PenCol.R * denom,
                   g = drawer.CurrentState.PenCol.G * denom,
                   b = drawer.CurrentState.PenCol.B * denom;

            //Shift hue.
            Matrix.ShiftRGBHue(Amount).MultiplyPoint(ref r, ref g, ref b);

            //Convert new color into Color struct.
            drawer.CurrentState.PenCol = Color.FromArgb(
                Math.Min(255, Math.Max(0, (int)Math.Round(r * 255.0, 0))),
                Math.Min(255, Math.Max(0, (int)Math.Round(g * 255.0, 0))),
                Math.Min(255, Math.Max(0, (int)Math.Round(b * 255.0, 0))));
        }

        public override string ToString()
        {
            return Symbol.ToString() + ": Shift hue by " + Amount;
        }
    }

    public class Command_ScaleSaturation : Command
    {
        public double Scale;

        public Command_ScaleSaturation(char symbol, double scale) : base(symbol) { Scale = scale; }

        public override void Apply(Drawer drawer)
        {
            //Get the color from 0 to 1.
            const double denom = 1.0 / 255.0;
            double r = drawer.CurrentState.PenCol.R * denom,
                   g = drawer.CurrentState.PenCol.G * denom,
                   b = drawer.CurrentState.PenCol.B * denom;

            //Scale the saturation.
            Matrix.ScaleRGBSaturation(Scale).MultiplyPoint(ref r, ref g, ref b);

            //Convert new color into Color struct.
            drawer.CurrentState.PenCol = Color.FromArgb(
                Math.Min(255, Math.Max(0, (int)Math.Round(r * 255.0, 0))),
                Math.Min(255, Math.Max(0, (int)Math.Round(g * 255.0, 0))),
                Math.Min(255, Math.Max(0, (int)Math.Round(b * 255.0, 0))));
        }

        public override string ToString()
        {
            return Symbol.ToString() + ": Scale saturation by " + Scale;
        }
    }
}