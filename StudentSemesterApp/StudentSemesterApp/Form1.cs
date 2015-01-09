using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSemesterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Student aStudent;
        private void saveButton_Click(object sender, EventArgs e)
        {
            aStudent = new Student(idEntryTextBox.Text,nameEntryTextBox.Text,emailEntryTextBox.Text);
            idEntryTextBox.ReadOnly = true;
            nameEntryTextBox.ReadOnly = true;
            emailEntryTextBox.ReadOnly = true;
            MessageBox.Show("Student Information Saved");
        }

        Semester aSemester = new Semester();
        private void addButton_Click(object sender, EventArgs e)
        {
            if (aStudent != null)
            {
                aSemester.semesterSession = semesterSessionComboBox.Text;
                aSemester.currentSemester = currentSemesterComboBox.Text;
                aSemester.midTermMark = Convert.ToInt32(midTermMarkTextBox.Text);
                aSemester.semesterFinalMark = Convert.ToInt32(semesterFinalMarkTextBox.Text);

                aSemester.calculateTotalMark();
                aSemester.CalculateGrade();
                aStudent.studentSemester = aSemester;

                MessageBox.Show("Student Added in : " + aSemester.currentSemester + "Semester");
            }
            else
             {
                 MessageBox.Show("Please save Student Information");
             }
            //semesterSessionComboBox.Text = string.Empty;
            //currentSemesterComboBox.Text = string.Empty;
            midTermMarkTextBox.Text = string.Empty;
            semesterFinalMarkTextBox.Text = string.Empty;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (aStudent != null)
            {
                idDisplayTextBox.Text = aStudent.id;
                nameDisplayTextBox.Text = aStudent.name;
                emailDisplayTextBox.Text = aStudent.email;
                completSemesterTextBox.Text = aStudent.studentSemester.semesterCount.ToString();
                totalMarkTextBox.Text = aStudent.studentSemester.totalMark.ToString();
                gradeTextBox.Text = aStudent.studentSemester.grade;
            }
             else
             {
                 MessageBox.Show("Please save Student Information");
             }
        }
    }
}
