namespace CubeRubik.Classes
{
    public class Side//:Cube
    {
        //public Layer Layer { get; set; }
        public virtual void Rotate(int countTurns, int[] layer)
        {

        }

        //public Color _color;
        public int[] hLayer1;
        public int[] hLayer2;
        public int[] hLayer3;
        public int[] vLayer1;
        public int[] vLayer2;
        public int[] vLayer3;

        public Side(int color)
        {
            if(color==1)
            {
                hLayer1 = new int[3];
                hLayer1[0] = 1;
                hLayer1[1] = 1;
                hLayer1[2] = 1;
                hLayer2 = new int[3];
                hLayer2[0] = 1;
                hLayer2[1] = 1;
                hLayer2[2] = 1;
                hLayer3 = new int[3];
                hLayer3[0] = 1;
                hLayer3[1] = 1;
                hLayer3[2] = 1;

                //Вертикальные слои
                vLayer1 = new int[3];
                vLayer1[0] = hLayer1[0];
                vLayer1[1] = hLayer2[0];
                vLayer1[2] = hLayer3[0];
                vLayer2 = new int[3];
                vLayer2[0] = hLayer1[1];
                vLayer2[1] = hLayer2[1];
                vLayer2[2] = hLayer3[1];
                vLayer3 = new int[3];
                vLayer3[0] = hLayer1[2];
                vLayer3[1] = hLayer2[2];
                vLayer3[2] = hLayer3[2];
            }
        }

        //public struct Color
        //{
        //    public const int RED = 1;
        //    public const int YELLOW = 2;
        //    public const int ORANGE = 3;
        //    public const int WHITE = 4;
        //    public const int BLUE = 5;
        //    public const int GREEN = 6;
        //}
    }
}
