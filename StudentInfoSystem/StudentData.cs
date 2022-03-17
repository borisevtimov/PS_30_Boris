using StudentInfoSystem.Enums;
using System.Collections.Generic;

namespace StudentInfoSystem
{
    public class StudentData
    {
        public List<Student>? TestStudents { get; private set; }

        public StudentData()
        {
            TestStudents = new List<Student>();

            TestStudents?.Add(new Student()
            {
                FirstName = "Ivan",
                MiddleName = "Georgiev",
                LastName = "Ivanov",
                Speciality = "Computer and software engineering",
                Faculty = "FCST",
                Course = 3,
                FacultyNumber = "121219000",
                Group = 30,
                Degree = Degree.Professional,
                Status = EducationStatus.Assured,
                Stream = 9
            });
        }
    }
}
