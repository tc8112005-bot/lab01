using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement
{
    class Student
    {  
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{ Id = 1, Name = "Cong", Age = 16 },
                new Student{ Id = 2, Name = "Hung", Age = 18 },
                new Student{ Id = 3, Name = "Chung", Age = 19 },
                new Student{ Id = 4, Name = "Duy", Age = 13},
                new Student{ Id = 5, Name = "Nhu", Age = 17 }
            };

            int choice;
            do
            {
                Console.WriteLine("\n===== MENU QUAN LY HOC SINH =====");
                Console.WriteLine("1. In toan bo danh sach hoc sinh");
                Console.WriteLine("2. Tim hoc sinh co tuoi tu 15 den 18");
                Console.WriteLine("3. Tim hoc sinh co ten bat dau bang chu A");
                Console.WriteLine("4. Tinh tong tuoi tat ca hoc sinh");
                Console.WriteLine("5. Tim hoc sinh co tuoi lon nhat");
                Console.WriteLine("6. Sap xep hoc sinh theo tuoi tang dan");
                Console.WriteLine("0. Thoat");
                Console.Write("Moi ban chon: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nDanh sach toan bo hoc sinh:");
                        foreach (var s in students)
                            Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");
                        break;

                    case 2:
                        Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
                        var ageRange = students.Where(s => s.Age >= 15 && s.Age <= 18);
                        foreach (var s in ageRange)
                            Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");
                        break;

                    case 3:
                        Console.WriteLine("\nHoc sinh co ten bat dau bang chu A:");
                        var startWithA = students.Where(s => s.Name.StartsWith("A"));
                        foreach (var s in startWithA)
                            Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");
                        break;

                    case 4:
                        int totalAge = students.Sum(s => s.Age);
                        Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");
                        break;

                    case 5:
                        var oldest = students.OrderByDescending(s => s.Age).First();
                        Console.WriteLine($"\nHoc sinh lon tuoi nhat: {oldest.Id} - {oldest.Name} - {oldest.Age}");
                        break;

                    case 6:
                        Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
                        var sorted = students.OrderBy(s => s.Age);
                        foreach (var s in sorted)
                            Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");
                        break;

                    case 0:
                        Console.WriteLine("Thoat chuong trinh!");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le. Moi nhap lai!");
                        break;
                }

            } while (choice != 0);
        }
    }
}
