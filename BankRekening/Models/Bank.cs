using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRekening.Models
{
    public class Bank
    {
        public string BankCard;
        public string BankName;
        public double Saldo;

        public Bank(string bankcard, string bankname, double saldo)
        {
            BankCard = bankcard;
            BankName = bankname;
            Saldo = saldo;
        }
        public void Deposit(double amount) 
        {
            Saldo += amount;
        }
        public void WithDraw(double amount) 
        {
            Saldo -= amount;
        }
        public double ShowSaldo()
        {
            return Saldo;
        }
        public override string ToString() 
        {
            return $"{BankCard} {BankName} {Saldo}";
        }
    }
}
