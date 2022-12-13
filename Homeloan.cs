using System;
using System.Collections.Generic;
using System.Text;

namespace Bulela_Tyelela_20120734_PROG6221_POE
{
    class Homeloan: Expense
    {
        //Create Vaiables to be used in class
        private double propertyPrice;
        private double deposit;
        private double interestRate;
        private int repayMonths;


        //Initialise values in a constructor
        public Homeloan()
        {
            this.propertyPrice = 0.00;
            this.deposit = 0.00;
            this.interestRate = 0.00;
            this.repayMonths = 0;
        }

        //implement set and get functions for variables
        public void setHomeCost(double hCost)
        {
            this.propertyPrice = hCost;
        }

        public double getHomeCost()
        {
            return this.propertyPrice;
        }

        public void setRepayNumberOfMonths(int months)
        {
            this.repayMonths = months;
        }

        public int getRepayNumberOfMonths()
        {
            return this.repayMonths;
        }

        //create function to calculate monthly payment using simple interest
        public double homeloanCostCalculation(double income, double iRate)
        {
            //set interestRate
            this.interestRate = iRate;

            //store property cost in a temp variable
            double m = this.getHomeCost();

            //Calculate total monthly payment using simple interest formula
            double total = m * (1 + (this.interestRate * this.getRepayNumberOfMonths()/12));
            //Round to 2 decimal places because it's currency
            double monthlyPayment = Math.Round((total / this.getRepayNumberOfMonths()),2);

            //If Monthly payment is more that a third of users total income
            //... notify them that a loan is unlikelt to be approved
            if (monthlyPayment > income / 3)
            {
                Console.WriteLine("approval of the home loan is unlikely");
            }

            return monthlyPayment;
        }


        //Because you have to override abstract functions,...
        //...return a thrown exception showing that the function was...
        //...not implemented
        public override void setGroceriesCost(double i)
        {
            throw new NotImplementedException();
        }

        public override double?[] getGroceriesCost(double?[] eArray)
        {
            throw new NotImplementedException();
        }

        public override void setWaterAndLightsCost(double i)
        {
            throw new NotImplementedException();
        }

        public override double?[] getWaterAndLightsCost(double?[] eArray)
        {
            throw new NotImplementedException();
        }

        public override void setTravelCost(double i)
        {
            throw new NotImplementedException();
        }

        public override double?[] getTravelCost(double?[] eArray)
        {
            throw new NotImplementedException();
        }

        public override void setCellphoneCost(double i)
        {
            throw new NotImplementedException();
        }

        public override double?[] getCellphoneCost(double?[] eArray)
        {
            throw new NotImplementedException();
        }

        public override void setOtherExpensesCost(double i)
        {
            throw new NotImplementedException();
        }

        public override double?[] getOtherExpensesCost(double?[] eArray)
        {
            throw new NotImplementedException();
        }
    }
}
