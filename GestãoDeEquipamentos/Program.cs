using System;

namespace GestãoDeEquipamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char teste;
            int QuantidadeDeProdutos = 0;

            string[] NomeDoProduto = new string[1000];
            double[] PrecoDoProduto = new double[1000];
            string[] NumeroDeSerieDoProduto = new string[1000];
            string[] DatadeFabricacaoDoProduto = new string[1000];
            string[] FabricanteDoProduto = new string[1000];

            do
            {
                int i = 0;
                Console.WriteLine("Digite o nome do produto:");
                NomeDoProduto[i] = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto:");
                PrecoDoProduto[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o número de série do produto:");
                NumeroDeSerieDoProduto[i] = Console.ReadLine();
                Console.WriteLine("Digite a data de fabricação do produto:");
                DatadeFabricacaoDoProduto[i] = Console.ReadLine();
                Console.WriteLine("Digite o nome do produto:");
                FabricanteDoProduto[i] = Console.ReadLine();

                do
                {
                    Console.WriteLine("Deseja inserir mais um valor (S || N) ?");
                    teste = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (teste != 'S' && teste != 'N')
                    {
                        Console.WriteLine("Digite APenas S ou N");
                    }
                } while (teste != 'S' && teste != 'N');
                QuantidadeDeProdutos = QuantidadeDeProdutos + 1;
                i = i + 1;
            } while (teste == 'S');

            //("Nome: "+NomeDoProduto[j]+" Número de Série: "+NumeroDeSerieDoProduto+" Fabricante: "+FabricanteDoProduto)  
            for(int j = 0; j < QuantidadeDeProdutos; j++)
            {
                Console.WriteLine("Nome: " + NomeDoProduto[j] + " Número de Série:" + NumeroDeSerieDoProduto[j] + " Fabricante: " + FabricanteDoProduto[j]);
            }
        }
    }
}
