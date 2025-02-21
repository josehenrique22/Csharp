
using System;
using System.Runtime.InteropServices;
using LowLevel;

namespace Learn {

    public class Program {

        static void Main(string[] args) {
            // Ex ex = new();

            // int n1 = 10, n2 = 20;
            unsafe
            {
                // int result = ex.Sum(&n1, &n2);

                // Console.WriteLine($"The sum is: {result}");   

                // Segunda maneira

                // Aprendendo sobre alocamento de memoria manual
                // int* resultPtr = ex.Sum(&n1, &n2); 

                // Console.WriteLine($"The sum is: {*resultPtr}");
            }
            
            // Console.WriteLine(ex.ReadRadius((float)4.5));


            // Using Namespace
            // ExStruct lowLevelEx = new(2, 4);

            // Using NameSpace
            // LowLevel.ExStruct exStruct = new(10, 20);

            // exStruct.Show();

            // Ex.PositiveOrNegative();
            // int n1 = 2, n2 = 2;
            // unsafe
            // {
            //     int* ptrResult = Ex.Sum(&n1, &n2);
            //     Console.WriteLine(*ptrResult);
            // }

            LearnLowLevel exLowLevel = new();

            exLowLevel.AllocMemoryMethodEx();
            exLowLevel.ModernAllocMemoryEx();

        }
        
    }

    static public class Ex {
        // Ler 2 valores e mostrar a soma dos valores

        // Unsafe metodo retorna ponteiro
        public static unsafe int* Sum(int* n1, int* n2) 
        {
            int *result = (int*)Marshal.AllocHGlobal(sizeof(int)); // Aloca espaço para int

            *result = *n1 + *n2;

            return result;
            
        }

        public static float ReadRadius(float radius) 
        {
            float TT = (float) Math.PI;
            radius = (float)(TT * Math.Pow(radius, 2));

            return radius;
        }

        public static void PositiveOrNegative() 
        {
            Console.WriteLine("Type a Number:");
            float number = float.Parse(Console.ReadLine());

            if (number < 0) Console.WriteLine($"Number: {number} is negative");
            else Console.WriteLine($"Number: {number} is positive");
        }


    }
}