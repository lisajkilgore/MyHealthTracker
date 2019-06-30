using Microsoft.EntityFrameworkCore;
using MyHealthTracker.Data;
using MyHealthTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthTracker.Services
{
    public class HealthService
    {
        private readonly Guid _userId;

        public HealthService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateHealthRecord(HealthCrud model)
        {
            using (var ctx = new Models.DbContext())
            {
                var healthRecord = new HealthRecord()
                {
                    RecordId = model.RecordId,
                    UserId = model.UserId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DateOfBirth = model.DateOfBirth,
                    Age = model.Age,
                    Weight = model.Weight,
                    HeightFeet = model.HeightFeet,
                    HeightInches = model.HeightInches,
                    BMI = model.BMI,
                    PhysicalDate = model.PhysicalDate,
                    DrAppt = model.DrAppt,
                    DrName = model.DrName,
                    Medications = model.Medications,
                    Illnesses = model.Illnesses,
                    Immunizations = model.Immunizations,
                    DaysExercised = model.DaysExercised,
                    HoursExercised = model.HoursExercised,
                    HrsSleep = model.HrsSleep,
                };
                ctx.HealthRecords.Add(healthRecord);
                return ctx.SaveChanges() == 1; 

            }
        }

    }
}

