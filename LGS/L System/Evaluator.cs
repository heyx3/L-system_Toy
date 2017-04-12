using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LSystem
{
    /// <summary>
    /// Evaluates a string using a given set of rules.
    /// </summary>
    public struct Evaluator
    {
        public string Value;
        public IList<Rule> Rules;
        public PrioritySystem RulePriorities;

        private Random r;


        public Evaluator(string seed, IList<Rule> rules, PrioritySystem rulePriorities,
                         Random _r = null)
        {
            Value = seed;
            Rules = rules;
            RulePriorities = rulePriorities;

            r = _r;
            if (r == null)
            {
                r = new Random();
            }
        }


        public Evaluator Evaluate()
        {
            StringBuilder newStr = new StringBuilder();
            List<int> applicableRules = new List<int>();

            //Try to apply a rule to each character.
            for (int i = 0; i < Value.Length; ++i)
            {
                //Get all rules that apply to this character.
                applicableRules.Clear();
                for (int j = 0; j < Rules.Count; ++j)
                {
                    if (Rules[j].Trigger == Value[i])
                    {
                        applicableRules.Add(j);
                    }
                }

                //Choose and apply a rule if one exists, otherwise just leave the character alone.
                if (applicableRules.Count > 0)
                {
                    int j = RulePriorities.ChooseRule(r, applicableRules.Count);
                    newStr.Append(Rules[applicableRules[j]].ReplaceWith);
                }
                else
                {
                    newStr.Append(Value[i]);
                }
            }

            return new Evaluator(newStr.ToString(), Rules, RulePriorities, r);
        }
    }
}
