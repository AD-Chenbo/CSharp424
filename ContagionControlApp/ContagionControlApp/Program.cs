namespace ContagionControlApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of citizens:");
            int N = int.Parse(Console.ReadLine());
            String Id = "Id";
            String Contactee = "Contactee";
            int[]citizens=new int[N];
            Console.Write("{0,10}",Id);
            for (int i = 0; i < N; i++) 
            {
                citizens[i] = i;
                Console.Write("{0,5}",i);
            }
            Console.WriteLine();
            Console.Write("{0,10}", Contactee);
            Random rng = new Random();
            for (int i = 0; i < N; i++)
            {
                int j = rng.Next(i, N);
                int tmp = citizens[i]; citizens[i] = citizens[j]; citizens[j] = tmp;
            }
            foreach (int x in citizens)
            {
                Console.Write("{0,5}", x);
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter Id of infected citizen:");
            int currentInfected = int.Parse(Console.ReadLine());
            bool[]infected = new bool[N];
            infected[currentInfected]=true;

            int[]infectionChain = new int[N];
            int infectionIndex = 0;
            infectionChain[infectionIndex++] = currentInfected;

            for (int i = 0; i < N && infectionIndex < N; i++)
            {
                int nextInfected = citizens[currentInfected];
                if (!infected[nextInfected])
                {
                    infected[nextInfected] = true;
                    infectionChain[infectionIndex++] = nextInfected;
                }
                currentInfected = nextInfected;
            }
            Console.WriteLine("These citizens are to be self-isolated in the following 14 days:");
            for (int i = 0;i < infectionIndex;i++)
            {
                Console.Write("{0,3}",infectionChain[i]);
            }
        }
    }
}
