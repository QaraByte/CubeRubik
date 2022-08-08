namespace CubeRubik.Classes
{
    public class Side:Cube
    {
        
        public virtual void Rotate()
        {

        }

        public struct Color
        {
            public const int RED = 1;
            public const int YELLOW = 2;
            public const int ORANGE = 3;
            public const int WHITE = 4;
            public const int BLUE = 5;
            public const int GREEN = 6;
        }
    }
}
