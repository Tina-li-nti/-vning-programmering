using System;

namespace metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;

            string svar;

            string Test1Svar;

            string Test2Svar;

            Console.WriteLine("Vem är du?");

            name = Console.ReadLine();

            Console.WriteLine("Hejsan " + name + " välkommen till test simuleringen.");
            Console.WriteLine("Är du redo?, svara ja eller nej.");
            svar = Console.ReadLine();


            if (svar == "ja")
            {
                Console.WriteLine("Bra då börjar vi");
            }
            else
            {
                Console.WriteLine("Ok, Hejdå.");
                System.Threading.Thread.Sleep(2000);
                return;
            }

            Test1();
            Console.WriteLine();

            Test1Svar = Console.ReadLine();

            if (Test1Svar == "18")
            {
                Console.WriteLine("Bra jobbat, du kan basic matte från årskurs 1 :)");
                Console.WriteLine("Vänligen vänta, nästa test börjar snart....");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Vilken är Österrikets huvudstad? (svara utan stor bokstav)");
                Test2Svar = Console.ReadLine();

                if (Test2Svar == "wien")
                {
                    Console.WriteLine("Nu när vi har testat din grundläggande intelligens");
                    Console.WriteLine("Förflyttar testsubjekt " + name + " till labratoriet...");
                    System.Threading.Thread.Sleep(5000);
                    return;
                }
                else
                {
                    Console.WriteLine("Nej, det kan inte vara rätt.");
                    System.Threading.Thread.Sleep(1000);
                }

            }
            else
            {
                Console.WriteLine("Du är nog inte så smart, du är fri att gå. Hejdå.");
                System.Threading.Thread.Sleep(1500);
            }

        }

        static void Test1()
        {
            Console.WriteLine("Vad är 3 x 6?");

        }

    }
}
