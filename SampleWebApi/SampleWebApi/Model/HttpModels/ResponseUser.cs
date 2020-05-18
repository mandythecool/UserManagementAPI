using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CerenetexUserManagement.Model.HttpModels
{
    public class ResponseUser
    {

        public int id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Profileimage { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public string Ethnicity { get; set; }
    }
}
