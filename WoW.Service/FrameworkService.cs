using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WoW.Data;
using WoW.Data.Models;
using WoW.Data.Models.Relations;

namespace WoW.Service
{
    public class FrameworkService:IFrameworkSevice
    {
        private readonly ApplicationDbContext _db;

        public FrameworkService(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Framework> GetAll()
        {
            return _db.Frameworks;

        }

        public IEnumerable<Framework> GetAllByWayId(int? id)
        {
            if (id==null)
            {
                
                return null;
            }
            else
            {
                return _db.Frameworks
                    .Include(x => x.WayOfWorks)
                    .ThenInclude(a => a.WayOfWork)
                    .Where(a => a.WayOfWorks
                        .Any(x => x.WayOfWork.Id == id));

            }
        }

        public Framework GetById(int id)
        {
            return _db.Frameworks.FirstOrDefault(x => x.Id == id);
        }

       

        
        public async Task Create(Framework framework,int? wayOfWorkId)
        {
            framework.WayOfWorks = new List<WayOfWorkFramework>
            {
                new WayOfWorkFramework
                {
                    WayOfWorkId = wayOfWorkId.Value, FrameworkId = framework.Id
                }
            };
           
            await _db.AddAsync(framework);
            
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int wayId)
        {
            var framework = GetAllByWayId(wayId);
            _db.Remove(framework);
            await _db.SaveChangesAsync();
        }
        //pojma nemam zosto mi trebalo wayId koga ce mi tekni ce go napram
        public async Task Update(Framework way)
        {
            _db.Update(way);
            await _db.SaveChangesAsync();
        }
        public float CalculateProgress(int id)
        {
            throw new NotImplementedException();
        }
    }
}
