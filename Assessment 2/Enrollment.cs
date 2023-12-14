using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assessment_2.student;

namespace Assessment_2
{
    internal class Enrollment
    {
        public bool Enrolled { get; set; }
        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }

        public Enrollment(bool enrolled, DateTime dateEnrolled, string grade, Student student, Course course)
        {
            Enrolled = enrolled;
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Student = student;
            Course = course;
        }

        // Method to display enrollment details
        public override string ToString()
        {
            return $"Enrolled: {Enrolled}\nDate Enrolled: {DateEnrolled.ToShortDateString()}\nGrade: {Grade}";
        }
    }
}
