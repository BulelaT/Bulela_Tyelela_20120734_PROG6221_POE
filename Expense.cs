using System;
using System.Collections.Generic;
using System.Text;

namespace Bulela_Tyelela_20120734_PROG6221_POE
{
    abstract class Expense
    {
        //create variables that can be accesed by any child classes created
        protected double groceries;
        protected double waterAndLights;
        protected double travelCosts;
        protected double cellphone;
        protected double otherExpenses;

        //Create abstract set and get function for each variable
        //The get functions will use the stored value to fill a nullable array
        //the get functions will take in a nullable array as an argument
        public abstract void setGroceriesCost(double i);
        public abstract double?[] getGroceriesCost(double?[] eArray);

        public abstract void setWaterAndLightsCost(double i);
        public abstract double?[] getWaterAndLightsCost(double?[] eArray);

        public abstract void setTravelCost(double i);
        public abstract double?[] getTravelCost(double?[] eArray);

        public abstract void setCellphoneCost(double i);
        public abstract double?[] getCellphoneCost(double?[] eArray);

        public abstract void setOtherExpensesCost(double i);
        public abstract double?[] getOtherExpensesCost(double?[] eArray);
    }
}
