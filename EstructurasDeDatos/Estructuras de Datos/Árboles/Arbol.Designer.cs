
namespace EstructurasDeDatos
{
    partial class Arbol
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnPostOrden = new System.Windows.Forms.RadioButton();
            this.rbtnOrden = new System.Windows.Forms.RadioButton();
            this.rbtnPreOrden = new System.Windows.Forms.RadioButton();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Pink;
            this.btnInsertar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(12, 345);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(103, 30);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Pink;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(12, 417);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 30);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Pink;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(12, 381);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(121, 348);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 27);
            this.txtDato.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.rbtnPostOrden);
            this.groupBox1.Controls.Add(this.rbtnOrden);
            this.groupBox1.Controls.Add(this.rbtnPreOrden);
            this.groupBox1.Controls.Add(this.btnRecorrer);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(227, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECORRER";
            // 
            // rbtnPostOrden
            // 
            this.rbtnPostOrden.AutoSize = true;
            this.rbtnPostOrden.Location = new System.Drawing.Point(22, 77);
            this.rbtnPostOrden.Name = "rbtnPostOrden";
            this.rbtnPostOrden.Size = new System.Drawing.Size(137, 25);
            this.rbtnPostOrden.TabIndex = 7;
            this.rbtnPostOrden.TabStop = true;
            this.rbtnPostOrden.Text = "POST - ORDEN";
            this.rbtnPostOrden.UseVisualStyleBackColor = true;
            // 
            // rbtnOrden
            // 
            this.rbtnOrden.AutoSize = true;
            this.rbtnOrden.Location = new System.Drawing.Point(22, 26);
            this.rbtnOrden.Name = "rbtnOrden";
            this.rbtnOrden.Size = new System.Drawing.Size(85, 25);
            this.rbtnOrden.TabIndex = 5;
            this.rbtnOrden.TabStop = true;
            this.rbtnOrden.Text = "ORDEN";
            this.rbtnOrden.UseVisualStyleBackColor = true;
            // 
            // rbtnPreOrden
            // 
            this.rbtnPreOrden.AutoSize = true;
            this.rbtnPreOrden.Location = new System.Drawing.Point(22, 50);
            this.rbtnPreOrden.Name = "rbtnPreOrden";
            this.rbtnPreOrden.Size = new System.Drawing.Size(126, 25);
            this.rbtnPreOrden.TabIndex = 6;
            this.rbtnPreOrden.TabStop = true;
            this.rbtnPreOrden.Text = "PRE - ORDEN";
            this.rbtnPreOrden.UseVisualStyleBackColor = true;
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.BackColor = System.Drawing.Color.Pink;
            this.btnRecorrer.Location = new System.Drawing.Point(31, 108);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(110, 34);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "RECORRER";
            this.btnRecorrer.UseVisualStyleBackColor = false;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENCONTRAR EL MÁXIMO Y MÍNIMO";
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.BackColor = System.Drawing.Color.Pink;
            this.btnIdentificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentificar.Location = new System.Drawing.Point(419, 364);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(157, 32);
            this.btnIdentificar.TabIndex = 5;
            this.btnIdentificar.Text = "IDENTIFICAR";
            this.btnIdentificar.UseVisualStyleBackColor = false;
            this.btnIdentificar.Click += new System.EventHandler(this.btnIdentificar_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.BackColor = System.Drawing.Color.Pink;
            this.btnAltura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltura.Location = new System.Drawing.Point(419, 402);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(157, 32);
            this.btnAltura.TabIndex = 6;
            this.btnAltura.Text = "DETERMINAR ALTURA";
            this.btnAltura.UseVisualStyleBackColor = false;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Pink;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(419, 440);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(157, 32);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "CARGAR ÁRBOL";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Pink;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(419, 478);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 32);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Pink;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 452);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(103, 29);
            this.btnVolver.TabIndex = 44;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Arbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EstructurasDeDatos.Properties.Resources._2df57548baa0c244ff9ee0d1ac1364dd;
            this.ClientSize = new System.Drawing.Size(929, 516);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnIdentificar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Arbol";
            this.Text = "Arbol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Arbol_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Arbol_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnPostOrden;
        private System.Windows.Forms.RadioButton rbtnOrden;
        private System.Windows.Forms.RadioButton rbtnPreOrden;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIdentificar;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
    }
}