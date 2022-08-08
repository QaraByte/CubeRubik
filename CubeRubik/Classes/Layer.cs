using System.Drawing;

namespace CubeRubik.Classes
{
    public class Layer
    {
        public List<int> points { get; set; }
        public int[] hLayer1 { get; set; }
        public int[] hLayer2 { get; set; }
        public int[] hLayer3 { get; set; }
        public int[] vLayer1 { get; set; }
        public int[] vLayer2 { get; set; }
        public int[] vLayer3 { get; set; }
    }
}
