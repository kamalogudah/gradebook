using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var numbers = new[] { 12.8, 7.8, 69.8 };

      // List<double> grades = new List<double>();
      var grades = new List<double>() { 12.8, 7.8, 69.8 };
      grades.Add(55.5);
      var result = 0.0;
      foreach (double number in grades)
      {
        result += number;
      }
      Console.WriteLine(result);


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
