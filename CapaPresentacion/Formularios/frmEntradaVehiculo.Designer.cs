
namespace CapaPresentacion.Formularios
{
    partial class frmEntradaVehiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradaVehiculo));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbVehiculo = new System.Windows.Forms.GroupBox();
            this.lblCantPuertas = new System.Windows.Forms.Label();
            this.txtCantPuertas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.cbxVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTipoAuto = new System.Windows.Forms.Label();
            this.cbxTipoAuto = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.gbDftos = new System.Windows.Forms.GroupBox();
            this.gvDesperfectos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.ilIconos = new System.Windows.Forms.ImageList(this.components);
            this.btnAgregarDesp = new System.Windows.Forms.Button();
            this.chkModificarVehiculo = new System.Windows.Forms.CheckBox();
            this.chkModificarCliente = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbVehiculo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDftos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDesperfectos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbVehiculo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.gbDftos, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 451);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.gbCliente.Controls.Add(this.chkModificarCliente);
            this.gbCliente.Controls.Add(this.label8);
            this.gbCliente.Controls.Add(this.txtDocumento);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.txtCorreo);
            this.gbCliente.Controls.Add(this.txtApellido);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbCliente.Location = new System.Drawing.Point(3, 3);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gbCliente.Size = new System.Drawing.Size(459, 84);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label8.Location = new System.Drawing.Point(9, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Documento:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtDocumento.Location = new System.Drawing.Point(85, 24);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(128, 22);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.txtDocumento_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(244, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(236, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtCorreo.Location = new System.Drawing.Point(295, 24);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(128, 22);
            this.txtCorreo.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtApellido.Location = new System.Drawing.Point(295, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(128, 22);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtNombre.Location = new System.Drawing.Point(85, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // gbVehiculo
            // 
            this.gbVehiculo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.gbVehiculo.Controls.Add(this.chkModificarVehiculo);
            this.gbVehiculo.Controls.Add(this.lblCantPuertas);
            this.gbVehiculo.Controls.Add(this.txtCantPuertas);
            this.gbVehiculo.Controls.Add(this.label7);
            this.gbVehiculo.Controls.Add(this.txtPatente);
            this.gbVehiculo.Controls.Add(this.label6);
            this.gbVehiculo.Controls.Add(this.txtMarca);
            this.gbVehiculo.Controls.Add(this.lblCilindrada);
            this.gbVehiculo.Controls.Add(this.txtCilindrada);
            this.gbVehiculo.Controls.Add(this.label5);
            this.gbVehiculo.Controls.Add(this.txtModelo);
            this.gbVehiculo.Controls.Add(this.lblVehiculo);
            this.gbVehiculo.Controls.Add(this.cbxVehiculo);
            this.gbVehiculo.Controls.Add(this.lblTipoAuto);
            this.gbVehiculo.Controls.Add(this.cbxTipoAuto);
            this.gbVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVehiculo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbVehiculo.Location = new System.Drawing.Point(3, 90);
            this.gbVehiculo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gbVehiculo.Name = "gbVehiculo";
            this.gbVehiculo.Size = new System.Drawing.Size(459, 107);
            this.gbVehiculo.TabIndex = 1;
            this.gbVehiculo.TabStop = false;
            this.gbVehiculo.Text = "Datos del Vehículo";
            // 
            // lblCantPuertas
            // 
            this.lblCantPuertas.AutoSize = true;
            this.lblCantPuertas.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCantPuertas.Location = new System.Drawing.Point(191, 81);
            this.lblCantPuertas.Name = "lblCantPuertas";
            this.lblCantPuertas.Size = new System.Drawing.Size(98, 13);
            this.lblCantPuertas.TabIndex = 31;
            this.lblCantPuertas.Text = "Cantidad Puertas:";
            // 
            // txtCantPuertas
            // 
            this.txtCantPuertas.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtCantPuertas.Location = new System.Drawing.Point(295, 77);
            this.txtCantPuertas.Name = "txtCantPuertas";
            this.txtCantPuertas.Size = new System.Drawing.Size(100, 22);
            this.txtCantPuertas.TabIndex = 10;
            this.txtCantPuertas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantPuertas_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label7.Location = new System.Drawing.Point(240, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Patente:";
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtPatente.Location = new System.Drawing.Point(295, 24);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 22);
            this.txtPatente.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(38, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtMarca.Location = new System.Drawing.Point(85, 77);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 22);
            this.txtMarca.TabIndex = 9;
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCilindrada.Location = new System.Drawing.Point(226, 55);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(63, 13);
            this.lblCilindrada.TabIndex = 22;
            this.lblCilindrada.Text = "Cilindrada:";
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtCilindrada.Location = new System.Drawing.Point(295, 51);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(100, 22);
            this.txtCilindrada.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(29, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtModelo.Location = new System.Drawing.Point(85, 51);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 22);
            this.txtModelo.TabIndex = 7;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblVehiculo.Location = new System.Drawing.Point(25, 28);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(54, 13);
            this.lblVehiculo.TabIndex = 17;
            this.lblVehiculo.Text = "Vehiculo:";
            // 
            // cbxVehiculo
            // 
            this.cbxVehiculo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbxVehiculo.FormattingEnabled = true;
            this.cbxVehiculo.Items.AddRange(new object[] {
            "Auto",
            "Moto"});
            this.cbxVehiculo.Location = new System.Drawing.Point(85, 24);
            this.cbxVehiculo.Name = "cbxVehiculo";
            this.cbxVehiculo.Size = new System.Drawing.Size(99, 21);
            this.cbxVehiculo.TabIndex = 5;
            this.cbxVehiculo.SelectedIndexChanged += new System.EventHandler(this.cbxVehiculo_SelectedIndexChanged);
            // 
            // lblTipoAuto
            // 
            this.lblTipoAuto.AutoSize = true;
            this.lblTipoAuto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTipoAuto.Location = new System.Drawing.Point(256, 55);
            this.lblTipoAuto.Name = "lblTipoAuto";
            this.lblTipoAuto.Size = new System.Drawing.Size(33, 13);
            this.lblTipoAuto.TabIndex = 20;
            this.lblTipoAuto.Text = "Tipo:";
            this.lblTipoAuto.Visible = false;
            // 
            // cbxTipoAuto
            // 
            this.cbxTipoAuto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbxTipoAuto.FormattingEnabled = true;
            this.cbxTipoAuto.Items.AddRange(new object[] {
            "Compacto",
            "Sedan",
            "Monovolumen",
            "Utilitario",
            "Lujo"});
            this.cbxTipoAuto.Location = new System.Drawing.Point(295, 51);
            this.cbxTipoAuto.Name = "cbxTipoAuto";
            this.cbxTipoAuto.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoAuto.TabIndex = 19;
            this.cbxTipoAuto.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.btnPresupuesto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 411);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 37);
            this.panel1.TabIndex = 2;
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnPresupuesto.Location = new System.Drawing.Point(316, 7);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(134, 23);
            this.btnPresupuesto.TabIndex = 14;
            this.btnPresupuesto.Text = "Generar Presupuesto";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // gbDftos
            // 
            this.gbDftos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.gbDftos.Controls.Add(this.gvDesperfectos);
            this.gbDftos.Controls.Add(this.panel2);
            this.gbDftos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDftos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDftos.Location = new System.Drawing.Point(3, 200);
            this.gbDftos.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gbDftos.Name = "gbDftos";
            this.gbDftos.Size = new System.Drawing.Size(459, 208);
            this.gbDftos.TabIndex = 3;
            this.gbDftos.TabStop = false;
            this.gbDftos.Text = "Desperfectos";
            // 
            // gvDesperfectos
            // 
            this.gvDesperfectos.AllowUserToAddRows = false;
            this.gvDesperfectos.AllowUserToDeleteRows = false;
            this.gvDesperfectos.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDesperfectos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDesperfectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDesperfectos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvDesperfectos.BackgroundColor = System.Drawing.Color.Beige;
            this.gvDesperfectos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDesperfectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvDesperfectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDesperfectos.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvDesperfectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDesperfectos.Location = new System.Drawing.Point(3, 53);
            this.gvDesperfectos.Name = "gvDesperfectos";
            this.gvDesperfectos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDesperfectos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDesperfectos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvDesperfectos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDesperfectos.Size = new System.Drawing.Size(453, 152);
            this.gvDesperfectos.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnAgregarDesp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 32);
            this.panel2.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEliminar.ImageIndex = 1;
            this.btnEliminar.ImageList = this.ilIconos;
            this.btnEliminar.Location = new System.Drawing.Point(99, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ilIconos
            // 
            this.ilIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIconos.ImageStream")));
            this.ilIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIconos.Images.SetKeyName(0, "agregar.png");
            this.ilIconos.Images.SetKeyName(1, "eliminar.png");
            // 
            // btnAgregarDesp
            // 
            this.btnAgregarDesp.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAgregarDesp.ImageIndex = 0;
            this.btnAgregarDesp.ImageList = this.ilIconos;
            this.btnAgregarDesp.Location = new System.Drawing.Point(9, 3);
            this.btnAgregarDesp.Name = "btnAgregarDesp";
            this.btnAgregarDesp.Size = new System.Drawing.Size(84, 23);
            this.btnAgregarDesp.TabIndex = 11;
            this.btnAgregarDesp.Text = "Añadir ";
            this.btnAgregarDesp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDesp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarDesp.UseVisualStyleBackColor = true;
            this.btnAgregarDesp.Click += new System.EventHandler(this.btnDesperfecto_Click);
            // 
            // chkModificarVehiculo
            // 
            this.chkModificarVehiculo.AutoSize = true;
            this.chkModificarVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificarVehiculo.Location = new System.Drawing.Point(295, 3);
            this.chkModificarVehiculo.Name = "chkModificarVehiculo";
            this.chkModificarVehiculo.Size = new System.Drawing.Size(107, 17);
            this.chkModificarVehiculo.TabIndex = 32;
            this.chkModificarVehiculo.Text = "Modificar datos";
            this.chkModificarVehiculo.UseVisualStyleBackColor = true;
            // 
            // chkModificarCliente
            // 
            this.chkModificarCliente.AutoSize = true;
            this.chkModificarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificarCliente.Location = new System.Drawing.Point(295, 1);
            this.chkModificarCliente.Name = "chkModificarCliente";
            this.chkModificarCliente.Size = new System.Drawing.Size(107, 17);
            this.chkModificarCliente.TabIndex = 33;
            this.chkModificarCliente.Text = "Modificar datos";
            this.chkModificarCliente.UseVisualStyleBackColor = true;
            // 
            // frmEntradaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(481, 490);
            this.Name = "frmEntradaVehiculo";
            this.Text = "Taller Mecanico";
            this.Load += new System.EventHandler(this.frmEntradaVehiculo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbVehiculo.ResumeLayout(false);
            this.gbVehiculo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbDftos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDesperfectos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbVehiculo;
        private System.Windows.Forms.Label lblCantPuertas;
        private System.Windows.Forms.TextBox txtCantPuertas;
        private System.Windows.Forms.Button btnAgregarDesp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblCilindrada;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.ComboBox cbxVehiculo;
        private System.Windows.Forms.Label lblTipoAuto;
        private System.Windows.Forms.ComboBox cbxTipoAuto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDftos;
        private System.Windows.Forms.DataGridView gvDesperfectos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList ilIconos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkModificarCliente;
        private System.Windows.Forms.CheckBox chkModificarVehiculo;
    }
}