using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WoW.Data;
using WoW.Data.Models;
using WoW.Service;
using WoWWeb.Models;
using WoWWeb.Models.Home;

namespace WoWWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWoW _wayOfWorkService;

        public HomeController(IWoW wayOfWorkService)
        {
            _wayOfWorkService = wayOfWorkService;
        }


        public IActionResult Index()
        {
            Random random = new Random();
            
            var wowModels = _wayOfWorkService.GetAll();
            var listingModel = wowModels.Select(
                result => new WowIndexListingModel
                {
                    Id = result.Id,
                    Name = result.Name,
                    Description = result.Description,
                    Progress = random.Next(0, 100)//_wayOfWorkService.CalculateProgress(result.Id)
                });
            var model = new WowIndexModel()
            {
                Wows = listingModel
            };
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddWay(NewWayOfWorkModel model)
        {
            var way = BuildWay(model);

            await _wayOfWorkService.Create(way);

            return RedirectToAction("Index", way.Id);
        }

        private WayOfWork BuildWay(NewWayOfWorkModel model)
        {
            return new WayOfWork
            {
                Name = model.Name,
                Description = model.Description,
                Progress = model.Progress
            };
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            else
            {
              await  _wayOfWorkService.Delete(id);
                return RedirectToAction("Index");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
