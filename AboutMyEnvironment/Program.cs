namespace AboutMyEnvironment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Information about my environment:");
            Console.WriteLine("Environment.CurrentDirectory: " + Environment.CurrentDirectory);
            Console.WriteLine("Environment.OSVersion.VersionString: " + Environment.OSVersion.VersionString);
            Console.WriteLine("Namespace: {0}", typeof(Program).Namespace);
        }
    }
}
