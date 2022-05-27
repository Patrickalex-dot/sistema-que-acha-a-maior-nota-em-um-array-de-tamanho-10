using System;

namespace sistema_que_acha_a_maior_nota_em_um_array_de_tamanho_10
{
    class Program
    {

        static void Main(string[] args)
        {
            double[] array = new double[10];
            double MaiorNumero = 0;


           MaiorNumero =  maiorNumero( MaiorNumero,array);



            Console.WriteLine("Seu maior Numero é: " + MaiorNumero);


        }
        static double maiorNumero(double MaiorNumero, double[]array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Digite 10 numeros");
                array[i] = Convert.ToDouble(Console.ReadLine());

                if (array[i] > MaiorNumero)
                {
                    MaiorNumero = array[i];

                }




            }
            return MaiorNumero;
        }
        
    }
}
