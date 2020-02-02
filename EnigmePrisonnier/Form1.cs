using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            GenerateSubjects(int.Parse(AmountOfSubjects.Text));
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        static Random rnd = new Random();
        private void GenerateSubjects(int numberOfSubjects = 50)
        {
            List<int> SubjectList = new List<int>();

            for (int i = 1; i <= numberOfSubjects; i++)
            {
                SubjectList.Add(i);
            }
            int designated = rnd.Next(SubjectList.Count);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AmountOfSubjects_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
