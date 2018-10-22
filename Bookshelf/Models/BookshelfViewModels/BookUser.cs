using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Models.BookshelfViewModels
{
    public class BookUser
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public bool Public { get; set; }

        public int BookId { get; set; }
        public virtual Book Books { get; set; }

        public string ApplicationUsersId { get; set; }
        public virtual ApplicationUser ApplicationUsers { get; set; }
    }
}
