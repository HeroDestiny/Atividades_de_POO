using System;

class MainClass {
  public static void Main (string[] args) {
    double salario, vendas, salario_bonus;
    string name;
    
    name = Console.ReadLine();
    salario = double.Parse(Console.ReadLine());
    vendas = double.Parse(Console.ReadLine());
    salario_bonus = salario + (vendas * 0.15);

    Console.WriteLine($"TOTAL = R$ {salario_bonus:0.00}");
  }
}
