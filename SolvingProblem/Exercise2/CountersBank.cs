
namespace Exercise2
{
    internal class CountersBank
    {
        // Fields
        private bool[] _tabCounters;

        // Properties
        public bool[] TabCounters
        {
            set
            {
                _tabCounters = value;
            }
            get
            {
                return _tabCounters;
            }
        }
        // Constructor 
        public CountersBank(int numberCounters)
        {
            TabCounters = new bool[numberCounters];
            for (int i = 0; i < TabCounters.Length; i++)
            {
                TabCounters[i] = true;
            }
        }
        // Searching for the number of the first libre counter
        public int CounterLibre()
        {
            for (int i = 0; i < TabCounters.Length; i++)
            {
                if (TabCounters[i] == false)
                {
                    continue;
                }
                else
                {
                    return i;
                }
            }
            Console.WriteLine($"None of counters are libre !");
            return -1;
        }

        // Change State of counter bank
        public void ChangeState(int numberCounter)
        {
            for (int i = 0; i < TabCounters.Length; i++)
            {
                if (i == numberCounter)
                {
                    TabCounters[i] = TabCounters[i] ? false : true;
                }
            }
        }

        // Numbers of libres Counters
        public int NumbersCountersLibres()
        {
            int number = 0;
            for (int i = 0; i < TabCounters.Length; i++)
            {
                if (TabCounters[i])
                {
                    number++;
                }
            }
            return number;
        }
        // Display Element Of TabCounters
        public void Display()
        {
            Console.Write($"[");
            foreach (bool item in TabCounters)
            {
                Console.Write($" {item} ");
            }
            Console.Write($"]");
            Console.WriteLine();
        }
    }
}
