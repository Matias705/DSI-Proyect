namespace dsi_proyect.Interfaces
{
    partial class Frm_InfLlamada
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
            this.groupDatosLlamada = new System.Windows.Forms.GroupBox();
            this.groupDatosEncuesta = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_DescripcionEncuesta = new System.Windows.Forms.Label();
            this.lbl_DescripcionPreguntas = new System.Windows.Forms.Label();
            this.lbl_RespuestasSeleccionadas = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtEstadoActual = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lbl_Duracion = new System.Windows.Forms.Label();
            this.lbl_estadoActual = new System.Windows.Forms.Label();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescripcionPreguntas = new System.Windows.Forms.TextBox();
            this.txtRtaSeleccionadas = new System.Windows.Forms.TextBox();
            this.groupDatosLlamada.SuspendLayout();
            this.groupDatosEncuesta.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDatosLlamada
            // 
            this.groupDatosLlamada.Controls.Add(this.groupDatosEncuesta);
            this.groupDatosLlamada.Controls.Add(this.txtDuracion);
            this.groupDatosLlamada.Controls.Add(this.txtEstadoActual);
            this.groupDatosLlamada.Controls.Add(this.txtCliente);
            this.groupDatosLlamada.Controls.Add(this.lbl_Duracion);
            this.groupDatosLlamada.Controls.Add(this.lbl_estadoActual);
            this.groupDatosLlamada.Controls.Add(this.lbl_Cliente);
            this.groupDatosLlamada.Location = new System.Drawing.Point(12, 21);
            this.groupDatosLlamada.Name = "groupDatosLlamada";
            this.groupDatosLlamada.Size = new System.Drawing.Size(755, 391);
            this.groupDatosLlamada.TabIndex = 0;
            this.groupDatosLlamada.TabStop = false;
            this.groupDatosLlamada.Text = "Datos de la Llamada";
            // 
            // groupDatosEncuesta
            // 
            this.groupDatosEncuesta.Controls.Add(this.txtRtaSeleccionadas);
            this.groupDatosEncuesta.Controls.Add(this.txtDescripcionPreguntas);
            this.groupDatosEncuesta.Controls.Add(this.textBox4);
            this.groupDatosEncuesta.Controls.Add(this.lbl_DescripcionEncuesta);
            this.groupDatosEncuesta.Controls.Add(this.lbl_DescripcionPreguntas);
            this.groupDatosEncuesta.Controls.Add(this.lbl_RespuestasSeleccionadas);
            this.groupDatosEncuesta.Location = new System.Drawing.Point(298, 41);
            this.groupDatosEncuesta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupDatosEncuesta.Name = "groupDatosEncuesta";
            this.groupDatosEncuesta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupDatosEncuesta.Size = new System.Drawing.Size(434, 333);
            this.groupDatosEncuesta.TabIndex = 8;
            this.groupDatosEncuesta.TabStop = false;
            this.groupDatosEncuesta.Text = "Datos de la Encuesta";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(165, 50);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(253, 20);
            this.textBox4.TabIndex = 5;
            // 
            // lbl_DescripcionEncuesta
            // 
            this.lbl_DescripcionEncuesta.AutoSize = true;
            this.lbl_DescripcionEncuesta.Location = new System.Drawing.Point(8, 50);
            this.lbl_DescripcionEncuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DescripcionEncuesta.Name = "lbl_DescripcionEncuesta";
            this.lbl_DescripcionEncuesta.Size = new System.Drawing.Size(137, 13);
            this.lbl_DescripcionEncuesta.TabIndex = 4;
            this.lbl_DescripcionEncuesta.Text = "Descripcion de la Encuesta";
            this.lbl_DescripcionEncuesta.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_DescripcionPreguntas
            // 
            this.lbl_DescripcionPreguntas.AutoSize = true;
            this.lbl_DescripcionPreguntas.Location = new System.Drawing.Point(4, 126);
            this.lbl_DescripcionPreguntas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DescripcionPreguntas.Name = "lbl_DescripcionPreguntas";
            this.lbl_DescripcionPreguntas.Size = new System.Drawing.Size(144, 13);
            this.lbl_DescripcionPreguntas.TabIndex = 2;
            this.lbl_DescripcionPreguntas.Text = "Descripcion de las preguntas";
            // 
            // lbl_RespuestasSeleccionadas
            // 
            this.lbl_RespuestasSeleccionadas.AutoSize = true;
            this.lbl_RespuestasSeleccionadas.Location = new System.Drawing.Point(8, 223);
            this.lbl_RespuestasSeleccionadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RespuestasSeleccionadas.Name = "lbl_RespuestasSeleccionadas";
            this.lbl_RespuestasSeleccionadas.Size = new System.Drawing.Size(134, 13);
            this.lbl_RespuestasSeleccionadas.TabIndex = 0;
            this.lbl_RespuestasSeleccionadas.Text = "Respuestas seleccionadas";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(159, 163);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(100, 20);
            this.txtDuracion.TabIndex = 6;
            // 
            // txtEstadoActual
            // 
            this.txtEstadoActual.Location = new System.Drawing.Point(159, 118);
            this.txtEstadoActual.Name = "txtEstadoActual";
            this.txtEstadoActual.Size = new System.Drawing.Size(100, 20);
            this.txtEstadoActual.TabIndex = 5;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(159, 72);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // lbl_Duracion
            // 
            this.lbl_Duracion.AutoSize = true;
            this.lbl_Duracion.Location = new System.Drawing.Point(32, 163);
            this.lbl_Duracion.Name = "lbl_Duracion";
            this.lbl_Duracion.Size = new System.Drawing.Size(115, 13);
            this.lbl_Duracion.TabIndex = 2;
            this.lbl_Duracion.Text = "Duracion de la llamada";
            this.lbl_Duracion.Click += new System.EventHandler(this.lbl_Duracion_Click);
            // 
            // lbl_estadoActual
            // 
            this.lbl_estadoActual.AutoSize = true;
            this.lbl_estadoActual.Location = new System.Drawing.Point(32, 123);
            this.lbl_estadoActual.Name = "lbl_estadoActual";
            this.lbl_estadoActual.Size = new System.Drawing.Size(73, 13);
            this.lbl_estadoActual.TabIndex = 1;
            this.lbl_estadoActual.Text = "Estado Actual";
            this.lbl_estadoActual.Click += new System.EventHandler(this.lbl_estado_Click);
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Location = new System.Drawing.Point(32, 77);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(39, 13);
            this.lbl_Cliente.TabIndex = 0;
            this.lbl_Cliente.Text = "Cliente";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(461, 418);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(574, 418);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(86, 23);
            this.btnCsv.TabIndex = 2;
            this.btnCsv.Text = "Generar Csv";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(690, 418);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescripcionPreguntas
            // 
            this.txtDescripcionPreguntas.Location = new System.Drawing.Point(165, 126);
            this.txtDescripcionPreguntas.Multiline = true;
            this.txtDescripcionPreguntas.Name = "txtDescripcionPreguntas";
            this.txtDescripcionPreguntas.Size = new System.Drawing.Size(253, 75);
            this.txtDescripcionPreguntas.TabIndex = 6;
            // 
            // txtRtaSeleccionadas
            // 
            this.txtRtaSeleccionadas.Location = new System.Drawing.Point(165, 223);
            this.txtRtaSeleccionadas.Multiline = true;
            this.txtRtaSeleccionadas.Name = "txtRtaSeleccionadas";
            this.txtRtaSeleccionadas.Size = new System.Drawing.Size(253, 90);
            this.txtRtaSeleccionadas.TabIndex = 7;
            // 
            // Frm_InfLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupDatosLlamada);
            this.Name = "Frm_InfLlamada";
            this.Text = "Informacion de Llamada";
            this.Load += new System.EventHandler(this.Frm_InfLlamada_Load);
            this.groupDatosLlamada.ResumeLayout(false);
            this.groupDatosLlamada.PerformLayout();
            this.groupDatosEncuesta.ResumeLayout(false);
            this.groupDatosEncuesta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDatosLlamada;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtEstadoActual;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lbl_Duracion;
        private System.Windows.Forms.Label lbl_estadoActual;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.GroupBox groupDatosEncuesta;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_DescripcionEncuesta;
        private System.Windows.Forms.Label lbl_DescripcionPreguntas;
        private System.Windows.Forms.Label lbl_RespuestasSeleccionadas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtRtaSeleccionadas;
        private System.Windows.Forms.TextBox txtDescripcionPreguntas;
    }
}