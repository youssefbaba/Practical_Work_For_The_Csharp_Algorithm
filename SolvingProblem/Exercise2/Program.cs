namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountersBank countersBank = new CountersBank(10);
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(0 ,10);
                countersBank.ChangeState(randomNumber);
            }
            countersBank.Display();
            Console.WriteLine($"The first libre counter : {countersBank.CounterLibre()}");
            Console.WriteLine($"Numbers of libres Counters : {countersBank.NumbersCountersLibres()}");
            
        }
    }
}