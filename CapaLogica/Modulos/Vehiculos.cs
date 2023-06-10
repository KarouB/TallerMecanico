using CapaModelos.Clases;
using CapaPersistencia.Sql_server;
using System;
using System.Data;

namespace CapaLogica.Modulos
{
    public static class Vehiculos
    {
        #region VariablesPrivadas
        private static BaseDatos objDatos = null;
        #endregion

        #region ConsultasDB
        public static void Read(ref Auto objAuto, ref Moto objMoto)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Vehiculos",
                NombreSP = "spVehiculos_Read",
                Scalar = false
            };
            objDatos.DtParametros.Rows.Add(@"@Patente", SqlDbType.VarChar, objAuto.Patente);

            Ejecutar(ref objAuto, ref objMoto);
        }
        public static void BuscarVehiculoxCliente(ref Auto objAuto, ref Moto objMoto)
        {
            objDatos = new BaseDatos()
            {
                NombreTable = "Vehiculos",
                NombreSP = "spBuscarVehiculoxCliente",
                Scalar = false
            };
            objDatos.DtParametros.Rows.Add(@"@IdCliente", SqlDbType.BigInt, objAuto.IdCliente);


            Ejecutar(ref objAuto, ref objMoto);
        }
        private static void Ejecutar(ref Auto objAuto, ref Moto objMoto)
        {
            objDatos.Crud(ref objDatos);

            if (objDatos.MensajeErrorDB == null)
            {
                if (objDatos.Scalar)
                {

                }
                else
                {
                    if (objDatos.DsResultados.Tables[0].Rows.Count == 1)
                    {
                        DataRow item = objDatos.DsResultados.Tables[0].Rows[0];
                        if (item.Field<int>("TipoVehiculo") == 0)
                        {
                            objAuto.IdVehiculo = Convert.ToInt32(item["Id"]);
                            objAuto.IdAuto = Convert.ToInt32(item["IdAuto"]);
                            objAuto.Marca = item["Marca"].ToString();
                            objAuto.Modelo = item["Modelo"].ToString();
                            objAuto.Patente = item["Patente"].ToString();
                            objAuto.Tipo = (Auto.TipoAuto)Convert.ToInt32(item["Tipo"]);
                            objAuto.CantidadPuertas = Convert.ToInt32(item["CantPuertas"]);
                        }
                        else
                        {
                            objMoto.IdVehiculo = Convert.ToInt32(item["Id"]);
                            objMoto.IdMoto = Convert.ToInt32(item["IdMoto"]);
                            objMoto.Marca = item["Marca"].ToString();
                            objMoto.Modelo = item["Modelo"].ToString();
                            objMoto.Patente = item["Patente"].ToString();
                            objMoto.Cilindrada = item["Cilindrada"].ToString();
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
