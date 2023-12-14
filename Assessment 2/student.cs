using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    internal class student
    {
        internal class Student : Person, IComparable<Student>
        {
            public int StudentId { get; set; }
            public string Program { get; set; }
            public DateTime DateRegistered { get; set; }
            
            public List<Enrollment> Enrollments { get; set; }

            public Student(int studentId, string name, string email, string telNum, string program, DateTime dateRegistered)
                : base(name, email, telNum)
            {
                StudentId = studentId;
                Program = program;
                DateRegistered = dateRegistered;
                Enrollments = new List<Enrollment>();
            }

            // Method to add an enrollment to the student
            public void AddEnrollment(Enrollment enrollment)
            {
                Enrollments.Add(enrollment);
            }

            // Method to display student details
            public override string ToString()
            {
                string studentDetails = $"Student ID: {StudentId}\nProgram: {Program}\nDate Registered: {DateRegistered.ToShortDateString()}";
                
                string enrollmentDetails = Enrollments.Any() ? $"Enrollments: {Enrollments.Count}" : "No enrollments available";

                return $"{base.ToString()}\n{studentDetails}\n{enrollmentDetails}";
            }

            // Override Equals method for equality checks

            public bool Equals(Student other)
            {
                if (other == null)
                    return false;

                // if Student class does not get passed in
                if (!(other is Student))
                    return false;

                return this.StudentId == ((Student)other).StudentId;

            }
            //public override bool Equals(object obj)
            //{
            //    return Equals(obj as Student);
            //}

           

            // Override GetHashCode for consistent hashing

            public override int GetHashCode()
            {
                return this.StudentId.GetHashCode() ^ this.StudentId.GetHashCode() ^ this.DateRegistered.GetHashCode();
            }
            // Implement IComparable<Student> for sorting
            public int CompareTo(Student other)
            {
                // Implement the comparison logic based on your requirements
                return String.Compare(this.Name, other.Name);
            }
        }
    }
}
