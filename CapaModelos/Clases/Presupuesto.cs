using CapaPersistencia.Sql_server;
using System.Data;

namespace CapaModelos.Clases
{
    public class Presupuesto
    {
        #region Variables
        private int mId;
        private int mIdVehiculo;
        private decimal mTotal;

        private BaseDatos objDataBase = null;
        private string _MensajeError, _ValorScalar;
        private DataTable _dtResultados;
        #endregion

        #region Propiedades
        public int Id { get => mId; set => mId = value; }
        public int IdVehiculo { get => mIdVehiculo; set => mIdVehiculo = value; }
        public decimal Total { get => mTotal; set => mTotal = value; }
        public BaseDatos ObjDataBase { get => objDataBase; set => objDataBase = value; }
        public string MensajeError { get => _MensajeError; set => _MensajeError = value; }
        public string ValorScalar { get => _ValorScalar; set => _ValorScalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion

        #region Constructor
            public Presupuesto()
            {
                mId = 0;
                mIdVehiculo = 0;
                mTotal = 0;
            }
        #endregion
    }
}
