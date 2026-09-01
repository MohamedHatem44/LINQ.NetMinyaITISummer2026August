# LINQ.NetMinyaITISummer2026August

# 🔷 C# LINQ – Language Integrated Query

## 📌 Project Overview

This project is a **C# Console Application** that demonstrates the fundamentals of **LINQ (Language Integrated Query)** and related C# concepts.

The project covers:

* Named Objects
* Anonymous Objects
* Anonymous Types
* Anonymous Functions
* Built-in Delegates
* Collections
* `IEnumerable`
* Extension Methods
* LINQ Method Syntax
* LINQ Query Syntax
* Deferred Execution
* Immediate Execution
* Filtering
* Sorting
* Projection
* Joining Collections
* Aggregation
* Element Operators
* Set Operators
* Partitioning Operators
* Quantifier Operators
* `OfType`
* `Zip`
* Indexed `Select`
* Indexed `Where`

The application uses in-memory `Employee` and `Department` collections to demonstrate different LINQ operations.

---

# 🏗 Project Structure

```text
LINQDemo
│
├── Program.cs
│
├── Employee.cs
│
├── Department.cs
│
├── Repository.cs
│
├── Student.cs
│
├── User.cs
│
├── Male.cs
├── Female.cs
│
├── Helper.cs
│
└── ExtensionMethod.cs
```

---

# ⚙ Technologies Used

* C#
* .NET
* LINQ
* Console Application
* Generic Collections
* Lambda Expressions
* Delegates
* Extension Methods

---

# 📦 Named Object

A **named object** is an object that has a reference variable.

Example:

```csharp
Student student = new Student
{
    Id = 1,
    Name = "John Doe"
};

student.Name = "Ahmed";

Console.WriteLine(student);
```

The variable `student` holds a reference to the `Student` object.

---

# 📦 Anonymous Object

A collection can contain multiple named objects.

Example:

```csharp
List<Student> students = new List<Student>
{
    new Student { Id = 1, Name = "John Doe" },
    new Student { Id = 2, Name = "Jane Smith" },
    new Student { Id = 3, Name = "Michael Johnson" }
};
```

Objects can be updated through:

```csharp
students[1].Name = "Ali";
```

Or:

```csharp
Student studentToUpdate = students[1];

studentToUpdate.Name = "Ali";
```

Both references point to the same object.

---

# 🧠 Anonymous Type

An **anonymous type** allows creating an object without explicitly defining a class.

```csharp
var s1 = new
{
    SSN = 1,
    Name = "Ahmed"
};

Console.WriteLine(s1);
Console.WriteLine(s1.GetType());
```

Anonymous type properties are **read-only**.

```csharp
// s1.Name = "Ali"; // Error
```

---

# 🔤 var Keyword

`var` allows the compiler to infer the type of a variable.

```csharp
var z = 10;
```

The compiler determines that `z` is an `int`.

```csharp
// z = "Ali"; // Error
```

`var` variables must be initialized when declared.

```csharp
// var x; // Error
```

---

# ⚡ Anonymous Function

An anonymous function is a function without an explicit method name.

Example:

```csharp
Func<int, int, int> func = (x, y) => x + y;
```

Lambda expressions are commonly used with LINQ.

---

# 🔗 Built-in Delegates

C# provides three commonly used built-in delegates.

---

## 1️⃣ Predicate

`Predicate<T>`:

* Accepts one parameter
* Returns `bool`

```csharp
Predicate<Student> predicate = s => s.Id == 1;
```

---

## 2️⃣ Action

`Action`:

* Returns `void`
* Supports from 0 to 16 parameters

```csharp
Action action1 = () => Console.WriteLine("Hello World");

Action<string> action2 =
    str => Console.WriteLine(str);
```

---

## 3️⃣ Func

`Func`:

* Returns a value
* Supports from 0 to 16 input parameters

```csharp
Func<int, int, int> func1 =
    (x, y) => x + y;

Func<int> func2 = () => 5;
```

---

# 📚 Collections

Collections are used to store groups of objects.

Example:

```csharp
List<int> ints = new List<int>
{
    1, 2, 3, 4, 5
};
```

A collection can also be referenced through `IEnumerable<T>`:

```csharp
IEnumerable<int> int2 =
    new List<int>
    {
        1, 2, 3, 4, 5
    };
```

`IEnumerable<T>` represents a sequence that can be iterated over.

---

# 🔄 Before LINQ

Before LINQ, filtering a collection commonly required a `foreach` loop.

```csharp
List<int> numbers =
    new List<int> { 1, 2, 3, 4, 5 };

List<int> result = new List<int>();

foreach (var item in numbers)
{
    if (item % 2 == 0)
    {
        result.Add(item);
    }
}
```

The same operation can be written using LINQ:

```csharp
var result = numbers.Where(n => n % 2 == 0);
```

LINQ provides a shorter and more expressive way to query collections.

---

# 🧩 Extension Method

An **extension method** allows adding a method to an existing type without modifying the original type.

Example:

```csharp
public static class ExtensionMethod
{
    public static int GetWordsCount(this string text)
    {
        if (!string.IsNullOrWhiteSpace(text))
        {
            int count = text.Split(" ").Length;
            return count;
        }

        return 0;
    }
}
```

Usage:

```csharp
var str = "Hello World From ITI MNF";

int count = str.GetWordsCount();

Console.WriteLine(count);
```

The `this` keyword makes the method an extension method for `string`.

---

# 📖 LINQ Definition

LINQ stands for:

> **Language Integrated Query**

LINQ provides a standardized way to query data from different data sources using C# syntax.

LINQ can be used with:

* Collections
* Arrays
* Lists
* Entity Framework
* Databases
* XML
* Other data sources

---

# 🔍 LINQ Syntax

There are two main ways to write LINQ queries.

## 1️⃣ Query Syntax

Query Syntax looks similar to SQL.

```csharp
var query =
    from e in employees
    where e.Age > 30
    select e;
```

Query Syntax supports a limited subset of LINQ methods.

---

## 2️⃣ Method Syntax

Method Syntax is also called:

> **Fluent API**

```csharp
var query = employees
    .Where(e => e.Age > 30);
```

Method Syntax provides access to the full set of LINQ extension methods.

---

# 🔎 LINQ Method Syntax

Method Syntax uses extension methods and lambda expressions.

Example:

```csharp
var q1 = employees
    .Where(e => e.Age > 30);
```

The same operation can also be written using:

```csharp
var q2 =
    Enumerable.Where(
        employees,
        e => e.Age > 30);
```

---

# 🔗 Function Chaining

LINQ methods can be chained together.

```csharp
var query = employees
    .Where(e => e.Age > 30)
    .Where(e => e.DeptId == 1);
```

Multiple conditions can also be combined:

```csharp
var query = employees
    .Where(e => e.Age > 30 &&
                e.DeptId == 1);
```

---

# 🔃 Sorting

## OrderBy

Sort ascending:

```csharp
var query = employees
    .Where(e => e.Age > 30)
    .OrderBy(e => e.DeptId);
```

---

## OrderByDescending

Sort descending:

```csharp
var query = employees
    .Where(e => e.Age > 30)
    .OrderByDescending(e => e.Name);
```

---

## ThenBy

Used for secondary sorting.

```csharp
var query = employees
    .Where(e => e.Age > 30)
    .OrderBy(e => e.DeptId)
    .ThenBy(e => e.Name);
```

Instead of:

```csharp
// OrderBy(e => e.DeptId)
// .OrderBy(e => e.Name)
```

Use `ThenBy` for secondary ordering.

---

# 📝 Query Syntax

Query Syntax is similar to SQL.

Basic query:

```csharp
var query =
    from e in employees
    select e;
```

---

## Where

```csharp
var query =
    from e in employees
    where e.Age > 30
    select e;
```

Multiple conditions:

```csharp
var query =
    from e in employees
    where e.Age > 30 &&
          e.DeptId == 2
    select e;
```

---

## Order By

```csharp
var query =
    from e in employees
    where e.Age > 30 &&
          e.DeptId == 2
    orderby e.Salary descending
    select e;
```

---

# 🎯 Single Element Operators

LINQ provides operators that return a single element.

| Method                | If No Match                           | If Multiple Matches                |
|-----------------------|---------------------------------------|------------------------------------|
| `First()`             | Throws Exception                      | Returns first matching element     |
| `FirstOrDefault()`    | Returns default (`null` / `0`)        | Returns first matching element     |
| `Last()`              | Throws Exception                      | Returns last matching element      |
| `LastOrDefault()`     | Returns default (`null` / `0`)        | Returns last matching element      |
| `Single()`            | Throws Exception                      | Throws Exception                   |
| `SingleOrDefault()`   | Returns default (`null` / `0`)        | Throws Exception                   |
| `ElementAt()`         | Throws Exception (index out of range) | —                                  |
| `ElementAtOrDefault()`| Returns default (`null` / `0`)        | —                                  |

---

# ⏳ Deferred Execution vs Immediate Execution

Most LINQ queries use **Deferred Execution**.

Example:

```csharp
var query =
    employees.Where(e => e.DeptId == 1);
```

The query is not executed immediately.

It is executed when the collection is enumerated.

```csharp
foreach (var employee in query)
{
    Console.WriteLine(employee);
}
```

---

# ⚡ Immediate Execution

Calling methods such as `ToList()` executes the query immediately.

```csharp
var query =
    employees
        .Where(e => e.DeptId == 1)
        .ToList();
```

The result is stored in a new list.

Therefore, later changes to the original collection do not affect the already-created list.

---

# 🎯 Partitioning Operators

LINQ provides operators for selecting or skipping elements.

Available operators:

* `Take`
* `TakeLast`
* `Skip`
* `SkipLast`
* `TakeWhile`
* `SkipWhile`

---

## Take

Returns the first specified number of elements.

```csharp
var query =
    employees.Take(3);
```

---

## TakeLast

Returns the last specified number of elements.

```csharp
var query =
    employees.TakeLast(3);
```

---

## Skip

Skips the first specified number of elements.

```csharp
var query =
    employees.Skip(3);
```

---

## SkipLast

Skips the last specified number of elements.

```csharp
var query =
    employees.SkipLast(3);
```

---

## Skip + Take

Can be used for pagination-like scenarios.

```csharp
var query =
    employees
        .Skip(3)
        .Take(3);
```

---

# ✅ All and Any

These are **quantifier operators**.

Example collection:

```csharp
List<int> ints =
    new List<int>
    {
        1, 2, 3, 4, 5, 6, 7
    };
```

---

## All

Checks whether all elements satisfy a condition.

```csharp
var result =
    ints.All(i => i % 2 == 0);
```

Returns:

```text
false
```

---

## Any

Checks whether at least one element satisfies a condition.

```csharp
var result =
    ints.Any(i => i % 2 == 0);
```

Returns:

```text
true
```

---

# 🔁 Distinct

Removes duplicate values.

```csharp
List<int> ints =
    new List<int>
    {
        1, 2, 3, 4, 5, 6,
        7, 7, 7, 8, 8, 9, 9
    };

var query = ints.Distinct();
```

---

# 🎯 Projection – Select Columns

`Select` is used to project elements into another shape.

Select employee names:

```csharp
var query = employees
    .Where(e => e.DeptId == 1)
    .Select(e => e.Name);
```

The same operation using Query Syntax:

```csharp
var query =
    from e in employees
    where e.DeptId == 1
    select e.Name;
```

---

# 📦 Select Anonymous Type

Multiple properties can be selected into an anonymous type.

```csharp
var query = employees
    .Where(e => e.DeptId == 1)
    .Select(e => new
    {
        EmployeeName = e.Name,
        EmpSalary = e.Salary
    });
```

This is useful when only specific fields are required.

---

# 🔗 Join

LINQ `Join` combines two collections based on a matching key.

In this project:

```text
Employee.DeptId
        ↓
Department.DeptId
```

---

# 🔗 Join – Query Syntax

Select Employee ID, Name, and Department Name:

```csharp
var query =
    from e in employees
    join d in departments
        on e.DeptId equals d.DeptId
    select new
    {
        EmployeeId = e.Id,
        EmployeeName = e.Name,
        DepartmentName = d.DeptName
    };
```

---

# 🔗 Join – Method Syntax

```csharp
var query = employees.Join(
    departments,
    e => e.DeptId,
    d => d.DeptId,
    (e, d) => new
    {
        Employee = e,
        DepartmentName = d.DeptName
    });
```

The result selector determines the shape of the returned object.

---

# 📊 Aggregation Operators

LINQ provides aggregation operators for calculations.

Common operators:

* `Min`
* `Max`
* `Count`
* `Average`
* `Sum`

---

## Min

```csharp
var minimumSalary =
    employees.Min(e => e.Salary);
```

---

## Max

```csharp
var maximumSalary =
    employees.Max(e => e.Salary);
```

---

## Count

```csharp
var count =
    employees.Count(e => e.DeptId == 1);
```

---

## Average

```csharp
var averageSalary =
    employees.Average(e => e.Salary);
```

---

## Sum

```csharp
var totalSalary =
    employees.Sum(e => e.Salary);
```

---

# 📈 Employees Above Average Salary

The average salary can be calculated first:

```csharp
var averageSalary =
    employees.Average(e => e.Salary);
```

Then used in another query:

```csharp
var query =
    employees.Where(
        e => e.Salary > averageSalary);
```

---

# 👥 OfType

`OfType<T>()` filters elements based on their runtime type.

Example:

```csharp
List<User> users =
    new List<User>
    {
        new Male
        {
            Id = 1,
            Name = "Admin 1"
        },

        new Male
        {
            Id = 2,
            Name = "Admin 2"
        },

        new Female
        {
            Id = 3,
            Name = "Customer 1"
        },

        new Female
        {
            Id = 4,
            Name = "Customer 2"
        }
    };
```

Get only `Male` objects:

```csharp
var males =
    users.OfType<Male>();
```

Get only `Female` objects:

```csharp
var females =
    users.OfType<Female>();
```

---

# 🔀 Concat, Union, Except, Intersect

These are **set operators**.

Example:

```csharp
List<int> list1 =
    new List<int>
    {
        1, 1, 1, 2, 2, 2,
        3, 4, 5, 6, 7, 8, 9
    };

List<int> list2 =
    new List<int>
    {
        8, 9, 10, 11, 12, 13
    };
```

---

## Concat

Combines two sequences and keeps duplicates.

```csharp
var result =
    list1.Concat(list2);
```

---

## Union

Combines two sequences and removes duplicates.

```csharp
var result =
    list1.Union(list2);
```

---

## Except

Returns elements from the first sequence that are not in the second sequence.

```csharp
var result =
    list1.Except(list2);
```

---

## Intersect

Returns elements that exist in both sequences.

```csharp
var result =
    list1.Intersect(list2);
```

---

# 🔗 Zip Operator

`Zip` combines two sequences element by element.

Example:

```csharp
List<int> nums =
    new List<int>
    {
        1, 2, 3
    };

List<string> names =
    new List<string>
    {
        "Ali", "Ahmed", "Rami"
    };
```

Using:

```csharp
var result =
    nums.Zip(names);
```

Can also project the result:

```csharp
var result =
    nums.Zip(
        names,
        (num, name) => new
        {
            Num = num,
            Name = name
        });
```

The first element is combined with the first element, the second with the second, and so on.

---

# 🔢 Indexed Select

`Select` can provide the element index.

```csharp
var query =
    employees.Select(
        (e, i) => new
        {
            Employee = e,
            Index = i
        });
```

The second parameter represents the zero-based index.

---

# 🔢 Indexed Where

`Where` can also use the element index.

```csharp
var query =
    employees.Where(
        (emp, i) =>
            emp.DeptId == 1 &&
            i < 5);
```

This allows filtering based on both:

* Element value
* Element index

---

# ▶ Running the Project

## 1️⃣ Build Project

```bash
dotnet build
```

---

## 2️⃣ Run Project

```bash
dotnet run
```

---

# 👨‍💻 Author

Mohamed Hatem
Software Engineer
---