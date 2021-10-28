using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DoublyLinkedList
    {
        DoublyLinkedListNode head = null;
        DoublyLinkedListNode tail = null;
        private int length = 0;
        public DoublyLinkedList(dynamic Value)
        {
            this.head = new DoublyLinkedListNode
            {
                Value = Value,
                Next = null,
                Previous = null
            };
            this.tail = this.head;
            this.length = 1;
        }

        public DoublyLinkedList Append(int value)
        {
            var dataToAppend = new DoublyLinkedListNode
            {
                Value = value,
                Next = null,
                Previous = this.tail
            };
            this.tail.Next = dataToAppend;
            this.tail = dataToAppend;
            this.length += 1;
            return this;
        }

        public DoublyLinkedList Prepend(int value)
        {
            var dataToPrepend = new DoublyLinkedListNode
            {
                Value = value,
                Next = this.head,
                Previous = null
            };
            this.head.Previous = dataToPrepend;
            this.head = dataToPrepend;
            this.length += 1;
            return this;
        }

        public DoublyLinkedList Insert(int index, int value)
        {
            var newDataToInsertAt= this.head;
            for (int i = 0; i <= index; i++)
            {
                if (index == 0)
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

                if (i == index - 1)
                {
                    var dataToInsert = new DoublyLinkedListNode
                    {
                        Value = value,
                        Next = newDataToInsertAt.Next,
                        Previous = newDataToInsertAt
                    };
                    newDataToInsertAt.Next = dataToInsert;
                    this.length += 1;

                }

                newDataToInsertAt = newDataToInsertAt.Next;
            }
            return this;
        }

        public DoublyLinkedList Remove(int index)
        {
            var previousNode = this.head;
            var nextNode = this.head.Next;
            for (int i = 0; i <= index; i++)
            {
                if (index == 0)
                {
                    this.head = this.head.Next;
                    this.head.Previous = null;
                    this.length = length - 1;
                    break;
                }

                if (i == index - 1)
                {
                    previousNode.Next = nextNode.Next;
                    nextNode.Previous = previousNode.Previous;
                    this.length = length - 1;
                    nextNode = nextNode.Next;
                    nextNode.Previous = previousNode;
                    break;
                }

                previousNode = previousNode.Next;
                nextNode = nextNode.Next;

            }
            return this;
        }

    }

    public class DoublyLinkedListNode
    {
        public dynamic Value { get; set; }
        public DoublyLinkedListNode Next { get; set; }
        public DoublyLinkedListNode Previous { get; set; }
    }
}
