namespace TypedLanguage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int leeftijd = 9;
            bool finished = true;

            float x = 0.1f;
            bool gameName = true;
            Console.WriteLine("Hello, World!");
        }
    }
    internal class GameEngine
    {
        GameEngineState state;
        
        internal bool load (string file)
        {
            return true;
        }
        internal void plus(int x,int y) 
        { 

        }
    }
    internal class GameEngineState
    {
    }
    internal interface IGameEngine
    {
    }

}