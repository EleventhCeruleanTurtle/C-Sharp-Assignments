using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
  Class: Employee.cs
  Date: Novemeber 15 2024
  Purpose: Modify Employee to use properties. Stores employee data read in Lab4.cs from the employee.txt file.

*/

/// <summary>
/// This class describes the employee
/// </summary>
public class Employee
{
  // Properties
  public string Name { get; set; }                          // The employee name
  public int Number { get; set; }                           // The employee ID
  public decimal Rate { get; set; }                         // The hourly rate
  public double Hours { get; set; }                         // The weekly hours
  public decimal Gross                                      // The gross pay
    { 
        get { return (Hours < 40) ? (decimal)Hours * Rate : (40.0m * Rate) + (((decimal)Hours - 40.0m) * Rate * 1.5m); } 
    }                        

  /// <summary>
  /// Default constructor for Employee - used for creating Employee list
  /// </summary>
  public Employee()
  {
  }

  /// <summary>
  /// Four-argument constructor for Employee
  /// </summary>
  /// <param name="name">Employee name</param>
  /// <param name="number">Employee number</param>
  /// <param name="rate">Hourly rate of pay</param>
  /// <param name="hours">Hours worked in a week</param>
  public Employee(string name, int number, decimal rate, double hours)
  {
        /* This is the better way to set data in a class - use the accessor methods.
         * That way, if their implementation changes, the constructor doesn't need to
         * be edited as well.
         */
        this.Name = name;
        this.Number = number;
        this.Rate = rate;
        this.Hours = hours;
  }

  /// <summary>
  /// Employee display method
  /// </summary>
  public override String ToString() => $"{Name,-20}  {Number:D5}  {Rate,6:C}  {Hours:#0.00}  {Gross,9:C}";

}

