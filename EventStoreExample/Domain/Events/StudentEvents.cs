using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Events
{
    public class StudentCreatedEvent : IEvent
    {
        public StudentCreatedEvent(Guid guid, string name, int age, string registrationCode, List<Subject> subjects)
        {
            Guid = guid;
            Name = name;
            Age = age;
            RegistrationCode = registrationCode;
            Subjects = subjects;
        }

        public List<Subject> Subjects { get; set; }
        public string Name { get; }
        public int Age { get; }
        public string RegistrationCode { get; }
        public Guid Guid { get; set; }
    }
}