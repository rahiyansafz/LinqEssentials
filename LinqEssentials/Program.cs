// See https://aka.ms/new-console-template for more information
using LinqEssentials;

Console.WriteLine("List of Cousins");

List<Model> people = Data.LoadData();


//OrderBy 
//people = people.OrderBy(x => x.FirstName).ToList(); // Ascending
//people = people.OrderByDescending(x => x.FirstName).ToList(); // Descending
//people = people.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.YearsOfExperience).ToList(); // More than one Condition
//people = people.OrderByDescending(x => x.FirstName).ThenBy(x => x.YearsOfExperience).ToList(); // More than one Condition


//Filter
//people = people.Where(x => x.YearsOfExperience > 1 && x.Birthdate.Month == 7).ToList(); // Basically overwriting the people list

//foreach (var person in people)
//{
//    Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthdate.ToShortDateString()}) : Experience {person.YearsOfExperience}");
//}


//Sum 
//int yearsTotal = people.Sum(x => x.YearsOfExperience);

//Console.WriteLine($"The total years of experience is : { yearsTotal }");


//Combining List Methods: Where and Sum
int yearsTotal = 0;
yearsTotal = people.Where(x => x.Birthdate.Month == 9).Sum(x => x.YearsOfExperience);

Console.WriteLine($"The total years of experience is : { yearsTotal }");

Console.ReadLine();