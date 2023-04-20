namespace hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "hello world!";
            {
                foreach (char c in message)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(c);
                    Console.ResetColor();

                    System.Threading.Thread.Sleep(100);
                }
            }

        }
    }
}