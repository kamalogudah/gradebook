using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      // List<double> grades = new List<double>();
      var grades = new List<double>() { 12.8, 7.8, 69.8 };
      grades.Add(55.5);
      var result = 0.0;
      foreach (double number in grades)
      {
        result += number;
      }
      result /= grades.Count;

      Console.WriteLine($"The average grade is {result:N1}");


      if (args.Length > 0)
      {
        Console.WriteLine($"Hello, {args[0]}!");
      }
      else
      {
        Console.WriteLine("Hello World!");
      }
    }
  }
}
