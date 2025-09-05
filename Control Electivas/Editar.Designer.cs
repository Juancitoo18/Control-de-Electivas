
namespace Control_Electivas
{
    partial class Editar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.TextBox txtResolucion;
        private System.Windows.Forms.Label lblAprobacion;
        private System.Windows.Forms.DateTimePicker dtpAprobacion;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.txtResolucion = new System.Windows.Forms.TextBox();
            this.lblAprobacion = new System.Windows.Forms.Label();
            this.dtpAprobacion = new System.Windows.Forms.DateTimePicker();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(20, 60);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(44, 13);
            this.lblCarrera.TabIndex = 2;
            this.lblCarrera.Text = "Carrera:";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.Location = new System.Drawing.Point(150, 60);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(200, 21);
            this.cmbCarrera.TabIndex = 3;
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.Location = new System.Drawing.Point(20, 100);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(103, 13);
            this.lblResolucion.TabIndex = 4;
            this.lblResolucion.Text = "Número Resolución:";
            // 
            // txtResolucion
            // 
            this.txtResolucion.Location = new System.Drawing.Point(150, 100);
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.Size = new System.Drawing.Size(200, 20);
            this.txtResolucion.TabIndex = 5;
            // 
            // lblAprobacion
            // 
            this.lblAprobacion.AutoSize = true;
            this.lblAprobacion.Location = new System.Drawing.Point(20, 140);
            this.lblAprobacion.Name = "lblAprobacion";
            this.lblAprobacion.Size = new System.Drawing.Size(97, 13);
            this.lblAprobacion.TabIndex = 6;
            this.lblAprobacion.Text = "Fecha Aprobación:";
            // 
            // dtpAprobacion
            // 
            this.dtpAprobacion.Location = new System.Drawing.Point(150, 140);
            this.dtpAprobacion.Name = "dtpAprobacion";
            this.dtpAprobacion.Size = new System.Drawing.Size(200, 20);
            this.dtpAprobacion.TabIndex = 7;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(20, 180);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(101, 13);
            this.lblVencimiento.TabIndex = 8;
            this.lblVencimiento.Text = "Fecha Vencimiento:";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(150, 180);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpVencimiento.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(150, 287);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(260, 287);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(20, 216);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 12;
            this.lblDesde.Text = "Desde:";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(150, 216);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(200, 20);
            this.txtDesde.TabIndex = 13;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(20, 252);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 14;
            this.lblHasta.Text = "Hasta:";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(150, 252);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(200, 20);
            this.txtHasta.TabIndex = 15;
            // 
            // Editar
            // 
            this.ClientSize = new System.Drawing.Size(400, 349);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.lblResolucion);
            this.Controls.Add(this.txtResolucion);
            this.Controls.Add(this.lblAprobacion);
            this.Controls.Add(this.dtpAprobacion);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtHasta;
    }

    #endregion
}
