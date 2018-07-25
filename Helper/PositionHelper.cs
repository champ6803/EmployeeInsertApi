using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeInsertApi.Libraries;
using EmployeeInsertApi.Models;

namespace EmployeeInsertApi.Helper
{
    public class PositionHelper
    {
        public async Task<IEnumerable<Position>> GetAll()
        {
            return await new PositionLibrary().GetAll();
        }

      
    }
}