using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Avot_U_Vanim
{
    class RandomKid
    {
        public static void DrawWinningNumber(int numOfKids) // it is a static method !
        {
            var rnd = new Random();
            int randomStart = rnd.Next(1, numOfKids + 1); // creates a number between 1 and numOfKids
            int winningNumber = randomStart;     /* computer choose number to start looping at (for best randomation)*/
            //Console.WriteLine($"(Random start was: {randomStart})\n"); //only for debugging not for UI
            Console.CursorVisible = false; //hides the cursor

            /* roll numbers */
            Console.WriteLine(" PRESS ANY KEY TO STOP THE WHEEL ");
            while (!Console.KeyAvailable)       /* looping all over the numbers untill user press any key */
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); //clear full one line
                Console.SetCursorPosition(20, 18);
                Console.Write($"{winningNumber}");
                System.Threading.Thread.Sleep(10); //wait ___ ms
                if (winningNumber == numOfKids) { winningNumber = 0; }
                winningNumber++;
            }
            Console.ReadKey(true);//will read a character from the stream without echoing back to the console for the user to see 
            Console.SetCursorPosition(0, 15);
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); //clear full one line
            Console.WriteLine($"      AND THE WINNER IS . . . ");
            int i=0;
            int speed = 4;//40;
            while (i < numOfKids*2)
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); //clear full one line
                Console.SetCursorPosition(20, 18);
                Console.Write($"{winningNumber}");
                System.Threading.Thread.Sleep(speed+=4); //wait ___ ms
                if (winningNumber == numOfKids) { winningNumber = 0; }
                winningNumber++;
                i++;
            }
            Console.Write("\b\b  ");
            Console.Beep(523, 200);           
            Console.Beep(659, 200);
            Console.Beep(784, 200);
            Console.Beep(1046, 1700);
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); //clear full one line
            Console.SetCursorPosition(0, 15);
            Console.WriteLine($"\n         ### THE WINNER IS ###   ");
            Console.Write($"\n            #  {winningNumber} - {DictionaryOfAllKids.DictOfAllKids[winningNumber]}  #\n\n");
            Console.WriteLine($"\t###  M A Z L   T O I V  !  ###       \n\n");
            System.Threading.Thread.Sleep(1000);
            Console.CursorVisible = true;

        }
    }
}
