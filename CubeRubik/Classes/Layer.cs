using System.Drawing;

namespace CubeRubik.Classes
{
    public class Layer //: Side
    {
        //public Layer _layer;
        //public List<int> points { get; set; }
        //public int[] Layer1 { get; set; }
        public int _type { get; set; }
        public string _typeName { get; set; }

        public int[] cells { get; set; }

        //public int[] hLayer1 { get; set; }
        //public int[] hLayer2 { get; set; }
        //public int[] hLayer3 { get; set; }
        //public int[] vLayer1 { get; set; }
        //public int[] vLayer2 { get; set; }
        //public int[] vLayer3 { get; set; }
        public Layer(int type, int color1, int color2, int color3) //: base(color)
        {
            _type = type;
            switch(type)
            {
                case TypeLayer.H1: _typeName = TypeLayer.H1_STR; break;
                case TypeLayer.H2: _typeName = TypeLayer.H2_STR; break;
                case TypeLayer.H3: _typeName = TypeLayer.H3_STR; break;
                case TypeLayer.V1: _typeName = TypeLayer.V1_STR; break;
                case TypeLayer.V2: _typeName = TypeLayer.V2_STR; break;
                case TypeLayer.V3: _typeName = TypeLayer.V3_STR; break;
            }
            
            cells = new int[3];
            cells[0] = color1;
            cells[1] = color2;
            cells[2] = color3;
            //if(color== Side.Color.RED)
            //{
            //Горизонтальные слои
            //Layer layer1 = new Layer(Side.Color.RED);
            //_type = TypeLayer.H1;
            //layer1.hLayer1=new int[3];
            //layer1.hLayer1[0] = Side.Color.RED;
            //layer1.hLayer1[1] = Side.Color.RED;
            //layer1.hLayer1[2] = Side.Color.RED;
            //Layer layer2 = new Layer(Side.Color.RED);
            //layer2._type = TypeLayer.H2;
            //layer2.hLayer2 = new int[3];
            //layer2.hLayer2[0] = Side.Color.RED;
            //layer2.hLayer2[1] = Side.Color.RED;
            //layer2.hLayer2[2] = Side.Color.RED;
            //Layer layer3= new Layer(Side.Color.RED);
            //layer3._type = TypeLayer.H3;
            //layer3.hLayer3 = new int[3];
            //layer3.hLayer3[0] = Side.Color.RED;
            //layer3.hLayer3[1] = Side.Color.RED;
            //layer3.hLayer3[2] = Side.Color.RED;

            //Вертикальные слои
            //Layer layer4 = new Layer(Side.Color.RED);
            //layer4._type = TypeLayer.V1;
            //layer4.vLayer1 = new int[3];
            //layer4.vLayer1[0] = layer1.hLayer1[0];
            //layer4.vLayer1[1] = layer2.hLayer2[0];
            //layer4.vLayer1[2] = layer3.hLayer3[0];
            //Layer layer5 = new Layer(Side.Color.RED);
            //layer5._type = TypeLayer.V2;
            //layer5.vLayer2 = new int[3];
            //layer5.vLayer2[0] = layer1.hLayer1[1];
            //layer5.vLayer2[1] = layer2.hLayer2[1];
            //layer5.vLayer2[2] = layer3.hLayer3[1];
            //Layer layer6 = new Layer(Side.Color.RED);
            //layer6._type = TypeLayer.V3;
            //layer6.vLayer3 = new int[3];
            //layer6.vLayer3[0] = layer1.hLayer1[2];
            //layer6.vLayer3[1] = layer2.hLayer2[2];
            //layer6.vLayer3[2] = layer3.hLayer3[2];
            //}
        }

        public struct TypeLayer
        {
            /// <summary>
            /// Нижний горизонтальный слой
            /// </summary>
            public const int H1 = 1;
            public const string H1_STR = "Horizontal layer 1";
            /// <summary>
            /// Средний горизонтальный слой
            /// </summary>
            public const int H2 = 2;
            public const string H2_STR = "Horizontal layer 2";
            /// <summary>
            /// Верхний горизонтальный слой
            /// </summary>
            public const int H3 = 3;
            public const string H3_STR = "Horizontal layer 3";
            /// <summary>
            /// Левый вертикальный слой
            /// </summary>
            public const int V1 = 4;
            public const string V1_STR = "Vertical layer 1";
            /// <summary>
            /// Средний вертикальный слой
            /// </summary>
            public const int V2 = 5;
            public const string V2_STR = "Vertical layer 2";
            /// <summary>
            /// Правый вертикальный слой
            /// </summary>
            public const int V3 = 6;
            public const string V3_STR = "Vertical layer 3";
        }
    }
}
