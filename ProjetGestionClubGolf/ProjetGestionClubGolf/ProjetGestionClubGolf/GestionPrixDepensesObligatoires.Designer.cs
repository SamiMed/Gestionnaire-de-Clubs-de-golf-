namespace ProjetGestionClubGolf
{
    partial class GestionPrixDepensesObligatoires
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
            this.dgTypeAbonnement = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prixDepensesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgGestionPrixDepenses = new System.Windows.Forms.DataGridView();
            this.NoTypeAbonnement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTypeAbonnement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionPrixDepenses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTypeAbonnement
            // 
            this.dgTypeAbonnement.AutoGenerateColumns = false;
            this.dgTypeAbonnement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTypeAbonnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTypeAbonnement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgTypeAbonnement.DataSource = this.typesAbonnementBindingSource;
            this.dgTypeAbonnement.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgTypeAbonnement.Location = new System.Drawing.Point(29, 116);
            this.dgTypeAbonnement.Name = "dgTypeAbonnement";
            this.dgTypeAbonnement.ReadOnly = true;
            this.dgTypeAbonnement.Size = new System.Drawing.Size(269, 161);
            this.dgTypeAbonnement.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(ProjetGestionClubGolf.TypesAbonnement);
            // 
            // prixDepensesAbonnementBindingSource
            // 
            this.prixDepensesAbonnementBindingSource.DataSource = typeof(ProjetGestionClubGolf.PrixDepensesAbonnement);
            // 
            // dgGestionPrixDepenses
            // 
            this.dgGestionPrixDepenses.AllowUserToAddRows = false;
            this.dgGestionPrixDepenses.AutoGenerateColumns = false;
            this.dgGestionPrixDepenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGestionPrixDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGestionPrixDepenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoTypeAbonnement,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgGestionPrixDepenses.DataSource = this.prixDepensesAbonnementBindingSource;
            this.dgGestionPrixDepenses.Location = new System.Drawing.Point(352, 88);
            this.dgGestionPrixDepenses.Name = "dgGestionPrixDepenses";
            this.dgGestionPrixDepenses.Size = new System.Drawing.Size(412, 201);
            this.dgGestionPrixDepenses.TabIndex = 1;
            this.dgGestionPrixDepenses.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGestionPrixDepenses_CellValueChanged);
            // 
            // NoTypeAbonnement
            // 
            this.NoTypeAbonnement.DataPropertyName = "NoTypeAbonnement";
            this.NoTypeAbonnement.HeaderText = "NoTypeAbonnement";
            this.NoTypeAbonnement.Name = "NoTypeAbonnement";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DepensesObligatoires";
            this.dataGridViewTextBoxColumn6.HeaderText = "DepensesObligatoires";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionPrixDepensesObligatoires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgGestionPrixDepenses);
            this.Controls.Add(this.dgTypeAbonnement);
            this.Name = "GestionPrixDepensesObligatoires";
            this.Text = "GestionPrixDepensesObligatoires";
            this.Load += new System.EventHandler(this.GestionPrixDepensesObligatoires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTypeAbonnement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionPrixDepenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTypeAbonnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depensesObligatoiresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.BindingSource prixDepensesAbonnementBindingSource;
        private System.Windows.Forms.DataGridView dgGestionPrixDepenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoTypeAbonnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
    }
}