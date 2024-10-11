List<Person> people = new List<Person>
{
    new Person
    {
        Id = 1,
        FirstName = "John",
        LastName = "Joe",
        Age = 30,
        Gender = "Male",
        Status = "Active",
        DateOfStart = new DateTime(2020, 1, 15),
        DateOfFinish = new DateTime(2021, 1, 15)
    },
    new Person
    {
        Id = 2,
        FirstName = "Jane",
        LastName = "Smith",
        Age = 28,
        Gender = "Female",
        Status = "Active",
        DateOfStart = new DateTime(2021, 2, 20),
        DateOfFinish = new DateTime(2022, 2, 20)
    },
    new Person
    {
        Id = 3,
        FirstName = "Sam",
        LastName = "Brown",
        Age = 22,
        Gender = "Male",
        Status = "InActive",
        DateOfStart = new DateTime(2019, 5, 10),
        DateOfFinish = new DateTime(2020, 5, 10)
    },
    new Person
    {
        Id = 4,
        FirstName = "Anna",
        LastName = "Johnson",
        Age = 35,
        Gender = "Female",
        Status = "Active",
        DateOfStart = new DateTime(2022, 3, 1),
        DateOfFinish = new DateTime(2023, 3, 1)
    },
    new Person
    {
        Id = 5,
        FirstName = "Mike",
        LastName = "Davis",
        Age = 16,
        Gender = "Male",
        Status = "Active",
        DateOfStart = new DateTime(2018, 7, 20),
        DateOfFinish = new DateTime(2022, 7, 20)
    }
};




// ------------------------- 1 -------------------- //
// Учитывая список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся, чей пол — Male. Распечатайте результат в операторе foreach.
// var res = from p in people
//           where p.Gender == "Male"
//           select p;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Gender);
// }


// ------------------------ 2 ------------------------- //
// Имея список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся со статусом InActive. Распечатайте результат в операторе foreach.
// var res = from p in people
//           where p.Status == "InActive"
//           select p;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Status);
// }



// -------------------------- 3 ------------------------------------//
// Используя список объектов Student, напишите запрос LINQ, чтобы выбрать студентов, дата рождения которых больше 2000 года. Распечатайте результат в операторе foreach.
// var res = from p in people
//           where DateTime.Now.Year - p.Age > 2000
//           select p;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.FirstName);
// }



// ------------------------------ 4 ------------------------------ //
// Используя список объектов Student, напишите запрос LINQ, чтобы выбрать студентов старше 20 лет, которые в настоящее время учатся. Выведите результат в операторе foreach.
// var res = from p in people
//           where p.Age > 20 && p.Status == "Active"
//           select p;
// foreach (var r in res)
// {
//     Console.WriteLine($"Id: {r.Id}, FullName: {r.FirstName} - {r.LastName}, Age: {r.Age}, Status: {r.Status}");
// }


// --------------------------------- 5 --------------------------- //
// Используя список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся, которые начали учиться в 16 лет. Выведите результат в операторе foreach.
// var res = from p in people




// ----------------------------- 6 ------------------------------- //
// Используя список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся, которые начали учиться, когда они, по крайней мере, стали взрослыми (+18). Выведите результат в операторе foreach.



// ----------------------------- 7 ------------------------------- //
// Используя список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся, имя которых начинается с буквы «A» или «I». Выведите результат в операторе foreach.
// var res = from p in people
//           where p.FirstName.ToUpper().StartsWith("A") || p.FirstName.ToUpper().StartsWith("I")
//           select p;
// foreach (var r in res)
// {
//     Console.WriteLine($"Id: {r.Id}, FullName: {r.FirstName} - {r.LastName}, Age: {r.Age}, Status: {r.Status}");
// }


// -------------------------- 8 --------------------------- //
// Используя список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся, чьи имена FisrtName и LastName начинаются с одинаковыми буквы. Выведите результат в операторе foreach.
// var res = from p in people
//           where p.FirstName[0] == p.LastName[0]
//           select p;
// foreach (var r in res)
// {
//     Console.WriteLine($"Id: {r.Id}, FullName: {r.FirstName} - {r.LastName}, Age: {r.Age}, Status: {r.Status}");
// }


// ------------------------ 9 ---------------------------- //
// Используя список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся, которые станут взрослыми во время учебы. Выведите результат в операторе foreach.
// var res = 



// ----------------------------- 10 --------------------- //
// Используя список объектов Student, напишите запрос LINQ, чтобы выбрать студентов, которые не являются женщинами, активны, учатся более 2 лет и младше 16 лет. Выведите результат в операторе foreach.
// var res = from p in people
//           where p.Gender == "Male" && p.Status == "Active" && (DateTime.Now.Year - p.DateOfStart.Year) > 2 && p.Age < 16
//           select p;
// foreach (var r in res)
// {
//     Console.WriteLine($"Id: {r.Id}, FullName: {r.FirstName} - {r.LastName}, Age: {r.Age}, Status: {r.Status}");
// }