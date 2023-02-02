namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random = new Random();
        public string RandomString()
        {
            int n = random.Next(0, this.Count);
            return this[n];
        }

        public string RemoveRandomElement()
        {
            int n = random.Next(0, this.Count);
            string s = this[n];
            this.RemoveAt(n);
            return s;
        }
    }

    public class Program
    {
        static void Main2()
        {
            RandomList rl = new RandomList();
            for ( int i = 0; i < 26; i++ )
            {
                rl.Add(Convert.ToChar( i + 65 ).ToString());
            }
            Console.WriteLine( "Press any key to continue." );
            Console.ReadKey();
            Console.WriteLine("List before remove");
            PrintList(rl);

            Console.Write("\nRandom string: ");
            Console.WriteLine(rl.RandomString());
            
            Console.Write("\nRemove string: ");
            Console.WriteLine(rl.RemoveRandomElement());
            
            Console.WriteLine("List after remove: ");
            PrintList(rl);
        }

        public static void PrintList(RandomList rl)
        {
            foreach (var n in rl)
            {
                Console.Write(n + " ");
            }  
        }
    }
}