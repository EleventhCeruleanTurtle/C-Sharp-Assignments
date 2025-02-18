using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/// <summary>
/// Date: September 20 2024
/// Purpose: reads and sorts data from employees.txt
/// </summary>

namespace Example
{
    /// <summary>
    /// This program prompts the user for a number which will then sort data read from the employees.txt file according to the entered number (1-5). 6 exits the program
    /// </summary>
    internal class Lab1
    {
        /// <summary>
        /// This method reads the data from the employees.txt file, adding it to an array by splitting it on ','
        /// </summary>
        static Employee[] Read()
        {
            string fileName = "employees.txt";

            FileInfo fileProps = new FileInfo(fileName); // used only to check if the file exists
            if (fileProps.Exists)
            {
                // file reading set up
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader data = new StreamReader(file);

                // array set up
                Employee[] employees = new Employee[100];
                int count = 0; // used for printing only the amount of employees in the employees array and not 100 lines

                // reading each line of the file, seperating the values by ',' and adding it to the employees array
                string line;
                while ((line = data.ReadLine()) != null)
                {
                    string[] exploded = line.Split(',');
                    Employee e = new Employee(exploded[0], Convert.ToInt32(exploded[1]), Convert.ToDecimal(exploded[2]), Convert.ToDouble(exploded[3]));

                    employees[count++] = e;
                }
                data.Close();
                return employees;
            }
            else { Console.WriteLine("That file does not exist."); }
            return null;
        }

        /// <summary>
        /// This method sorts the data from employees.txt using selection sort according to what the user inputs
        /// <param name="employees"> the employees array containing data from the employees.txt file </param>
        /// <param name="userInput"> the number the user entered </param>
        static void Sort(Employee[] employees, int userInput) 
        {
            if (userInput == 1) // sort by employee name (ascending)
            {
                for (int i = 0; i < employees.Length-1; i++)
                {
                    int jMinimum = i;
                    for (int j = i+1; j < employees.Length; j++)
                    {
                        if (employees[j] != null) 
                        {
                            if (employees[j].GetName().CompareTo(employees[jMinimum].GetName()) < 1)
                            {
                                jMinimum = j;
                            }
                        }
                            
                    }
                    if (jMinimum != i)
                    {
                        Employee temp = employees[i];
                        employees[i] = employees[jMinimum];
                        employees[jMinimum] = temp;
                    }
                }
            }
            else if (userInput == 2) // sort by employee number (ascending)
            {
                for (int i = 0; i < employees.Length - 1; i++)
                {
                    int jMinimum = i;
                    for (int j = i + 1; j < employees.Length; j++)
                    {
                        if (employees[j] != null)
                        {
                            if (employees[j].GetNumber() < employees[jMinimum].GetNumber())
                            {
                                jMinimum = j;
                            }
                        }

                    }
                    if (jMinimum != i)
                    {
                        Employee temp = employees[i];
                        employees[i] = employees[jMinimum];
                        employees[jMinimum] = temp;
                    }
                }
            }
            else if (userInput == 3)  // sort by employee pay rate (descending) 
            {
                for (int i = 0; i < employees.Length - 1; i++)
                {
                    int jMinimum = i;
                    for (int j = i + 1; j < employees.Length; j++)
                    {
                        if (employees[j] != null)
                        {
                            if (employees[j].GetRate() > employees[jMinimum].GetRate())
                            {
                                jMinimum = j;
                            }
                        }

                    }
                    if (jMinimum != i)
                    {
                        Employee temp = employees[i];
                        employees[i] = employees[jMinimum];
                        employees[jMinimum] = temp;
                    }
                }
            }
            else if (userInput == 4) // sort by employee hours (descending)
            {
                for (int i = 0; i < employees.Length - 1; i++)
                {
                    int jMinimum = i;
                    for (int j = i + 1; j < employees.Length; j++)
                    {
                        if (employees[j] != null)
                        {
                            if (employees[j].GetHours() > employees[jMinimum].GetHours())
                            {
                                jMinimum = j;
                            }
                        }

                    }
                    if (jMinimum != i)
                    {
                        Employee temp = employees[i];
                        employees[i] = employees[jMinimum];
                        employees[jMinimum] = temp;
                    }
                }
            }
            else if (userInput == 5) // sort by employee gross pay (descending)
            {
                for (int i = 0; i < employees.Length - 1; i++)
                {
                    int jMinimum = i;
                    for (int j = i + 1; j < employees.Length; j++)
                    {
                        if (employees[j] != null)
                        {
                            if (employees[j].GetGross() > employees[jMinimum].GetGross())
                            {
                                jMinimum = j;
                            }
                        }

                    }
                    if (jMinimum != i)
                    {
                        Employee temp = employees[i];
                        employees[i] = employees[jMinimum];
                        employees[jMinimum] = temp;
                    }
                }
            }

            // print sorted data
            Console.WriteLine("Name \t\t     Number rate   hours gross");
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
                    Employee[] employees = Read();
                    Sort(employees, userInput);
                } 
                else if (userInput == 2)// sort by employee number (ascending)
                {
                    Console.WriteLine("");
                    Employee[] employees = Read();
                    Sort(employees, userInput);
                } 
                else if (userInput == 3)  // sort by employee pay rate (descending) 
                {
                    Console.WriteLine("");
                    Employee[] employees = Read();
                    Sort(employees, userInput);
                }
                else if (userInput == 4) // sort by employee hours (descending)
                {
                    Console.WriteLine("");
                    Employee[] employees = Read();
                    Sort(employees, userInput);
                }
                else if (userInput == 5) // sort by employee gross pay (descending)
                {
                    Console.WriteLine("");
                    Employee[] employees = Read();
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
