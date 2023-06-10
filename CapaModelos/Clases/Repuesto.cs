using CapaPersistencia.Sql_server;
using System.Data;

namespace CapaModelos.Clases
{
    public class Repuesto
    {
        #region Variables
        private int mId;
        private string mNombre;
        private decimal mPrecio;

        private BaseDatos objDataBase = null;
        private string _MensajeError, _ValorScalar;
        private DataTable _dtResultados;
        #endregion

        #region Propiedades
        public int Id { get => mId; set => mId = value; }
        public string Nombre { get => mNombre; set => mNombre = value; }
        public decimal Precio { get => mPrecio; set => mPrecio = value; }
        public BaseDatos ObjDataBase { get => objDataBase; set => objDataBase = value; }
        public string MensajeError { get => _MensajeError; set => _MensajeError = value; }
        public string ValorScalar { get => _ValorScalar; set => _ValorScalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
