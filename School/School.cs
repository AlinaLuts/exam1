using System.Collections.Generic;
using System.Linq;


public class School
{
    private List<Student> studentList = new List<Student>();
    private List<Teacher> teacherList = new List<Teacher>();

    public List<Student> StudentList
    {
        get
        {
            return studentList;
        }
        private set
        {
            studentList = value;
        }
    }

    public List<Teacher> TeacherList
    {
        get
        {
            return teacherList;
        }
        private set
        {
            teacherList = value;
        }
    }

    public School() { }

    public void AddStudent(Student student)
    {
        studentList.Add(student);
    }
    public void AddTeacher(Teacher teacher)
    {
        teacherList.Add(teacher);
    }

    public string GetAllStudentsInfo()
    {
        string result = "";

        foreach (var student in studentList)
        {
            result += student.Info() + "\n";
        }
        return result;
    }

    public string GetAllTeachersInfo()
    {
        string result = "";

        foreach (var teacher in teacherList)
        {
            result += teacher.Info() + "\n";
        }
        return result;
    }

    public Student TryGetStudentByName(string fullname)
    {
        if (string.IsNullOrEmpty(fullname))
        {
            return null;
        }
        return studentList.Where(student => student.Fullname == fullname).FirstOrDefault();//вернет студента где имя совпадает с тем что мы ввели
    }

    public Teacher TryGetTeacherByName(string fullname)
    {
        if (string.IsNullOrEmpty(fullname))
        {
            return null;
        }
        return teacherList.Where(teacher => teacher.Fullname == fullname).FirstOrDefault(); 
    }

}

