using System;
using DataStructureAlgorithm.AlgorithmPrograms;

namespace DataStructureAlgorithm;
class Program
{
    public static string binaryTextPath = @"D:\GitRepository\Algorithm_Programs\DataStructureAlgorithm\Files\BinarySearch.txt";
    public static void Main(string[] args)
    {
        int[] array = { 5, 1, 8, 7, 2, 4, 6, 9, 3, 10 };
        int[] array2 = { 26, 20, 54, 34, 12, 39, 19, 45 };
        Console.WriteLine("Welcome to the Algorithm Programs");
        bool flag = true;
        while(flag)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1.BinarySearch\n2.InsertionSort\n3.BubbleSort\n4.CheckForAnagram\n5.UpdateMessageAfterUserInput\n6.PrimeNumbersBetweenGivenRange\n7.CheckAnagramAndPalindrome\n8.Exit");
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
                    InsertionSort sort=new InsertionSort();
                    sort.ReadTextFiles(binaryTextPath);
                    sort.Sort();
                    break;
                case 3:
                    BubbleSort bubblesort = new BubbleSort();
                    Console.WriteLine("Before sorting: ");
                    bubblesort.Display(array);
                    bubblesort.Sort(array);
                    break;
                case 4:
                    Anagram check = new Anagram();
                    check.CheckAnagram("heart", "earth");
                    break;
                case 5:
                    MessageDemonstration replace=new MessageDemonstration();
                    replace.ReplaceString();
                    break;
                case 6:
                    PrimeNumbers range = new PrimeNumbers();
                    range.PrimeNumberRange(1, 100);
                    break;
                case 7:
                    PrimeNumbers primePalindrome = new PrimeNumbers();
                    primePalindrome.PrimeNumberRange(100, 500);
                    primePalindrome.CheckAnagramPalindrome();
                    break;
                case 8:
                    flag = false;
                    break;
            }
        }
    }
}
