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
        public List<int> SubjectList = new List<int>();
        public List<int> FinishedSubjectList = new List<int>();
        int totalSubjectsCount = 0;
        int designated = 0; /* Le sujet désigner pour compter */
        bool activateAlgorithm = false;

        bool switchState = false;
        int currentSubject = 0;
        int SubjectCount = 0; //La variable la plus importante ! Compter les sujets !
        int iterations = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (AmountOfSubjects.Text != "")
            {
                totalSubjectsCount = int.Parse(AmountOfSubjects.Text);
                GenerateSubjects(totalSubjectsCount);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (SubjectList.Count != 0)
            {
                activateAlgorithm = true;
            }
        }

        static Random rnd = new Random();
        private void GenerateSubjects(int numberOfSubjects = 15)
        {
            ClearEverything();

            for (int i = 0; i < numberOfSubjects; i++)
            {
                SubjectList.Add(i);    
            }
            designated = rnd.Next(SubjectList.Count);
            textBoxDesignatedsubject.Text = designated.ToString();
            listViewUndone.Items.AddRange(SubjectList.Select(t => new ListViewItem(t.ToString())).ToArray());
            listViewUndone.Items[designated].BackColor = Color.Green;
        }

        private void ClearEverything()
        {
            SubjectList.Clear();
            FinishedSubjectList.Clear();
            listViewUndone.Clear();
            listViewDone.Clear();
            SubjectCount = 0;
            iterations = 0;
        }

        private void MainAlgorithm()
        {
            if (SubjectCount != totalSubjectsCount - 1) /* Oui, -1 car le sujet désigné ne va pas se compter lui-même*/
            {
                if (currentSubject != designated) listViewUndone.Items[currentSubject].BackColor = listViewUndone.BackColor;
                currentSubject = rnd.Next(SubjectList.Count);
                if(currentSubject!=designated) listViewUndone.Items[currentSubject].BackColor = Color.Red;
                textBoxCurrentSubject.Text = currentSubject.ToString();
                //Etant donné que je donne la valeur 0 aux sujets traités, je vérifie qu'on tombe pas sur un sujet traité pour la prochaine boucle
                // Si c'est éteint ET que ce n'est pas le sujet désigné, on allume et on rajoute le sujet à la liste des sujets terminés
                if (SubjectList[currentSubject] != -1 && !switchState && SubjectList[currentSubject] != designated)
                {
                    switchState = true; lamp.BackColor = Color.Yellow;
                    FinishedSubjectList.Add(currentSubject);
                    listViewDone.Items.Add(currentSubject.ToString());
                    
                    SubjectList[currentSubject] = -1; /* je donne la valeur -1 au lieu de l'enlever de la liste, c'est plus simple et opti pour toujours avoir la valeur du sujet = son index (sauf sujets traités)*/
                }

                // Si c'est allumé ET que c'est le sujet désigné, on éteint et on incrémente le compteur.
                if (SubjectList[currentSubject] == designated && switchState)
                {
                    switchState = false; lamp.BackColor = Color.Black;
                    SubjectCount++;
                    textBoxCount.Text = (SubjectCount + 1).ToString();
                }
                iterations++;
                labelIretations.Text = iterations.ToString();
            }
            else
                activateAlgorithm = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AmountOfSubjects_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lamp.BackColor = Color.Yellow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (textBoxtimeInterval.Value != 0 && textBoxtimeInterval.Value <= 2000 && textBoxtimeInterval.Value != null)
                timer1.Interval = Convert.ToInt16(textBoxtimeInterval.Value);
            if (activateAlgorithm)
                MainAlgorithm();
        }
    }
}
