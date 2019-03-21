using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WoW.Data;
using WoW.Data.Models;
using WoW.Data.Models.Relations;
using WoWWeb.Models.Framework;
using WoWWeb.Models.Language;

namespace WoWWeb.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ILanguagesService _languagesService;
        private readonly IFrameworkSevice _frameworkService;

        public LanguageController(ILanguagesService languagesService,IFrameworkSevice frameworkService)
        {
            _languagesService = languagesService;
            _frameworkService = frameworkService;
        }

        public IActionResult Index(int?id)
        {
            if (id==null)
            {
                return RedirectToAction("Index", "Home");
            }
            var listingLanguages = _languagesService.GetAllByFrameworkId(id);
            
            //ova da se sredi ne e voopsto sredeno najdi dali e prazno  isredi gi id-nata
            if (listingLanguages.DefaultIfEmpty(null) == null)
            {
                return RedirectToAction("Create", new {id = id});
            }

            
            var listingModel = listingLanguages.Select(x => new LanguageListingModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Documentation = x.Documentation,
                Tutorials = x.Tutorials,
                Version = x.Version,
                Progress = x.Progress
            });
            var model = new LangiageIndexModel
            {
                LanguageListingModel = listingModel,
                FrameworkName = _frameworkService.GetById(id.Value).Name,
                FrameworkId = id.Value

            };
            return View(model);
        }

        public IActionResult Create(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var framework = _frameworkService.GetById(id.GetValueOrDefault());
                var model = new NewLanguageModel
                {
                    FrameworkId = id.GetValueOrDefault()
                };
                return View(model);
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> AddLanguage(NewLanguageModel model)
        {
            if (model == null)
            {
                return NotFound();
            }
            else
            {
                var language = BuildLanguage(model);

                await _languagesService.CreateAsync(language);
                return RedirectToAction("Index", new {id = model.FrameworkId});
            }
        }

        private Language BuildLanguage(NewLanguageModel model)
        {
            return new Language
            {
                Name = model.Name,
                Description = model.Description,
                Documentation = model.Documentation,
                Version = model.Version,
                Tutorials = model.Tutorials,
                WhenYouFinish = DateTime.UtcNow,
                Frameworks = new List<FrameworkLanguage>{new FrameworkLanguage { FrameworkId = model.FrameworkId, LanguageId = model.Id}}
            };
        }
    }
}