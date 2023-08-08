using DataAccsess.Layer.Entitys;
using DataAccsess.Layer.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Layer.Contrete
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext context;

        public BookRepository(BookDbContext _context)
        {
            context= _context;
        }
        public async Task<Book> BookGetId(int id)
        {
           // throw new NotImplementedException();
           var book1=await context.Books.FirstOrDefaultAsync(x => x.Id == id);
           return book1;
            
        }

        public async Task<Book> CreateBook(Book book)
        {
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();

            return book;

        }

        public async Task<Book> DeleteBook(int id)
        {
            var a=await context.Books.FirstOrDefaultAsync(x => x.Id ==id);
            context.Books.Remove(a);
            await context.SaveChangesAsync();
            return a;

        }

        public async Task<Book> GetBookById()
        {
            var a2= await context.Books.ToListAsync();
            return a2;
           
        }

        public async Task<Book> UpdateBook(Book book)
        {
            //DEĞİŞMİYOR 
            await context.Books.FirstOrDefaultAsync(x => x.Id==book.Id);
            book.Title= book.Title;
            book.Description= book.Description;
            book.Price= book.Price;
            await context.SaveChangesAsync();
            return book;

        }

        


    }
}
