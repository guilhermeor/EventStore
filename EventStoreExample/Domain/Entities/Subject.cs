﻿using System.Collections.Generic;
using System.Linq;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class Subject
    {
        public string Name { get; private set; }
        public double Grade { get; private set; }
        public char LetterGrade => ComputeLetterGrade(Grade);

        internal char ComputeLetterGrade(double grade)
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

        #region Commands

        internal Subject(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public static Subject Create(string name, double grade)
        {
            return new Subject(name, grade);
        }
        #endregion

        #region Queries

        #endregion
    }
}
