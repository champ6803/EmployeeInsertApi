﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeInsertApi.Models;
using EmployeeInsertApi.Helper;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeInsertApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        EmployeeHelper emHeplp = new EmployeeHelper();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task UpdateEmployee(Profile p)
        {
            var result = await emHeplp.InsertEmployee(p);
            
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
