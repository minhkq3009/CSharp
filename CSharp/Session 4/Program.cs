//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static List<Student> students = new List<Student>();

//    static void Main(string[] args)
//    {
//        bool exit = false;
//        while (!exit)
//        {
//            Console.WriteLine("------ MENU ------");
//            Console.WriteLine("1. Thêm sinh viên");
//            Console.WriteLine("2. Cập nhật thông tin sinh viên bởi ID");
//            Console.WriteLine("3. Xóa sinh viên bởi ID");
//            Console.WriteLine("4. Tìm kiếm sinh viên theo tên");
//            Console.WriteLine("5. Sắp xếp sinh viên theo điểm trung bình (GPA)");
//            Console.WriteLine("6. Sắp xếp sinh viên theo tên");
//            Console.WriteLine("7. Sắp xếp sinh viên theo ID");
//            Console.WriteLine("8. Hiển thị danh sách sinh viên");
//            Console.WriteLine("9. Thoát");
//            Console.WriteLine("------------------");

//            Console.Write("Nhập lựa chọn của bạn: ");
//            int choice = Convert.ToInt32(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    AddStudent();
//                    break;
//                case 2:
//                    UpdateStudent();
//                    break;
//                case 3:
//                    RemoveStudent();
//                    break;
//                case 4:
//                    SearchStudentByName();
//                    break;
//                case 5:
//                    SortStudentsByGPA();
//                    break;
//                case 6:
//                    SortStudentsByName();
//                    break;
//                case 7:
//                    SortStudentsById();
//                    break;
//                case 8:
//                    DisplayStudents();
//                    break;
//                case 9:
//                    exit = true;
//                    break;
//                default:
//                    Console.WriteLine("Lựa chọn không hợp lệ!");
//                    break;
//            }
//        }
//    }

//    static void AddStudent()
//    {
//        Student student = new Student();
//        Console.WriteLine("Nhập thông tin sinh viên:");
//        Console.Write("ID: ");
//        student.Id = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Tên: ");
//        student.Name = Console.ReadLine();
//        Console.Write("Giới tính: ");
//        student.Gender = Console.ReadLine();
//        Console.Write("Tuổi: ");
//        student.Age = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Điểm Toán: ");
//        student.MathScore = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Điểm Lý: ");
//        student.PhysicsScore = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Điểm Hóa: ");
//        student.ChemistryScore = Convert.ToDouble(Console.ReadLine());

//        student.CalculateAverageScore();
//        student.CalculateAcademicPerformance();

//        students.Add(student);
//        Console.WriteLine("Thêm sinh viên thành công!");
//    }

//    static void UpdateStudent()
//    {
//        Console.Write("Nhập ID của sinh viên cần cập nhật: ");
//        int id = Convert.ToInt32(Console.ReadLine());
//        Student student = students.Find(s => s.Id == id);
//        if (student != null)
//        {
//            Console.WriteLine("Nhập thông tin mới:");
//            Console.Write("Tên: ");
//            student.Name = Console.ReadLine();
//            Console.Write("Giới tính: ");
//            student.Gender = Console.ReadLine();
//            Console.Write("Tuổi: ");
//            student.Age = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Điểm Toán: ");
//            student.MathScore = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Điểm Lý: ");
//            student.PhysicsScore = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Điểm Hóa: ");
//            student.ChemistryScore = Convert.ToDouble(Console.ReadLine());

//            student.CalculateAverageScore();
//            student.CalculateAcademicPerformance();

//            Console.WriteLine("Cập nhật thông tin sinh viên thành công!");
//        }
//        else
//        {
//            Console.WriteLine("Không tìm thấy sinh viên có ID này!");
//        }
//    }

//    static void RemoveStudent()
//    {
//        Console.Write("Nhập ID của sinh viên cần xóa: ");
//        int id = Convert.ToInt32(Console.ReadLine());
//        Student student = students.Find(s => s.Id == id);
//        if (student != null)
//        {
//            students.Remove(student);
//            Console.WriteLine("Xóa sinh viên thành công!");
//        }
//        else
//        {
//            Console.WriteLine("Không tìm thấy sinh viên có ID này!");
//        }
//    }

//    static void SearchStudentByName()
//    {
//        Console.Write("Nhập tên sinh viên cần tìm: ");
//        string name = Console.ReadLine();
//        List<Student> result = students.FindAll(s => s.Name.ToLower().Contains(name.ToLower()));
//        if (result.Count > 0)
//        {
//            Console.WriteLine("Danh sách sinh viên:");
//            DisplayStudents(result);
//        }
//        else
//        {
//            Console.WriteLine("Không tìm thấy sinh viên có tên này!");
//        }
//    }

//    static void SortStudentsByGPA()
//    {
//        List<Student> sortedList = students.OrderByDescending(s => s.AverageScore).ToList();
//        Console.WriteLine("Danh sách sinh viên được sắp xếp theo GPA:");
//        DisplayStudents(sortedList);
//    }

//    static void SortStudentsByName()
//    {
//        List<Student> sortedList = students.OrderBy(s => s.Name).ToList();
//        Console.WriteLine("Danh sách sinh viên được sắp xếp theo tên:");
//        DisplayStudents(sortedList);
//    }

//    static void SortStudentsById()
//    {
//        List<Student> sortedList = students.OrderBy(s => s.Id).ToList();
//        Console.WriteLine("Danh sách sinh viên được sắp xếp theo ID:");
//        DisplayStudents(sortedList);
//    }

//    static void DisplayStudents(List<Student> list = null)
//    {
//        List<Student> displayList = list ?? students;
//        foreach (var student in displayList)
//        {
//            Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}, Giới tính: {student.Gender}, Điểm TB: {student.AverageScore}, Học lực: {student.AcademicPerformance}");
//        }
//    }
//}
