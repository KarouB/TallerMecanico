using CapaModelos.Clases;
using CapaPersistencia.Sql_server;
using System;
using System.Data;

namespace CapaLogica.Modulos
{
    public static class Desperfectos
    {
        #region VariablesPrivadas
        private static BaseDatos objDatos = null;
        #endregion

        #region ConsultasDB
        public static void Read(ref Desperfecto objDesp)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Desperfectos",
                NombreSP = "spDesperfectos_Read",
                Scalar = false
            };
            objDatos.DtParametros.Rows.Add(@"@Id", SqlDbType.VarChar, objDesp.Id);

            Ejecutar(ref objDesp);
        }
        public static void Save(ref Desperfecto objDesp)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Desperfectos",
                NombreSP = "spDesperfectos_Create",
                Scalar = true
            };
            objDatos.DtParametros.Rows.Add(@"@Id", SqlDbType.BigInt, objDesp.Id, ParameterDirection.Output);
            objDatos.DtParametros.Rows.Add(@"@IdPresupuesto", SqlDbType.BigInt, objDesp.IdPresupuesto);
            objDatos.DtParametros.Rows.Add(@"@Descripcion", SqlDbType.VarChar, objDesp.Descripcion);
            objDatos.DtParametros.Rows.Add(@"@ManoObra", SqlDbType.Decimal, objDesp.ManoObra);
            objDatos.DtParametros.Rows.Add(@"@Tiempo", SqlDbType.Int, objDesp.Tiempo);

            Ejecutar(ref objDesp);
        }
        public static DataTable GetDtRepuestos()
        {
            DataTable dt = new DataTable();
            objDatos = new BaseDatos()
            {
                NombreTable = "GetDtRepuestos",
                NombreSP = "spGetDtRepuestos",
                Scalar = false
            };

            objDatos.Crud(ref objDatos);

            if (objDatos.MensajeErrorDB == null)
            {
                dt = objDatos.DsResultados.Tables[0];
            }
            return dt;
        }
        public static void GuardarRelacionRepuestos(int idDesp, int idRep)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Desperfectos_Repuestos",
                NombreSP = "spDesperfectos_Repuestos",
                Scalar = true
            };
            objDatos.DtParametros.Rows.Add(@"@IdDesperfecto", SqlDbType.BigInt, idDesp);
            objDatos.DtParametros.Rows.Add(@"@IdRepuesto", SqlDbType.BigInt, idRep);

            objDatos.Crud(ref objDatos);

        }
        private static void Ejecutar(ref Desperfecto objDesp)
        {
            objDatos.Crud(ref objDatos);

            if (objDatos.MensajeErrorDB == null)
            {
                if (objDatos.Scalar)
                {
                    objDesp.Id = Convert.ToInt32(objDatos.ObjSqlCommand.Parameters[0].Value);
                }
                else
                {
                    objDesp.DtResultados = objDatos.DsResultados.Tables[0];
                    if (objDesp.DtResultados.Rows.Count == 1)
                    {
                        DataRow item = objDesp.DtResultados.Rows[0];
                        objDesp.Id = Convert.ToInt32(item["Id"]);
                        objDesp.IdPresupuesto = Convert.ToInt32(item["IdPresupuesto"]);
                        objDesp.Descripcion = item["Descripcion"].ToString();
                        objDesp.ManoObra = Convert.ToInt32(item["ManoObra"]);
                        objDesp.Tiempo = Convert.ToInt32(item["Tiempo"]);
                    }
                }
            }
            else
            {
                objDesp.MensajeError = objDatos.MensajeErrorDB;
            }
        }
        #endregion
    }
}
