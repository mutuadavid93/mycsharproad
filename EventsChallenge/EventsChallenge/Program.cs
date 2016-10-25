using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsChallenge
{
    public delegate void myPiggyBank(int deposit);

    public class PiggyBank
    {
        private int balance;

        //Declare the Event
        public event myPiggyBank deposited;

        public int Balance
        {
            get { return this.balance; }
            set
            {
                this.balance = value;

                //Trigger the Event
                this.deposited(this.balance);
            }
        }
    }

    public class MyTarget
    {
        public void myTarget(int amount)
        {
            if (amount == 500)
                Console.WriteLine("Congratulations, 500 target acquired! new balance is {0} \n", amount);
        }
    }

    public class BalanceChange
    {
        public void balanceChange(int amount)
        {
            Console.WriteLine("The balance amount is {0} \n", amount);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //The event publisher
            PiggyBank pbank = new PiggyBank();

            MyTarget mygoal = new MyTarget();
            BalanceChange mybal = new BalanceChange();

            //Handle the Event
            pbank.deposited += mygoal.myTarget;
            pbank.deposited += mybal.balanceChange;

            string str;
            do
            {
                Console.WriteLine("How much to deposit? ");
                str = Console.ReadLine();

                if (!str.Equals("exit"))
                {
                    int addedAmount = int.Parse(str);

                    pbank.Balance += addedAmount;              
                }

            } while (!str.Equals("exit"));
            Console.WriteLine("Thank you for depositing with us \n");

        }
    }
}
