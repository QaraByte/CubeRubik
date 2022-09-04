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
                    int cellColorFour0 = this.SideFour.hLayer1.cells[2];
                    int cellColorFour1 = this.SideFour.hLayer2.cells[2];
                    int cellColorFour2 = this.SideFour.hLayer3.cells[2];
                    //Записываем цвета 3-ей стороны на 4-ую сторону
                    this.SideFour.hLayer3.cells[2] = SideThree.hLayer3.cells[2];
                    this.SideFour.hLayer2.cells[2] = SideThree.hLayer2.cells[2];
                    this.SideFour.hLayer1.cells[2] = SideThree.hLayer3.cells[2];
                    //Записываем цвета 2-ой стороны на 3-ью сторону
                    this.SideThree.hLayer3.cells[2] = SideTwo.hLayer3.cells[2];
                    this.SideThree.hLayer2.cells[2] = SideTwo.hLayer2.cells[2];
                    this.SideThree.hLayer1.cells[2] = SideTwo.hLayer3.cells[2];
                    //Записываем цвета 1-ой стороны на 2-ую сторону
                    this.SideTwo.hLayer3.cells[2] = SideOne.hLayer3.cells[2];
                    this.SideTwo.hLayer2.cells[2] = SideOne.hLayer2.cells[2];
                    this.SideTwo.hLayer1.cells[2] = SideOne.hLayer1.cells[2];
                    //Записываем цвета 4-ой стороны на 1-ую сторону
                    this.SideOne.hLayer3.cells[2] = cellColorFour0;
                    this.SideOne.hLayer2.cells[2] = cellColorFour1;
                    this.SideOne.hLayer1.cells[2] = cellColorFour2;
                    //5-ая сторона
                    //Сохраняем первый вертикальный слой
                    //int cellV1_0 = this.SideFive.vLayer1.cells[0];
                    //int cellV1_1 = this.SideFive.vLayer1.cells[1];
                    //int cellV1_2 = this.SideFive.vLayer1.cells[2];
                    //Крутим 1-ый горизонтальный слой
                    this.SideFive.hLayer3.cells[0] = this.SideFive.hLayer1.cells[0];
                    this.SideFive.hLayer2.cells[0] = this.SideFive.hLayer1.cells[1];
                    this.SideFive.hLayer1.cells[0] = this.SideFive.hLayer1.cells[2];
                    //Крутим 2-ой слой
                    this.SideFive.hLayer3.cells[1] = this.SideFive.hLayer2.cells[0];
                    this.SideFive.hLayer1.cells[1] = this.SideFive.hLayer2.cells[2];
                    //Крутим 3-ий слой
                    this.SideFive.hLayer3.cells[2] = this.SideFive.hLayer3.cells[0];
                    this.SideFive.hLayer2.cells[2] = this.SideFive.hLayer3.cells[1];
                    this.SideFive.hLayer1.cells[2] = this.SideFive.hLayer3.cells[2];
                    
                }
            }
        }
    }
}
