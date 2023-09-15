namespace libFigura2D
{
    public abstract class clsFigura2D
    {
        #region Atributos
        protected float fltArea;
        protected float fltPerimetro;
        protected string strError;
        #endregion
        #region Propiedades
        public float Area
        {
            get { return fltArea; }
        }
        public float Perimetro
        {
            get { return fltPerimetro; }
        }
        public string Error
        {
            get { return strError; }
        }
        #endregion
        #region Metodos publicos
        public abstract bool hallarArea();
        public abstract bool hallarPerimetro();
        #endregion
    }
}
