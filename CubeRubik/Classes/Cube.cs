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

        public void Rotate(int countTurns, int typeLayer)
        {
            //Третий вертикальный слой
            if (typeLayer == Layer.TypeLayer.V3)
            {
                //Сохраняем значения 4-ой стороны
                int cellColorFour0 = this.SideFour.vLayer3.cells[0];
                int cellColorFour1 = this.SideFour.vLayer3.cells[1];
                int cellColorFour2 = this.SideFour.vLayer3.cells[2];
                //Сохраняем значения 3-ей стороны
                int cellColorThree0 = this.SideThree.vLayer3.cells[0];
                int cellColorThree1 = this.SideThree.vLayer3.cells[1];
                int cellColorThree2 = this.SideThree.vLayer3.cells[2];
                //Записываем цвета 3-ей стороны на 4-ую сторону
                this.SideFour.vLayer3.cells[0] = cellColorThree0;
                this.SideFour.vLayer3.cells[1] = cellColorThree1;
                this.SideFour.vLayer3.cells[2] = cellColorThree2;
                //Сохраняем значения 2-ой стороны
                int cellColorTwo0 = this.SideTwo.vLayer3.cells[0];
                int cellColorTwo1 = this.SideTwo.vLayer3.cells[1];
                int cellColorTwo2 = this.SideTwo.vLayer3.cells[2];
                //Записываем цвета 2-ой стороны на 3-ью сторону
                this.SideThree.vLayer3.cells[0] = cellColorTwo0;
                this.SideThree.vLayer3.cells[1] = cellColorTwo1;
                this.SideThree.vLayer3.cells[2] = cellColorTwo2;
                //Сохраняем значения 1-ой стороны
                int cellColorOne0 = this.SideOne.vLayer3.cells[0];
                int cellColorOne1 = this.SideOne.vLayer3.cells[1];
                int cellColorOne2 = this.SideOne.vLayer3.cells[2];
                //Записываем цвета 1-ой стороны на 2-ую сторону
                this.SideTwo.vLayer3.cells[0] = cellColorOne0;
                this.SideTwo.vLayer3.cells[1] = cellColorOne1;
                this.SideTwo.vLayer3.cells[2] = cellColorOne2;
                //Записываем цвета 4-ой стороны на 1-ую сторону
                this.SideOne.vLayer3.cells[0] = cellColorFour0;
                this.SideOne.vLayer3.cells[1] = cellColorFour1;
                this.SideOne.vLayer3.cells[2] = cellColorFour2;
            }
        }
    }
}
