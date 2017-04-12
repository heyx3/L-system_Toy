using System;
using System.Collections.Generic;
using System.Drawing;


namespace DrawSystem
{
    /// <summary>
    /// The current state of the drawing system.
    /// </summary>
    public struct State
    {
        public PointF Pos;
        public double Angle;

        public Color PenCol;
        public float PenWidth;

        public float MoveScale;
        public float TurnScale;


        public State(PointF pos, double angle,
                     Color penCol, float penWidth,
                     float moveScale, float turnScale)
        {
            Pos = pos;
            Angle = angle;
            PenCol = penCol;
            PenWidth = penWidth;
            MoveScale = moveScale;
            TurnScale = turnScale;
        }
    }
}