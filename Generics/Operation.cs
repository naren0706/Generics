namespace Generics
{
    internal class Operation
    {
        public void FindMaxInteger(int a, int b, int c)
        {
            if (a > b && a > c)
                Console.WriteLine("a is largest");
            if (b > a && b > c)
                Console.WriteLine("b is largest");
            if (c > a && c > b)
                Console.WriteLine("c is largest");
        }
        public void FindMaxFloat(float a, float b, float c)
        {
            if (a > b && a > c)
                Console.WriteLine("a is largest");
            if (b > a && b > c)
                Console.WriteLine("b is largest");
            if (c > a && c > b)
                Console.WriteLine("c is largest");
        }
        public void FindMaxString(string a, string b, string c)
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
                Console.WriteLine("a is largest");
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
                Console.WriteLine("b is largest");
            if (c.CompareTo(a) >= 0 && c.CompareTo(b) >= 0)
                Console.WriteLine("c is largest");
        }

    }
}