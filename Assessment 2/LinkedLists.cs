using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    public static class DataStructures<T> where T : IComparable<T>
    {
        /// <summary>
        /// Node structure for linked lists and trees.
        /// </summary>
        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }
            public Node<T> Previous { get; set; }

            public Node(T data)
            {
                Data = data;
            }
        }

        /// <summary>
        /// Singly linked list implementation.
        /// </summary>
        public class SinglyLinkedList<T>
        {
            private Node<T> head;

            public void AddAtHead(T data)
            {
                var newNode = new Node<T>(data);

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    newNode.Next = head;
                    head = newNode;
                }
            }

            public void Traverse()
            {
                var current = head;

                while (current != null)
                {
                    Console.Write($"{current.Data} -> ");
                    current = current.Next;
                }

                Console.WriteLine("null");
            }

            public void AddAtTail(T data)
            {
                var newNode = new Node<T>(data);

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    var current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }

                    current.Next = newNode;
                }
            }

            public void DeleteAtHead()
            {
                if (head != null)
                {
                    head = head.Next;
                }
            }

            public void DeleteAtTail()
            {
                if (head == null)
                {
                    return;
                }

                if (head.Next == null)
                {
                    // Only one node in the list
                    head = null;
                    return;
                }

                var current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }

                current.Next = null;
            }

            public bool Contains(T data)
            {
                var current = head;
                while (current != null)
                {
                    if (EqualityComparer<T>.Default.Equals(current.Data, data))
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }
        }



        /// <summary>
        /// Doubly linked list implementation.
        /// </summary>
        public class DoublyLinkedList<T>
        {
            private Node<T> head;
            private Node<T> tail;

            public void AddAtHead(T data)
            {
                var newNode = new Node<T>(data);

                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    newNode.Next = head;
                    head.Previous = newNode;
                    head = newNode;
                }
            }

            public void AddAtTail(T data)
            {
                var newNode = new Node<T>(data);

                if (tail == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    newNode.Previous = tail;
                    tail.Next = newNode;
                    tail = newNode;
                }
            }

            public void DeleteNode(T data)
            {
                var current = head;

                while (current != null)
                {
                    if (EqualityComparer<T>.Default.Equals(current.Data, data))
                    {
                        if (current.Previous != null)
                        {
                            current.Previous.Next = current.Next;
                        }
                        else
                        {
                            head = current.Next;
                        }

                        if (current.Next != null)
                        {
                            current.Next.Previous = current.Previous;
                        }
                        else
                        {
                            tail = current.Previous;
                        }

                        return;
                    }

                    current = current.Next;
                }
            }

            public void Traverse()
            {
                var current = head;

                while (current != null)
                {
                    Console.Write($"{current.Data} <-> ");
                    current = current.Next;
                }

                Console.WriteLine("null");
            }

            public bool Contains(T data)
            {
                var current = head;
                while (current != null)
                {
                    if (EqualityComparer<T>.Default.Equals(current.Data, data))
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }

            public void DeleteAtHead()
            {
                if (head != null)
                {
                    head = head.Next;
                    if (head != null)
                    {
                        head.Previous = null;
                    }
                    else
                    {
                        tail = null;
                    }
                }
            }

            public void DeleteAtTail()
            {
                if (tail != null)
                {
                    tail = tail.Previous;
                    if (tail != null)
                    {
                        tail.Next = null;
                    }
                    else
                    {
                        head = null;
                    }
                }
            }
        }

        /// <summary>
        /// Node structure for binary trees.
        /// </summary>
        public class TreeNode<T>
        {
            public T Data { get; set; }
            public TreeNode<T> Left { get; set; }
            public TreeNode<T> Right { get; set; }

            public TreeNode(T data)
            {
                Data = data;
            }
        }

        /// <summary>
        /// Binary tree implementation.
        /// </summary>
        public class BinaryTree<T>
        {
            public TreeNode<T> Root { get; private set; }

            public void AddNode(T data)
            {
                Root = AddNode(Root, data);
            }

            private TreeNode<T> AddNode(TreeNode<T> node, T data)
            {
                if (node == null)
                {
                    return new TreeNode<T>(data);
                }

                if (Comparer<T>.Default.Compare(data, node.Data) < 0)
                {
                    node.Left = AddNode(node.Left, data);
                }
                else
                {
                    node.Right = AddNode(node.Right, data);
                }

                return node;
            }

            public void InOrderTraversal()
            {
                InOrderTraversal(Root);
            }

            private void InOrderTraversal(TreeNode<T> node)
            {
                if (node != null)
                {
                    InOrderTraversal(node.Left);
                    Console.Write($"{node.Data} ");
                    InOrderTraversal(node.Right);
                }
            }
        }
    }
}

