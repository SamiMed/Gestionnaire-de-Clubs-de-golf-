namespace ProjetGestionClubGolf
{
    partial class AjoutEmp
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tbMotDePasse = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.ddlSexe = new System.Windows.Forms.ComboBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCellulaire = new System.Windows.Forms.MaskedTextBox();
            this.tbNoCivique = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.cboIdProvince = new System.Windows.Forms.ComboBox();
            this.bDB56Projet22DataSet = new ProjetGestionClubGolf.BDB56Projet22DataSet();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provincesTableAdapter = new ProjetGestionClubGolf.BDB56Projet22DataSetTableAdapters.ProvincesTableAdapter();
            this.tableAdapterManager = new ProjetGestionClubGolf.BDB56Projet22DataSetTableAdapters.TableAdapterManager();
            this.mtbCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.tbCouriel = new System.Windows.Forms.TextBox();
            this.numSalaire = new System.Windows.Forms.NumericUpDown();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.msgErreur = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.typesEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesEmployeTableAdapter = new ProjetGestionClubGolf.BDB56Projet22DataSetTableAdapters.TypesEmployeTableAdapter();
            this.cboTypeEmp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet22DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(487, 278);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(137, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(32, 278);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(137, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(132, 37);
            this.tbMotDePasse.MaxLength = 50;
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.PasswordChar = '*';
            this.tbMotDePasse.Size = new System.Drawing.Size(137, 20);
            this.tbMotDePasse.TabIndex = 2;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(132, 63);
            this.tbNom.MaxLength = 30;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(137, 20);
            this.tbNom.TabIndex = 3;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(132, 89);
            this.tbPrenom.MaxLength = 30;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(137, 20);
            this.tbPrenom.TabIndex = 4;
            // 
            // ddlSexe
            // 
            this.ddlSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSexe.FormattingEnabled = true;
            this.ddlSexe.Location = new System.Drawing.Point(132, 115);
            this.ddlSexe.Name = "ddlSexe";
            this.ddlSexe.Size = new System.Drawing.Size(137, 21);
            this.ddlSexe.TabIndex = 5;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(132, 143);
            this.numAge.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(137, 20);
            this.numAge.TabIndex = 6;
            this.numAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(487, 89);
            this.mtbTelephone.Mask = "(999) 999-9999";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(137, 20);
            this.mtbTelephone.TabIndex = 8;
            // 
            // mtbCellulaire
            // 
            this.mtbCellulaire.Location = new System.Drawing.Point(487, 115);
            this.mtbCellulaire.Mask = "(999) 999-9999";
            this.mtbCellulaire.Name = "mtbCellulaire";
            this.mtbCellulaire.Size = new System.Drawing.Size(137, 20);
            this.mtbCellulaire.TabIndex = 9;
            // 
            // tbNoCivique
            // 
            this.tbNoCivique.Location = new System.Drawing.Point(132, 170);
            this.tbNoCivique.Name = "tbNoCivique";
            this.tbNoCivique.Size = new System.Drawing.Size(137, 20);
            this.tbNoCivique.TabIndex = 10;
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(132, 197);
            this.tbRue.MaxLength = 50;
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(137, 20);
            this.tbRue.TabIndex = 11;
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(132, 224);
            this.tbVille.MaxLength = 50;
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(137, 20);
            this.tbVille.TabIndex = 12;
            // 
            // cboIdProvince
            // 
            this.cboIdProvince.DataSource = this.provincesBindingSource;
            this.cboIdProvince.DisplayMember = "Nom";
            this.cboIdProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdProvince.FormattingEnabled = true;
            this.cboIdProvince.Location = new System.Drawing.Point(487, 36);
            this.cboIdProvince.Name = "cboIdProvince";
            this.cboIdProvince.Size = new System.Drawing.Size(137, 21);
            this.cboIdProvince.TabIndex = 13;
            this.cboIdProvince.ValueMember = "Id";
            // 
            // bDB56Projet22DataSet
            // 
            this.bDB56Projet22DataSet.DataSetName = "BDB56Projet22DataSet";
            this.bDB56Projet22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataMember = "Provinces";
            this.provincesBindingSource.DataSource = this.bDB56Projet22DataSet;
            // 
            // provincesTableAdapter
            // 
            this.provincesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependantsTableAdapter = null;
            this.tableAdapterManager.DepensesTableAdapter = null;
            this.tableAdapterManager.EmployesTableAdapter = null;
            this.tableAdapterManager.PartiesJoueesTableAdapter = null;
            this.tableAdapterManager.PrixDepensesAbonnementsTableAdapter = null;
            this.tableAdapterManager.ProvincesTableAdapter = this.provincesTableAdapter;
            this.tableAdapterManager.ReabonnementsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TerrainsTableAdapter = null;
            this.tableAdapterManager.TypesAbonnementTableAdapter = null;
            this.tableAdapterManager.TypesEmployeTableAdapter = this.typesEmployeTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetGestionClubGolf.BDB56Projet22DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mtbCodePostal
            // 
            this.mtbCodePostal.Location = new System.Drawing.Point(487, 64);
            this.mtbCodePostal.Mask = "A9A 9A9";
            this.mtbCodePostal.Name = "mtbCodePostal";
            this.mtbCodePostal.Size = new System.Drawing.Size(137, 20);
            this.mtbCodePostal.TabIndex = 14;
            // 
            // tbCouriel
            // 
            this.tbCouriel.Location = new System.Drawing.Point(487, 140);
            this.tbCouriel.MaxLength = 50;
            this.tbCouriel.Name = "tbCouriel";
            this.tbCouriel.Size = new System.Drawing.Size(137, 20);
            this.tbCouriel.TabIndex = 15;
            // 
            // numSalaire
            // 
            this.numSalaire.DecimalPlaces = 2;
            this.numSalaire.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSalaire.Location = new System.Drawing.Point(487, 167);
            this.numSalaire.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSalaire.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSalaire.Name = "numSalaire";
            this.numSalaire.Size = new System.Drawing.Size(137, 20);
            this.numSalaire.TabIndex = 16;
            this.numSalaire.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(487, 221);
            this.tbRemarque.MaxLength = 50;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(137, 20);
            this.tbRemarque.TabIndex = 18;
            // 
            // msgErreur
            // 
            this.msgErreur.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ville:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prénom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mot de passe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nom:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sexe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Âge:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Numéro civique:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Rue:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Province:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Code postal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(385, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Téléphone:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(385, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Cellulaire:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(385, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Courriel:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(385, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Salaire:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(385, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Type:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(385, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Remarque:";
            // 
            // typesEmployeBindingSource
            // 
            this.typesEmployeBindingSource.DataMember = "TypesEmploye";
            this.typesEmployeBindingSource.DataSource = this.bDB56Projet22DataSet;
            // 
            // typesEmployeTableAdapter
            // 
            this.typesEmployeTableAdapter.ClearBeforeFill = true;
            // 
            // cboTypeEmp
            // 
            this.cboTypeEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeEmp.FormattingEnabled = true;
            this.cboTypeEmp.Location = new System.Drawing.Point(487, 193);
            this.cboTypeEmp.Name = "cboTypeEmp";
            this.cboTypeEmp.Size = new System.Drawing.Size(137, 21);
            this.cboTypeEmp.TabIndex = 35;
            // 
            // AjoutEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 322);
            this.Controls.Add(this.cboTypeEmp);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.numSalaire);
            this.Controls.Add(this.tbCouriel);
            this.Controls.Add(this.mtbCodePostal);
            this.Controls.Add(this.cboIdProvince);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.tbRue);
            this.Controls.Add(this.tbNoCivique);
            this.Controls.Add(this.mtbCellulaire);
            this.Controls.Add(this.mtbTelephone);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.ddlSexe);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbMotDePasse);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Name = "AjoutEmp";
            this.Text = "Ajouter un employé";
            this.Load += new System.EventHandler(this.AjoutEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet22DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox tbMotDePasse;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.ComboBox ddlSexe;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.MaskedTextBox mtbCellulaire;
        private System.Windows.Forms.TextBox tbNoCivique;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.ComboBox cboIdProvince;
        private BDB56Projet22DataSet bDB56Projet22DataSet;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private BDB56Projet22DataSetTableAdapters.ProvincesTableAdapter provincesTableAdapter;
        private BDB56Projet22DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox mtbCodePostal;
        private System.Windows.Forms.TextBox tbCouriel;
        private System.Windows.Forms.NumericUpDown numSalaire;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.ErrorProvider msgErreur;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BDB56Projet22DataSetTableAdapters.TypesEmployeTableAdapter typesEmployeTableAdapter;
        private System.Windows.Forms.BindingSource typesEmployeBindingSource;
        private System.Windows.Forms.ComboBox cboTypeEmp;
    }
}