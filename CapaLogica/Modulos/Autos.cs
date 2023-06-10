using CapaModelos.Clases;
using CapaPersistencia.Sql_server;
using System;
using System.Data;

namespace CapaLogica.Modulos
{
    public static class Autos
    {
        #region VariablesPrivadas
        private static BaseDatos objDatos = null;
        #endregion

        #region ConsultasDB
        public static void SaveAuto(ref Auto objAuto)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Autos",
                NombreSP = "spAutosCreate",
                Scalar = true
            };
            objDatos.DtParametros.Rows.Add(@"@Id", SqlDbType.BigInt, objAuto.Id, ParameterDirection.Output);
            objDatos.DtParametros.Rows.Add(@"@IdVehiculo", SqlDbType.BigInt, objAuto.IdVehiculo, ParameterDirection.Output);
            objDatos.DtParametros.Rows.Add(@"@IdCliente", SqlDbType.BigInt, objAuto.IdCliente);
            objDatos.DtParametros.Rows.Add(@"@Tipo", SqlDbType.SmallInt, Convert.ToInt32(objAuto.Tipo));
            objDatos.DtParametros.Rows.Add(@"@CantPuertas", SqlDbType.SmallInt, objAuto.CantidadPuertas);
            objDatos.DtParametros.Rows.Add(@"@Marca", SqlDbType.VarChar, objAuto.Marca);
            objDatos.DtParametros.Rows.Add(@"@Patente", SqlDbType.VarChar, objAuto.Patente);
            objDatos.DtParametros.Rows.Add(@"@Modelo", SqlDbType.VarChar, objAuto.Modelo);

            Ejecutar(ref objAuto);
        }
        public static void UpdateAuto(ref Auto objAuto)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Autos",
                NombreSP = "spAutos_Up",
                Scalar = true
            };
            objDatos.DtParametros.Rows.Add(@"@Id", SqlDbType.BigInt, objAuto.Id);
            objDatos.DtParametros.Rows.Add(@"@IdVehiculo", SqlDbType.BigInt, objAuto.IdVehiculo);
            objDatos.DtParametros.Rows.Add(@"@Tipo", SqlDbType.SmallInt, Convert.ToInt32(objAuto.Tipo));
            objDatos.DtParametros.Rows.Add(@"@CantPuertas", SqlDbType.SmallInt, objAuto.CantidadPuertas);
            objDatos.DtParametros.Rows.Add(@"@Marca", SqlDbType.VarChar, objAuto.Marca);
            objDatos.DtParametros.Rows.Add(@"@Patente", SqlDbType.VarChar, objAuto.Patente);
            objDatos.DtParametros.Rows.Add(@"@Modelo", SqlDbType.VarChar, objAuto.Modelo);

            Ejecutar(ref objAuto);
        }
        private static void Ejecutar(ref Auto objAuto)
        {
            objDatos.Crud(ref objDatos);

            if (objDatos.MensajeErrorDB == null)
            {
                if (objDatos.Scalar)
                {
                    objAuto.IdAuto = Convert.ToInt32(objDatos.ObjSqlCommand.Parameters[0].Value);
                    objAuto.IdVehiculo = Convert.ToInt32(objDatos.ObjSqlCommand.Parameters[1].Value);
                }
                else
                {
                    objAuto.DtResultados = objDatos.DsResultados.Tables[0];
                    if (objAuto.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in objAuto.DtResultados.Rows)
                        {
                            objAuto.IdAuto = Convert.ToInt32(item["Id"]);
                            objAuto.IdVehiculo = Convert.ToInt32(item["IdVehiculo"]);
                            objAuto.Tipo = (Auto.TipoAuto)Convert.ToInt32(item["Tipo"]);
                            objAuto.CantidadPuertas = Convert.ToInt32(item["CantPuertas"].ToString());
                            objAuto.Marca = item["Marca"].ToString();
                            objAuto.Modelo = item["Modelo"].ToString();
                            objAuto.Patente = item["Patente"].ToString();
                        }
                    }
                }
            }
            else
            {
                objAuto.MensajeError = objDatos.MensajeErrorDB;
            }
        }
        #endregion
    }
}
