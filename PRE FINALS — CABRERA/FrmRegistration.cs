using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRE_FINALS___CABRERA
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] displayInfo = new string[]

            {

                "Student No.: " + textBox1.Text,
                "Full Name: " + textBox2.Text + "," + textBox4.Text + "," + textBox6.Text,
                "Program: " + comboBox1,
                "Gender: " + comboBox2,
                "Age: " + textBox3.Text,
                "Birthday: " + dateTimePicker1.Text,
                "Contact No: " + textBox5.Text

            };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FrmFileName fileName = new FrmFileName();
            fileName.ShowDialog();

                using(StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
                {

                    outputFile.WriteLine("Student No.: " + textBox1.Text);
                    outputFile.WriteLine("Full Name: " + textBox2.Text + "," + textBox4.Text + "," + textBox6.Text);
                    outputFile.WriteLine("Program: " + comboBox1.Text);
                    outputFile.WriteLine("Gender: " + comboBox2.Text);
                    outputFile.WriteLine("Age: " + textBox3.Text);
                    outputFile.WriteLine("Birthday: " + dateTimePicker1.Text);
                    outputFile.WriteLine("Contact No: " + textBox5.Text);

                }

            }

        }

    }
