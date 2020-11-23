namespace Real_del_Mar
{
    partial class Terrenos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terrenos));
            this.btninfo = new System.Windows.Forms.Button();
            this.dvgterreno = new System.Windows.Forms.DataGridView();
            this.btnbuscarterrenos = new System.Windows.Forms.Button();
            this.btnagregarterrenos = new System.Windows.Forms.Button();
            this.txtterrenobuscador = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgterreno)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btninfo
            // 
            this.btninfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btninfo.BackColor = System.Drawing.Color.White;
            this.btninfo.FlatAppearance.BorderSize = 0;
            this.btninfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninfo.Image = ((System.Drawing.Image)(resources.GetObject("btninfo.Image")));
            this.btninfo.Location = new System.Drawing.Point(641, 31);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(71, 45);
            this.btninfo.TabIndex = 28;
            this.btninfo.Text = "Información";
            this.btninfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btninfo.UseVisualStyleBackColor = false;
            this.btninfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvgterreno
            // 
            this.dvgterreno.AllowUserToAddRows = false;
            this.dvgterreno.AllowUserToDeleteRows = false;
            this.dvgterreno.AllowUserToOrderColumns = true;
            this.dvgterreno.BackgroundColor = System.Drawing.Color.White;
            this.dvgterreno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgterreno.Location = new System.Drawing.Point(3, 274);
            this.dvgterreno.Name = "dvgterreno";
            this.dvgterreno.ReadOnly = true;
            this.dvgterreno.Size = new System.Drawing.Size(739, 265);
            this.dvgterreno.TabIndex = 27;
            this.dvgterreno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgterreno_CellContentClick);
            // 
            // btnbuscarterrenos
            // 
            this.btnbuscarterrenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnbuscarterrenos.BackColor = System.Drawing.Color.White;
            this.btnbuscarterrenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarterrenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarterrenos.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btnbuscarterrenos.ForeColor = System.Drawing.Color.White;
            this.btnbuscarterrenos.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarterrenos.Image")));
            this.btnbuscarterrenos.Location = new System.Drawing.Point(442, 39);
            this.btnbuscarterrenos.Name = "btnbuscarterrenos";
            this.btnbuscarterrenos.Size = new System.Drawing.Size(29, 29);
            this.btnbuscarterrenos.TabIndex = 26;
            this.btnbuscarterrenos.UseVisualStyleBackColor = false;
            // 
            // btnagregarterrenos
            // 
            this.btnagregarterrenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnagregarterrenos.BackColor = System.Drawing.Color.White;
            this.btnagregarterrenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarterrenos.FlatAppearance.BorderSize = 0;
            this.btnagregarterrenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarterrenos.Image = ((System.Drawing.Image)(resources.GetObject("btnagregarterrenos.Image")));
            this.btnagregarterrenos.Location = new System.Drawing.Point(577, 15);
            this.btnagregarterrenos.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnagregarterrenos.Name = "btnagregarterrenos";
            this.btnagregarterrenos.Size = new System.Drawing.Size(89, 53);
            this.btnagregarterrenos.TabIndex = 25;
            this.btnagregarterrenos.Text = "Agregar terreno";
            this.btnagregarterrenos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregarterrenos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarterrenos.UseVisualStyleBackColor = false;
            this.btnagregarterrenos.Click += new System.EventHandler(this.btnagregarterrenos_Click);
            // 
            // txtterrenobuscador
            // 
            this.txtterrenobuscador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtterrenobuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtterrenobuscador.Location = new System.Drawing.Point(198, 40);
            this.txtterrenobuscador.Multiline = true;
            this.txtterrenobuscador.Name = "txtterrenobuscador";
            this.txtterrenobuscador.Size = new System.Drawing.Size(238, 28);
            this.txtterrenobuscador.TabIndex = 24;
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
            this.lbltitulo.Size = new System.Drawing.Size(739, 57);
            this.lbltitulo.TabIndex = 23;
            this.lbltitulo.Text = "Terrenos";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 745F));
            this.tableLayoutPanel1.Controls.Add(this.lbltitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dvgterreno, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(745, 582);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnagregarterrenos, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnbuscarterrenos, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtterrenobuscador, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 104);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(739, 71);
            this.tableLayoutPanel2.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 71);
            this.label3.TabIndex = 27;
            this.label3.Text = "Buscar terreno";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(92)))), ((int)(((byte)(130)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 40);
            this.label1.TabIndex = 30;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 569F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.Controls.Add(this.btneliminar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btninfo, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 189);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(739, 79);
            this.tableLayoutPanel3.TabIndex = 31;
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btneliminar.BackColor = System.Drawing.Color.White;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(569, 29);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(65, 47);
            this.btneliminar.TabIndex = 33;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // Terrenos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 598);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Terrenos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terrenos";
            this.Load += new System.EventHandler(this.Terrenos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgterreno)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.DataGridView dvgterreno;
        private System.Windows.Forms.Button btnbuscarterrenos;
        private System.Windows.Forms.Button btnagregarterrenos;
        private System.Windows.Forms.TextBox txtterrenobuscador;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btneliminar;
    }
}