﻿using System;

namespace FibonacciSeries {
  class Program {
    static void Main(string[] args) {
      int count = 5;
      if (args.Length == 1)
        int.TryParse(args[0], out count);
      int[] fibonacci = CreateFibonacciSeries(count);

      for (int i = 0; i < fibonacci.Length; i++) {
        Console.Out.Write(fibonacci[i]);
        Console.Out.Write(" ");
      }
      Console.Out.WriteLine();
    }

    static int CreateFibonacciNumber(int index) {
      if (index == 1) return 1;
      if (index == 0) return 0;
      return CreateFibonacciNumber(index - 1) + CreateFibonacciNumber(index - 2);
    }

    static int[] CreateFibonacciSeries(int count) {
      int[] fibonacciSeries = new int[count];
      for (int i = 0; i < count; i++)
        fibonacciSeries[i] = CreateFibonacciNumber(i);
      return fibonacciSeries;
    }
  }
}
