using Assessment18.DataContext;
using Microsoft.EntityFrameworkCore;
using System;

class Program
{
    static void Main()
    {
        var connectionString = "server=localhost;database=task18database;user=root;password=mysqlusername@123;";

        var optionsBuilder = new DbContextOptionsBuilder<StudentDataContext>();
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        using (var context = new StudentDataContext(optionsBuilder.Options))
        {
            var students = context.Students.ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Email: {student.Email}");
            }
        }
    }
}

