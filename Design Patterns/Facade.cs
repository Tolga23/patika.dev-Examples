using System;

namespace facade
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.name);
            if(amount > 100000)
            {
                return false;
            }
            
            return true;
        }
    }

    public class Credit
    {
        public bool HasGoodCreditScore(Customer c)
        {
            Console.WriteLine("Check credit for " + c.name);
            return true;
        }
    }

    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.name);
            return true;
        }
    }

    public class Mortgage
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();


        public bool IsEligible(Customer c, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", c.name, amount);

            bool eligible = true;

            if (!bank.HasSufficientSavings(c, amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(c))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCreditScore(c))
            {
                eligible = false;
            }

            if (eligible)
            {
                Console.WriteLine("{0} has been approved\n", c.name);
            }
            else
            {
                Console.WriteLine("{0} has not been approved\n", c.name);
            }

            return eligible;
        }
    }

    public class Customer
    {
        
        public string name { get; set; }

        public Customer(string name)
        {
            this.name = name;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {

            Customer c = new Customer("Jack");
            Mortgage mortgage = new Mortgage();
            bool isEligable = mortgage.IsEligible(c, 100000);
            // mortgage.IsEligible(c, 100000);

            if (isEligable)
            {
                Console.WriteLine("{0} has been approved for a 100000 loan", c.name);
            }
            else
            {
                Console.WriteLine("{0} has not been approved for a 100000 loan", c.name);

            }

            
        }
        
    }

}