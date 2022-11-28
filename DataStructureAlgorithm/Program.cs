using System;
using DataStructureAlgorithm.AlgorithmPrograms;
using DataStructureAlgorithm.DataStructurePrograms;

namespace DataStructureAlgorithm;
class Program
{
    public static string binaryTextPath = @"D:\GitRepository\Algorithm_Programs\DataStructureAlgorithm\Files\BinarySearch.txt";
    public static string numberTextPath = @"D:\GitRepository\Algorithm_Programs\DataStructureAlgorithm\Files\NumberFile.txt";
    public static string paranthesisTextPath = @"D:\GitRepository\Algorithm_Programs\DataStructureAlgorithm\Files\BalancedParanthesis.txt";
    public static string bankingTextPath = @"D:\GitRepository\Algorithm_Programs\DataStructureAlgorithm\Files\PersonsInATM.txt";
    public static void Main(string[] args)
    {
        int[] array = { 5, 1, 8, 7, 2, 4, 6, 9, 3, 10 };
        int[] array2 = { 26, 20, 54, 34, 12, 39, 19, 45 };
        Console.WriteLine("Welcome to the Algorithm Programs");
        bool flag = true;
        while(flag)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1.BinarySearch\n2.InsertionSort\n3.BubbleSort\n4.MergeSort\n5.CheckForAnagram\n6.UpdateMessageAfterUserInput\n7.PrimeNumbersBetweenGivenRange\n8.CheckAnagramAndPalindrome\n9.UnOrdered List\n10.Ordered List\n11.Balanced Paranthesis\n12.BankingCashCounter\n13.Exit");
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
                    MergeSort mergeSort = new MergeSort();
                    Console.WriteLine("Array Before Sorting: ");
                    mergeSort.Display(array2);
                    mergeSort.Merge_Sort(array2, 0, array2.Length - 1);
                    Console.WriteLine("Array after Sorting: ");
                    mergeSort.Display(array2);
                    break;
                case 5:
                    Anagram check = new Anagram();
                    check.CheckAnagram("heart", "earth");
                    break;
                case 6:
                    MessageDemonstration replace=new MessageDemonstration();
                    replace.ReplaceString();
                    break;
                case 7:
                    PrimeNumbers range = new PrimeNumbers();
                    range.PrimeNumberRange(1, 100);
                    break;
                case 8:
                    PrimeNumbers primePalindrome = new PrimeNumbers();
                    primePalindrome.PrimeNumberRange(100, 500);
                    primePalindrome.CheckAnagramPalindrome();
                    break;
                case 9:
                    UnOrderedList unOrderedList = new UnOrderedList();
                    unOrderedList.ReadAllTextFile(binaryTextPath);
                    break;
                case 10:
                    OrderedList orderedList = new OrderedList();
                    orderedList.ReadTextFile(numberTextPath);
                    break;
                case 11:
                    BalancedParanthesis checkk=new BalancedParanthesis();
                    checkk.ReadTextFile(paranthesisTextPath);
                    break;
                case 12:
                    BankingCashCounter cash = new BankingCashCounter();
                    cash.ReadAllTextFile(bankingTextPath,120000);
                    break;
                case 13:
                    flag = false;
                    break;
            }
        }
    }
}
