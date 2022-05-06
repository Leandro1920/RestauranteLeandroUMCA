namespace sistemaRestaurante.vistas
{
    partial class productosEingredientes
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPRODUCTOS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgwIngredientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblm = new System.Windows.Forms.Label();
            this.dgwProducto = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblProdut = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIngredientes)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregar.Location = new System.Drawing.Point(1111, 508);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 59);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Listo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Agregar Ingredientes al Producto";
            // 
            // cbPRODUCTOS
            // 
            this.cbPRODUCTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPRODUCTOS.FormattingEnabled = true;
            this.cbPRODUCTOS.Location = new System.Drawing.Point(521, 65);
            this.cbPRODUCTOS.Margin = new System.Windows.Forms.Padding(4);
            this.cbPRODUCTOS.Name = "cbPRODUCTOS";
            this.cbPRODUCTOS.Size = new System.Drawing.Size(160, 30);
            this.cbPRODUCTOS.TabIndex = 13;
            this.cbPRODUCTOS.SelectedIndexChanged += new System.EventHandler(this.cbPRODUCTOS_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seleccione el producto que necesita ingredientes.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarProductoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrarProductoToolStripMenuItem
            // 
            this.administrarProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.detalleProductosToolStripMenuItem});
            this.administrarProductoToolStripMenuItem.Name = "administrarProductoToolStripMenuItem";
            this.administrarProductoToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.administrarProductoToolStripMenuItem.Text = "Mantenimiento Producto";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // detalleProductosToolStripMenuItem
            // 
            this.detalleProductosToolStripMenuItem.Name = "detalleProductosToolStripMenuItem";
            this.detalleProductosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.detalleProductosToolStripMenuItem.Text = "DetalleProductos";
            this.detalleProductosToolStripMenuItem.Visible = false;
            this.detalleProductosToolStripMenuItem.Click += new System.EventHandler(this.detalleProductosToolStripMenuItem_Click);
            // 
            // dgwIngredientes
            // 
            this.dgwIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIngredientes.Location = new System.Drawing.Point(33, 20);
            this.dgwIngredientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgwIngredientes.Name = "dgwIngredientes";
            this.dgwIngredientes.RowHeadersWidth = 51;
            this.dgwIngredientes.Size = new System.Drawing.Size(479, 282);
            this.dgwIngredientes.TabIndex = 3;
            this.dgwIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwIngredientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Agregue los ingredientes que necesita el produto";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dgwIngredientes);
            this.panel3.Location = new System.Drawing.Point(61, 169);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 332);
            this.panel3.TabIndex = 10;
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Location = new System.Drawing.Point(725, 551);
            this.lblm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(151, 16);
            this.lblm.TabIndex = 21;
            this.lblm.Text = "                                                ";
            // 
            // dgwProducto
            // 
            this.dgwProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducto.Location = new System.Drawing.Point(43, 20);
            this.dgwProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dgwProducto.Name = "dgwProducto";
            this.dgwProducto.RowHeadersWidth = 51;
            this.dgwProducto.Size = new System.Drawing.Size(421, 282);
            this.dgwProducto.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgwProducto);
            this.panel1.Location = new System.Drawing.Point(729, 169);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 332);
            this.panel1.TabIndex = 17;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(801, 98);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(348, 22);
            this.lblProducto.TabIndex = 18;
            this.lblProducto.Text = "Vista de los ingredientes del producto";
            // 
            // lblProdut
            // 
            this.lblProdut.AutoSize = true;
            this.lblProdut.Location = new System.Drawing.Point(1038, 138);
            this.lblProdut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdut.Name = "lblProdut";
            this.lblProdut.Size = new System.Drawing.Size(178, 16);
            this.lblProdut.TabIndex = 19;
            this.lblProdut.Text = ":                                                        ";
            this.lblProdut.Click += new System.EventHandler(this.lblProdut_Click);
            // 
            // productosEingredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 603);
            this.Controls.Add(this.lblm);
            this.Controls.Add(this.lblProdut);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPRODUCTOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "productosEingredientes";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.productosEingredientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIngredientes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPRODUCTOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleProductosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgwIngredientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.DataGridView dgwProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblProdut;
    }
}