using System;
using System.Collections.Generic;
using System.Text;

namespace Avot_U_Vanim
{
    class Tools
    {
        public static void Title()
        {
            Console.WriteLine(" ###########################################");
            Console.WriteLine(" #                                         #");
            Console.WriteLine(" #    WELCOM  TO  AVOT & BANIM  LOTTARY    #");
            Console.WriteLine(" #                                         #");
            Console.WriteLine(" ###########################################");
        }
        public static void Menu()
        {
            Console.WriteLine("  ------------------MENU--------------------");
            Console.WriteLine(" |    l     |    i    |     s     |    e    |");
            Console.WriteLine(" |----------|---------|-----------|---------|");
            Console.WriteLine(" | LIST of  | INSERT  |   START   |   EXIT  |");
            Console.WriteLine(" | ALL KIDS | NEW KID |  LOTTARY  |         |");
            Console.WriteLine(" |----------|---------|-----------|---------|");
        }
        public static void Clear40LinesBelow()
        {
            Console.SetCursorPosition(0, 12);
            for (int i = 0; i < 40; i++) // clear 40 lines below curser
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); //clear full one line
            }
            Console.SetCursorPosition(0, 13);
        }
        public static void SmallMenu()
        {
            Console.WriteLine("\n ------------------------");
            Console.Write(" SELECT (l / i / s / e) : ");
        }
    }
}
