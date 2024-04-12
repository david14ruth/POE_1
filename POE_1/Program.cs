using System;

namespace POE_1
{
    internal class Program
    {

        // declaring variables

        string Recipe_name;
        int number_of_ingredient;
        string[] Name_of_ingredient = new String[10];
        float[] Quantity = new float[20];
        float[] Unit_of_measurement = new float[20];
        int[] Step = new int[10];
        float[] convert = new float[20];
        float[] convert1 = new float[20];
        string place_condition;
        string place_condition_convert;
        string condition2;
        string[] description = new string[20];
        string condition3;
        static void Main(string[] args)
        {
            //Creating object of Class 

            Program p = new Program();
            //Calling the method into the main method
            p.user_first_input();

        }
        public void user_first_input()
        {
            //creating the while to keep the statement ruin 
            while (true)
            {    //adding new lign
                Console.WriteLine("");
                //showing the user what he has to put as input
                Console.Write("Enter the name of the recipe :");
                //where the user can store his input 
                Recipe_name = Console.ReadLine();
                //showing the user what he has to put as input
                Console.Write("Enter the Number of ingredients :");
                //where the user can store his input 
                number_of_ingredient = Convert.ToInt32(Console.ReadLine());
                //placing a condition in order to excute the statement
                if (number_of_ingredient == number_of_ingredient)
                {
                    //placing the condition to loop according to the number of ingredient that the user will input
                    for (int i = 0; i < number_of_ingredient; i++)
                    {
                        //showing the user what his has to input
                        Console.Write("Enter the name of ingredient :");
                        //storage of the the user input 
                        Name_of_ingredient[i] = Console.ReadLine();
                        //showing the user what his has to input
                        Console.Write("Enter the quantity :");
                        //storage of the the user input
                        Quantity[i] = float.Parse(Console.ReadLine());
                        //placing the condition to the user to make a choice
                        Console.Write("Would you like to reset the Quantity? (YES) or(NOT):");
                        //storage of the the user input
                        place_condition = Console.ReadLine();
                        //convert input user by uppercase
                        place_condition_convert = place_condition.ToUpper();
                        //placing a condition 
                        if (place_condition_convert == "YES")
                        {
                            //set the quantity to empty
                            Quantity[i] = 0;
                            //storage of the the user input
                            Console.Write("Enter the quantity :");
                            //storage of the the user input
                            Quantity[i] = float.Parse(Console.ReadLine());


                        }
                        //in case the first condution does not work
                        else
                        {
                            //adding new lign 
                            Console.Write("");
                        }
                        //showing the user what his has to input
                        Console.Write("How many of teaspoon :");
                        //storage of the the user input
                        Unit_of_measurement[i] = float.Parse(Console.ReadLine());
                        convert[i] = Unit_of_measurement[i] / 5;

                        //showing the user what his has to input
                        Console.Write("Enter the number of Step: ");
                        //storage of the the user input
                        Step[i] = int.Parse(Console.ReadLine());
                        //showing the user what his has to input
                        Console.Write("Enter the description of Step: ");
                        description[i] = Console.ReadLine();
                        //storage of the the user input

                    }
                    //adding new ligns 
                    Console.WriteLine("");
                    Console.WriteLine("");
                    //what it will be displayed
                    Console.Write("Recipe'name: " + Recipe_name);
                    Console.WriteLine("");
                    Console.Write("the Number of ingredients:" + number_of_ingredient);
                    Console.WriteLine("");
                    Console.Write("the name of ingredient and quantity and Unit_of_measurement: ");
                    // looping according to the number of ingredient the user will input
                    for (int b = 0; b < number_of_ingredient; b++)
                    {
                        //what it will be displayed
                        Console.WriteLine(" " + Name_of_ingredient[b] + ", Quantity: " + Quantity[b] + ", Teaspoon: " + convert[b] + " ");

                    }
                    //adding new lign
                    Console.WriteLine("");
                    // looping according to the number of ingredient the user will input
                    for (int b = 0; b < number_of_ingredient; b++)
                    {
                        //what it will be displayed
                        Console.WriteLine("Step " + Step[b] + " " + description[b]);
                    }
                    //adding new lign
                    Console.WriteLine("");
                    //showing the user what his has to input
                    Console.Write("Would you like to clear all data? (YES) or(NOT): ");
                    //storage of the the user input
                    condition2 = Console.ReadLine();
                    //convert the input user to uppercase
                    condition2 = condition2.ToUpper();
                    //placing condition
                    if (condition2 == "YES")
                    {
                        //reset everyrhing 
                        Console.WriteLine("");
                        Recipe_name = "";
                        number_of_ingredient = 0;
                        Name_of_ingredient = new String[10];
                        Quantity = new float[20];
                        Unit_of_measurement = new float[20];
                        Step = new int[10];
                        convert = new float[20];
                        convert1 = new float[20];
                        description = new string[20];
                        //what the user should see as an output
                        Console.WriteLine("All data have been succefully deleted!");
                        //adding new ling
                        Console.WriteLine("");
                        //creating the obeject of the class
                        second_class second = new second_class();
                        //calling a method
                        second.clear_all_data();
                        break;

                    }
                    else
                    {
                        //adding new lign 
                        Console.WriteLine("");
                        //displaying to the user 
                        Console.Write("Would you like to exist the application ? (YES) or(NOT): ");
                        //storage of the the user input
                        condition3 = Console.ReadLine();
                        //convert the user input to upppercase
                        condition3 = condition3.ToUpper();
                        //placing condition
                        if (condition3 == "YES")
                        {
                            break;
                        }
                    }

                }
                //adding new lign 
                Console.WriteLine("");


            }

        }
    }
    class  second_class 
    {

        public void clear_all_data()
        {
            // declaring variables
            string Recipe_name;
            int number_of_ingredient;
            string[] Name_of_ingredient = new String[10];
            float[] Quantity = new float[20];
            float[] Unit_of_measurement = new float[20];
            int[] Step = new int[10];
            float[] convert = new float[20];
            float[] convert1 = new float[20];
            string place_condition;
            string place_condition_convert;
            string condition2;
            string[] description = new string[20];
            string condition3;

            while (true)
            {
                Console.WriteLine("");
                //showing the user what he has to put as input
                Console.Write("Enter the name of the recipe :");
                //where the user can store his input 
                Recipe_name = Console.ReadLine();
                //showing the user what he has to put as input
                Console.Write("Enter the Number of ingredients :");
                //where the user can store his input 
                number_of_ingredient = Convert.ToInt32(Console.ReadLine());
                //placing a condition in order to excute the statement
                if (number_of_ingredient == number_of_ingredient)
                {
                    //placing the condition to loop according to the number of ingredient that the user will input
                    for (int i = 0; i < number_of_ingredient; i++)
                    {
                        //showing the user what his has to input
                        Console.Write("Enter the name of ingredient :");
                        //storage of the the user input 
                        Name_of_ingredient[i] = Console.ReadLine();
                        //showing the user what his has to input
                        Console.Write("Enter the quantity :");
                        //storage of the the user input
                        Quantity[i] = float.Parse(Console.ReadLine());
                        //placing the condition to the user to make a choice
                        Console.Write("Would you like to reset the Quantity? (YES) or(NOT):");
                        //storage of the the user input
                        place_condition = Console.ReadLine();
                        //convert input user by uppercase
                        place_condition_convert = place_condition.ToUpper();
                        //placing a condition 
                        if (place_condition_convert == "YES")
                        {
                            //set the quantity to empty
                            Quantity[i] = 0;
                            //storage of the the user input
                            Console.Write("Enter the quantity :");
                            //storage of the the user input
                            Quantity[i] = float.Parse(Console.ReadLine());


                        }
                        //in case the first condution does not work
                        else
                        {
                            //adding new lign 
                            Console.Write("");
                        }
                        //showing the user what his has to input
                        Console.Write("How many of teaspoon :");
                        //storage of the the user input
                        Unit_of_measurement[i] = float.Parse(Console.ReadLine());
                        convert[i] = Unit_of_measurement[i] / 5;

                        //showing the user what his has to input
                        Console.Write("Enter the number of Step: ");
                        //storage of the the user input
                        Step[i] = int.Parse(Console.ReadLine());
                        //showing the user what his has to input
                        Console.Write("Enter the description of Step: ");
                        description[i] = Console.ReadLine();
                        //storage of the the user input

                    }
                    //adding new ligns 
                    Console.WriteLine("");
                    Console.WriteLine("");
                    //what it will be displayed
                    Console.Write("Recipe'name: " + Recipe_name);
                    Console.WriteLine("");
                    Console.Write("the Number of ingredients:" + number_of_ingredient);
                    Console.WriteLine("");
                    Console.Write("the name of ingredient and quantity and Unit_of_measurement: ");
                    // looping according to the number of ingredient the user will input
                    for (int b = 0; b < number_of_ingredient; b++)
                    {
                        //what it will be displayed
                        Console.WriteLine(" " + Name_of_ingredient[b] + ", Quantity: " + Quantity[b] + ", Teaspoon: " + convert[b] + " ");

                    }
                    //adding new lign
                    Console.WriteLine("");
                    // looping according to the number of ingredient the user will input
                    for (int b = 0; b < number_of_ingredient; b++)
                    {
                        //what it will be displayed
                        Console.WriteLine("Step " + Step[b] + " " + description[b]);
                    }
                    //adding new lign
                    Console.WriteLine("");
                    //showing the user what his has to input
                    Console.Write("Would you like to clear all data? (YES) or(NOT): ");
                    //storage of the the user input
                    condition2 = Console.ReadLine();
                    //convert the input user to uppercase
                    condition2 = condition2.ToUpper();
                    //placing condition
                    if (condition2 == "YES")
                    {
                        //reset everyrhing 
                        Console.WriteLine("");
                        Recipe_name = "";
                        number_of_ingredient = 0;
                        Name_of_ingredient = new String[10];
                        Quantity = new float[20];
                        Unit_of_measurement = new float[20];
                        Step = new int[10];
                        convert = new float[20];
                        convert1 = new float[20];
                        description = new string[20];
                        //what the user should see as an output
                        Console.WriteLine("All data have been succefully deleted!");
                        //adding new ling
                        Console.WriteLine("");
                        //calling a method
                        clear_all_data();
                        break;

                    }
                    else
                    {
                        //adding new lign 
                        Console.WriteLine("");
                        //displaying to the user 
                        Console.Write("Would you like to exist the application ? (YES) or(NOT): ");
                        //storage of the the user input
                        condition3 = Console.ReadLine();
                        //convert the user input to upppercase
                        condition3 = condition3.ToUpper();
                        //placing condition
                        if (condition3 == "YES")
                        {
                            break;
                        }
                    }

                }
                //adding new lign 
                Console.WriteLine("");


            }
        }
    }
}
