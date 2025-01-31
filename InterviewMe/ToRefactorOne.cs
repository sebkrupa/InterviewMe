namespace InterviewMe.EF;

//SOLID: single responsibility and separating logic
public class ToRefactorOne
{
    public class StudentManager {
        public List<Student> Students { get; set; }

        public StudentManager() {
            Students = new List<Student>();
        }

        public void AddStudent(string name, int age, double grade) {
            var student = new Student {
                Name = name,
                Age = age,
                Grade = grade
            };
            Students.Add(student);
        }

        public double CalculateAverageGrade() {
            if (Students.Count == 0) return 0;
            return Students.Average(s => s.Grade);
        }
    }

    public class Student {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
    }

}

public class RefactoredOne
{
    public class Student {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
    }

    public interface IGradeCalculator {
        double CalculateAverageGrade(List<Student> students);
    }

    public class GradeCalculator : IGradeCalculator {
        public double CalculateAverageGrade(List<Student> students) {
            if (students.Count == 0) return 0;
            return students.Average(s => s.Grade);
        }
    }

    public class StudentManager {
        private List<Student> _students;
        private readonly IGradeCalculator _gradeCalculator;

        public StudentManager(IGradeCalculator gradeCalculator) {
            _students = new List<Student>();
            _gradeCalculator = gradeCalculator;
        }

        public void AddStudent(string name, int age, double grade) {
            var student = new Student {
                Name = name,
                Age = age,
                Grade = grade
            };
            _students.Add(student);
        }

        public double CalculateAverageGrade() {
            return _gradeCalculator.CalculateAverageGrade(_students);
        }
    }
}