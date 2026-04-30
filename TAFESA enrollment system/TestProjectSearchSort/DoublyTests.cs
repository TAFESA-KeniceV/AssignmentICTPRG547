using TAFESA_enrollment_system;
using TAFESA_enrollment_system.model;

namespace TestProjectSearchSort
{

    public class DoublyTests
    {


        private DoublyLinkedList<Student> DoublyLinkedListCreate()
        {
            DoublyLinkedList<Student> StuDoublyLinkedList = new DoublyLinkedList<Student>();
            StuDoublyLinkedList.Add(new Student("10005"));
            StuDoublyLinkedList.Add(new Student("10004"));
            StuDoublyLinkedList.Add(new Student("10003"));
            StuDoublyLinkedList.Add(new Student("10002"));
            StuDoublyLinkedList.Add(new Student("10001"));

            return StuDoublyLinkedList;
        }

        static String DisplayDoublyList(DoublyLinkedList<Student> doublyLinkedList)
        {
            String list = "";
            foreach (Student item in doublyLinkedList)
            {
                list = list + item;
            }
            return list;

        }

        [SetUp]

        [Test]
        public void DoublyTest1AddHead()
        {
            DoublyLinkedList<Student> StuDoublyLinkedList = DoublyLinkedListCreate();

            //expected list
            DoublyLinkedList<Student> TestDoublyLinkedList = new DoublyLinkedList<Student>();
            TestDoublyLinkedList.Add(new Student("10005"));
            TestDoublyLinkedList.Add(new Student("10004"));
            TestDoublyLinkedList.Add(new Student("10003"));
            TestDoublyLinkedList.Add(new Student("10002"));
            TestDoublyLinkedList.Add(new Student("10001"));
            TestDoublyLinkedList.Add(new Student("20006"));

            StuDoublyLinkedList.AddFirst(new Student("20006"));

            Assert.That(DisplayDoublyList(TestDoublyLinkedList), Is.EqualTo(DisplayDoublyList(StuDoublyLinkedList)));

        }

        [Test]
        public void DoublyTest2AddTail()
        {
            DoublyLinkedList<Student> StuDoublyLinkedList = DoublyLinkedListCreate();

            //expected list
            DoublyLinkedList<Student> TestDoublyLinkedList = new DoublyLinkedList<Student>();
            TestDoublyLinkedList.Add(new Student("20006"));
            TestDoublyLinkedList.Add(new Student("10005"));
            TestDoublyLinkedList.Add(new Student("10004"));
            TestDoublyLinkedList.Add(new Student("10003"));
            TestDoublyLinkedList.Add(new Student("10002"));
            TestDoublyLinkedList.Add(new Student("10001"));

            StuDoublyLinkedList.AddLast(new Student("20006"));

            Assert.That(DisplayDoublyList(TestDoublyLinkedList), Is.EqualTo(DisplayDoublyList(StuDoublyLinkedList)));

        }

        [Test]
        public void DoublyTest3AddContainsFound()
        {
            DoublyLinkedList<Student> StuDoublyLinkedList = DoublyLinkedListCreate();


            Assert.That(StuDoublyLinkedList.Contains(new Student("10002")), Is.EqualTo(true));

        }
        [Test]
        public void DoublyTest4AddContainsNotFound()
        {
            DoublyLinkedList<Student> StuDoublyLinkedList = DoublyLinkedListCreate();

            Assert.That(StuDoublyLinkedList.Contains(new Student("20006")), Is.EqualTo(false));

        }

        [Test]
        public void DoublyTest5RemoveHead()
        {
            DoublyLinkedList<Student> StuDoublyLinkedList = DoublyLinkedListCreate();

            //expected list
            DoublyLinkedList<Student> TestDoublyLinkedList = new DoublyLinkedList<Student>();
            TestDoublyLinkedList.Add(new Student("10005"));
            TestDoublyLinkedList.Add(new Student("10004"));
            TestDoublyLinkedList.Add(new Student("10003"));
            TestDoublyLinkedList.Add(new Student("10002"));

            StuDoublyLinkedList.RemoveFirst();

            Assert.That(DisplayDoublyList(TestDoublyLinkedList), Is.EqualTo(DisplayDoublyList(StuDoublyLinkedList)));

        }

        [Test]
        public void DoublyTest6RemoveTail()
        {
            DoublyLinkedList<Student> StuDoublyLinkedList = DoublyLinkedListCreate();

            //expected list
            DoublyLinkedList<Student> TestDoublyLinkedList = new DoublyLinkedList<Student>();
            
            TestDoublyLinkedList.Add(new Student("10004"));
            TestDoublyLinkedList.Add(new Student("10003"));
            TestDoublyLinkedList.Add(new Student("10002"));
            TestDoublyLinkedList.Add(new Student("10001"));

            StuDoublyLinkedList.RemoveLast();

            Assert.That(DisplayDoublyList(TestDoublyLinkedList), Is.EqualTo(DisplayDoublyList(StuDoublyLinkedList)));


        }
    }
}
