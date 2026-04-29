using TAFESA_enrollment_system;
using TAFESA_enrollment_system.model;

namespace TestProjectSearchSort
{

    public class SinglyTests
    {


        private SinglyLinkedList<Student> SinglyLinkedListCreate()
        {
            SinglyLinkedList<Student> StuSinglyLinkedList = new SinglyLinkedList<Student>();
            StuSinglyLinkedList.Add(new Student("10005"));
            StuSinglyLinkedList.Add(new Student("10004"));
            StuSinglyLinkedList.Add(new Student("10003"));
            StuSinglyLinkedList.Add(new Student("10002"));
            StuSinglyLinkedList.Add(new Student("10001"));

            return StuSinglyLinkedList;
        }

        static String DisplaySinglyList(SinglyLinkedList<Student> singlyLinkedList)
        {
            String list = "";
            foreach (Student item in singlyLinkedList)
            {
                list = list + item;
            }
            return list;

        }

        [SetUp]
 
        [Test]
        public void SinglyTest1AddHead()
        {
            SinglyLinkedList<Student> StuSinglyLinkedList = SinglyLinkedListCreate();

            //expected list
            SinglyLinkedList<Student> TestSinglyLinkedList = new SinglyLinkedList<Student>();
            TestSinglyLinkedList.Add(new Student("10005"));
            TestSinglyLinkedList.Add(new Student("10004"));
            TestSinglyLinkedList.Add(new Student("10003"));
            TestSinglyLinkedList.Add(new Student("10002"));
            TestSinglyLinkedList.Add(new Student("10001"));
            TestSinglyLinkedList.Add(new Student("20006"));

            StuSinglyLinkedList.AddFirst(new Student("20006"));

            Assert.That(DisplaySinglyList(TestSinglyLinkedList), Is.EqualTo(DisplaySinglyList(StuSinglyLinkedList)));

        }

        [Test]
        public void SinglyTest2AddTail()
        {
            SinglyLinkedList<Student> StuSinglyLinkedList = SinglyLinkedListCreate();

            //expected list
            SinglyLinkedList<Student> TestSinglyLinkedList = new SinglyLinkedList<Student>();
            TestSinglyLinkedList.Add(new Student("20006"));
            TestSinglyLinkedList.Add(new Student("10005"));
            TestSinglyLinkedList.Add(new Student("10004"));
            TestSinglyLinkedList.Add(new Student("10003"));
            TestSinglyLinkedList.Add(new Student("10002"));
            TestSinglyLinkedList.Add(new Student("10001"));


            StuSinglyLinkedList.AddLast(new Student("20006"));

            Assert.That(DisplaySinglyList(TestSinglyLinkedList), Is.EqualTo(DisplaySinglyList(StuSinglyLinkedList)));

        }

        [Test]
        public void SinglyTest3AddContainsFound()
        {
            SinglyLinkedList<Student> StuSinglyLinkedList = SinglyLinkedListCreate();


            Assert.That(StuSinglyLinkedList.Contains(new Student("10002")), Is.EqualTo(true));

        }
        [Test]
        public void SinglyTest4AddContainsNotFound()
        {
            SinglyLinkedList<Student> StuSinglyLinkedList = SinglyLinkedListCreate();

            Assert.That(StuSinglyLinkedList.Contains(new Student("20006")), Is.EqualTo(false));

        }

        [Test]
        public void SinglyTest5RemoveHead()
        {
            SinglyLinkedList<Student> StuSinglyLinkedList = SinglyLinkedListCreate();

            //expected list
            SinglyLinkedList<Student> TestSinglyLinkedList = new SinglyLinkedList<Student>();
            TestSinglyLinkedList.Add(new Student("10005"));
            TestSinglyLinkedList.Add(new Student("10004"));
            TestSinglyLinkedList.Add(new Student("10003"));
            TestSinglyLinkedList.Add(new Student("10002"));

            StuSinglyLinkedList.RemoveFirst();

            Assert.That(DisplaySinglyList(TestSinglyLinkedList), Is.EqualTo(DisplaySinglyList(StuSinglyLinkedList)));

        }

        [Test]
        public void SinglyTest6RemoveTail()
        {
            SinglyLinkedList<Student> StuSinglyLinkedList = SinglyLinkedListCreate();

            //expected list
            SinglyLinkedList<Student> TestSinglyLinkedList = new SinglyLinkedList<Student>();
            TestSinglyLinkedList.Add(new Student("10004"));
            TestSinglyLinkedList.Add(new Student("10003"));
            TestSinglyLinkedList.Add(new Student("10002"));
            TestSinglyLinkedList.Add(new Student("10001"));


            StuSinglyLinkedList.RemoveLast();

            Assert.That(DisplaySinglyList(TestSinglyLinkedList), Is.EqualTo(DisplaySinglyList(StuSinglyLinkedList)));

        }
    }
}
