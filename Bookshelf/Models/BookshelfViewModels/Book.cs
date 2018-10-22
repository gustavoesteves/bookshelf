using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Models.BookshelfViewModels
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string LongTitle { get; set; }
        public string ISBN { get; set; }
        public string ISBN13 { get; set; }
        public string Format { get; set; }
        public string Language { get; set; }
        public DateTime DatePublished { get; set; }
        public string Edition { get; set; }
        public int Pages { get; set; }
        public string Dimensions { get; set; }
        public string Overview { get; set; }
        public string Synopsys { get; set; }

        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }

        public virtual ICollection<BookUser> UserBooks { get; set; }
    }
}
