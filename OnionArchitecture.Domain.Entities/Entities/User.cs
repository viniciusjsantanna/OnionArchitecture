using OnionArchitecture.Domain.Entities.ValueObjects;

namespace OnionArchitecture.Domain.Entities.Entities
{
    public class User
    {
        public Name Name { get; set; }
        public string Cpf { get; set; }
    }
}
