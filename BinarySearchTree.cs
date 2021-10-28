using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LeetCode
{
    [JsonObject(MemberSerialization.OptOut)]
    public class BinarySearchTree
    {
        private BinaryNode parent;
        public BinarySearchTree()
        {
            parent = null;
        }

        public BinarySearchTree Insert(int value)
        {
            var newNode = new BinaryNode
            {
                Value = value,
                RightNode = null,
                LeftNode = null
            };
            if (parent == null)
            {
                parent = newNode;
            }

            else
            {
                Traverse(newNode, parent);
            }
            return this;
        }

        public BinarySearchTree Traverse(BinaryNode newNode, BinaryNode root)
        {
            if (newNode.Value > root.Value)
            {
                if (root.RightNode == null)
                {
                    root.RightNode = newNode;
                }
                else
                {
                    root = root.RightNode;
                    Traverse(newNode, root);
                }

            }

            if (newNode.Value < root.Value)
            {
                if (root.LeftNode == null)
                {
                    root.LeftNode = newNode;
                }
                else
                {
                    root = root.LeftNode;
                    Traverse(newNode, root);
                }

            }
            return this;
        }


        //Find using Recursion
        public BinaryNode TraverseFind(int value, BinaryNode root)
        {
            if (value == root.Value)
            {
                return root;
            }
            if (value > root.Value && root.RightNode != null)
            {
                root = root.RightNode;
                TraverseFind(value, root);
            }

            else if (value < root.Value && root.LeftNode !=null)
            {
                root = root.LeftNode;
                TraverseFind(value, root);
            }
            
            return null;
        }

        //Find Using While loop
        public BinaryNode Lookup(int value)
        {
            if (this.parent == null)
            {
                return null;
            }

            while (true)
            {
                if (value == this.parent.Value)
                {
                    return this.parent;
                }
                if (value > this.parent.Value && this.parent.RightNode != null)
                {
                    this.parent = this.parent.RightNode;
                }

                else if (value < this.parent.Value && this.parent.LeftNode != null)
                {
                    this.parent = this.parent.LeftNode;
                }

                else
                {
                    return null;
                }
            }
        }

        public BinarySearchTree Delete(int value)
        {
            var root = this.parent;
            var previousNode = root;
            if (root == null)
            {
                return null;
            }
            while (true)
            {
                if (value == root.Value)
                {
                    if (root.RightNode == null && root.LeftNode == null)
                    {
                        if (previousNode.LeftNode.Value == value)
                        {
                            previousNode.LeftNode = null;
                        }
                        else if (previousNode.RightNode.Value == value)
                        {
                            previousNode.RightNode = null;
                        }

                    }
                    else
                    {
                        root = FindTheReplacement(ref root);
                        if (previousNode.LeftNode.Value == value)
                        {
                            previousNode.LeftNode = root;
                        }
                        else if (previousNode.RightNode.Value == value)
                        {
                            previousNode.RightNode = root;
                        }
                        return this;
                    }

                    return this;
                }
                if (value > root.Value && root.RightNode != null)
                {
                    previousNode = root;
                    root = root.RightNode;

                }

                else if (value < root.Value && root.LeftNode != null)
                {
                    previousNode = root;
                    root = root.LeftNode;
                }

                else 
                {
                    return this;
                }
            }
        }

        public BinaryNode FindTheReplacement(ref BinaryNode root)
        {
            BinaryNode rightNode = new BinaryNode();
            BinaryNode lastButOneNode = new BinaryNode();
            BinaryNode lastNode = new BinaryNode();
            if (root.RightNode != null)
            {
                rightNode = root.RightNode;
                lastButOneNode = rightNode;
            }

            if (rightNode.LeftNode != null)
            {
                lastNode = rightNode.LeftNode;
            }
            while (lastNode != null && lastNode.LeftNode != null)
            {
                lastButOneNode = lastNode;
                lastNode = lastNode.LeftNode;
            }

            if (lastNode.Value == 0 && lastNode.LeftNode == null && lastNode.RightNode == null)
            {
                root.Value = lastButOneNode.Value;
                lastButOneNode = null;
            }

            return root;
        }

        public bool TraverseDelete(int value)
        {

            return false;
        }
    }

    [JsonObject(MemberSerialization.OptOut)]
    public class BinaryNode
    {
        public int Value { get; set; }
        public BinaryNode LeftNode { get; set; }
        public BinaryNode RightNode { get; set; }
    }
}
