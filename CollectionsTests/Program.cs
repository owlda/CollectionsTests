using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> catalog = new Dictionary<string, string>()
            {
                ["Jerome Hugon"] = "C#7. Developpez des aplications",
                ["Paola Zannele"] = "Architecture et technologie des ordinateurs"
            };


            catalog.Add("Yves Ligter", "Cours preparation A+");
            ShowCatalog();
            void ShowCatalog()
            {
                foreach (KeyValuePair<string, string> pair in catalog)
                {
                    Console.WriteLine($" author: {pair.Key} , name of book: {pair.Value}");
                }
             
            }
            Console.ReadKey();

            



        }
      
            
            

    }    
}
