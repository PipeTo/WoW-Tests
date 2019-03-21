using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WoW.Data;
using WoW.Data.Models;
using WoWWeb.Models.Framework;

namespace WoWWeb.Controllers
{
    public class FrameworkController : Controller
    {
        private readonly IFrameworkSevice _frameworkSevice;
        private readonly IWoW _wayOfWorkService;

        public FrameworkController(IFrameworkSevice frameworkSevice, IWoW wayOfWorkService)
        {
            _frameworkSevice = frameworkSevice;
            _wayOfWorkService = wayOfWorkService;
        }


        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                Random r = new Random();
                
                var frameworks = _frameworkSevice.GetAllByWayId(id);
                var listingModel = frameworks.Select(
                    fra => new FrameworkListingModel
                    {
                        Id = fra.Id,
                        Name = fra.Name,
                        Description = fra.Description,
                        Progress = r.Next(0,100),//_frameworkSevice.CalculateProgress(fra.Id),
                        WhenYouStart = fra.WhenYouStartToLearn


                    });
                var model = new FrameworkIndexModel
                {
                    FrameworksIndex = listingModel,
                    WayId = id,
                    WayOfWorkName = _wayOfWorkService.GetById(id).Name


                };
                return View(model);
            }
            else
            {

                return NotFound();
            }

        }

        public IActionResult Create(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var wayOfWork = _wayOfWorkService.GetById(id);
                var model = new NewFrameworkModel
                {
                    WayOfWorkName = wayOfWork.Name,
                    WayId = wayOfWork.Id
                };
                return View(model);
            }

        }
        [HttpPost]
        public async Task<IActionResult> AddFramework(NewFrameworkModel model)
        {
            if (model == null)
            {
                return NotFound();
            }
            else
            {

                var framework = BuildWay(model , model.WayId);

                await _frameworkSevice.Create(framework,model.WayId);
                return RedirectToAction("Index", new{ id= model.WayId });
            }
            
        }

        private Framework BuildWay(NewFrameworkModel model,int? id)
        {
            return new Framework
            {
                Name = model.Name,
                Description = model.Description,
                WhenYouStartToLearn = DateTime.UtcNow,
                Progress = 5,//_frameworkSevice.CalculateProgress(model.Id),
                //WayOfWorks = _frameworkSevice.GetWayOfWorksById(id)
            };
        }
    }
}