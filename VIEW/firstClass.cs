using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminView;
using CustomerView;

namespace VIEW
{
    public class firstClass
    {
        private int accountType;
        public void displayMenu()
        {
            string _val = "";
            Console.WriteLine("Customer Management System");
            Console.WriteLine();
            Console.WriteLine("Welcome !");
            Console.WriteLine("Please Select Your Account Type: "+"\r\n"+"\r\n");
            Console.WriteLine("1.Administrator");
            Console.WriteLine("2.Customer");
            Console.WriteLine("3.Close Programe");


            Console.Write("Enter your value: ");
            ConsoleKeyInfo key;
            
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                    if (_x)
                    {
                        _val += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _val.Length > 0)
                    {
                        _val = _val.Substring(0, (_val.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            // Stops Receving Keys Once Enter is Pressed
            while (key.Key != ConsoleKey.Enter);
            int choice = int.Parse(_val);
            if(choice==3)
            {
                Console.WriteLine("\b \b");
                Environment.Exit(0);
            }
            else if(choice==2)
            {
                customerViewC1 cust1 = new customerViewC1();
                cust1.dispMenu1();
            }
        }
    }
}
