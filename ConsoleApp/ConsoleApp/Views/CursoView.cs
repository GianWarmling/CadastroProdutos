using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Views
{
    internal class CursoView
    {
        public void Executa()
        {
            int opcao = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("1. Cadastrar");
                Console.WriteLine("2. Listar Todos");
                Console.WriteLine("3. Listar Por ID");
                Console.WriteLine("4. Alterar");
                Console.WriteLine("5. Deletar");
                Console.WriteLine("6. Sair");

                Console.Write("Escolha uma das opções do Menu: ");

                opcao = Convert.ToInt32(Console.ReadLine());

                EscolheOpcoes(opcao);

            } while (opcao != 6);

        }
        public void EscolheOpcoes(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Cadastrando novo curso:");
                    break;
                case 2:
                    Console.WriteLine("Listando todos os cursos:");
                    break;
                case 3:
                    Console.WriteLine("Listando curso por ID:");
                    break;
                case 4:
                    Console.WriteLine("Alterando curso:");
                    break;
                case 5:
                    Console.WriteLine("Deletando curso:");
                    break;
                case 6:
                    Console.WriteLine("Saindo...");
                    break;
            }
        }
    }
}
