using System;

class MainClass {
  public static void Main (string[] args) {
    string[] x = Console.ReadLine().Split(' ');

    int a = int.Parse(x[0]);
    int b = int.Parse(x[1]);
    int s = int.Parse(x[2]);

    int mab = (a + b + Math.Abs( a - b )) / 2;
    int mabs = (mab + s + Math.Abs( mab - s )) / 2;

    Console.WriteLine($"{mabs:0} eh o maior");

  }
}