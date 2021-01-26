using System;

class MainClass {
  public static void Main (string[] args) {
    string[] x = Console.ReadLine().Split(' ');
    string[] y = Console.ReadLine().Split(' ');
    double x1 = double.Parse(x[0]);
    double y1 = double.Parse(x[1]);
    double x2 = double.Parse(y[0]);
    double y2 = double.Parse(y[1]);
    double a = Math.Sqrt((Math.Pow(x2 - x1,2)) + (Math.Pow(y2 - y1,2)));
    Console.WriteLine($"{a:0.0000}");
  }
}