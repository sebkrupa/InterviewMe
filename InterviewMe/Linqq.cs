namespace InterviewMe.EF
{
    /*README
     - REMOVE OR HIDE THIS COMMENT BEFORE INTERVIEW
     - HIDE ALL METHODS TO NOT GIVE ADVANTAGE AND SHOW ONLY ONES THAT ARE BEING CURRENTLY TESTED WITH CANDIDATE
     
    1:
        _students.Where(s => s.Grade >= 4).Select(s => s.Name).ToList();
    2:
        namesOfStudentsWithGradeAbove4 = students
           .Where(s => s.Grade >= 4)
           .GroupBy(s => s.Name)
           .Select(g => g.MaxBy(s => s.Grade))
           .OrderByDescending(s => s.Name);
    3:
        it will appear - because of materialization.
        where it materializes? foreach
        how to enforce materialization during linq query? eg. ToList/ToArray

    4:
        var currentYear = DateTime.UtcNow;
        var studentsWithYears = students.Select(s => new
           { s.Name, s.Age, s.StudiesStartDate, YearsStudied = currentYear.Year - s.StudiesStartDate });
    
    5:
        var joinedStudents = students.Join(teachers, s => s.TeacherId, t => t.id, (s, t) => new { s,t } );
    */
    record Student(int id, string Name, int Age, int StudiesStartDate, double Grade, int TeacherId);

    record Teacher(int id, string Name);

    public class Linqq
    {
        List<Student> students = new List<Student>()
        {
            new Student(1, "John", 20, 2020, 3.5,1),
            new Student(2,"Jane", 21, 2021, 4.7,1),
            new Student(3, "Jill", 22, 2020, 5.9,2),
            new Student(4, "Jake", 23, 2024, 4.1,3),
            new Student(5, "Jenny", 24, 2021, 4.3,2),
            new Student(6, "Jessy", 25, 2018, 3.9,1),
            new Student(7, "Jake", 26, 2019, 4.2,1),
            new Student(8, "Jenny", 27, 2021, 4.7,3)
        };

        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher(1, "Carl"),
            new Teacher(2, "Christian"),
            new Teacher(3, "Cosmo"),
            new Teacher(4, "Cake"),
            new Teacher(5, "Cindy")
        };
        
        public void TaskOne()
        {
            //exercise: collection below should contain only names of students with min grade equal to 4.
            var namesOfStudendsWithGradeAbove4 = Enumerable.Empty<Student>(); // <- change this

            foreach (var obj in namesOfStudendsWithGradeAbove4)
            {
                Console.WriteLine(obj);
            }
        }
        
        public void TaskTwo()
        {
            //exercise: collection below should contain only students with min grade equal to 4.
            //collection should be ordered A-Z
            //if names are duplicated, collection should have only one name with the highest grade
            
            var namesOfStudentsWithGradeAbove4 = Enumerable.Empty<Student>(); // <- change this
            
            foreach (var obj in namesOfStudentsWithGradeAbove4)
            {
                Console.WriteLine($"{obj.Name} - {obj.Grade}");
            }
        }

        public void TaskThree()
        {
            //question: without running the code, will 'Eleks' appear or not? why?
            var myStudents = students.Select(s => s.Name);
            
            students.Add(new Student(9,"Eleks",99, 2023, 6.0, 1));

            foreach (var obj in myStudents)
            {
                Console.WriteLine(obj);
            }
        }

        public void TaskFour()
        {
            //exercise: Project student data into a new format that includes the number of years they have been studying.
        }

        public void TaskFive()
        {
            //exercise: combine two collections (students and teachers) into a single collection where each student will have their corresponding Teachers
        }
    }
}