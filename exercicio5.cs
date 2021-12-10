using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("N: ");
    string n = Console.ReadLine();
    Console.WriteLine("K: ");
    int k = Int32.Parse(Console.ReadLine());

    string[] ar = n.Split(",");

    for(int i = 0; i<ar.Length; i++){
      if(Int32.Parse(ar[i])<=k){
        Console.WriteLine(ar[i]);
      }
    }
  }
  //B = Não é possivel pois se é feita a ordenação, de um jeito ou de outro vai ter que percorrer a lista para ordenar.
}