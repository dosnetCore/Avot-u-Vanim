using System;
using System.Collections.Generic;
using System.Text;

namespace Avot_U_Vanim
{
    class Start
    {
        public static void WelcomToLottary()
        {
  
            Tools.Title();
            Console.SetCursorPosition(0, 6);
            Tools.Menu();
            Tools.SmallMenu();

            bool loopContinue = true;
            while (loopContinue)
            {
                string phase = Console.ReadLine();

                switch (phase)
                {
                    case "l": // show list of children + their sum
                        Tools.Title();
                        Tools.Menu();
                        Tools.Clear40LinesBelow();                       
                        DictionaryOfAllKids.ShowDictOfAllKids();
                        Tools.SmallMenu();
                        loopContinue = true;
                        break;

                    case "i":
                        Tools.Clear40LinesBelow();
                        AddKidToList.AddKid();
                        Tools.SmallMenu();
                        loopContinue = true;
                        break;

                    case "s":  
                        Tools.Clear40LinesBelow();
                        Console.WriteLine("\tLET'S ROLL THE LOTTARY");
                        Console.WriteLine("\t----------------------");
                        RandomKid.DrawWinningNumber(DictionaryOfAllKids.numberOfAllKids);
                        Tools.SmallMenu();
                        loopContinue = true;
                        break;

                    case "e":
                        Console.Clear();
                        //Tools.Clear40LinesBelow();
                        Console.SetCursorPosition(10, 7);
                        Console.WriteLine("\n\n\n         - GOOD BYE - \n\n\n");
                        System.Threading.Thread.Sleep(3000);
                        loopContinue = false;
                        break;
                        
                    default:
                        int cursorPos = Console.CursorTop;
                        Console.SetCursorPosition(0, cursorPos-1);
                        Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); //clear full one line
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(0, cursorPos - 1);
                        Console.Write("press only l, i, s or e :");
                        Console.ResetColor();
                        loopContinue = true;
                        break;
                }

            }
        }
    }
}
