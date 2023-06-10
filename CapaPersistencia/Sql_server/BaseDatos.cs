using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaPersistencia.Sql_server
{
    public class BaseDatos
    {
        #region VariablesPrivadas
        private SqlConnection _objSqlConnection;
        private SqlDataAdapter _objSqlDataAdapter;
        private SqlCommand _objSqlCommand;
        private DataSet _dsResultados;
        private DataTable _dtParametros;
        private string _NombreTable, _NombreSP, _MensajeErrorDB, _ValorScalar, _NombreDB;
        private bool _scalar;
        #endregion

        #region Propiedades
        public SqlConnection ObjSqlConnection { get => _objSqlConnection; set => _objSqlConnection = value; }
        public SqlDataAdapter ObjSqlDataAdapter { get => _objSqlDataAdapter; set => _objSqlDataAdapter = value; }
        public SqlCommand ObjSqlCommand { get => _objSqlCommand; set => _objSqlCommand = value; }
        public DataSet DsResultados { get => _dsResultados; set => _dsResultados = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string NombreTable { get => _NombreTable; set => _NombreTable = value; }
        public string NombreSP { get => _NombreSP; set => _NombreSP = value; }
        public string MensajeErrorDB { get => _MensajeErrorDB; set => _MensajeErrorDB = value; }
        public string ValorScalar { get => _ValorScalar; set => _ValorScalar = value; }
        public string NombreDB { get => _NombreDB; set => _NombreDB = value; }
        public bool Scalar { get => _scalar; set => _scalar = value; }
        #endregion

        #region Constructor
        public BaseDatos()
        {
            DtParametros = new DataTable("spParametros");
            DtParametros.Columns.Add("Nombre");
            DtParametros.Columns.Add("TipoDato", typeof(SqlDbType));
            DtParametros.Columns.Add("Valor");
            DtParametros.Columns.Add("Direccion", typeof(ParameterDirection));

            NombreDB = "TallerDb";
        }
        #endregion

        #region MetodosPrivados
        private void CrearConexionDB(ref BaseDatos objDatos)
        {
            switch (objDatos.NombreDB)
            {
                case "TallerDb":
                    objDatos.ObjSqlConnection = new SqlConnection(Properties.Settings.Default.cadenaConexion_TalleDb);
                    break;
                default:
                    break;
            }
        }
        private void ValidarConexionDB(ref BaseDatos objDatos)
        {

            if (objDatos.ObjSqlConnection.State == ConnectionState.Closed)
            {
                objDatos.ObjSqlConnection.Open();
            }
            else
            {
                objDatos.ObjSqlConnection.Close();
                objDatos.ObjSqlConnection.Dispose();
            }
        }
        private void AgregarParametros(ref BaseDatos objDatos)
        {
            if (objDatos.DtParametros != null)
            {
                SqlDbType TipoDatoSQL;
                ParameterDirection Direction;
                SqlParameter p;
                foreach (DataRow item in objDatos.DtParametros.Rows)
                {
                    TipoDatoSQL = (SqlDbType)item[1];

                    if (!item.IsNull(3)) Direction = (ParameterDirection)item[3];
                    else Direction = ParameterDirection.Input;

                    if (objDatos.Scalar)
                    {
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            p = objDatos.ObjSqlCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL);
                            p.Value = DBNull.Value;
                            p.Direction = Direction;

                        }
                        else
                        {
                            p = objDatos.ObjSqlCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL);
                            p.Value = item[2].ToString();
                            p.Direction = Direction;
                        }
                    }
                    else
                    {
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            p = objDatos.ObjSqlDataAdapter.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL);
                            p.Value = DBNull.Value;
                            p.Direction = Direction;
                        }
                        else
                        {
                            p = objDatos.ObjSqlDataAdapter.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL);
                            p.Value = item[2].ToString();
                            p.Direction = Direction;
                        }
                    }

                }
            }

        }
        private void PrepararConexionDB(ref BaseDatos objDatos)
        {
            CrearConexionDB(ref objDatos);
            ValidarConexionDB(ref objDatos);
        }
        private void EjecutarDA(ref BaseDatos objDatos)
        {
            try
            {
                PrepararConexionDB(ref objDatos);

                objDatos.ObjSqlDataAdapter = new SqlDataAdapter(objDatos.NombreSP, ObjSqlConnection);
                objDatos.ObjSqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                AgregarParametros(ref objDatos);
                objDatos.DsResultados = new DataSet();
                objDatos.ObjSqlDataAdapter.Fill(objDatos.DsResultados, objDatos.NombreTable);
            }
            catch (Exception ex)
            {
                objDatos.MensajeErrorDB = ex.Message.ToString();

            }
            finally
            {
                if (objDatos.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidarConexionDB(ref objDatos);
                }
            }
        }
        private void EjecutarCommand(ref BaseDatos objDatos)
        {
            try
            {
                PrepararConexionDB(ref objDatos);
                objDatos.ObjSqlCommand = new SqlCommand(objDatos.NombreSP, ObjSqlConnection);
                objDatos.ObjSqlCommand.CommandType = CommandType.StoredProcedure;
                AgregarParametros(ref objDatos);

                if (objDatos.Scalar)
                {
                    objDatos.ObjSqlCommand.ExecuteScalar();
                }
                else
                {
                    objDatos.ObjSqlCommand.ExecuteNonQuery();
                }


            }
            catch (Exception exc)
            {
                objDatos.MensajeErrorDB = exc.Message.ToString();
            }
            finally
            {
                if (objDatos.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidarConexionDB(ref objDatos);
                }
            }
        }
        #endregion

        #region MetodosPublicos
        public void Crud(ref BaseDatos objDatos)
        {
            if (objDatos.Scalar)
            {
                EjecutarCommand(ref objDatos);
            }
            else
            {
                EjecutarDA(ref objDatos);
            }
        }
        #endregion

    }
}
