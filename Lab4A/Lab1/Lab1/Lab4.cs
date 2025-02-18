using System;
using System.Collections.Generic;
using System.IO;

/*
  Class: Lab4.cs
  Date: Novemeber 15 2024
  Purpose: Modify Lab 1 to use a generic List<T> and its built-in Sort() method. The program will read the employee.txt file and store its information in a list.
           The user can then enter a number (1-5) to display the fields sorted. Entering 6 will exit the program.

*/

namespace Example
{
    /// <summary>
    /// This program prompts the user for a number which will then sort data read from the employees.txt file according to the entered number (1-5). 6 exits the program
    /// </summary>
    public class Lab4
    {
        /// <summary>
        /// This method reads the data from the employees.txt file, adding it to list by splitting it on ','
        /// </summary>
        static List<Employee> Read()
        {
            string fileName = "employees.txt";

            FileInfo fileProps = new FileInfo(fileName); // used only to check if the file exists
            if (fileProps.Exists)
            {
                // file reading set up
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader data = new StreamReader(file);

                // list set up
                List<Employee> employees = new List<Employee>();

                // reading each line of the file, seperating the values by ',' and adding it to the employees list
                string line;
                while ((line = data.ReadLine()) != null)
                {
                    string[] exploded = line.Split(',');
                    Employee e = new Employee(exploded[0], Convert.ToInt32(exploded[1]), Convert.ToDecimal(exploded[2]), Convert.ToDouble(exploded[3]));

                    employees.Add(e);
                }
                data.Close();
                return employees;
            }
            else { Console.WriteLine("That file does not exist."); }
            return null;
        }

        /// <summary>
        /// This method sorts the data from employees.txt using the List<T> collection's sort according to what the user inputs
        /// The sort makes use of lambda expressions with CompareTo() to compare the relevant field
        /// <param name="employees"> the employees list containing data from the employees.txt file </param>
        /// <param name="userInput"> the number the user entered </param>
        static void Sort(List<Employee> employees, int userInput)
        {
            if (userInput == 1) // sort by employee name (ascending)
            {
                employees.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
            }
            else if (userInput == 2) // sort by employee number (ascending)
            {
                employees.Sort((s1, s2) => s1.Number.CompareTo(s2.Number));
            }
            else if (userInput == 3)  // sort by employee pay rate (descending) 
            {
                employees.Sort((s1, s2) => s1.Rate.CompareTo(s2.Rate));
                employees.Reverse();
            }
            else if (userInput == 4) // sort by employee hours (descending)
            {
                employees.Sort((s1, s2) => s1.Hours.CompareTo(s2.Hours));
                employees.Reverse();
            }
            else if (userInput == 5) // sort by employee gross pay (descending)
            {
                employees.Sort((s1, s2) => s1.Gross.CompareTo(s2.Gross));
                employees.Reverse();
            }

            // print sorted data
            Console.WriteLine("Name \t\t      Number  Rate    Hours  Gross Pay");
            Console.WriteLine("==== \t\t      ======  ====    =====  =========");
            foreach (Employee e in employees)
            {
                if (e != null)
                {
                    Console.WriteLine(e);
                }
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// The main method is used to repeatly prompt the user for a number, 1-5, or 6 to exit. Depending on what number is used the data is sorted accordingly
        /// <param name="args"> unused default </param>
        /// </summary>
        static void Main(string[] args)
        {
            while (true)
            {
                int userInput;
                Console.Write("\n1.Sort by Employee Name (ascending)\r\n" +
                                  "2.Sort by Employee Number (ascending)\r\n" +
                                  "3.Sort by Employee Pay Rate (descending)\r\n" +
                                  "4.Sort by Employee Hours (descending)\r\n" +
                                  "5.Sort by Employee Gross Pay (descending)\r\n" +
                                  "6.Exit\r\n" +
                                  "Enter Number: ");
                try
                {
                    userInput = int.Parse(Console.ReadLine()); // try user input to ensure int is entered
                }
                catch (Exception e)
                {
                    userInput = 0; // set to value that will trigger else statement
                }
                if (userInput == 1) // sort by employee name (ascending)
                {
                    Console.WriteLine("");
                    List<Employee> employees = Read();
                    Sort(employees, userInput);
                }
                else if (userInput == 2)// sort by employee number (ascending)
                {
                    Console.WriteLine("");
                    List<Employee> employees = Read();
                    Sort(employees, userInput);
                }
                else if (userInput == 3)  // sort by employee pay rate (descending) 
                {
                    Console.WriteLine("");
                    List<Employee> employees = Read();
                    Sort(employees, userInput);
                }
                else if (userInput == 4) // sort by employee hours (descending)
                {
                    Console.WriteLine("");
                    List<Employee> employees = Read();
                    Sort(employees, userInput);
                }
                else if (userInput == 5) // sort by employee gross pay (descending)
                {
                    Console.WriteLine("");
                    List<Employee> employees = Read();
                    Sort(employees, userInput);
                }
                else if (userInput == 6) // exit
                {
                    break;
                }
                else // number out of range (1-6), also prints when user enters a non interger number
                {
                    Console.WriteLine("Please enter a valid number (1-6).");
                }
            }
        }
    }
}
