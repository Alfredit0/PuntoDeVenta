namespace PuntoDeVenta
{
    partial class ArticulosActualizar
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
            this.comboProveedor = new System.Windows.Forms.ComboBox();
            this.richTextDescripcion = new System.Windows.Forms.RichTextBox();
            this.textPorcIva = new System.Windows.Forms.TextBox();
            this.textCosto = new System.Windows.Forms.TextBox();
            this.textPrecioV = new System.Windows.Forms.TextBox();
            this.textCodigoAlt = new System.Windows.Forms.TextBox();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.textCodigo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboProveedor
            // 
            this.comboProveedor.FormattingEnabled = true;
            this.comboProveedor.Location = new System.Drawing.Point(339, 291);
            this.comboProveedor.Name = "comboProveedor";
            this.comboProveedor.Size = new System.Drawing.Size(310, 21);
            this.comboProveedor.TabIndex = 6;
            // 
            // richTextDescripcion
            // 
            this.richTextDescripcion.Location = new System.Drawing.Point(339, 214);
            this.richTextDescripcion.Name = "richTextDescripcion";
            this.richTextDescripcion.Size = new System.Drawing.Size(310, 56);
            this.richTextDescripcion.TabIndex = 5;
            this.richTextDescripcion.Text = "";
            // 
            // textPorcIva
            // 
            this.textPorcIva.Location = new System.Drawing.Point(339, 173);
            this.textPorcIva.Name = "textPorcIva";
            this.textPorcIva.Size = new System.Drawing.Size(186, 20);
            this.textPorcIva.TabIndex = 4;
            // 
            // textCosto
            // 
            this.textCosto.Location = new System.Drawing.Point(339, 139);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(186, 20);
            this.textCosto.TabIndex = 3;
            // 
            // textPrecioV
            // 
            this.textPrecioV.Location = new System.Drawing.Point(339, 108);
            this.textPrecioV.Name = "textPrecioV";
            this.textPrecioV.Size = new System.Drawing.Size(186, 20);
            this.textPrecioV.TabIndex = 2;
            // 
            // textCodigoAlt
            // 
            this.textCodigoAlt.Location = new System.Drawing.Point(339, 81);
            this.textCodigoAlt.Name = "textCodigoAlt";
            this.textCodigoAlt.Size = new System.Drawing.Size(186, 20);
            this.textCodigoAlt.TabIndex = 1;
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(339, 53);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(186, 20);
            this.textBuscar.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(224, 371);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 23);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // textCodigo
            // 
            this.textCodigo.AutoSize = true;
            this.textCodigo.Location = new System.Drawing.Point(208, 291);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(75, 13);
            this.textCodigo.TabIndex = 22;
            this.textCodigo.Text = "PROVEEDOR";
            this.textCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "DESCRIPCIÓN DEL PRODUCTO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "PORCENTAJE DE IVA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "COSTO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "PRECIO DE VENTA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "CODIGO ALTERNO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "CODIGO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(545, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ArticulosActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboProveedor);
            this.Controls.Add(this.richTextDescripcion);
            this.Controls.Add(this.textPorcIva);
            this.Controls.Add(this.textCosto);
            this.Controls.Add(this.textPrecioV);
            this.Controls.Add(this.textCodigoAlt);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArticulosActualizar";
            this.Text = "Actualizar Articulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboProveedor;
        private System.Windows.Forms.RichTextBox richTextDescripcion;
        private System.Windows.Forms.TextBox textPorcIva;
        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.TextBox textPrecioV;
        private System.Windows.Forms.TextBox textCodigoAlt;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label textCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
    }
}