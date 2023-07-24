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
        
    }
}