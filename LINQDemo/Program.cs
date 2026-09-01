namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            #region Named Object
            //Student student = new Student
            //{
            //    Id = 1,
            //    Name = "John Doe"
            //};

            //// Named object => Object Has Reference Name
            //student.Name = "Jane Doe"; // Accessing property using reference name and Updating the value
            //Console.WriteLine(student); // Output: LINQDemo.Student // Override ToString()
            #endregion
            /*------------------------------------------------------------------*/
            #region Anonymous Object
            //List<Student> students = new List<Student>
            //{
            //    new Student { Id = 1, Name = "John Doe" },
            //    new Student { Id = 2, Name = "Jane Smith" },
            //    new Student { Id = 3, Name = "Bob Johnson" }
            //};

            //students[1].Name = "";
            //Student studentToUpdate = students[1];
            //studentToUpdate.Name = "Update Name";
            //// Catch To Update
            #endregion
            /*------------------------------------------------------------------*/
            #region Anonymous Type
            //Student student = new Student
            //{
            //    Id = 1,
            //    Name = "John Doe"
            //};
            //Console.WriteLine(student.GetType());

            //var s1 = new { SSN = 1, StudentName = "John Doe" };
            //Console.WriteLine(s1);
            //Console.WriteLine(s1.GetType());

            //s1.StudentName = "Ali"; // Error: Cannot modify the property of an anonymous type
            // Readonly property

            //// var
            //// LINQ => Language Integrated Query

            //var x = 10;
            //x = ""; // Error: Cannot implicitly convert type 'string' to 'int'

            //var z;
            #endregion
            /*------------------------------------------------------------------*/
            #region Anonymous Function
            //// (int x, int y) => x + y;
            //Func<int, int, int> add = (x, y) => x + y;

            //// Delegate
            //// Built-in delegate types

            //// 1- Predicate
            //// Retuen bool and takes one parameter
            //Predicate<Student> predicate = s => s.Id == 1;

            //// 2- Action
            //// Return void and takes 0 to 16 parameters
            //Action action1 = () => Console.WriteLine("Hello World");
            //Action<string> action2 = name => Console.WriteLine($"Hello {name}");

            //// 3- Func
            //// Return Type Generic and from 0 to 16 parameters
            //Func<int, int, int> func1 = (x, y) => x + y;
            //Func<int> func2 = () => 1;
            #endregion
            /*------------------------------------------------------------------*/
            #region Collections
            //// Base For All Collections
            //// 1- IEnumerable
            //// 2- ICollection

            //List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
            //IEnumerable<int> ints2 = new List<int> { 1, 2, 3, 4, 5 };
            ////IEnumerable<int> ints3 = new IEnumerable<int> { 1, 2, 3, 4, 5 }; XXXXXXX
            #endregion
            /*------------------------------------------------------------------*/
            #region Before LINQ
            //List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
            //List<int> result = new List<int>();

            //foreach (var item in ints)
            //{
            //    if(item % 2 == 0)
            //    {
            //        result.Add(item);
            //    }
            //}

            //var result2 = ints.Where(x => x % 2 == 0);

            //Console.WriteLine("-------------------------------------------");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------------------------------");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------------------------------");
            #endregion
            /*------------------------------------------------------------------*/
            #region Extension Method
            //var str = "Hello World From ITI";

            //var count1 = Helper.GetWordsCount(str);
            //Console.WriteLine(count1);

            //var count2 = str.GetWordsCount();
            //Console.WriteLine(count2);
            #endregion
            /*------------------------------------------------------------------*/
            #region LINQ Definition
            // LINQ stands for Language Integrated Query, a Microsoft.NET Framework
            // that provides a standardized way to query data from various data sources using
            // a common syntax within programming languages like C#
            #endregion
            /*------------------------------------------------------------------*/
            #region LINQ
            // 1- Query Syntax => Like SQL => Limited => Not Support All LINQ Methods [12/40]
            // 2- Method Syntax [Fluent API] => Like C# => Support All LINQ Methods [40/40]
            #endregion
            /*------------------------------------------------------------------*/
            #region Repository
            var employees = Repository.GetEmployees();
            var departments = Repository.GetDepartments();
            #endregion
            /*------------------------------------------------------------------*/
            #region Method Syntax
            //// Enumerable
            //// namespace System.Linq
            //var q1 = employees.Where(e => e.Age > 30);
            //var q2 = Enumerable.Where(employees, e => e.Age > 30);

            //var q3 = employees.Where(e => e.DeptId == 1);

            //var q4 = employees
            //         .Where(e => e.DeptId == 1)
            //         .Where(e => e.Age > 30);

            //var q5 = employees.Where(e => e.DeptId == 1 && e.Age > 30);

            //var q6 = employees
            //    .Where(e => e.DeptId == 1)
            //    .OrderBy(e => e.Age);

            //var q7 = employees
            //    .Where(e => e.DeptId == 1)
            //    .OrderByDescending(e => e.Age);

            //var q8 = employees
            //    .Where(e => e.DeptId == 1)
            //    .OrderBy(e => e.Age)
            //    .OrderBy(e => e.Name); // XXXX

            //var q9 = employees
            //    .Where(e => e.DeptId == 1)
            //    .OrderBy(e => e.Age)
            //    .ThenBy(e => e.Name);

            //foreach (var item in q7)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Query Syntax
            //// Select * from Employee
            //// from - where - orderby - select

            //var q10 = from e in employees
            //          select e;

            //var q11 = from e in employees
            //          where e.Age > 30
            //          select e;

            //var q12 = from e in employees
            //          where e.Age > 30 && e.DeptId == 1
            //          select e;

            //var q13 = from e in employees
            //          where e.Age > 30 && e.DeptId == 1
            //          orderby e.Age descending
            //          select e;

            //Console.WriteLine(q13); // XXXXXXX

            //foreach (var item in q10)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Single Element
            // First
            // FirstOrDefault
            // Last
            // LastOrDefault
            // Single
            // SingleOrDefault
            // ElementAt
            // ElementAtOrDefault
            // Find => EFCore

            #region First and FirstOrDefault
            //var q14 = employees.First();
            //var q15 = employees.First(e => e.Age > 30);
            //var q16 = employees.First(e => e.DeptId == 300);

            //// First
            //// 1- Return First Element Only
            //// 2- If No Element Found => Throw Exception => Sequence contains no matching element
            //// 3- If Found => Return Element
            //// 4- If Found more than one => Return First Only

            //var q17 = employees.FirstOrDefault();
            //var q18 = employees.FirstOrDefault(e => e.Age > 30);
            //var q19 = employees.FirstOrDefault(e => e.DeptId == 300);

            //if(q19 == null)
            //{
            //    Console.WriteLine("No Element Found");
            //}
            //else
            //{
            //    Console.WriteLine(q19);
            //}

            //// FirstOrDefault
            //// 1- Return First Element Only
            //// 2- If No Element Found => Return Null and no Exception
            //// 3- If Found => Return Element
            //// 4- If Found more than one => Return First Only
            #endregion

            #region Last and LastOrDefault
            //var q20 = employees.Last();
            //var q21 = employees.Last(e=>e.DeptId == 1);
            //var q22 = employees.Last(e=>e.DeptId == 1000);

            //// Last
            //// 1- Return Last Element Only
            //// 2- If No Element Found => Throw Exception => Sequence contains no matching element
            //// 3- If Found => Return Element
            //// 4- If Found more than one => Return Last Only

            //var q23 = employees.LastOrDefault();
            //var q24 = employees.LastOrDefault(e => e.DeptId == 1);
            //var q25 = employees.LastOrDefault(e => e.DeptId == 1000);

            //// LastOrDefault
            //// 1- Return Last Element Only
            //// 2- If No Element Found => Return Null and no Exception
            //// 3- If Found => Return Element
            //// 4- If Found more than one => Return Last Only
            #endregion

            #region Single and SingleOrDefault
            // Single => Return Single Element Only
            //var q26 = employees.Single();
            //var q27 = employees.Single(e => e.Id == 1);
            //var q28 = employees.Single(e => e.DeptId == 3);
            //var q29 = employees.Single(e => e.DeptId == 300000);

            //// Single
            //// 1- Return Single Element Only
            //// 2- If No Element Found => Throw Exception => Sequence contains no matching element
            //// 3- If Found one => Return Element
            //// 4- If Found more than one => Sequence contains more than one matching element

            //var q30 = employees.SingleOrDefault();
            //var q31 = employees.SingleOrDefault(e => e.Id == 1);
            //var q32 = employees.SingleOrDefault(e => e.DeptId == 3);
            //var q33 = employees.SingleOrDefault(e => e.DeptId == 300000);

            //// SingleOrDefault
            //// 1- Return Single Element Only
            //// 2- If No Element Found => Return Null and no Excpetion
            //// 3- If Found one => Return Element
            //// 4- If Found more than one => Throw Exception => Sequence contains more than one matching element
            #endregion

            #region ElementAt and ElementAtOrDefault
            // ElementAt => Return Element At Index

            //var q34 = employees.ElementAt(0);
            //var q35 = employees.ElementAt(100);

            //// ElementAt
            //// 1- Return Element at Specific Index
            //// 2- If Index Out of Range => Throw Exception => Index was out of range
            //// 3- If Index in Range => Return Element

            //var q36 = employees.ElementAtOrDefault(0);
            //var q37 = employees.ElementAtOrDefault(100);

            //// ElementAtOrDefault
            //// 1- Return Element at Specific Index
            //// 2- If Index Out of Range => Null
            //// 3- If Index in Range => Return Element
            #endregion
            #endregion
            /*------------------------------------------------------------------*/
            #region Deferred Execution vs Immediate Execution
            //// All LINQ Methods are Deferred Execution Except
            //// [ToList, ToArray, ToDictionary, Count, Sum, Max, Min, Average, First] => Immediate Execution
            //var q39 = employees.Where(e => e.DeptId == 1);
            //var newEmployee1 = new Employee
            //{
            //    Id = 11,
            //    Name = "New Employee",
            //    Age = 30,
            //    Salary = 1000,
            //    DeptId = 1
            //};
            //employees.Add(newEmployee1); // Execute Happen Here

            //foreach (var item in q39)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("----------------------------------------------");

            //var q40 = employees.Where(e => e.DeptId == 1).ToList(); // Execute Happen Here
            //var newEmployee2 = new Employee
            //{
            //    Id = 11,
            //    Name = "New Employee",
            //    Age = 30,
            //    Salary = 1000,
            //    DeptId = 1
            //};
            //employees.Add(newEmployee2);

            //foreach (var item in q40)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Select Top
            //// Take
            //// TakeLast
            //// TakeWhile
            //// Skip
            //// SkipLast
            //// SkipWhile

            //var q41 = employees.Take(3);
            //var q42 = employees.Take(300);

            //var q43 = employees.TakeLast(3);
            //var q44 = employees.TakeLast(300);

            //var q45 = employees.Skip(3);
            //var q46 = employees.Skip(300);

            //var q47 = employees.SkipLast(3);
            //var q48 = employees.SkipLast(300);

            //var q49 = employees.Skip(2).Take(3);

            //foreach (var item in q49)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region All & Any
            //List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
            //var q50 = ints.All(x => x % 2 == 0);
            //var q51 = ints.Any(x => x % 2 == 0);

            //Console.WriteLine(q50);
            //Console.WriteLine(q51);
            #endregion
            /*------------------------------------------------------------------*/
            #region Dinstinct
            //List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 6, 6, 6 };
            //var q52 = ints.Distinct();
            //foreach (var item in q52)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Projection => Select Columns
            //var q53 = employees
            //    .Where(e => e.DeptId == 1)
            //    .Select(e => e.Name);

            //var q54 = from e in employees
            //          where e.DeptId == 1
            //          select e.Name;

            ////var q55 = employees
            ////      .Where(e => e.DeptId == 1)
            ////      .Select(e => e.Name && e.Age);

            //var q56 = employees
            //    .Where(e => e.DeptId == 1)
            //    .Select(e => new Employee { Id = e.Id, Name = e.Name });

            //var q57 = employees
            //    .Where(e => e.DeptId == 1)
            //    .Select(e => new { SSN = e.Id, EmpName = e.Name });

            //foreach (var item in q57)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Join [Query Syntax]
            // Select Empployee Id, Name and Department Name

            //var q58 = from e in employees
            //          join d in departments
            //          on e.DeptId equals d.DeptId
            //          select new { EmpId = e.Id, EmpName = e.Name, Department = d.DeptName };

            //var q59 = from e in employees
            //          join d in departments
            //          on e.DeptId equals d.DeptId
            //          select new { Employee = e, Department = d.DeptName };

            //foreach (var item in q59)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Join [Method Syntax]
            //var q60 = employees.Join(
            //    departments,
            //    e => e.DeptId,
            //    d => d.DeptId,
            //    (e, d) => new { EmpId = e.Id, EmpName = e.Name, Department = d.DeptName });

            //var q61 = departments.Join(
            //    employees,
            //    d => d.DeptId,
            //    e => e.DeptId,
            //    (d, e) => new { EmpId = e.Id, EmpName = e.Name, Department = d.DeptName });

            //foreach (var item in q60)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Min, Max, Count, Avg, Sum
            //var q62 = employees.Min(e => e.Salary);
            //var q63 = employees.Max(e => e.Salary);
            //var q64 = employees.Count(e => e.Salary > 5000);
            //var q65 = employees.Average(e => e.Salary);
            //var q66 = employees.Sum(e => e.Salary);

            //Console.WriteLine(q62);
            //Console.WriteLine(q63);
            //Console.WriteLine(q64);
            //Console.WriteLine(q65);
            //Console.WriteLine(q66);

            //var q67 = employees.Where(e => e.Salary > employees.Average(e => e.Salary));
            //var q68 = employees.Where(e => e.Salary > q65);

            //foreach (var item in q68)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Oftype
            //List<User> users = new List<User>
            //{
            //    new Male { Id = 1, Name = "Ahmed" },
            //    new Male { Id = 2, Name = "Ahmed" },
            //    new Female { Id = 3, Name = "Sara" },
            //    new Female { Id = 4, Name = "Mai" },
            //};

            //var q69 = users.OfType<Male>();
            //var q70 = users.OfType<Female>();

            //foreach (var item in q69)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Concat, Union, Except, Intersect
            //List<int> list1 = new List<int> { 1, 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> list2 = new List<int> { 8, 9, 10, 11 };

            //var q71 = list1.Concat(list2);
            //var q72 = list1.Union(list2);
            //var q73 = list1.Except(list2);
            //var q74 = list1.Intersect(list2);

            //foreach (var item in q74)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Zip Operator
            //List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            //List<string> names = new List<string> { "Ahmed", "Mohamed", "Sara", "Mai", "Ramy" };

            //var q75 = nums.Zip(names);
            //var q76 = nums.Zip(names, (num, name) => new { Number = num, Name = name });

            //foreach (var item in q76)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region IndexedSelect & IndexedWhere
            //var q77 = employees.Select((e, i) => new { Employee = e, Index = i });
            //foreach (var item in q77)
            //{
            //    Console.WriteLine(item);
            //}

            //var q78 = employees.Where((emp, i) => emp.DeptId == 1 && i < 5);
            //foreach (var item in q78)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region GroupBy
            //var q79 = employees.GroupBy(e => e.DeptId);
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}