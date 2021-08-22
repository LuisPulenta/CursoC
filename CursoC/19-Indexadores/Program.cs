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

            //Combinando operadores
            Console.WriteLine("-----------Combinando operadores----------");
            var uno = 0b0_00000001;
            var desplazamiento = uno << 6; // <-- 01000000
            uint binDatoA = 0b0_11000000;
            uint binDatoB = 0b0_10000000;
            var resultadoA = (binDatoA & desplazamiento) != 0;
            var resultadoB = (binDatoB & desplazamiento) != 0;
            Console.WriteLine("binDatoA tiene en el bit 6= " + resultadoA.ToString());
            Console.WriteLine("binDatoB tiene en el bit 6= " + resultadoB.ToString());
            Console.WriteLine("-----------Otra forma mas directa----------");
            var resultadoC = (binDatoA & (1<<6)) != 0;
            Console.WriteLine("binDatoA tiene en el bit 6= " + resultadoA.ToString());

            Console.WriteLine("-----------Uso de indexadores----------");
            int binDatoC = 0b0_1111111_11111111_11111111_11101011;
            Console.WriteLine("binDatoC= " + Convert.ToString(binDatoC, 2));

            Bits bits = new Bits(binDatoC);
            bool datoPos0 = bits[0];
            bool datoPos1 = bits[1];
            bool datoPos2 = bits[2];
            bool datoPos3 = bits[3];
            Console.WriteLine("datoPos0= " + datoPos0);
            Console.WriteLine("datoPos1= " + datoPos1);
            Console.WriteLine("datoPos2= " + datoPos2);
            Console.WriteLine("datoPos3= " + datoPos3);

            bits[0] = false;
            Console.WriteLine("bits[0]= " + bits[0]);

            Console.ReadLine();
        }
    }
}