using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class Administrator
    {
        public Administrator()
        {
            LibraryUser = new HashSet<LibraryUser>();
            Request = new HashSet<Request>();
        }

        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nidno { get; set; }
        public string PassportNo { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string HomeAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Uname { get; set; }
        public string Upassword { get; set; }
        public string AccountStatus { get; set; }
        public int AdminLevel { get; set; }

        public virtual ICollection<LibraryUser> LibraryUser { get; set; }
        public virtual ICollection<Request> Request { get; set; }
    }
}
