using System;
using Library;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            Patient pacienteEnzo = new Patient("Enzo Cantoni", "5432184-0", "999-999-999", 19, "Hombre");
            Patient pacientePaula = new Patient("Paula Jhonson", "986782342", "5555-555-555", 45, "Mujer");
            Patient pacienteLaurita = new Patient("NPC Laurita", "", "", 20, "Mujer");
            Doctor doctorCarlito = new Doctor("Carlito", "123123123", "999-999-999", "Fisioterapeuta");
            string hospitalBritanico = "Hospital Britanico";

            MedicalAppointment appointmentEnzo = new MedicalAppointment(pacienteEnzo, doctorCarlito, DateTime.Now, hospitalBritanico);
            MedicalAppointment appointmentPaula = new MedicalAppointment(pacientePaula, doctorCarlito, DateTime.Now, hospitalBritanico);
            MedicalAppointment appointmentLaurita = new MedicalAppointment(pacienteLaurita, doctorCarlito, DateTime.Now, hospitalBritanico);

            AppoinmentPrinter.PrintAppointment(appointmentEnzo);
            AppoinmentPrinter.PrintAppointment(appointmentPaula);
            AppoinmentPrinter.PrintAppointment(appointmentLaurita);
        }

        
        
        /* static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
        }
        */
    }
}
