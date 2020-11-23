namespace Real_del_Mar
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtventasbuscador = new System.Windows.Forms.TextBox();
            this.btnagregarpagare = new System.Windows.Forms.Button();
            this.btnbuscarventas = new System.Windows.Forms.Button();
            this.dgvventas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnpagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.CausesValidation = false;
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltitulo.Location = new System.Drawing.Point(3, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(741, 57);
            this.lbltitulo.TabIndex = 11;
            this.lbltitulo.Text = "Ventas";
            this.lbltitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // txtventasbuscador
            // 
            this.txtventasbuscador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtventasbuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtventasbuscador.Location = new System.Drawing.Point(260, 30);
            this.txtventasbuscador.Multiline = true;
            this.txtventasbuscador.Name = "txtventasbuscador";
            this.txtventasbuscador.Size = new System.Drawing.Size(184, 28);
            this.txtventasbuscador.TabIndex = 21;
            // 
            // btnagregarpagare
            // 
            this.btnagregarpagare.BackColor = System.Drawing.Color.White;
            this.btnagregarpagare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarpagare.FlatAppearance.BorderSize = 0;
            this.btnagregarpagare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarpagare.Image = ((System.Drawing.Image)(resources.GetObject("btnagregarpagare.Image")));
            this.btnagregarpagare.Location = new System.Drawing.Point(558, 3);
            this.btnagregarpagare.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnagregarpagare.Name = "btnagregarpagare";
            this.btnagregarpagare.Size = new System.Drawing.Size(92, 52);
            this.btnagregarpagare.TabIndex = 22;
            this.btnagregarpagare.Text = "Generar pagaré";
            this.btnagregarpagare.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregarpagare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarpagare.UseVisualStyleBackColor = false;
            this.btnagregarpagare.Click += new System.EventHandler(this.btnagregarpagare_Click);
            // 
            // btnbuscarventas
            // 
            this.btnbuscarventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnbuscarventas.BackColor = System.Drawing.Color.White;
            this.btnbuscarventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarventas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbuscarventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarventas.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btnbuscarventas.ForeColor = System.Drawing.Color.White;
            this.btnbuscarventas.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarventas.Image")));
            this.btnbuscarventas.Location = new System.Drawing.Point(450, 29);
            this.btnbuscarventas.Name = "btnbuscarventas";
            this.btnbuscarventas.Size = new System.Drawing.Size(29, 29);
            this.btnbuscarventas.TabIndex = 23;
            this.btnbuscarventas.UseVisualStyleBackColor = false;
            // 
            // dgvventas
            // 
            this.dgvventas.BackgroundColor = System.Drawing.Color.White;
            this.dgvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventas.Location = new System.Drawing.Point(3, 274);
            this.dgvventas.Name = "dgvventas";
            this.dgvventas.Size = new System.Drawing.Size(741, 271);
            this.dgvventas.TabIndex = 24;
            this.dgvventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvventas_CellClick);
            this.dgvventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvventas_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 747F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbltitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvventas, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 555);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtventasbuscador, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnbuscarventas, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnagregarpagare, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 112);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(741, 61);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 61);
            this.label3.TabIndex = 24;
            this.label3.Text = "Buscar ventas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(92)))), ((int)(((byte)(130)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 36);
            this.label1.TabIndex = 27;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.Controls.Add(this.btnimprimir, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btneliminar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnpagar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 179);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(741, 89);
            this.tableLayoutPanel3.TabIndex = 28;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnimprimir.BackColor = System.Drawing.Color.White;
            this.btnimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.Location = new System.Drawing.Point(649, 39);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(55, 47);
            this.btnimprimir.TabIndex = 33;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnimprimir.UseVisualStyleBackColor = false;
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btneliminar.BackColor = System.Drawing.Color.White;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(571, 39);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 47);
            this.btneliminar.TabIndex = 32;
            this.btneliminar.Text = "Cancelar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnpagar
            // 
            this.btnpagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpagar.BackColor = System.Drawing.Color.White;
            this.btnpagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpagar.FlatAppearance.BorderSize = 0;
            this.btnpagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpagar.Image = ((System.Drawing.Image)(resources.GetObject("btnpagar.Image")));
            this.btnpagar.Location = new System.Drawing.Point(501, 39);
            this.btnpagar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(67, 47);
            this.btnpagar.TabIndex = 31;
            this.btnpagar.Text = "Pagar";
            this.btnpagar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnpagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnpagar.UseVisualStyleBackColor = false;
            // 
            // Ventas
            // 
            this.AcceptButton = this.btnbuscarventas;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 562);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtventasbuscador;
        private System.Windows.Forms.Button btnagregarpagare;
        private System.Windows.Forms.Button btnbuscarventas;
        private System.Windows.Forms.DataGridView dgvventas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnimprimir;
    }
}
