using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeInsertApi.Models;
using EmployeeInsertApi.DAL;

namespace EmployeeInsertApi.Libraries
{
    public class EmployeeLibrary
    {
        EmployeeDAL emdal = new EmployeeDAL();
        
        public async Task<Profile> InsertEmployee(Profile p)
        {
            Profile pro = new Profile();
            pro.email = p.email;
            pro.location =p.location;
            pro.position = p.position;
            pro.salary = p.salary;
            await emdal.UpdateEmployee(pro);
            return pro;
        }
    }
}