using System;

namespace OnionArchitecture.Domain.Entities.ValueObjects
{
    public class Name
    {
        public Name() { }

        public Name(string nome)
        {
            this.nome = nome;
        }

        public string nome { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is Name name &&
                   nome == name.nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nome);
        }

        public override string ToString()
        {
            return nome;
        }

        public static implicit operator Name(string nome)
            => Validate3Letters(nome);


        private static Name Validate3Letters(string nome)
        {
            if(nome.Length < 3)
            {
                throw new Exception("O nome precisa ser maior que 3");
            }

            return new Name(nome);
        }

    }
}