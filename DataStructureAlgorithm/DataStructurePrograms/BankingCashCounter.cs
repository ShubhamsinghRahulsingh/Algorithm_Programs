using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.DataStructurePrograms
{
    public class BankingCashCounter
    {
        Queue<string> queue;
        int totalAmount;
        public void ReadAllTextFile(string filepath,int amount )
        {
            this.totalAmount = amount;
            string line = File.ReadAllText(filepath);
            string[] words = line.Split(",");
            queue = new Queue<string>();
            foreach (var word in words)
            {
                queue.Enqueue(word);
            }
            queue.Display();
            Console.Write("Total Amount Available in ATM: "+totalAmount);
          //  totalAmount=Convert.ToInt32(Console.ReadLine());
            foreach(var word in words)
            {
                Console.WriteLine("\n******Hello {0} Welcome*******\nTell What you want to Do ",word);
                Console.WriteLine("1.Deposit Amount\n2.Withdraw Amount");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Deposit();
                        break;
                    case 2:
                        Withdraw();
                        break;
                }
            }
            Console.WriteLine("Cash left in the ATM is: "+totalAmount);
        }
        public void Deposit()
        {
            Console.Write("Enter the amount you want to Deposit: ");
            int deposit = Convert.ToInt32(Console.ReadLine());
            totalAmount += deposit;
            Console.WriteLine("Your Amount is deposited Successfully");
            queue.Dequeue();
        }
        public void Withdraw()
        {
            Console.Write("Enter the amount you want to Withdraw: ");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            if (totalAmount > withdraw)
            {
                if (withdraw <= 40000)
                {
                    totalAmount -= withdraw;
                    Console.WriteLine("Amount is Withdrawn.");
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Limit Exceeds.Try Again");
                    Withdraw();
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance in ATM.Please select less amount");
                Withdraw();
            }
        }
    }
}
