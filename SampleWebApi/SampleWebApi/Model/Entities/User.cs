using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi.Model.Entities
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Profileimage { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string Ethnicity { get; set; }

    }
}
