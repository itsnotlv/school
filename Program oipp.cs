using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static public void Main()
    {
        Dictionary<int, Student> students = new Dictionary<int, Student>
        {
            { 1001, new Student { Name = "Eleanor", Age = 20 } },
            { 1002, new Student { Name = "Finn", Age = 22 } },
            { 1003, new Student { Name = "Gina", Age = 21 } },
            { 1004, new Student { Name = "Harry", Age = 23 } },
            { 1005, new Student { Name = "Ivy", Age = 19 } },
            { 1006, new Student { Name = "Jack", Age = 24 } },
            { 1007, new Student { Name = "Katie", Age = 20 } },
            { 1008, new Student { Name = "Liam", Age = 22 } },
            { 1009, new Student { Name = "Mia", Age = 21 } },
            { 1010, new Student { Name = "Noah", Age = 25 } }
        };

        Console.WriteLine("Student Dictionary:");
        foreach (var student in students)
        {
            Console.WriteLine($"Key: {student.Key}, Name: {student.Value.Name}, Age: {student.Value.Age}");
        }

        Console.WriteLine("\nSorted Students by Student Number:");
        SortedDictionary<int, Student> sortedStudents = new SortedDictionary<int, Student>(students);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Student Number: {student.Key}, Name: {student.Value.Name}");
        }

        List<Student> studentsByAge = new List<Student>(students.Values);
        studentsByAge.Sort((s1, s2) => s1.Age.CompareTo(s2.Age));

        Console.WriteLine($"\nOldest Student: Name: {studentsByAge[studentsByAge.Count - 1].Name}, Age: {studentsByAge[studentsByAge.Count - 1].Age}");

        Console.WriteLine("\nStudents Sorted by Age:");
        foreach (var student in studentsByAge)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }
    }
}
