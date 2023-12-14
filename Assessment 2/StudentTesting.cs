using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assessment_2.student;
using Assessment_2;

public class Class1
{
    [TestFixture]
    class TestingMethods
    {
        

        public static int LinearSearchStudents(Student[] studentsArray, Student targetStudent)
        {
            for (int i = 0; i < studentsArray.Length; i++)
            {
                if (studentsArray[i].Equals(targetStudent))
                {
                    return i; // Student found, return the index
                }
            }

            return -1; // Student not found
        }

        public static int BinarySearchStudents(Student[] studentsArray, Student targetStudent)
        {
            // Sort the array by name
            Array.Sort(studentsArray, (s1, s2) => s1.Name.CompareTo(s2.Name));

            int left = 0;
            int right = studentsArray.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (studentsArray[middle].Name == targetStudent.Name)
                {
                    return middle; // Student found, return the index
                }
                else if (studentsArray[middle].Name.CompareTo(targetStudent.Name) < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1; // Student not found
        }

        public static void BubbleSortStudents(Student[] studentsArray)
        {
            int n = studentsArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Use the overloaded relational operators of the Student class
                    if (studentsArray[j].Name.CompareTo(studentsArray[j + 1].Name) > 0)
                    {
                        // Swap students if they are in the wrong order
                        Student temp = studentsArray[j];
                        studentsArray[j] = studentsArray[j + 1];
                        studentsArray[j + 1] = temp;
                    }
                }
            }
        }

        internal static IEnumerable GetExpectedSortedStudents()
        {
            throw new NotImplementedException();
        }
    }





    [TestFixture]
    public class TestingMethodsTests
    {
       
        [Test]
        public void TestLinearSearchStudents()
        {
            // Arrange
            var studentsArray = GetSampleStudentsArray();
            var targetStudent = new Student(1, "Alice", "alice@example.com", "987-654-3210", "Mathematics", DateTime.Now);

            // Act
            int result = TestingMethods.LinearSearchStudents(studentsArray, targetStudent);

            // Assert
           
            Assert.That(result, Is.EqualTo(1), "Student should be found at index 0");
            Console.WriteLine();
        }



        
        [Test]
        public void TestBinarySearchStudents()
        {
            // Arrange
            var studentsArray = GetSampleStudentsArray();
            Array.Sort(studentsArray, (s1, s2) => s1.Name.CompareTo(s2.Name)); // Ensure the array is sorted by name
            var targetStudent = new Student(9, "Ivy", "ivy@example.com", "987-654-3210", "History", DateTime.Now);
            // Act
            int result = TestingMethods.BinarySearchStudents(studentsArray, targetStudent);

            // Assert
            Assert.That(result, Is.EqualTo(8), "Student should be found at index 8");
        }

        [Test]
        public void TestBubbleSortStudents()
        {
            // Arrange
            var studentsArray = GetSampleStudentsArray();

            // Act
            Assert.DoesNotThrow(() => TestingMethods.BubbleSortStudents(studentsArray), "BubbleSortStudents should not throw an exception");

            // Assert
            CollectionAssert.AreEqual(TestingMethods.GetExpectedSortedStudents(), studentsArray, "Students should be sorted");
        }


        private static Student[] GetSampleStudentsArray()
        {
            return new Student[]
            {
                new Student(0, "John", "john@example.com", "123-456-7890", "Computer Science", DateTime.Now),
                new Student(1, "Alice", "alice@example.com", "987-654-3210", "Mathematics", DateTime.Now),
                new Student(2, "Bob", "bob@example.com", "555-555-5555", "Physics", DateTime.Now),
                new Student(3, "Cathy", "cathy@example.com", "777-777-7777", "Chemistry", DateTime.Now),
                new Student(4, "David", "david@example.com", "123-456-7890", "Biology", DateTime.Now),
                new Student(5, "Eva", "eva@example.com", "987-654-3210", "Art", DateTime.Now),
                new Student(6, "Frank", "frank@example.com", "555-555-5555", "Psychology", DateTime.Now),
                new Student(7, "Grace", "grace@example.com", "777-777-7777", "English Literature", DateTime.Now),
                new Student(8, "Harry", "harry@example.com", "123-456-7890", "Sociology", DateTime.Now),
                new Student(9, "Ivy", "ivy@example.com", "987-654-3210", "History", DateTime.Now),
            };
        }



        // Testing Single Linked List
        [Test]
        public static void TestSingleLinkedList()
        {
            var singleLinkedList = new DataStructures<Student>.SinglyLinkedList<Student>();

            // (a) Add to Head
            singleLinkedList.AddAtHead(new Student(1, "Cauthan", "Cauthan@example.com", "0493284950", "Computer Science", DateTime.Now));

            // Enumerate to check
            Console.Write("Single Linked List (Added at Head): ");
            singleLinkedList.Traverse();

            // (b) Add to Tail
            singleLinkedList.AddAtTail(new Student(2, "Max", "alice@example.com", "987-654-3210", "Mathematics", DateTime.Now));

            // Enumerate to check
            Console.Write("Single Linked List (Added at Tail): ");
            singleLinkedList.Traverse();

            // (c) Search for a specific student
            var targetStudent = new Student(1, "John", "john@example.com", "123-456-7890", "Computer Science", DateTime.Now);
            bool found = singleLinkedList.Contains(targetStudent);
            Console.WriteLine($"Single Linked List: Student {targetStudent.Name} found? {found}");

            // (d) Remove from Head
            singleLinkedList.DeleteAtHead();

            // Enumerate to check
            Console.Write("Single Linked List (Removed from Head): ");
            singleLinkedList.Traverse();

            // (e) Remove from Tail
            singleLinkedList.DeleteAtTail();

            // Enumerate to check
            Console.Write("Single Linked List (Removed from Tail): ");
            singleLinkedList.Traverse();
        }

        // Testing Doubly Linked List
        [Test]
        public static void TestDoublyLinkedList()
        {
            var doublyLinkedList = new DataStructures<Student>.DoublyLinkedList<Student>();

            // (a) Add to Head
            doublyLinkedList.AddAtHead(new Student(1, "John", "john@example.com", "123-456-7890", "Computer Science", DateTime.Now));

            // Enumerate to check
            Console.Write("Doubly Linked List (Added at Head): ");
            doublyLinkedList.Traverse();

            // (b) Add to Tail
            doublyLinkedList.AddAtTail(new Student(2, "Alice", "alice@example.com", "987-654-3210", "Mathematics", DateTime.Now));

            // Enumerate to check
            Console.Write("Doubly Linked List (Added at Tail): ");
            doublyLinkedList.Traverse();

            // (c) Search for a specific student
            var targetStudent = new Student(1, "Cauthan", "cauthan@example.com", "0493284950", "Computer Science", DateTime.Now);
            bool found = doublyLinkedList.Contains(targetStudent);
            Console.WriteLine($"Doubly Linked List: Student {targetStudent.Name} found? {found}");

            // (d) Remove from Head
            doublyLinkedList.DeleteAtHead();

            // Enumerate to check
            Console.Write("Doubly Linked List (Removed from Head): ");
            doublyLinkedList.Traverse();

            // (e) Remove from Tail
            doublyLinkedList.DeleteAtTail();

            // Enumerate to check
            Console.Write("Doubly Linked List (Removed from Tail): ");
            doublyLinkedList.Traverse();
        }

        // Testing Binary Tree
        [Test]
        public static void TestBinaryTree()
        {
            var binaryTree = new DataStructures<Student>.BinaryTree<Student>();

            // Add nodes to the binary tree
            binaryTree.AddNode(new Student(1, "John", "john@example.com", "123-456-7890", "Computer Science", DateTime.Now));
            Console.WriteLine();
            Console.WriteLine();
            binaryTree.AddNode(new Student(2, "Alice", "alice@example.com", "987-654-3210", "Mathematics", DateTime.Now));
            Console.WriteLine();
            binaryTree.AddNode(new Student(3, "Bob", "bob@example.com", "555-555-5555", "Physics", DateTime.Now));
            binaryTree.AddNode(new Student(4, "Cauthan","example.com", "777-777-7777", "Chemistry", DateTime.Now));

            // Perform In-Order Traversal
            Console.Write("Binary Tree In-Order Traversal: ");
            Console.WriteLine();
            binaryTree.InOrderTraversal();
            Console.WriteLine();
        }
    }
}
