using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSemesterApp
{
    class Semester
    {
        public string semesterSession { set; get; }
        public string currentSemester { set; get; }
        public int midTermMark { set; private get; }
        public int semesterFinalMark { set; private get; }
        public int semesterCount { private set; get; }
        public string grade { private set; get; }
         
        public int  totalMark { private set; get; }
        public int perSemesterMark { private set; get; }
        public int avgMark { private set; get; }
        public void calculateTotalMark()
        {
            semesterCount++;
            perSemesterMark = (midTermMark + semesterFinalMark) / 2;
            avgMark += perSemesterMark;
            totalMark = avgMark / semesterCount;
            
        }

        public void CalculateGrade()
        {
            if (totalMark >= 80)
            {
                grade = "A+";
            }
            if (totalMark >= 70 && totalMark < 80)
            {
                grade = "B+";
            }
            if (totalMark >= 60 && totalMark < 70)
            {
                grade = "C+";
            }
            if (totalMark >= 50 && totalMark < 60)
            {
                grade = "D+";
            }
            if (totalMark < 50)
            {
                grade = "F";
            }
        }
    }
}
