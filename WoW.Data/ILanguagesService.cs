using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WoW.Data.Models;

namespace WoW.Data
{
    public interface ILanguagesService
    {
        IEnumerable<Language> GetAllLanguages();
        IEnumerable<Language> GetAllById(int? id);
        IEnumerable<Language> GetAllByFrameworkId(int? frameworkId);
        float CalculateLanguageProcess(int? languageId);
        IEnumerable<Book> GetAllBookFromThisLanguage(int? laguageId);
        IEnumerable<Video> GetAllVideoFromThisLanguage(int? laguageId);


        //ovie dva taskoj mozi da se povikaat od nivnite interfaceServices no za vezbajne ke gi kreirame i tuka 
        Task AddVideo(Video video,int? languageId);
        Task AddBook(Book book, int?languageId);
        Task UpdateProgrss();
        Task CreateAsync(Language languege);
        Task DeleteAsync(int? languageId);
        Task Update(Language language);
    }
}
