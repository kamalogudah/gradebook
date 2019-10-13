using System;
using System.Collections.Generic;

namespace GradeBook
{


  class Program
  {
    static void Main(string[] args)
    {
      // List<double> grades = new List<double>();
      var book = new Book("Paul's Grade Book");
      book.AddGrade(89.1);
      book.AddGrade(90.1);
      book.AddGrade(900.1);
      Book.Generation();
      var stats = book.GetStatistics();
      Console.WriteLine($"The lowest grade is {stats.Low}");
      Console.WriteLine($"The highest grade is { stats.High }");
      Console.WriteLine($"The average grade is {stats.Average:N1}");

    }
  }
}
