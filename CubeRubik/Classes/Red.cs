namespace CubeRubik.Classes
{
    public class Red:Side
    {
        public Layer layer = new Layer();
        public Red()
        {
            layer.points = new List<int>();
        }
    }
}
