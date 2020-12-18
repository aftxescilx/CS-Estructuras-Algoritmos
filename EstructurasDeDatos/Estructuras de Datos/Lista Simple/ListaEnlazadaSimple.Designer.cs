
namespace EstructurasDeDatos
{
    partial class ListaEnlazadaSimple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEliminarLista = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarNodo = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(162, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(266, 30);
            this.lblTitulo.TabIndex = 35;
            this.lblTitulo.Text = "Lista Enlazada Simple";
            // 
            // btnEliminarLista
            // 
            this.btnEliminarLista.BackColor = System.Drawing.Color.Pink;
            this.btnEliminarLista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLista.Location = new System.Drawing.Point(131, 256);
            this.btnEliminarLista.Name = "btnEliminarLista";
            this.btnEliminarLista.Size = new System.Drawing.Size(89, 53);
            this.btnEliminarLista.TabIndex = 34;
            this.btnEliminarLista.Text = "Eliminar lista";
            this.btnEliminarLista.UseVisualStyleBackColor = false;
            this.btnEliminarLista.Click += new System.EventHandler(this.btnEliminarLista_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Pink;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(131, 220);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(89, 30);
            this.btnCargar.TabIndex = 33;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.BackColor = System.Drawing.Color.Pink;
            this.btnGuardarArchivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarArchivo.Location = new System.Drawing.Point(131, 163);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(89, 51);
            this.btnGuardarArchivo.TabIndex = 32;
            this.btnGuardarArchivo.Text = "Guardar Archivo";
            this.btnGuardarArchivo.UseVisualStyleBackColor = false;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // btnContar
            // 
            this.btnContar.BackColor = System.Drawing.Color.Pink;
            this.btnContar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(131, 126);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(89, 30);
            this.btnContar.TabIndex = 29;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = false;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminar.Location = new System.Drawing.Point(11, 93);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(114, 26);
            this.txtEliminar.TabIndex = 28;
            // 
            // btnEliminarNodo
            // 
            this.btnEliminarNodo.BackColor = System.Drawing.Color.Pink;
            this.btnEliminarNodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarNodo.Location = new System.Drawing.Point(131, 90);
            this.btnEliminarNodo.Name = "btnEliminarNodo";
            this.btnEliminarNodo.Size = new System.Drawing.Size(89, 30);
            this.btnEliminarNodo.TabIndex = 27;
            this.btnEliminarNodo.Text = "Eliminar dato";
            this.btnEliminarNodo.UseVisualStyleBackColor = false;
            this.btnEliminarNodo.Click += new System.EventHandler(this.btnEliminarNodo_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.BackColor = System.Drawing.Color.White;
            this.lblLista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(231, 57);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(14, 20);
            this.lblLista.TabIndex = 26;
            this.lblLista.Text = "-";
            // 
            // txtNodo
            // 
            this.txtNodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodo.Location = new System.Drawing.Point(11, 56);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(114, 26);
            this.txtNodo.TabIndex = 25;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Pink;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(131, 54);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 30);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ListaEnlazadaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EstructurasDeDatos.Properties.Resources._2df57548baa0c244ff9ee0d1ac1364dd;
            this.ClientSize = new System.Drawing.Size(577, 365);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEliminarLista);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardarArchivo);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnEliminarNodo);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.btnGuardar);
            this.Name = "ListaEnlazadaSimple";
            this.Text = "ListaEnlazadaSimple";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListaEnlazadaSimple_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEliminarLista;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardarArchivo;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnEliminarNodo;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnGuardar;
    }
}