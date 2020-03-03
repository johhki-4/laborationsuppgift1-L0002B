// Johannes Håkansson
// 931011-5119
// L0002B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L0002B_Lab1_Johannes_Hakansson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sparar priset man ska betala i en variabel.
            Console.Write("Att betala: ");
            string tempPris = Console.ReadLine();

            //Sparar summan man har betalat i en variabel.
            Console.Write("Betalt: ");
            string tempBetalt = Console.ReadLine();

            //Gör om textsträngar till siffror så att de kan användas för beräkningar.
            int pris = int.Parse(tempPris);
            int betalt = int.Parse(tempBetalt);
            int växel = betalt - pris;

            //Om man inte ska få tillbaka någon växel betyder det att man har betalat för lite.
            if (växel < 0)
            {
                Console.WriteLine("Du har betalat för lite pengar, försök igen med en ny transaktion");
                Console.ReadKey();
                return;
            }

            //En array med valörer och en motsvarande array med valörernas namn.
            int[] sedlarOchMynt = { 500, 100, 50, 20, 10, 5, 1 };
            string[] sedlarOchMynt2 = { "femhundralappar", "hundralappar", "femtiolappar", "tjugolappar", "tior", "femmor", "enkronor"};

            //Börja med den högsta valören för att se hur många av denne man ska få tillbaka. man kan sedan ta bort denna summan från totalen och 
            // fortsätta räkna med nästa valör. När man har gjort klar enkronorna är man klar
            Console.WriteLine("Din växel är: ");
            for (int i = 0; i < sedlarOchMynt.Length; i = i + 1) {
                int antal = växel / sedlarOchMynt[i];
                if (antal > 0)
                {
                    Console.WriteLine(antal + " st " + sedlarOchMynt2[i]);
                    växel = växel - (sedlarOchMynt[i] * antal);
                }
                else
                {
                    växel = växel - (sedlarOchMynt[i] * antal);
                }
            }

            Console.ReadKey();
        }
    }
}
