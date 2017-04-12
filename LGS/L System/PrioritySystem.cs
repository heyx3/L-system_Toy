using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LSystem
{
    /// <summary>
    /// Defines how to choose a rule from multiple applicable ones.
    /// </summary>
    public abstract class PrioritySystem
    {
        public abstract int ChooseRule(Random r, int nRules);
    }

    /// <summary>
    /// Chooses rules completely randomly.
    /// </summary>
    public class PrioritySystem_Random : PrioritySystem
    {
        public override int ChooseRule(Random r, int nRules)
        {
            return r.Next(nRules);
        }
    }

    /// <summary>
    /// More likely to choose earlier/later rules based on a parameter.
    /// </summary>
    public class PrioritySystem_Order : PrioritySystem
    {
        /// <summary>
        /// Values between 0 and 1 bias this instance toward later rules.
        /// Values greater than 1 bias this instance toward earlier rules.
        /// </summary>
        public double Distribution = 1.0;

        public PrioritySystem_Order(double distribution = 1.0)
        {
            Distribution = distribution;
        }

        public override int ChooseRule(Random r, int nRules)
        {
            //Make a random double with equal distribution between 0 and (nRules - 1).
            double d = r.NextDouble();            
            const double minD = -0.5;
            double maxD = (double)nRules - 0.5;
            d = (d * (maxD - minD)) + minD;
            d = Math.Min(Math.Max(d, 0.0), 1.0);

            //Bias it.
            d = Math.Pow(d, Distribution);

            return (int)Math.Round(d);
        }
    }
}
