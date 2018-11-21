using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class frmCalculadora : Form
    {
        private Calculadora calc;

        public frmCalculadora()
        {
            InitializeComponent();

            //inicio instancia de calculadora
            calc = Calculadora.getInstancia();

            //inicio label display y operador
            ActualizarLabels();
        }


        private void ActualizarLabels()
        {
            //operandos 1 y 2
            this.lblOperando1.Text = this.calc.getStrOperando1();
            this.lblOperando2.Text = this.calc.getStrOperando2();
            //resultado
            this.lblResultado.Text = this.calc.getStrResultado();
            //actualizo operacion
            this.lblOperacion.Text =this.calc.Operacion;
        }
        /*--------------------------------------------------*/

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void frmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char digito = e.KeyChar;
            Button btn = null;
            
            //efecto de tecla presionada
            //tomo la tecla presionada
            switch (digito)
            {
                //teclas de numeros 0- 9
                case (char)Keys.D0://tecla cero
                    btn = btnCero;
                    break;
                case (char)Keys.D1://tecla uno
                    btn = btnUno;
                    break;
                case (char)Keys.D2://tecla dos
                    btn = btnDos;
                    break;
                case (char)Keys.D3://tecla tres
                    btn = btnTres;
                    break;
                case (char)Keys.D4://tecla cuatro
                    btn = btnCuatro;
                    break;
                case (char)Keys.D5://tecla cinco
                    btn = btnCinco;
                    break;
                case (char)Keys.D6://tecla seis
                    btn = btnSeis;
                    break;
                case (char)Keys.D7://tecla siete
                    btn = btnSiete;
                    break;
                case (char)Keys.D8://tecla ocho
                    btn = btnOcho;
                    break;
                case (char)Keys.D9://tecla nueve
                    btn = btnNueve;
                    break;
                
            }//switch

            //accion del boton presionado
            if (btn != null)
            {
                btn.Select();
                btn.PerformClick();
            }
        }

        private void FrmCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            int key = (int)e.KeyCode;
            Button btn = null;
           // MessageBox.Show("tecla " + key);
            switch (key)
            {
                //operaciones matematicas
                case (int)Keys. Add:
                    btn = this.btnSuma;
                    
                    break;//    +
                case (int)Keys.Subtract:
                    btn = this.btnResta;
                    break;//    -
                case (int)Keys.Multiply:
                    btn = this.btnProducto;
                    break;//    x, boton * teclado
                case (int)Keys.Divide:
                    btn = this.btnDivision;
                    break;//    /, boton dividir 
                case (int)Keys.P:
                    btn = this.btnPorciento;
                    break;//    %, tecla P, porcentaje
                case (int)Keys.X:
                    btn = this.btnCuadrado;
                    break;//    x2, tecla x, cuadrado
                case (int)Keys.R:
                    btn = this.btnRaiz;
                    break;//    %, tecla P, porcentaje

                //signo
                case (int)Keys.S:
                    btn = this.btnSigno;
                    break;//    +-, boton signo
                //punto  decimal
                case (int)Keys.Decimal:
                case (int)Keys.Separator:
                    btn = this.btnPunto;
                    break;//    ., punto decimal
                //controles
                case 8:
                    btn = this.btnBack;
                    break;//    <<, retroceso
                case (int)Keys.Escape:
                    btn = this.btnCE;
                    break;//    boton CE.cancela todo
                case (int)Keys.F2:
                    btn = this.btnC;
                    break;//    boton C, borra el operador actual
                case (int)Keys.F4:
                    btn = this.btnSalir;
                    break; //   botono X, salir 
                case (int)Keys.F5:
                    btn = this.btnIgual;
                    break;// boton  =

                // ayuda
                case (int)Keys.F1:
                    MessageBox.Show(
                        "TP1 Calculadora" +'\r'+
                        "Autor: Sam" + '\r' +
                        "Aplicaciones Distribuidas 2018" + '\r' +
                        "-------------------------" +'\r' +
                        "F1 - AYUDA" + '\r' +
                        "ESC - CE - cancela operacion y operandos " +'\r' +
                        "F2 - C - borra el operando actual" + '\r' +
                        "F4 - X - sale de la aplicacion " + '\r' +
                        "tecla p - calcula porcentaje B de A" + '\r' +
                        "tecla x - calcula cuadrado de A" + '\r' +
                        "tecla r - calcula razi cuadra de A" + '\r' +
                        "F5 - =  - Obtiene resultado de la operacion "
                        );
                    break;
            }
            //accion del boton presionado
            if (btn != null)
            {
                btn.Select();
                btn.PerformClick();
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            //este metodo es general para todos los botones 
            //tomo el boton presionado, del  0 al 9 para cargar los operadores
            Button btn = (Button)sender;
            this.lblOperando1.Text = this.lblOperando1.Text + btn.Text;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            //reinicia datos de la calculadora
            calc.reiniciarValores();
            ActualizarLabels();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.lblOperando1.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //elimina el ultimo digito ingresado
            //si no se a pulsado la operacion
            String aux;
            aux = this.lblOperando1.Text;
            if (aux.Length > 0 )
            {
                aux = aux.Remove(aux.Length - 1);
                this.lblOperando1.Text = aux;
            }
            /*else
            {
                aux = this.lblOperando2.Text;
                aux = aux.Remove(aux.Length - 1);
                this.lblOperando2.Text = aux;
            }*/
            //ActualizarLabels();
        }

        private void sqrRaiz_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (this.calc.Operacion == "")
            {
                this.calc.setStrOperando1(lblOperando1.Text);
            }
            else
            {
                this.calc.Operando1 = this.calc.Resultado;
            }
            //cargo la operacion realizada
            this.calc.Operacion = (String)btn.Tag;//raiz
            this.calc.raiz();
            ActualizarLabels();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (this.calc.Operacion == "")
            {
                this.calc.setStrOperando1(lblOperando1.Text);
            }
            else
            {
                this.calc.Operando1 = this.calc.Resultado;
            }
            //cargo la operacion realizada
            this.calc.Operacion = (String)btn.Tag;//cuadrado
            this.calc.cuadrado();
            ActualizarLabels();
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            //agrega el signo - o lo quita de pantalla
            Button btn = (Button)sender;
            String aux;
            if (this.lblOperando1.Text !="0" )
            {
                aux=this.lblOperando1.Text;
                if (aux.Contains("-"))
                {
                    aux = aux.Remove(0);
                }
                else
                {
                    aux = aux + "-";
                }

                this.lblOperando1.Text=aux;
            }
        }

        private void btnPorciento_Click(object sender, EventArgs e)
        {
            //confirma primer operando y la operacion
            //es generala para % + - * / 
            Button btn = (Button)sender;
            this.calc.Operacion = (String)btn.Tag;//pocentaje 
            lblOperacion.Text = this.calc.Operacion;
            //guardo operando 1
            this.calc.setStrOperando1(lblOperando1.Text);
            this.lblOperando2.Text = this.calc.getStrOperando1();
            //vuelvo a cero para ingresar el sgte operando
            this.lblOperando1.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!lblOperando1.Text.Contains("."))
            {
                lblOperando1.Text = lblOperando1.Text + ".";
            }

        }
               

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //guardo operando 2 para %  + - * /
            this.calc.setStrOperando2(lblOperando1.Text);

            //efectuo la operacion
            //suma
            if (this.calc.Operacion==(String)this.btnSuma.Tag)
            {
                this.calc.suma();
            }
            //resta
            if (this.calc.Operacion == (String)this.btnResta.Tag)
            {
                this.calc.resta();
            }
            //producto
            if (this.calc.Operacion == (String)this.btnProducto.Tag)
            {
                this.calc.producto();
            }
            //division
            if (this.calc.Operacion == (String)btnDivision.Tag)
            {
                this.calc.division();
            }
            //porcentaje
            if (this.calc.Operacion == (String)btnPorciento.Tag)
            {
                this.calc.porcentaje();
            }
            

            Button btn = (Button)sender;
            this.calc.Operacion = "";
            this.lblOperando1.Text = this.calc.getStrResultado();
            this.lblResultado.Text = this.calc.getStrResultado();
            //ActualizarLabels();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
                        "TP1 Calculadora" + '\r' +
                        "Autor: Sam" + '\r' +
                        "Aplicaciones Distribuidas 2018" + '\r' +

                        "-------------------------" + '\r' +
                        "F1 - AYUDA" + '\r' +
                        "ESC - CE - cancela operacion y operandos " + '\r' +
                        "F2 - C - borra el operando actual" + '\r' +
                        "F4 - X - sale de la aplicacion " + '\r' +
                        "tecla p - calcula porcentaje B de A" + '\r' +
                        "tecla x - calcula cuadrado de A" + '\r' +
                        "tecla r - calcula razi cuadra de A" + '\r' +
                        "F5 - =  - Obtiene resultado de la operacion "
                        );
            
        }
    }
}

