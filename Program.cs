using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    //add node
    class Node
    {
        public int rollNumber;
        public string name;
        public string next;
    }
    //add class circularlist
    class CircularList
    {
        Node LAST;
        public CircularList()
        {
            LAST = null;
        }
        public bool search(int rollNo, ref Node previous, ref Node current)
        {
            //add function
            for (previous = current = LAST; current != LAST; previous = current, current = current)
            {
                if (rollNo == current.rollNumber)
                    return (true);
            }
            if (rollNo == LAST.rollNumber)
                return true;
            else
                return (false);
        }
        //add bool list empty
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
        //add void traverse
        public void traverse()
        {
            //add function
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecords in the list are: \n");
                Node currentNode;
                currentNode = LAST;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + "" + currentNode.name + "\n");
                    currentNode = currentNode;
                }
                Console.Write(LAST.rollNumber + "" + LAST.name + "\n");
            }
        }
        //add void firstnode
        public void firstNode()
        {
            if (listEmpty())
                Console.WriteLine("\nlist is empty");
            else
                Console.WriteLine("\nThe first record in the list is:\n\n" + LAST.rollNumber + "" + LAST.name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            CircularList obj = new CircularList();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("\nView all the record in the list");
                    Console.WriteLine("\nSearch for a record in the list");
                    Console.WriteLine("\ndisplay the first record in the list");
                    Console.WriteLine("\nExit");
                    Console.Write("\nEnter your choice (1-4): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.traverse();
                            }
                            break;
                        case '2':
                            {
                                if (obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\nList is empty");
                                    break;
                                }
                                Node prev, curr;
                                prev = curr = null;
                                Console.Write("\nEnter the roll number of the student whose record is to be searched: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.search(num, ref prev, ref curr) == false)
                                    Console.WriteLine("\nRecord not found");
                                else
                                {
                                    Console.WriteLine("\nRecord found");
                                    Console.WriteLine("\nRoll number: " + curr.rollNumber);
                                    Console.WriteLine("\nName: " + curr.name);
                                }

                            }
                            break;
                        case '3':
                            {
                                obj.firstNode();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("invalid option");
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }
    }
}
