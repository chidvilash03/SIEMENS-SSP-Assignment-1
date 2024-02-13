using System;

namespace GradeClassificationClass
{
    //define GradeClassififcationClass
    class GradeClassification
    {
        public int marks;
        public GradeClassification(int x)
        {
            marks = x;
        }


        //method to return the grade
        public string GetGradeClassification()
        {
            switch (marks)
            {
                case int n when (n >= 90 && n <= 100):
                    return "A";
                case int n when (n >= 80 && n < 90):
                    return "B";
                case int n when (n >= 70 && n < 80):
                    return "C";
                case int n when (n >= 60 && n < 70):
                    return "D";
                case int n when (n >= 0 && n < 60):
                    return "F";
                default:
                    return "Invalid Grade";
            }
        }
    }

}