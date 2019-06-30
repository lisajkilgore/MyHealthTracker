using System;

namespace MyHealthTracker.Data
{
    public class HealthRecord
    {
     
        public int RecordId { get; set; }

        public Guid UserId { get; set; }

        [System.ComponentModel.DisplayName("First Name")]
        public string FirstName { get; set; }

        [System.ComponentModel.DisplayName("Last Name")]
        public string LastName { get; set; }

        [System.ComponentModel.DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public int Weight { get; set; }

        [System.ComponentModel.DisplayName("Height in Feet")]
        public int HeightFeet { get; set; }

        [System.ComponentModel.DisplayName("Height in Inches")]
        public int HeightInches { get; set; }

        [System.ComponentModel.DisplayName("BMI Calculator")]
        public decimal BMI { get; set; }

        [System.ComponentModel.DisplayName("Date of Last Physical")]
        public DateTime PhysicalDate { get; set; }

        [System.ComponentModel.DisplayName("Date of Last Dr's Appointment")]
        public DateTime DrAppt { get; set; }

        [System.ComponentModel.DisplayName("Dr's Name")]
        public string DrName { get; set; }

        public string Medications { get; set; }

        public string Illnesses { get; set; }

        public string Immunizations { get; set; }

        [System.ComponentModel.DisplayName("Days exercised weekly")]
        public decimal DaysExercised { get; set; }

        [System.ComponentModel.DisplayName("Hours exercised weekly")]
        public decimal HoursExercised { get; set; }

        [System.ComponentModel.DisplayName("Hours slept daily")]
        public decimal HrsSleep { get; set; }               
    }
}
