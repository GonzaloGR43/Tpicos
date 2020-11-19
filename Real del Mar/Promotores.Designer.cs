namespace Real_del_Mar
{
    partial class Promotores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Promotores));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvpromo = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscador_Promotores = new System.Windows.Forms.TextBox();
            this.btnBuscador_Promotores = new System.Windows.Forms.Button();
            this.btnAgregar_Promotor = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpromo)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 752F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvpromo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 533);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promotores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.13793F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(746, 37);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(92)))), ((int)(((byte)(130)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(740, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Promotores de ventas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvpromo
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvpromo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvpromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpromo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpromo.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvpromo.Location = new System.Drawing.Point(3, 218);
            this.dgvpromo.Name = "dgvpromo";
            this.dgvpromo.Size = new System.Drawing.Size(746, 312);
            this.dgvpromo.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtBuscador_Promotores, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBuscador_Promotores, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAgregar_Promotor, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 112);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(746, 69);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 69);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buscar promotor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtBuscador_Promotores
            // 
            this.txtBuscador_Promotores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBuscador_Promotores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscador_Promotores.Location = new System.Drawing.Point(220, 40);
            this.txtBuscador_Promotores.Name = "txtBuscador_Promotores";
            this.txtBuscador_Promotores.Size = new System.Drawing.Size(191, 26);
            this.txtBuscador_Promotores.TabIndex = 1;
            // 
            // btnBuscador_Promotores
            // 
            this.btnBuscador_Promotores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscador_Promotores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscador_Promotores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscador_Promotores.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscador_Promotores.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscador_Promotores.Image")));
            this.btnBuscador_Promotores.Location = new System.Drawing.Point(417, 37);
            this.btnBuscador_Promotores.Name = "btnBuscador_Promotores";
            this.btnBuscador_Promotores.Size = new System.Drawing.Size(29, 29);
            this.btnBuscador_Promotores.TabIndex = 2;
            this.btnBuscador_Promotores.UseVisualStyleBackColor = true;
            // 
            // btnAgregar_Promotor
            // 
            this.btnAgregar_Promotor.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar_Promotor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar_Promotor.FlatAppearance.BorderSize = 0;
            this.btnAgregar_Promotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar_Promotor.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar_Promotor.Image")));
            this.btnAgregar_Promotor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar_Promotor.Location = new System.Drawing.Point(588, 3);
            this.btnAgregar_Promotor.Name = "btnAgregar_Promotor";
            this.btnAgregar_Promotor.Size = new System.Drawing.Size(67, 63);
            this.btnAgregar_Promotor.TabIndex = 3;
            this.btnAgregar_Promotor.Text = "Agregar Promotor";
            this.btnAgregar_Promotor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar_Promotor.UseVisualStyleBackColor = false;
            this.btnAgregar_Promotor.Click += new System.EventHandler(this.btnAgregar_Promotor_Click);
            // 
            // Promotores
            // 
            this.AcceptButton = this.btnBuscador_Promotores;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 537);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Promotores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotores";
            this.Load += new System.EventHandler(this.Promotores_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpromo)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvpromo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscador_Promotores;
        private System.Windows.Forms.Button btnBuscador_Promotores;
        private System.Windows.Forms.Button btnAgregar_Promotor;
    }
}