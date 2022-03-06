using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEssentials
{
    public class Model
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int YearsOfExperience { get; set; }
        public DateTime Birthdate { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
