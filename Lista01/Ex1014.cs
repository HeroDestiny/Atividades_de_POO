using System;

class MainClass {
  public static void Main (string[] args) {

    int x = int.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double d = x / y;

    Console.WriteLine($"{d:0.000} km/l");

  }
}