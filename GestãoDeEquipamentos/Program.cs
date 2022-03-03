using System;

namespace GestãoDeEquipamentos
{
    internal class Program
    {

        //      --------------------| Equipametos |------------------------------

        static char teste, opcao;
        static int QuantidadeDeProdutos = 0, indice, posicao1 = 0;

        static string[] NomeDoProduto = new string[1000];
        static double[] PrecoDoProduto = new double[1000];
        static string[] NumeroDeSerieDoProduto = new string[1000];
        static string[] DatadeFabricacaoDoProduto = new string[1000];
        static string[] FabricanteDoProduto = new string[1000];

        //      --------------------| Chamados |---------------------------------
        static int posicao2 = 0;
        static int QuantidadeDeChamadas = 0;

        static string[] NomeDaChamada = new string[1000];
        static string[] DescricaoDaChamada = new string[1000];
        static int[] NomeDoEquipamento = new int[1000];
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
                Console.Write("Resposta:");
                opcao = Convert.ToChar(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        MenuEquipamentos();
                        opcao = 'x';
                        break;
                    case '2':
                        MenuChamada();
                        opcao = 'x';
                        break;
                }

            } while (opcao != '3');

            //      ---------------------------| Final do Main |--------------------------------------

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
                Console.WriteLine("Digite 3 para editar Chamado: ");
                Console.WriteLine("Digite 4 para excluir Equipamentos: ");
                Console.WriteLine("Digite 5 para voltar: ");
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
                        EditarChamada();
                        break;
                    case '4':
                        ExcluirChamada();
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
                Console.WriteLine("Digite 5 para Voltar: ");
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
                        EditarEquipamentos();
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

        private static void InserirEquipamento()
        {

            do
            {
                int tamanho;
                do
                {
                    Console.Write("Digite o nome do produto:");
                    NomeDoProduto[posicao1] = Console.ReadLine();
                    tamanho = NomeDoProduto.Length;
                } while (tamanho < 6);
                do
                {
                    Console.Write("Digite o preço do produto:");
                    PrecoDoProduto[posicao1] = Convert.ToDouble(Console.ReadLine());
                } while (PrecoDoProduto[posicao1] < 0);

                do
                {
                    Console.Write("Digite o número de série do produto:");
                    NumeroDeSerieDoProduto[posicao1] = Console.ReadLine();

                } while (NumeroDeSerieDoProduto[posicao1] != null);

                do
                {
                    Console.Write("Digite a data de fabricação do produto:");
                    DatadeFabricacaoDoProduto[posicao1] = Console.ReadLine();
                }while(DatadeFabricacaoDoProduto != null);
                do
                {
                    Console.Write("Digite o fabricante do produto:");
                    FabricanteDoProduto[posicao1] = Console.ReadLine();
                } while (FabricanteDoProduto[posicao1] != null);
                
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

        private static void EditarEquipamentos()
        {
            do
            {
                Console.Write("Digite o indice do chamado que deseja editar:");
                indice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o nome do produto:");
                NomeDoProduto[indice] = Console.ReadLine();

                Console.Write("Digite o preço do produto:");
                PrecoDoProduto[indice] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o número de série do produto:");
                NumeroDeSerieDoProduto[indice] = Console.ReadLine();

                Console.Write("Digite a data de fabricação do produto:");
                DatadeFabricacaoDoProduto[indice] = Console.ReadLine();

                Console.Write("Digite o fabricante do produto:");
                FabricanteDoProduto[indice] = Console.ReadLine();

                do
                {
                    Console.WriteLine("Deseja inserir mais um valor (S || N) ?");
                    teste = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (teste != 'S' && teste != 'N')
                    {
                        Console.WriteLine("Digite APenas S ou N");
                    }
                } while (teste != 'S' && teste != 'N');
            } while (teste == 'S');
        }

        private static void ExcluirEquipamento()
        {
            do
            {
                Console.Write("Digite o indice do item q deseja alterar:  ");
                indice = Convert.ToInt32(Console.ReadLine());

                NomeDoProduto[indice] = null;
                PrecoDoProduto[indice] = 0;
                NumeroDeSerieDoProduto[indice] = null;
                DatadeFabricacaoDoProduto[indice] = null;
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
            for (int j = 0; j <= QuantidadeDeProdutos; j++)
            {
                if (NomeDaChamada != null)
                {
                    Console.WriteLine("Indice: " + j + " | Nome: " + NomeDoProduto[j] + " | Número de Série:" + NumeroDeSerieDoProduto[j] + " | Fabricante: " + FabricanteDoProduto[j] + "|");
                    Console.ReadLine();
                }
            }
        }

        private static void VisualizarChamados()
        {

            for (int j = 0; j < QuantidadeDeChamadas; j++)
            {
                DateTime dataAbertura = Convert.ToDateTime(DataDeAberturaDoChamado[j]);
                TimeSpan diferenca = DateTime.Today - dataAbertura;
                double dias = diferenca.TotalDays;

                if (NomeDaChamada[j] != null)
                {
                    Console.WriteLine("Indice: " + j + " | Título: " + NomeDaChamada[j] + " | Descrição: " + DescricaoDaChamada[j] + " | Data de abertura: " + DataDeAberturaDoChamado[j] + "| Dias em aberto: " + dias + " |");
                    Console.ReadLine();
                }
            }
        }

        private static void InsetirChamado()
        {
            do
            {
                do
                {
                    Console.Write("Digite o nome da chamada:");
                    NomeDaChamada[posicao1] = Console.ReadLine();
                } while (NomeDaChamada[posicao1] != null);

                Console.Write("Digite a descrição da chamada:");
                DescricaoDaChamada[posicao1] = Console.ReadLine();

                do
                {
                    Console.Write("Digite o indice do equipamento ao qual a chamada se refere:");
                    NomeDoEquipamento[posicao1] = Convert.ToInt32(Console.ReadLine());
                } while (true);
                Console.Write("Digite o indice do equipamento ao qual a chamada se refere:");
                NomeDoEquipamento[posicao1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a data de abertura da chamada:");
                DataDeAberturaDoChamado[posicao1] = Console.ReadLine();
                QuantidadeDeChamadas = QuantidadeDeChamadas + 1;

                do
                {
                    Console.WriteLine("Deseja inserir mais um valor (S || N) ?");
                    teste = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (teste != 'S' && teste != 'N')
                    {
                        Console.WriteLine("Digite APenas S ou N");
                    }
                } while (teste != 'S' && teste != 'N');
                posicao1 = posicao1 + 1;
            } while (teste == 'S');
        }

        private static void EditarChamada()
        {
            do
            {
                Console.Write("Digite o indice do chamado que deseja editar:");
                indice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o nome da chamada:");
                NomeDaChamada[indice] = Console.ReadLine();
                Console.Write("Digite a descrição da chamada:");
                DescricaoDaChamada[indice] = Console.ReadLine();
                Console.Write("Digite o indice do equipamento ao qual a chamada se refere:");
                NomeDoEquipamento[indice] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a data de abertura da chamada:");
                DataDeAberturaDoChamado[indice] = Console.ReadLine();

                do
                {
                    Console.WriteLine("Deseja inserir mais um valor (S || N) ?");
                    teste = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (teste != 'S' && teste != 'N')
                    {
                        Console.WriteLine("Digite APenas S ou N");
                    }
                } while (teste != 'S' && teste != 'N');
            } while (teste == 'S');
        }

        private static void ExcluirChamada()
        {
            do
            {
                Console.Write("Digite o indice do item q deseja alterar:  ");
                indice = Convert.ToInt32(Console.ReadLine());

                NomeDaChamada[posicao1] = null;
                DescricaoDaChamada[posicao1] = null;
                NomeDoEquipamento[posicao1] = 0;
                DataDeAberturaDoChamado[posicao1] = null;

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

    }
}
