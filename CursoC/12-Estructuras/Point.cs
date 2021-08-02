namespace _12_Estructuras
{
    struct Point
    {
        //Campos
        public int X;
        public int Y;

        //Constructor
        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }

        //Métodos
        public int Calcular()
        {
            return X * Y;
        }
    }
}