using libClasifFiguras;
using System;
//se referencian todas ysolo se usa la ultima
namespace libFiguras
{
    public class clsTriangulo : clsPoligono
    {
        #region Atributos
        private float fltLado2;
        private float fltAngulo;
        #endregion
        #region Constructores
        public clsTriangulo()
        {
            fltLado1 = 0;
            fltLado2 = 0;
            fltAngulo = 0;
            fltArea = 0;
            fltPerimetro = 0;
            strError = string.Empty;
        }
        public clsTriangulo(float lado1, float lado2, float angulo)
        {
            fltLado1 = lado1;
            fltLado2 = lado2;
            fltAngulo = angulo;
            fltArea = 0;
            fltPerimetro = 0;
            strError = string.Empty;
        }
        #endregion
        #region Propiedades
        public float Lado2
        {
            set { fltLado2 = value; }
        }
        public float Angulo
        {
            set { fltAngulo = value; }
        }
        #endregion
        #region Metodos privados
        private bool Validar()
        {
            if (fltLado1 <= 0)
            {
                strError = $"Error,lado 1:{fltLado1} no valido";
                return false;
            }
            if (fltLado2 <= 0)
            {
                strError = $"Error, lado 2:{fltLado2} no valido";
                return false;
            }
            if (fltAngulo <= 0)
            {
                strError = $"Error, angulo:{fltAngulo} no valido";
                return false;
            }
            return true;
        }
        public override bool hallarArea()
        {
            if (!Validar())
            {
                return false;
            }
            try
            {
                //lado 1 es la base qu esería el lado b
                float h = fltLado1 * ((float)( Math.Sin(fltAngulo*180/Math.PI)));
                fltArea = fltLado1 * h / 2f;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        public override bool hallarPerimetro()
        {
            if (!Validar())
            {
                return false;
            }
            float vrA = 0;
            try
            {
                vrA = (float)(Math.Sqrt(Math.Pow(fltLado1, 2) + Math.Pow(fltLado2, 2)-(2f*fltLado1*fltLado2*Math.Cos(fltAngulo*180/Math.PI))));
                fltPerimetro = fltLado1 + fltLado2 + vrA;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion
    }
    public class clsCuadrado : clsCuadrilatero
    {
        #region Atributos
        private float fltLado2;
        #endregion
        #region Constructores
        public clsCuadrado()
        {
            fltLado1 = 0;
            fltLado2 = 0;
            fltArea = 0;
            fltPerimetro = 0;
            strError = string.Empty;
        }
        public clsCuadrado(float lado1, float lado2)
        {
            fltLado1 = lado1;
            fltLado2 = lado2;
            fltArea = 0;
            fltPerimetro = 0;
            strError = string.Empty;
        }
        #endregion
        #region Propiedades
        public float Lado2
        {
            set { fltLado2 = value; }
        }
        #endregion
        #region Metodos privados
        private bool Validar()
        {
            if (fltLado1 <= 0)
            {
                strError = $"Error,lado 1:{fltLado1} no valido";
                return false;
            }
            if (fltLado2 <= 0)
            {
                strError = $"Error, lado 2:{fltLado2} no valido";
                return false;
            }
            return true;
        }
        public override bool hallarArea()
        {
            if (!Validar())
            {
                return false;
            }
            try
            {
                //lado 1 es la base qu esería el lado b
                fltArea = fltLado1 * fltLado2;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        public override bool hallarPerimetro()
        {
            if (!Validar())
            {
                return false;
            }
            try
            {
                fltPerimetro = fltLado1*2f + fltLado2 *2f;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion
    }
    public class clsRombo : clsCuadrilatero
    {
        #region Atributos
        private float fltDiagMy;
        private float fltDiagMn;
        #endregion
        #region Constructores
        public clsRombo()
        {
            fltLado1 = 0;
            fltDiagMy = 0;
            fltDiagMn = 0;
            fltArea = 0;
            fltPerimetro = 0;
            strError = string.Empty;
        }
        public clsRombo(float lado1, float diagonalMayor, float diagonalMenor)
        {
            fltLado1 = lado1;
            fltDiagMy = diagonalMayor;
            fltDiagMn = diagonalMenor;
            fltArea = 0;
            fltPerimetro = 0;
            strError = string.Empty;
        }
        #endregion
        #region Propiedades
        public float diag_Mayor
        {
            set { fltDiagMy = value; }
        }
        public float diag_Menor
        {
            set { fltDiagMn = value; }
        }
        #endregion
        #region Metodos privados
        private bool Validar()
        {
            if (fltLado1 <= 0)
            {
                strError = $"Error,lado 1:{fltLado1} no valido";
                return false;
            }
            if (fltDiagMy <= 0)
            {
                strError = $"Error, lado 2:{fltDiagMy} no valido";
                return false;
            }
            if (fltDiagMn <= 0)
            {
                strError = $"Error, lado 2:{fltDiagMn} no valido";
                return false;
            }
            return true;
        }
        public override bool hallarArea()
        {
            if (!Validar())
            {
                return false;
            }
            try
            {
                //lado 1 es la base qu esería el lado b
                fltArea = fltDiagMy * fltDiagMn/2f;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        public override bool hallarPerimetro()
        {
            if (!Validar())
            {
                return false;
            }
            try
            {
                fltPerimetro = fltLado1 * 4f;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion
    }
}
