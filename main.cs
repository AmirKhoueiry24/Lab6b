using System;
using System.Linq;
class Program {
  public static void Main (string[] args) {
  
int[] odd = {1,3,5,7,9};

Array.Reverse(odd);

Console.WriteLine("Odd Numbers");

Console.WriteLine(odd[0]);
Console.WriteLine(odd[1]);
Console.WriteLine(odd[2]);
Console.WriteLine(odd[3]);
Console.WriteLine(odd[4]);

double Sum1 = odd.Sum();
    Console.WriteLine("The sum for the Odd numbers is " + Sum1);
 
int[] even = {2,4,6,8,10};

Console.WriteLine("Even Numbers");

Console.WriteLine(even[0]);
Console.WriteLine(even[1]);
Console.WriteLine(even[2]);
Console.WriteLine(even[3]);
Console.WriteLine(even[4]);

double Sum =even.Sum();
      Console.WriteLine("The sum for the Even numbers is " + Sum);



  }
}