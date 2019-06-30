using System;
using System.ComponentModel.DataAnnotations;

namespace MyHealthTracker.Data
{
    public class Health
    {
        [Key]
        public int RecordId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public int Weight { get; set; }

        [Display(Name = "Height in Feet")]
        public int HeightFeet { get; set; }

        [Display(Name = "Height in Inches")]
        public int HeightInches { get; set; }

        [Display(Name = "BMI Calculator")]
        public decimal BMI { get; set; }

        [Display(Name = "Date of Last Physical")]
        public DateTime PhysicalDate { get; set; }

        [Display(Name = "Date of Last Dr's Appointment")]
        public DateTime DrAppt { get; set; }

        [Display(Name = "Dr's Name")]
        public string DrName { get; set; }

        public string Medications { get; set; }

        public string Illnesses { get; set; }

        public string Immunizations { get; set; }

        [Display(Name = "How many days do you exercise weekly?")]
        public decimal DaysExercised { get; set; }

        [Display(Name = "How many hours do you exercise weekly?")]
        public decimal HoursExercised { get; set; }

        [Display(Name = "How many hours do you sleep daily?")]
        public decimal HrsSleep { get; set; }               
    }
}
