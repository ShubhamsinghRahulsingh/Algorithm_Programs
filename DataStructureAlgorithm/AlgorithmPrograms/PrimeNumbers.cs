using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.AlgorithmPrograms
{
    public class PrimeNumbers
    {
        public List<int> primeNumbers=new List<int>();
        public List<int> primePalindrome = new List<int>();
        public List<int> primeAnagram = new List<int>();


        public void PrimeNumberRange(int minNum,int maxNum)
        {
            Console.Write("Pime Numbers between given range are:");
            for (int i = minNum; i <= maxNum; i++)
            {
                if (i>2)
                {
                    int temp = i;
                    bool isPrime = true;
                    for (int j=2; j<temp; j++)
                    {
                        if(temp%j==0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if(isPrime==true)
                    {
                        primeNumbers.Add(i);
                    }
                }
                else
                {
                    if(i==2)
                        primeNumbers.Add(i);
                }
            }
            Display(primeNumbers);
            Console.WriteLine("\n------------------------------------------------------------");
        }
        public void CheckAnagramPalindrome()
        {
            foreach (var data in primeNumbers)
            {
                if (data > 9)
                {
                    int sum = 0;
                    int remainder;
                    int temp = data;
                    while (temp > 0)
                    {
                        remainder = temp % 10;
                        sum = sum * 10 + remainder;
                        temp /= 10;
                    }
                    if (sum == data)
                        primePalindrome.Add(data);
                }
            }
            Console.WriteLine("Prime Numbers that are Palindrome between given range are: ");
            Display(primePalindrome);
        }
        public void Display(List<int> list)
        {
            foreach(var data in list)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
