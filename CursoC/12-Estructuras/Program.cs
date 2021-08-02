using System;

namespace _12_Estructuras
{
    class Program
    {
        static void Main()
        {
            //¿Cómo se inicializa una estructura?
            Console.WriteLine("----------------------------");
            Point? p = new Point();
            Print(p);


            //Copiando valores de una estructura
            Console.WriteLine("----------------------------");
            StructPoint s1 = new StructPoint();
            StructPoint s2 = s1;
            Console.Write("s1.X = ");
            Console.WriteLine(s1.X);
            Console.Write("s2.X = ");
            Console.WriteLine(s2.X);
            s1.X++;
            Console.Write("s1.X después de s1.X++= ");
            Console.WriteLine(s1.X);
            Console.Write("s2.X después de s1.X++ = ");
            Console.WriteLine(s2.X);

            ClassPoint c1 = new ClassPoint();
            ClassPoint c2 = c1;
            Console.Write("c1.X = ");
            Console.WriteLine(c1.X);
            Console.Write("c2.X = ");
            Console.WriteLine(c2.X);
            c1.X++;
            Console.Write("c1.X después de c1.X++= ");
            Console.WriteLine(c1.X);
            Console.Write("c2.X después de c1.X++ = ");
            Console.WriteLine(c2.X);


            Console.ReadLine();
        }
        static void Print(Point? p)
        {
            Console.WriteLine(p.Value.X);
        }
    }
}