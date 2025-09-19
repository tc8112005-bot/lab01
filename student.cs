using System;

namespace lab01_2
{
    // Lớp Student chứa thông tin về sinh viên
    class Student
    {
        // 1. Field
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;

        // 2. Property
        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        // 3. Constructor
        public Student()
        {
        }

        public Student(string studentID, string fullName, float averageScore, string faculty)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.averageScore = averageScore;
            this.faculty = faculty;
        }

        // 4. Methods

        // Nhập thông tin sinh viên
        public void Input()
        {
            Console.Write("Nhập MSSV: ");
            StudentID = Console.ReadLine();
            Console.Write("Nhập Họ tên Sinh viên: ");
            FullName = Console.ReadLine();
            Console.Write("Nhập Điểm TB: ");
            AverageScore = float.Parse(Console.ReadLine()); // ép sang kiểu float
            Console.Write("Nhập Khoa: ");
            Faculty = Console.ReadLine();
        }

        // Hiển thị thông tin sinh viên
        public void Show()
        {
            Console.WriteLine("MSSV: {0}, Họ Tên: {1}, Khoa: {2}, Điểm TB: {3}",
                this.StudentID, this.FullName, this.Faculty, this.AverageScore);
        }
    }
}
