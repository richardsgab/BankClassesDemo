using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRekening.Models
{
    public class Client
    {
        public string FirstName;
        public string LastName;
        public string Adress;
        public int Age;

        public Client(string firstname, string lastname, string adress, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Adress = adress;
            Age = age;
        }
        public override string ToString() 
        {
            return $"{FirstName} {LastName} {Adress} {Age}";
        }
    }
}
