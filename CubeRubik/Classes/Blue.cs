namespace CubeRubik.Classes
{
    public class Blue:Side
    {
        public Layer layer = new Layer();
        public Blue()
        {
            layer.points = new List<int>();
        }
    }
}
