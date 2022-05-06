namespace sistemaRestaurante.vistas
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteFrecuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agragarClienteFrecuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteFrecuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribucionDeLasMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenDeIngredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proximasActualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtCocina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.administrarMesasToolStripMenuItem,
            this.ordenesToolStripMenuItem,
            this.administrarProductosToolStripMenuItem,
            this.proximasActualizacionesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarUsuariosToolStripMenuItem,
            this.agregarClienteFrecuenteToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            this.administrarUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            this.administrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.administrarUsuariosToolStripMenuItem.Text = "Administrar usuarios";
            this.administrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.administrarUsuariosToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.borrarToolStripMenuItem.Text = "borrar";
            this.borrarToolStripMenuItem.Visible = false;
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // agregarClienteFrecuenteToolStripMenuItem
            // 
            this.agregarClienteFrecuenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agragarClienteFrecuenteToolStripMenuItem,
            this.eliminarClienteFrecuenteToolStripMenuItem});
            this.agregarClienteFrecuenteToolStripMenuItem.Name = "agregarClienteFrecuenteToolStripMenuItem";
            this.agregarClienteFrecuenteToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.agregarClienteFrecuenteToolStripMenuItem.Text = "Clientes Frecuentes";
            this.agregarClienteFrecuenteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteFrecuenteToolStripMenuItem_Click);
            // 
            // agragarClienteFrecuenteToolStripMenuItem
            // 
            this.agragarClienteFrecuenteToolStripMenuItem.Name = "agragarClienteFrecuenteToolStripMenuItem";
            this.agragarClienteFrecuenteToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.agragarClienteFrecuenteToolStripMenuItem.Text = "Agregar Cliente Frecuente";
            this.agragarClienteFrecuenteToolStripMenuItem.Click += new System.EventHandler(this.agragarClienteFrecuenteToolStripMenuItem_Click);
            // 
            // eliminarClienteFrecuenteToolStripMenuItem
            // 
            this.eliminarClienteFrecuenteToolStripMenuItem.Name = "eliminarClienteFrecuenteToolStripMenuItem";
            this.eliminarClienteFrecuenteToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.eliminarClienteFrecuenteToolStripMenuItem.Text = "eliminar Cliente Frecuente";
            this.eliminarClienteFrecuenteToolStripMenuItem.Visible = false;
            this.eliminarClienteFrecuenteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteFrecuenteToolStripMenuItem_Click);
            // 
            // administrarMesasToolStripMenuItem
            // 
            this.administrarMesasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distribucionDeLasMesasToolStripMenuItem});
            this.administrarMesasToolStripMenuItem.Name = "administrarMesasToolStripMenuItem";
            this.administrarMesasToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.administrarMesasToolStripMenuItem.Text = "Barras y Mesas";
            // 
            // distribucionDeLasMesasToolStripMenuItem
            // 
            this.distribucionDeLasMesasToolStripMenuItem.Name = "distribucionDeLasMesasToolStripMenuItem";
            this.distribucionDeLasMesasToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.distribucionDeLasMesasToolStripMenuItem.Text = "Distribucion de las Mesas";
            this.distribucionDeLasMesasToolStripMenuItem.Click += new System.EventHandler(this.distribucionDeLasMesasToolStripMenuItem_Click);
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarToolStripMenuItem});
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.ordenarToolStripMenuItem.Text = "Ordenar";
            this.ordenarToolStripMenuItem.Click += new System.EventHandler(this.ordenarToolStripMenuItem_Click);
            // 
            // administrarProductosToolStripMenuItem
            // 
            this.administrarProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.almacenDeIngredientesToolStripMenuItem});
            this.administrarProductosToolStripMenuItem.Name = "administrarProductosToolStripMenuItem";
            this.administrarProductosToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.administrarProductosToolStripMenuItem.Text = "Administrar Productos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // almacenDeIngredientesToolStripMenuItem
            // 
            this.almacenDeIngredientesToolStripMenuItem.Name = "almacenDeIngredientesToolStripMenuItem";
            this.almacenDeIngredientesToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.almacenDeIngredientesToolStripMenuItem.Text = "Almacen de ingredientesFaseBeta";
            this.almacenDeIngredientesToolStripMenuItem.Click += new System.EventHandler(this.almacenDeIngredientesToolStripMenuItem_Click);
            // 
            // proximasActualizacionesToolStripMenuItem
            // 
            this.proximasActualizacionesToolStripMenuItem.Checked = true;
            this.proximasActualizacionesToolStripMenuItem.CheckOnClick = true;
            this.proximasActualizacionesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.proximasActualizacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comandaToolStripMenuItem,
            this.ingredientesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.proximasActualizacionesToolStripMenuItem.Name = "proximasActualizacionesToolStripMenuItem";
            this.proximasActualizacionesToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.proximasActualizacionesToolStripMenuItem.Text = "Proximas Actualizaciones";
            // 
            // comandaToolStripMenuItem
            // 
            this.comandaToolStripMenuItem.Name = "comandaToolStripMenuItem";
            this.comandaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.comandaToolStripMenuItem.Text = "Comanda";
            // 
            // ingredientesToolStripMenuItem
            // 
            this.ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            this.ingredientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ingredientesToolStripMenuItem.Text = "Ingredientes";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // TxtCocina
            // 
            this.TxtCocina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCocina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCocina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCocina.Location = new System.Drawing.Point(606, 104);
            this.TxtCocina.Multiline = true;
            this.TxtCocina.Name = "TxtCocina";
            this.TxtCocina.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtCocina.Size = new System.Drawing.Size(246, 98);
            this.TxtCocina.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(602, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enviar Mensaje a la cocina";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnviar.Location = new System.Drawing.Point(689, 228);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(93, 33);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 474);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCocina);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal Restaurante";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteFrecuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agragarClienteFrecuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteFrecuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribucionDeLasMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenDeIngredientesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox TxtCocina;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ToolStripMenuItem proximasActualizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}