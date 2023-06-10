using CapaPersistencia.Sql_server;
using System.Collections.Generic;
using System.Data;

namespace CapaModelos.Clases
{
    public class Desperfecto
    {
        #region Variables
        private int mId;
        private int mIdPresupuesto;
        private string mDescripcion;
        private List<Repuesto> mRepuestos;
        private decimal mManoObra;
        private int mTiempo;
        //atributos de manejo de la base de datos
        private BaseDatos objDataBase = null;
        private string _MensajeError, _ValorScalar;
        private DataTable _dtResultados;
        #endregion

        #region Propiedades
        public int Id { get => mId; set => mId = value; }
        public int IdPresupuesto { get => mIdPresupuesto; set => mIdPresupuesto = value; }
        public string Descripcion { get => mDescripcion; set => mDescripcion = value; }
        public decimal ManoObra { get => mManoObra; set => mManoObra = value; }
        public int Tiempo { get => mTiempo; set => mTiempo = value; }
        public string MensajeError { get => _MensajeError; set => _MensajeError = value; }
        public string ValorScalar { get => _ValorScalar; set => _ValorScalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        public List<Repuesto> Repuestos { get => mRepuestos; set => mRepuestos = value; }
        #endregion

        #region Constructor
        public Desperfecto()
        {
            mId = 0;
            mIdPresupuesto = 0;
            mDescripcion = "";
            mManoObra = 0;
            mTiempo = 0;
            mRepuestos = new List<Repuesto>();
        }
        #endregion

    }
}
