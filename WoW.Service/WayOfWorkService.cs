using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WoW.Data;
using WoW.Data.Models;

namespace WoW.Service
{
    public class WayOfWorkService:IWoW
    {
        private readonly ApplicationDbContext _db;

        public WayOfWorkService(ApplicationDbContext db)
        {
            _db = db;
        }   

        public WayOfWork GetById(int? id)
        {
            return _db.WayOfWorks.Find(id);
        }

        public IEnumerable<WayOfWork> GetAll()
        {
            
            return _db.WayOfWorks
                .Include(x => x.Frameworks)
                .ThenInclude(x => x.Framework);
        }

        public IEnumerable<Framework> GetAllFrameworksId(int id)
        {
            var result = _db.Frameworks
                .Include(x => x.WayOfWorks)
                .ThenInclude(x => x.WayOfWork)
                .Where(x=>x.WayOfWorks.Any(a=>a.WayOfWork.Id==id));
            return result;
            
        }

        public float CalculateProgress(int id)
        {
            float res=0;
            
            List<Framework>frameworks = GetAllFrameworksId(id).ToList();
            if (frameworks.Count == 0)
            {
                return res;
            }
            else
            {
                foreach (var fra in frameworks)
                {
                    res += fra.Progress;
                }

                res /= frameworks.Count;
                return res;
            }
           
        }

        public async Task Create(WayOfWork way)
        {
            _db.Add(way);
            await _db.SaveChangesAsync();
        }

        //It need to be changed it not remove data from related tables 
        public async Task Delete(int? wayId)
        {

            _db.Remove(GetById(wayId));
            await _db.SaveChangesAsync();
        }

        public async Task Update( WayOfWork way)
        {
            _db.Update(way);
            await _db.SaveChangesAsync();
        }
        
    }
}
