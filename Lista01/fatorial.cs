using System;

class MainClass {
  public static void Main (string[] args) {

    int i = int.Parse(Console.ReadLine());
    Console.WriteLine($"Fatorial({i}): {Fatorial(i)}");

  }

  private static int Fatorial(int n){
    if(n == 0)
      return 1;
    else
      return n * Fatorial(n-1);
  }
}