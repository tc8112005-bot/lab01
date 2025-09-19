using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace StudentTeacherApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Student> studentList = new List<Student>();
            List<Teacher> teacherList = new List<Teacher>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Thêm giáo viên");
                Console.WriteLine("3. Xuất danh sách sinh viên");
                Console.WriteLine("4. Xuất danh sách giáo viên");
                Console.WriteLine("5. Số lượng sinh viên và giáo viên");
                Console.WriteLine("6. Xuất sinh viên khoa CNTT");
                Console.WriteLine("7. Xuất giáo viên có địa chỉ chứa 'Quận 9'");
                Console.WriteLine("8. Xuất sinh viên khoa CNTT có điểm trung bình cao nhất");
                Console.WriteLine("9. Xếp loại sinh viên");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng (0-9): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(studentList);
                        break;
                    case "2":
                        AddTeacher(teacherList);
                        break;
                    case "3":
                        DisplayStudentList(studentList);
                        break;
                    case "4":
                        DisplayTeacherList(teacherList);
                        break;
                    case "5":
                        DisplayCount(studentList, teacherList);
                        break;
                    case "6":
                        DisplayStudentsByFaculty(studentList, "CNTT");
                        break;
                    case "7":
                        DisplayTeachersByAddress(teacherList, "Quận 9");
                        break;
                    case "8":
                        DisplayHighestAverageScoreStudent(studentList, "CNTT");
                        break;
                    case "9":
                        DisplayStudentClassification(studentList);
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Kết thúc chương trình.");
                        break;
                    default:
                        Console.WriteLine("Tùy chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
                Console.WriteLine();
            }
        }
        // case 1
        static void AddStudent(List<Student> studentList)
        {
            Console.WriteLine("=== Nhập thông tin sinh viên ===");
            Student student = new Student();
            student.Input();
            studentList.Add(student);
            Console.WriteLine("Thêm sinh viên thành công!");
        }
        //case 2
        static void AddTeacher(List<Teacher> teacherList)
        {
            Console.WriteLine("=== Nhập thông tin giáo viên ===");
            Teacher teacher = new Teacher();
            teacher.Input();
            teacherList.Add(teacher);
            Console.WriteLine("Thêm giáo viên thành công!");
        }
        //case 3
        static void DisplayStudentList(List<Student> studentList)
        {
            Console.WriteLine("=== Danh sách sinh viên ===");
            foreach (var student in studentList)
            {
                student.Show();
            }
        }
        //case 4
        static void DisplayTeacherList(List<Teacher> teacherList)
        {
            Console.WriteLine("=== Danh sách giáo viên ===");
            foreach (var teacher in teacherList)
            {
                teacher.Show();
            }
        }
        //case 5
        static void DisplayCount(List<Student> studentList, List<Teacher> teacherList)
        {
            Console.WriteLine("Số lượng sinh viên: " + studentList.Count);
            Console.WriteLine("Số lượng giáo viên: " + teacherList.Count);
        }
        //case 6
        static void DisplayStudentsByFaculty(List<Student> studentList, string faculty)
        {
            Console.WriteLine("=== Danh sách sinh viên khoa {0} ===", faculty);
            var students = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (var student in students)
            {
                student.Show();
            }
        }
        //case 7
        static void DisplayTeachersByAddress(List<Teacher> teacherList, string addressKeyword)
        {
            Console.WriteLine("=== Danh sách giáo viên có địa chỉ chứa '{0}' ===", addressKeyword);
            var teachers = teacherList.Where(t => t.Address.IndexOf(addressKeyword,StringComparison.OrdinalIgnoreCase)>=0).ToList();
            foreach (var teacher in teachers)
            {
                teacher.Show();
            }
        }
        //case 8
        static void DisplayHighestAverageScoreStudent(List<Student> studentList, string faculty)
        {
            Console.WriteLine("=== Sinh viên khoa {0} có điểm trung bình cao nhất ===", faculty);
            var highestScoreStudent = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase))
                                                 .OrderByDescending(s => s.AverageScore)
                                                 .FirstOrDefault();
            if (highestScoreStudent != null)
            {
                highestScoreStudent.Show();
            }
            else
            {
                Console.WriteLine("Không có sinh viên khoa {0}.", faculty);
            }
        }
        //case 9
        static void DisplayStudentClassification(List<Student> studentList)
        {
            int excellent = 0, good = 0, average = 0, weak = 0;
            foreach (var student in studentList)
            {
                if (student.AverageScore >= 8)
                    excellent++;
                else if (student.AverageScore >= 6.5)
                    good++;
                else if (student.AverageScore >= 5)
                    average++;
                else
                    weak++;
            }

            Console.WriteLine("Số lượng sinh viên xếp loại xuất sắc: {0}", excellent);
            Console.WriteLine("Số lượng sinh viên xếp loại giỏi: {0}", good);
            Console.WriteLine("Số lượng sinh viên xếp loại khá: {0}", average);
            Console.WriteLine("Số lượng sinh viên xếp loại yếu: {0}", weak);
        }
    }
}
