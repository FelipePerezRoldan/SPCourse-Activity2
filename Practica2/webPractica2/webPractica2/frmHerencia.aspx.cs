using libFiguras;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webPractica2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        #region Variables globales
        static int intFig;
        static string strDir = "~/Imagenes/";//sube un nivel ~ y luego entra a la carpeta imagenes
        static string strImage;
        #endregion

        #region Metodos própios
        private void Mensaje(string texto)
        {
            this.lblMsj.Text = texto;
        }
        private void cargarImagen(string name)
        {
            strImage = strDir + name + ".jpg";
            this.imgFigura.ImageUrl = @strImage;
        }
        private void limpiarDatos()
        {
            //limpiar con  el foreach
            intFig = this.rlbfiguras.SelectedIndex;
            switch (intFig)
            {
                case 0://triangulo
                    foreach (Control control in pnlTriangulo.Controls) // Limpiar con foreach
                    {
                        if (control is TextBox)
                        {
                            TextBox textBox = (TextBox)control;
                            textBox.Text = string.Empty;
                        }
                    }
                    break;
                case 1://Rectangulo
                    foreach (Control control in pnlRectangulo.Controls) // Limpiar con foreach
                    {
                        if (control is TextBox)
                        {
                            TextBox textBox = (TextBox)control;
                            textBox.Text = string.Empty;
                        }
                    }
                    break;
                default:
                    foreach (Control control in pnlRombo.Controls) // Limpiar con foreach
                    {
                        if (control is TextBox)
                        {
                            TextBox textBox = (TextBox)control;
                            textBox.Text = string.Empty;
                        }
                    }
                    break;
            }
            Mensaje(string.Empty);
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                intFig = 0;
                cargarImagen("Triangulo");
                this.txtLadoA.Focus();
            }
        }

        protected void rlbfiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarDatos();
            this.pnlRectangulo.Visible = false;
            this.pnlRombo.Visible = false;
            this.pnlTriangulo.Visible = false;
            this.pnlRpta.Visible = false;
            intFig = this.rlbfiguras.SelectedIndex;
            switch (intFig)
            {
                case 0://triangulo
                    cargarImagen("triangulo");
                    this.pnlTriangulo.Visible = true;
                    this.txtLadoA.Focus();
                    break;
                case 1://Rectangulo
                    cargarImagen("rectangulo");
                    this.pnlRectangulo.Visible = true;
                    this.txtLado1.Focus();
                    break;
                default:
                    cargarImagen("rombo");
                    this.pnlRombo.Visible = true;
                    this.txtDiagMy.Focus();
                    break;
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            float vr1 = 0;
            float vr2 = 0;
            float vr3 = 0;
            float vrArea = 0;
            float vrPerim = 0;

            try
            {
                switch (intFig)
                {
                    case 0://triangulo
                        vr1 = Convert.ToSingle(this.txtLadoA.Text);
                        vr2 = Convert.ToSingle(this.txtLadoB.Text);
                        vr3 = Convert.ToSingle(this.txtAngulo.Text);
                        this.txtLadoA.Focus();
                        //crear objeto
                        clsTriangulo objT = new clsTriangulo(vr1, vr2, vr3);
                        //Enviar info
                        if (!objT.hallarArea() || !objT.hallarPerimetro())
                        {
                            Mensaje(objT.Error);
                            objT = null;
                            break;
                        }
                        vrArea = objT.Area;
                        vrPerim = objT.Perimetro;
                        objT = null;
                        break;
                    case 1://Rectangulo
                        vr1 = Convert.ToSingle(this.txtLado1.Text);
                        vr2 = Convert.ToSingle(this.txtLado2.Text);
                        this.txtLado1.Focus();
                        //crear objeto
                        clsCuadrado objC = new clsCuadrado(vr1, vr2);
                        //Enviar info
                        if (!objC.hallarArea() || !objC.hallarPerimetro())
                        {
                            Mensaje(objC.Error);
                            objC = null;
                            break;
                        }
                        vrArea = objC.Area;
                        vrPerim = objC.Perimetro;
                        objC = null;
                        break;
                    default:
                        vr1 = Convert.ToSingle(this.txtLado.Text);
                        vr2 = Convert.ToSingle(this.txtDiagMy.Text);
                        vr3 = Convert.ToSingle(this.txtDiagMn.Text);
                        this.txtLadoA.Focus();
                        //crear objeto
                        clsRombo objR = new clsRombo(vr1, vr2, vr3);
                        //Enviar info
                        if (!objR.hallarArea() || !objR.hallarPerimetro())
                        {
                            Mensaje(objR.Error);
                            objR = null;
                            break;
                        }
                        vrArea = objR.Area;
                        vrPerim = objR.Perimetro;
                        objR = null;
                        break;
                }
                this.lblArea.Text = Convert.ToString(vrArea);
                this.lblPerim.Text = Convert.ToString(vrPerim);
                this.pnlRpta.Visible = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            rlbfiguras_SelectedIndexChanged(null, null);
        }
    }
}