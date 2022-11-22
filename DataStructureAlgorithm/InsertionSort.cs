using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class InsertionSort
    {
        string[] binaryArr;
        public void ReadTextFiles(string filepath)
        {
            string words = File.ReadAllText(filepath);
            binaryArr = words.Split(",");
            Console.WriteLine("Before sorting we have: ");
            Display();
            Console.WriteLine("------------------------------------");
        }
        public void Sort()
        {
            for (int i = 0; i < binaryArr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (binaryArr[i].CompareTo(binaryArr[j]) < 0)
                    {
                        string temp = binaryArr[j];
                        binaryArr[j] = binaryArr[i];
                        binaryArr[i] = temp;
                    }
                }
            }
            Console.WriteLine("After sorting we have: ");
            Display();
        }
        public void Display()
        {
            foreach (var data in binaryArr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
