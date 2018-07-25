using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeInsertApi.Helper;
using EmployeeInsertApi.Models;
using Microsoft.AspNetCore.Cors;

namespace EmployeeInsertApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeHelper emHelp = new EmployeeHelper();
        
         [HttpPost("/insert")]
        public async Task<Profile> InsertEmployee(Profile p)
        {
            var em = emHelp.InsertEmployee(p);
            return await em;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
