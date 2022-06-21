
namespace ProjetGestionClubGolf
{
    partial class MenuEmployerProShop
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
            this.btnAjouterPartieGolfJouer = new System.Windows.Forms.Button();
            this.btnAjoutDepense = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu Employer pro shop";
            // 
            // btnAjouterPartieGolfJouer
            // 
            this.btnAjouterPartieGolfJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPartieGolfJouer.Location = new System.Drawing.Point(49, 138);
            this.btnAjouterPartieGolfJouer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterPartieGolfJouer.Name = "btnAjouterPartieGolfJouer";
            this.btnAjouterPartieGolfJouer.Size = new System.Drawing.Size(401, 28);
            this.btnAjouterPartieGolfJouer.TabIndex = 12;
            this.btnAjouterPartieGolfJouer.Text = "Inscription d’une partie de golf jouée";
            this.btnAjouterPartieGolfJouer.UseVisualStyleBackColor = true;
            this.btnAjouterPartieGolfJouer.Click += new System.EventHandler(this.btnAjouterPartieGolfJouer_Click);
            // 
            // btnAjoutDepense
            // 
            this.btnAjoutDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutDepense.Location = new System.Drawing.Point(49, 212);
            this.btnAjoutDepense.Name = "btnAjoutDepense";
            this.btnAjoutDepense.Size = new System.Drawing.Size(401, 29);
            this.btnAjoutDepense.TabIndex = 13;
            this.btnAjoutDepense.Text = "Ajouter une dépense";
            this.btnAjoutDepense.UseVisualStyleBackColor = true;
            this.btnAjoutDepense.Click += new System.EventHandler(this.btnAjoutDepense_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(106, 332);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(280, 29);
            this.btnDeconnexion.TabIndex = 14;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // MenuEmployerProShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 427);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnAjoutDepense);
            this.Controls.Add(this.btnAjouterPartieGolfJouer);
            this.Controls.Add(this.label1);
            this.Name = "MenuEmployerProShop";
            this.Text = "Employer pro shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouterPartieGolfJouer;
        private System.Windows.Forms.Button btnAjoutDepense;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}