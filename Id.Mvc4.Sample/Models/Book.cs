using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Id.Mvc4.Sample.Models
{

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Isbn { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
        public virtual Format Format { get; set; }
        public virtual Subject Subject { get; set; }
    }
}