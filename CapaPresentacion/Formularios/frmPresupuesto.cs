using CapaModelos.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class frmPresupuesto : Form
    {
        public frmPresupuesto()
        {
            InitializeComponent();
        }
        
        #region Variables
        private Cliente mCliente;
        private Presupuesto mPresupuesto;
        private Auto mAuto;
        private Moto mMoto;
        private List<Desperfecto> mDesperfectos;
        private DataTable mDt;
        #endregion

        #region Propiedades
        public Cliente Cliente { get => mCliente; set => mCliente = value; }
        public Presupuesto Presupuesto { get => mPresupuesto; set => mPresupuesto = value; }
        public Auto Auto { get => mAuto; set => mAuto = value; }
        public Moto Moto { get => mMoto; set => mMoto = value; }
        public List<Desperfecto> Desperfectos { get => mDesperfectos; set => mDesperfectos = value; }
        #endregion

        #region Load
        private void frmPresupuesto_Load(object sender, EventArgs e)
        {
            ConfiguraDt();
            ConfiguraGrilla();
            CargarDatos();
        }
        private void ConfiguraDt()
        {
            mDt = new DataTable();

            DataColumn col;

            col = new DataColumn("Descripcion", typeof(string));
            mDt.Columns.Add(col);

            col = new DataColumn("Cantidad", typeof(int));
            mDt.Columns.Add(col);

            col = new DataColumn("PrecioU", typeof(decimal));
            mDt.Columns.Add(col);

            col = new DataColumn("Precio", typeof(decimal));
            mDt.Columns.Add(col);

            gvPresupuesto.DataSource = mDt;
        }
        private void ConfiguraGrilla()
        {
            DataGridViewColumn col = gvPresupuesto.Columns[0];
            col.Width = 250;
            col.HeaderText = "Descripción";

            col = gvPresupuesto.Columns[1];
            col.HeaderText = "Cantidad";

            col = gvPresupuesto.Columns[2];
            col.HeaderText = "Precio Unitario";

            col = gvPresupuesto.Columns[3];
            col.HeaderText = "Precio";
        }
        private void CargarDatos()
        {
            if (mCliente == null) return;
            if (mCliente.Id == 0) return;

            lblDocumento.Text = mCliente.Documento.Trim();
            lblNombre.Text = mCliente.Nombre.Trim();
            lblApellido.Text = mCliente.Apellido.Trim();
            lblCorreo.Text = mCliente.Mail.Trim();

            if (mAuto.IdAuto != 0)
            {
                lblPatente.Text = mAuto.Patente;
                lblModelo.Text = mAuto.Modelo;
                lblMarca.Text = mAuto.Marca;
                lblTipo.Text = mAuto.Tipo.ToString();
                lblPuertas.Text = mAuto.CantidadPuertas.ToString();
                lblCilindrada.Visible = false;
                lblDCilindrada.Visible = false;
            }
            else if (mMoto.IdMoto != 0)
            {

                lblPatente.Text = mMoto.Patente;
                lblModelo.Text = mMoto.Modelo;
                lblMarca.Text = mMoto.Marca;
                lblCilindrada.Text = mMoto.Cilindrada;

                lblTipo.Visible = false;
                lblDTipo.Visible = false;
                lblPuertas.Visible = false;
                lblDPuertas.Visible = false;
            }
            else
            {
                return;
            }

            CargarGrilla();

            if (mPresupuesto.Id == 0) return;
            lblTotal.Text = mPresupuesto.Total.ToString();

        }
        private void CargarGrilla()
        {
            decimal ManoObra = 0, SubTotal = 0;
            int Tiempo = 0;

            DataTable diRepuestos = new DataTable();
            diRepuestos.Columns.Add("Id", typeof(int));

            diRepuestos.PrimaryKey = new DataColumn[]
            {
                diRepuestos.Columns[0]
            };

            diRepuestos.Columns.Add("Nombre", typeof(string));
            diRepuestos.Columns.Add("Precio", typeof(decimal));
            diRepuestos.Columns.Add("Cantidad", typeof(int));

            DataRow row, xRow;
            foreach (Desperfecto desp in mDesperfectos)
            {
                ManoObra += desp.ManoObra;
                Tiempo += desp.Tiempo;
                foreach (Repuesto rep in desp.Repuestos)
                {
                    xRow = diRepuestos.Rows.Find(rep.Id);
                    if (xRow != null)
                    {
                        xRow["Cantidad"] = xRow.Field<int>("Cantidad") + 1;
                    }
                    else
                    {
                        xRow = diRepuestos.NewRow();
                        xRow["Id"] = rep.Id;
                        xRow["Nombre"] = rep.Nombre;
                        xRow["Precio"] = rep.Precio;
                        xRow["Cantidad"] = 1;
                        diRepuestos.Rows.Add(xRow);
                    }
                }
            }

            foreach (DataRow dRow in diRepuestos.Rows)
            {
                row = mDt.NewRow();
                row["Descripcion"] = dRow["Nombre"];
                row["Cantidad"] = dRow["Cantidad"];
                row["PrecioU"] = dRow["Precio"];
                row["Precio"] = dRow.Field<int>("Cantidad") * dRow.Field<decimal>("Precio");
                SubTotal += row.Field<decimal>("Precio");
                mDt.Rows.Add(row);
            }

            row = mDt.NewRow();
            row["Descripcion"] = "Mano de obra";
            row["Cantidad"] = 1;
            row["PrecioU"] = ManoObra;
            row["Precio"] = ManoObra;
            SubTotal += row.Field<decimal>("Precio");
            mDt.Rows.Add(row);

            row = mDt.NewRow();
            row["Descripcion"] = "Tiempo estimado (Días)";
            row["Cantidad"] = Tiempo;
            row["PrecioU"] = 130;
            row["Precio"] = Tiempo * 130;
            SubTotal += row.Field<decimal>("Precio");
            mDt.Rows.Add(row);

            row = mDt.NewRow();
            row["Descripcion"] = "SubTotal";
            row["Precio"] = SubTotal;
            mDt.Rows.Add(row);

            row = mDt.NewRow();
            row["Descripcion"] = "Beneficio taller";
            row["Precio"] = SubTotal * 0.10M;
            mDt.Rows.Add(row);
        }
        #endregion

    }
}
