using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class Request
    {
        public int RequestId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public string Rstatus { get; set; }
        public int? ApprovedBy { get; set; }
        public string RequestToken { get; set; }

        public virtual Administrator ApprovedByNavigation { get; set; }
        public virtual Book Book { get; set; }
        public virtual LibraryUser User { get; set; }
    }
}
