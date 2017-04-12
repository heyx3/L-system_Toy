using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;


namespace DrawSystem
{
    /// <summary>
    /// Controls the drawing system.
    /// </summary>
    public class Drawer
    {
        public State CurrentState;
        public Stack<State> PrevStates;

        public Color BackgroundCol;

        public Dictionary<char, Command> Commands;


        private Pen pen;
        private Graphics surf;


        public Drawer(State initialState, Color backgroundCol, IEnumerable<Command> commands)
        {
            CurrentState = initialState;
            PrevStates = new Stack<State>();

            BackgroundCol = backgroundCol;

            pen = new Pen(CurrentState.PenCol, CurrentState.PenWidth);

            Commands = commands.ToDictionary(cm => cm.Symbol);
        }


        public void Run(Graphics surface, string toExecute)
        {
            surf = surface;
            surf.Clear(BackgroundCol);

            Random rnd = new Random();

            foreach (char c in toExecute)
                if (Commands.ContainsKey(c))
                    Commands[c].Apply(this);
        }

        /// <summary>
        /// Moves the given amount, drawing a line between the old and new position.
        /// </summary>
        public void Move(PointF delta)
        {
            pen.Width = CurrentState.PenWidth;
            pen.Color = CurrentState.PenCol;

            PointF end = new PointF(CurrentState.Pos.X + delta.X,
                                    CurrentState.Pos.Y + delta.Y);

            surf.DrawLine(pen, CurrentState.Pos, end);
            CurrentState.Pos = end;
        }
    }
}