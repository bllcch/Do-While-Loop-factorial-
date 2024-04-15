using System;

namespace Loops
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      decimal factorial = 1;

      do
      {
        factorial *= x;
        x--;
      } while (x > 0);

      Console.WriteLine("x!=" + factorial);
    }
  }
}