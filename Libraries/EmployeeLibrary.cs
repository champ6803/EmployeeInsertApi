using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeInsertApi.Models;

namespace EmployeeInsertApi.Libraries
{
    public class EmployeeLibrary
    {
        EmployeeDAL emdal = new EmployeeDAL();
        
        public async Task<Profile> InsertEmployee(Profile p)
        {
            Profile pro = new Profile();
            var em = await emdal.UpdateEmployee(p);
            return pro;
        }
    }
}