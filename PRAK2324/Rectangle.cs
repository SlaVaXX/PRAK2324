using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PRAK2324
{
    internal class Rectangle : Figures
    {
        private float ShortLine;
        private float LongLine;

        private Vector2 TopLeftCoordinates;
        private Vector2 BottomLeftCoordinates;
        private Vector2 TopRightCoordinates;
        private Vector2 BottomRightCoordinates;

        public Rectangle()
        {

        }
        public Rectangle(float TopLeftX, float TopLeftY, float BottomLeftX, float BottomLeftY, float TopRightX, float TopRightY, float BottomRightX, float BottomRightY)
        {

            TopLeftCoordinates.X = TopLeftX;
            TopLeftCoordinates.Y = TopLeftY;

            BottomLeftCoordinates.X = BottomLeftX;
            BottomLeftCoordinates.Y = BottomLeftY;

            TopRightCoordinates.X = TopRightX;
            TopRightCoordinates.Y = TopRightY;

            BottomRightCoordinates.X = BottomRightX;
            BottomRightCoordinates.Y = BottomRightY;

            SetLines();
        }
        public override float Area()
        {
            return (float)Math.Round(ShortLine * LongLine, 1);
        }
        public override float Perimeter()
        {
            return (float)Math.Round(2 * ShortLine + 2 * LongLine, 1);
        }
        private void SetLines()
        {

            ShortLine = (float)Math.Round(Math.Abs(Math.Sqrt(Math.Pow(BottomLeftCoordinates.X - TopLeftCoordinates.X, 2) + Math.Pow(BottomLeftCoordinates.Y - TopLeftCoordinates.Y, 2))), 1);
            LongLine = (float)Math.Round(Math.Abs(Math.Sqrt(Math.Pow(BottomRightCoordinates.X - BottomLeftCoordinates.X, 2) + Math.Pow(BottomRightCoordinates.Y - BottomLeftCoordinates.Y, 2))), 1);
        }
    }
}
