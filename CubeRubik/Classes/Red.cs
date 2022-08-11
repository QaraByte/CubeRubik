namespace CubeRubik.Classes
{
    public class Red : Side
    {
        public int _color { get; set; }

        public override void Rotate(int countTurns, int[] layer)
        {
            if(layer==vLayer3)
            {
                
            }
        }

        public Red(int color) : base(color)
        {
            _color = color;
        }
    }
}
