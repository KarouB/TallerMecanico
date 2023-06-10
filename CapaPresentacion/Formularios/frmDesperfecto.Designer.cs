
namespace CapaPresentacion.Formularios
{
    partial class frmDesperfecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesperfecto));
            this.btnEliminarRepuesto = new System.Windows.Forms.Button();
            this.lbxRepuestos = new System.Windows.Forms.ListBox();
            this.btnGenerarDesperfecto = new System.Windows.Forms.Button();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarRepuesto = new System.Windows.Forms.Button();
            this.txtManoObra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxRepuesto = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarRepuesto
            // 
            this.btnEliminarRepuesto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRepuesto.Location = new System.Drawing.Point(170, 61);
            this.btnEliminarRepuesto.Name = "btnEliminarRepuesto";
            this.btnEliminarRepuesto.Size = new System.Drawing.Size(60, 23);
            this.btnEliminarRepuesto.TabIndex = 7;
            this.btnEliminarRepuesto.Text = "Eliminar";
            this.btnEliminarRepuesto.UseVisualStyleBackColor = true;
            this.btnEliminarRepuesto.Click += new System.EventHandler(this.btnEliminarRepuesto_Click);
            // 
            // lbxRepuestos
            // 
            this.lbxRepuestos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRepuestos.FormattingEnabled = true;
            this.lbxRepuestos.ItemHeight = 15;
            this.lbxRepuestos.Location = new System.Drawing.Point(11, 61);
            this.lbxRepuestos.Name = "lbxRepuestos";
            this.lbxRepuestos.Size = new System.Drawing.Size(153, 109);
            this.lbxRepuestos.TabIndex = 24;
            // 
            // btnGenerarDesperfecto
            // 
            this.btnGenerarDesperfecto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarDesperfecto.Location = new System.Drawing.Point(157, 5);
            this.btnGenerarDesperfecto.Name = "btnGenerarDesperfecto";
            this.btnGenerarDesperfecto.Size = new System.Drawing.Size(72, 23);
            this.btnGenerarDesperfecto.TabIndex = 8;
            this.btnGenerarDesperfecto.Text = "Guardar";
            this.btnGenerarDesperfecto.UseVisualStyleBackColor = true;
            this.btnGenerarDesperfecto.Click += new System.EventHandler(this.btnGenerarDesperfecto_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(110, 35);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(153, 23);
            this.txtTiempo.TabIndex = 2;
            this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tiempo Estimado: (Dias)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAgregarRepuesto
            // 
            this.btnAgregarRepuesto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRepuesto.Location = new System.Drawing.Point(170, 36);
            this.btnAgregarRepuesto.Name = "btnAgregarRepuesto";
            this.btnAgregarRepuesto.Size = new System.Drawing.Size(60, 23);
            this.btnAgregarRepuesto.TabIndex = 5;
            this.btnAgregarRepuesto.Text = "Añadir";
            this.btnAgregarRepuesto.UseVisualStyleBackColor = true;
            this.btnAgregarRepuesto.Click += new System.EventHandler(this.btnAgregarRepuesto_Click);
            // 
            // txtManoObra
            // 
            this.txtManoObra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManoObra.Location = new System.Drawing.Point(110, 9);
            this.txtManoObra.Name = "txtManoObra";
            this.txtManoObra.Size = new System.Drawing.Size(153, 23);
            this.txtManoObra.TabIndex = 1;
            this.txtManoObra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            this.txtManoObra.Validating += new System.ComponentModel.CancelEventHandler(this.txtManoObra_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mano de Obra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Repuesto/s:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(110, 61);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(153, 110);
            this.txtDesc.TabIndex = 3;
            this.txtDesc.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(37, 69);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 15);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 227);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 187);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 37);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.txtManoObra);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTiempo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 181);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.Controls.Add(this.cbxRepuesto);
            this.panel2.Controls.Add(this.btnAgregarRepuesto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnEliminarRepuesto);
            this.panel2.Controls.Add(this.lbxRepuestos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(279, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 181);
            this.panel2.TabIndex = 1;
            // 
            // cbxRepuesto
            // 
            this.cbxRepuesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxRepuesto.FormattingEnabled = true;
            this.cbxRepuesto.Location = new System.Drawing.Point(11, 36);
            this.cbxRepuesto.Name = "cbxRepuesto";
            this.cbxRepuesto.Size = new System.Drawing.Size(153, 21);
            this.cbxRepuesto.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel3.Controls.Add(this.btnGenerarDesperfecto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(279, 187);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 37);
            this.panel3.TabIndex = 2;
            // 
            // frmDesperfecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 227);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(60, 39);
            this.Name = "frmDesperfecto";
            this.Text = "Agregar nuevo desperfecto";
            this.Load += new System.EventHandler(this.frmDesperfecto_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarRepuesto;
        private System.Windows.Forms.ListBox lbxRepuestos;
        private System.Windows.Forms.Button btnGenerarDesperfecto;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarRepuesto;
        private System.Windows.Forms.TextBox txtManoObra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxRepuesto;
    }
}