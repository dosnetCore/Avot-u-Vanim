using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avot_U_Vanim
{
    class DictionaryOfAllKids
    {
        public static IDictionary<int, string> DictOfAllKids = new Dictionary<int, string>()
        {
            {1, "Malachi" },
            {2, "Hillel" },
            {3, "Naftali" },
            {4, "Imanuel" },
            {5, "Moishi" },
            {6, "Yossi" },
            {7, "Avrumi" },
            {8, "David" },
            {9, "Izchak" },
            {10,"Yanki" },
            {11,"Shlomi" },
            {12,"Elyahu" },
            {13,"Refoel" },
            {14,"Michael" },
            {15,"Asher" },
            {16,"Shmaya" },
            {17,"Shimon" },
            {18,"Reuven" },
            {19,"Leyvi" },
            {20,"Bini" },
            {21,"Yhuda" }
        };
        public static int numberOfAllKids = DictOfAllKids.Count;
        public static void ShowDictOfAllKids()
        {
            string space = "          ";
            Console.WriteLine($"LIST OF ALL THE KIDS: "); 
            foreach (var item in DictOfAllKids)
            {
                
                Console.WriteLine($"{space}{item.Key} - {item.Value}");
            }

            Console.WriteLine($"Number of all Kids in list: {numberOfAllKids}");
            //Console.WriteLine("largest key: "+DictOfAllKids.Keys.Max()); //just for debugging not for UI
        }
    }
}
