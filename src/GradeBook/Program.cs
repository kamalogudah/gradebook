using System;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      double x = 23.5;
      // var x = 23.5;
      double y = 19.8;
      double sum = x + y;

      if (args.Length > 0)
      {
        Console.WriteLine($"Hello, {args[0]}!");
      }
      else
      {
        Console.WriteLine($"Hello World! and the sum is , { sum }");
      }
    }
  }
}
