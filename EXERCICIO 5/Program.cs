using System;

namespace EXERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {

            double valordoproduto, percentualdedesconto, percentualimposto=0, valordodesconto, valorimposto, valorfinal;
           



            Console.WriteLine("Qual o valor do produto?");
            valordoproduto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o valor do percentual de desconto?");
            percentualdedesconto = Convert.ToDouble(Console.ReadLine());

         
            if (valordoproduto <= 100)
            {
                percentualimposto = 5;
            }

            else
            if (valordoproduto <= 300)
            {
                percentualimposto = 15;
            }
            
            else
                if(valordoproduto <= 1000)
            {
                percentualimposto = 25;
            }

            
            valordodesconto = (percentualdedesconto / 100) * valordoproduto;
            Console.WriteLine("o valor do desconto é " + valordodesconto);

            valorimposto = (percentualimposto / 100) * valordoproduto;

            valorfinal = (valordoproduto + valorimposto) - valordodesconto;
            Console.WriteLine("O valor final do produto é " + valorfinal);



            










        }
    }
}
