using System;

namespace HashAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("1", "to");
            hash.Add("2", "be");
            hash.Add("3", "or");
            hash.Add("4", "not");
            hash.Add("5", "to");
            hash.Add("6", "be");
            string hash3 = hash.Get("3");
            Console.WriteLine("value of 5th index is: {0}",hash3);
            hash.Remove("4"); // It will remove the 4th index value.
        }
    }
}
