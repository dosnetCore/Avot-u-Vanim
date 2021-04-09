using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Avot_U_Vanim
{
    class AddKidToList
    {
        public static void AddKid()
        {
            Console.WriteLine("\nADD NEW KID TO LIST:\n");
            Console.WriteLine("--------------------");
            Console.CursorVisible = true;
            Console.Write("ENTER NEW KID'S NAME: ");
            string kid = Console.ReadLine();
            int largestKey = DictionaryOfAllKids.DictOfAllKids.Keys.Max();
            DictionaryOfAllKids.DictOfAllKids.Add(largestKey+1, kid);
            DictionaryOfAllKids.numberOfAllKids = DictionaryOfAllKids.DictOfAllKids.Count;
            Console.WriteLine($"\n{largestKey + 1} - {kid}  <--  has been added to the list.");
        }
    }
}
