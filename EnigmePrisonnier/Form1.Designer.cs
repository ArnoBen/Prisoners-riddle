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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.AmountOfSubjects = new System.Windows.Forms.TextBox();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.listViewDone = new System.Windows.Forms.ListView();
            this.listViewUndone = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(145, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(145, 79);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(108, 49);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // AmountOfSubjects
            // 
            this.AmountOfSubjects.Location = new System.Drawing.Point(172, 23);
            this.AmountOfSubjects.Name = "AmountOfSubjects";
            this.AmountOfSubjects.Size = new System.Drawing.Size(51, 20);
            this.AmountOfSubjects.TabIndex = 4;
            this.AmountOfSubjects.Text = "50";
            this.AmountOfSubjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmountOfSubjects.TextChanged += new System.EventHandler(this.AmountOfSubjects_TextChanged);
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Location = new System.Drawing.Point(148, 7);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(97, 13);
            this.LabelAmount.TabIndex = 5;
            this.LabelAmount.Text = "Amount of subjects";
            this.LabelAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(161, 50);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 6;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // listViewDone
            // 
            this.listViewDone.Location = new System.Drawing.Point(251, 149);
            this.listViewDone.Name = "listViewDone";
            this.listViewDone.Size = new System.Drawing.Size(121, 97);
            this.listViewDone.TabIndex = 7;
            this.listViewDone.UseCompatibleStateImageBehavior = false;
            // 
            // listViewUndone
            // 
            this.listViewUndone.Location = new System.Drawing.Point(18, 149);
            this.listViewUndone.Name = "listViewUndone";
            this.listViewUndone.Size = new System.Drawing.Size(121, 97);
            this.listViewUndone.TabIndex = 7;
            this.listViewUndone.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 490);
            this.Controls.Add(this.listViewUndone);
            this.Controls.Add(this.listViewDone);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.AmountOfSubjects);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox AmountOfSubjects;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ListView listViewDone;
        private System.Windows.Forms.ListView listViewUndone;
    }
}

