namespace Library
{
    public class Patient : Person
    {
        // Herencia de la clase Person, ahora para el paciente. Abierta a extensión
        public byte Age {get;}
        public string Gender {get;}

        public Patient(string name, string id, string phoneNumber, byte age, string gender)
            : base(name, id, phoneNumber)
        {
            this.Age = age;
            this.Gender = gender;
        }
    }
}