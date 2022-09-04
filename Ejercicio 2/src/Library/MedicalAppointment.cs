using System;
using System.Collections.Generic;

namespace Library
{
    // Armar la consulta. Armar la consulta sería el string que devolvería la función toString() 

    public class MedicalAppointment
    {
        private static int idCount;
        public Patient Patient {get;}
        public Doctor Doctor {get;}
        public string Id {get;}
        public DateTime Date {get; set;}
        public string AppoinmentPlace {get;}
        public String[] AppointmentData;
        
        public MedicalAppointment
        (Patient patient, Doctor doctor, DateTime date, string appoinmentPlace)
        {
            this.Patient = patient;
            this.Doctor = doctor;
            this.AppoinmentPlace = appoinmentPlace;
            this.Date = date;
            this.Id = "00" + idCount.ToString();

            idCount++;
            String[] tempData = {Patient.Name, Patient.Id, Patient.Age.ToString(), Patient.Gender, Patient.PhoneNumber, 
                                Doctor.Name, Doctor.Id, Doctor.Especialidad, Date.ToString(), AppoinmentPlace};
            this.AppointmentData = tempData;
        }

        public override string ToString()
        {
            return $@" 
                        --- Medical Appointment Status ---   {Date.ToString()}
            
            -> {AppoinmentPlace} / Appointment ID: {Id}

            - Patient Information
            Name: {Patient.Name}
            ID: {Patient.Id}
            Gender: {Patient.Gender}
            Age: {Patient.Age.ToString()}
            Phone: {Patient.PhoneNumber}
            
            - Doctor: 
            Name: {Doctor.Name}
            Specialty: {Doctor.Especialidad}

            ";
        }
        

    }
}