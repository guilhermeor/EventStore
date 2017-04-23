using System;
using Domain.Interfaces;
using System.Collections.Generic;
using Domain.Events;

namespace Domain.Entities
{
    public class Student : IEntity
    {    
        public int Id { get; private set; } 
        public string Name { get; private set; } 
        public int Age { get; private set; } 
        public string RegistrationCode { get; private set; }
        public IEnumerable<Subject> Subjects { get; private set; }
        public bool Approved => ComputeApproval(Subjects);

        internal bool ComputeApproval(IEnumerable<Subject> subjects)
        {
            return subjects.None(x=>x.LetterGrade.Equals('D'));
        }

        #region Commands

        internal Student(string name, int age, string registrationCode, IEnumerable<Subject> subjects)
        {
            Name = name;
            Age = age;
            RegistrationCode = registrationCode;
            Subjects = subjects;
        }

        public static Student Create(string name, int age, string registrationCode, IEnumerable<Subject> subjects)
        {
            return new Student(name, age, registrationCode, subjects);
        }
        #endregion

        #region Queries

        #endregion

    }


}
