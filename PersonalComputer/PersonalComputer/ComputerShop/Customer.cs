using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    class Customer : Person
    {
        /// <summary> Покупки, которые курил покупатель. </summary>
        public List<IProduct> Products { get; } = new List<IProduct>();
        public string Adress { get; }
        public double Balance { get; private set; }
        public double Spent { get; private set; }

        public Customer(string name, int age, string adress, int balance, int spent)
            :base(name, age)
        {
            Adress = adress;
            Balance = balance;
            Spent = spent;
        }

        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }
    }
}
