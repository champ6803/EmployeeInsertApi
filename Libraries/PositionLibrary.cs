using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeInsertApi.Models;

namespace EmployeeInsertApi.Libraries
{
    public class PositionLibrary
    {
        PositionDAL posdal = new PositionDAL();
        
        public async Task<IEnumerable<Position>> GetAll()
        {
            var all = await posdal.All();
            return all;
        }
    }
}