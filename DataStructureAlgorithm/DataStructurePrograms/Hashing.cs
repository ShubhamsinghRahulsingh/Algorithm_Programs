using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.DataStructurePrograms
{
    public class Hashing
    {
        LinkedList<int>[] array = new LinkedList<int>[11];
        List<int> values = new List<int>();
        public Hashing()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new LinkedList<int>();
            }
        }
        public void ReadTextFile(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(",");
            foreach (var data in words)
            {
                values.Add(Convert.ToInt32(data));
            }
        }
        public void Operation()
        {
            foreach (var data in values)
            {
                array[data % 11].Add(data);
            }
        }
        public void DisplayLinkedList()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("\nSlot " + i);
                array[i].Display();
            }
        }
    }
}
