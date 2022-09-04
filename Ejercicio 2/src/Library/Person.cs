namespace Library 
{
    public class Person
    {
        // Creando esta clase persona, si alguna funcionalidad quiere ser agregada para Patient o Doctor
        // Modificando person, no tengo que cambiar Patient Y Doctor. Y si quisiera agregar otra clase como
        // "Asistente" o "Padres", no necesito copiar el nombre, cedula y numero para cada nueva clase

        public string Name {get;}
        public string Id {get;}
        public string PhoneNumber {get;}

        public Person(string name, string id, string phoneNumber)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
        }
    }
}