using System;

namespace RealizationAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("홍길동", 1);
            Gorillar gorillar = new Gorillar();
            student.Intro();
            Test(student);
            Test(gorillar);

        }

        static void Test(IStudy study)
        {
            study.Study();
        }
    }
}
