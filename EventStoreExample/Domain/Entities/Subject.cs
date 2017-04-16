using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    class Subject
    {
        public string Name { get; private set; }
        public double Grade { get; private set; }
        public char LetterGrade => ComputeLetterGrade(Grade);

        private char ComputeLetterGrade(double grade)
        {
            if (grade >= 9)
                return 'A';
            else if (grade >= 7.5)
                return 'B';
            else if (grade >= 6)
                return 'C';
            else
                return 'D';
        }
    }
}
