namespace WindowsFormsApp1
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSigno = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnPorciento = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.lblOperando2 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblOperando1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pnlBotonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.Controls.Add(this.btnNueve);
            this.pnlBotonera.Controls.Add(this.btnResta);
            this.pnlBotonera.Controls.Add(this.btnPunto);
            this.pnlBotonera.Controls.Add(this.btnTres);
            this.pnlBotonera.Controls.Add(this.btnCero);
            this.pnlBotonera.Controls.Add(this.btnSeis);
            this.pnlBotonera.Controls.Add(this.btnCinco);
            this.pnlBotonera.Controls.Add(this.btnDos);
            this.pnlBotonera.Controls.Add(this.btnOcho);
            this.pnlBotonera.Controls.Add(this.btnSigno);
            this.pnlBotonera.Controls.Add(this.btnCuatro);
            this.pnlBotonera.Controls.Add(this.btnUno);
            this.pnlBotonera.Controls.Add(this.btnProducto);
            this.pnlBotonera.Controls.Add(this.btnSuma);
            this.pnlBotonera.Controls.Add(this.btnIgual);
            this.pnlBotonera.Controls.Add(this.btnDivision);
            this.pnlBotonera.Controls.Add(this.btnPorciento);
            this.pnlBotonera.Controls.Add(this.btnSiete);
            this.pnlBotonera.Controls.Add(this.btnCuadrado);
            this.pnlBotonera.Controls.Add(this.btnSalir);
            this.pnlBotonera.Controls.Add(this.btnRaiz);
            this.pnlBotonera.Controls.Add(this.btnBack);
            this.pnlBotonera.Controls.Add(this.btnC);
            this.pnlBotonera.Controls.Add(this.btnCE);
            resources.ApplyResources(this.pnlBotonera, "pnlBotonera");
            this.pnlBotonera.Name = "pnlBotonera";
            // 
            // btnNueve
            // 
            resources.ApplyResources(this.btnNueve, "btnNueve");
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Tag = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnResta
            // 
            resources.ApplyResources(this.btnResta, "btnResta");
            this.btnResta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnResta.Name = "btnResta";
            this.btnResta.Tag = "resta";
            this.toolTip1.SetToolTip(this.btnResta, resources.GetString("btnResta.ToolTip"));
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnPorciento_Click);
            // 
            // btnPunto
            // 
            resources.ApplyResources(this.btnPunto, "btnPunto");
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Tag = "punto";
            this.toolTip1.SetToolTip(this.btnPunto, resources.GetString("btnPunto.ToolTip"));
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnTres
            // 
            resources.ApplyResources(this.btnTres, "btnTres");
            this.btnTres.Name = "btnTres";
            this.btnTres.Tag = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnCero
            // 
            resources.ApplyResources(this.btnCero, "btnCero");
            this.btnCero.Name = "btnCero";
            this.btnCero.Tag = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnSeis
            // 
            resources.ApplyResources(this.btnSeis, "btnSeis");
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Tag = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnCinco
            // 
            resources.ApplyResources(this.btnCinco, "btnCinco");
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Tag = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            resources.ApplyResources(this.btnDos, "btnDos");
            this.btnDos.Name = "btnDos";
            this.btnDos.Tag = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnOcho
            // 
            resources.ApplyResources(this.btnOcho, "btnOcho");
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Tag = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnSigno
            // 
            resources.ApplyResources(this.btnSigno, "btnSigno");
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Tag = "signo";
            this.toolTip1.SetToolTip(this.btnSigno, resources.GetString("btnSigno.ToolTip"));
            this.btnSigno.UseVisualStyleBackColor = true;
            this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // btnCuatro
            // 
            resources.ApplyResources(this.btnCuatro, "btnCuatro");
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Tag = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnUno
            // 
            resources.ApplyResources(this.btnUno, "btnUno");
            this.btnUno.Name = "btnUno";
            this.btnUno.Tag = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnProducto
            // 
            resources.ApplyResources(this.btnProducto, "btnProducto");
            this.btnProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Tag = "producto";
            this.toolTip1.SetToolTip(this.btnProducto, resources.GetString("btnProducto.ToolTip"));
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnPorciento_Click);
            // 
            // btnSuma
            // 
            resources.ApplyResources(this.btnSuma, "btnSuma");
            this.btnSuma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Tag = "suma";
            this.toolTip1.SetToolTip(this.btnSuma, resources.GetString("btnSuma.ToolTip"));
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnPorciento_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnIgual, "btnIgual");
            this.btnIgual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Tag = "resultado";
            this.toolTip1.SetToolTip(this.btnIgual, resources.GetString("btnIgual.ToolTip"));
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDivision
            // 
            resources.ApplyResources(this.btnDivision, "btnDivision");
            this.btnDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Tag = "division";
            this.toolTip1.SetToolTip(this.btnDivision, resources.GetString("btnDivision.ToolTip"));
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnPorciento_Click);
            // 
            // btnPorciento
            // 
            resources.ApplyResources(this.btnPorciento, "btnPorciento");
            this.btnPorciento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPorciento.Name = "btnPorciento";
            this.btnPorciento.Tag = "porciento";
            this.toolTip1.SetToolTip(this.btnPorciento, resources.GetString("btnPorciento.ToolTip"));
            this.btnPorciento.UseVisualStyleBackColor = true;
            this.btnPorciento.Click += new System.EventHandler(this.btnPorciento_Click);
            // 
            // btnSiete
            // 
            resources.ApplyResources(this.btnSiete, "btnSiete");
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Tag = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnCuadrado
            // 
            resources.ApplyResources(this.btnCuadrado, "btnCuadrado");
            this.btnCuadrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Tag = "cuadrado";
            this.toolTip1.SetToolTip(this.btnCuadrado, resources.GetString("btnCuadrado.ToolTip"));
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Tag = "salir";
            this.toolTip1.SetToolTip(this.btnSalir, resources.GetString("btnSalir.ToolTip"));
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRaiz
            // 
            resources.ApplyResources(this.btnRaiz, "btnRaiz");
            this.btnRaiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Tag = "raiz";
            this.toolTip1.SetToolTip(this.btnRaiz, resources.GetString("btnRaiz.ToolTip"));
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.sqrRaiz_Click);
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Name = "btnBack";
            this.btnBack.Tag = "restroceso";
            this.toolTip1.SetToolTip(this.btnBack, resources.GetString("btnBack.ToolTip"));
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnC
            // 
            resources.ApplyResources(this.btnC, "btnC");
            this.btnC.ForeColor = System.Drawing.Color.Blue;
            this.btnC.Name = "btnC";
            this.btnC.Tag = "c";
            this.toolTip1.SetToolTip(this.btnC, resources.GetString("btnC.ToolTip"));
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            resources.ApplyResources(this.btnCE, "btnCE");
            this.btnCE.ForeColor = System.Drawing.Color.Blue;
            this.btnCE.Name = "btnCE";
            this.btnCE.Tag = "ce";
            this.toolTip1.SetToolTip(this.btnCE, resources.GetString("btnCE.ToolTip"));
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // lblOperando2
            // 
            this.lblOperando2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblOperando2, "lblOperando2");
            this.lblOperando2.ForeColor = System.Drawing.Color.Coral;
            this.lblOperando2.Name = "lblOperando2";
            // 
            // lblOperacion
            // 
            this.lblOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblOperacion, "lblOperacion");
            this.lblOperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOperacion.Name = "lblOperacion";
            // 
            // lblOperando1
            // 
            this.lblOperando1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblOperando1, "lblOperando1");
            this.lblOperando1.ForeColor = System.Drawing.Color.Coral;
            this.lblOperando1.Name = "lblOperando1";
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblResultado, "lblResultado");
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblResultado.Name = "lblResultado";
            // 
            // frmCalculadora
            // 
            this.AcceptButton = this.btnIgual;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.btnCE;
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOperando1);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.lblOperando2);
            this.Controls.Add(this.pnlBotonera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmCalculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCalculadora_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculadora_KeyPress);
            this.pnlBotonera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSigno;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnPorciento;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Label lblOperando2;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblOperando1;
        private System.Windows.Forms.Label lblResultado;
    }
}

