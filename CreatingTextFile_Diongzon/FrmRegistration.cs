using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile_Diongzon
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technolgy",
                "BS Computer Science",
                "BS Information System",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management",
            };
            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i]);
            }
            string[] ListOfGender = new string[]
            {
                "Male",
                "Female"
            };
            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGender[i]);
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string StudentNo = txtStudentNo.Text;
            string LastName = txtLastName.Text;
            string Age = txtAge.Text;
            string Birthday = dateTimePicker1.Text;
            string Program = cbProgram.Text;
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string Gender = cbGender.Text;
            string contactNo = txtContactNo.Text;

            string DocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string[] input =
            {
                "StudentNo: " + StudentNo,
                "Full Name: " + LastName + ", " + firstName + ", " + middleName,
                "Program: " + Program,
                "Gender: " + Gender,
                "Birthday: " + Birthday,
                "Age: " + Age,
                "Contanct No. " + contactNo
            };

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(DocPath, StudentNo + ".txt")))
            {
                foreach (string i in input)
                {
                    outputFile.WriteLine(i);
                }
            }
            MessageBox.Show("Successful!");

        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.Show();
            this.Hide();
        }
    }
}
