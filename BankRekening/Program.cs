using BankRekening.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRekening
{
    internal class Program
    {        
        static Bank[] banks = new Bank[2];
        static Client[] clients = new Client[2];

        static void Main(string[] args)
        {
            string line = new string('_', 50);
            Console.WriteLine(line);

            Client client1 = new Client("Jan", "Jansens", "Anderlecht", 44);
            Bank bank1 = new Bank("BE1245545", "ING", 1000);
            bank1.WithDraw(100);
            ShowInfo(client1, bank1);
            bank1.Deposit(2500);
            ShowInfo(client1, bank1);


            Console.WriteLine(line);
            ClientnfoInput();

            for(int i = 0;i < clients.Length;i++)
            {
                Client client = ClientnfoInput();
                clients[i] = client;
            }
            for(int i = 0;i<banks.Length;i++)
            {
                Bank bank = BankInfoInput();
                /*bank1.WithDraw(100);*/
                banks[i] = bank;
            }
            for(int i = 0; i < clients.Length;i++) 
            {
                Console.WriteLine($"{clients[i]} - {banks[i]}");
            }
            for( int i = 0;i<banks.Length; i++) 
            {
                banks[i].WithDraw(500);
                Console.WriteLine($"{banks[i].ShowSaldo()}");
            }

            /*Client client2 = new Client("Piet", "Piraat", "SchieveLavabo", 52);*/
        }

         static Client ClientnfoInput()
        {
            //Data by the user input:
            Console.Clear();
            Console.Write("Enter your first name: ");
            string fnm = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string ltnm = Console.ReadLine();
            Console.Write("Enter your adress: ");
            string adrs = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());

            Client client = new Client(fnm, ltnm, adrs, age);
            return client;
            
        }

        static Bank BankInfoInput()
        {
            Console.Clear();
            //Here goes the screen for the bank input........
            Bank bank = new Bank("BE1245545", "ING", 1000);
            //Bank bank = new Bank(iban, bankName, saldo);
            return bank;
        }
        static void ShowInfo(Client client, Bank bank)
        {
            
            Console.WriteLine($"{client.LastName} has {bank.ShowSaldo()}");
        }

    }
}
