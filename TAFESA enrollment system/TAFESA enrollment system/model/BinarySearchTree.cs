using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TAFESA_enrollment_system.model
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {

            public BinarySearchNode<T> Root { get; set; }

            public bool Add(T value)
            {
            BinarySearchNode<T> before = null;
            BinarySearchNode<T> after = this.Root;

                while (after != null)
                {
                    before = after;
                    //left side
                    if (value.CompareTo(after.Data) < 0)
                        after = after.LeftNode;
                    //right side
                    else if (value.CompareTo(after.Data)>0)
                        after = after.RightNode;
                    else
                    {
                        //same value exist
                        return false;
                    }
                }
            BinarySearchNode<T> newNode = new BinarySearchNode<T>(value);
                

                //if tree is empty
                if (this.Root == null)
                {
                    this.Root = newNode;
                }
                else
                {
                    if (value.CompareTo(before.Data)<0)
                        before.LeftNode = newNode;
                    else
                        before.RightNode = newNode;
                }

                return true;
            }

            public BinarySearchNode<T> Find(T value)
            {
                return this.Find(value, this.Root);
            }

            private BinarySearchNode<T> Find(T value, BinarySearchNode<T> parent)
            {
                if (parent != null)
                {
                    if (value.CompareTo(parent.Data)==0)
                        return parent;
                    if (value.CompareTo(parent.Data)<0)
                        return Find(value, parent.LeftNode);
                    else
                        return Find(value, parent.RightNode);
                }
                return null;
            }

            public void Remove(T value)
            {
                this.Root = Remove(this.Root, value);
            }

            private BinarySearchNode<T> Remove(BinarySearchNode<T> parent, T key)
            {
                if (parent == null)
                    return parent;

                if (key.CompareTo(parent.Data)<0)
                    parent.LeftNode = Remove(parent.LeftNode, key);
                else if (key.CompareTo(parent.Data)>0)
                    parent.RightNode = Remove(parent.RightNode, key);

                //if value is same as parent value, then delete it
                else
                {
                    //node with only one child or node
                    if (parent.LeftNode == null)
                        return parent.RightNode;
                    else if (parent.RightNode == null)
                        return parent.LeftNode;
                    //node with two children. get the inorder successor, the smallest on the right
                    parent.Data = MinValue(parent.RightNode);

                    //delete the inorder successor
                    parent.RightNode = Remove(parent.RightNode, parent.Data);

                }
                return parent;
            }

            private T MinValue(BinarySearchNode<T> node)
            {
                T minv = node.Data;

                while (node.LeftNode != null)
                {
                    minv = node.LeftNode.Data;
                    node = node.LeftNode;
                }
                return minv;
            }

            public int GetTreeDepth()
            {
                return this.GetTreeDepth(this.Root);
            }

            private int GetTreeDepth(BinarySearchNode<T> current)
            {
                return current == null ? 0 : Math.Max(GetTreeDepth(current.LeftNode), GetTreeDepth(current.RightNode)) + 1;
            }

        //public void TraversePreOrder(BinarySearchNode<T> parent)
        //{
        //    if (parent != null)
        //    {
        //        Console.Write(parent.Data + " ");
        //        TraversePreOrder(parent.LeftNode);
        //        TraversePreOrder(parent.RightNode);
        //    }
        //}

        public SinglyLinkedList<T> TraversePreOrder(BinarySearchNode<T> parent)
        {
            SinglyLinkedList<T> path= new SinglyLinkedList<T>();
            TraversePreOrder(parent, path);
            return path;
        }

        public void TraversePreOrder(BinarySearchNode<T> parent, SinglyLinkedList<T> path)
        {
            
            if (parent != null)
            {
                
                path.AddLast(parent.Data);
                
                TraversePreOrder(parent.LeftNode, path);
                TraversePreOrder(parent.RightNode, path);
            }
            
        }

        //public void TraverseInOrder(BinarySearchNode<T> parent)
        //    {
        //        if (parent != null)
        //        {
        //            {
        //                TraverseInOrder(parent.LeftNode);
        //                Console.Write(parent.Data + " ");
        //                TraverseInOrder(parent.RightNode);
        //            }
        //        }
        //    }

        public SinglyLinkedList<T> TraverseInOrder(BinarySearchNode<T> parent)
        {
            SinglyLinkedList<T> path = new SinglyLinkedList<T>();
            TraverseInOrder(parent, path);
            return path;
        }

        public void TraverseInOrder(BinarySearchNode<T> parent, SinglyLinkedList<T> path)
        {
            if (parent != null)
            {
                {
                    TraverseInOrder(parent.LeftNode, path);
                    path.AddLast(parent.Data);
                    TraverseInOrder(parent.RightNode, path);
                }
            }
        }

        //public void TraversePostOrder(BinarySearchNode<T> parent)
        //    {
        //        if (parent != null)
        //        {
        //            TraversePostOrder(parent.LeftNode);
        //            TraversePostOrder(parent.RightNode);
        //            Console.Write(parent.Data + " ");
        //        }
        //    }

        public SinglyLinkedList<T> TraversePostOrder(BinarySearchNode<T> parent)
        {
            SinglyLinkedList<T> path = new SinglyLinkedList<T>();
            TraversePostOrder(parent, path);
            return path;
        }

        public void TraversePostOrder(BinarySearchNode<T> parent, SinglyLinkedList<T> path)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode, path);
                TraversePostOrder(parent.RightNode, path);
                path.AddLast(parent.Data);
            }
        }


    }
    }


