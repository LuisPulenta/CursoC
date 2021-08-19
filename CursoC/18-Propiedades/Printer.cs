using System;

namespace _18_Propiedades
{
    class Printer
    {
        int x;
        int y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = VerificarX(value);
            }
        }
        public int Y { get => y; set => y = VerificarY(value); }

        int prueba;
        public int Prueba { get => prueba; set => prueba = value; }

        int prueba1;
        private int Prueba1 { get => prueba1; }

        int prueba2;
        public int Prueba2 { set => prueba2 = value; }
        

        int prueba3;
        private int Prueba3 { get => prueba3; set => prueba3 = value; }

        int prueba4;
        public int Prueba4 { get => prueba4; private set => prueba4 = value; }
        
        public int Z { get => Z1; set => Z1 = value; }
        public int Z1 { get; set; }
        

        //Constructor
        public Printer (int _x,int _y)
        {
            x = VerificarX(_x);
            y = VerificarY(_y);
        }

        public void Print()
        {

            Console.SetCursorPosition(x, y);
            Console.WriteLine("X");
        }

        private int VerificarX(int _x)
        {
            if (_x < 0 || _x > 60)
            {
                throw new ArgumentOutOfRangeException("Error en X");
            }
            else return _x;
        }
        private int VerificarY(int _y)
        {
            if (_y < 0 || _y > 50)
            {
                throw new ArgumentOutOfRangeException("Error en Y");
            }
            else return _y;
        }
    }
}