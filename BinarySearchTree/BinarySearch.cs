using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //Generic class where T is IComparable
    public class BinarySearch<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }


        //creating get set method for lefttree and righttree
        public BinarySearch<T> leftTree { get; set; }
        public BinarySearch<T> rightTree { get; set; }

        public BinarySearch(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;

        }

        //defining static variables so that we can get proper count 
        public static int leftCount=0, rightCount=0;

        //this variable created to get result of search method
        //public bool result;


        //Creating Add method where parameter as T 

        public void Insert(T item)
        {
            T root=this.NodeData;

            if (root.CompareTo(item) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new BinarySearch<T>(item);

                }
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new BinarySearch<T>(item);
                }
                else
                    this.rightTree.Insert(item);
            }
        }

        //Display method to add elements in respective position

        public void Display()
        {
            Console.WriteLine(this.NodeData.ToString());

            if (this.leftTree != null)
            {
                leftCount++;
                Console.Write("On Left Tree :");
                this.leftTree.Display();
            }

            if (this.rightTree != null)
            {
                rightCount++;
                Console.Write("On Right Tree :");
                this.rightTree.Display();
            }
        }
        //Size method shows element present in the tree

        public void Getsize()
        {
            Console.WriteLine("Size of the tree is :" + " " + (1 + leftCount + rightCount));
        }

        //Search method to search for a particular element 

        public bool Search(T element,BinarySearch<T> node)
        {
            if(node== null)
            return false;

            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Element Found : " + node.NodeData);
                return true;
            }
            //else
            //{
            //    Console.WriteLine("Element Not Found : ");

            //}

            //Now checking to add element in respective Side
            //
            if (element.CompareTo(node.NodeData) < 0)
            {
                Search(element, node.leftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                Search(element, node.rightTree);

            }
          
            return true;

        }

    }
}
