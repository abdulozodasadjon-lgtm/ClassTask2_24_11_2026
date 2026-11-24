
List<Person> people =
[
    new Person { Id = 1, Name = "Saad", Age = 13, CityId = 1 },
    new Person { Id = 2, Name = "Ali", Age = 28, CityId = 2 },
    new Person { Id = 3, Name = "Madina", Age = 22, CityId = 3 },
    new Person { Id = 4, Name = "Hikmatullo", Age = 35, CityId = 1 },
    new Person { Id = 5, Name = "Amir", Age = 5, CityId = 4 },
    new Person { Id = 6, Name = "Zarina", Age = 7, CityId = 5 },
    new Person { Id = 7, Name = "Ibrahim", Age = 30, CityId = 2 },
    new Person { Id = 8, Name = "Olim", Age = 4, CityId = 4 },
    new Person { Id = 9, Name = "Farzona", Age = 26, CityId = 6 },
    new Person { Id = 10, Name = "Anvar", Age = 6, CityId = 4 }
];

List<City> cities =
[
    new City { Id = 1, Name = "Dushanbe" },
    new City { Id = 2, Name = "Khujand" },
    new City { Id = 3, Name = "Bokhtar" },
    new City { Id = 4, Name = "Almaty" },
    new City { Id = 5, Name = "Ankara" },
    new City { Id = 6, Name = "Amsterdam" }
];

int i = 1;


// 1

// Method Syntax

// var result1 = people.Where(x => x.Age > 25)
//                     .Select(x => new { x.Name, x.Age });

// foreach (var person in result1)
// {
//     System.Console.WriteLine($"Person {i}: {person.Name}, Age: {person.Age}");
//     i++;
// }

// Query Syntax

// var result2 = from x in people
//               where x.Age > 25
//               select new { x.Name, x.Age };

// foreach (var person in result2)
// {
//     System.Console.WriteLine($"Person {i}: {person.Name}, Age: {person.Age}");
//     i++;
// }


// 2

// Method Syntax

// var result3 = people.OrderBy(x => x.Age)
//                     .ThenBy(x => x.Name);

// foreach (var person in result3)
// {
//     System.Console.WriteLine($"Person {i}: {person.Name}, Age: {person.Age}");
//     i++;
// }

// Query Syntax

// var result4 = from x in people
//               orderby x.Age, x.Name
//               select x;

// foreach (var person in result4)
// {
//     System.Console.WriteLine($"Person {i}: {person.Name}, Age: {person.Age}");
//     i++;
// }


// 3

// Method Syntax

// var result5 = people.GroupBy(x => x.Name[0]);

// foreach (var group in result5)
// {
//     System.Console.WriteLine($"Letter: {group.Key}");

//     foreach (var person in group)
//     {
//         System.Console.WriteLine(person.Name);
//     }
// }

// Query Syntax

// var result6 = from x in people
//               group x by x.Name[0];

// foreach (var group in result6)
// {
//     System.Console.WriteLine($"Letter: {group.Key}");

//     foreach (var person in group)
//     {
//         System.Console.WriteLine(person.Name);
//     }
// }


// 4

// Method Syntax

// var result7 = people.Join(cities,
//                           p => p.CityId,
//                           c => c.Id,
//                           (p, c) => new
//                           {
//                               PersonName = p.Name,
//                               CityName = c.Name
//                           });

// foreach (var item in result7)
// {
//     System.Console.WriteLine($"{item.PersonName} - {item.CityName}");
// }

// Query Syntax

// var result8 = from p in people
//               join c in cities
//               on p.CityId equals c.Id
//               select new
//               {
//                   PersonName = p.Name,
//                   CityName = c.Name
//               };

// foreach (var item in result8)
// {
//     System.Console.WriteLine($"{item.PersonName} - {item.CityName}");
// }


// 5

// Method Syntax

// var result9 = people.Where(x => "AEIOU".Contains(char.ToUpper(x.Name[0])))
//                     .Sum(x => x.Age);

// foreach (var item in new[] { result9 })
// {
//     System.Console.WriteLine($"Total Age: {item}");
// }

// Query Syntax

// var result10 = from x in people
//                where "AEIOU".Contains(char.ToUpper(x.Name[0]))
//                group x by 1 into g
//                select g.Sum(x => x.Age);

// foreach (var item in result10)
// {
//     System.Console.WriteLine($"Total Age: {item}");
// }


// 6

// Method Syntax

// var result11 = people.GroupBy(x => x.Name[0])
//                      .Select(x => new
//                      {
//                          Letter = x.Key,
//                          Count = x.Count()
//                      });

// foreach (var item in result11)
// {
//     System.Console.WriteLine($"Letter: {item.Letter}, Count: {item.Count}");
// }

// Query Syntax

// var result12 = from x in people
//                group x by x.Name[0] into g
//                select new
//                {
//                    Letter = g.Key,
//                    Count = g.Count()
//                };

// foreach (var item in result12)
// {
//     System.Console.WriteLine($"Letter: {item.Letter}, Count: {item.Count}");
// }


// 7

// Method Syntax

// var result13 = cities.Select(c => new
// {
//     CityName = c.Name,
//     Count = people.Count(p => p.CityId == c.Id)
// })
// .OrderByDescending(x => x.Count)
// .Take(1);

// foreach (var item in result13)
// {
//     System.Console.WriteLine($"City: {item.CityName}, People: {item.Count}");
// }

// Query Syntax

// var result14 = (from c in cities
//                 let count = people.Count(p => p.CityId == c.Id)
//                 orderby count descending
//                 select new
//                 {
//                     CityName = c.Name,
//                     Count = count
//                 }).Take(1);

// foreach (var item in result14)
// {
//     System.Console.WriteLine($"City: {item.CityName}, People: {item.Count}");
// }


// 8

// Method Syntax

// var result15 = people.Join(cities,
//                            p => p.CityId,
//                            c => c.Id,
//                            (p, c) => new { Person = p, City = c })
//                       .Where(x => x.Person.Age >= 2 &&
//                                   x.Person.Age <= 7 &&
//                                   x.City.Name.StartsWith("a", StringComparison.OrdinalIgnoreCase))
//                       .Select(x => new
//                       {
//                           PersonName = x.Person.Name,
//                           Age = x.Person.Age,
//                           CityName = x.City.Name
//                       });

// foreach (var item in result15)
// {
//     System.Console.WriteLine($"{item.PersonName}, Age: {item.Age}, City: {item.CityName}");
// }

// Query Syntax

// var result16 = from p in people
//                join c in cities
//                on p.CityId equals c.Id
//                where p.Age >= 2 && p.Age <= 7
//                && c.Name.StartsWith("a", StringComparison.OrdinalIgnoreCase)
//                select new
//                {
//                    PersonName = p.Name,
//                    Age = p.Age,
//                    CityName = c.Name
//                };

// foreach (var item in result16)
// {
//     System.Console.WriteLine($"{item.PersonName}, Age: {item.Age}, City: {item.CityName}");
// }
