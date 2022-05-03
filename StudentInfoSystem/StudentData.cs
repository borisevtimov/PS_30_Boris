using StudentInfoSystem.Enums;
using System.Collections.Generic;
using System.Linq;

namespace StudentInfoSystem
{
    public class StudentData
    {
        public List<Student>? TestStudents { get; private set; }

        public StudentData()
        {
            TestStudents = new List<Student>();

            if (!IsThereStudent("121219000"))
            {
                //TestStudents?.Add(new Student()
                //{
                //    FirstName = "Ivan",
                //    MiddleName = "Georgiev",
                //    LastName = "Ivanov",
                //    Speciality = "Computer and software engineering",
                //    Faculty = "FCST",
                //    Course = 3,
                //    FacultyNumber = "121219000",
                //    Group = 30,
                //    Degree = Degree.Професионално,
                //    Status = EducationStatus.Редовен,
                //    Stream = 9
                //});

            }
        }

        public bool IsThereStudent(string facNum)
        {
            StudentInfoContext context = new StudentInfoContext();

            Student? result = context.Students.SingleOrDefault(s => s.FacultyNumber == facNum);
            return result != null;
        }
    }
}
