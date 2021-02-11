using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Linked_Lists
{
    public class LinkedList<T>
    {
        private class Node
        {
            public T Element { get; set; }
            public Node NextNode { get; set; }

            public Node(T element)
            {
                Element = element;
                NextNode = null;
            }

            public Node(T element, Node previousNode)
            {
                Element = element;
                previousNode.NextNode = this;
            }
        }
        public LinkedList()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }
        private int Count { get; set; }
        private Node Head { get; set; }
        private Node Tail { get; set; }

        public void Add(T item)
        {
            if (Head == null)
            {
                Head = new Node(item);
                Tail = Head;
            }
            else
            {
                var newNode = new Node(item, Tail);
                Tail = newNode;
            }

            Count++;
            
        }

        public T RemoveAt(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            var currentIndex = 0;
            var currentNode = Head;
            Node previousNode = null;
            while (currentIndex < index)
            {
                previousNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            RemoveNode(currentNode, previousNode);

            return currentNode.Element;
        }

        private void RemoveNode(Node node, Node prevNode)
        {
            Count--;
            if (Count == 0)
            {
                Head = null;
                Tail = null;
            }
            else if (prevNode == null)
            {
                Head = node.NextNode;
            }
            else
            {
                prevNode.NextNode = node.NextNode;
            }

            if (ReferenceEquals(Tail, node))
                Tail = prevNode;
        }

        public int Remove(T item)
        {
            var currentIndex = 0;
            var currentNode = Head;
            Node prevNode = null;

            while (currentNode != null)
            {
                if(Equals(currentNode.Element, item)) break;
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            if (currentNode == null) return -1;

            RemoveNode(currentNode, prevNode);
            return currentIndex;

        }

        public int IndexOf(T item)
        {
            var index = 0;
            var currentNode = Head;
            while (currentNode != null)
            {
                if (Equals(currentNode.Element, item)) return index;
                currentNode = currentNode.NextNode;
                index++;
            }

            return -1;
        }

        public bool Contains(T item)
        {
            var index = IndexOf(item);
            return index != -1;
        }

        public T this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }

                var currentNode = Head;
                for (var i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }

                return currentNode.Element;
            }
            set
            {
                if (index >= Count || index < 0) throw new ArgumentOutOfRangeException("Invalid index: " + index);

                var currentNode = Head;
                for (var i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }

                currentNode.Element = value;
            }
        }

        public int GetLength()
        {
            return Count;
        }
    }
}