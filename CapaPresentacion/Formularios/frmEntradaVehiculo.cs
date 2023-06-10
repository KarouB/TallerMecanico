using CapaLogica.Modulos;
using CapaModelos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class frmEntradaVehiculo : Form
    {
        public frmEntradaVehiculo()
        {
            InitializeComponent();
        }

        #region Variables
        public int mIdCliente;
        public int mIdVehiculo;
        private DataTable mDt;

        private Cliente mCliente;
        private Presupuesto mPresupuesto;
        private Auto mAuto;
        private Moto mMoto;
        private List<Desperfecto> mDesperfectos;
        #endregion

        #region Load
        private void frmEntradaVehiculo_Load(object sender, EventArgs e)
        {
            ConfiguraDt();
            ConfiguraGrilla();
            BlanquearCampos();
        }
        private void ConfiguraGrilla()
        {
            DataGridViewColumn col = gvDesperfectos.Columns[0];
            col.Resizable = DataGridViewTriState.True;
            col.HeaderText = "Descripción";

            col = gvDesperfectos.Columns[1];
            col.HeaderText = "Cantidad de repuestos";

            col = gvDesperfectos.Columns[2];
            col.HeaderText = "Tiempo estimado (Días)";

            col = gvDesperfectos.Columns[3];
            col.Visible = false;
        }
        private void ConfiguraDt()
        {
            mDt = new DataTable();

            DataColumn col;

            col = new DataColumn("Descripcion", typeof(string));
            mDt.Columns.Add(col);

            col = new DataColumn("Cant_Repuestos", typeof(int));
            mDt.Columns.Add(col);

            col = new DataColumn("Tiempo", typeof(int));
            mDt.Columns.Add(col);

            col = new DataColumn("ManoObra", typeof(decimal));
            mDt.Columns.Add(col);

            col = new DataColumn("Repuestos", typeof(List<Repuesto>));
            mDt.Columns.Add(col);

            gvDesperfectos.DataSource = mDt;
        }
        private void BlanquearCampos()
        {
            mIdCliente = 0;
            mIdVehiculo = 0;
            cbxVehiculo.SelectedIndex = 0;
            //cliente
            txtDocumento.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            chkModificarCliente.Enabled = false;
            //Vehiculo
            txtModelo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPatente.Text = string.Empty;
            txtCilindrada.Text = string.Empty;
            txtCantPuertas.Text = string.Empty;
            cbxTipoAuto.Text = string.Empty;
            chkModificarVehiculo.Enabled = false;

            mDt.Clear();
        }

        #endregion

        #region Eventos
        private void txtDocumento_Validating(object sender, CancelEventArgs e)
        {
            txtDocumento.Text = txtDocumento.Text.Trim();
            if (string.IsNullOrEmpty(txtDocumento.Text)) return;

            mCliente = new Cliente();
            mCliente.Documento = txtDocumento.Text;
            Clientes.Read(ref mCliente);
            if (mCliente.Id != 0)
            {
                txtNombre.Text = mCliente.Nombre;
                txtApellido.Text = mCliente.Apellido;
                txtCorreo.Text = mCliente.Mail;
                mIdCliente = mCliente.Id;
                chkModificarCliente.Enabled = true;
                chkModificarVehiculo.Enabled = true;
                CargarVehiculo(mIdCliente);
            }
            else
            {
                mIdCliente = 0;
            }

        }
        private void cbxVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCilindrada.Visible = cbxVehiculo.SelectedIndex == 1;
            lblCilindrada.Visible = cbxVehiculo.SelectedIndex == 1;

            cbxTipoAuto.Visible = cbxVehiculo.SelectedIndex == 0;
            lblTipoAuto.Visible = cbxVehiculo.SelectedIndex == 0;

            txtCantPuertas.Visible = cbxVehiculo.SelectedIndex == 0;
            lblCantPuertas.Visible = cbxVehiculo.SelectedIndex == 0;
        }
        private void btnDesperfecto_Click(object sender, EventArgs e)
        {
            frmDesperfecto desperfectos = new frmDesperfecto();
            desperfectos.Parent = this;
            desperfectos.ShowDialog();
        }
        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            if (mDt.Rows.Count == 0)
            {
                MessageBox.Show("Debe cargar algún desperfecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (mIdCliente == 0 || chkModificarCliente.Checked)
            {
                mCliente = new Cliente();
                if (!ValidarCamposCliente(ref mCliente)) return;

                if (mIdCliente != 0)
                {
                    Clientes.UpdateCliente(ref mCliente);
                }
                else
                {
                    Clientes.Save(ref mCliente);
                }
                mIdCliente = mCliente.Id;
            }

            if (mIdVehiculo == 0)
            {
                mAuto = new Auto();
                mMoto = new Moto();

                if (!ValidarCamposVehiculo(ref mAuto, ref mMoto)) return;

                if (cbxVehiculo.SelectedIndex == 0 || chkModificarVehiculo.Checked)
                {
                    if (mIdVehiculo != 0)
                    {
                        Autos.UpdateAuto(ref mAuto);
                    }
                    else
                    {
                         Autos.SaveAuto(ref mAuto);                       
                    }

                    mIdVehiculo = mAuto.IdVehiculo;
                }
                else
                {
                    if (mIdVehiculo != 0)
                    {
                        Motos.UpdateMoto(ref mMoto);
                    }
                    else
                    {
                        Motos.SaveMoto(ref mMoto);                       
                    }

                    mIdVehiculo = mMoto.IdVehiculo;
                }

            }

            mPresupuesto = new Presupuesto();

            mPresupuesto.IdVehiculo = mIdVehiculo;
            mPresupuesto.Total = ObtenerTotal();
            mPresupuesto.IdVehiculo = mIdVehiculo;
            Presupuestos.Save(ref mPresupuesto);

            GuardarDesperfectos(mPresupuesto.Id);

            frmPresupuesto frmPres = new frmPresupuesto
            {
                Presupuesto = mPresupuesto,
                Cliente = mCliente,
                Auto = mAuto,
                Moto = mMoto,
                Desperfectos = mDesperfectos
            };

            frmPres.ShowDialog();
            BlanquearCampos();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gvDesperfectos.CurrentCell == null) return;
            if (MessageBox.Show("¿Está seguro que desea eliminar el desperfecto de la lista?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            mDt.Rows.Remove(mDt.Rows[gvDesperfectos.CurrentCell.RowIndex]);
            mDt.AcceptChanges();
        }
        private void txtCantPuertas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (("0123456789").IndexOf(e.KeyChar) < 0)
                    e.Handled = true;
            }
        }
        #endregion

        #region Validaciones
        private bool ValidarCamposCliente(ref Cliente obj)
        {           
            if (string.IsNullOrEmpty(txtDocumento.Text.Trim()))
            {
                txtDocumento.Focus();
                MessageBox.Show("Debe ingresar un Documento.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                txtNombre.Focus();
                MessageBox.Show("Debe ingresar un Nombre.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(txtCorreo.Text.Trim()))
            {
                txtCorreo.Focus();
                MessageBox.Show("Debe ingresar un Mail.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            obj.Documento = txtDocumento.Text;
            obj.Nombre = txtNombre.Text;
            obj.Apellido = txtApellido.Text;
            obj.Mail = txtCorreo.Text;
            obj.Id = mIdCliente;

            return true;
        }
        private bool ValidarCamposVehiculo(ref Auto objAuto, ref Moto objMoto)
        {
            dynamic obj;
            if (cbxVehiculo.SelectedIndex == 0)
                obj = new Auto();
            else
                obj = new Moto();

            if (string.IsNullOrEmpty(txtModelo.Text.Trim()))
            {
                txtModelo.Focus();
                MessageBox.Show("Debe ingresar un Modelo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtMarca.Text.Trim()))
            {
                txtMarca.Focus();
                MessageBox.Show("Debe ingresar una Marca.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtPatente.Text.Trim()))
            {
                txtPatente.Focus();
                MessageBox.Show("Debe ingresar una Patente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            obj.Modelo = txtModelo.Text.Trim();
            obj.Marca = txtMarca.Text.Trim();
            obj.Patente = txtPatente.Text.Trim();

            if (cbxVehiculo.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtCantPuertas.Text.Trim()))
                {
                    txtCantPuertas.Focus();
                    MessageBox.Show("Debe ingresar Cantidad de puertas.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtCilindrada.Text.Trim()))
                {
                    txtCilindrada.Focus();
                    MessageBox.Show("Debe ingresar  Cilindrada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

            }
            obj.IdCliente = mIdCliente;
            if (cbxVehiculo.SelectedIndex == 0)
            {
                objAuto = obj;
                objAuto.CantidadPuertas = Convert.ToInt32(txtCantPuertas.Text.Trim());
                objAuto.Tipo = (Auto.TipoAuto)cbxTipoAuto.SelectedIndex;
            }
            else
            {
                objMoto = obj;
                objMoto.Cilindrada = txtCilindrada.Text.Trim();
            }


            return true;
        }
        #endregion

        #region CallBack
        public void CallBack(ref Desperfecto objDesp)
        {
            DataRow row = mDt.NewRow();

            row["Descripcion"] = objDesp.Descripcion;
            row["Cant_Repuestos"] = objDesp.Repuestos.Count;
            row["Tiempo"] = objDesp.Tiempo;
            row["Repuestos"] = objDesp.Repuestos;
            row["ManoObra"] = objDesp.ManoObra;
            mDt.Rows.Add(row);
        }
        #endregion

        #region Funciones
        private void CargarVehiculo(int idCliente)
        {
            mAuto = new Auto();
            mMoto = new Moto();
            mAuto.IdCliente = idCliente;
            Vehiculos.BuscarVehiculoxCliente(ref mAuto, ref mMoto);
            if (mAuto.IdAuto != 0)
            {
                cbxVehiculo.SelectedIndex = 0;
                txtPatente.Text = mAuto.Patente;
                txtModelo.Text = mAuto.Modelo;
                txtMarca.Text = mAuto.Marca;
                txtCantPuertas.Text = mAuto.CantidadPuertas.ToString();
                cbxTipoAuto.SelectedIndex = Convert.ToInt32(mAuto.Tipo);
                mIdVehiculo = mAuto.IdVehiculo;
            }
            else if (mMoto.IdMoto != 0)
            {
                cbxVehiculo.SelectedIndex = 1;
                txtPatente.Text = mMoto.Patente;
                txtModelo.Text = mMoto.Modelo;
                txtMarca.Text = mMoto.Marca;
                txtCilindrada.Text = mMoto.Cilindrada;
                mIdVehiculo = mMoto.IdVehiculo;
            }
            else
            {
                mIdVehiculo = 0;
            }
        }
        private void GuardarDesperfectos(int IdPre)
        {
            Desperfecto desp;
            mDesperfectos = new List<Desperfecto>();

            foreach (DataRow row in mDt.Rows)
            {
                desp = new Desperfecto();
                desp.Descripcion = row.Field<string>("descripcion");
                desp.ManoObra = row.Field<decimal>("ManoObra");
                desp.Tiempo = row.Field<int>("Tiempo");
                desp.IdPresupuesto = IdPre;
                desp.Repuestos = row.Field<List<Repuesto>>("Repuestos");
                Desperfectos.Save(ref desp);

                foreach (Repuesto rep in row.Field<List<Repuesto>>("Repuestos"))
                {
                    Desperfectos.GuardarRelacionRepuestos(desp.Id, rep.Id);
                }

                mDesperfectos.Add(desp);
            }
        }
        private decimal ObtenerTotal()
        {
            decimal total = 0;

            foreach (DataRow row in mDt.Rows)
            {
                foreach (Repuesto rep in row.Field<List<Repuesto>>("Repuestos"))
                {
                    total += rep.Precio;
                }

                total += row.Field<decimal>("ManoObra");
                total += (row.Field<int>("Tiempo") * 130);
            }

            total = total * 1.10M;

            return total;
        }
        #endregion

    }
}
