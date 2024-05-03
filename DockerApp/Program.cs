namespace DockerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            while(i < 1_000)
            {
                Console.WriteLine($"Hello, World! ({i})");

                i++;

                Thread.Sleep(1000);
            }
        }
    }
}
