using System;
using System.Collections.Generic;
using System.Text;

namespace Bulela_Tyelela_20120734_PROG6221_POE
{
    class Rent:Expense
    {
        //Make a rent variable to use in the class
        private double myRent;

        //Initialise rent variable
        public Rent()
        {
            this.myRent = 0.00;
        }


        //Make set and get functions for rent class
        public void setRent(double rentCash)
        {
            this.myRent = rentCash;
        }

        public double getRent()
        {
            return this.myRent;
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
