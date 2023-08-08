using DataAccsess.Layer.Entitys;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Interface
{

    public interface IBookBusinessServices1
    {
        Task<Book> GetById(int ıd);

        Task<Book> GetBookById();
        Task<Book> CreateBook(Book book);

        Task<Book> UpdateBook(Book book);

        Task<Book> DeleteBook(int ıd);
    }
}
