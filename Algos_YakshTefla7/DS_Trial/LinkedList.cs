/// <summary>
/// NOT YET TESTED
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Algos_YakshTefla7.DS_Trial
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T data)
        {
            this.Data = data;
        }
        public T Data { get; set; }
        public LinkedListNode<T> Previous { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }
    public class LinkedList
    {
        public LinkedListNode<int> FirstNode { get; private set; } = null;
        public LinkedListNode<int> LastNode { get; private set; } = null;

        public LinkedListNode<int> InsertSorted(int data)
        {
            LinkedListNode<int> node = new LinkedListNode<int>(data);

            //empty list
            if (FirstNode == null)
            {
                FirstNode = node;
                LastNode = node;
            }
            else
            {
                //LinkedListNode<T> insertBefore = null;

                LinkedListNode<int> currentNode = FirstNode;

                while (currentNode.Next != null)
                {
                    if(currentNode.Data > data)
                        break;

                    currentNode = currentNode.Next;
                };

                if(currentNode.Data > data)
                {
                    //insert before
                    if (currentNode.Previous != null)
                    {
                        node.Previous = currentNode.Previous;
                        currentNode.Previous.Next = node;
                    }

                    currentNode.Previous = node;
                    node.Next = currentNode;

                    if (currentNode == FirstNode)
                        FirstNode = node;
                }
                else
                {
                    //insert after (InsertLast)
                    currentNode.Next = node;
                    node.Previous = currentNode;

                    if (LastNode == currentNode)
                        LastNode = node;
                }
                
            }

            return node;
        }

        public int IndexOf(int data)
        {
            int index = -1;

            if (FirstNode != null)
            {
                var node = FirstNode;
                int i = 0;

                while (node != null);
                {
                    if (node.Data == data)
                        return i;

                    node = node.Next;
                    i++;
                }
            }

            return index;
        }
        //private LinkedListNode<int> InsertBefore(LinkedListNode<int> node)
        //{
        //    return node;
        //}
    }
}
