using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLE_GAME
{
    internal class DragHelper
    {
        public Point Start { get; private set; }
        public Point End { get; private set; }
        public bool IsDragging { get; private set; }

        public void Begin(Point start)
        {
            Start = start;
            End = start;
            IsDragging = true;
        }

        public void Update(Point current)
        {
            End = current;
        }

        public void EndDrag()
        {
            IsDragging = false;
        }

        public Rectangle GetRect()
        {
            return new Rectangle(
                Math.Min(Start.X, End.X),
                Math.Min(Start.Y, End.Y),
                Math.Abs(Start.X - End.X),
                Math.Abs(Start.Y - End.Y)
            );
        }
    }
}
