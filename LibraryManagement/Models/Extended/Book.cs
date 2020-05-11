using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    [ModelMetadataType(typeof(BookMetaData))]
    public partial class Book
    {
    }

    public class BookMetaData
    {
        [DisplayName("Type")]
        public string BookType { get; set; }

        [DisplayName("Description")]
        public string BookDescription { get; set; }

        [DisplayName("Status")]
        public string BookStatus { get; set; }
    }
}
