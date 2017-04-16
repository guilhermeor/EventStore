using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    class Student : IEntity
    {    
        public int Id { get; private set; } 
        public string Name { get; private set; } 
        public int Age { get; private set; } 
        public string RegistrationCode { get; set; }
        public IList<Subject> Subjects { get; set; }
        public bool Approved => ComputeApproval(Subjects);

        private bool ComputeApproval(IList<Subject> subjects)
        {
            return !subjects.Any(x => x.LetterGrade.Equals('D'));
        }
    }
}
