using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardAttendenceTracker
{
    public partial class StudentSelect : Form
    {
        Student[] studentInfo;
        public Student SelectedStudent { get; set; }
        public bool IsNewStudent { get; set; }
        public StudentSelect(List<Student> data)
        {
            InitializeComponent();
            studentInfo = data.FindAll(s => string.IsNullOrWhiteSpace(s.CardNumber)).ToArray();
            StudentListBox.Items.AddRange(studentInfo);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SelectedStudent = null;
            IsNewStudent = false;
            this.Close();
            return;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            SelectedStudent = (Student)StudentListBox.SelectedItem;
            IsNewStudent = false;
            this.Close();
            return;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            StudentAdd sa = new StudentAdd();
            if(sa.ShowDialog() == DialogResult.Cancel) { return; }
            SelectedStudent = sa.AddedStudent;
            IsNewStudent = true;
            this.Close();
            return;
        }
    }
}
