
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistroMateriasElectivas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDardeBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmActualizarFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDardeBaja2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMateriasPorVencer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMateriasVencidas = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCambiarContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFiltro = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMaterias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(10, 25);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(857, 291);
            this.dgvMaterias.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.Location = new System.Drawing.Point(12, 322);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 26);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMenu
            // 
            this.tsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegistroMateriasElectivas,
            this.listadosToolStripMenuItem,
            this.tsmFiltro});
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(50, 20);
            this.tsMenu.Text = "Menu";
            // 
            // tsmRegistroMateriasElectivas
            // 
            this.tsmRegistroMateriasElectivas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregar,
            this.tsmEditar,
            this.tsmDardeBaja,
            this.tsmActualizarFecha,
            this.tsmDardeBaja2});
            this.tsmRegistroMateriasElectivas.Name = "tsmRegistroMateriasElectivas";
            this.tsmRegistroMateriasElectivas.Size = new System.Drawing.Size(180, 22);
            this.tsmRegistroMateriasElectivas.Text = "Registro";
            // 
            // tsmAgregar
            // 
            this.tsmAgregar.Name = "tsmAgregar";
            this.tsmAgregar.Size = new System.Drawing.Size(160, 22);
            this.tsmAgregar.Text = "Agregar";
            this.tsmAgregar.Click += new System.EventHandler(this.tsmAgregar_Click);
            // 
            // tsmEditar
            // 
            this.tsmEditar.Name = "tsmEditar";
            this.tsmEditar.Size = new System.Drawing.Size(160, 22);
            this.tsmEditar.Text = "Editar";
            this.tsmEditar.Click += new System.EventHandler(this.tsmEditar_Click);
            // 
            // tsmDardeBaja
            // 
            this.tsmDardeBaja.Name = "tsmDardeBaja";
            this.tsmDardeBaja.Size = new System.Drawing.Size(160, 22);
            this.tsmDardeBaja.Text = "Dar de Baja";
            this.tsmDardeBaja.Click += new System.EventHandler(this.tsmDardeBaja_Click);
            // 
            // tsmActualizarFecha
            // 
            this.tsmActualizarFecha.Name = "tsmActualizarFecha";
            this.tsmActualizarFecha.Size = new System.Drawing.Size(160, 22);
            this.tsmActualizarFecha.Text = "Actualizar Fecha";
            this.tsmActualizarFecha.Visible = false;
            this.tsmActualizarFecha.Click += new System.EventHandler(this.tsmActualizarFecha_Click);
            // 
            // tsmDardeBaja2
            // 
            this.tsmDardeBaja2.Name = "tsmDardeBaja2";
            this.tsmDardeBaja2.Size = new System.Drawing.Size(160, 22);
            this.tsmDardeBaja2.Text = "Dar de Baja";
            this.tsmDardeBaja2.Visible = false;
            this.tsmDardeBaja2.Click += new System.EventHandler(this.tsmDardeBaja2_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMateriasPorVencer,
            this.tsmMateriasVencidas});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // tsmMateriasPorVencer
            // 
            this.tsmMateriasPorVencer.Name = "tsmMateriasPorVencer";
            this.tsmMateriasPorVencer.Size = new System.Drawing.Size(178, 22);
            this.tsmMateriasPorVencer.Text = "Materias Por Vencer";
            this.tsmMateriasPorVencer.Click += new System.EventHandler(this.tsmMateriasPorVencer_Click);
            // 
            // tsmMateriasVencidas
            // 
            this.tsmMateriasVencidas.Name = "tsmMateriasVencidas";
            this.tsmMateriasVencidas.Size = new System.Drawing.Size(178, 22);
            this.tsmMateriasVencidas.Text = "Materias Vencidas";
            this.tsmMateriasVencidas.Click += new System.EventHandler(this.tsmMateriasVencidas_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCambiarContraseña,
            this.tsmCerrarSesion});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // tsmCambiarContraseña
            // 
            this.tsmCambiarContraseña.Name = "tsmCambiarContraseña";
            this.tsmCambiarContraseña.Size = new System.Drawing.Size(182, 22);
            this.tsmCambiarContraseña.Text = "Cambiar Contraseña";
            this.tsmCambiarContraseña.Click += new System.EventHandler(this.tsmCambiarContraseña_Click);
            // 
            // tsmCerrarSesion
            // 
            this.tsmCerrarSesion.Name = "tsmCerrarSesion";
            this.tsmCerrarSesion.Size = new System.Drawing.Size(182, 22);
            this.tsmCerrarSesion.Text = "Cerrar Sesion";
            this.tsmCerrarSesion.Click += new System.EventHandler(this.tsmCerrarSesion_Click);
            // 
            // tsmFiltro
            // 
            this.tsmFiltro.Name = "tsmFiltro";
            this.tsmFiltro.Size = new System.Drawing.Size(180, 22);
            this.tsmFiltro.Text = "Filtro";
            this.tsmFiltro.Click += new System.EventHandler(this.tsmFiltro_Click);
            // 
            // ControldeElectivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 366);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControldeElectivas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Materias Electivas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControldeElectivas_FormClosing);
            this.Load += new System.EventHandler(this.ControldeElectivas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistroMateriasElectivas;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregar;
        private System.Windows.Forms.ToolStripMenuItem tsmEditar;
        private System.Windows.Forms.ToolStripMenuItem tsmDardeBaja;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmMateriasPorVencer;
        private System.Windows.Forms.ToolStripMenuItem tsmMateriasVencidas;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizarFecha;
        private System.Windows.Forms.ToolStripMenuItem tsmDardeBaja2;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCambiarContraseña;
        private System.Windows.Forms.ToolStripMenuItem tsmCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmFiltro;
    }
}