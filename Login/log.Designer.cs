namespace Login
{
    partial class log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.arriendoDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoYBusquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReiniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuingreso = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldoBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labFecha = new System.Windows.Forms.Label();
            this.labHora = new System.Windows.Forms.Label();
            this.labCuenta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labIntentos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuAyuda,
            this.menuAutor,
            this.menuReiniciar,
            this.menuingreso,
            this.respaldoBaseDeDatosToolStripMenuItem,
            this.menuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arriendoDeVehiculosToolStripMenuItem,
            this.listadoYBusquedaToolStripMenuItem});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "Archivo";
            // 
            // arriendoDeVehiculosToolStripMenuItem
            // 
            this.arriendoDeVehiculosToolStripMenuItem.Name = "arriendoDeVehiculosToolStripMenuItem";
            this.arriendoDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.arriendoDeVehiculosToolStripMenuItem.Text = "Arriendo de Vehiculos";
            this.arriendoDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.arriendoDeVehiculosToolStripMenuItem_Click);
            // 
            // listadoYBusquedaToolStripMenuItem
            // 
            this.listadoYBusquedaToolStripMenuItem.Name = "listadoYBusquedaToolStripMenuItem";
            this.listadoYBusquedaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.listadoYBusquedaToolStripMenuItem.Text = "Listado y Busqueda";
            this.listadoYBusquedaToolStripMenuItem.Click += new System.EventHandler(this.listadoYBusquedaToolStripMenuItem_Click);
            // 
            // menuAyuda
            // 
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Text = "Ayuda";
            this.menuAyuda.Click += new System.EventHandler(this.menuAyuda_Click);
            // 
            // menuAutor
            // 
            this.menuAutor.Name = "menuAutor";
            this.menuAutor.Size = new System.Drawing.Size(49, 20);
            this.menuAutor.Text = "Autor";
            this.menuAutor.Click += new System.EventHandler(this.menuAutor_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(41, 20);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // menuReiniciar
            // 
            this.menuReiniciar.Name = "menuReiniciar";
            this.menuReiniciar.Size = new System.Drawing.Size(101, 20);
            this.menuReiniciar.Text = "Reiniciar Sesion";
            this.menuReiniciar.Click += new System.EventHandler(this.menuReiniciar_Click);
            // 
            // menuingreso
            // 
            this.menuingreso.AccessibleName = "";
            this.menuingreso.Name = "menuingreso";
            this.menuingreso.Size = new System.Drawing.Size(142, 20);
            this.menuingreso.Text = "Ingresar Nuevo Usuario";
            this.menuingreso.Click += new System.EventHandler(this.ingresarNuevoUsuarioToolStripMenuItem_Click);
            // 
            // respaldoBaseDeDatosToolStripMenuItem
            // 
            this.respaldoBaseDeDatosToolStripMenuItem.Name = "respaldoBaseDeDatosToolStripMenuItem";
            this.respaldoBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.respaldoBaseDeDatosToolStripMenuItem.Text = "Respaldo Base De Datos";
            this.respaldoBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.respaldoBaseDeDatosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.labFecha);
            this.panel1.Controls.Add(this.labHora);
            this.panel1.Controls.Add(this.labCuenta);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labIntentos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 217);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(225, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Bienvenido";
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFecha.ForeColor = System.Drawing.Color.Black;
            this.labFecha.Location = new System.Drawing.Point(360, 184);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(70, 17);
            this.labFecha.TabIndex = 10;
            this.labFecha.Text = "00/00/00";
            // 
            // labHora
            // 
            this.labHora.AutoSize = true;
            this.labHora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHora.ForeColor = System.Drawing.Color.Black;
            this.labHora.Location = new System.Drawing.Point(124, 184);
            this.labHora.Name = "labHora";
            this.labHora.Size = new System.Drawing.Size(72, 17);
            this.labHora.TabIndex = 8;
            this.labHora.Text = "00:00:00";
            // 
            // labCuenta
            // 
            this.labCuenta.AutoSize = true;
            this.labCuenta.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCuenta.ForeColor = System.Drawing.Color.DarkBlue;
            this.labCuenta.Location = new System.Drawing.Point(300, 144);
            this.labCuenta.Name = "labCuenta";
            this.labCuenta.Size = new System.Drawing.Size(81, 20);
            this.labCuenta.TabIndex = 7;
            this.labCuenta.Text = "????????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(108, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Usuario Ingresado:";
            // 
            // labIntentos
            // 
            this.labIntentos.AutoSize = true;
            this.labIntentos.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIntentos.ForeColor = System.Drawing.Color.Firebrick;
            this.labIntentos.Location = new System.Drawing.Point(529, 63);
            this.labIntentos.MaximumSize = new System.Drawing.Size(40, 30);
            this.labIntentos.Name = "labIntentos";
            this.labIntentos.Size = new System.Drawing.Size(20, 23);
            this.labIntentos.TabIndex = 5;
            this.labIntentos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(455, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Intento Restantes";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(230, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(118, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(230, 61);
            this.txtUsuario.MaximumSize = new System.Drawing.Size(118, 25);
            this.txtUsuario.MinimumSize = new System.Drawing.Size(118, 25);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(118, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(80, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(80, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(676, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(692, 597);
            this.MinimumSize = new System.Drawing.Size(692, 597);
            this.Name = "log";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.log_FormClosing);
            this.Load += new System.EventHandler(this.log_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem arriendoDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoYBusquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem menuAutor;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem menuReiniciar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.Label labHora;
        private System.Windows.Forms.Label labCuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labIntentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem menuingreso;
        private System.Windows.Forms.ToolStripMenuItem respaldoBaseDeDatosToolStripMenuItem;
    }
}

