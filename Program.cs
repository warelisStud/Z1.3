namespace Z1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paczka[] paczki = {new ("ekonomiczna", 4, 5, 6),
                               new("priorytetowa", 1, 3, 3),
                               new("ekonomiczna", 5, 5, 5)};
            foreach (Paczka p in paczki)
            {
                Console.WriteLine(p.ToString());
            }
            
            Console.WriteLine(Paczka.MaxObj(paczki));
            
        }
    }
}
