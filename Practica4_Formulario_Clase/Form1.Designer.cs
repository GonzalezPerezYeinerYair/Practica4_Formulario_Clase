namespace Practica4_Formulario_Clase
{
    partial class ventana
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
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_apellidos = new System.Windows.Forms.Label();
            this.lb_telefono = new System.Windows.Forms.Label();
            this.lb_estatura = new System.Windows.Forms.Label();
            this.lb_edad = new System.Windows.Forms.Label();
            this.gbx_genero = new System.Windows.Forms.GroupBox();
            this.rb_mujer = new System.Windows.Forms.RadioButton();
            this.rb_hombre = new System.Windows.Forms.RadioButton();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellidos = new System.Windows.Forms.TextBox();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.tb_estatura = new System.Windows.Forms.TextBox();
            this.tb_edad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbx_genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(58, 25);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(44, 13);
            this.lb_nombre.TabIndex = 0;
            this.lb_nombre.Text = "Nombre";
            this.lb_nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_apellidos
            // 
            this.lb_apellidos.AutoSize = true;
            this.lb_apellidos.Location = new System.Drawing.Point(58, 62);
            this.lb_apellidos.Name = "lb_apellidos";
            this.lb_apellidos.Size = new System.Drawing.Size(49, 13);
            this.lb_apellidos.TabIndex = 1;
            this.lb_apellidos.Text = "Apellidos";
            // 
            // lb_telefono
            // 
            this.lb_telefono.AutoSize = true;
            this.lb_telefono.Location = new System.Drawing.Point(58, 98);
            this.lb_telefono.Name = "lb_telefono";
            this.lb_telefono.Size = new System.Drawing.Size(45, 13);
            this.lb_telefono.TabIndex = 2;
            this.lb_telefono.Text = "telefono";
            this.lb_telefono.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_estatura
            // 
            this.lb_estatura.AutoSize = true;
            this.lb_estatura.Location = new System.Drawing.Point(58, 130);
            this.lb_estatura.Name = "lb_estatura";
            this.lb_estatura.Size = new System.Drawing.Size(46, 13);
            this.lb_estatura.TabIndex = 3;
            this.lb_estatura.Text = "Estatura";
            // 
            // lb_edad
            // 
            this.lb_edad.AutoSize = true;
            this.lb_edad.Location = new System.Drawing.Point(58, 169);
            this.lb_edad.Name = "lb_edad";
            this.lb_edad.Size = new System.Drawing.Size(32, 13);
            this.lb_edad.TabIndex = 4;
            this.lb_edad.Text = "Edad";
            // 
            // gbx_genero
            // 
            this.gbx_genero.Controls.Add(this.rb_mujer);
            this.gbx_genero.Controls.Add(this.rb_hombre);
            this.gbx_genero.Location = new System.Drawing.Point(61, 251);
            this.gbx_genero.Name = "gbx_genero";
            this.gbx_genero.Size = new System.Drawing.Size(200, 103);
            this.gbx_genero.TabIndex = 6;
            this.gbx_genero.TabStop = false;
            this.gbx_genero.Text = "Genero:";
            // 
            // rb_mujer
            // 
            this.rb_mujer.AutoSize = true;
            this.rb_mujer.Location = new System.Drawing.Point(97, 38);
            this.rb_mujer.Name = "rb_mujer";
            this.rb_mujer.Size = new System.Drawing.Size(51, 17);
            this.rb_mujer.TabIndex = 3;
            this.rb_mujer.TabStop = true;
            this.rb_mujer.Text = "Mujer";
            this.rb_mujer.UseVisualStyleBackColor = true;
            this.rb_mujer.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_hombre
            // 
            this.rb_hombre.AutoSize = true;
            this.rb_hombre.Location = new System.Drawing.Point(6, 38);
            this.rb_hombre.Name = "rb_hombre";
            this.rb_hombre.Size = new System.Drawing.Size(62, 17);
            this.rb_hombre.TabIndex = 2;
            this.rb_hombre.TabStop = true;
            this.rb_hombre.Text = "Hombre";
            this.rb_hombre.UseVisualStyleBackColor = true;
            this.rb_hombre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(100, 25);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_nombre.TabIndex = 7;
            // 
            // tb_apellidos
            // 
            this.tb_apellidos.Location = new System.Drawing.Point(99, 59);
            this.tb_apellidos.Name = "tb_apellidos";
            this.tb_apellidos.Size = new System.Drawing.Size(100, 20);
            this.tb_apellidos.TabIndex = 8;
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(99, 98);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(100, 20);
            this.tb_telefono.TabIndex = 9;
            // 
            // tb_estatura
            // 
            this.tb_estatura.Location = new System.Drawing.Point(100, 130);
            this.tb_estatura.Name = "tb_estatura";
            this.tb_estatura.Size = new System.Drawing.Size(100, 20);
            this.tb_estatura.TabIndex = 10;
            // 
            // tb_edad
            // 
            this.tb_edad.Location = new System.Drawing.Point(99, 166);
            this.tb_edad.Name = "tb_edad";
            this.tb_edad.Size = new System.Drawing.Size(100, 20);
            this.tb_edad.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_guardar);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_cancelar);
            // 
            // ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_edad);
            this.Controls.Add(this.tb_estatura);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_apellidos);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.gbx_genero);
            this.Controls.Add(this.lb_edad);
            this.Controls.Add(this.lb_estatura);
            this.Controls.Add(this.lb_telefono);
            this.Controls.Add(this.lb_apellidos);
            this.Controls.Add(this.lb_nombre);
            this.Name = "ventana";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_genero.ResumeLayout(false);
            this.gbx_genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_apellidos;
        private System.Windows.Forms.Label lb_telefono;
        private System.Windows.Forms.Label lb_estatura;
        private System.Windows.Forms.Label lb_edad;
        private System.Windows.Forms.GroupBox gbx_genero;
        private System.Windows.Forms.RadioButton rb_hombre;
        private System.Windows.Forms.RadioButton rb_mujer;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_apellidos;
        private System.Windows.Forms.TextBox tb_telefono;
        private System.Windows.Forms.TextBox tb_estatura;
        private System.Windows.Forms.TextBox tb_edad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

