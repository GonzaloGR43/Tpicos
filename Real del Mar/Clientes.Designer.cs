namespace Real_del_Mar
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.btnbuscarclientes = new System.Windows.Forms.Button();
            this.btnagregarclientes = new System.Windows.Forms.Button();
            this.txtclientesbuscador = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcliente
            // 
            this.dgvcliente.AllowUserToAddRows = false;
            this.dgvcliente.AllowUserToDeleteRows = false;
            this.dgvcliente.AllowUserToOrderColumns = true;
            this.dgvcliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(3, 216);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.ReadOnly = true;
            this.dgvcliente.Size = new System.Drawing.Size(746, 489);
            this.dgvcliente.TabIndex = 2;
            this.dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellContentClick);
            // 
            // btnbuscarclientes
            // 
            this.btnbuscarclientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnbuscarclientes.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscarclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarclientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbuscarclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarclientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btnbuscarclientes.ForeColor = System.Drawing.Color.White;
            this.btnbuscarclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarclientes.Image")));
            this.btnbuscarclientes.Location = new System.Drawing.Point(435, 28);
            this.btnbuscarclientes.Name = "btnbuscarclientes";
            this.btnbuscarclientes.Size = new System.Drawing.Size(29, 29);
            this.btnbuscarclientes.TabIndex = 28;
            this.btnbuscarclientes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnbuscarclientes.UseVisualStyleBackColor = false;
            // 
            // btnagregarclientes
            // 
            this.btnagregarclientes.BackColor = System.Drawing.Color.White;
            this.btnagregarclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarclientes.FlatAppearance.BorderSize = 0;
            this.btnagregarclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnagregarclientes.Image")));
            this.btnagregarclientes.Location = new System.Drawing.Point(585, 3);
            this.btnagregarclientes.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnagregarclientes.Name = "btnagregarclientes";
            this.btnagregarclientes.Size = new System.Drawing.Size(67, 54);
            this.btnagregarclientes.TabIndex = 27;
            this.btnagregarclientes.Text = "Agregar";
            this.btnagregarclientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregarclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarclientes.UseVisualStyleBackColor = false;
            this.btnagregarclientes.Click += new System.EventHandler(this.btnagregarclientes_Click);
            // 
            // txtclientesbuscador
            // 
            this.txtclientesbuscador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtclientesbuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtclientesbuscador.Location = new System.Drawing.Point(190, 29);
            this.txtclientesbuscador.Multiline = true;
            this.txtclientesbuscador.Name = "txtclientesbuscador";
            this.txtclientesbuscador.Size = new System.Drawing.Size(239, 28);
            this.txtclientesbuscador.TabIndex = 26;
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
            this.lbltitulo.Size = new System.Drawing.Size(746, 57);
            this.lbltitulo.TabIndex = 25;
            this.lbltitulo.Text = "Clientes";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 752F));
            this.tableLayoutPanel1.Controls.Add(this.lbltitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvcliente, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 495F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 533);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtclientesbuscador, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnbuscarclientes, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnagregarclientes, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 106);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(746, 60);
            this.tableLayoutPanel2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 60);
            this.label3.TabIndex = 29;
            this.label3.Text = "Buscar cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(92)))), ((int)(((byte)(130)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 37);
            this.label1.TabIndex = 31;
            // 
            // Clientes
            // 
            this.AcceptButton = this.btnbuscarclientes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnbuscarclientes;
        private System.Windows.Forms.Button btnagregarclientes;
        private System.Windows.Forms.TextBox txtclientesbuscador;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvcliente;
    }
}