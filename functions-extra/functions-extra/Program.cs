namespace functions_extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program main = new Program();
            Console.WriteLine("Hello, World!");
            main.IntFunction(9);
            main.StrFunction("Hello World, but with a function");
        }
        void IntFunction(int numb)
        {
            Console.WriteLine(numb);
        }
        void StrFunction(string str)
        {
            Console.WriteLine(str);
        }
    }
}