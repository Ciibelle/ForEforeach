using System;

namespace RevisaoForEforeach
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] alimentos = new string[6];

           alimentos[0] = "Arroz";
           alimentos[1] = "Feijão";
           alimentos[2] = "Macarrão";
           alimentos[3] = "Leite";
           alimentos[4] = "Açucar";
           alimentos[5] = "Café";

           Console.WriteLine($"*Lista De Alimentos*");
           Console.WriteLine(" ");
           Console.WriteLine($"LAÇO FOREACH");
            
           foreach(string comida in alimentos)
           {
               Console.WriteLine(comida);
           }

           Console.WriteLine("FINAL DO LAÇO FOREACH");
           Console.WriteLine(" ");
           Console.WriteLine("LAÇO FOR");

           for(int i = 0; i< alimentos.Length; i++)
           {
               Console.WriteLine(alimentos[i]);
           }

           Console.WriteLine("FINAL DO LAÇO FOR");

        }
    }
}
