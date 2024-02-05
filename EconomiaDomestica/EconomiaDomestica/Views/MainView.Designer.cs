namespace EconomiaDomestica.Views
{
    partial class MainView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGVRegistro = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbIdRegistro = new System.Windows.Forms.TextBox();
            this.txtbFecha = new System.Windows.Forms.TextBox();
            this.txtbConcepto = new System.Windows.Forms.TextBox();
            this.txtbImporte = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.tabPageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registros";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageList);
            this.tabControl.Controls.Add(this.tabPageDetail);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 53);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 397);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.dataGVRegistro);
            this.tabPageList.Controls.Add(this.btnDelete);
            this.tabPageList.Controls.Add(this.btnEdit);
            this.tabPageList.Controls.Add(this.btnAddNew);
            this.tabPageList.Controls.Add(this.btnSearch);
            this.tabPageList.Controls.Add(this.txtbSearch);
            this.tabPageList.Controls.Add(this.label2);
            this.tabPageList.Location = new System.Drawing.Point(4, 22);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageList.Size = new System.Drawing.Size(792, 371);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "Lista";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.btnCancel);
            this.tabPageDetail.Controls.Add(this.btnSave);
            this.tabPageDetail.Controls.Add(this.txtbImporte);
            this.tabPageDetail.Controls.Add(this.txtbConcepto);
            this.tabPageDetail.Controls.Add(this.txtbFecha);
            this.tabPageDetail.Controls.Add(this.txtbIdRegistro);
            this.tabPageDetail.Controls.Add(this.label6);
            this.tabPageDetail.Controls.Add(this.label5);
            this.tabPageDetail.Controls.Add(this.label4);
            this.tabPageDetail.Controls.Add(this.label3);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetail.Size = new System.Drawing.Size(792, 371);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Detalle";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Busca concepto";
            // 
            // txtbSearch
            // 
            this.txtbSearch.Location = new System.Drawing.Point(15, 24);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(647, 20);
            this.txtbSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(587, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(687, 48);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Añadir";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(687, 77);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(687, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGVRegistro
            // 
            this.dataGVRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVRegistro.Location = new System.Drawing.Point(15, 50);
            this.dataGVRegistro.Name = "dataGVRegistro";
            this.dataGVRegistro.Size = new System.Drawing.Size(647, 318);
            this.dataGVRegistro.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id Registro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Concepto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Importe";
            // 
            // txtbIdRegistro
            // 
            this.txtbIdRegistro.Location = new System.Drawing.Point(90, 39);
            this.txtbIdRegistro.Name = "txtbIdRegistro";
            this.txtbIdRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtbIdRegistro.TabIndex = 4;
            // 
            // txtbFecha
            // 
            this.txtbFecha.Location = new System.Drawing.Point(90, 70);
            this.txtbFecha.Name = "txtbFecha";
            this.txtbFecha.Size = new System.Drawing.Size(100, 20);
            this.txtbFecha.TabIndex = 5;
            // 
            // txtbConcepto
            // 
            this.txtbConcepto.Location = new System.Drawing.Point(90, 98);
            this.txtbConcepto.Name = "txtbConcepto";
            this.txtbConcepto.Size = new System.Drawing.Size(100, 20);
            this.txtbConcepto.TabIndex = 6;
            // 
            // txtbImporte
            // 
            this.txtbImporte.Location = new System.Drawing.Point(90, 129);
            this.txtbImporte.Name = "txtbImporte";
            this.txtbImporte.Size = new System.Drawing.Size(100, 20);
            this.txtbImporte.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(283, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(283, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.tabPageList.PerformLayout();
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGVRegistro;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtbImporte;
        private System.Windows.Forms.TextBox txtbConcepto;
        private System.Windows.Forms.TextBox txtbFecha;
        private System.Windows.Forms.TextBox txtbIdRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}