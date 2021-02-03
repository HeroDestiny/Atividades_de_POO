using System;

class MainClass {
  public static void Main (string[] args) {
    
    int tmp = int.Parse(Console.ReadLine());
    int vlc = int.Parse(Console.ReadLine());

    double gsl = (tmp * vlc) / 12.0;

    Console.WriteLine($"{gsl:0.000}");

  }
}