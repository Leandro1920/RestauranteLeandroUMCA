namespace sistemaRestaurante.vistas
{
    partial class frmTipoOrden
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
            this.btnListo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbresponsable = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescricion = new System.Windows.Forms.TextBox();
            this.btnListo2 = new System.Windows.Forms.Button();
            this.cbAtendio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbcliebtellevar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btlOpcion1 = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnListo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbMesa);
            this.panel1.Controls.Add(this.cbCliente);
            this.panel1.Controls.Add(this.cbresponsable);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(16, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 329);
            this.panel1.TabIndex = 0;
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.DarkBlue;
            this.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListo.Location = new System.Drawing.Point(252, 258);
            this.btnListo.Margin = new System.Windows.Forms.Padding(4);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(100, 49);
            this.btnListo.TabIndex = 22;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = false;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mesa Disponible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mesero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cliente";
            // 
            // cbMesa
            // 
            this.cbMesa.FormattingEnabled = true;
            this.cbMesa.Location = new System.Drawing.Point(191, 185);
            this.cbMesa.Margin = new System.Windows.Forms.Padding(4);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(160, 24);
            this.cbMesa.TabIndex = 3;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(191, 9);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(160, 24);
            this.cbCliente.TabIndex = 2;
            // 
            // cbresponsable
            // 
            this.cbresponsable.FormattingEnabled = true;
            this.cbresponsable.Location = new System.Drawing.Point(191, 85);
            this.cbresponsable.Margin = new System.Windows.Forms.Padding(4);
            this.cbresponsable.Name = "cbresponsable";
            this.cbresponsable.Size = new System.Drawing.Size(160, 24);
            this.cbresponsable.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtDescricion);
            this.panel2.Controls.Add(this.btnListo2);
            this.panel2.Controls.Add(this.cbAtendio);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbcliebtellevar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(477, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 329);
            this.panel2.TabIndex = 1;
            // 
            // txtDescricion
            // 
            this.txtDescricion.Location = new System.Drawing.Point(171, 186);
            this.txtDescricion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricion.Name = "txtDescricion";
            this.txtDescricion.Size = new System.Drawing.Size(192, 22);
            this.txtDescricion.TabIndex = 30;
            // 
            // btnListo2
            // 
            this.btnListo2.BackColor = System.Drawing.Color.DarkBlue;
            this.btnListo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListo2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListo2.Location = new System.Drawing.Point(264, 258);
            this.btnListo2.Margin = new System.Windows.Forms.Padding(4);
            this.btnListo2.Name = "btnListo2";
            this.btnListo2.Size = new System.Drawing.Size(100, 49);
            this.btnListo2.TabIndex = 29;
            this.btnListo2.Text = "Listo";
            this.btnListo2.UseVisualStyleBackColor = false;
            this.btnListo2.Click += new System.EventHandler(this.btnListo2_Click);
            // 
            // cbAtendio
            // 
            this.cbAtendio.FormattingEnabled = true;
            this.cbAtendio.Location = new System.Drawing.Point(171, 85);
            this.cbAtendio.Margin = new System.Windows.Forms.Padding(4);
            this.cbAtendio.Name = "cbAtendio";
            this.cbAtendio.Size = new System.Drawing.Size(192, 24);
            this.cbAtendio.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Descripcion";
            // 
            // cbcliebtellevar
            // 
            this.cbcliebtellevar.FormattingEnabled = true;
            this.cbcliebtellevar.Location = new System.Drawing.Point(171, 9);
            this.cbcliebtellevar.Margin = new System.Windows.Forms.Padding(4);
            this.cbcliebtellevar.Name = "cbcliebtellevar";
            this.cbcliebtellevar.Size = new System.Drawing.Size(192, 24);
            this.cbcliebtellevar.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Atendido por.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(71, 81);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Servir Orden en Mesa Local";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Orden para llevar";
            // 
            // btlOpcion1
            // 
            this.btlOpcion1.BackColor = System.Drawing.Color.DarkBlue;
            this.btlOpcion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlOpcion1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btlOpcion1.Location = new System.Drawing.Point(112, 37);
            this.btlOpcion1.Margin = new System.Windows.Forms.Padding(4);
            this.btlOpcion1.Name = "btlOpcion1";
            this.btlOpcion1.Size = new System.Drawing.Size(126, 28);
            this.btlOpcion1.TabIndex = 23;
            this.btlOpcion1.Text = "Elegir";
            this.btlOpcion1.UseVisualStyleBackColor = false;
            this.btlOpcion1.Click += new System.EventHandler(this.btlOpcion1_Click);
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.BackColor = System.Drawing.Color.DarkBlue;
            this.btnOpcion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcion2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpcion2.Location = new System.Drawing.Point(687, 37);
            this.btnOpcion2.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(118, 28);
            this.btnOpcion2.TabIndex = 24;
            this.btnOpcion2.Text = "Elegir";
            this.btnOpcion2.UseVisualStyleBackColor = false;
            this.btnOpcion2.Click += new System.EventHandler(this.btnOpcion2_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblRespuesta.Location = new System.Drawing.Point(168, 452);
            this.lblRespuesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(471, 20);
            this.lblRespuesta.TabIndex = 25;
            this.lblRespuesta.Text = "                                                                             ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(108, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(697, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Este apartado aun esta en produccion ya que la informacion no llega bien a la BD";
            // 
            // frmTipoOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 462);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btlOpcion1);
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTipoOrden";
            this.Text = "Tipo de Orden";
            this.Load += new System.EventHandler(this.tipoOrden_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbMesa;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbresponsable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Button btlOpcion1;
        private System.Windows.Forms.Button btnOpcion2;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtDescricion;
        private System.Windows.Forms.Button btnListo2;
        private System.Windows.Forms.ComboBox cbAtendio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbcliebtellevar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}