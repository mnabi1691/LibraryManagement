using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class Book
    {
        public Book()
        {
            Request = new HashSet<Request>();
        }

        public int BookId { get; set; }
        public string Tittle { get; set; }
        public string BookType { get; set; }
        public string BookDescription { get; set; }
        public int? AuthId { get; set; }
        public int? PubId { get; set; }
        public string BookStatus { get; set; }

        public virtual Author Auth { get; set; }
        public virtual Publisher Pub { get; set; }
        public virtual ICollection<Request> Request { get; set; }
    }
}
