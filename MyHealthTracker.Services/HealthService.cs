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

        public bool CreateHealthRecord(HealthCreate model)
        {
            using (var ctx = new Models.DbContext())
            {
                HealthRecord healthRecord = new HealthRecord()
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
        public IEnumerable<HealthListItem> GetHealthRecord()
        {
            using (var ctx = new Models.DbContext())
            {
                var query =
                    ctx
                    .HealthRecords
                    .Where(e => e.UserId == _userId)
                    .Select(
                        e =>
                        new HealthListItem
                        {
                            RecordId = e.RecordId,
                            UserId = e.UserId,
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            DateOfBirth = e.DateOfBirth,
                            Age = e.Age,
                            Weight = e.Weight,
                            HeightFeet = e.HeightFeet,
                            HeightInches = e.HeightInches,
                            BMI = e.BMI,
                            PhysicalDate = e.PhysicalDate,
                            DrAppt = e.DrAppt,
                            DrName = e.DrName,
                            Medications = e.Medications,
                            Illnesses = e.Illnesses,
                            Immunizations = e.Immunizations,
                            DaysExercised = e.DaysExercised,
                            HoursExercised = e.HoursExercised,
                            HrsSleep = e.HrsSleep,
                        }
                        );
                return query.ToArray();
            }
        }
        public HealthDetail GetHealthRecordbyId(int recordId)
        {
            using (var ctx = new Models.DbContext())
            {
                var entity =
                    ctx
                    .HealthRecords
                    .Single(e => e.RecordId == recordId && e.UserId == _userId);
                return
                    new HealthDetail
                    {
                        RecordId = entity.RecordId,
                        UserId = entity.UserId,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        DateOfBirth = entity.DateOfBirth,
                        Age = entity.Age,
                        Weight = entity.Weight,
                        HeightFeet = entity.HeightFeet,
                        HeightInches = entity.HeightInches,
                        BMI = entity.BMI,
                        PhysicalDate = entity.PhysicalDate,
                        DrAppt = entity.DrAppt,
                        DrName = entity.DrName,
                        Medications = entity.Medications,
                        Illnesses = entity.Illnesses,
                        Immunizations = entity.Immunizations,
                        DaysExercised = entity.DaysExercised,
                        HoursExercised = entity.HoursExercised,
                        HrsSleep = entity.HrsSleep,
                    };
            }
        }
        public bool UpdateHealthRecord(HealthEdit model)
        {
            using (var ctx = new Models.DbContext())
            {
                var entity =
                    ctx
                    .HealthRecords
                    .Single(e => e.RecordId == model.RecordId && e.UserId == _userId);
                entity.RecordId = model.RecordId;
                entity.UserId = model.UserId;
                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.DateOfBirth = model.DateOfBirth;
                entity.Age = model.Age;
                entity.Weight = model.Weight;
                entity.HeightFeet = model.HeightFeet;
                entity.HeightInches = model.HeightInches;
                entity.BMI = model.BMI;
                entity.PhysicalDate = model.PhysicalDate;
                entity.DrAppt = model.DrAppt;
                entity.DrName = model.DrName;
                entity.Medications = model.Medications;
                entity.Illnesses = model.Illnesses;
                entity.Immunizations = model.Immunizations;
                entity.DaysExercised = model.DaysExercised;
                entity.HoursExercised = model.HoursExercised;
                entity.HrsSleep = model.HrsSleep;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteHealthRecord(int recordId)
        {
            using (var ctx = new Models.DbContext())
            {
                var entity =
                    ctx
                    .HealthRecords
                    .Single(e => e.RecordId == recordId && e.UserId == _userId);

                ctx.HealthRecords.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
