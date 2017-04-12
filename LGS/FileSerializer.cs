using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Xml;

using DrawSystem;


public static class FileSerializer
{
    private static string RemoveNamespaces(string typeName)
    {
        string[] split = typeName.Split('.');
        return split[split.Length - 1];
    }


    /// <summary>
    /// Attempts to serialize the given data into a file.
    /// Returns an error message, or the empty string if everything went fine.
    /// </summary>
    public static string ToFile(string seed, IList<string> ruleTriggers, IList<string> ruleValues,
                                IEnumerable<Command> commands,
                                LSystem.PrioritySystem rulesPriority,
                                int nIterations, Color backgroundCol, Color penCol,
                                PointF startPos, float penThickness,
                                string filePath)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        sb.Append("seed:");
        sb.AppendLine(seed);

        sb.AppendLine("rules");
        for (int i = 0; i < ruleTriggers.Count; ++i)
        {
            sb.AppendLine("\trule");
            sb.Append("\t\ttrigger:");
            sb.AppendLine(ruleTriggers[i]);
            sb.Append("\t\tvalue:");
            sb.AppendLine(ruleValues[i]);
        }

        sb.AppendLine("commands");
        foreach (Command c in commands)
        {
            sb.AppendLine("\tcommand");
            sb.Append("\t\tsymbol:");
            sb.AppendLine(c.Symbol.ToString());
            sb.Append("\t\ttype:");
            if (c is Command_MoveForward)
            {
                sb.AppendLine("MoveForward");
                sb.Append("\t\tamount:");
                sb.AppendLine(((Command_MoveForward)c).Amount.ToString());
            }
            else if (c is Command_Turn)
            {
                sb.AppendLine("Turn");
                sb.Append("\t\tamount:");
                sb.AppendLine(((Command_Turn)c).Amount.ToString());
            }
            else if (c is Command_ScaleMove)
            {
                sb.AppendLine("ScaleMovement");
                sb.Append("\t\tscale:");
                sb.AppendLine(((Command_ScaleMove)c).Scale.ToString());
            }
            else if (c is Command_ScaleTurn)
            {
                sb.AppendLine("ScaleTurns");
                sb.Append("\t\tscale:");
                sb.AppendLine(((Command_ScaleTurn)c).Scale.ToString());
            }
            else if (c is Command_ScalePen)
            {
                sb.AppendLine("ScalePen");
                sb.Append("\t\tscale:");
                sb.AppendLine(((Command_ScalePen)c).Scale.ToString());
            }
            else if (c is Command_BrightenPen)
            {
                sb.AppendLine("BrightenPen");
                sb.Append("\t\tscale:");
                sb.AppendLine(((Command_BrightenPen)c).BrightnessScale.ToString());
            }
            else if (c is Command_ShiftHue)
            {
                sb.AppendLine("ShiftHue");
                sb.Append("\t\tamount:");
                sb.AppendLine(((Command_ShiftHue)c).Amount.ToString());
            }
            else if (c is Command_ScaleSaturation)
            {
                sb.AppendLine("ScaleSaturation");
                sb.AppendLine("\t\tscale:");
                sb.AppendLine(((Command_ScaleSaturation)c).Scale.ToString());
            }
            else if (c is Command_PopState)
            {
                sb.AppendLine("PopState");
            }
            else if (c is Command_PushState)
            {
                sb.AppendLine("PushState");
            }
            else
            {
                return "Unknown command type " + c.GetType().ToString();
            }
        }

        sb.Append("rule priority:");
        sb.AppendLine(rulesPriority.GetType().ToString());
        if (rulesPriority is LSystem.PrioritySystem_Random)
        {

        }
        else if (rulesPriority is LSystem.PrioritySystem_Order)
        {
            sb.Append("\tdistribution:");
            sb.AppendLine(((LSystem.PrioritySystem_Order)rulesPriority).Distribution.ToString());
        }
        else
        {
            return "Unknown rule priority type " + rulesPriority.GetType().ToString();
        }

        sb.Append("n iterations:");
        sb.AppendLine(nIterations.ToString());

        sb.Append("background color:");
        sb.Append(backgroundCol.R);
        sb.Append(",");
        sb.Append(backgroundCol.G);
        sb.Append(",");
        sb.AppendLine(backgroundCol.B.ToString());

        sb.Append("pen color:");
        sb.Append(penCol.R);
        sb.Append(",");
        sb.Append(penCol.G);
        sb.Append(",");
        sb.AppendLine(penCol.B.ToString());

        sb.Append("start pos:");
        sb.Append(startPos.X);
        sb.Append(",");
        sb.AppendLine(startPos.Y.ToString());

        sb.Append("pen thickness:");
        sb.AppendLine(penThickness.ToString());

        try
        {
            File.WriteAllText(filePath, sb.ToString());
        }
        catch (Exception e)
        {
            return "Error writing file: " + e.Message;
        }

        return "";
    }

    /// <summary>
    /// Loads the data out of a file.
    /// Returns an error message, or the empty string if everything went fine.
    /// </summary>
    public static string FromFile(ref string outSeed,
                                  IList<char> outRuleTriggers,
                                  IList<string> outRuleValues,
                                  IList<Command> outCommands,
                                  ref LSystem.PrioritySystem outRulesPriority,
                                  ref int outNIterations,
                                  ref Color outBackGroundCol, ref Color outPenCol,
                                  ref PointF outStartPos, ref float outPenThickness,
                                  string filePath)
    {
        string file = null;
        try
        {
            file = File.ReadAllText(filePath);
        }
        catch (Exception e)
        {
            return "Error opening file: " + e.Message;
        }

        string[] lines = file.Split('\n', '\r')
                             .Select(s => s.TrimStart(' ', '\t'))
                             .Where(s => s.Length > 0)
                             .ToArray();

        try
        {
            for (int i = 0; i < lines.Length; ++i)
            {
                if (lines[i] == "rules")
                {
                    i += 1;
                    string header = lines[i];
                    while (header == "rule")
                    {
                        for (int j = 0; j < 2; ++j)
                        {
                            i += 1;
                            string[] sides = lines[i].Split(':');
                            if (sides[0] == "trigger")
                            {
                                outRuleTriggers.Add(sides[1][0]);
                            }
                            else if (sides[0] == "value")
                            {
                                outRuleValues.Add(sides[1]);
                            }
                            else
                            {
                                return "Unknown rule parameter " + sides[0];
                            }
                        }

                        i += 1;
                        header = lines[i];
                    }
                    i -= 1;
                }
                else if (lines[i] == "commands")
                {
                    i += 1;
                    string header = lines[i];
                    while (header == "command")
                    {
                        string type = null;
                        char symbol = '\0';

                        for (int j = 0; j < 2; ++j)
                        {
                            i += 1;
                            string[] sides2 = lines[i].Split(':');
                            if (sides2[0] == "symbol")
                            {
                                symbol = sides2[1][0];
                            }
                            else if (sides2[0] == "type")
                            {
                                type = sides2[1];
                            }
                            else
                            {
                                return "Unknown initial command param " + sides2[0];
                            }
                        }

                        if (type == null)
                        {
                            return "No 'type' param for command";
                        }
                        else if (type == "MoveForward")
                        {
                            i += 1;
                            string[] sides = lines[i].Split(':');
                            if (sides[0] == "amount")
                            {
                                outCommands.Add(new Command_MoveForward(symbol, float.Parse(sides[1])));
                            }
                            else
                            {
                                return "Expected 'amount' param for Command_MoveForward";
                            }
                        }
                        else if (type == "Turn")
                        {
                            i += 1;
                            string[] sides = lines[i].Split(':');
                            if (sides[0] == "amount")
                            {
                                outCommands.Add(new Command_Turn(symbol, float.Parse(sides[1])));
                            }
                            else
                            {
                                return "Expected 'amount' param for Command_Turn";
                            }
                        }
                        else if (type == "ScaleMovement")
                        {
                            i += 1;
                            string[] sides = lines[i].Split(':');
                            if (sides[0] == "scale")
                            {
                                outCommands.Add(new Command_ScaleMove(symbol, float.Parse(sides[1])));
                            }
                            else
                            {
                                return "Expected 'scale' param for Command_ScaleMove";
                            }
                        }
                        else if (type == "ScaleTurns")
                        {
                            i += 1;
                            string[] sides = lines[i].Split(':');
                            if (sides[0] == "scale")
                            {
                                outCommands.Add(new Command_ScaleTurn(symbol, float.Parse(sides[1])));
                            }
                            else
                            {
                                return "Expected 'scale' param for Command_ScaleTurn";
                            }
                        }
                        else if (type == "ScalePen")
                        {
                            i += 1;
                            string[] sides = lines[i].Split(':');
                            if (sides[0] == "scale")
                            {
                                outCommands.Add(new Command_ScalePen(symbol, float.Parse(sides[1])));
                            }
                            else
                            {
                                return "Expected 'scale' param for Command_ScalePen";
                            }
                        }
                        else if (type == "BrightenPen")
                        {
                            i += 1;
                            string[] sides = lines[i].Split(':');
                            if (sides[0] == "scale")
                            {
                                outCommands.Add(new Command_BrightenPen(symbol, float.Parse(sides[1])));
                            }
                            else
                            {
                                return "Expected 'scale' param for Command_BrightenPen";
                            }
                        }
                        else if (type == "ShiftHue")
                        {
                            i += 1;
                            string[] sides = lines[i].Split(':');
                            if (sides[0] == "amount")
                            {
                                outCommands.Add(new Command_ShiftHue(symbol, float.Parse(sides[1])));
                            }
                            else
                            {
                                return "Expected 'amount' param for Command_ShiftHue";
                            }
                        }
                        else if (type == "ScaleSaturation")
                        {
                            i += 1;
                            string[] sides = lines[i].Split(':');
                            if (sides[0] == "scale")
                            {
                                outCommands.Add(new Command_ScaleSaturation(symbol, float.Parse(sides[1])));
                            }
                            else
                            {
                                return "Expected 'scale' param for Command_ScaleSaturation";
                            }
                        }
                        else if (type == "PushState")
                        {
                            outCommands.Add(new Command_PushState(symbol));
                        }
                        else if (type == "PopState")
                        {
                            outCommands.Add(new Command_PopState(symbol));
                        }
                        else
                        {
                            return "Unknown command type: " + type;
                        }

                        i += 1;
                        header = lines[i];
                    }
                    i -= 1;
                }
                else
                {
                    string[] sides = lines[i].Split(':');

                    if (sides[0] == "seed")
                    {
                        outSeed = sides[1];
                    }
                    else if (sides[0] == "rule priority")
                    {
                        if (sides[1] == typeof(LSystem.PrioritySystem_Order).ToString())
                        {
                            i += 1;
                            sides = lines[i].Split(':');
                            if (sides[0] == "distribution")
                            {
                                outRulesPriority = new LSystem.PrioritySystem_Order(double.Parse(sides[1]));
                            }
                            else
                            {
                                return "Unknown param for PrioritySystem_Order: " + sides[0];
                            }
                        }
                        else if (sides[1] == typeof(LSystem.PrioritySystem_Random).ToString())
                        {
                            outRulesPriority = new LSystem.PrioritySystem_Random();
                        }
                    }
                    else if (sides[0] == "n iterations")
                    {
                        outNIterations = int.Parse(sides[1]);
                    }
                    else if (sides[0] == "background color")
                    {
                        string[] components = sides[1].Split(',');
                        outBackGroundCol = Color.FromArgb(byte.Parse(components[0]),
                                                          byte.Parse(components[1]),
                                                          byte.Parse(components[2]));
                    }
                    else if (sides[0] == "pen color")
                    {
                        string[] components = sides[1].Split(',');
                        outPenCol = Color.FromArgb(byte.Parse(components[0]),
                                                   byte.Parse(components[1]),
                                                   byte.Parse(components[2]));
                    }
                    else if (sides[0] == "start pos")
                    {
                        string[] components = sides[1].Split(',');
                        outStartPos = new PointF(float.Parse(components[0]),
                                                 float.Parse(components[1]));
                    }
                    else if (sides[0] == "pen thickness")
                    {
                        outPenThickness = float.Parse(sides[1]);
                    }
                    else
                    {
                        return "Unknown param: " + sides[0];
                    }
                }
            }
        }
        catch (Exception e)
        {
            return "Error parsing file: " + e.Message;
        }

        return "";
    }
}