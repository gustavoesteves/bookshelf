﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Models.BookshelfViewModels
{
    public class BookAuthor
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
