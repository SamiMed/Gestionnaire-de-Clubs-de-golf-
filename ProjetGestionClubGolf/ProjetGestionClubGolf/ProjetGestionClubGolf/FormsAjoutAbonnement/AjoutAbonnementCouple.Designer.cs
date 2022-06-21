
namespace ProjetGestionClubGolf.FormsAjoutAbonnement
{
    partial class AjoutAbonnementCouple
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
            this.components = new System.ComponentModel.Container();
            this.lblAjoutAbonnnement = new System.Windows.Forms.Label();
            this.txtCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRemarque = new System.Windows.Forms.TextBox();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.cboSexe = new System.Windows.Forms.ComboBox();
            this.txtNoCivique = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conjoint = new System.Windows.Forms.GroupBox();
            this.txtRemarqueConjoint = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpDateNaissanceConjoint = new System.Windows.Forms.DateTimePicker();
            this.txtNomConjoint = new System.Windows.Forms.TextBox();
            this.txtPrenomConjoint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboSexeConjoint = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAnnuller = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            this.conjoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAjoutAbonnnement
            // 
            this.lblAjoutAbonnnement.AutoSize = true;
            this.lblAjoutAbonnnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutAbonnnement.Location = new System.Drawing.Point(264, 9);
            this.lblAjoutAbonnnement.Name = "lblAjoutAbonnnement";
            this.lblAjoutAbonnnement.Size = new System.Drawing.Size(300, 24);
            this.lblAjoutAbonnnement.TabIndex = 58;
            this.lblAjoutAbonnnement.Text = "Ajouter un abonnement couple";
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(143, 429);
            this.txtCodePostal.Mask = "L9L 9L9";
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodePostal.TabIndex = 57;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(338, 413);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(205, 88);
            this.btnEnregistrer.TabIndex = 56;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // cboProvince
            // 
            this.cboProvince.DataSource = this.provinceBindingSource;
            this.cboProvince.DisplayMember = "Id";
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Location = new System.Drawing.Point(408, 59);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(121, 21);
            this.cboProvince.TabIndex = 55;
            this.cboProvince.ValueMember = "Abonnements";
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataSource = typeof(ProjetGestionClubGolf.Province);
            // 
            // txtRemarque
            // 
            this.txtRemarque.Location = new System.Drawing.Point(394, 320);
            this.txtRemarque.Name = "txtRemarque";
            this.txtRemarque.Size = new System.Drawing.Size(100, 20);
            this.txtRemarque.TabIndex = 54;
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(408, 222);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(100, 20);
            this.txtCourriel.TabIndex = 53;
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(408, 161);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(100, 20);
            this.txtCell.TabIndex = 52;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(408, 105);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtTelephone.TabIndex = 51;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(143, 372);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 50;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(143, 64);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 20);
            this.txtNom.TabIndex = 49;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(143, 319);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(100, 20);
            this.txtRue.TabIndex = 48;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(143, 114);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(121, 20);
            this.txtPrenom.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(335, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "couriel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(335, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "cell";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(335, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "tel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Ville";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "rue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "remarque";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "province";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "NoCivique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "codepostal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Date de naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "sexe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "prenom";
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(143, 221);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(164, 20);
            this.dtpDateNaissance.TabIndex = 34;
            // 
            // cboSexe
            // 
            this.cboSexe.FormattingEnabled = true;
            this.cboSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cboSexe.Location = new System.Drawing.Point(143, 170);
            this.cboSexe.Name = "cboSexe";
            this.cboSexe.Size = new System.Drawing.Size(121, 21);
            this.cboSexe.TabIndex = 33;
            // 
            // txtNoCivique
            // 
            this.txtNoCivique.Location = new System.Drawing.Point(143, 267);
            this.txtNoCivique.Name = "txtNoCivique";
            this.txtNoCivique.Size = new System.Drawing.Size(100, 20);
            this.txtNoCivique.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "nom";
            // 
            // conjoint
            // 
            this.conjoint.BackColor = System.Drawing.Color.OldLace;
            this.conjoint.Controls.Add(this.txtRemarqueConjoint);
            this.conjoint.Controls.Add(this.label18);
            this.conjoint.Controls.Add(this.label17);
            this.conjoint.Controls.Add(this.dtpDateNaissanceConjoint);
            this.conjoint.Controls.Add(this.txtNomConjoint);
            this.conjoint.Controls.Add(this.txtPrenomConjoint);
            this.conjoint.Controls.Add(this.label8);
            this.conjoint.Controls.Add(this.label15);
            this.conjoint.Controls.Add(this.cboSexeConjoint);
            this.conjoint.Controls.Add(this.label16);
            this.conjoint.Location = new System.Drawing.Point(562, 47);
            this.conjoint.Name = "conjoint";
            this.conjoint.Size = new System.Drawing.Size(262, 324);
            this.conjoint.TabIndex = 59;
            this.conjoint.TabStop = false;
            this.conjoint.Text = "Infos conjoint(e)";
            // 
            // txtRemarqueConjoint
            // 
            this.txtRemarqueConjoint.Location = new System.Drawing.Point(139, 247);
            this.txtRemarqueConjoint.Name = "txtRemarqueConjoint";
            this.txtRemarqueConjoint.Size = new System.Drawing.Size(100, 20);
            this.txtRemarqueConjoint.TabIndex = 61;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 60;
            this.label18.Text = "remarque";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-3, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 61;
            this.label17.Text = "Date de naissance";
            // 
            // dtpDateNaissanceConjoint
            // 
            this.dtpDateNaissanceConjoint.Location = new System.Drawing.Point(113, 185);
            this.dtpDateNaissanceConjoint.Name = "dtpDateNaissanceConjoint";
            this.dtpDateNaissanceConjoint.Size = new System.Drawing.Size(143, 20);
            this.dtpDateNaissanceConjoint.TabIndex = 60;
            // 
            // txtNomConjoint
            // 
            this.txtNomConjoint.Location = new System.Drawing.Point(118, 20);
            this.txtNomConjoint.Name = "txtNomConjoint";
            this.txtNomConjoint.Size = new System.Drawing.Size(121, 20);
            this.txtNomConjoint.TabIndex = 55;
            // 
            // txtPrenomConjoint
            // 
            this.txtPrenomConjoint.Location = new System.Drawing.Point(118, 70);
            this.txtPrenomConjoint.Name = "txtPrenomConjoint";
            this.txtPrenomConjoint.Size = new System.Drawing.Size(121, 20);
            this.txtPrenomConjoint.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "sexe";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "prenom";
            // 
            // cboSexeConjoint
            // 
            this.cboSexeConjoint.FormattingEnabled = true;
            this.cboSexeConjoint.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cboSexeConjoint.Location = new System.Drawing.Point(118, 126);
            this.cboSexeConjoint.Name = "cboSexeConjoint";
            this.cboSexeConjoint.Size = new System.Drawing.Size(121, 21);
            this.cboSexeConjoint.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "nom";
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // btnAnnuller
            // 
            this.btnAnnuller.Location = new System.Drawing.Point(571, 429);
            this.btnAnnuller.Name = "btnAnnuller";
            this.btnAnnuller.Size = new System.Drawing.Size(145, 61);
            this.btnAnnuller.TabIndex = 60;
            this.btnAnnuller.Text = "annuller";
            this.btnAnnuller.UseVisualStyleBackColor = true;
            this.btnAnnuller.Click += new System.EventHandler(this.btnAnnuller_Click);
            // 
            // AjoutAbonnementCouple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 552);
            this.Controls.Add(this.btnAnnuller);
            this.Controls.Add(this.conjoint);
            this.Controls.Add(this.lblAjoutAbonnnement);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.cboProvince);
            this.Controls.Add(this.txtRemarque);
            this.Controls.Add(this.txtCourriel);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(this.cboSexe);
            this.Controls.Add(this.txtNoCivique);
            this.Controls.Add(this.label1);
            this.Name = "AjoutAbonnementCouple";
            this.Text = "AjoutAbonnementCouple";
            this.Load += new System.EventHandler(this.AjoutAbonnementCouple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            this.conjoint.ResumeLayout(false);
            this.conjoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAjoutAbonnnement;
        private System.Windows.Forms.MaskedTextBox txtCodePostal;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.TextBox txtRemarque;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.ComboBox cboSexe;
        private System.Windows.Forms.TextBox txtNoCivique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox conjoint;
        private System.Windows.Forms.TextBox txtRemarqueConjoint;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpDateNaissanceConjoint;
        private System.Windows.Forms.TextBox txtNomConjoint;
        private System.Windows.Forms.TextBox txtPrenomConjoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboSexeConjoint;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private System.Windows.Forms.Button btnAnnuller;
    }
}