using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mva.Training.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }
}