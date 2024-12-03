namespace GuessNumberApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max = 99;
            Random rng = new Random();
            int SN = rng.Next(max + 1);
            Console.WriteLine("({0},{1})?", min, max);

            while (true)
            {
                int guess = int.Parse(Console.ReadLine());
                if (guess < min || guess > max)
                {
                    Console.WriteLine("Out of range.Try again");
                    Console.WriteLine("({0},{1})?", min, max);
                    continue;
                }
                if (guess == SN)
                {
                    Console.WriteLine("Bingo!");
                    break;
                }
                else if (guess < SN)
                {
                    min = guess + 1;
                    Console.WriteLine("({0},{1})?", min, max);
                }
                else if (guess > SN)
                {
                    max = guess - 1;
                    Console.WriteLine("({0},{1})?", min, max);
                }
                if (min >= max)
                {
                    Console.WriteLine("GG,SN={0}", SN);
                }
            }
        }
    }
}
