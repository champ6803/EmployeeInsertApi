using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeInsertApi.Libraries;
using EmployeeInsertApi.Models;

namespace EmployeeInsertApi.Helper
{
    public class EmployeeHelper
    {
          public async Task<Profile> InsertEmployee(Profile p)
        {
            return await new EmployeeLibrary().InsertEmployee(p);
        }
    }
}