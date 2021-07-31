using System;
//using static System.Console;
//using static _09_Clases.Matemáticas;

namespace _09_Clases
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------------------------");
            Rectangulo rectangulo1 = new Rectangulo(20,10,"Azul");
            Rectangulo rectangulo2 = new Rectangulo(40, 30, "Rojo");

            double resultadoArea1 = rectangulo1.CalcularArea();
            double resultadoPerimetro1 = rectangulo1.CalcularPerimetro();
            double resultadoArea2 = rectangulo2.CalcularArea();
            double resultadoPerimetro2 = rectangulo2.CalcularPerimetro();

            Console.Write("resultadoArea Rect1 = ");
            Console.WriteLine(resultadoArea1);
            Console.Write("resultadoPerimetro  Rect1 = ");
            Console.WriteLine(resultadoPerimetro1);
            Console.Write("resultadoArea Rect2 = ");
            Console.WriteLine(resultadoArea2);
            Console.Write("resultadoPerimetro  Rect2 = ");
            Console.WriteLine(resultadoPerimetro2);


            Console.WriteLine("--------------Deconstruct--------------");
            (double baseRect, double alturaRect, string colorRect) = rectangulo1;
            Console.Write("baseRect Rect1 = ");
            Console.WriteLine(baseRect);
            Console.Write("alturaRect Rect1 = ");
            Console.WriteLine(alturaRect);
            Console.Write("colorRect Rect1 = ");
            Console.WriteLine(colorRect);

            //Métodos estáticos
            Console.WriteLine("--------------Métodos estáticos--------------");
            Console.Write("Area de un Rectangulo de 24.2 x 45.3 = ");
            Console.WriteLine(Rectangulo.CalcularPerimetroRectangulo(24.2,45.3));

            //Campos compartidos
            Console.WriteLine("--------------Campos compartidos--------------");
            Circulo circulo1 = new Circulo();
            Circulo circulo2 = new Circulo();
            Circulo circulo3 = new Circulo();
            Console.Write("Cantidad de circulos instanciados: ");
            Console.WriteLine(Circulo.numeroDeCirdulos);

            //Campos compartidos constantes
            Console.WriteLine("--------------Campos compartidos constantes--------------");
            Console.Write("El valor de PI, declarado como campo compartido constante, es: ");
            Console.WriteLine(Circulo.PI);

            //Clases anónimas
            Console.WriteLine("--------------Clases anónimas--------------");
            var objetoAnonimo = new
            {
                numero = 15,
                nombre = "Luis",
                esHombre = true
            };

            Console.Write("objetoAnonimo.nombre: ");
            Console.WriteLine(objetoAnonimo.nombre);

            Console.ReadLine();
        }
    }
}