using System;

namespace GestãoDeEquipamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char teste;
            int QuantidadeDeProdutos = 0, indice;

            //Controle de Equipamentos
            string[] NomeDoProduto = new string[1000];
            double[] PrecoDoProduto = new double[1000];
            string[] NumeroDeSerieDoProduto = new string[1000];
            string[] DatadeFabricacaoDoProduto = new string[1000];
            string[] FabricanteDoProduto = new string[1000];

            string[] NovoNomeDoProduto = new string[1000];
            double[] NovoPrecoDoProduto = new double[1000];
            string[] NovoNumeroDeSerieDoProduto = new string[1000];
            string[] NovoDatadeFabricacaoDoProduto = new string[1000];
            string[] NovoFabricanteDoProduto = new string[1000];

            do
            {
                int i = 0;
                Console.Write("Digite o nome do produto:");
                NomeDoProduto[i] = Console.ReadLine();
                Console.Write("Digite o preço do produto:");
                PrecoDoProduto[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o número de série do produto:");
                NumeroDeSerieDoProduto[i] = Console.ReadLine();
                Console.Write("Digite a data de fabricação do produto:");
                DatadeFabricacaoDoProduto[i] = Console.ReadLine();
                Console.Write("Digite o fabricante do produto:");
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
            for (int j = 0; j < QuantidadeDeProdutos; j++)
            {
                Console.WriteLine("Indice: "+j+" | Nome: " + NomeDoProduto[j] + " | Número de Série:" + NumeroDeSerieDoProduto[j] + " | Fabricante: " + FabricanteDoProduto[j] + "|");
            }

            do
            {
                Console.WriteLine("Deseja alterar algum item (S || N) ?");
                teste = Convert.ToChar(Console.ReadLine().ToUpper());
                if (teste != 'S' && teste != 'N')
                {
                    Console.WriteLine("Digite APenas S ou N");
                }
            } while (teste != 'S' && teste != 'N');


            while (teste == 'S')
            {
                Console.Write("Digite o indice do item q deseja alterar:  ");
                indice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o novo nome do produto:");
                NomeDoProduto[indice] = Console.ReadLine();
                Console.Write("Digite o novo preço do produto:");
                PrecoDoProduto[indice] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o novo número de série do produto:");
                NumeroDeSerieDoProduto[indice] = Console.ReadLine();
                Console.Write("Digite a nova data de fabricação do produto:");
                DatadeFabricacaoDoProduto[indice] = Console.ReadLine();
                Console.Write("Digite o novo fabricante do produto:");
                FabricanteDoProduto[indice] = Console.ReadLine();
            }

            do
            {
                Console.WriteLine("Deseja remover algum item ?");
                teste = Convert.ToChar(Console.ReadLine().ToUpper());
                if (teste != 'S' && teste != 'N')
                {
                    Console.WriteLine("Digite APenas S ou N");
                }
            } while (teste != 'S' && teste != 'N');

            if(teste == 'S')
            {
                Console.Write("digite o indice do item que deseja remover: ");
                indice = Convert.ToInt32(Console.ReadLine());
                int j = 0;
                for (int i = 0; i < QuantidadeDeProdutos;i++)
                {
                    if(i != indice)
                    {
                        j++;
                        NovoNomeDoProduto[j] = NomeDoProduto[i];
                        NovoPrecoDoProduto[j] = PrecoDoProduto[i];
                        NovoNumeroDeSerieDoProduto[j] = NumeroDeSerieDoProduto[i];
                        NovoDatadeFabricacaoDoProduto[j] = DatadeFabricacaoDoProduto[i];
                        NovoFabricanteDoProduto[j] = FabricanteDoProduto[i];
                    }
                }
            }

            //Controle de Chamados
            int QuantidadeDeChamadas = 0;

            string[] NomeDaChamada = new string[1000];
            double[] DescricaoDaChamada = new double[1000];
            string[] NomeDoEquipamento = new string[1000];
            string[] DataDeAberturaDoChamado = new string[1000];

            do
            {
                int i = 0;
                Console.Write("Digite o nome da chamada:");
                NomeDaChamada[i] = Console.ReadLine();
                Console.Write("Digite a descrição da chamada:");
                DescricaoDaChamada[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o nome do equipamento:");
                NomeDoEquipamento[i] = Console.ReadLine();
                Console.Write("Digite a data de abertura da chamada:");
                DataDeAberturaDoChamado[i] = Console.ReadLine();

                do
                {
                    Console.WriteLine("Deseja inserir mais um valor (S || N) ?");
                    teste = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (teste != 'S' && teste != 'N')
                    {
                        Console.WriteLine("Digite APenas S ou N");
                    }
                } while (teste != 'S' && teste != 'N');
                QuantidadeDeChamadas = QuantidadeDeChamadas + 1;
                i = i + 1;
            } while (teste == 'S');



        }
    }
}
