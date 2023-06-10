using CapaPersistencia.Sql_server;
using System.Data;

namespace CapaModelos.Clases
{
    public abstract class Vehiculo
    {
        #region Variables
        private int mId;
        private int mIdCliente;
        private string mMarca;
        private string mModelo;
        private string mPatente;

        private BaseDatos objDataBase = null;
        private string _MensajeError, _ValorScalar;
        private DataTable _dtResultados;
        #endregion

        #region Propiedades
        public int Id { get => mId; set => mId = value; }
        public int IdCliente { get => mIdCliente; set => mIdCliente = value; }
        public string Marca { get => mMarca; set => mMarca = value; }
        public string Modelo { get => mModelo; set => mModelo = value; }
        public string Patente { get => mPatente; set => mPatente = value; }
        public string MensajeError { get => _MensajeError; set => _MensajeError = value; }
        public string ValorScalar { get => _ValorScalar; set => _ValorScalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion

    }
}
