namespace INTEC.Patient
{
    partial class UserTypeForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModifiedDate = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbPanel = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.gbPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(697, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Criterio:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(759, 21);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(207, 22);
            this.txtFilter.TabIndex = 36;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "-- TODOS --",
            "Id",
            "Usuario",
            "Nombre Completo",
            "Tipo de Usuario",
            "Fecha de Creación"});
            this.cbFilter.Location = new System.Drawing.Point(420, 23);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(195, 24);
            this.cbFilter.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Filtrar por:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(257, 378);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 32);
            this.btnNew.TabIndex = 35;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(120, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(7, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 32);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvRecords
            // 
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Location = new System.Drawing.Point(344, 53);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.RowHeadersWidth = 51;
            this.dgvRecords.RowTemplate.Height = 24;
            this.dgvRecords.Size = new System.Drawing.Size(708, 357);
            this.dgvRecords.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ultima Modificación:";
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(24, 304);
            this.txtModifiedDate.Name = "txtModifiedDate";
            this.txtModifiedDate.ReadOnly = true;
            this.txtModifiedDate.Size = new System.Drawing.Size(279, 22);
            this.txtModifiedDate.TabIndex = 25;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(972, 16);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(80, 32);
            this.btnFilter.TabIndex = 39;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fecha de Creación:";
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Location = new System.Drawing.Point(21, 250);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(279, 22);
            this.txtCreatedDate.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Descripcion:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(24, 166);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(279, 22);
            this.txtDescription.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(27, 58);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(279, 22);
            this.txtId.TabIndex = 16;
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(27, 194);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(70, 20);
            this.chkEnabled.TabIndex = 13;
            this.chkEnabled.Text = "Visible";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(27, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 22);
            this.txtName.TabIndex = 9;
            // 
            // gbPanel
            // 
            this.gbPanel.Controls.Add(this.label7);
            this.gbPanel.Controls.Add(this.txtModifiedDate);
            this.gbPanel.Controls.Add(this.label6);
            this.gbPanel.Controls.Add(this.txtCreatedDate);
            this.gbPanel.Controls.Add(this.label5);
            this.gbPanel.Controls.Add(this.label3);
            this.gbPanel.Controls.Add(this.txtId);
            this.gbPanel.Controls.Add(this.label1);
            this.gbPanel.Controls.Add(this.txtDescription);
            this.gbPanel.Controls.Add(this.txtName);
            this.gbPanel.Controls.Add(this.chkEnabled);
            this.gbPanel.Location = new System.Drawing.Point(7, 14);
            this.gbPanel.Name = "gbPanel";
            this.gbPanel.Size = new System.Drawing.Size(331, 349);
            this.gbPanel.TabIndex = 31;
            this.gbPanel.TabStop = false;
            this.gbPanel.Text = "GESTION DE USUARIOS";
            // 
            // UserTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 428);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.gbPanel);
            this.Name = "UserTypeForm";
            this.Text = "UserTypeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.gbPanel.ResumeLayout(false);
            this.gbPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModifiedDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbPanel;
    }
}