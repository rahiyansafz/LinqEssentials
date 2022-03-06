using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEssentials
{
    public class Data
    {
        public static List<Model> LoadData()
        {
            List<Model> list = new();

            list.Add(new Model { FirstName = "Rahiyan", LastName = "Safin", YearsOfExperience = 3, Birthdate = Convert.ToDateTime("7/11/1998") });
            list.Add(new Model { FirstName = "Risha", LastName = "Afrin", YearsOfExperience = 3, Birthdate = Convert.ToDateTime("5/12/2003") });
            list.Add(new Model { FirstName = "Shad", LastName = "Ahmed", YearsOfExperience = 0, Birthdate = Convert.ToDateTime("6/14/2002") });
            list.Add(new Model { FirstName = "Sifat", LastName = "Hossain", YearsOfExperience = 2, Birthdate = Convert.ToDateTime("1/16/1994") });
            list.Add(new Model { FirstName = "Sara", LastName = "Hossain", YearsOfExperience = 1, Birthdate = Convert.ToDateTime("12/12/1996") });
            list.Add(new Model { FirstName = "Oniya", LastName = "Ordhya", YearsOfExperience = 1, Birthdate = Convert.ToDateTime("5/25/2020") });
            list.Add(new Model { FirstName = "Ayesha", LastName = "Mila", YearsOfExperience = 0, Birthdate = Convert.ToDateTime("6/2/2008") });
            list.Add(new Model { FirstName = "John", LastName = "Doe", YearsOfExperience = 13, Birthdate = Convert.ToDateTime("9/9/1950") });
            list.Add(new Model { FirstName = "John", LastName = "Doe", YearsOfExperience = 14, Birthdate = Convert.ToDateTime("9/9/1950") });

            return list;
        }
    }
}
