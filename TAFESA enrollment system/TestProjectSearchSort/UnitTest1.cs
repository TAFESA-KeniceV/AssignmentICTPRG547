using TAFESA_enrollment_system;
using TAFESA_enrollment_system.model;

namespace TestProjectSearchSort
{

    public class Tests
    {

        private Student[] studentArray = {
            new Student("10001"),
            new Student("10003"),
            new Student("10009"),
            new Student("10004"),
            new Student("10005"),
            new Student("10006"),
            new Student("10002"),
            new Student("10007"),
            new Student("10008"),
            new Student("10010")
            };

        [SetUp]
        public void Setup()
        {



        }

        [Test]
        public void Test1LinearFound()
        {


            Student stu1 = new Student("10004");

            Assert.That(3, Is.EqualTo(Utility.LinearSearchArray<Student>(studentArray, stu1)));
        }
        [Test]
        public void Test2LinearNotFound()
        {

            Student stu1 = new Student("10012");

            Assert.That(-1, Is.EqualTo(Utility.LinearSearchArray<Student>(studentArray, stu1)));
        }

        [Test]
        public void Test3BinarySearchFound()
        {

            Student stu1 = new Student("10005");

            Assert.That(4, Is.EqualTo(Utility.BinarySearch<Student>(studentArray, stu1)));
        }
        [Test]
        public void Test4BinarySearchNotFound()
        {

            Student stu1 = new Student("10012");

            Assert.That(-1, Is.EqualTo(Utility.BinarySearch<Student>(studentArray, stu1)));
        }
        [Test]
        public void Test5BubbleSortAscdPass()
        {

            Student[] testArray = {
            new Student("10001"),
            new Student("10002"),
            new Student("10003"),
            new Student("10004"),
            new Student("10005"),
            new Student("10006"),
            new Student("10007"),
            new Student("10008"),
            new Student("10009"),
            new Student("10010")
            };
            Utility.BubbleSortAscd<Student>(studentArray);

            Assert.That(testArray, Is.EqualTo(studentArray));
        }

        [Test]
        public void Test5BubbleSortAscdFail()
        {

            Student[] testArray = {
            new Student("10001"),
            new Student("10002"),
            new Student("10007"),
            new Student("10008"),
            new Student("10003"),
            new Student("10004"),
            new Student("10005"),
            new Student("10006"),
            new Student("10009"),
            new Student("10010")
            };
            Utility.BubbleSortAscd<Student>(studentArray);

            Assert.That(testArray, Is.EqualTo(studentArray));
        }

        [Test]
        public void Test5BubbleSortDesdPass()
        {

            Student[] testArray = {
            new Student("10010"),
            new Student("10009"),
            new Student("10008"),
            new Student("10007"),
            new Student("10006"),
            new Student("10005"),
            new Student("10004"),
            new Student("10003"),
            new Student("10002"),
            new Student("10001")
            };
            Utility.BubbleSortDesd<Student>(studentArray);

            Assert.That(testArray, Is.EqualTo(studentArray));
        }

        [Test]
        public void Test5BubbleSortDesdFail()
        {

            Student[] testArray = {
            new Student("10010"),
            new Student("10009"),
            new Student("10004"),
            new Student("10003"),
            new Student("10002"),
            new Student("10001"),
            new Student("10008"),
            new Student("10007"),
            new Student("10006"),
            new Student("10005")

            };
            Utility.BubbleSortDesd<Student>(studentArray);

            Assert.That(testArray, Is.EqualTo(studentArray));
        }
    }
}
