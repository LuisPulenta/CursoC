namespace _18_Propiedades
{
    class Triangulo
    {
        int lado1 = 10;
        int lado2 = 10;
        int lado3 = 10;
        string color;

        public int Lado1 { get => lado1; set => lado1 = value; }
        public int Lado2 { set => lado2 = value; }
        public int Lado3 { set => lado3 = value; }

        public Triangulo()
        {

        }

        public Triangulo(string _color)
        {
            color = _color;
        }
    }
}