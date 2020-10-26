using System;

namespace Curso_Excript
{
    class Program
    {
        static public Boolean verifyString (string value)
        {
            if (value.ToLower() == "n")
            {
                return true;
            } else if (value.ToLower() == "s")
            {
                return false;
            }
            return false;
        }
        static void Main()
        {
            Boolean stop_value = false;
            Calculadora calculadora = new Calculadora();

            while(stop_value == false)
            {
                Console.WriteLine("Digite um valor:");
                
                int x = Int32.Parse(Console.ReadLine());
                int y = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"o resultado de {x} + {y} é {calculadora.Soma(x, y)}");
                Console.WriteLine("Digite Se quer continuar [S/N]");
                
                stop_value = verifyString(Console.ReadLine());
            };
        }
    }
}
