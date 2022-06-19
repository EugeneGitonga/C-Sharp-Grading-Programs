using System;

class AwardPointsTwo
{
   static void Main(string[] args) 
   {
      int points;

      Console.Write("\nEnter the points the student got -> ");
      points = Convert.ToInt32(Console.ReadLine());

      switch(points)
      {
         case 4:
         case 3:
         case 2:Console.WriteLine("\nThe student passed.");
                break;
         case 1:Console.WriteLine("\nThe student failed");
                break;
         default:Console.WriteLine(points + " not valid! Points can only be between 1 and 4.\a\a\a");
                break;
      }
   
      Console.WriteLine("\nHave yourself a lovely day.");
   }
}