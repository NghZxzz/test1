using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_03
{
    class student:person
    {
        private float averageScore;
        private string faculty;

        public student(string iD, string fullName,float averageScore, string faculty)
        {
            this.averageScore = averageScore;
            this.faculty = faculty;
        }

        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }
    }
}
