using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronometro
{
    internal class Program
    {
        // Classe principal, inicia o programa
        static void Main(string[] args)
        {
            Prepara();  
        }

        // Classe responsável pela apresentção 
        static void Prepara()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=- Cronometro Terminal -=-=-=-=-=-=-=-");
            Console.WriteLine("");

            Console.WriteLine("----> Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("----> Apontar!...");
            Thread.Sleep(1000);
            Console.WriteLine("----> Vai!!!...");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------");
            Thread.Sleep(1000);

            Menu();
        }

        // Classe responsavel pelo Menu da aplicação
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=- Cronometro Terminal -=-=-=-=-=-=-=-");
            Console.WriteLine("");

            Console.WriteLine("Esolha a opção de cronometro que deseja:");
            Console.WriteLine("");

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("[Minutos]  -> Digite o Número e no final adicione o (m)");
            Console.WriteLine("[Segundos] -> Digite o número e no final adicione o (s)");
            Console.WriteLine("[Zero-0]   -> Sair do Cronometro");
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("");

            Console.Write("Como você deseja contar?:  ");
            string opcao = Console.ReadLine().ToLower();
            Console.WriteLine("--------------------------------------------------------");

            try
            {
                char tipo = char.Parse(opcao.Substring(opcao.Length - 1, 1));
                int tempo = int.Parse(opcao.Substring(0, opcao.Length - 1));

                int multiplicar = 1;

                if (tipo == 's') {multiplicar = 1;}

                else if (tipo == 'm') {multiplicar = 60;}

                Iniciar(tempo * multiplicar);
            }

            catch (Exception)
            {
                if (opcao == "0") { Sair(); }

                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Opção invalida, Digite uma Opção na Lista Certinha. \nRetornando ao Menu Principal.");
                    Console.WriteLine("");
                    Console.WriteLine("--------- Retornando para o Menu --------");
                    Thread.Sleep(3000);

                    Menu();
                }
            }       
        }

        // Classe responsavel pela contagem do cronometro (Lógica)
        static void Iniciar(int tempo) // Parametro usado "tempo"
        {
            Console.Clear();

            Console.WriteLine("-=-=-=-=-=- Cronometro Ativado -=-=-=-=-=-");
            Console.WriteLine("");

            int MinutoAtual = 0; 

            while (MinutoAtual != tempo) 
            {
                MinutoAtual++;
                Console.WriteLine($"Tic Tac, Tic Tac: {MinutoAtual}");

                Thread.Sleep(1000); 
            }

            Console.WriteLine("------------------------------------------");

            Console.Clear();
            Console.WriteLine("-=-=-=-=-=- Cronometro Finalizado! -=-=-=-=-=-");
            Console.WriteLine("");
            Console.WriteLine("-------------> Voltando ao Menu <-------------");

            Thread.Sleep(2000);

            Menu();
        }

        // Classe responsavel pelo encerramento da aplicação
        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("-=-=-=-=-=- Finalizando Aplicação -=-=-=-=-=-");
            Thread.Sleep(2000);
            System.Environment.Exit(0);
        }
    }
}
