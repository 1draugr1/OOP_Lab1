using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task3
{
    class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }

        public Node(T value)
        {
            this.Value = value;
            Children = new List<Node<T>>();
        }

        public void PrintChildren(int lvl = 1)
        {
            if (lvl == 1)
                Console.WriteLine(Value);
            if (Children.Count == 0)
                return;
            else if (Children.Count > 0)
            {
                foreach (var child in Children)
                {
                    Console.Write(new string('-', lvl));
                    Console.WriteLine(child.Value);
                    if (child.Children.Count > 0)
                    {
                        child.PrintChildren(lvl + 1);
                    }
                }
            }
        }
    }
}
