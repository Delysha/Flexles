namespace Arrays_Extra
{
    internal class Program
    {

        int[] nuts = new int[] { 10, 20, 30, 40, 50, 60 };
        static void Main(string[] args)
        {
            Program main = new Program();
            int ArrayTotal = main.ArrayFunction(main.nuts);
            Console.WriteLine(ArrayTotal);
            Console.WriteLine("Hello, World!");
        }
        internal int ArrayFunction(int[] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            return total;
        }
    }

}