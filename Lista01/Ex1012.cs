using System;

class MainClass {
  public static void Main (string[] args) {
    string[] x = Console.ReadLine().Split(' ');

    double a = double.Parse(x[0]);
    double b = double.Parse(x[1]);
    double c = double.Parse(x[2]);

    double tri = (a * c) / 2 ;
    double cir = (c * c) * 3.14159 ;
    double tra = (a + b) * c / 2 ;
    double qua = (b * b) ;
    double ret = (a * b) ;

    Console.WriteLine($"TRIANGULO: {tri:0.000}");
    Console.WriteLine($"CIRCULO: {cir:0.000}");
    Console.WriteLine($"TRAPEZIO: {tra:0.000}");
    Console.WriteLine($"QUADRADO: {qua:0.000}");
    Console.WriteLine($"RETANGULO: {ret:0.000}");
  }
}