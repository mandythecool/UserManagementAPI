using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi.Model.Entities
{
    public class User
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Profileimage { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string Ethnicity { get; set; }

    }
}
