namespace sistemaRestaurante.vistas
{
    partial class frmOrden
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwOrden = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgwMenu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalOrden = new System.Windows.Forms.TextBox();
            this.btnHacerOrden = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrden)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgwOrden);
            this.panel1.Location = new System.Drawing.Point(915, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 332);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgwOrden
            // 
            this.dgwOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrden.Location = new System.Drawing.Point(4, 18);
            this.dgwOrden.Margin = new System.Windows.Forms.Padding(4);
            this.dgwOrden.Name = "dgwOrden";
            this.dgwOrden.RowHeadersWidth = 51;
            this.dgwOrden.Size = new System.Drawing.Size(557, 282);
            this.dgwOrden.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgwMenu);
            this.panel3.Location = new System.Drawing.Point(26, 39);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 332);
            this.panel3.TabIndex = 2;
            // 
            // dgwMenu
            // 
            this.dgwMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMenu.Location = new System.Drawing.Point(22, 24);
            this.dgwMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgwMenu.Name = "dgwMenu";
            this.dgwMenu.RowHeadersWidth = 51;
            this.dgwMenu.Size = new System.Drawing.Size(601, 282);
            this.dgwMenu.TabIndex = 3;
            this.dgwMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMenu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1155, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monto Total";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(683, 64);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(160, 24);
            this.cbCategoria.TabIndex = 5;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria";
            // 
            // txtTotalOrden
            // 
            this.txtTotalOrden.Enabled = false;
            this.txtTotalOrden.Location = new System.Drawing.Point(1271, 380);
            this.txtTotalOrden.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalOrden.Name = "txtTotalOrden";
            this.txtTotalOrden.Size = new System.Drawing.Size(189, 22);
            this.txtTotalOrden.TabIndex = 7;
            // 
            // btnHacerOrden
            // 
            this.btnHacerOrden.BackColor = System.Drawing.Color.DarkBlue;
            this.btnHacerOrden.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHacerOrden.Location = new System.Drawing.Point(683, 403);
            this.btnHacerOrden.Margin = new System.Windows.Forms.Padding(4);
            this.btnHacerOrden.Name = "btnHacerOrden";
            this.btnHacerOrden.Size = new System.Drawing.Size(135, 59);
            this.btnHacerOrden.TabIndex = 8;
            this.btnHacerOrden.Text = "Hacer Orden";
            this.btnHacerOrden.UseVisualStyleBackColor = false;
            this.btnHacerOrden.Click += new System.EventHandler(this.btnHacerOrden_Click);
            // 
            // frmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 501);
            this.Controls.Add(this.btnHacerOrden);
            this.Controls.Add(this.txtTotalOrden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrden";
            this.Text = "Gestion Ordenes";
            this.Load += new System.EventHandler(this.Orden_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrden)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwOrden;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgwMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalOrden;
        private System.Windows.Forms.Button btnHacerOrden;
    }
}