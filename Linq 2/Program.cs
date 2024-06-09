namespace Linq_2_Task_15_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Москва";
            string b = "Ярославль";

            char[] c = a.Intersect(b).ToArray();
            foreach (char c2 in c) {Console.WriteLine(c2);} 
        }
    }
}
