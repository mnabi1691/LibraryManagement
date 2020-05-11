using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class LibraryUser
    {
        public LibraryUser()
        {
            Request = new HashSet<Request>();
        }

        public int UserId { get; set; }
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
        public string DateOfBirth { get; set; }
        public DateTime? ActiveOn { get; set; }
        public int? ApproverBy { get; set; }
        public int? ApplicationId { get; set; }

        public virtual Administrator ApproverByNavigation { get; set; }
        public virtual ICollection<Request> Request { get; set; }
    }
}
