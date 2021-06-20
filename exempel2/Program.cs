using System;

namespace exempel2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (true)
            {
                Console.WriteLine("Välkommen, tryck 0 för att avsluta");
                switch (Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine("Tack och ha en bra dag!");
                        done = true;
                        break;
                    case "1":
                        Console.WriteLine("Hur många är intresserade av bio");
                        int n = int.Parse( Console.ReadLine());
                        int sum = 0;
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Besökarens ålder?");
                            int iage = int.Parse(Console.ReadLine());
                            if (iage < 20)
                            {
                                Console.WriteLine("Ungdomspris 80kr");
                                sum += 80;
                            }
                            else
                            {
                                if (iage > 64)
                                {
                                    Console.WriteLine("Pensionärspris 90kr");
                                    sum += 90;
                                }
                                else
                                {
                                    Console.WriteLine("Normalpris 100kr");
                                    sum += 100;
                                }
                            }
                        }
                        string s = sum.ToString();
                        Console.WriteLine("Antal besökare: "+n.ToString()+" Totalt biljettpris´: " + s + "kr");
                        Console.WriteLine("Hoppas ni gillar filmen!");
                        break;
                    case "2":
                        Console.Write("V g skriv en text:");
                        string s1 = Console.ReadLine();
                        for (int i=0;i<10;i++)
                        {
                            Console.Write(s1);
                        }
                        Console.WriteLine("");
                         break;
                    case "3":
                        Console.WriteLine("V g skriv en text med minst 3st ord");
                        s1 = Console.ReadLine();
                        string[] ord = s1.Split(' ');
                        Console.WriteLine("Ditt tredje ord är " + ord[2]);
                        break;
                    default:
                        Console.WriteLine("Okänt val, v g försök igen." );
                        break;
                }
                if (done) break;
            }
        }
    }
}
