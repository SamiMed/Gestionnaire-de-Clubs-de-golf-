
namespace ProjetGestionClubGolf
{
    partial class Rapports
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgPartieJouer = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAnnees = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgDepenseParAbonnement = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAbonnePrincipal = new System.Windows.Forms.ComboBox();
            this.tabDepensesParAnnee = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dgDepensesParAnnee = new System.Windows.Forms.DataGridView();
            this.cbAnneesDepensesParAnnee = new System.Windows.Forms.ComboBox();
            this.tbRapprotPartieJouerParAbonnement = new System.Windows.Forms.TabPage();
            this.dgpartieJouerParAbonnement = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAbonnerPartieJouer = new System.Windows.Forms.ComboBox();
            this.tabRapportPartieParTerrain = new System.Windows.Forms.TabPage();
            this.dgPartiesParTerrains = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTerrain = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgDepensesParEmploye = new System.Windows.Forms.DataGridView();
            this.label567 = new System.Windows.Forms.Label();
            this.cboEmployes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.abonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartieJouer)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepenseParAbonnement)).BeginInit();
            this.tabDepensesParAnnee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepensesParAnnee)).BeginInit();
            this.tbRapprotPartieJouerParAbonnement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpartieJouerParAbonnement)).BeginInit();
            this.tabRapportPartieParTerrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartiesParTerrains)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepensesParEmploye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabDepensesParAnnee);
            this.tabControl1.Controls.Add(this.tbRapprotPartieJouerParAbonnement);
            this.tabControl1.Controls.Add(this.tabRapportPartieParTerrain);
            this.tabControl1.Location = new System.Drawing.Point(51, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1159, 557);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgPartieJouer);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbAnnees);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1151, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rapport des parties jouées par année";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgPartieJouer
            // 
            this.dgPartieJouer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPartieJouer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPartieJouer.Location = new System.Drawing.Point(146, 94);
            this.dgPartieJouer.Name = "dgPartieJouer";
            this.dgPartieJouer.Size = new System.Drawing.Size(840, 406);
            this.dgPartieJouer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choisir une année";
            // 
            // cbAnnees
            // 
            this.cbAnnees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnnees.FormattingEnabled = true;
            this.cbAnnees.Location = new System.Drawing.Point(146, 53);
            this.cbAnnees.Name = "cbAnnees";
            this.cbAnnees.Size = new System.Drawing.Size(155, 21);
            this.cbAnnees.TabIndex = 1;
            this.cbAnnees.SelectedValueChanged += new System.EventHandler(this.cbAnnees_SelectedValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgDepenseParAbonnement);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbAbonnePrincipal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1151, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Le rapport des dépenses par abonnement";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgDepenseParAbonnement
            // 
            this.dgDepenseParAbonnement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepenseParAbonnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepenseParAbonnement.Location = new System.Drawing.Point(139, 94);
            this.dgDepenseParAbonnement.Name = "dgDepenseParAbonnement";
            this.dgDepenseParAbonnement.Size = new System.Drawing.Size(895, 392);
            this.dgDepenseParAbonnement.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choisir un abonné principal";
            // 
            // cbAbonnePrincipal
            // 
            this.cbAbonnePrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbonnePrincipal.FormattingEnabled = true;
            this.cbAbonnePrincipal.Location = new System.Drawing.Point(207, 27);
            this.cbAbonnePrincipal.Name = "cbAbonnePrincipal";
            this.cbAbonnePrincipal.Size = new System.Drawing.Size(208, 21);
            this.cbAbonnePrincipal.TabIndex = 0;
            this.cbAbonnePrincipal.SelectedValueChanged += new System.EventHandler(this.cbAbonnePrincipal_SelectedValueChanged);
            // 
            // tabDepensesParAnnee
            // 
            this.tabDepensesParAnnee.Controls.Add(this.label6);
            this.tabDepensesParAnnee.Controls.Add(this.dgDepensesParAnnee);
            this.tabDepensesParAnnee.Controls.Add(this.cbAnneesDepensesParAnnee);
            this.tabDepensesParAnnee.Location = new System.Drawing.Point(4, 22);
            this.tabDepensesParAnnee.Name = "tabDepensesParAnnee";
            this.tabDepensesParAnnee.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepensesParAnnee.Size = new System.Drawing.Size(1151, 531);
            this.tabDepensesParAnnee.TabIndex = 2;
            this.tabDepensesParAnnee.Text = "Rapport des dépenses par années";
            this.tabDepensesParAnnee.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Choisir une année";
            // 
            // dgDepensesParAnnee
            // 
            this.dgDepensesParAnnee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepensesParAnnee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepensesParAnnee.Location = new System.Drawing.Point(184, 84);
            this.dgDepensesParAnnee.Name = "dgDepensesParAnnee";
            this.dgDepensesParAnnee.Size = new System.Drawing.Size(840, 427);
            this.dgDepensesParAnnee.TabIndex = 6;
            // 
            // cbAnneesDepensesParAnnee
            // 
            this.cbAnneesDepensesParAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnneesDepensesParAnnee.FormattingEnabled = true;
            this.cbAnneesDepensesParAnnee.Location = new System.Drawing.Point(214, 44);
            this.cbAnneesDepensesParAnnee.Name = "cbAnneesDepensesParAnnee";
            this.cbAnneesDepensesParAnnee.Size = new System.Drawing.Size(155, 21);
            this.cbAnneesDepensesParAnnee.TabIndex = 4;
            this.cbAnneesDepensesParAnnee.SelectedValueChanged += new System.EventHandler(this.cbAnneesDepensesParAnnee_SelectedValueChanged);
            // 
            // tbRapprotPartieJouerParAbonnement
            // 
            this.tbRapprotPartieJouerParAbonnement.Controls.Add(this.dgpartieJouerParAbonnement);
            this.tbRapprotPartieJouerParAbonnement.Controls.Add(this.label5);
            this.tbRapprotPartieJouerParAbonnement.Controls.Add(this.cbAbonnerPartieJouer);
            this.tbRapprotPartieJouerParAbonnement.Location = new System.Drawing.Point(4, 22);
            this.tbRapprotPartieJouerParAbonnement.Name = "tbRapprotPartieJouerParAbonnement";
            this.tbRapprotPartieJouerParAbonnement.Padding = new System.Windows.Forms.Padding(3);
            this.tbRapprotPartieJouerParAbonnement.Size = new System.Drawing.Size(1151, 531);
            this.tbRapprotPartieJouerParAbonnement.TabIndex = 3;
            this.tbRapprotPartieJouerParAbonnement.Text = "Rapport parties jouer par abonnements";
            this.tbRapprotPartieJouerParAbonnement.UseVisualStyleBackColor = true;
            // 
            // dgpartieJouerParAbonnement
            // 
            this.dgpartieJouerParAbonnement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgpartieJouerParAbonnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpartieJouerParAbonnement.Location = new System.Drawing.Point(163, 101);
            this.dgpartieJouerParAbonnement.Name = "dgpartieJouerParAbonnement";
            this.dgpartieJouerParAbonnement.Size = new System.Drawing.Size(852, 387);
            this.dgpartieJouerParAbonnement.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choisir un abonné principal";
            // 
            // cbAbonnerPartieJouer
            // 
            this.cbAbonnerPartieJouer.FormattingEnabled = true;
            this.cbAbonnerPartieJouer.Location = new System.Drawing.Point(221, 46);
            this.cbAbonnerPartieJouer.Name = "cbAbonnerPartieJouer";
            this.cbAbonnerPartieJouer.Size = new System.Drawing.Size(208, 21);
            this.cbAbonnerPartieJouer.TabIndex = 3;
            this.cbAbonnerPartieJouer.SelectedValueChanged += new System.EventHandler(this.cbAbonnerPartieJouer_SelectedValueChanged);
            // 
            // tabRapportPartieParTerrain
            // 
            this.tabRapportPartieParTerrain.Controls.Add(this.dgPartiesParTerrains);
            this.tabRapportPartieParTerrain.Controls.Add(this.label4);
            this.tabRapportPartieParTerrain.Controls.Add(this.cboTerrain);
            this.tabRapportPartieParTerrain.Location = new System.Drawing.Point(4, 22);
            this.tabRapportPartieParTerrain.Name = "tabRapportPartieParTerrain";
            this.tabRapportPartieParTerrain.Padding = new System.Windows.Forms.Padding(3);
            this.tabRapportPartieParTerrain.Size = new System.Drawing.Size(1151, 531);
            this.tabRapportPartieParTerrain.TabIndex = 2;
            this.tabRapportPartieParTerrain.Text = "Le rapport des parties jouées par terrain";
            this.tabRapportPartieParTerrain.UseVisualStyleBackColor = true;
            // 
            // dgPartiesParTerrains
            // 
            this.dgPartiesParTerrains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPartiesParTerrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPartiesParTerrains.Location = new System.Drawing.Point(159, 64);
            this.dgPartiesParTerrains.Name = "dgPartiesParTerrains";
            this.dgPartiesParTerrains.Size = new System.Drawing.Size(866, 444);
            this.dgPartiesParTerrains.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choisir une année";
            // 
            // cboTerrain
            // 
            this.cboTerrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerrain.FormattingEnabled = true;
            this.cboTerrain.Location = new System.Drawing.Point(146, 26);
            this.cboTerrain.Name = "cboTerrain";
            this.cboTerrain.Size = new System.Drawing.Size(155, 21);
            this.cboTerrain.TabIndex = 3;
            this.cboTerrain.SelectedValueChanged += new System.EventHandler(this.cboTerrain_SelectedValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgDepensesParEmploye);
            this.tabPage3.Controls.Add(this.label567);
            this.tabPage3.Controls.Add(this.cboEmployes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1151, 531);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Le rapport des dépenses par employé";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgDepensesParEmploye
            // 
            this.dgDepensesParEmploye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepensesParEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepensesParEmploye.Location = new System.Drawing.Point(142, 64);
            this.dgDepensesParEmploye.Name = "dgDepensesParEmploye";
            this.dgDepensesParEmploye.Size = new System.Drawing.Size(867, 444);
            this.dgDepensesParEmploye.TabIndex = 7;
            // 
            // label567
            // 
            this.label567.AutoSize = true;
            this.label567.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label567.Location = new System.Drawing.Point(25, 27);
            this.label567.Name = "label567";
            this.label567.Size = new System.Drawing.Size(122, 16);
            this.label567.TabIndex = 6;
            this.label567.Text = "Choisir un employé";
            // 
            // cboEmployes
            // 
            this.cboEmployes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployes.FormattingEnabled = true;
            this.cboEmployes.Location = new System.Drawing.Point(155, 26);
            this.cboEmployes.Name = "cboEmployes";
            this.cboEmployes.Size = new System.Drawing.Size(155, 21);
            this.cboEmployes.TabIndex = 5;
            this.cboEmployes.SelectedIndexChanged += new System.EventHandler(this.cboEmployes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Les rapports";
            // 
            // abonnementBindingSource
            // 
            this.abonnementBindingSource.DataSource = typeof(ProjetGestionClubGolf.Abonnement);
            // 
            // Rapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Rapports";
            this.Text = "Rapports";
            this.Load += new System.EventHandler(this.Rapports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartieJouer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepenseParAbonnement)).EndInit();
            this.tabDepensesParAnnee.ResumeLayout(false);
            this.tabDepensesParAnnee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepensesParAnnee)).EndInit();
            this.tbRapprotPartieJouerParAbonnement.ResumeLayout(false);
            this.tbRapprotPartieJouerParAbonnement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpartieJouerParAbonnement)).EndInit();
            this.tabRapportPartieParTerrain.ResumeLayout(false);
            this.tabRapportPartieParTerrain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartiesParTerrains)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepensesParEmploye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAnnees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgPartieJouer;
        private System.Windows.Forms.DataGridView dgDepenseParAbonnement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAbonnePrincipal;
        private System.Windows.Forms.BindingSource abonnementBindingSource;
        private System.Windows.Forms.TabPage tabRapportPartieParTerrain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTerrain;
        private System.Windows.Forms.DataGridView dgPartiesParTerrains;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgDepensesParEmploye;
       private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEmployes;
        private System.Windows.Forms.TabPage tabDepensesParAnnee;
        private System.Windows.Forms.DataGridView dgDepensesParAnnee;
        private System.Windows.Forms.ComboBox cbAnneesDepensesParAnnee;
        private System.Windows.Forms.TabPage tbRapprotPartieJouerParAbonnement;
        private System.Windows.Forms.DataGridView dgpartieJouerParAbonnement;
        private System.Windows.Forms.Label label567;
        private System.Windows.Forms.ComboBox cbAbonnerPartieJouer;
        private System.Windows.Forms.Label label6;
    }
}