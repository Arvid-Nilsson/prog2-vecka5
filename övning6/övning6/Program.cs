using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning6
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Uppgift 1");
            //uppgift 1
            int räknare = 0;
            int mål = 20;

            //budget for loop
            while (räknare < mål) {
                Console.WriteLine("Vi har inte nått målet");
                räknare++;
            }
            Console.WriteLine("Vi har nått målet");

            Console.WriteLine("\nUppgift 2");
            //uppgift 2
            string[] mailList = { "hej@gmail.com", "arvid@gmail.com", "skola@ntig.se" };
            string sökord = "gmail";

            //Kolla om någon/några mailadress innehåller sökordet och isåfall skriver ut den 
            foreach(string mail in mailList) {
                if (mail.Contains(sökord))
                {
                    Console.WriteLine(mail);
                }
                
            }

            Console.WriteLine("\nUppgift 3");
            //uppgift 3
            bool kommerBilar = true;
            Random rnd = new Random();

            while (kommerBilar)
            {
                //slumpar fram antal bilar
                int antalBilar = rnd.Next(10);

                //Kollar om det kommer några bilar
                if( antalBilar == 0 )
                {
                    kommerBilar = false;
                    Console.WriteLine("Du gick över gatan för att det inte kom några bilar");
                }
                else
                {
                    Console.WriteLine($"Du gick inte över gatan på grund av att det komm {antalBilar} bilar");
                }
                
            }
            
        }
    }
}
