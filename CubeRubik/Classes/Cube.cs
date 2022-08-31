namespace CubeRubik.Classes
{
    public class Cube
    {
        //public Layer Layer { get; set; }
        public Side SideOne { get; set; }
        public Side SideTwo { get; set; }
        public Side SideThree { get; set; }
        public Side SideFour { get; set; }
        public Side SideFive { get; set; }
        public Side SideSix { get; set; }
        //public Layer Layer { get; set; }
        public Cube()
        {
            //Layer = new Layer();
            //Red red = new Red();
            SideOne = new Side(Side.Color.RED);
            SideTwo = new Side(Side.Color.YELLOW);
            SideThree = new Side(Side.Color.ORANGE);
            SideFour = new Side(Side.Color.WHITE);
            SideFive = new Side(Side.Color.BLUE);
            SideSix = new Side(Side.Color.GREEN);
        }
    }
}
