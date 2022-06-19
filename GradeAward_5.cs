using System;

class AwardSwitchTwo
{
   static void Main(string[] args) 
   {
      char grade;

      Console.Write("\nEnter the grade the student got -> ");
      grade = Convert.ToChar(Console.ReadLine());

      switch(Char.ToUpper(grade)) //Note the difference compared to string
      {
         case 'A':Console.WriteLine("\nThe student got a Distinction.");
                break;
         case 'B':
         case 'C':Console.WriteLine("\nThe student got a Credit.");
                break;
         case 'D':Console.WriteLine("\nThe student got a Pass.");
                break;
         case 'E':Console.WriteLine("\nThe student got a Fail");
                break;
         default:Console.WriteLine(grade + " is not a valid grade!\a\a\a");
                break;
      }
   
      Console.WriteLine("\nHave yourself a lovely day.");
   }
}