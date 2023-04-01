namespace Vydaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aplikace aplikace = new Aplikace();
            aplikace.Start();
            aplikace.VypisOsoby();
        }
    }
}