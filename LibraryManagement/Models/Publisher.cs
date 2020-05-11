using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Book = new HashSet<Book>();
        }

        public int PublisherId { get; set; }
        public string PuilisherName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
