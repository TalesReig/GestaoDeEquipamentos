using System;

namespace GestãoDeEquipamentos
{
    internal class Program
    {

        //      -------------------- Equipametos ------------------------------

        static char teste, opcao;
        static int QuantidadeDeProdutos = 0, indice, posicao1 = 0;

        static string[] NomeDoProduto = new string[1000];
        static double[] PrecoDoProduto = new double[1000];
        static string[] NumeroDeSerieDoProduto = new string[1000];
        static string[] DatadeFabricacaoDoProduto = new string[1000];
        static string[] FabricanteDoProduto = new string[1000];

        //      -------------------- Chamados ---------------------------------
        
        static int posicao2 = 0;
        static int QuantidadeDeChamadas = 0;

        static string[] NomeDaChamada = new string[1000];
        static double[] DescricaoDaChamada = new double[1000];
        static string[] NomeDoEquipamento = new string[1000];
        static string[] DataDeAberturaDoChamado = new string[1000];

        static void Main(string[] args)
        {
            Console.WriteLine("Controle de Manutenção e Equipamentos 1.0");
            Console.WriteLine();
            do
            {
                Console.Clear();
                Console.WriteLine("Controle de Manutenção e Equipamentos 1.0");
                Console.WriteLine();
                Console.WriteLine("Digite 1 para acessar o menu dos Equipamentos: ");
                Console.WriteLine("Digite 2 para acessar o menu das Chamadas: ");
                Console.WriteLine("Digite 3 para SAIR: ");
                opcao = Convert.ToChar(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        MenuEquipamentos();
                        break;
                    case '2':
                        MenuChamada();
                        break;
                }

            } while (opcao != '3');

            do
            {
                Console.Write("Digite o indice do item q deseja alterar:  ");
                indice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o novo nome do produto:");
                NomeDoProduto[indice] = null;
                Console.Write("Digite o novo preço do produto:");
                PrecoDoProduto[indice] = 0;
                Console.Write("Digite o novo número de série do produto:");
                NumeroDeSerieDoProduto[indice] = null;
                Console.Write("Digite a nova data de fabricação do produto:");
                DatadeFabricacaoDoProduto[indice] = null;
                Console.Write("Digite o novo fabricante do produto:");
                FabricanteDoProduto[indice] = null;

                do
                {
                    Console.WriteLine("Deseja excluir mais algum item ?");
                    teste = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (teste != 'S' && teste != 'N')
                    {
                        Console.WriteLine("Digite APenas S ou N");
                    }
                } while (teste != 'S' && teste != 'N');

            } while (teste == 'S');
            //      ------------------------------------------------------------------------------
        }

        private static void MenuChamada()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Controle de Manutenção e Equipamentos 1.0");
                Console.WriteLine();
                Console.WriteLine("Digite 1 para inserir Chamados: ");
                Console.WriteLine("Digite 2 para Visualizar Chamados: ");
                Console.WriteLine("Digite 3 para editar Equipamentos: ");
                Console.WriteLine("Digite 4 para excluir Equipamentos: ");
                Console.WriteLine("Digite 5 para fechar o sistema: ");
                opcao = Convert.ToChar(Console.ReadLine());
                switch (opcao)
                {
                    case '1':
                        InsetirChamado();
                        break;
                    case '2':
                        VisualizarChamados();
                        break;
                    case '3':
                        EditarEquipamento();
                        break;
                    case '4':
                        //ExcluirEquipamento()
                        break;
                    case '5':
                        teste = 'n';
                        break;
                }
            } while (teste == 'n');
        }

        private static void MenuEquipamentos()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Controle de Manutenção e Equipamentos 1.0");
                Console.WriteLine();
                Console.WriteLine("Digite 1 para inserir Equipamentos: ");
                Console.WriteLine("Digite 2 para Visualizar Equipamentos: ");
                Console.WriteLine("Digite 3 para editar Equipamentos: ");
                Console.WriteLine("Digite 4 para excluir Equipamentos: ");
                Console.WriteLine("Digite 5 para fechar o sistema: ");
                opcao = Convert.ToChar(Console.ReadLine());
                switch (opcao)
                {
                    case '1':
                        InserirEquipamento();
                        break;
                    case '2':
                        VisualizarEquipamentos();
                        break;
                    case '3':
                        EditarEquipamento();
                        break;
                    case '4':
                        ExcluirEquipamento();
                        break;
                    case '5':
                        teste = 'n';
                        break;
                }
            } while (teste == 's');
        }

        private static void VisualizarChamados()
        {
            for (int j = 0; j < QuantidadeDeProdutos; j++)
            {
                if (NomeDaChamada[j] != null)
                {
                    Console.WriteLine("Indice: " + j + " | Título: " + NomeDaChamada[j] + " | Descrição: " + DescricaoDaChamada[j] + " | Data de abertura: " + DataDeAberturaDoChamado[j] + "| Equipamento: " + NomeDoProduto[j] + " |");
                }
            }
        }

        private static void InsetirChamado()
        {
            do
            {
                Console.Write("Digite o nome da chamada:");
                NomeDaChamada[posicao2] = Console.ReadLine();
                Console.Write("Digite a descrição da chamada:");
                DescricaoDaChamada[posicao2] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o indice do equipamento oo qual a chamada se refere:");
                NomeDoEquipamento[posicao2] = Console.ReadLine();
                Console.Write("Digite a data de abertura da chamada:");
                DataDeAberturaDoChamado[posicao2] = Console.ReadLine();

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
                posicao1 = posicao1 + 1;
            } while (teste == 'S');
        }

        private static void InserirEquipamento()
        {
            do
            {
                Console.Write("Digite o nome do produto:");
                NomeDoProduto[posicao2] = Console.ReadLine();
                Console.Write("Digite o preço do produto:");
                PrecoDoProduto[posicao2] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o número de série do produto:");
                NumeroDeSerieDoProduto[posicao2] = Console.ReadLine();
                Console.Write("Digite a data de fabricação do produto:");
                DatadeFabricacaoDoProduto[posicao2] = Console.ReadLine();
                Console.Write("Digite o fabricante do produto:");
                FabricanteDoProduto[posicao2] = Console.ReadLine();
                posicao1 = posicao1 + 1;

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

            } while (teste == 'S');
        }

        private static void EditarEquipamento()
        {
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

                do
                {
                    Console.WriteLine("Deseja editar mais algum item ?");
                    teste = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (teste != 'S' && teste != 'N')
                    {
                        Console.WriteLine("Digite APenas S ou N");
                    }
                } while (teste != 'S' && teste != 'N');
            }
        }

        private static void ExcluirEquipamento()
        {
            do
            {
                Console.Write("Digite o indice do item q deseja alterar:  ");
                indice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o novo nome do produto:");
                NomeDoProduto[indice] = null;
                Console.Write("Digite o novo preço do produto:");
                PrecoDoProduto[indice] = 0;
                Console.Write("Digite o novo número de série do produto:");
                NumeroDeSerieDoProduto[indice] = null;
                Console.Write("Digite a nova data de fabricação do produto:");
                DatadeFabricacaoDoProduto[indice] = null;
                Console.Write("Digite o novo fabricante do produto:");
                FabricanteDoProduto[indice] = null;

                do
                {
                    Console.WriteLine("Deseja excluir mais algum item ?");
                    teste = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (teste != 'S' && teste != 'N')
                    {
                        Console.WriteLine("Digite APenas S ou N");
                    }
                } while (teste != 'S' && teste != 'N');

            } while (teste == 'S');
        }

        private static void VisualizarEquipamentos()
        {
            for (int j = 0; j < QuantidadeDeProdutos; j++)
            {
                Console.WriteLine("Indice: " + j + " | Nome: " + NomeDoProduto[j] + " | Número de Série:" + NumeroDeSerieDoProduto[j] + " | Fabricante: " + FabricanteDoProduto[j] + "|");
            }
        }

    }
}
