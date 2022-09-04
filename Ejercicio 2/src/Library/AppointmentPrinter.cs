using System;

namespace Library
{
    public class AppoinmentPrinter
    {

        public static void PrintAppointment(MedicalAppointment appointment)
        {
            if (AppointmentValidator.IsAppointmentValid(appointment))
            {
                Console.WriteLine(appointment.ToString());
                return;    
            }
            
            Console.WriteLine(AppointmentValidator.AppointmentIssue(appointment));
        }
    }
}