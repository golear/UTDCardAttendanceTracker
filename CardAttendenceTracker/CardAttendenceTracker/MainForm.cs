using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CardAttendenceTracker
{
    public partial class MainForm : Form
    {
        List<Student> studentInfo;

        public MainForm()
        {
            InitializeComponent();
            studentInfo = new List<Student>();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            List<Student> output = new List<Student>();

            if(ImportDialog.ShowDialog(this) == DialogResult.Cancel) return;
            
            string filename = ImportDialog.FileName;
            try {
                System.IO.StreamReader file = new System.IO.StreamReader(filename);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] tokens = record.Split(',');
                    tokens = tokens.Select(t => t.Trim('"')).ToArray();
                    if (tokens.Length < 3 || tokens[0] == "Last Name") { continue; }
                    output.Add(new Student(tokens[0], tokens[1], tokens[2], null));
                }

                file.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Can't Open the file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch(Exception) {
                MessageBox.Show("Error in *.csv e-learning format.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            studentInfo = output;
            return;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            List<Student> output = new List<Student>();

            if (ImportDialog.ShowDialog(this) == DialogResult.Cancel) return;

            string filename = ImportDialog.FileName;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(filename);
                string record;
                record = file.ReadLine();
                if (record != null)
                {
                    string[] tokens = record.Split(',');
                    tokens = tokens.Select(t => t.Trim('"')).Select(t => t.Trim(' ')).ToArray();
                    if (tokens[0] != "Last Name" || tokens[1] != "First Name" || tokens[2] != "Username" || tokens[3] != "CardSerial")
                    {
                        throw new Exception();
                    }
                    int pos = 4;
                    List<DateTime> days = new List<DateTime>();
                    while(tokens.Length > pos)
                    {
                        DateTime d = DateTime.MinValue;
                        if(DateTime.TryParse(tokens[pos],out d))
                        {
                            days.Add(d);
                        }
                        pos++;
                    }
                    while ((record = file.ReadLine()) != null)
                    {
                        tokens = record.Split(',');
                        tokens = tokens.Select(t => t.Trim('"')).ToArray();
                        Student temp = new Student(tokens[0], tokens[1], tokens[2], tokens[3]);
                        for (int d = 0; d < days.Count; d++)
                        {
                            int attendValue = 0;
                            if (tokens[d] != null)
                            {
                                int.TryParse(tokens[d], out attendValue);
                            }
                            if (!temp.Swipe.ContainsKey(days[d]))
                            {
                                temp.Swipe.Add(days[d], 0);
                            }
                            temp.Swipe[days[d]] = (Student.AttendenceFlag)attendValue;
                        }
                        output.Add(temp);
                    }
                }
                file.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Can't Open the file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in *.csv e-learning format.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            studentInfo = output;
            return;
        }

        private void AcceptSwipeButton_Click(object sender, EventArgs e)
        {
            string serial = CardSerialTextBox.Text;
            if (!string.IsNullOrWhiteSpace(serial)){
                Student swiper = studentInfo.Find(s=>s.CardNumber == serial);
                if(swiper == null)
                {
                    StudentSelect ss = new StudentSelect(studentInfo);
                    ss.ShowDialog(this);
                    if(ss.SelectedStudent != null)
                    {
                        if (ss.IsNewStudent)
                        {
                            studentInfo.Add(ss.SelectedStudent);
                        }
                        swiper = studentInfo.Find(s=>s.Username == ss.SelectedStudent.Username);
                        swiper.CardNumber = serial;
                    }
                    else
                    {
                        ResultTextBox.Text = "ERROR!";
                        CardSerialTextBox.Text = null;
                        return;
                    }
                }
                DateTime current = DateTime.Now.Date;
                Student.AttendenceFlag att = Student.AttendenceFlag.ABSENT;
                if (!LateCheckBox.Checked) { att = Student.AttendenceFlag.PRESENT; }
                else { att = Student.AttendenceFlag.LATE; }
                if (!swiper.Swipe.ContainsKey(current))
                {
                    swiper.Swipe.Add(current, Student.AttendenceFlag.ABSENT);
                }
                swiper.Swipe[current] = att;
                ResultTextBox.Text = swiper.ToString() + " Accepted!";
                CardSerialTextBox.Text = null;
            }
        }

        private void CardSerialTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AcceptSwipeButton_Click((object)sender, (EventArgs)e);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ExportDialog.ShowDialog(this) == DialogResult.Cancel) return;
            string filename = ExportDialog.FileName;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
            {
                file.Write("Last Name, First Name, Username, CardSerial");
                DateTime[] days = studentInfo.SelectMany(s => s.Swipe.Keys).Distinct().OrderBy(s => s).ToArray();
                for (int i = 0; i < days.Length; i++)
                {
                    file.Write("," + days[i].ToString("MM/dd/yyyy") );
                }
                file.WriteLine();
                for (int j = 0; j < studentInfo.Count; j++)
                {
                    file.Write(studentInfo[j].LastName);
                    file.Write(","+ studentInfo[j].FirstName );
                    file.Write(","+ studentInfo[j].Username);
                    file.Write(","+ studentInfo[j].CardNumber);
                    for (int i = 0; i < days.Length; i++)
                    {
                        if (studentInfo[j].Swipe.ContainsKey(days[i]))
                        {
                            file.Write(","+ (int)studentInfo[j].Swipe[days[i]] );
                        }
                        else
                        {
                            file.Write(","+ (int)Student.AttendenceFlag.ABSENT );
                        }
                    }
                    file.WriteLine();
                }
            }
            return;
        }

        private void ExportButton_Click(object sender, EventArgs ea)
        {
            if (ExportDialog.ShowDialog(this) == DialogResult.Cancel) return;
            string filename = ExportDialog.FileName;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
            {
                file.Write("Last Name, First Name, Username, CardSerial, Present, Late, Absent");
                DateTime[] days = studentInfo.SelectMany(s => s.Swipe.Keys).Distinct().OrderBy(s => s).ToArray();
                int totalDays = days.Count();
                for (int i = 0; i < days.Length; i++)
                {
                    file.Write("," + days[i].ToString("MM/dd/yyyy") );
                }
                file.WriteLine();
                for (int j = 0; j < studentInfo.Count; j++)
                {
                    int pres = studentInfo[j].Swipe.Count(s => s.Value == Student.AttendenceFlag.PRESENT);
                    int late = studentInfo[j].Swipe.Count(s => s.Value == Student.AttendenceFlag.LATE);
                    file.Write(studentInfo[j].LastName );
                    file.Write("," + studentInfo[j].FirstName );
                    file.Write("," + studentInfo[j].Username);
                    file.Write("," + studentInfo[j].CardNumber);
                    file.Write("," + pres);
                    file.Write("," + late);
                    file.Write("," + (totalDays-pres-late));
                    file.WriteLine();
                }
            }
            return;
        }
 
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
