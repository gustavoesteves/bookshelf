using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Models.BookshelfViewModels
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
