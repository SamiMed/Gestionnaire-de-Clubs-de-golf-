
namespace ProjetGestionClubGolf
{
    partial class ChoixTypeAjoutAbonnement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPersonneSeul = new System.Windows.Forms.Button();
            this.btnPersonneAge = new System.Windows.Forms.Button();
            this.btnCouple = new System.Windows.Forms.Button();
            this.btnFamille1enfant = new System.Windows.Forms.Button();
            this.btnFamille2enfant = new System.Windows.Forms.Button();
            this.btnFamille3enfant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersonneSeul
            // 
            this.btnPersonneSeul.Location = new System.Drawing.Point(69, 121);
            this.btnPersonneSeul.Name = "btnPersonneSeul";
            this.btnPersonneSeul.Size = new System.Drawing.Size(192, 32);
            this.btnPersonneSeul.TabIndex = 0;
            this.btnPersonneSeul.Text = "Personne seul";
            this.btnPersonneSeul.UseVisualStyleBackColor = true;
            this.btnPersonneSeul.Click += new System.EventHandler(this.btnPersonneSeul_Click);
            // 
            // btnPersonneAge
            // 
            this.btnPersonneAge.Location = new System.Drawing.Point(69, 196);
            this.btnPersonneAge.Name = "btnPersonneAge";
            this.btnPersonneAge.Size = new System.Drawing.Size(192, 32);
            this.btnPersonneAge.TabIndex = 1;
            this.btnPersonneAge.Text = "Age d\'or";
            this.btnPersonneAge.UseVisualStyleBackColor = true;
            this.btnPersonneAge.Click += new System.EventHandler(this.btnPersonneAge_Click);
            // 
            // btnCouple
            // 
            this.btnCouple.Location = new System.Drawing.Point(69, 265);
            this.btnCouple.Name = "btnCouple";
            this.btnCouple.Size = new System.Drawing.Size(192, 32);
            this.btnCouple.TabIndex = 2;
            this.btnCouple.Text = "Couple";
            this.btnCouple.UseVisualStyleBackColor = true;
            this.btnCouple.Click += new System.EventHandler(this.btnCouple_Click);
            // 
            // btnFamille1enfant
            // 
            this.btnFamille1enfant.Location = new System.Drawing.Point(69, 338);
            this.btnFamille1enfant.Name = "btnFamille1enfant";
            this.btnFamille1enfant.Size = new System.Drawing.Size(192, 32);
            this.btnFamille1enfant.TabIndex = 3;
            this.btnFamille1enfant.Text = "Famille avec 1 enfant";
            this.btnFamille1enfant.UseVisualStyleBackColor = true;
            this.btnFamille1enfant.Click += new System.EventHandler(this.btnFamille1enfant_Click);
            // 
            // btnFamille2enfant
            // 
            this.btnFamille2enfant.Location = new System.Drawing.Point(69, 414);
            this.btnFamille2enfant.Name = "btnFamille2enfant";
            this.btnFamille2enfant.Size = new System.Drawing.Size(192, 32);
            this.btnFamille2enfant.TabIndex = 4;
            this.btnFamille2enfant.Text = "Famille avec 2 enfants";
            this.btnFamille2enfant.UseVisualStyleBackColor = true;
            this.btnFamille2enfant.Click += new System.EventHandler(this.btnFamille2enfant_Click);
            // 
            // btnFamille3enfant
            // 
            this.btnFamille3enfant.Location = new System.Drawing.Point(69, 483);
            this.btnFamille3enfant.Name = "btnFamille3enfant";
            this.btnFamille3enfant.Size = new System.Drawing.Size(192, 32);
            this.btnFamille3enfant.TabIndex = 5;
            this.btnFamille3enfant.Text = "Famille avec 3 enfants";
            this.btnFamille3enfant.UseVisualStyleBackColor = true;
            this.btnFamille3enfant.Click += new System.EventHandler(this.btnFamille3enfant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Veuillez spécifier le type \r\nd\'ajout vous voullez faire";
            // 
            // ChoixTypeAjoutAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFamille3enfant);
            this.Controls.Add(this.btnFamille2enfant);
            this.Controls.Add(this.btnFamille1enfant);
            this.Controls.Add(this.btnCouple);
            this.Controls.Add(this.btnPersonneAge);
            this.Controls.Add(this.btnPersonneSeul);
            this.Name = "ChoixTypeAjoutAbonnement";
            this.Text = "ChoixTypeAjoutAbonnement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonneSeul;
        private System.Windows.Forms.Button btnPersonneAge;
        private System.Windows.Forms.Button btnCouple;
        private System.Windows.Forms.Button btnFamille1enfant;
        private System.Windows.Forms.Button btnFamille2enfant;
        private System.Windows.Forms.Button btnFamille3enfant;
        private System.Windows.Forms.Label label1;
    }
}