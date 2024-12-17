using System.Data.Entity;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}



class Program
{
    static void Main(string[] args)
    {
        using (var context = new StudentContext())
        {
            var student = new Student
            {
                FirstName = "John",
                LastName = "Doe"
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully.");
        }
    }
}
