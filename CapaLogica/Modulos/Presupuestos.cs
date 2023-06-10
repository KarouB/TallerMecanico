using CapaModelos.Clases;
using CapaPersistencia.Sql_server;
using System;
using System.Data;

namespace CapaLogica.Modulos
{
    public static class Presupuestos
    {
        #region VariablesPrivadas
        private static BaseDatos objDatos = null;
        #endregion

        #region ConsultasDB
        public static void Save(ref Presupuesto objPresupuesto)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Presupuestos",
                NombreSP = "spPresupuestos_Create",
                Scalar = true
            };
            objDatos.DtParametros.Rows.Add(@"@Id", SqlDbType.BigInt, objPresupuesto.Id, ParameterDirection.Output);
            objDatos.DtParametros.Rows.Add(@"@IdVehiculo", SqlDbType.BigInt, objPresupuesto.IdVehiculo);
            objDatos.DtParametros.Rows.Add(@"@Total", SqlDbType.Decimal, objPresupuesto.Total);

            Ejecutar(ref objPresupuesto);
        }
        private static void Ejecutar(ref Presupuesto objPresupuesto)
        {
            objDatos.Crud(ref objDatos);

            if (objDatos.MensajeErrorDB == null)
            {
                if (objDatos.Scalar)
                {
                    objPresupuesto.Id = Convert.ToInt32(objDatos.ObjSqlCommand.Parameters[0].Value);
                }
                else
                {
                    objPresupuesto.DtResultados = objDatos.DsResultados.Tables[0];
                    if (objPresupuesto.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in objPresupuesto.DtResultados.Rows)
                        {
                            objPresupuesto.Id = Convert.ToInt32(item["Id"]);
                            objPresupuesto.IdVehiculo = Convert.ToInt32(item["IdVehiculo"]);
                            objPresupuesto.Total = Convert.ToInt32(item["Total"]);
                        }
                    }
                }
            }
            else
            {
                objPresupuesto.MensajeError = objDatos.MensajeErrorDB;
            }
        }
        #endregion
    }
}
