namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lamp = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.AmountOfSubjects = new System.Windows.Forms.TextBox();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.listViewDone = new System.Windows.Forms.ListView();
            this.listViewUndone = new System.Windows.Forms.ListView();
            this.subjects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDesignatedsubject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLamp = new System.Windows.Forms.Label();
            this.labelAllSubjects = new System.Windows.Forms.Label();
            this.labelCountedSubjects = new System.Windows.Forms.Label();
            this.textBoxDesignatedsubject = new System.Windows.Forms.Label();
            this.textBoxCurrentSubject = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIretations = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeinterval = new System.Windows.Forms.Label();
            this.textBoxtimeInterval = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.lamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxtimeInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // lamp
            // 
            this.lamp.BackColor = System.Drawing.Color.Black;
            this.lamp.Location = new System.Drawing.Point(238, 274);
            this.lamp.Name = "lamp";
            this.lamp.Size = new System.Drawing.Size(100, 50);
            this.lamp.TabIndex = 2;
            this.lamp.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(69, 92);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(108, 49);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // AmountOfSubjects
            // 
            this.AmountOfSubjects.Location = new System.Drawing.Point(97, 25);
            this.AmountOfSubjects.Name = "AmountOfSubjects";
            this.AmountOfSubjects.Size = new System.Drawing.Size(51, 20);
            this.AmountOfSubjects.TabIndex = 4;
            this.AmountOfSubjects.Text = "15";
            this.AmountOfSubjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmountOfSubjects.TextChanged += new System.EventHandler(this.AmountOfSubjects_TextChanged);
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Location = new System.Drawing.Point(76, 9);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(97, 13);
            this.LabelAmount.TabIndex = 5;
            this.LabelAmount.Text = "Amount of subjects";
            this.LabelAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(69, 63);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(108, 23);
            this.Generate.TabIndex = 6;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // listViewDone
            // 
            this.listViewDone.Location = new System.Drawing.Point(344, 176);
            this.listViewDone.Name = "listViewDone";
            this.listViewDone.Size = new System.Drawing.Size(232, 253);
            this.listViewDone.TabIndex = 7;
            this.listViewDone.UseCompatibleStateImageBehavior = false;
            this.listViewDone.View = System.Windows.Forms.View.List;
            // 
            // listViewUndone
            // 
            this.listViewUndone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.subjects});
            this.listViewUndone.Location = new System.Drawing.Point(12, 176);
            this.listViewUndone.Name = "listViewUndone";
            this.listViewUndone.Size = new System.Drawing.Size(220, 253);
            this.listViewUndone.TabIndex = 7;
            this.listViewUndone.UseCompatibleStateImageBehavior = false;
            this.listViewUndone.View = System.Windows.Forms.View.List;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(441, 35);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(65, 25);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "Count";
            this.labelCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDesignatedsubject
            // 
            this.labelDesignatedsubject.AutoSize = true;
            this.labelDesignatedsubject.Location = new System.Drawing.Point(242, 9);
            this.labelDesignatedsubject.Name = "labelDesignatedsubject";
            this.labelDesignatedsubject.Size = new System.Drawing.Size(98, 13);
            this.labelDesignatedsubject.TabIndex = 5;
            this.labelDesignatedsubject.Text = "Designated subject";
            this.labelDesignatedsubject.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current subject";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLamp
            // 
            this.labelLamp.AutoSize = true;
            this.labelLamp.Location = new System.Drawing.Point(261, 258);
            this.labelLamp.Name = "labelLamp";
            this.labelLamp.Size = new System.Drawing.Size(57, 13);
            this.labelLamp.TabIndex = 8;
            this.labelLamp.Text = "The lamp !";
            // 
            // labelAllSubjects
            // 
            this.labelAllSubjects.AutoSize = true;
            this.labelAllSubjects.Location = new System.Drawing.Point(94, 432);
            this.labelAllSubjects.Name = "labelAllSubjects";
            this.labelAllSubjects.Size = new System.Drawing.Size(60, 13);
            this.labelAllSubjects.TabIndex = 10;
            this.labelAllSubjects.Text = "All subjects";
            // 
            // labelCountedSubjects
            // 
            this.labelCountedSubjects.AutoSize = true;
            this.labelCountedSubjects.Location = new System.Drawing.Point(415, 432);
            this.labelCountedSubjects.Name = "labelCountedSubjects";
            this.labelCountedSubjects.Size = new System.Drawing.Size(91, 13);
            this.labelCountedSubjects.TabIndex = 10;
            this.labelCountedSubjects.Text = "Counted suibjects";
            // 
            // textBoxDesignatedsubject
            // 
            this.textBoxDesignatedsubject.AutoSize = true;
            this.textBoxDesignatedsubject.Location = new System.Drawing.Point(283, 28);
            this.textBoxDesignatedsubject.Name = "textBoxDesignatedsubject";
            this.textBoxDesignatedsubject.Size = new System.Drawing.Size(10, 13);
            this.textBoxDesignatedsubject.TabIndex = 11;
            this.textBoxDesignatedsubject.Text = "-";
            // 
            // textBoxCurrentSubject
            // 
            this.textBoxCurrentSubject.AutoSize = true;
            this.textBoxCurrentSubject.Location = new System.Drawing.Point(283, 95);
            this.textBoxCurrentSubject.Name = "textBoxCurrentSubject";
            this.textBoxCurrentSubject.Size = new System.Drawing.Size(10, 13);
            this.textBoxCurrentSubject.TabIndex = 11;
            this.textBoxCurrentSubject.Text = "-";
            // 
            // textBoxCount
            // 
            this.textBoxCount.AutoSize = true;
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCount.Location = new System.Drawing.Point(460, 63);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(23, 31);
            this.textBoxCount.TabIndex = 12;
            this.textBoxCount.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Iterations";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelIretations
            // 
            this.labelIretations.AutoSize = true;
            this.labelIretations.Location = new System.Drawing.Point(283, 138);
            this.labelIretations.Name = "labelIretations";
            this.labelIretations.Size = new System.Drawing.Size(10, 13);
            this.labelIretations.TabIndex = 11;
            this.labelIretations.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(234, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Made by Arno";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeinterval
            // 
            this.timeinterval.AutoSize = true;
            this.timeinterval.Location = new System.Drawing.Point(9, 468);
            this.timeinterval.Name = "timeinterval";
            this.timeinterval.Size = new System.Drawing.Size(95, 13);
            this.timeinterval.TabIndex = 10;
            this.timeinterval.Text = "Time interval (ms) :";
            // 
            // textBoxtimeInterval
            // 
            this.textBoxtimeInterval.Location = new System.Drawing.Point(108, 466);
            this.textBoxtimeInterval.Name = "textBoxtimeInterval";
            this.textBoxtimeInterval.Size = new System.Drawing.Size(54, 20);
            this.textBoxtimeInterval.TabIndex = 14;
            this.textBoxtimeInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxtimeInterval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 490);
            this.Controls.Add(this.textBoxtimeInterval);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelIretations);
            this.Controls.Add(this.textBoxCurrentSubject);
            this.Controls.Add(this.textBoxDesignatedsubject);
            this.Controls.Add(this.labelCountedSubjects);
            this.Controls.Add(this.timeinterval);
            this.Controls.Add(this.labelAllSubjects);
            this.Controls.Add(this.labelLamp);
            this.Controls.Add(this.listViewUndone);
            this.Controls.Add(this.listViewDone);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDesignatedsubject);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.AmountOfSubjects);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.lamp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxtimeInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox lamp;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox AmountOfSubjects;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ListView listViewDone;
        private System.Windows.Forms.ListView listViewUndone;
        private System.Windows.Forms.ColumnHeader subjects;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDesignatedsubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLamp;
        private System.Windows.Forms.Label labelAllSubjects;
        private System.Windows.Forms.Label labelCountedSubjects;
        private System.Windows.Forms.Label textBoxDesignatedsubject;
        private System.Windows.Forms.Label textBoxCurrentSubject;
        private System.Windows.Forms.Label textBoxCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIretations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeinterval;
        private System.Windows.Forms.NumericUpDown textBoxtimeInterval;
    }
}

