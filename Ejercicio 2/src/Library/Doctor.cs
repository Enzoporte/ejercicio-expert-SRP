namespace Library
{
    public class Doctor : Person
    {
        // Herencia de la clase Person, pero se le agrega especialidad al doctor
        // De este modo, si se le quiere agregar más datos al doctor, no tenes que cambiar más que la clase doctor
        public string Especialidad {get;}

        public Doctor(string name, string id, string phoneNumber, string especialidad)
            : base(name, id, phoneNumber)
        {
            this.Especialidad = especialidad;
        }
    }
}