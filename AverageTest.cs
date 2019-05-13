/******************************

AverageTest class
by Jhoset
  -----------JA10-------------

*******************************/

using System;

namespace MyProgram {

  public class AverageTest {

      public static void Main(string[] args) {

        // Outputs empty line.
        Console.WriteLine("");
        // Outputs to the console.
        Console.WriteLine("############### Running Program #################");
        // Outputs emtpy line.
        Console.WriteLine("");

        // Builds object from the class AverageTwo.
        // Constructor takes no parameters.
        AverageTwo aObj = new AverageTwo();

        // Initializes array.
        int[] average = new int[5];
        // Declares loop control variable.
        int control;

        // Prompts user.
        Console.Write("Enter -1 to quit program: ");
        // Stores input in the vairable control.
        control = Convert.ToInt32(Console.ReadLine());
        // Outputs empty line.
        Console.WriteLine("");

        // Builds sentinel while loop.
        while(control != -1) {

          // Prompts user about grades.
          Console.Write("Enter first grade: ");
          // Stores input in the the array average.
          average[0] = Convert.ToInt32(Console.ReadLine());
          // Outputs empty line.
          Console.WriteLine("");

          Console.Write("Enter second grade: ");
          average[1] = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("");

          Console.Write("Enter third grade: ");
          average[2] = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("");

          Console.Write("Enter fourth grade: ");
          average[3] = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("");

          Console.Write("Enter number of grades: ");
          average[4] = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("");

          // Method call
          // using object name.
          // Takes two paramters.
          aObj.SetIntegers(10, 10);

          // Method call
          // using object name.
          // Takes one parameter.
          aObj.OutputAverage(average);

          // Method call
          // using object name.
          // Takes no parameters.
          Console.WriteLine(aObj.GetIntegers());

          // Prompts user.
          Console.Write("Enter -1 to quit program: ");
          // Stores input in the variable control.
          control = Convert.ToInt32(Console.ReadLine());
          // Outputs empty line.
          Console.WriteLine("");

        }

        // Outputs empty line.
        Console.WriteLine("");
        // Outputs to the console.
        Console.WriteLine("################## Exiting Program #################");
        // Outputs empty line.
        Console.WriteLine("");

        // Allows user to enter any
        // key to exit program.
        Console.ReadKey();

      }

    }

}
