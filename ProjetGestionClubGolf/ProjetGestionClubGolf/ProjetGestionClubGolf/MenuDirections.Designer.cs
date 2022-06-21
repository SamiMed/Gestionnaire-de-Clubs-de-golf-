
namespace ProjetGestionClubGolf
{
    partial class MenuDirections
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
            this.btnGestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestionPrixDepenses1 = new System.Windows.Forms.Button();
            this.btnAjoutDepense = new System.Windows.Forms.Button();
            this.btnRapport = new System.Windows.Forms.Button();
            this.btnStatistique = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestion
            // 
            this.btnGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.Location = new System.Drawing.Point(46, 133);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(392, 30);
            this.btnGestion.TabIndex = 0;
            this.btnGestion.Text = "Gestion des employés";
            this.btnGestion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu direction";
            // 
            // btnGestionPrixDepenses1
            // 
            this.btnGestionPrixDepenses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPrixDepenses1.Location = new System.Drawing.Point(46, 216);
            this.btnGestionPrixDepenses1.Name = "btnGestionPrixDepenses1";
            this.btnGestionPrixDepenses1.Size = new System.Drawing.Size(392, 29);
            this.btnGestionPrixDepenses1.TabIndex = 9;
            this.btnGestionPrixDepenses1.Text = "Modification d’un prix et des dépenses obligatoires";
            this.btnGestionPrixDepenses1.UseVisualStyleBackColor = true;
            this.btnGestionPrixDepenses1.Click += new System.EventHandler(this.btnGestionPrixDepenses1_Click);
            // 
            // btnAjoutDepense
            // 
            this.btnAjoutDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutDepense.Location = new System.Drawing.Point(46, 298);
            this.btnAjoutDepense.Name = "btnAjoutDepense";
            this.btnAjoutDepense.Size = new System.Drawing.Size(392, 29);
            this.btnAjoutDepense.TabIndex = 15;
            this.btnAjoutDepense.Text = "Ajouter une dépense";
            this.btnAjoutDepense.UseVisualStyleBackColor = true;
            this.btnAjoutDepense.Click += new System.EventHandler(this.btnAjoutDepense_Click);
            // 
            // btnRapport
            // 
            this.btnRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapport.Location = new System.Drawing.Point(499, 133);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(392, 30);
            this.btnRapport.TabIndex = 16;
            this.btnRapport.Text = "Rapports";
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(559, 27);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(280, 29);
            this.btnDeconnexion.TabIndex = 18;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // MenuDirections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 393);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnStatistique);
            this.Controls.Add(this.btnRapport);
            this.Controls.Add(this.btnAjoutDepense);
            this.Controls.Add(this.btnGestionPrixDepenses1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGestion);
            this.Name = "MenuDirections";
            this.Text = "Menu direction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestionPrixDepenses1;
        private System.Windows.Forms.Button btnAjoutDepense;
        private System.Windows.Forms.Button btnRapport;
        private System.Windows.Forms.Button btnStatistique;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}