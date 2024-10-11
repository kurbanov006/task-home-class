using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

List<Student> students = new List<Student>
{
    new Student { Id = 1, Name = "Alice", DateOfBirth = new DateTime(2000, 5, 15) },
    new Student { Id = 2, Name = "Bob", DateOfBirth = new DateTime(1999, 8, 25) },
    new Student { Id = 3, Name = "Charlie", DateOfBirth = new DateTime(2001, 3, 10) }
};


List<Course> courses = new List<Course>
{
    new Course { Id = 101, Title = "Mathematics", Credits = 4 },
    new Course { Id = 102, Title = "Computer Science", Credits = 3 },
    new Course { Id = 103, Title = "Physics", Credits = 4 }
};


List<Enrollment> enrollments = new List<Enrollment>
{
    new Enrollment { Id = 1, StudentId = 1, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 15) },
    new Enrollment { Id = 2, StudentId = 1, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 20) },
    new Enrollment { Id = 3, StudentId = 2, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 18) },
    new Enrollment { Id = 4, StudentId = 3, CourseId = 103, EnrollmentDate = new DateTime(2023, 1, 22) },
    new Enrollment { Id = 5, StudentId = 3, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 25) },
    new Enrollment { Id = 6, StudentId = 3, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 30) }
};







// ------------------- 1 ----------------------- //
// Найдите всех студентов, обучающихся по курсу «Математика».
// var res = from s in students
//           join e in enrollments on s.Id equals e.StudentId
//           join c in courses on e.CourseId equals c.Id
//           where c.Title == "Mathematics"
//           select new
//           {
//               Name = s.Name,
//               Course = c.Title
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name + " " + r.Course);
// }


// ------------------ 2 ------------------------ //
// Найдите все курсы, на которые записан «Чарли».
// var res = from s in students
//           join e in enrollments on s.Id equals e.StudentId
//           join c in courses on e.CourseId equals c.Id
//           where s.Name == "Charlie"
//           select new
//           {
//               Name = s.Name,
//               Course = c.Title
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name + " " + r.Course);
// }


// ------------------------ 3 --------------------- //
// Использование SelectMany с иерархическими данными: сведите список зачисленных и выберите студентов, которые зачислены на несколько курсов.
// -- ? -- //


// ---------------------- 4 -------------------------- //
// Сгруппируйте учащихся по возрастному диапазону, а затем по курсам и рассчитайте средний возраст для каждой группы.
// var res = from s in students
//           join e in enrollments on s.Id equals e.StudentId
//           join c in courses on e.CourseId equals c.Id
//           //   group s by c.Title into g
//           //   orderby g.Key
//           orderby s.DateOfBirth, c.Title
//           group s by c.Title into g
//           select new { Course = g.Key, Avg = g.Average(x => DateTime.Now.Year - x.DateOfBirth.Year) };

// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Course + " " + (int)r.Avg);
// }



// ------------------------------ 5 ------------------------------ // 
// Присоединяйте Student, Enrollment и Course и фильтруйте по дате зачисления и кредитам курса.
// var res = from s in students
//           join e in enrollments on s.Id equals e.StudentId
//           join c in courses on e.CourseId equals c.Id
//           orderby e.EnrollmentDate, c.Credits
//           select new
//           {
//               Name = s.Name,
//               Date = e.EnrollmentDate,
//               Credit = c.Credits
//           };

// foreach (var r in res)
// {
//     Console.WriteLine($"Студент: {r.Name}, Дата : {r.Date}, Кредиты: {r.Credit}");
// }

// --------------------------------- 6 ----------------------------------- //
// Подсчитайте общее количество кредитов, на которые записался каждый студент.
// var res = from s in students
//           join e in enrollments on s.Id equals e.StudentId
//           join c in courses on e.CourseId equals c.Id
//           group c by s.Name into g
//           select new
//           {
//               NameStud = g.Key,
//               Count = g.Count()
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.NameStud + " " + r.Count);
// }


// ------------------------- 7 ------------------------ //
// Найдите количество студентов, обучающихся на каждом курсе.
// var res = from s in students
//           join e in enrollments on s.Id equals e.StudentId
//           join c in courses on e.CourseId equals c.Id
//           group s by c.Title into g
//           select new
//           {
//               NameCourse = g.Key,
//               CountStd = g.Count()
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.NameCourse + " " + r.CountStd);
// }


// --------------------------- 8 --------------------------------- //
// Найдите все курсы, на которые не записан конкретный студент, например «Боб».
// var res = from s in students
//           join e in enrollments on s.Id equals e.StudentId
//           join c in courses on e.CourseId equals c.Id
//           where s.Name != "Bob"
//           select new
//           {
//               Name = s.Name,
//               Course = c.Title
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name + " " + r.Course);
// }