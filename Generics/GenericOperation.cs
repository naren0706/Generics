namespace Generics
{
    internal class GenericOperation<T> where T : IComparable
    {
        public void FindMax(T a, T b, T c)
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
                Console.WriteLine(a + " is Maximum Value");
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
                Console.WriteLine(b + " is Maximum Value");
            if (c.CompareTo(a) >= 0 && c.CompareTo(b) >= 0)
                Console.WriteLine(c + " is Maximum Value");
        }        
    }
}