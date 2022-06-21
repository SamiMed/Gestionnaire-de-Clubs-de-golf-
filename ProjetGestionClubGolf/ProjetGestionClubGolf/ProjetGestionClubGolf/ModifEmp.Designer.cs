namespace ProjetGestionClubGolf
{
    partial class ModifEmp
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
            this.cboTypeEmp = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.numSalaire = new System.Windows.Forms.NumericUpDown();
            this.tbCouriel = new System.Windows.Forms.TextBox();
            this.mtbCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.cboIdProvince = new System.Windows.Forms.ComboBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbNoCivique = new System.Windows.Forms.TextBox();
            this.mtbCellulaire = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.ddlSexe = new System.Windows.Forms.ComboBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbMotDePasse = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.bDB56Projet22DataSet = new ProjetGestionClubGolf.BDB56Projet22DataSet();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provincesTableAdapter = new ProjetGestionClubGolf.BDB56Projet22DataSetTableAdapters.ProvincesTableAdapter();
            this.tableAdapterManager = new ProjetGestionClubGolf.BDB56Projet22DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.numSalaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet22DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTypeEmp
            // 
            this.cboTypeEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeEmp.FormattingEnabled = true;
            this.cboTypeEmp.Location = new System.Drawing.Point(484, 185);
            this.cboTypeEmp.Name = "cboTypeEmp";
            this.cboTypeEmp.Size = new System.Drawing.Size(137, 21);
            this.cboTypeEmp.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(382, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 68;
            this.label16.Text = "Remarque:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(382, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 67;
            this.label15.Text = "Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(382, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Salaire:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(382, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Courriel:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Cellulaire:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(382, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Téléphone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Code postal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Province:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Rue:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Numéro civique:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Âge:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Sexe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Mot de passe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Prénom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ville:";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(484, 213);
            this.tbRemarque.MaxLength = 50;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(137, 20);
            this.tbRemarque.TabIndex = 52;
            // 
            // numSalaire
            // 
            this.numSalaire.DecimalPlaces = 2;
            this.numSalaire.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSalaire.Location = new System.Drawing.Point(484, 159);
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
            this.numSalaire.TabIndex = 51;
            this.numSalaire.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tbCouriel
            // 
            this.tbCouriel.Location = new System.Drawing.Point(484, 132);
            this.tbCouriel.MaxLength = 50;
            this.tbCouriel.Name = "tbCouriel";
            this.tbCouriel.Size = new System.Drawing.Size(137, 20);
            this.tbCouriel.TabIndex = 50;
            // 
            // mtbCodePostal
            // 
            this.mtbCodePostal.Location = new System.Drawing.Point(484, 56);
            this.mtbCodePostal.Mask = "A9A 9A9";
            this.mtbCodePostal.Name = "mtbCodePostal";
            this.mtbCodePostal.Size = new System.Drawing.Size(137, 20);
            this.mtbCodePostal.TabIndex = 49;
            // 
            // cboIdProvince
            // 
            this.cboIdProvince.DataSource = this.provincesBindingSource;
            this.cboIdProvince.DisplayMember = "Nom";
            this.cboIdProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdProvince.FormattingEnabled = true;
            this.cboIdProvince.Location = new System.Drawing.Point(484, 28);
            this.cboIdProvince.Name = "cboIdProvince";
            this.cboIdProvince.Size = new System.Drawing.Size(137, 21);
            this.cboIdProvince.TabIndex = 48;
            this.cboIdProvince.ValueMember = "Id";
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(129, 216);
            this.tbVille.MaxLength = 50;
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(137, 20);
            this.tbVille.TabIndex = 47;
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(129, 189);
            this.tbRue.MaxLength = 50;
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(137, 20);
            this.tbRue.TabIndex = 46;
            // 
            // tbNoCivique
            // 
            this.tbNoCivique.Location = new System.Drawing.Point(129, 162);
            this.tbNoCivique.Name = "tbNoCivique";
            this.tbNoCivique.Size = new System.Drawing.Size(137, 20);
            this.tbNoCivique.TabIndex = 45;
            // 
            // mtbCellulaire
            // 
            this.mtbCellulaire.Location = new System.Drawing.Point(484, 107);
            this.mtbCellulaire.Mask = "(999) 999-9999";
            this.mtbCellulaire.Name = "mtbCellulaire";
            this.mtbCellulaire.Size = new System.Drawing.Size(137, 20);
            this.mtbCellulaire.TabIndex = 44;
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(484, 81);
            this.mtbTelephone.Mask = "(999) 999-9999";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(137, 20);
            this.mtbTelephone.TabIndex = 43;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(129, 135);
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
            this.numAge.TabIndex = 42;
            this.numAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // ddlSexe
            // 
            this.ddlSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSexe.FormattingEnabled = true;
            this.ddlSexe.Location = new System.Drawing.Point(129, 107);
            this.ddlSexe.Name = "ddlSexe";
            this.ddlSexe.Size = new System.Drawing.Size(137, 21);
            this.ddlSexe.TabIndex = 41;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(129, 81);
            this.tbPrenom.MaxLength = 30;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(137, 20);
            this.tbPrenom.TabIndex = 40;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(129, 55);
            this.tbNom.MaxLength = 30;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(137, 20);
            this.tbNom.TabIndex = 39;
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(129, 29);
            this.tbMotDePasse.MaxLength = 50;
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.PasswordChar = '*';
            this.tbMotDePasse.Size = new System.Drawing.Size(137, 20);
            this.tbMotDePasse.TabIndex = 38;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(29, 270);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(137, 23);
            this.btnAnnuler.TabIndex = 37;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(484, 270);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(137, 23);
            this.btnModifier.TabIndex = 36;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
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
            this.tableAdapterManager.TypesEmployeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetGestionClubGolf.BDB56Projet22DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ModifEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 307);
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
            this.Controls.Add(this.btnModifier);
            this.Name = "ModifEmp";
            this.Text = "ModifEmp";
            this.Load += new System.EventHandler(this.ModifEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSalaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet22DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTypeEmp;
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
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.NumericUpDown numSalaire;
        private System.Windows.Forms.TextBox tbCouriel;
        private System.Windows.Forms.MaskedTextBox mtbCodePostal;
        private System.Windows.Forms.ComboBox cboIdProvince;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbNoCivique;
        private System.Windows.Forms.MaskedTextBox mtbCellulaire;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.ComboBox ddlSexe;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbMotDePasse;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private BDB56Projet22DataSet bDB56Projet22DataSet;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private BDB56Projet22DataSetTableAdapters.ProvincesTableAdapter provincesTableAdapter;
        private BDB56Projet22DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}