
namespace ProjetGestionClubGolf
{
    partial class GestionAbonnements
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAbonnementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCiviqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellulaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courrielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTypeAbonnementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAbonnementss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjoutAbonnement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateAbonnementDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.dateNaissanceDataGridViewTextBoxColumn,
            this.noCiviqueDataGridViewTextBoxColumn,
            this.rueDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.idProvinceDataGridViewTextBoxColumn,
            this.codePostalDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.cellulaireDataGridViewTextBoxColumn,
            this.courrielDataGridViewTextBoxColumn,
            this.noTypeAbonnementDataGridViewTextBoxColumn,
            this.remarqueDataGridViewTextBoxColumn,
            this.DateAbonnementss});
            this.dataGridView1.DataSource = this.abonnementBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateAbonnementDataGridViewTextBoxColumn
            // 
            this.dateAbonnementDataGridViewTextBoxColumn.DataPropertyName = "DateAbonnement";
            this.dateAbonnementDataGridViewTextBoxColumn.HeaderText = "DateAbonnementss";
            this.dateAbonnementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAbonnementDataGridViewTextBoxColumn.Name = "dateAbonnementDataGridViewTextBoxColumn";
            this.dateAbonnementDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "Sexe";
            this.sexeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            this.sexeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateNaissanceDataGridViewTextBoxColumn
            // 
            this.dateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "DateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.HeaderText = "DateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateNaissanceDataGridViewTextBoxColumn.Name = "dateNaissanceDataGridViewTextBoxColumn";
            this.dateNaissanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // noCiviqueDataGridViewTextBoxColumn
            // 
            this.noCiviqueDataGridViewTextBoxColumn.DataPropertyName = "NoCivique";
            this.noCiviqueDataGridViewTextBoxColumn.HeaderText = "NoCivique";
            this.noCiviqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noCiviqueDataGridViewTextBoxColumn.Name = "noCiviqueDataGridViewTextBoxColumn";
            this.noCiviqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // rueDataGridViewTextBoxColumn
            // 
            this.rueDataGridViewTextBoxColumn.DataPropertyName = "Rue";
            this.rueDataGridViewTextBoxColumn.HeaderText = "Rue";
            this.rueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rueDataGridViewTextBoxColumn.Name = "rueDataGridViewTextBoxColumn";
            this.rueDataGridViewTextBoxColumn.Width = 125;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.Width = 125;
            // 
            // idProvinceDataGridViewTextBoxColumn
            // 
            this.idProvinceDataGridViewTextBoxColumn.DataPropertyName = "IdProvince";
            this.idProvinceDataGridViewTextBoxColumn.HeaderText = "IdProvince";
            this.idProvinceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProvinceDataGridViewTextBoxColumn.Name = "idProvinceDataGridViewTextBoxColumn";
            this.idProvinceDataGridViewTextBoxColumn.Width = 125;
            // 
            // codePostalDataGridViewTextBoxColumn
            // 
            this.codePostalDataGridViewTextBoxColumn.DataPropertyName = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.HeaderText = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codePostalDataGridViewTextBoxColumn.Name = "codePostalDataGridViewTextBoxColumn";
            this.codePostalDataGridViewTextBoxColumn.Width = 125;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // cellulaireDataGridViewTextBoxColumn
            // 
            this.cellulaireDataGridViewTextBoxColumn.DataPropertyName = "Cellulaire";
            this.cellulaireDataGridViewTextBoxColumn.HeaderText = "Cellulaire";
            this.cellulaireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cellulaireDataGridViewTextBoxColumn.Name = "cellulaireDataGridViewTextBoxColumn";
            this.cellulaireDataGridViewTextBoxColumn.Width = 125;
            // 
            // courrielDataGridViewTextBoxColumn
            // 
            this.courrielDataGridViewTextBoxColumn.DataPropertyName = "Courriel";
            this.courrielDataGridViewTextBoxColumn.HeaderText = "Courriel";
            this.courrielDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courrielDataGridViewTextBoxColumn.Name = "courrielDataGridViewTextBoxColumn";
            this.courrielDataGridViewTextBoxColumn.Width = 125;
            // 
            // noTypeAbonnementDataGridViewTextBoxColumn
            // 
            this.noTypeAbonnementDataGridViewTextBoxColumn.DataPropertyName = "NoTypeAbonnement";
            this.noTypeAbonnementDataGridViewTextBoxColumn.HeaderText = "NoTypeAbonnement";
            this.noTypeAbonnementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noTypeAbonnementDataGridViewTextBoxColumn.Name = "noTypeAbonnementDataGridViewTextBoxColumn";
            this.noTypeAbonnementDataGridViewTextBoxColumn.Width = 125;
            // 
            // remarqueDataGridViewTextBoxColumn
            // 
            this.remarqueDataGridViewTextBoxColumn.DataPropertyName = "Remarque";
            this.remarqueDataGridViewTextBoxColumn.HeaderText = "Remarque";
            this.remarqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarqueDataGridViewTextBoxColumn.Name = "remarqueDataGridViewTextBoxColumn";
            this.remarqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // DateAbonnementss
            // 
            this.DateAbonnementss.HeaderText = "testing";
            this.DateAbonnementss.Name = "DateAbonnementss";
            // 
            // abonnementBindingSource
            // 
            this.abonnementBindingSource.DataSource = typeof(ProjetGestionClubGolf.Abonnement);
            // 
            // btnAjoutAbonnement
            // 
            this.btnAjoutAbonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutAbonnement.Location = new System.Drawing.Point(276, 317);
            this.btnAjoutAbonnement.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjoutAbonnement.Name = "btnAjoutAbonnement";
            this.btnAjoutAbonnement.Size = new System.Drawing.Size(230, 35);
            this.btnAjoutAbonnement.TabIndex = 3;
            this.btnAjoutAbonnement.Text = "Ajouter un abonnement";
            this.btnAjoutAbonnement.UseVisualStyleBackColor = true;
            this.btnAjoutAbonnement.Click += new System.EventHandler(this.btnAjoutAbonnement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestion Abonnement";
            // 
            // GestionAbonnements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAjoutAbonnement);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionAbonnements";
            this.Text = "Gestion des abonnements";
            this.Load += new System.EventHandler(this.GestionAbonnements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource abonnementBindingSource;
        private System.Windows.Forms.Button btnAjoutAbonnement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAbonnementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCiviqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellulaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courrielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTypeAbonnementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAbonnementss;
    }
}