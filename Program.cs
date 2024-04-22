// Calculator (simple console project in C#)

// Menu 
// features (Menu-addition-subtraction-multiplication-division-exit)

using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Transactions;

namespace calculator_space
{
    class Calculator
    {
        // addition method
        static decimal Addition (decimal a, decimal b){
            return a+b;
        }
       
        // subtraction method
        static decimal Subtraction (decimal a, decimal b){
            return a-b;
        }

        // multiplication method
        static decimal Multiplication(decimal a, decimal b){
            return a*b;
        }

        // division method 
        static decimal Division(decimal a, decimal b){
            // check if b not equal zero
            if (b != 0){
                return a/b;
            }else{
                Console.WriteLine("Not correct because it is divided by zero :(");
                return 0;
            }
        }

        // exit function 


        // Menu: display list of all features allow user to select one of them.
         static void Menu(bool start){

            if (start){
  
                // display list of choices:
                Console.WriteLine("MENU:\n1.Addition\n2.subtraction\n3.Multiplication\n4.Division\n5.Exit");

                // start to allow user enter number to select choice
                Console.WriteLine("Enter your choice from list:");
                int choice_number = Convert.ToInt16(Console.ReadLine());
              
               // enter two numbers 
                Console.WriteLine("Enter numbers");
                decimal number_a = Convert.ToDecimal(Console.ReadLine());
                decimal number_b = Convert.ToDecimal(Console.ReadLine());
                


                switch (choice_number){
                    case 1:
                    // addition function
                    
                        break;
                    case 2:
                    // difference between numbers

                        break;
                    case 3:
                    // Multiplication 

                        break;
                    case 4:
                    // division numbers

                        break;
                    case 5:
                    // exit function

                        break;
                }
            }
        }


        static void Main(string[] args)
        {
          
           // Allow user to start using calculator by press enter button
           Console.WriteLine("Press Enter to start using the calculator ...");

           while (Console.ReadKey().Key != ConsoleKey.Enter){
                // If key not enter, continue waiting..
                Console.WriteLine("Please, Press Enter to start using the calculator ...");
           }
           // once Enter is pressed, start using calculator
           bool start = true;
           Menu(start);
        
        }
    }
}


// Main function  (start point of project)

