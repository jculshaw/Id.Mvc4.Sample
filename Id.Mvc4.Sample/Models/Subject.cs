using System.Collections.Generic;
using Newtonsoft.Json;

namespace Id.Mvc4.Sample.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Book> Books { get; set; }
    }
}