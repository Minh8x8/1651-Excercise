using System.Collections;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty() => this.Count == 0;

        public void AddRange(IEnumerable<string> collection)
        {
            foreach (var element in collection)
            {
                this.Push(element);
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine("Before adding to stack");
            Console.Write("IsEmpty => " + stack.IsEmpty());
            
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            
            Console.WriteLine("Adding alphabetic characters");
            List<string> alphabetic = new List<string>();
            for ( int i = 0; i < 26; i++ )
            {
                alphabetic.Add(Convert.ToChar( i + 65 ).ToString());
            }
            stack.AddRange(alphabetic);
            PrintStack(stack);
        }

        public static void PrintStack(StackOfStrings stack)
        {
            foreach (var element in stack)
            {
                Console.Write(element + " ");
            }
        }
    }
}

