using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> CustomerNameCustomerNumber = new Dictionary<string, int>();
                                        //Name     //Number
                                        //İsim     //Numara
            CustomerNameCustomerNumber.Add("Mummer", 1453);
            CustomerNameCustomerNumber.Add("Turan", 2000);
            CustomerNameCustomerNumber.Add("Egemen", 1905);
            CustomerNameCustomerNumber.Add("Ayşe", 1907);
            CustomerNameCustomerNumber.Add("Sıla", 2003);

            foreach (var degeroku in CustomerNameCustomerNumber)
            {
                Console.WriteLine(degeroku);
            }
            Console.ReadLine();
        }
    }
}
