using System;

class MainClass {
  public static void Main (string[] args) {
    Circulo x;
    x = new Circulo();
    x.SetRaio(4);

    Console.WriteLine(x.AreaCirc());
    Console.WriteLine(x.CircufCirc());
  }

  class Circulo{
    private double raio;

    public void SetRaio(double r){
      if (r > 0) raio = r;
    }

    public double AreaCirc(){
      return (raio * raio) * 3.14;
    }
    
    public double CircufCirc(){
      return (2 * 3.14) * raio;
    }

  }
}