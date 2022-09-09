using System;

namespace ValorX
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = Console.ReadLine();
            char[] valor = conta.ToCharArray();

            if (Char.IsDigit(valor[0]) == false)
            {
                var calculo = int.Parse(valor[4].ToString()) - int.Parse(valor[2].ToString());
                Console.WriteLine(calculo);
            }
            else if (Char.IsDigit(valor[2]) == false)
            {
                var calculo =int.Parse(valor[0].ToString()) - int.Parse(valor[4].ToString());
                Console.WriteLine(calculo);
            }
            else if (Char.IsDigit(valor[4]) == false)
            {
                var calculo = int.Parse(valor[0].ToString()) + int.Parse(valor[2].ToString());
                Console.WriteLine(calculo);
            }
            else
            {
                Console.WriteLine("Teste");
            }

        }
    }
}

