using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    internal class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public decimal Cost { get; set; }
        public List<Enrollment> Enrollments { get; set; }

        public Course(string courseCode, string courseName, decimal cost)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Cost = cost;
            Enrollments = new List<Enrollment>();
        }

        // Method to add an enrollment to the course
        public void AddEnrollment(Enrollment enrollment)
        {
            Enrollments.Add(enrollment);
        }

        // Method to display course details
        public override string ToString()
        {
            string courseDetails = $"Course Code: {CourseCode}\nCourse Name: {CourseName}\nCost: {Cost:C}";
            string enrollmentDetails = Enrollments.Any() ? $"Enrollments: {Enrollments.Count}" : "No enrollments available";

            return $"{courseDetails}\n{enrollmentDetails}";
        }
    }
}
