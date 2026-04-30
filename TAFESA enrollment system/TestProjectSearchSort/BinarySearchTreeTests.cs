using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESA_enrollment_system;
using TAFESA_enrollment_system.model;

namespace TestProjectSearchSort
{
    internal class BinarySearchTreeTests
    {

        private BinarySearchTree<String> CreateTree()
        {
            BinarySearchTree<String> tree = new BinarySearchTree<String>();

            tree.Add("10004");
            tree.Add("10002");
            tree.Add("10006");
            tree.Add("10001");
            tree.Add("10005");
            tree.Add("10003");
            tree.Add("10007");
            

            //        4
            //     /     \
            //    2       6
            //  /   \   /   \
            //  1   3   5   7
            return tree;
        }

        static String DisplaySinglyList(SinglyLinkedList<String> singlyLinkedList)
        {
            String list = "";
            foreach (String item in singlyLinkedList)
            {
                list = list + item + " ";
            }
            return list;

        }


        [Test]
        public void Test1PreOrder()
        {
            BinarySearchTree<String> tree = CreateTree();
            SinglyLinkedList<String> test = tree.TraversePreOrder(tree.Root);
            //expected
            String expected = "10004 10002 10001 10003 10006 10005 10007 ";
            Assert.That(DisplaySinglyList(test), Is.EqualTo(expected));

        }

        [Test]
        public void Test2InOrder()
        {
            BinarySearchTree<String> tree = CreateTree();
            SinglyLinkedList<String> test = tree.TraverseInOrder(tree.Root);
            //expected
            String expected = "10001 10002 10003 10004 10005 10006 10007 ";
            Assert.That(DisplaySinglyList(test), Is.EqualTo(expected));

        }

        [Test]
        public void Test3PostOrder()
        {
            BinarySearchTree<String> tree = CreateTree();
            SinglyLinkedList<String> test = tree.TraversePostOrder(tree.Root);
            //expected
            String expected = "10001 10003 10002 10005 10007 10006 10004 ";
            Assert.That(DisplaySinglyList(test), Is.EqualTo(expected));

        }
    }
}
