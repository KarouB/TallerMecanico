using CapaModelos.Clases;
using CapaPersistencia.Sql_server;
using System;
using System.Data;

namespace CapaLogica.Modulos
{
    public static class Clientes
    {
        #region VariablesPrivadas
        private static BaseDatos objDatos = null;
        #endregion

        #region ConsultasDB
        public static void Read(ref Cliente objCliente)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Clientes",
                NombreSP = "spClientes_Read",
                Scalar = false
            };
            objDatos.DtParametros.Rows.Add(@"@Documento", SqlDbType.VarChar, objCliente.Documento);

            Ejecutar(ref objCliente);
        }
        public static void Save(ref Cliente objCliente)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Clientes",
                NombreSP = "spClientes_Create",
                Scalar = true
            };
            objDatos.DtParametros.Rows.Add(@"@Id", SqlDbType.BigInt, objCliente.Id, ParameterDirection.Output);
            objDatos.DtParametros.Rows.Add(@"@Nombre", SqlDbType.VarChar, objCliente.Nombre);
            objDatos.DtParametros.Rows.Add(@"@Apellido", SqlDbType.VarChar, objCliente.Apellido);
            objDatos.DtParametros.Rows.Add(@"@Documento", SqlDbType.VarChar, objCliente.Documento);
            objDatos.DtParametros.Rows.Add(@"@Mail", SqlDbType.VarChar, objCliente.Mail);

            Ejecutar(ref objCliente);
        }
        public static void UpdateCliente(ref Cliente objCliente)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Clientes",
                NombreSP = "spClientes_Up",
                Scalar = true
            };
            objDatos.DtParametros.Rows.Add(@"@Id", SqlDbType.BigInt, objCliente.Id);
            objDatos.DtParametros.Rows.Add(@"@Nombre", SqlDbType.VarChar, objCliente.Nombre);
            objDatos.DtParametros.Rows.Add(@"@Apellido", SqlDbType.VarChar, objCliente.Apellido);
            objDatos.DtParametros.Rows.Add(@"@Documento", SqlDbType.VarChar, objCliente.Documento);
            objDatos.DtParametros.Rows.Add(@"@Mail", SqlDbType.VarChar, objCliente.Mail);

            Ejecutar(ref objCliente);
        }
        private static void Ejecutar(ref Cliente objCliente)
        {
            objDatos.Crud(ref objDatos);

            if (objDatos.MensajeErrorDB == null)
            {
                if (objDatos.Scalar)
                {
                    objCliente.Id = Convert.ToInt32(objDatos.ObjSqlCommand.Parameters[0].Value);
                }
                else
                {
                    objCliente.DtResultados = objDatos.DsResultados.Tables[0];
                    if (objCliente.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in objCliente.DtResultados.Rows)
                        {
                            objCliente.Id = Convert.ToInt32(item["Id"]);
                            objCliente.Nombre = item["Nombre"].ToString();
                            objCliente.Apellido = item["Apellido"].ToString();
                            objCliente.Documento = item["Documento"].ToString();
                            objCliente.Mail = item["Mail"].ToString();
                        }
                    }
                }
            }
            else
            {
                objCliente.MensajeError = objDatos.MensajeErrorDB;
            }
        }
        #endregion
    }
}
