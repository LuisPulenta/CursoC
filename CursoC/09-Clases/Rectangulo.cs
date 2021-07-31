namespace _09_Clases
{
    class Rectangulo
    {
        double baseRectangulo;
        double alturaRectangulo;
        string colorRectangulo;

        public Rectangulo ()
        {
            baseRectangulo = 4;
            alturaRectangulo = 2;
            colorRectangulo = "Azul";
        }

        public Rectangulo(double baseRect, double alturaRect, string colorRect)
        {
            baseRectangulo = baseRect;
            alturaRectangulo = alturaRect;
            colorRectangulo = colorRect;
        }

        public double CalcularPerimetro()
        {
            return baseRectangulo*2 + alturaRectangulo * 2;
        }

        public double CalcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }

        public void Deconstruct(out double baseRect, out double alturaRect, out string colorRect)
        {
            baseRect = baseRectangulo;
            alturaRect = alturaRectangulo;
            colorRect = colorRectangulo;
        }

        public static double CalcularPerimetroRectangulo(double baseRect, double alturaRect)
        {
            return baseRect * 2 + alturaRect * 2;
        }
    }
}