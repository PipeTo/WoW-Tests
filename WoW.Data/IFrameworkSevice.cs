using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WoW.Data.Models;
using WoW.Data.Models.Relations;

namespace WoW.Data
{
    public interface IFrameworkSevice
    {
       IEnumerable<Framework> GetAll();
       IEnumerable<Framework> GetAllByWayId(int? id);
       Framework GetById(int id);
       float CalculateProgress(int id);

       Task Create(Framework framework, int? wayOfWorkId);
       Task Delete(int wayId);
       Task Update(Framework way);

    }
}
