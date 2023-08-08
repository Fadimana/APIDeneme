using Business.Layer.Interface;
using DataAccsess.Layer;
using DataAccsess.Layer.Entitys;
using DataAccsess.Layer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Contrete
{
    public class BookBusinessServices : IBookBusinessServices1
    {
        private readonly IBookRepository _bookRepository; //Data kısmında ki verileri okuması için

        public BookBusinessServices(IBookRepository bookRepository)
        {
            _bookRepository= bookRepository;
        }

        public async Task<Book> CreateBook(Book book)
        {
            var cb = await _bookRepository.CreateBook(book);
            return cb;

        }

        public async Task<Book> DeleteBook(int ıd)
        {
            //throw new NotImplementedException();
            var d=await _bookRepository.DeleteBook(ıd);

            if (d == null) throw new Exception("Silinecek öge yok");
            return d;
            
        }
         
        public async Task<Book> GetById(int ıd)
        {
            var gb = await _bookRepository.BookGetId(ıd);

            if (gb == null) throw new Exception("User NULL");

            return gb;
        }

        public async Task<Book> GetBookById()
        {
            var gt = await _bookRepository.GetBookById();
            return gt;
        }

        public Task<Book> GetByName(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> UpdateBook(Book book)
        {
           var up=await _bookRepository.UpdateBook(book);

            if (up == null) throw new Exception("Güncellenecek değer yok");

           
            return up;
        }
    }
}
