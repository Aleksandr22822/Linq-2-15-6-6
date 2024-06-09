namespace Task_15_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var a = Console.ReadLine().ToUpper().ToArray();

            char[] b = new char[7] { ' ', '!', '?', '.', ',', ':', ';'};
            var c = a.Except(b);
            foreach (var s in c)
            {
            Console.WriteLine(s);
            }
        }
    }
}
