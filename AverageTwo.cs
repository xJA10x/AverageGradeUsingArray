/***************************************

AverageTwo class
by Jhoset
----------- JA10 ----------------

 ****************************************/

using System;

namespace MyProgram {

  // Builds class
  // inherits from the Average class
  // in order to have access to variables and methods.
  class AverageTwo: Average {

    // Declares private variables.
    private int x;
    private int y;

    // Builds method.
    // Takes two parameters,
    // global variables x and y.
    // Set() method.
    public void SetIntegers(int x, int y) {

      // Stores input in the variable x.
      this.x = x;
      // Stores input in the variable y.
      this.y = y;

    }

    // Builds method.
    // Takes no parameters,
    // Get() method.
    public int GetIntegers() {

      // Returns sum.
      return x + y;

    }

    // Builds method
    // Takes one parameter,
    // array average in the main class.
    public void OutputAverage(int[] average) {

      // Outputs to the console.
      Console.WriteLine("First grade: " + average[0]);
      Console.WriteLine("Second grade: " + average[1]);
      Console.WriteLine("Third grade: " + average[2]);
      Console.WriteLine("Fourth grade: " + average[3]);
      Console.WriteLine("Number of grades: " + average[4]);
      // Method call.
      // Takes one parameter.
      Console.WriteLine("Average grade: " + AverageGrade(average));

    }

  }

}
