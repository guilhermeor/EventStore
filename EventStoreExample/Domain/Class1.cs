using Domain.Interfaces;

namespace Domain
{
    public class Student : IEntity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string RegistrationCode { get; set; }
    }
}
