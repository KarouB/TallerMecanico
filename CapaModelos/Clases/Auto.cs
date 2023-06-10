namespace CapaModelos.Clases
{
    public class Auto : Vehiculo
    {
        #region Enum
        public enum TipoAuto
        {
            Compacto = 0,
            Sedan = 1,
            Monovolumen = 2,
            Utilitario = 3,
            Lujo = 4
        };
        #endregion

        #region Variables
        private int mIdAuto;
        private int mIdVehiculo;
        private TipoAuto mTipo;
        private int mCantidadPuertas;
        #endregion

        #region Propiedades
        public int IdAuto { get => mIdAuto; set => mIdAuto = value; }
        public int IdVehiculo { get => mIdVehiculo; set => mIdVehiculo = value; }
        public TipoAuto Tipo { get => mTipo; set => mTipo = value; }
        public int CantidadPuertas { get => mCantidadPuertas; set => mCantidadPuertas = value; }
        #endregion
    }
}
