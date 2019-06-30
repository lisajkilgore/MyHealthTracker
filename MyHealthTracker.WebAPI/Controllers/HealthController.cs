using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHealthTracker.Data;
using MyHealthTracker.Models;

namespace MyHealthTracker.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        private readonly DbContext _context;

        public HealthController(DbContext context)
        {
            _context = context;

            if(_context.HealthRecords.Count() ==0)
            {
                // Create a new HealthItem if collection is empty,
                // which means you can't delete all HealthItems.
                _context.HealthRecords.Add(new HealthRecord { RecordId = 1 });
                _context.SaveChanges();
            }
        }
    }
}