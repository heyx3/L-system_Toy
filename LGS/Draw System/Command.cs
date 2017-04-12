using System;
using System.Collections.Generic;
using System.Drawing;


namespace DrawSystem
{
    /// <summary>
    /// A drawing command with an associated symbol in the L-System string.
    /// </summary>
    public abstract class Command
    {
        public char Symbol;

        public Command(char symbol) { Symbol = symbol; }

        public abstract void Apply(Drawer drawer);
    }
}