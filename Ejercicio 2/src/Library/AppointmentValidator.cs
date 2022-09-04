using System;
using System.Reflection;
using System.Text;

namespace Library
{
    public class AppointmentValidator
    {
        // En esta clase, creo el validador de la consulta. Verificará todas las propiedades de la consulta si no son vacías o nulas.
        // AppointmentIssue guardará los problemas encontrados
        // IsAppointmentValid devolverá false o verdadero dependiendo de si la consulta devuelve un string con problemas o no respectivamente.

        public static string AppointmentIssue(MedicalAppointment appointment)
        {
            //StringBuilder IssuesBuilder = new StringBuilder("Issues Found:\n");
            //var isValid = true;
            foreach (String prop in appointment.AppointmentData)
            {
                if (string.IsNullOrEmpty(prop))
                {
                    //IssuesBuilder.Append($"Unable to schedule appointment. Missing {}.\n");
                    //isValid = false;
                    return "One or more parameters from the Appointment are missing!";
                }
                
            }
            return "";

            //return IssuesBuilder.ToString();
        }
        
        public static bool IsAppointmentValid(MedicalAppointment appointment)
        {
            return string.IsNullOrEmpty(AppointmentIssue(appointment));
        }

        
    }
}