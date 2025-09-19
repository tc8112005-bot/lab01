// Lớp Person là lớp cơ sở cho Student và Teacher
using System;

class Person
{
    public string ID { get; set; }
    public string FullName { get; set; }

    public Person() { }

    public Person(string id, string fullName)
    {
        ID = id;
        FullName = fullName;
    }

    // Hiển thị thông tin chung
    public virtual void Show()
    {
        Console.WriteLine("Mã số: {0}, Họ Tên: {1}", ID, FullName);
    }
}

// Lớp Student kế thừa từ Person
class Student : Person
{
    public float AverageScore { get; set; }
    public string Faculty { get; set; }

    public Student() { }

    public Student(string id, string fullName, float averageScore, string faculty)
        : base(id, fullName)
    {
        AverageScore = averageScore;
        Faculty = faculty;
    }

    // Nhập thông tin sinh viên
    public void Input()
    {
        Console.Write("Nhập MSSV: ");
        ID = Console.ReadLine();
        Console.Write("Nhập Họ tên Sinh viên: ");
        FullName = Console.ReadLine();
        Console.Write("Nhập Điểm TB: ");
        AverageScore = float.Parse(Console.ReadLine());
        Console.Write("Nhập Khoa: ");
        Faculty = Console.ReadLine();
    }

    // Hiển thị thông tin sinh viên
    public override void Show()
    {
        base.Show();
        Console.WriteLine("Điểm TB: {0}, Khoa: {1}", AverageScore, Faculty);
    }
}

// Lớp Teacher kế thừa từ Person
class Teacher : Person
{
    public string Address { get; set; }

    public Teacher() { }

    public Teacher(string id, string fullName, string address)
        : base(id, fullName)
    {
        Address = address;
    }

    // Nhập thông tin giảng viên
    public void Input()
    {
        Console.Write("Nhập Mã số Giảng viên: ");
        ID = Console.ReadLine();
        Console.Write("Nhập Họ tên Giảng viên: ");
        FullName = Console.ReadLine();
        Console.Write("Nhập Địa chỉ: ");
        Address = Console.ReadLine();
    }

    // Hiển thị thông tin giảng viên
    public override void Show()
    {
        base.Show();
        Console.WriteLine("Địa chỉ: {0}", Address);
    }
}