/**************************************

Average class
by Jhoset
------------------- JA10 ----------------

****************************************/

// Notes:
  // Average grade = (gradeOne + gradeTwo + gradeThree + numGrades)

  using System;

  namespace MyProgram {

    class Average {

      // Builds method.
      // Takes one parameter,
      // array average in the main class.
      public int AverageGrade(int[] average) {

        // Returns average grade.
        return (average[0] + average[1] + average[2] + average[3]) / average[4];

      }

    }

  }
