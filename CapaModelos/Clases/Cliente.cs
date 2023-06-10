using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistencia.Sql_server;

namespace CapaModelos.Clases
{
    public class Cliente
    {
        #region Variables
        private int mId;
        private string mNombre;
        private string mDocumento;
        private string mApellido;
        private string mMail;
        //atributos de manejo de la base de datos
        private BaseDatos objDataBase = null;
        private string _MensajeError, _ValorScalar;
        private DataTable _dtResultados;
        #endregion

        #region Propiedades
        public int Id { get => mId; set => mId = value; }
        public string Nombre { get => mNombre; set => mNombre = value; }
        public string Documento { get => mDocumento; set => mDocumento = value; }
        public string Apellido { get => mApellido; set => mApellido = value; }
        public string Mail { get => mMail; set => mMail = value; }
        public string MensajeError { get => _MensajeError; set => _MensajeError = value; }
        public string ValorScalar { get => _ValorScalar; set => _ValorScalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion

        #region Constructor
        public Cliente()
        {
            Reset();
        }
        #endregion

        #region Funciones
        public void Reset()
        {
            mId = 0;
            mNombre = string.Empty;
            mApellido = string.Empty;
            mMail = string.Empty;
        }
        #endregion

    }
}
