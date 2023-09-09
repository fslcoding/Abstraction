using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("This program will illustrate the difference between abstraction and encapsulation");

    //This creates an instance of the mobile class initialising a number of isntance variables with values shown
    mobile newMobile = new mobile("Apple","Iphone 11 Pro Max",1000,1000,25.5, 25.5);
   
   
    Console.WriteLine("The cost of this mobile is £{0} ", newMobile.CostPerMonth);
    Console.WriteLine("How much additional credit would you like to add?");
    int additionalCredit = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Current balance is £{0}", newMobile.Credit);
    
    //This is an example of abstraction, where the details of how additional credit is added is hidden from the main program through the method handle
    newMobile.addCredit(additionalCredit);
    Console.WriteLine("Current balance is £{0}", newMobile.Credit);

  }

}
