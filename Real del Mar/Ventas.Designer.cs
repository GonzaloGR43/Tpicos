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
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.CausesValidation = false;
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
            this.dgvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventas.Location = new System.Drawing.Point(3, 226);
            this.dgvventas.Name = "dgvventas";
            this.dgvventas.Size = new System.Drawing.Size(741, 219);
            this.dgvventas.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 747F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvventas, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbltitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 527);
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
            this.label3.Text = "Buscar promotor";
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
            // Ventas
            // 
            this.AcceptButton = this.btnbuscarventas;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 532);
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
    }
}