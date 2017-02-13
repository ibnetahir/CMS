using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BO;

namespace CustomerView
{
    public class customerViewC1
    {
        private string userName;
        private string password;
        
        
        // function for the login Menu
        // function for the login Menu
        public void dispMenu1()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter your login Information: ");
            int i = 0;
            do
            {
                Console.WriteLine();
                Console.Write("User Name: ");

                string name = Console.ReadLine();
                while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine();
                    Console.Write("User Name: ");
                    name = Console.ReadLine();
                }
                Console.Write("Password: ");
                string pass = Console.ReadLine();
                while(!Regex.IsMatch(pass,@"^[a-zA-Z0-9]+$"))
                {
                    Console.WriteLine();
                    Console.Write("Password: ");
                    pass = Console.ReadLine();
                }
                // here the verifyUser function is called 
                // this function returns true if the user is authenticated
                // otherwise it returns false for unathenticated user
                if (verifyUser(ref name, pass))
                {
                    userName = name;
                    password = pass;
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Welcome " + userName + " !");
                    Console.WriteLine("Please select an option");
                    Console.WriteLine("1.Change Password");
                    Console.WriteLine("2.Logout");
                    ConsoleKeyInfo key;
                    string _val = "";
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
                    } while (key.Key != ConsoleKey.Enter);
                    // Stops Receving Keys Once Enter is Pressed
                    
                    int choice = int.Parse(_val);
                    
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Enter 1 for Try again: ");
                    ConsoleKeyInfo key;
                    string _val = "";
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
                    if(choice==1)
                    {
                        i = 1;
                    }
                }
            } while (i==1);

        }
        private bool verifyUser(ref string username,string password)
        {
            CustLogin cust = new CustLogin();
            return cust.loginData(ref username, password);
        }
    }
}
