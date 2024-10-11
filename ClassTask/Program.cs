using System.Security.Cryptography.X509Certificates;

List<Person> people = new List<Person>
{
    new Person { Id = 1, Name = "Alice", Age = 30, CityId = 1 },
    new Person { Id = 2, Name = "Bob", Age = 25, CityId = 2 },
    new Person { Id = 3, Name = "Charlie", Age = 35, CityId = 1 },
    new Person { Id = 4, Name = "Diana", Age = 28, CityId = 3 },
    new Person { Id = 5, Name = "Evan", Age = 40, CityId = 2 },
    new Person { Id = 6, Name = "Fiona", Age = 22, CityId = 1 },
    new Person { Id = 7, Name = "George", Age = 33, CityId = 3 },
    new Person { Id = 8, Name = "Hannah", Age = 27, CityId = 2 },
    new Person { Id = 9, Name = "Ian", Age = 31, CityId = 1 },
    new Person { Id = 10, Name = "Iane", Age = 29, CityId = 3 },
    new Person { Id = 11, Name = "Daler", Age = 5, CityId = 4 }
};
List<City> cities = new List<City>
{
    new City { Id = 1, Name = "Dushanbe" },
    new City { Id = 2, Name = "Dubay" },
    new City { Id = 3, Name = "London" },
    new City { Id = 4, Name = "Alpi" }
};


// ---------------------------------- 1 ----------------------------- //
// Найдите всех людей, длина имени которых превышает 4. Выведите имя человека и длину имени человека.
// var res = people.Where(x => x.Name.Length > 4).Select(p => p);

// foreach (var r in res)
// {
//     System.Console.WriteLine($"{r.Name} - {r.Name.Length}");
// }


// ----------------------------------- 2 ---------------------------------- //
// Сгруппируйте людей по городам, упорядочите каждую группу по возрасту и выберите самого молодого человека в каждом городе.
// var res = people.OrderBy(x => x.Age).GroupBy(x => x.CityId);
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Key);
//     foreach (var i in r)
//     {
//         System.Console.WriteLine(i.Name);
//         break;
//     }
// }


// ------------------------------------ 3 ---------------------------------- //
// Создайте иерархическую структуру, в которой каждый город содержит список его жителей, а затем рассчитайте средний возраст жителей в каждом городе.
// var res = people.GroupBy(x => x.CityId)
// .Select(x => new
// {
//     CityId = x.Key,
//     Average = x.Average(y => y.Age)
// });
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.CityId + " " + (int)r.Average);
// }


// -------------------------------- 4 ---------------------------------- //
// Выполните объединение людей и городов, затем сгруппируйте результаты по городам и спроецируйте новый тип, содержащий название города и список имен жителей.
// var res = from p in people
//           join c in cities on p.CityId equals c.Id
//           group p by c.Name;

// foreach (var r in res)
// {
//     System.Console.WriteLine();
//     System.Console.WriteLine(r.Key);
//     foreach (var i in r)
//     {
//         System.Console.Write(i.Name + ", ");
//     }
//     System.Console.WriteLine();
// }


// ----------------------------------- 5 ------------------------------ //
// Найдите всех людей, живущих в городах, название которых начинается с буквы «N» или «L». Для этих людей создайте новый тип, содержащий имя человека и название города.
// var res = from p in people
//             join c in cities on p.CityId equals c.Id
//             where c.Name.ToUpper().StartsWith("T") || c.Name.ToUpper().StartsWith("L")
//             select 
//             new 
//             {
//                 CityName = c.Name,
//                 NamePeople = p.Name
//             };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.CityName + " " + r.NamePeople);
// }



// --------------------------------------------------------------------------------------------------- //


//  Task 1
// Найдите всех людей старше 25 лет и спроецируйте их имена и возраст на новый анонимный тип.
// var res = from p in people
//           where p.Age > 25
//           select new
//           {
//               NamePeople = p.Name,
//               AgePeople = p.Age
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine($"Name: {r.NamePeople} - Age: {r.AgePeople}");
// }


// Task 2
// Упорядочите людей по возрасту, а затем по именам в алфавитном порядке в пределах одного возраста.
// var res = people.OrderBy(x=>x.Age).ThenBy(x=>x.Name); // 1 
// var res = from p in people// 2
//           orderby p.Age, p.Name
//           select p;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Age + " " + r.Name);
// }


// Task 3
// Выберите первую букву имени каждого человека и сгруппируйте людей по этой букве.
//  --   ?   --


// Task 4
// Предположим, что существует еще один список объектов City. Присоединяйтесь к людям с городами на основе общего CityId и спроектируйте новый анонимный тип с именами людей и названиями городов.
// var res = from p in people
//           join c in cities on p.CityId equals c.Id
//           select new
//           {
//               CityName = c.Name,
//               NamePeople = p.Name
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine($" {r.NamePeople} : {r.CityName}");
// }


// Task 5
// Вычислите общий возраст всех людей, имена которых начинаются с гласной.
// var res = (from p in people
//            where p.Name.ToUpper().StartsWith("A")
//            || p.Name.ToUpper().StartsWith("E")
//            || p.Name.ToUpper().StartsWith("O")
//            || p.Name.ToUpper().StartsWith("I")
//            || p.Name.ToUpper().StartsWith("U")
//            select p.Age).Sum();

// System.Console.WriteLine(res);


// Task 6
// Сгруппируйте людей по первой букве имени и посчитайте, сколько человек попадает в каждую группу.
// var res = from p in people
//           let n = p.Name[0]
//           group p by n into x
//           select new
//           {
//               FirstBukva = x.Key,
//               Count = x.Count()
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine($"{r.FirstBukva} - {r.Count}");
// }



// Task 7
// Выберите город, в котором максимальное количество людей
// var res = from p in people
//           join c in cities on p.CityId equals c.Id
//           group p by c.Name into g
//           select new
//           {
//               City = g.Key,
//               Count = g.Count()
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine($"Город: {r.City}: Колличество: {r.Count}");
// }


// Task 8
// Выберите всех детей от 2 до 7 лет, проживающих в любом городе, название которого начинается с буквы «а».
// var res = from p in people
//           join c in cities on p.CityId equals c.Id
//           where c.Name.ToUpper().StartsWith("A") && p.Age >= 2 && p.Age <= 7
//           select new
//           {
//               NameCity = c.Name,
//               Name = p.Name,
//               Age = p.Age
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.NameCity + " " + r.Name + " " + r.Age);
// }
