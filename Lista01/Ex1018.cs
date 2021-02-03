using System;

class MainClass {

  public static void Main (string[] args) {
    
    int rs, rs1, n100, n50, n20, n10, n05, n02, n01;

    rs = int.Parse(Console.ReadLine());
    rs1 = rs;
    n100 = rs / 100;
    rs = rs - (n100 * 100);
    n50 = rs / 50;
    rs = rs - (n50 * 50);
    n20 = rs / 20;
    rs = rs - (n20 * 20);
    n10 = rs / 10;
    rs = rs - (n10 * 10);
    n05 = rs / 5;
    rs = rs - (n05 * 5);
    n02 = rs / 2;
    rs = rs - (n02 * 2);
    n01 = rs / 1;
    rs = rs - (n01 * 1);

    Console.WriteLine(rs1);
    Console.WriteLine($"{n100} nota(s) de R$ 100,00");
    Console.WriteLine($"{n50} nota(s) de R$ 50,00");
    Console.WriteLine($"{n20} nota(s) de R$ 20,00");
    Console.WriteLine($"{n10} nota(s) de R$ 10,00");
    Console.WriteLine($"{n05} nota(s) de R$ 5,00");
    Console.WriteLine($"{n02} nota(s) de R$ 2,00");
    Console.WriteLine($"{n01} nota(s) de R$ 1,00");
  }
}