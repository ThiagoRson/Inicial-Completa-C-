using System;

namespace estrutura.While.Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //segurança
            #region

            //int s1 = int.Parse(Console.ReadLine());
            //while ( s1 != 2002)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Senha Inválida");
            //    s1 = (int.Parse)(Console.ReadLine());
            //}
            //Console.Clear();
            //Console.WriteLine("Acesso Permitido");
            #endregion

            //quadranteUsandoWhile
            #region
            //string[] v = Console.ReadLine().Split(" ");
            //int x = int.Parse(v[0]);
            //int y = int.Parse(v[1]);

            //while (x != 0 || y != 0)
            //{
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("primeiro");
            //    }
            //    else if (x > 0 && y < 0)
            //    {
            //        Console.WriteLine("quarto");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("terceiro");
            //    }
            //    else if (x < 0 && y > 0) 
            //    {
            //        Console.WriteLine("segundo");
            //    }
            //    v = Console.ReadLine().Split(" ");
            //    x = int.Parse(v[0]);
            //    y = int.Parse(v[1]);
            #endregion

            //calcularReputação
            #region
            
            int s1 = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (s1 != 4)
            {
                if (s1 == 1)
                {
                    alcool++;
                    s1 = int.Parse(Console.ReadLine());
                }
                else if (s1 == 2)
                {
                    gasolina++;
                    s1 = int.Parse(Console.ReadLine());
                }
                else if (s1 == 3)
                {
                    diesel++;
                    s1 = int.Parse(Console.ReadLine());
                }
                else
                {
                    s1 = int.Parse(Console.ReadLine());
                }
            }
                Console.Clear();
                Console.WriteLine("Muito Obrigado\nAlcool: {0}\nGasolina: {1}\nDiesel: {2}", alcool, gasolina, diesel);
#endregion



        }
    }
}
