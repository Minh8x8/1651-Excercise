namespace ConsoleApp7
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter sides:");
            int side;
            try
            {
                side = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            Dice dice = new Dice();
            dice.Side = side;
            int guessNum;
            do
            {
                Console.WriteLine("Enter the guessing number (0 to stop)");
                guessNum = int.Parse(Console.ReadLine());
                Console.WriteLine($"Your guess: {guessNum}" +
                                  $"\nRolling dice: {dice.Roll()}"); 
            } while (guessNum != 0);
        }
    }
}
