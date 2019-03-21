using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WoW.Data.Models;

namespace WoW.Data
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetAllByLanguageId(int? id);
        IEnumerable<Book> GetAllByFrameworkId(int? id);
        IEnumerable<Book> GetAllByRelatedTecId(int? id);

        Task Create(Book book);
        Task UpdateProgrss();
        Task Delete();
        Task Update();
    
}
}
