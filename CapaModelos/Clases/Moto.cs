namespace CapaModelos.Clases
{
    public class Moto : Vehiculo
    {
        #region Variables
        private int mIdMoto;
        private int mIdVehiculo;
        private string mCilindrada;
        #endregion

        #region Propiedades
        public int IdMoto { get => mIdMoto; set => mIdMoto = value; }
        public int IdVehiculo { get => mIdVehiculo; set => mIdVehiculo = value; }
        public string Cilindrada { get => mCilindrada; set => mCilindrada = value; }
        #endregion
    }
}
