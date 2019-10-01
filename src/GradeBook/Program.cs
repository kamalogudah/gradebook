using System;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      double[] numbers = new double[3];
      numbers[0] = 12.8;
      numbers[1] = 7.8;
      numbers[2] = 69.8;

      var result = numbers[0];
      result = result + numbers[1];
      result = result + numbers[2];
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
