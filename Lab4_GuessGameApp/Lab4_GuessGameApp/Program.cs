namespace Lab4_GuessGameApp
{
    interface Strategy
    {
        int Next (int low, int high);
    }

    abstract class Player:Strategy
    {
        public abstract int Next(int low, int high);
    }

    class HumanPlayer: Player
    {
        public override int Next(int low, int high)
        {
            return int.Parse(Console.ReadLine());
        }
    }

    class RandomGuess : Player
    {
        public override int Next(int low, int high)
        {
            return new Random().Next(low, high+1);
        }
    }
    class BinarySearch : Player
    {
        public override int Next(int low, int high)
        {
            return (low + high)/2;
        }
    }

    class Game
    {
        private int low, high;
        private int s;
        private Player player;
        

        public Game(Player player)
        {
            this.low = 0;
            this.high = 99;
            this.s = new Random().Next(100);
            this.player = player;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("({0},{1})?", low, high);
                int g = player.Next(low, high);
                Console.WriteLine(g);

                if (g < low || g > high)
                {
                    Console.WriteLine("Out of range.Try again?");
                    continue;
                }
                if (g == s)
                {
                    Console.WriteLine("Bingo!");
                    break;
                }
                else if (g < s)
                {
                    low = g + 1;
                }
                else
                {
                    high = g - 1;
                }
                if (high == low)
                {
                    Console.WriteLine("GG,SN={0}", s);
                    break;
                }
            }
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            new Game(new RandomGuess()).Run();
        }
    }
}
