using CapaLogica.Modulos;
using CapaModelos.Clases;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class frmDesperfecto : Form
    {
        public frmDesperfecto()
        {
            InitializeComponent();
        }

        #region Variables
        private Desperfecto objDesp = null;
        private DataTable dtRepuestos;
        private DataTable dtRepuestosSeleccionados;
        private frmEntradaVehiculo mParent;
        #endregion

        #region Propiedades
        public frmEntradaVehiculo Parent { get => mParent; set => mParent = value; }
        #endregion

        #region Load
        private void frmDesperfecto_Load(object sender, EventArgs e)
        {
            CargarCombo();
            BlanquearCampos();
        }
        private void CargarCombo()
        {
            dtRepuestos = new DataTable();
            dtRepuestos.Columns.Add("Id", typeof(int));
            dtRepuestos.Columns.Add("Nombre", typeof(string));
            dtRepuestos.Columns.Add("Precio", typeof(decimal));
            dtRepuestos.Merge(Desperfectos.GetDtRepuestos(), false, MissingSchemaAction.Ignore);

            cbxRepuesto.DataSource = dtRepuestos;
            cbxRepuesto.DisplayMember = "Nombre";
            cbxRepuesto.ValueMember = "Id";

            dtRepuestosSeleccionados = new DataTable();
            dtRepuestosSeleccionados.Columns.Add("Id", typeof(int));
            dtRepuestosSeleccionados.Columns.Add("Nombre", typeof(string));
            dtRepuestosSeleccionados.Columns.Add("Precio", typeof(decimal));

            lbxRepuestos.DataSource = dtRepuestosSeleccionados;
            lbxRepuestos.DisplayMember = "Nombre";
            lbxRepuestos.ValueMember = "Id";
        }
        private void BlanquearCampos()
        {
            cbxRepuesto.SelectedIndex = -1;
            txtManoObra.Text = string.Empty;
            txtTiempo.Text = string.Empty;
            txtTiempo.Text = string.Empty;
        }
        #endregion

        #region Validaciones
        private bool ValidarCampos(ref Desperfecto obj)
        {
            if (lbxRepuestos.Items.Count == 0)
            {
                cbxRepuesto.Focus();
                MessageBox.Show("Debe ingresar uno o más Repuestos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            txtManoObra.Text = txtManoObra.Text.Trim();
            if (string.IsNullOrEmpty(txtManoObra.Text))
            {
                txtManoObra.Focus();
                MessageBox.Show("Debe ingresar el valor de la mano de obra.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            txtTiempo.Text = txtTiempo.Text.Trim();
            if (string.IsNullOrEmpty(txtTiempo.Text))
            {
                txtTiempo.Focus();
                MessageBox.Show("Debe ingresar un tiempo estimado en días.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            txtDesc.Text = txtDesc.Text.Trim();
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                txtDesc.Focus();
                MessageBox.Show("Debe ingresar una descripción del desperfecto del vehiculo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            CargarRepuestos(obj);
            obj.ManoObra = Convert.ToDecimal(txtManoObra.Text);
            obj.Tiempo = Convert.ToInt32(txtTiempo.Text);
            obj.Descripcion = txtDesc.Text;
            return true;
        }
        #endregion

        #region Funciones
        private void CargarRepuestos(Desperfecto obj)
        {
            Repuesto rep;
            foreach (DataRow row in dtRepuestosSeleccionados.Rows)
            {
                rep = new Repuesto();
                rep.Id = row.Field<int>("Id");
                rep.Nombre = row.Field<string>("Nombre");
                rep.Precio = row.Field<decimal>("Precio");
                obj.Repuestos.Add(rep);
            }
        }
        #endregion

        #region Eventos
        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            if (cbxRepuesto.SelectedIndex == -1) return;
            DataRow row = dtRepuestosSeleccionados.NewRow();
            row["Id"] = (cbxRepuesto.SelectedItem as DataRowView).Row["Id"];
            row["Nombre"] = (cbxRepuesto.SelectedItem as DataRowView).Row["Nombre"];
            row["Precio"] = (cbxRepuesto.SelectedItem as DataRowView).Row["Precio"];
            dtRepuestosSeleccionados.Rows.Add(row);
        }
        private void btnEliminarRepuesto_Click(object sender, EventArgs e)
        {
            int indice = lbxRepuestos.SelectedIndex;
            if (indice != -1)
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar el repuesto?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dtRepuestosSeleccionados.Rows.Remove(dtRepuestosSeleccionados.Rows[indice]);
                    dtRepuestosSeleccionados.AcceptChanges();
                }
            }
        }
        private void btnGenerarDesperfecto_Click(object sender, EventArgs e)
        {
            try
            {
                objDesp = new Desperfecto();
                if (!ValidarCampos(ref objDesp)) return;

                if (mParent != null)
                {
                    mParent.CallBack(ref objDesp);
                }
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al guardar los datos del desperfecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if ((sender as TextBox).Name == "txtManoObra")
                {
                    if ((",0123456789").IndexOf(e.KeyChar) < 0)
                        e.Handled = true;
                }
                else
                {
                    if (("0123456789").IndexOf(e.KeyChar) < 0)
                        e.Handled = true;
                }
            }
        }
        private void txtManoObra_Validating(object sender, CancelEventArgs e)
        {
            txtManoObra.Text = txtManoObra.Text.Trim();
            if (string.IsNullOrEmpty(txtManoObra.Text)) return;

            txtManoObra.Text = string.Format("{0:#0.000000}", Convert.ToDecimal(txtManoObra.Text));
        }

        #endregion
    }
}
