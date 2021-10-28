using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LinkedList
    {
        Node head = null;
        Node tail = null;
        private int length = 0;
        public LinkedList(dynamic Value)
        {
            this.head = new Node
            {
                Value = Value,
                Next = null
            };
            this.tail = this.head;
            this.length = 1;
        }

        public LinkedList Append(int value)
        {
            var dataToAppend = new Node
            {
                Value = value,
                Next = null
            };
            this.tail.Next = dataToAppend;
            this.tail = dataToAppend;
            this.length += 1;
            return this;
        }

        public LinkedList Prepend(int value)
        {
            var dataToPrepend = new Node
            {
                Value = value,
                Next = this.head
            };
            this.head = dataToPrepend;
            this.length += 1;
            return this;
        }

        public LinkedList Insert(int index, int value)
        {
            var indexToInsertAt = this.head;
            for (int i=0; i <= index; i++)
            {
                if (index == 0 )
                {
                    Prepend(value);
                    this.length += 1;
                    break;
                }

                if (index == this.length - 1 || index >= length)
                {
                    Append(value);
                    this.length += 1;
                    break;
                }

                if (i == index -1)
                {
                    var dataToInsert = new Node
                    {
                        Value = value,
                        Next = indexToInsertAt.Next
                    };
                    indexToInsertAt.Next = dataToInsert;
                    this.length += 1;
                    break;
                }

                indexToInsertAt = indexToInsertAt.Next;
            }
            return this;
        }

        public LinkedList Remove(int index)
        {
            var previousNode = this.head;
            var nextNode = this.head.Next;
            for (int i=0; i <= index; i++)
            {
                if (index == 0)
                {
                    this.head = this.head.Next;
                    this.length = length - 1;
                    break;
                }

                if (i == index-1)
                {
                    previousNode.Next = nextNode.Next;
                    nextNode = nextNode.Next;
                    this.length = length - 1;
                    break;
                }

                previousNode = previousNode.Next;
                nextNode = nextNode.Next;

            }
            return this;
        }

        public LinkedList Reverse()
        {
            var startNode = this.tail;
            for (int i = 0; i < this.length; i++)
            {
                if (i == 0)
                {

                }


            }
            return this;
        }

        private static ListNode result = new ListNode();
        private static ListNode tail1 = result;
        private int carryOver = 0;

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }

            while (l1 != null || l2 != null)
            {

                if (l1 != null && l2 == null)
                {
                    var val = l1.val + carryOver;
                    carryOver = 0;
                    AddItemToResult(val);
                }
                else if (l2 != null && l1 == null)
                {
                    var val = l2.val + carryOver;
                    carryOver = 0;
                    AddItemToResult(val);
                }
                else
                {
                    int val = l1.val + l2.val + carryOver;
                    carryOver = 0;
                    AddItemToResult(val);
                }
                l1 = l1.next;
                l2 = l2.next;
            }
            if (carryOver > 0)
            {
                AddItemToResult(carryOver);
            }
            return result;

        }


        public void AddItemToResult(int val)
        {
            ListNode node = new ListNode();
            if (val >= 10)
            {
                node.val = val;
            }
            else
            {
                carryOver = 1;
                node.val = val % 10;
            }

            if (result == null)
            {
                result = node;
                tail1 = result;
                tail1 = result.next;
            }
            else
            {
                tail1 = node;
                result = tail1;
                tail1 = tail1.next;
            }
        }

    }


    public class ListNode
    {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Node
    {
        public dynamic Value { get; set; }
        public Node Next { get; set; }
    }
}
