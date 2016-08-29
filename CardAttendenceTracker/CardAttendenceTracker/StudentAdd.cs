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
    public partial class StudentAdd : Form
    {
        public Student AddedStudent;

        public StudentAdd()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            AddedStudent = null;
            DialogResult = DialogResult.Cancel;
            this.Close();
            return;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            Student temp = new Student();
            temp.LastName = LastNameTextBox.Text;
            temp.FirstName = FirstNameTextBox.Text;
            temp.Username = UsernameTextBox.Text;
            AddedStudent = temp;
            DialogResult = DialogResult.OK;
            this.Close();
            return;
        }
    }
}
