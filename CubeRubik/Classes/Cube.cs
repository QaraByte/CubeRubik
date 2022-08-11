namespace CubeRubik.Classes
{
    public class Cube
    {
        //public Layer Layer { get; set; }
        public Side SideRed { get; set; }
        public Side SideYellow { get; set; }
        public Side SideOrange { get; set; }
        public Side SideWhite { get; set; }
        public Side SideBlue { get; set; }
        public Side SideGreen { get; set; }
        public Cube()
        {
            //Layer = new Layer();
            //Red red = new Red();
            SideRed = new Side(1);
            SideYellow = new Side(2);
            SideOrange = new Side(3);
            SideWhite = new Side(4);
            SideBlue = new Side(5);
            SideGreen = new Side(6);
        }
    }
}
