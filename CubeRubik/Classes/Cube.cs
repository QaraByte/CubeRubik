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
            SideOne = new Side(Side.SideNumber.ONE);
            SideTwo = new Side(Side.SideNumber.TWO);
            SideThree = new Side(Side.SideNumber.THREE);
            SideFour = new Side(Side.SideNumber.FOUR);
            SideFive = new Side(Side.SideNumber.FIVE);
            SideSix = new Side(Side.SideNumber.SIX);
        }

        public void Rotate(int countTurns, int typeLayer, int direction)
        {
            if (direction == Side.Direction.UP)
            {
                //Третий вертикальный слой
                if (typeLayer == Layer.TypeLayer.V3)
                {
                    //Сохраняем значения 4-ой стороны
                    int cellColorFour0 = this.SideFour.vLayer3.cells[0];
                    int cellColorFour1 = this.SideFour.vLayer3.cells[1];
                    int cellColorFour2 = this.SideFour.vLayer3.cells[2];
                    //Записываем цвета 3-ей стороны на 4-ую сторону
                    this.SideFour.vLayer3.cells[0] = SideThree.vLayer3.cells[0];
                    this.SideFour.vLayer3.cells[1] = SideThree.vLayer3.cells[1];
                    this.SideFour.vLayer3.cells[2] = SideThree.vLayer3.cells[2];
                    //Записываем цвета 2-ой стороны на 3-ью сторону
                    this.SideThree.vLayer3.cells[0] = SideTwo.vLayer3.cells[0];
                    this.SideThree.vLayer3.cells[1] = SideTwo.vLayer3.cells[1];
                    this.SideThree.vLayer3.cells[2] = SideTwo.vLayer3.cells[2];
                    //Записываем цвета 1-ой стороны на 2-ую сторону
                    this.SideTwo.vLayer3.cells[0] = SideOne.vLayer3.cells[0];
                    this.SideTwo.vLayer3.cells[1] = SideOne.vLayer3.cells[1];
                    this.SideTwo.vLayer3.cells[2] = SideOne.vLayer3.cells[2];
                    //Записываем цвета 4-ой стороны на 1-ую сторону
                    this.SideOne.vLayer3.cells[0] = cellColorFour0;
                    this.SideOne.vLayer3.cells[1] = cellColorFour1;
                    this.SideOne.vLayer3.cells[2] = cellColorFour2;
                }
            }
        }
    }
}
