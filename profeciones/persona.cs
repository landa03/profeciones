using System;

namespace Profecion
{
    abstract class Profecion
    {
        protected string name;
        protected string lastName;
        public string LastName
        {
            get => $"Mr. {lastName}" ;
            set => lastName = value;
        }
        public abstract void dimeProfecion();
        public string fullName()
        {
            return $"{this.name} {this.lastName}";
        }
    }
}
