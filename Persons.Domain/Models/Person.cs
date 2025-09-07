using System;

namespace Persons.Domain.Models
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime? DateEmploy {  get; set; }
        public DateTime? DateUnemploy { get; set; }
        public string Department { get; set; }
        public string Post { get; set; }
        public string Status { get; set; }
    }
}
