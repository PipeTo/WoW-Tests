using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WoW.Data;
using WoW.Data.Models;
using WoW.Data.Models.Relations;

namespace WoW.Service
{
    public class LanguageService : ILanguagesService
    {
        private readonly ApplicationDbContext _db;

        public LanguageService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddBook(Book book, int? languageId)
        {
            book.Languages = new List<LanguagesBooks>
            {
                new LanguagesBooks{LanguageId = languageId .GetValueOrDefault(),BookId = book.Id}
            };
            await _db.AddAsync(book);
            await _db.SaveChangesAsync();
        }

        public async Task AddVideo(Video video, int? languageId)
        {
            video.Languages=new List<LanguageVideo>
            {
                new LanguageVideo{LanguageId = languageId .GetValueOrDefault(),VideoId = video.Id}
            };
            await _db.AddAsync(video);
            await _db.SaveChangesAsync();
        }

        

        //Ovde ke ja napravime srednata tabela vo kontrolerot za proba :)
        public async Task CreateAsync(Language languege)
        {
            await _db.AddAsync(languege);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int? languageId)
        {
            var language = GetAllById(languageId);
            _db.Remove(language);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<Book> GetAllBookFromThisLanguage(int? laguageId)
        {
            return _db.Books
                .Include(x => x.Languages)
                .ThenInclude(a => a.Language.Id == laguageId);
        }

        public IEnumerable<Language> GetAllByFrameworkId(int? frameworkId)
        {
            var k = _db.Languages
                .Include(x => x.Frameworks)
                .ThenInclude(a => a.Framework)
                .Where(a => a.Frameworks
                    .Any(x => x.Framework.Id == frameworkId));
            return k;
        }

        public IEnumerable<Language> GetAllById(int? id)
        {
            return _db.Languages.Where(x=>x.Id==id);
        }

        public IEnumerable<Language> GetAllLanguages()
        {
            return _db.Languages;
        }

        public IEnumerable<Video> GetAllVideoFromThisLanguage(int? laguageId)
        {
            return _db.Videos
                .Include(x => x.Languages)
                .ThenInclude(x => x.Language.Id == laguageId);
        }

        public Task Update(Language language)
        {
            _db.Update(language);
            _db.SaveChangesAsync();
            return Task.CompletedTask;
        }

        public Task UpdateProgrss()
        {
            throw new NotImplementedException();
        }
        public float CalculateLanguageProcess(int? languageId)
        {
            throw new NotImplementedException();
        }
    }
}
