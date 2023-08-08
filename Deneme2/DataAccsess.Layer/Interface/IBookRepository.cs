using DataAccsess.Layer.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Layer.Interface
{
    public interface IBookRepository
    {
        Task<Book> BookGetId(int id);
        Task<Book> GetBookById();
        Task<Book> DeleteBook(int id);

        Task<Book> UpdateBook(Book book);
        Task<Book> CreateBook(Book book);

    }
}
