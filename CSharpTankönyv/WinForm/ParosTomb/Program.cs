using System;

namespace ParosTomb
{
    class Program
    {
        static void Main(string[] args)
        {
            ParosTomb parosTomb = new ParosTomb(3);

            for (int i = 0; i < parosTomb.Length; i++)
            {
                try
                {
                    Console.Write($"Kérlek adj be egy számot, a tömb feltöltéséhez ({i+1}/{parosTomb.Length}): ");
                    int szam = Convert.ToInt32(Console.ReadLine());
                    parosTomb[i] = szam; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nem megfelelő érték!");
                    i--;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }

            }

            Console.WriteLine(parosTomb.ToString());

            Console.ReadKey();
        }
    }
}
