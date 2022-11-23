using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.AlgorithmPrograms
{
    public class MessageDemonstration
    {
        public void ReplaceString()
        {
            string input = "Hello << name >> We have your fullname as << full name >> in our system. your contact number is 91 - xxxxxxxxxx.Please,let us know in case of any clarification.Thank you BridgeLabz 01 / 01 / 2016.";
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            input = input.Replace("<< name >>", name);
            Console.WriteLine("Enter your Full name");
            string fullname = Console.ReadLine();
            input = input.Replace("<< full name >>", fullname);
            Console.WriteLine("Enter your Phone Number");
            string Ph_No = Console.ReadLine();
            input = input.Replace("xxxxxxxxxx", Ph_No);
            Console.WriteLine("Enter today's Date");
            string date = Console.ReadLine();
            input = input.Replace("01 / 01 / 2016", date);
            Console.WriteLine(input);
        }
    }
}
