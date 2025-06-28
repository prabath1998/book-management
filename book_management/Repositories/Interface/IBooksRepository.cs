using book_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_management.Repositories.Interface
{
   public interface IBooksRepository
    {
        public void AddBook(Book book);

        public List<Book> GetAllBooks();
    }
}
