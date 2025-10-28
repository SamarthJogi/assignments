using System;

namespace InvestmentApp
{
    class Investment
    {
        private double amount ,rate;
        private int period;

        public Investment()
        {
            amount = 0.0;
            rate = 0.0;
            period = 0;
            // Console.WriteLine("Default constructor called.");
        }

        public Investment(double amount,double rate, int period)
        {
            this.amount = amount;
            this.rate = rate;
            this.period = period;
            // Console.WriteLine("parameterized constructor called.");

        }

        ~Investment()
        {
             Console.WriteLine("Destructor called for Investment objects.");
        }

        public double Amount{
            get{return amount;}
            set{amount = value;}
        }

        public double Rate{
            get{ return rate;}
            set{ rate = value;}
        }

        public int Period{
            get {return period;}
            set{period = value;}
        }

        public double GetInterest()
        {
            return (amount * rate * period) / 100.0;
        }

        public void Print()
        {
            Console.WriteLine("\n\tInvestment Details: ");
            Console.WriteLine($"Amount Invested : {amount:0.00}");
            Console.WriteLine($"Rate of Interest: {rate}%");
            Console.WriteLine($"Period (years)  : {period}");
        }
    }
}