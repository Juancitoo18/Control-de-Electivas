
namespace Control_Electivas
{
    partial class ControldeElectivas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControldeElectivas));
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnVencimientos = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMateriasVencidas = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblkCambiar = new System.Windows.Forms.LinkLabel();
            this.btnBaja2 = new System.Windows.Forms.Button();
            this.btnActualizarFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMaterias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(10, 25);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(857, 281);
            this.dgvMaterias.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(10, 322);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 26);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(93, 322);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 26);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBaja.Location = new System.Drawing.Point(175, 322);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(77, 26);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnVencimientos
            // 
            this.btnVencimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVencimientos.Location = new System.Drawing.Point(722, 322);
            this.btnVencimientos.Name = "btnVencimientos";
            this.btnVencimientos.Size = new System.Drawing.Size(144, 26);
            this.btnVencimientos.TabIndex = 4;
            this.btnVencimientos.Text = "Ver Proximos Vencimientos";
            this.btnVencimientos.UseVisualStyleBackColor = true;
            this.btnVencimientos.Click += new System.EventHandler(this.btnVencimientos_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.Location = new System.Drawing.Point(10, 322);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 26);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMateriasVencidas
            // 
            this.btnMateriasVencidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMateriasVencidas.Location = new System.Drawing.Point(722, 322);
            this.btnMateriasVencidas.Name = "btnMateriasVencidas";
            this.btnMateriasVencidas.Size = new System.Drawing.Size(144, 26);
            this.btnMateriasVencidas.TabIndex = 6;
            this.btnMateriasVencidas.Text = "Ver Materias Vencidas";
            this.btnMateriasVencidas.UseVisualStyleBackColor = true;
            this.btnMateriasVencidas.Visible = false;
            this.btnMateriasVencidas.Click += new System.EventHandler(this.btnMateriasVencidas_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(344, -2);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(177, 24);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Materias Electivas";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(13, 8);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 8;
            // 
            // lblkCambiar
            // 
            this.lblkCambiar.AutoSize = true;
            this.lblkCambiar.LinkColor = System.Drawing.Color.Black;
            this.lblkCambiar.Location = new System.Drawing.Point(766, 9);
            this.lblkCambiar.Name = "lblkCambiar";
            this.lblkCambiar.Size = new System.Drawing.Size(101, 13);
            this.lblkCambiar.TabIndex = 9;
            this.lblkCambiar.TabStop = true;
            this.lblkCambiar.Text = "Cambiar contraseña";
            this.lblkCambiar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkCambiar_LinkClicked);
            // 
            // btnBaja2
            // 
            this.btnBaja2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBaja2.Location = new System.Drawing.Point(678, 322);
            this.btnBaja2.Name = "btnBaja2";
            this.btnBaja2.Size = new System.Drawing.Size(77, 26);
            this.btnBaja2.TabIndex = 10;
            this.btnBaja2.Text = "Dar de Baja";
            this.btnBaja2.UseVisualStyleBackColor = true;
            this.btnBaja2.Visible = false;
            this.btnBaja2.Click += new System.EventHandler(this.btnBaja2_Click);
            // 
            // btnActualizarFecha
            // 
            this.btnActualizarFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizarFecha.Location = new System.Drawing.Point(769, 322);
            this.btnActualizarFecha.Name = "btnActualizarFecha";
            this.btnActualizarFecha.Size = new System.Drawing.Size(97, 26);
            this.btnActualizarFecha.TabIndex = 11;
            this.btnActualizarFecha.Text = "Actualizar Fecha ";
            this.btnActualizarFecha.UseVisualStyleBackColor = true;
            this.btnActualizarFecha.Visible = false;
            this.btnActualizarFecha.Click += new System.EventHandler(this.btnActualizarFecha_Click);
            // 
            // ControldeElectivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 366);
            this.Controls.Add(this.btnActualizarFecha);
            this.Controls.Add(this.btnBaja2);
            this.Controls.Add(this.lblkCambiar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnMateriasVencidas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnVencimientos);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvMaterias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControldeElectivas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Materias Electivas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControldeElectivas_FormClosing);
            this.Load += new System.EventHandler(this.ControldeElectivas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnVencimientos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnMateriasVencidas;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.LinkLabel lblkCambiar;
        private System.Windows.Forms.Button btnBaja2;
        private System.Windows.Forms.Button btnActualizarFecha;
    }
}