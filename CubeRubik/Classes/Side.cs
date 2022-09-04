namespace CubeRubik.Classes
{
    public class Side//:Cube
    {
        //public Layer Layer { get; set; }
        
        public int _sideNumber;

        public Layer hLayer1 { get; set; }
        public Layer hLayer2 { get; set; }
        public Layer hLayer3 { get; set; }
        public Layer vLayer1 { get; set; }
        public Layer vLayer2 { get; set; }
        public Layer vLayer3 { get; set; }

        public Side(int sideNumber)
        {
            if(sideNumber == SideNumber.ONE)
            {
                _sideNumber = SideNumber.ONE;
                hLayer1 = new Layer(Layer.TypeLayer.H1, Color.RED, Color.RED, Color.RED);
                hLayer2 = new Layer(Layer.TypeLayer.H2, Color.RED, Color.RED, Color.RED);
                hLayer3 = new Layer(Layer.TypeLayer.H3, Color.RED, Color.RED, Color.RED);

                //Вертикальные слои
                vLayer1 = new Layer(Layer.TypeLayer.V1, Color.RED, Color.RED, Color.RED);
                vLayer2 = new Layer(Layer.TypeLayer.V2, Color.RED, Color.RED, Color.RED);
                vLayer3 = new Layer(Layer.TypeLayer.V3, Color.RED, Color.RED, Color.RED);
            }
            if (sideNumber == SideNumber.TWO)
            {
                _sideNumber = SideNumber.TWO;
                //Горизонтальные слои
                hLayer1 = new Layer(Layer.TypeLayer.H1, Color.YELLOW, Color.YELLOW, Color.YELLOW);
                hLayer2 = new Layer(Layer.TypeLayer.H2, Color.YELLOW, Color.YELLOW, Color.YELLOW);
                hLayer3 = new Layer(Layer.TypeLayer.H3, Color.YELLOW, Color.YELLOW, Color.YELLOW);
                //Вертикальные слои                          
                vLayer1 = new Layer(Layer.TypeLayer.V1, Color.YELLOW, Color.YELLOW, Color.YELLOW);
                vLayer2 = new Layer(Layer.TypeLayer.V2, Color.YELLOW, Color.YELLOW, Color.YELLOW);
                vLayer3 = new Layer(Layer.TypeLayer.V3, Color.YELLOW, Color.YELLOW, Color.YELLOW);
            }
            if (sideNumber == SideNumber.THREE)
            {
                _sideNumber = SideNumber.THREE;
                //Горизонтальные слои
                hLayer1 = new Layer(Layer.TypeLayer.H1, Color.ORANGE, Color.ORANGE, Color.ORANGE);
                hLayer2 = new Layer(Layer.TypeLayer.H2, Color.ORANGE, Color.ORANGE, Color.ORANGE);
                hLayer3 = new Layer(Layer.TypeLayer.H3, Color.ORANGE, Color.ORANGE, Color.ORANGE);
                //Вертикальные слои                           
                vLayer1 = new Layer(Layer.TypeLayer.V1, Color.ORANGE, Color.ORANGE, Color.ORANGE);
                vLayer2 = new Layer(Layer.TypeLayer.V2, Color.ORANGE, Color.ORANGE, Color.ORANGE);
                vLayer3 = new Layer(Layer.TypeLayer.V3, Color.ORANGE, Color.ORANGE, Color.ORANGE);
            }
            if (sideNumber == SideNumber.FOUR)
            {
                _sideNumber = SideNumber.FOUR;
                //Горизонтальные слои
                hLayer1 = new Layer(Layer.TypeLayer.H1, Color.WHITE, Color.WHITE, Color.WHITE);
                hLayer2 = new Layer(Layer.TypeLayer.H2, Color.WHITE, Color.WHITE, Color.WHITE);
                hLayer3 = new Layer(Layer.TypeLayer.H3, Color.WHITE, Color.WHITE, Color.WHITE);
                //Вертикальные слои                           
                vLayer1 = new Layer(Layer.TypeLayer.V1, Color.WHITE, Color.WHITE, Color.WHITE);
                vLayer2 = new Layer(Layer.TypeLayer.V2, Color.WHITE, Color.WHITE, Color.WHITE);
                vLayer3 = new Layer(Layer.TypeLayer.V3, Color.WHITE, Color.WHITE, Color.WHITE);
            }
            if (sideNumber == SideNumber.FIVE)
            {
                _sideNumber = SideNumber.FIVE;
                //Горизонтальные слои
                hLayer1 = new Layer(Layer.TypeLayer.H1, Color.BLUE, Color.BLUE, Color.BLUE);
                hLayer2 = new Layer(Layer.TypeLayer.H2, Color.BLUE, Color.BLUE, Color.BLUE);
                hLayer3 = new Layer(Layer.TypeLayer.H3, Color.BLUE, Color.BLUE, Color.BLUE);
                //Вертикальные слои
                vLayer1 = new Layer(Layer.TypeLayer.V1, Color.BLUE, Color.BLUE, Color.BLUE);
                vLayer2 = new Layer(Layer.TypeLayer.V2, Color.BLUE, Color.BLUE, Color.BLUE);
                vLayer3 = new Layer(Layer.TypeLayer.V3, Color.BLUE, Color.BLUE, Color.BLUE);
            }
            if (sideNumber == SideNumber.SIX)
            {
                _sideNumber = SideNumber.SIX;
                //Горизонтальные слои
                hLayer1 = new Layer(Layer.TypeLayer.H1, Color.GREEN, Color.GREEN, Color.GREEN);
                hLayer2 = new Layer(Layer.TypeLayer.H2, Color.GREEN, Color.GREEN, Color.GREEN);
                hLayer3 = new Layer(Layer.TypeLayer.H3, Color.GREEN, Color.GREEN, Color.GREEN);
                //Вертикальные слои        
                vLayer1 = new Layer(Layer.TypeLayer.V1, Color.GREEN, Color.GREEN, Color.GREEN);
                vLayer2 = new Layer(Layer.TypeLayer.V2, Color.GREEN, Color.GREEN, Color.GREEN);
                vLayer3 = new Layer(Layer.TypeLayer.V3, Color.GREEN, Color.GREEN, Color.GREEN);
            }
        }

        public struct Color
        {
            public const int RED = 1;
            public const int YELLOW = 2;
            public const int ORANGE = 3;
            public const int WHITE = 4;
            public const int BLUE = 5;
            public const int GREEN = 6;
        }

        public struct SideNumber
        {
            public const int ONE = 1;
            public const int TWO = 2;
            public const int THREE = 3;
            public const int FOUR = 4;
            public const int FIVE = 5;
            public const int SIX = 6;
        }

        public struct Direction
        {
            public const int UP = 0;
            public const int DOWN = 1;
        }
    }
}
