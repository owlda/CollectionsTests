using System;
using System.Collections.Generic;
using System.Collections;
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

            List<string> bookAuthor = new List<string>();
            List<string> bookName = new List<string>();
            ArrayList datesRegister = new ArrayList();



            //-------------------- Execute----------------------------------------
            catalog.Add("Yves Ligter", "Cours preparation A+");
            bookAuthor.Insert(0, "Jerome Hugon");
            bookAuthor.Insert(1, "Paola Zannele");
            bookAuthor.Insert(2, "Yves Ligter");
            
            ShowCatalog();
            Console.WriteLine(String.Empty);
            ShowAuthors();

            //---------------------Methodes--------------------------------------
            void ShowCatalog()
            {
                foreach (KeyValuePair<string, string> pair in catalog)
                {
                    Console.WriteLine($" author: {pair.Key} , name of book: {pair.Value}");
                }
             
            }

            void ShowAuthors()
            {
                foreach (string a in bookAuthor)
                {
                    Console.WriteLine($"{a}");
                }
            }
            Console.ReadKey();

            



        }
      
            
            

    }    
}
