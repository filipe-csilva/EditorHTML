using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            DrawScreen();
            WriteOptions();
            short option = short.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            if (option != null)
            {
                HandleMenuOption(option);
            }
        }

        public static void DrawScreen()
        {
            LinhaMenu();
            for (int lines = 0; lines <= 20; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 100; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
            LinhaMenu();    
        }

        static void LinhaMenu()
        {
            Console.Write("+");
            for (int i = 0; i <= 100; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=====================================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("0");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void HandleMenuOption(short option)
        {
            switch(option){
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    Viewer.Show();
                    break;
                default:
                    Show();
                    break;
            }
        }
    }
}
