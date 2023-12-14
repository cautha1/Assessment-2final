using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assessment_2.student;

namespace Assessment_2
{
    internal class Utility
    {
        public static void Main()
        {



            // Data sample object
            Address address1 = new Address("123 Main St", "Apt 1", "Cityville", "12345", "StateA");
            Address address2 = new Address("456 Oak St", "Suite 3", "Townsville", "67890", "StateB");

            Student student1 = new Student(1, "Cauthan","cauthan@example.com", "0493284650", "Programming", DateTime.Now);
            student1.AddAddress(address1);

            Student student2 = new Student(2, "Winter Summer", "winter@example.com", "987-654-3210", "Engineering", DateTime.Now);
            student2.AddAddress(address2);

            Course course1 = new Course("C0101", "Introduction to Java", 500);
            Course course2 = new Course("AD202", "Advanced Diploma", 700);

            Enrollment enrollment1 = new Enrollment(true, DateTime.Now, "A", student1, course1);
            Enrollment enrollment2 = new Enrollment(true, DateTime.Now, "B", student2, course2);


            Console.WriteLine(student1);
            Console.WriteLine();
            Console.WriteLine(student2);
            Console.WriteLine();
            Console.WriteLine(course1);
            Console.WriteLine();
            Console.WriteLine(course2);
            Console.WriteLine();




            // Sorting and Searching
            List<int> numbers = new List<int> { 5, 2, 8, 1, 7, 3 };
            Console.WriteLine("Original List: " + string.Join(", ", numbers));

            // Sorting
            SortingUtility<int>.QuickSortAscending(numbers);
            Console.WriteLine("Sorted List (Ascending): " + string.Join(", ", numbers));

            SortingUtility<int>.SortDescending(numbers);
            Console.WriteLine("Sorted List (Descending): " + string.Join(", ", numbers));

            // Searching
            int target = 7;
            bool found = SearchingUtility<int>.BinarySearch(numbers, target);
            Console.WriteLine($"Binary Search: Target {target} found? {found}");

            //found = SearchingUtility<int>.LinearSearch(numbers, target);
            Console.WriteLine($"Linear Search: Target {target} found? {found}");

            // Doubly Linked List
            var doublyLinkedList = new DataStructures<int>.DoublyLinkedList<int>();
            doublyLinkedList.AddAtHead(3);
            doublyLinkedList.AddAtTail(7);
            doublyLinkedList.AddAtHead(1);

            Console.Write("Doubly Linked List: ");
            doublyLinkedList.Traverse();

            doublyLinkedList.DeleteNode(7);
            Console.Write("Doubly Linked List after deleting 7: ");
            doublyLinkedList.Traverse();

            // Binary Tree
            var binaryTree = new DataStructures<int>.BinaryTree<int>();
            binaryTree.AddNode(5);
            binaryTree.AddNode(3);
            binaryTree.AddNode(7);
            binaryTree.AddNode(2);
            binaryTree.AddNode(4);
            binaryTree.AddNode(6);
            binaryTree.AddNode(8);

            Console.Write("InOrder Traversal of Binary Tree: ");
            binaryTree.InOrderTraversal();

            Console.WriteLine("Press Enter to exit...");
            
            Console.ReadLine();
        }
    }
}

