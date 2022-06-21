
namespace ProjetGestionClubGolf
{
    partial class MenuEmployerClub
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestionAbonnement = new System.Windows.Forms.Button();
            this.btnReabonnement = new System.Windows.Forms.Button();
            this.btnMiseAjourAbonnees = new System.Windows.Forms.Button();
            this.btnAjouterPartieGolfJouer = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu employer club";
            // 
            // btnGestionAbonnement
            // 
            this.btnGestionAbonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAbonnement.Location = new System.Drawing.Point(18, 117);
            this.btnGestionAbonnement.Name = "btnGestionAbonnement";
            this.btnGestionAbonnement.Size = new System.Drawing.Size(260, 29);
            this.btnGestionAbonnement.TabIndex = 6;
            this.btnGestionAbonnement.Text = "Gestion des abonnements";
            this.btnGestionAbonnement.UseVisualStyleBackColor = true;
            // 
            // btnReabonnement
            // 
            this.btnReabonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReabonnement.Location = new System.Drawing.Point(18, 197);
            this.btnReabonnement.Name = "btnReabonnement";
            this.btnReabonnement.Size = new System.Drawing.Size(260, 29);
            this.btnReabonnement.TabIndex = 9;
            this.btnReabonnement.Text = "Réabonnement";
            this.btnReabonnement.UseVisualStyleBackColor = true;
            this.btnReabonnement.Click += new System.EventHandler(this.btnReabonnement_Click);
            // 
            // btnMiseAjourAbonnees
            // 
            this.btnMiseAjourAbonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiseAjourAbonnees.Location = new System.Drawing.Point(386, 117);
            this.btnMiseAjourAbonnees.Margin = new System.Windows.Forms.Padding(2);
            this.btnMiseAjourAbonnees.Name = "btnMiseAjourAbonnees";
            this.btnMiseAjourAbonnees.Size = new System.Drawing.Size(401, 30);
            this.btnMiseAjourAbonnees.TabIndex = 10;
            this.btnMiseAjourAbonnees.Text = "Mise à jour des abonnés";
            this.btnMiseAjourAbonnees.UseVisualStyleBackColor = true;
            this.btnMiseAjourAbonnees.Click += new System.EventHandler(this.btnMiseAjourAbonnees_Click);
            // 
            // btnAjouterPartieGolfJouer
            // 
            this.btnAjouterPartieGolfJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPartieGolfJouer.Location = new System.Drawing.Point(386, 197);
            this.btnAjouterPartieGolfJouer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterPartieGolfJouer.Name = "btnAjouterPartieGolfJouer";
            this.btnAjouterPartieGolfJouer.Size = new System.Drawing.Size(401, 28);
            this.btnAjouterPartieGolfJouer.TabIndex = 11;
            this.btnAjouterPartieGolfJouer.Text = "Inscription d’une partie de golf jouée";
            this.btnAjouterPartieGolfJouer.UseVisualStyleBackColor = true;
            this.btnAjouterPartieGolfJouer.Click += new System.EventHandler(this.btnAjouterPartieGolfJouer_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(449, 30);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(280, 29);
            this.btnDeconnexion.TabIndex = 12;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // MenuEmployerClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 297);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnAjouterPartieGolfJouer);
            this.Controls.Add(this.btnMiseAjourAbonnees);
            this.Controls.Add(this.btnReabonnement);
            this.Controls.Add(this.btnGestionAbonnement);
            this.Controls.Add(this.label1);
            this.Name = "MenuEmployerClub";
            this.Text = "Menu employer club";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestionAbonnement;
        private System.Windows.Forms.Button btnReabonnement;
        private System.Windows.Forms.Button btnMiseAjourAbonnees;
        private System.Windows.Forms.Button btnAjouterPartieGolfJouer;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}