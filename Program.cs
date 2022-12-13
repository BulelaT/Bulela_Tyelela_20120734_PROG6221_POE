using System;
using System.Collections.Generic;
using System.Text;

namespace Bulela_Tyelela_20120734_PROG6221_POE
{
    class Program
    {
        //Making delegate blueprint
        public delegate void delegateNoticePtr(double x, double y);
        static void Main(string[] args)
        {
            //create an array that holds the values of all the expenses mentioned
            double?[] expensesArray = new double?[6];
            //Create list to store all expenses
            List<double?> expensesList = new List<double?>(7);
            //Create Vehicle class
            Vehicle v = new Vehicle();
            //Temp variable for monthly vehicle cost
            double tempvC = 0;
            

            Console.WriteLine("Hello Siphiwe!");

            //Ask user to input how much they earn
            Console.Write("How much is your gross income?: R ");
            //Read value and convert it to double since it is currency
            double grossIncome = Convert.ToDouble(Console.ReadLine());
            double tempIncome = grossIncome;

            //Promt user input for type of living accomodation
            Console.WriteLine("Are you paying rent or applying for a homeloan (type 'rent' or 'homeloan')");
            string option = Console.ReadLine();

            //TASK 2 - Adding a vehicle and making use of a list
            //Ask user if they are buying a vehicle
            Console.WriteLine("Will you be purchasing a vehicle? (Type yes or no)");
            String answer = Console.ReadLine();

            //If they are purchasing a vehicle, prompt user to input all necessary data
            if (answer.Equals("yes"))
            {
                Console.WriteLine("What is the vehicle's model?");
                string model = Console.ReadLine();
                v.setModel(model);

                Console.WriteLine("What is the vehicle's make?");
                string make = Console.ReadLine();
                v.setMake(make);

                Console.WriteLine("How much is the full price of the vehicle?");
                double purchasePrice = Convert.ToDouble(Console.ReadLine());
                v.setPurchasePrice(purchasePrice);

                Console.WriteLine("How much is the total deposit?");
                double deposit = Convert.ToDouble(Console.ReadLine());
                v.setDeposit(deposit);

                Console.WriteLine("What is the interest rate on the vehicle payment? (in %)");
                double interestRate = Convert.ToDouble(Console.ReadLine());
                v.setInterestRate(interestRate);

                Console.WriteLine("What is the estimated insurance premium of the vehicle?");
                double insurancePremium = Convert.ToDouble(Console.ReadLine());
                v.setInsurancePremium(insurancePremium);

                //Add vehicle cost to list
                double vehicleCost = v.totalMonthlyCost();
                expensesList.Add(vehicleCost);
                tempvC = vehicleCost;

                //output test for monthly vehicle cost
                Console.WriteLine("Monthly Vehicle Cost is R" + expensesList[0]);

                //deduct vehicle monthly cost from gross income
                grossIncome -= vehicleCost;

                //Ask if the user would like to see the vehicle information
                Console.WriteLine("Would you like to see the vehicle information? (Type 'yes' or 'no')");
                String newOption = Console.ReadLine();
                if(newOption.Equals("yes"))
                {
                    v.vehicleInfo();
                }
            }

            


            if (option == "rent")
            {
                //Create rent object
                Rent r = new Rent();

                //Ask user how much their rent is
                Console.Write("How much rent are you paying for your accomodation?: R ");
                double rentC = Convert.ToDouble(Console.ReadLine());

                //Ask user if they had to pay a deposit
                Console.Write("How much deposit do you have to pay, if there isn't a deposit, enter 0: R");
                double deposit = Convert.ToDouble(Console.ReadLine());

                //call set function to set rent amount
                r.setRent(rentC);

                
                Console.WriteLine("Now let's move on to your other expenses...");

                //Add the value of your rent to the array
                expensesArray[0] = r.getRent();

                //Create an object that will hold every other expense
                OtherExpenses oE = new OtherExpenses();

                //call funnction that adds all expenses into an array...
                //... and assign the returned array to the local array...
                //These values will be moved to a List Collection later
                expensesArray = oE.getAllexpenses(expensesArray);

                //Take all values stored in Array and add them to LIST COLLECTION
                for (int i = 0; i < expensesArray.Length; i++)
                {
                    expensesList.Add(expensesArray[i]);
                }

                //Clear Array
                for (int i = 0; i < expensesArray.Length; i++)
                {
                    expensesArray[i] = null;
                }

                //Subtract all values in LIST from the grossIncome
                for (int i = 0; i < expensesList.Count; i++)
                {
                    grossIncome -= Convert.ToDouble(expensesList[i]);
                }

                //If there was a deposit, show for update purposes
                if (deposit > 0)
                {
                    Console.WriteLine("Also included with these expenses is your deposit of {0:c}", deposit);
                    //Subtract deposit from grossIncome
                    grossIncome -= deposit;
                }

                //Creating delegate object
                delegateNoticePtr dPtr = new delegateNoticePtr(oE.delegateNotice);
                //invoke delegation
                dPtr(grossIncome,tempIncome);

                //Show remaining income
                Console.WriteLine("After All your expenses you have {0:c} left.", grossIncome + tempvC);
                //Display Expenses in Decending order
                expensesList.Sort();
                expensesList.Reverse();
                Console.WriteLine("The expenses in decending order are: ");
                for (int i = 0; i < expensesList.Count; i++)
                {
                    Console.WriteLine(expensesList[i]);
                }

            }
            else if (option == "homeloan")
            {
                //create Homeloan object
                Homeloan h = new Homeloan();

                //Prompt user to input property full price
                Console.Write("How much does your home cost (full price please): R");
                double homePrice = Convert.ToDouble(Console.ReadLine());

                //Prompt user to input the loan's interest rate
                Console.Write("What is your loan's interest rate, in percentage? ");
                double iRate = Convert.ToDouble(Console.ReadLine());

                //Prompt user to input the amount of months it will take to repay loan
                int rMonths = 0;
                
                //Make do-while loop to ensure user inputs the correct number
                do
                {
                    Console.Write("How many months will it take to repay the loan (choose between 240 and 360) : ");
                    rMonths = Convert.ToInt32(Console.ReadLine());
                } while (rMonths < 240 || rMonths > 360);
               

                Console.Write("How much deposit do you have to pay, if there isn't a deposit, enter 0: R");
                double deposit = Convert.ToDouble(Console.ReadLine());

                //set values for the property cost and...
                //how long it will take to repay the loan
                h.setHomeCost(homePrice);
                h.setRepayNumberOfMonths(rMonths);

                //Call function that will calculate monthly payment...
                //...using simple interest
                double homeMonthlyRepay = h.homeloanCostCalculation(grossIncome,(iRate/100));

                //notify user how much they'll pay per month
                Console.WriteLine("Your monthly repayment is: {0:c}", homeMonthlyRepay);
                Console.WriteLine("You have {0:c} left, Now let's move on to your other expenses...", (grossIncome - homeMonthlyRepay - deposit));

                //add monthly payment to array
                expensesArray[0] = homeMonthlyRepay;

                //Create OtherExpenses object
                OtherExpenses oE = new OtherExpenses();

                //call funnction that adds all expenses into an array...
                //... and assign the returned array to the local array
                expensesArray = oE.getAllexpenses(expensesArray);

                //Take all values stored in Array and add them to LIST COLLECTION
                for (int i = 0; i < expensesArray.Length; i++)
                {
                    expensesList.Add(expensesArray[i]);
                }

                //Clear Array
                for (int i = 0; i < expensesArray.Length; i++)
                {
                    expensesArray[i] = null;
                }

                //Subtract all values in LIST from the grossIncome
                for (int i = 0; i < expensesList.Count; i++)
                {
                    grossIncome -= Convert.ToDouble(expensesList[i]);
                }

                //If there was a deposit, show for update purposes
                if (deposit > 0)
                {
                    Console.WriteLine("Also included with these expenses is your deposit of {0:c}", deposit);
                    //deduct deposit from income
                    grossIncome -= deposit;
                }

                //Creating delegate object
                delegateNoticePtr dPtr = new delegateNoticePtr(oE.delegateNotice);
                //invoke delegation
                dPtr(grossIncome, tempIncome);

                //notify user how much they have left
                Console.WriteLine("After All your expenses you have {0:c} left.", grossIncome + tempvC);

                //Display Expenses in Decending order
                expensesList.Sort();
                expensesList.Reverse();
                Console.WriteLine("The expenses in decending order are: ");
                for (int i = 0; i < expensesList.Count; i++)
                {
                    Console.WriteLine(expensesList[i]);
                }
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}
