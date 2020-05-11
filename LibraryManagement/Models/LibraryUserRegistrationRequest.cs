using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class LibraryUserRegistrationRequest
    {
        public int RequestId { get; set; }
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
        public string DateOfBirth { get; set; }
        public string ActivationCode { get; set; }
        public DateTime RequestTime { get; set; }
        public string UserRequestStatus { get; set; }
    }
}
