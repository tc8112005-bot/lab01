using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_2
{
internal class Program
    {
        static void Main(string[] args)
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;    
        List<Student> studentList = new List<Student>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Hiển thị danh sách sinh viên");
                Console.WriteLine("3. Danh sách sinh viên khoa CNTT");
                Console.WriteLine("4. Danh sách sinh viên có điểm TB >= 5");
                Console.WriteLine("5. Sắp xếp sinh viên theo điểm TB");
                Console.WriteLine("6. Sinh viên khoa CNTT có điểm TB >= 5");
                Console.WriteLine("7. Sinh viên khoa CNTT có điểm TB cao nhất");
                Console.WriteLine("8. Sinh viên khoa CNTT có điểm TB thấp nhất");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng (0-8): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(studentList);
                        break;
                    case "2":
                        DisplayStudentList(studentList);
                        break;
                    case "3":
                        DisplayStudentsByFaculty(studentList, "CNTT");
                        break;
                    case "4":
                        DisplayStudentsWithHighAverageScore(studentList, 5);
                        break;
                    case "5":
                        SortStudentsByAverageScore(studentList);
                        break;
                    case "6":
                        DisplayStudentsByFacultyAndScore(studentList, "CNTT", 5);
                        break;
                    case "7":
                        DisplayStudentsWithHighestAverageScoreByFaculty(studentList, "CNTT");
                        break;
                    case "8":
                        DisplayStudentsWithLowestAverageScoreByFaculty(studentList, "CNTT");
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

        // case1
        static void AddStudent(List<Student> studentList)
        {
            Console.WriteLine("=== Nhập thông tin sinh viên ===");
            Student student = new Student();
            student.Input();
            studentList.Add(student);
            Console.WriteLine("Thêm sinh viên thành công!");
        }

        // case 2
        
        static void DisplayStudentList(List<Student> studentList)
        {
            Console.WriteLine("=== Danh sách chi tiết thông tin sinh viên ===");
            foreach (Student student in studentList)
            {
                student.Show();
            }
        }

        // case 3
        static void DisplayStudentsByFaculty(List<Student> studentList, string faculty)
        {
            Console.WriteLine("=== Danh sách sinh viên thuộc khoa {0} ===", faculty);
            var students = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudentList(students);
        }

        // case 4
        static void DisplayStudentsWithHighAverageScore(List<Student> studentList, float minDTB)
        {
            Console.WriteLine("=== Danh sách sinh viên có điểm TB >= {0} ===", minDTB);
            var students = studentList.Where(s => s.AverageScore >= minDTB).ToList();
            DisplayStudentList(students);
        }

        // case 5
        static void SortStudentsByAverageScore(List<Student> studentList)
        {
            Console.WriteLine("=== Danh sách sinh viên được sắp xếp theo điểm trung bình tăng dần ===");
            var sortedStudents = studentList.OrderBy(s => s.AverageScore).ToList();
            DisplayStudentList(sortedStudents);
        }

        // case 6
        static void DisplayStudentsByFacultyAndScore(List<Student> studentList, string faculty, float minDTB)
        {
            Console.WriteLine("=== Danh sách sinh viên có điểm TB >= {0} và thuộc khoa {1} ===", minDTB, faculty);
            var students = studentList.Where(s => s.AverageScore >= minDTB && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudentList(students);
        }

        // case 7
        static void DisplayStudentsWithHighestAverageScoreByFaculty(List<Student> studentList, string faculty)
        {
            Console.WriteLine("=== Sinh viên có điểm TB cao nhất trong khoa {0} ===", faculty);
            var highestScoreStudent = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase))
                                                 .OrderByDescending(s => s.AverageScore)
                                                 .FirstOrDefault();
            if (highestScoreStudent != null)
            {
                highestScoreStudent.Show();
            }
            else
            {
                Console.WriteLine("Không có sinh viên trong khoa này.");
            }
        }

        // case 8
        static void DisplayStudentsWithLowestAverageScoreByFaculty(List<Student> studentList, string faculty)
        {
            Console.WriteLine("=== Sinh viên có điểm TB thấp nhất trong khoa {0} ===", faculty);
            var lowestScoreStudent = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase))
                                                 .OrderBy(s => s.AverageScore)
                                                 .FirstOrDefault();
            if (lowestScoreStudent != null)
            {
                lowestScoreStudent.Show();
            }
            else
            {
                Console.WriteLine("Không có sinh viên trong khoa này.");
            }
        }
    }
}
