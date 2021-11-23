using System;

namespace HashAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose option\n1.find frequency of word\n2.Create Binary Tree\n3.exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
                        hash.Add("1", "to");
                        hash.Add("2", "be");
                        hash.Add("3", "or");
                        hash.Add("4", "not");
                        hash.Add("5", "to");
                        hash.Add("6", "be");
                        string hash3 = hash.Get("3");
                        Console.WriteLine("value of 5th index is: {0}", hash3);
                        hash.Remove("4"); // It will remove the 4th index value.
                        break;
                    case 2:
                        BinarySearchTree binary = new BinarySearchTree();
                        binary.Insert(56);
                        binary.Insert(30);
                        binary.Insert(70);
                        binary.Insert(40);
                        binary.Insert(20);
                        binary.Pre_order(binary.root);
                        binary.Post_order(binary.root);
                        binary.In_order(binary.root);
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your option should be between 1 to 3");
                        break;
                }
            }
        }
    }
}
