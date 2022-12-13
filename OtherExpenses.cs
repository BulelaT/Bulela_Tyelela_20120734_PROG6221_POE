using System;
using System.Collections.Generic;
using System.Text;

namespace Bulela_Tyelela_20120734_PROG6221_POE
{
    class OtherExpenses : Expense
    {
        public OtherExpenses()
        {
            this.groceries = 0.00;
            this.waterAndLights = 0.00;
            this.travelCosts = 0.00;
            this.cellphone = 0.00;
            this.otherExpenses = 0.00;
        }
        public override void setGroceriesCost(double gCost)
        {
            this.groceries = gCost;
        }
        public override double?[] getGroceriesCost(double?[] eArray)
        {
            for (int i = 0; i < 6; i++)
            {
                if (!eArray[i].HasValue)
                {
                    eArray[i] = this.groceries;
                    break;
                }
            }
            return eArray;
        }

        public override void setWaterAndLightsCost(double wCost)
        {
            this.waterAndLights = wCost;
        }
        public override double?[] getWaterAndLightsCost(double?[] eArray)
        {
            for (int i = 0; i < 6; i++)
            {
                if (!eArray[i].HasValue)
                {
                    eArray[i] = this.waterAndLights;
                    break;
                }
            }
            return eArray;
        }

        public override void setTravelCost(double tCost) 
        {
            this.travelCosts = tCost;
        }
        public override double?[] getTravelCost(double?[] eArray)
        {
            for (int i = 0; i < 6; i++)
            {
                if (!eArray[i].HasValue)
                {
                    eArray[i] = this.travelCosts;
                    break;
                }
            }
            return eArray;
        }

        public override void setCellphoneCost(double cCost)
        {
            this.cellphone = cCost;
        }
        public override double?[] getCellphoneCost(double?[] eArray)
        {
            for (int i = 0; i < 6; i++)
            {
                if (!eArray[i].HasValue)
                {
                    eArray[i] = this.cellphone;
                    break;
                }
            }
            return eArray;
        }

        public override void setOtherExpensesCost(double oCost)
        {
            this.otherExpenses = oCost;
        }
        public override double?[] getOtherExpensesCost(double?[] eArray)
        {
            for (int i = 0; i < 6; i++)
            {
                if (!eArray[i].HasValue)
                {
                    eArray[i] = this.otherExpenses;
                    break;
                }
            }
            return eArray;
        }

        public double?[] getAllexpenses(double?[] eArray)
        {
            double?[] tempArray = eArray;

            Console.Write("How much do you spend on groceries: R");
            double cost1 = Convert.ToDouble(Console.ReadLine());
            this.setGroceriesCost(cost1);
            tempArray = this.getGroceriesCost(tempArray);

            Console.Write("How much do you spend on water and lights: R");
            double cost2 = Convert.ToDouble(Console.ReadLine());
            this.setWaterAndLightsCost(cost2);
            tempArray = this.getWaterAndLightsCost(tempArray);

            Console.Write("How much do you spend on travelling: R");
            double cost3 = Convert.ToDouble(Console.ReadLine());
            this.setTravelCost(cost3);
            tempArray = this.getTravelCost(tempArray);

            Console.Write("How much do you spend on your cellphone bill: R");
            double cost4 = Convert.ToDouble(Console.ReadLine());
            this.setCellphoneCost(cost4);
            tempArray = this.getCellphoneCost(tempArray);

            Console.Write("How much do you spend on miscellenious costs: R");
            double cost5 = Convert.ToDouble(Console.ReadLine());
            this.setOtherExpensesCost(cost5);
            tempArray = this.getOtherExpensesCost(tempArray);

            String[] expenseNames = { "Rent", "Groceries", "Water & Lights", "Travelling", "Cellphones", "Miscellenious"};


            Console.WriteLine("Your expenses are as follows:");
            Console.WriteLine();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(expenseNames[i] + ": R" + tempArray[i] + " ");
            }
            Console.WriteLine();



            eArray = tempArray;

            return eArray;
        }

        //Delegate notice
        public void delegateNotice(double moneyLeft, double grossIncome)
        {
            if (moneyLeft < (0.25 * grossIncome))
            {
                Console.WriteLine("Expenses exceed 75% of your income.");
            }
            
        }
    }
}
