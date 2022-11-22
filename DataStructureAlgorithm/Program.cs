using System;
namespace DataStructureAlgorithm;
class Program
{
    public static string binaryTextPath = @"D:\GitRepository\Algorithm_Programs\DataStructureAlgorithm\Files\BinarySearch.txt";
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Algorithm Programs");
        bool flag = true;
        while(flag)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1.BinarySearch\n2.Exit");
            Console.Write("Select any one from the above option: ");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    BinarySearch search=new BinarySearch();
                    search.ReadFile(binaryTextPath);
                    search.BinarySearchWord("bridgelabz");
                    break;
                case 2:
                    flag = false;
                    break;
            }
        }
    }
}
