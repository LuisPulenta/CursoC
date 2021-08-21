using System;

namespace _19_Indexadores
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("------------------------");

            uint binData = 0b0_1111_1111_1111_1111; //número en binario
            Console.WriteLine("binData= " + binData);

            uint binData2 = 0x0_FFFF; //número en hexadecimal
            Console.WriteLine("binData2= " + binData2);

            Console.WriteLine("binData= " + Convert.ToString(binData,2));       //Para imprimir en formato binario
            Console.WriteLine("binData2= " + Convert.ToString(binData2, 16));   //Para imprimir en formato hexadecimal

            //Operadores
            Console.WriteLine("-----------Operadores----------");
            uint binDato1 = 0b0_0101;
            uint binDato2 = 0b0_1001;
            Console.WriteLine("binDato1= " + Convert.ToString(binDato1, 2));
            Console.WriteLine("binDato2= " + Convert.ToString(binDato2, 2));

            //NOT
            Console.WriteLine("-----------NOT----------");
            Console.WriteLine("NOT binDato1= " + Convert.ToString(~binDato1  , 2));
            Console.WriteLine("NOT binDato2= " + Convert.ToString(~binDato2, 2));
            
            //Left shift (<<) Desplazamiento a la izquierda
            //Right shift (>>) Desplazamiento a la derecha
            Console.WriteLine("-----------Left shift----------");
            Console.WriteLine("Left shift 2 lugares binDato1= " + Convert.ToString(binDato1 << 2, 2));
            Console.WriteLine("Left shift 2 lugares binDato2= " + Convert.ToString(binDato2 << 2, 2));
            Console.WriteLine("-----------Right shift----------");
            Console.WriteLine("Right shift 2 lugares binDato1= " + Convert.ToString(binDato1 >> 2, 2));
            Console.WriteLine("Right shift 2 lugares binDato2= " + Convert.ToString(binDato2 >> 2, 2));

            //OR
            Console.WriteLine("-----------OR----------");
            Console.WriteLine("binDato1 OR binDato2= " + Convert.ToString(binDato1 | binDato2, 2));
            
            //AND
            Console.WriteLine("-----------AND----------");
            Console.WriteLine("binDato1 AND binDato2= " + Convert.ToString(binDato1 & binDato2, 2));
            
            //XOR
            Console.WriteLine("-----------XOR----------");
            Console.WriteLine("binDato1 XOR binDato2= " + Convert.ToString(binDato1 ^ binDato2, 2));

            Console.ReadLine();
        }
    }
}