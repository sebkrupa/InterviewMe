using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InterviewMe.EF
{
    /*README
     - REMOVE OR HIDE THIS COMMENT BEFORE INTERVIEW
     - HIDE ALL METHODS TO NOT GIVE ADVANTAGE AND SHOW ONLY ONES THAT ARE BEING CURRENTLY TESTED WITH CANDIDATE
     
    1:
        _students.Where(s => s.Grade >= 4).Select(s => s.Name).ToList();
    2:
        
    */
    record Student(string Name, int Age, double Grade);

    public class InterviewOne
    {
        List<Student> _students = new List<Student>()
        {
            new Student("John", 20, 3.5),
            new Student("Jane", 21, 4.7),
            new Student("Jill", 22, 5.9),
            new Student("Jake", 23, 3.1),
            new Student("Jenny", 24, 2.7),
            new Student("Jessy", 25, 3.9),
            new Student("Jake", 26, 4.1),
            new Student("Jenny", 27, 4.3)
        };
            
        public void TaskOne()
        {
            //exercise: collection below should contain only names of students with min grade equal to 4
            var _namesOfStudendsWithGradeAbove4 = Enumerable.Empty<Student>(); // <- change this

            foreach (var obj in _namesOfStudendsWithGradeAbove4)
            {
                Console.WriteLine(obj);
            }
        }

        public void TaskTwo()
        {

            var myStudents = _students;
            
            _students.Add(new Student("Eleks",99,6.0));

            foreach (var obj in myStudents)
            {
                Console.WriteLine(obj.Name);
            }
        }
        
        
    }
}