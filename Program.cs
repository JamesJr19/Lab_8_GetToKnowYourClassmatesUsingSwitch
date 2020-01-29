using System;

namespace Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# January 2020.");
            //start of while-loop for userContinue
            string userContinue = "y";
            while (userContinue != "n")
            {
                //Prompt user to select a classmate and uses the Switch-Case method
                Console.WriteLine("Pick a classmate from below to get to know them.");
                Console.WriteLine(" 1. James \n 2. Matt \n 3. Sean \n 4. Blake");
                Console.WriteLine();

                //Start of while-loop to only accept valid case
                string name = "";
                bool tryAgain = true;
                while (tryAgain)
                {
                    string userInput = Console.ReadLine().ToLower();
                    tryAgain = false;

                    switch (userInput)
                    {
                        case "1":
                        case "james":
                            name = "James";
                            break;

                        case "2":
                        case "matt":
                            name = "Matt";
                            break;

                        case "3":
                        case "sean":
                            name = "Sean";
                            break;

                        case "4":
                        case "blake":
                            name = "Blake";
                            break;

                        default:
                            tryAgain = true;
                            Console.WriteLine("Invalid. Try another option");
                            break;
                    }
                }
                //diplays the classmate's name
                Console.WriteLine();
                Console.WriteLine($"You've entered {name}! Excellent choice!");
                Console.WriteLine();

                //Prompts user what they would like to know next
                Console.WriteLine("What would you like to know next?");
                Console.WriteLine();

                //give user list to choose from
                Console.WriteLine(" 1. Hometown \n 2. Favorite food \n");


                //Another while-loop to validate case number inputs
                bool tryAgain2 = true;
                while (tryAgain2)
                {
                    string moreInfo = Console.ReadLine().ToLower();
                    tryAgain2 = false;

                    switch (moreInfo)
                    {
                        case "1":
                        case "hometown":
                            Console.WriteLine($"{name} is from Detroit!");
                            break;

                        case "2":
                        case "favorite food":
                            Console.WriteLine($"{name}'s favorite food is pizza!");
                            break;

                        default:
                            tryAgain = true;
                            Console.WriteLine("Invalid. Try another option");
                            break;
                    }

                    //The while-loop at the top comes full circle
                    //ask user if they want to try again
                    //Validation to make sure they enter y or n
                    userContinue = "";
                    while (userContinue != "y" && userContinue != "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Would you like to try again? y/n");
                        userContinue = Console.ReadLine().ToLower();
                    }

                }

            }
        }
    }
}



