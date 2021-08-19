using System;

namespace _18_Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer(5,5);   //p está inicializada
            p.X = 20;                       //Entonces se pueden cambiar las propiedades de p
            p.Y = 15;

            Printer p2;                     //p2 NO está inicializada
            //p2.X = 20;                      //Entonces NO SE PUEDEN cambiar las propiedades de p2
            p2.Y = 15;



            int x = p.X;
            int y = p.Y;

            Console.WriteLine("X= " + x);
            Console.WriteLine("Y= " + y);

            p.X += 10;
            p.Y += 10;

            x = p.X;
            y = p.Y;

            Triangulo t = new Triangulo();
            t.Lado1 = 10;
            t.Lado2 = 20;
            t.Lado3 = 30;

            Triangulo t2 = new Triangulo
            {
                Lado1=20
            };

            Triangulo t3 = new Triangulo
            {
                Lado1 = 20,
                Lado3=50
            };

            Triangulo t4 = new Triangulo("Rojo")
            {
                Lado1 = 30,
                Lado3 = 20
            };

            Console.WriteLine("X= " + x);
            Console.WriteLine("Y= " + y);
            Console.ReadLine();
        }
    }
}
