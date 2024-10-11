List<Employee> employees = new List<Employee>();

Employee employee = new Employee
{
    Id = 1,
    FirstName = "Daler",
    LastName = "Kurbanov",
    Age = 19,
    Salary = 1234553,
    Experience = 12
};
Employee employee2 = new Employee
{
    Id = 2,
    FirstName = "Komron",
    LastName = "Komron",
    Age = 23,
    Salary = 1234553,
    Experience = 12
};
Employee employee3 = new Employee
{
    Id = 3,
    FirstName = "Jon",
    LastName = "Doe",
    Age = 19,
    Salary = 1234553,
    Experience = 12
};
Employee employee4 = new Employee
{
    Id = 4,
    FirstName = "Davron",
    LastName = "Doe",
    Age = 15,
    Salary = 1234553,
    Experience = 12
};
Employee employee5 = new Employee
{
    Id = 5,
    FirstName = "Faruh",
    LastName = "Doe",
    Age = 12,
    Salary = 1234553,
    Experience = 12
};
Employee employee6 = new Employee
{
    Id = 6,
    FirstName = "Vie",
    LastName = "Doe",
    Age = 28,
    Salary = 1234553,
    Experience = 12
};
Employee employee7 = new Employee
{
    Id = 7,
    FirstName = "Lacoste",
    LastName = "Doe",
    Age = 25,
    Salary = 1234553,
    Experience = 12
};

employees.Add(employee);
employees.Add(employee2);
employees.Add(employee3);
employees.Add(employee4);
employees.Add(employee5);
employees.Add(employee6);
employees.Add(employee7);



// Имея список объектов Employee, напишите запрос LINQ, чтобы выбрать зарплату сотрудника. Распечатайте результат в операторе foreach

//----------------------------- 1 ---------------------------//
// var res = from emp in employees
//           select emp.Salary;
// foreach (var item in res)
// {
// System.Console.WriteLine($"{item}");
// }




// Учитывая список объектов Employee, напишите запрос LINQ, чтобы выбрать сотрудников, чьи имена содержат более 6 символов. Распечатайте результат в операторе foreach.

// ------------------- 2 -----------------//
// var res = from p in employees
// where p.FirstName.Length > 6
// select p.FirstName;
// foreach (var item in res)
// {
//     System.Console.WriteLine(item);
// }


// Учитывая список объектов Employee, напишите запрос LINQ, чтобы выбрать полное имя сотрудника, который старше первого сотрудника в списке или массиве. Распечатайте результат в операторе foreach.

// ------------------------------ 3 ---------------------------//
// var res = from p in employees
//           let e = employees.First(x => x.Id == 1)
//           where p.Age > e.Age
//           select p.FirstName;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r);
// }



// Имея список объектов Employee, напишите запрос LINQ, чтобы выбрать сотрудников, чей опыт работы вдвое меньше чем их возраст. Распечатайте результат в операторе foreach.

// ------------------------ 4 ---------------------
// var res = from p in employees
//           where p.Age / 2 == p.Experience
//           select p.FirstName;
// foreach (var item in res)
// {
//     System.Console.WriteLine(item);
// }



// Имея список объектов Employee, напишите запрос LINQ, чтобы выбрать трех лучших сотрудников с большим опытом и зарплатой выше 5000. Выведите результат в операторе foreach.
// ---------------- 5 ---------------------- //
// var res = (from p in employees
//            orderby p.Experience descending
//            where p.Salary > 5000
//            select p).Take(3);

// foreach (var item in res)
// {
//     System.Console.WriteLine(item.FirstName);
// }
