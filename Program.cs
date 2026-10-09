var sv1 = new Student { Name = "Dũng" };
DoiTen(sv1);
Console.WriteLine($"Sau DoiTen : {sv1.Name}");

var sv2 = new Student { Name = "Dũng" };
DoiNguoi(sv2);
Console.WriteLine($"Sau DoiNguoi : {sv2.Name}");

void DoiTen(Student s)
{
    s.Name = "Cường";
}

void DoiNguoi(Student s)
{
    s = new Student { Name = "Cường" };
}

class Student
{
    public string Name { get; set; } = "";
}