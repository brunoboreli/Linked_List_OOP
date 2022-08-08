using System;


namespace Lista_Ligada
{
    class Program
    {
        public static void Main(string[] args)
        {

            int menuInit()
            {
                Console.Clear();
                Console.WriteLine(" === Escolha uma opção: ===");
                Console.WriteLine("[1] - Inserir Inteiro no Início da Lista");
                Console.WriteLine("[2] - Inserir Inteiro no Final da Lista");
                Console.WriteLine("[3] - Remover qualquer Inteiro da Lista");
                Console.WriteLine("[4] - Imprimir Lista");
                Console.WriteLine("[5] - Imprimir Lista - Invertido");
                Console.WriteLine("[6] - Sair");
                int choice = Convert.ToInt32(Console.ReadLine());

                return choice;
            }

            int caso = 0;
            Lista newLista = new Lista();
            while (caso != 6)
            {
                caso = menuInit();
                if (caso == 1)
                {
                    Console.WriteLine("Digite o número a ser inserido:");
                    int insert = Convert.ToInt32(Console.ReadLine());
                    newLista.InsertBegin(insert);
                    //Console.ReadLine();
                }
                else if (caso == 2)
                {
                    Console.WriteLine("Digite o número a ser inserido no final:");
                    int insert = Convert.ToInt32(Console.ReadLine());
                    newLista.InsertEnd(insert);
                }
                else if (caso == 3)
                {
                    Console.WriteLine("Digite o número a ser removido:");
                    int remove = Convert.ToInt32(Console.ReadLine());
                    newLista.ListRemove(remove);
                }
                else if (caso == 4)
                {
                    newLista.printLista();
                    Console.ReadLine();
                }
                else if (caso == 5)
                {
                    newLista.printInvert();
                    Console.ReadLine();
                }
            }            

        }
    }

}



