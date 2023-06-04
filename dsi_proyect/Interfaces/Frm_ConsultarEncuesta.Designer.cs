namespace dsi_proyect.Interfaces
{
    partial class Frm_ConsultarEncuesta
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
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.lbl_Desde = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.groupFiltros = new System.Windows.Forms.GroupBox();
            this.gridLlamadas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLlamadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(27, 72);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(121, 26);
            this.dateTimeDesde.TabIndex = 1;
            this.dateTimeDesde.Value = new System.DateTime(2023, 5, 20, 0, 0, 0, 0);
            this.dateTimeDesde.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(178, 74);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(121, 26);
            this.dateTimeHasta.TabIndex = 2;
            this.dateTimeHasta.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filtrar.Location = new System.Drawing.Point(341, 72);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(94, 25);
            this.btn_Filtrar.TabIndex = 3;
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desde.Location = new System.Drawing.Point(24, 41);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(48, 16);
            this.lbl_Desde.TabIndex = 4;
            this.lbl_Desde.Text = "Desde";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.Location = new System.Drawing.Point(175, 41);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(43, 16);
            this.lbl_hasta.TabIndex = 5;
            this.lbl_hasta.Text = "Hasta";
            // 
            // groupFiltros
            // 
            this.groupFiltros.Controls.Add(this.gridLlamadas);
            this.groupFiltros.Controls.Add(this.dateTimeDesde);
            this.groupFiltros.Controls.Add(this.btn_Filtrar);
            this.groupFiltros.Controls.Add(this.lbl_hasta);
            this.groupFiltros.Controls.Add(this.dateTimeHasta);
            this.groupFiltros.Controls.Add(this.lbl_Desde);
            this.groupFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFiltros.Location = new System.Drawing.Point(12, 12);
            this.groupFiltros.Name = "groupFiltros";
            this.groupFiltros.Size = new System.Drawing.Size(466, 426);
            this.groupFiltros.TabIndex = 6;
            this.groupFiltros.TabStop = false;
            this.groupFiltros.Text = "Filtros";
            // 
            // gridLlamadas
            // 
            this.gridLlamadas.AllowUserToAddRows = false;
            this.gridLlamadas.AllowUserToDeleteRows = false;
            this.gridLlamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLlamadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridLlamadas.Location = new System.Drawing.Point(7, 147);
            this.gridLlamadas.Name = "gridLlamadas";
            this.gridLlamadas.ReadOnly = true;
            this.gridLlamadas.RowHeadersWidth = 51;
            this.gridLlamadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLlamadas.Size = new System.Drawing.Size(449, 273);
            this.gridLlamadas.TabIndex = 6;
            this.gridLlamadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLlamadas_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero de Llamada";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 230;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha de Llamada";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 230;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(403, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Frm_ConsultarEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 486);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupFiltros);
            this.Name = "Frm_ConsultarEncuesta";
            this.Text = "Consultar Encuesta";
            this.groupFiltros.ResumeLayout(false);
            this.groupFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLlamadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DateTimePicker dateTimeDesde;
        public System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.Label lbl_Desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.GroupBox groupFiltros;
        private System.Windows.Forms.DataGridView gridLlamadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnCancelar;
    }
}