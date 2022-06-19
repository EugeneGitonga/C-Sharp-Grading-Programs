using System;

class GradingOne
{
   static void Main(string[] args) 
   {
      double markOne, markTwo, markThree, average;
      char grade = 'X';

      Console.Write("\nEnter the mark scored in the first unit:> ");
      markOne = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the mark scored in the second unit:> ");
      markTwo = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the mark scored in the third unit:> ");
      markThree = Convert.ToDouble(Console.ReadLine());

      average = (markOne + markTwo + markThree) / 3;

      if (average >= 70)
         grade = 'A';
      else if (average >= 60)
         grade = 'B';
      else if (average >= 50)
         grade = 'C';
      else if (average >= 40)
         grade = 'D';
      else if (average >= 0)
         grade = 'E';

      Console.WriteLine("The average mark is " + average);
      Console.WriteLine("The grade obtained is " + grade + "\n");
   }
}