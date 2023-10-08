namespace TestChars{
    internal class Program {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the test program ...");
            Console.WriteLine("Enter Brackets :");
            string input = Console.ReadLine();
            char[] bracket = input.ToCharArray();
            FindBrackets findBrackets = new FindBrackets();
            if (findBrackets.IsValidBrackets(bracket))
            {
                System.Console.WriteLine("true");
            }
            else
            {
                System.Console.WriteLine("false");
            }
        }
    }
}