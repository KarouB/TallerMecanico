using CapaModelos.Clases;
using CapaPersistencia.Sql_server;
using System;
using System.Data;

namespace CapaLogica.Modulos
{
    public static class Motos
    {
        #region VariablesPrivadas
        private static BaseDatos objDatos = null;
        #endregion

        #region ConsultasDB
        public static void SaveMoto(ref Moto objMoto)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Motos",
                NombreSP = "spMotos_Create",
                Scalar = true
            };
            objDatos.DtParametros.Rows.Add(@"@Id", SqlDbType.BigInt, objMoto.Id, ParameterDirection.Output);
            objDatos.DtParametros.Rows.Add(@"@IdCliente", SqlDbType.BigInt, objMoto.IdCliente);
            objDatos.DtParametros.Rows.Add(@"@IdVehiculo", SqlDbType.BigInt, objMoto.IdVehiculo, ParameterDirection.Output);
            objDatos.DtParametros.Rows.Add(@"@Cilindrada", SqlDbType.VarChar, objMoto.Cilindrada);
            objDatos.DtParametros.Rows.Add(@"@Marca", SqlDbType.VarChar, objMoto.Marca);
            objDatos.DtParametros.Rows.Add(@"@Patente", SqlDbType.VarChar, objMoto.Patente);
            objDatos.DtParametros.Rows.Add(@"@Modelo", SqlDbType.VarChar, objMoto.Modelo);


            Ejecutar(ref objMoto);
        }
        public static void UpdateMoto(ref Moto objMoto)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Motos",
                NombreSP = "spMotos_Up",
                Scalar = true
            };
            objDatos.DtParametros.Rows.Add(@"@Id", SqlDbType.BigInt, objMoto.Id);
            objDatos.DtParametros.Rows.Add(@"@IdVehiculo", SqlDbType.BigInt, objMoto.IdVehiculo);
            objDatos.DtParametros.Rows.Add(@"@Cilindrada", SqlDbType.VarChar, objMoto.Cilindrada);
            objDatos.DtParametros.Rows.Add(@"@Marca", SqlDbType.VarChar, objMoto.Marca);
            objDatos.DtParametros.Rows.Add(@"@Patente", SqlDbType.VarChar, objMoto.Patente);
            objDatos.DtParametros.Rows.Add(@"@Modelo", SqlDbType.VarChar, objMoto.Modelo);


            Ejecutar(ref objMoto);
        }
        private static void Ejecutar(ref Moto objMoto)
        {
            objDatos.Crud(ref objDatos);

            if (objDatos.MensajeErrorDB == null)
            {
                if (objDatos.Scalar)
                {
                    objMoto.IdMoto = Convert.ToInt32(objDatos.ObjSqlCommand.Parameters[0].Value);
                    objMoto.IdVehiculo = Convert.ToInt32(objDatos.ObjSqlCommand.Parameters[1].Value);
                }
                else
                {
                    objMoto.DtResultados = objDatos.DsResultados.Tables[0];
                    if (objMoto.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in objMoto.DtResultados.Rows)
                        {
                            objMoto.IdMoto = Convert.ToInt32(item["Id"]);
                            objMoto.IdVehiculo = Convert.ToInt32(item["IdVehiculo"]);
                            objMoto.Cilindrada = item["Cilindrada"].ToString();
                            objMoto.Marca = item["Marca"].ToString();
                            objMoto.Modelo = item["Modelo"].ToString();
                            objMoto.Patente = item["Patente"].ToString();
                        }
                    }
                }
            }
            else
            {
                objMoto.MensajeError = objDatos.MensajeErrorDB;
            }
        }
        #endregion
    }
}
