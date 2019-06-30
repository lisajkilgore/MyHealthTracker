﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MyHealthTracker.Data
{
    public class Health
    {
        
        public int RecordId { get; set; }
        public Guid OwnerId { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int HeightFeet { get; set; }
        public int HeightInches { get; set; }
        public decimal BMI { get; set; }
        public DateTime PhysicalDate { get; set; }
        public DateTime DrAppt { get; set; }
        public string DrName { get; set; }
        public string Medications { get; set; }
        public string Illnesses { get; set; }
        public decimal DaysExercised { get; set; }
        public decimal HoursExercised { get; set; }
        public decimal HrsSleep { get; set; }               
    }
}
