using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libFigura2D;

namespace libClasifFiguras
{
    public abstract class clsPoligono : clsFigura2D
    {
        #region Atributos
        protected float fltLado1;
        #endregion
        #region Propiedades
        public float Lado1
        {
            set { fltLado1 = value; }
        }
        #endregion
    }
    public abstract class clsCuadrilatero : clsPoligono
    {

    }
}
