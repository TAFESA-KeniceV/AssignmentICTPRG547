using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TAFESA_enrollment_system.model
{
    public class BinarySearchNode<T> where T : IComparable<T>
    {
        public BinarySearchNode<T> LeftNode { get; set; }
        public BinarySearchNode<T> RightNode { get; set; }
        public  T Data { get; set; }
        public BinarySearchNode(T value)
        {
            Data = value;
            LeftNode = null;
            RightNode = null;
        }
    }
}
