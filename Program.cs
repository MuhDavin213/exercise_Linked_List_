using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    class Node
    {
        public int rollNumber;
        public string name;
        public string next;
    }
    class CircularList
    {
        Node LAST;
        public CircularList()
        {
            LAST = null;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
