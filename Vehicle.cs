using System;
using System.Collections.Generic;
using System.Text;

namespace Bulela_Tyelela_20120734_PROG6221_POE
{
    class Vehicle : Expense
    {
        //Variable Declaration
        private String model;
        private String make;
        private double purchasePrice;
        private double deposit;
        private double interestRate;
        private double insurancePremium;

        //Constuctor
        public Vehicle()
        {
            this.model = "";
            this.make = "";
            this.purchasePrice = 0.00;
            this.deposit = 0.00;
            this.interestRate = 0.00;
            this.insurancePremium = 0.00;
        }

        //Setters
        public void setModel(String m)
        { this.model = m; }
        public void setMake(String m)
        { this.make = m; }
        public void setPurchasePrice(double pp)
        { this.purchasePrice = pp; }
        public void setDeposit(double d)
        { this.deposit = d; }
        public void setInterestRate(double iR)
        { this.interestRate = iR; }
        public void setInsurancePremium(double iP)
        { this.insurancePremium = iP; }

        //Getters
        public String getModel()
        { return this.model; }
        public String getMake()
        { return this.make; }
        public double getPurchasePrice()
        { return this.purchasePrice; }
        public double getDeposit()
        { return this.deposit; }
        public double getInterestRate()
        { return this.interestRate; }
        public double getInsurancePremium()
        { return this.insurancePremium; }

        //Monthly interest rate calculation
        public double totalMonthlyCost()
        {
            double total = 0;

            //create temp values for use in calculations
            double vC = this.getPurchasePrice();
            double iR = this.getInterestRate();

            //Simple interest calculation
            total = vC * (1 + ((iR/100) * 60 / 12));
            double monthlyPayment = Math.Round((total / 60), 2);

            //Monthly Payment + Insurance Perium
            monthlyPayment += this.getInsurancePremium();

            return monthlyPayment;
        }

        //Vehicle Information
        public void vehicleInfo()
        {
            Console.WriteLine("Vehicle Model: " + this.getModel());
            Console.WriteLine("Vehicle Make: " + this.getMake());
            Console.WriteLine("Vehicle Full Price: R" + this.getPurchasePrice());
            Console.WriteLine("Vehicle Deposit: R" + this.getDeposit());
            Console.WriteLine("Vehicle Interest Rate: {0}%", this.getInterestRate());
            Console.WriteLine("Vehicle Insurance Premium: R" + this.getInsurancePremium());
        }

        public override double?[] getCellphoneCost(double?[] eArray)
        {
            throw new NotImplementedException();
        }

        public override double?[] getGroceriesCost(double?[] eArray)
        {
            throw new NotImplementedException();
        }

        public override double?[] getOtherExpensesCost(double?[] eArray)
        {
            throw new NotImplementedException();
        }

        public override double?[] getTravelCost(double?[] eArray)
        {
            throw new NotImplementedException();
        }

        public override double?[] getWaterAndLightsCost(double?[] eArray)
        {
            throw new NotImplementedException();
        }

        public override void setCellphoneCost(double i)
        {
            throw new NotImplementedException();
        }

        public override void setGroceriesCost(double i)
        {
            throw new NotImplementedException();
        }

        public override void setOtherExpensesCost(double i)
        {
            throw new NotImplementedException();
        }

        public override void setTravelCost(double i)
        {
            throw new NotImplementedException();
        }

        public override void setWaterAndLightsCost(double i)
        {
            throw new NotImplementedException();
        }
    }
}
