using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WoW.Data.Models;

namespace WoW.Data
{
    public interface IWoW
    {
        WayOfWork GetById(int? id);
        IEnumerable<WayOfWork> GetAll();
        IEnumerable<Framework> GetAllFrameworksId(int id);
        float CalculateProgress(int id);

        Task Create(WayOfWork way);
        Task Delete(int? wayId);
        Task Update( WayOfWork way);
    }
}