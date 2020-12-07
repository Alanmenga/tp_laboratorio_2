namespace FormSupermercado
{
    partial class SupermercadoForm
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
            this.listBoxListaProductosStock = new System.Windows.Forms.ListBox();
            this.listBoxListaProductosComprados = new System.Windows.Forms.ListBox();
            this.richTextBoxMostrarDatos = new System.Windows.Forms.RichTextBox();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.buttonCompra = new System.Windows.Forms.Button();
            this.labelNombreProducto = new System.Windows.Forms.Label();
            this.labelIdProducto = new System.Windows.Forms.Label();
            this.textBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.textBoxIdProducto = new System.Windows.Forms.TextBox();
            this.labelProductosDisponibles = new System.Windows.Forms.Label();
            this.labelProdEncargados = new System.Windows.Forms.Label();
            this.labelProdComprados = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBoxProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxListaProductosStock
            // 
            this.listBoxListaProductosStock.FormattingEnabled = true;
            this.listBoxListaProductosStock.ItemHeight = 20;
            this.listBoxListaProductosStock.Location = new System.Drawing.Point(13, 366);
            this.listBoxListaProductosStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxListaProductosStock.Name = "listBoxListaProductosStock";
            this.listBoxListaProductosStock.Size = new System.Drawing.Size(313, 244);
            this.listBoxListaProductosStock.TabIndex = 0;
            // 
            // listBoxListaProductosComprados
            // 
            this.listBoxListaProductosComprados.FormattingEnabled = true;
            this.listBoxListaProductosComprados.ItemHeight = 20;
            this.listBoxListaProductosComprados.Location = new System.Drawing.Point(421, 366);
            this.listBoxListaProductosComprados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxListaProductosComprados.Name = "listBoxListaProductosComprados";
            this.listBoxListaProductosComprados.Size = new System.Drawing.Size(355, 244);
            this.listBoxListaProductosComprados.TabIndex = 1;
            // 
            // richTextBoxMostrarDatos
            // 
            this.richTextBoxMostrarDatos.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxMostrarDatos.Location = new System.Drawing.Point(13, 44);
            this.richTextBoxMostrarDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxMostrarDatos.Name = "richTextBoxMostrarDatos";
            this.richTextBoxMostrarDatos.ReadOnly = true;
            this.richTextBoxMostrarDatos.Size = new System.Drawing.Size(313, 288);
            this.richTextBoxMostrarDatos.TabIndex = 2;
            this.richTextBoxMostrarDatos.Text = "";
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.buttonGuardar);
            this.groupBoxProducto.Controls.Add(this.buttonCompra);
            this.groupBoxProducto.Controls.Add(this.labelNombreProducto);
            this.groupBoxProducto.Controls.Add(this.labelIdProducto);
            this.groupBoxProducto.Controls.Add(this.textBoxNombreProducto);
            this.groupBoxProducto.Controls.Add(this.textBoxIdProducto);
            this.groupBoxProducto.Location = new System.Drawing.Point(421, 18);
            this.groupBoxProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxProducto.Size = new System.Drawing.Size(357, 305);
            this.groupBoxProducto.TabIndex = 3;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Producto a Comprar";
            // 
            // buttonCompra
            // 
            this.buttonCompra.Location = new System.Drawing.Point(24, 229);
            this.buttonCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCompra.Name = "buttonCompra";
            this.buttonCompra.Size = new System.Drawing.Size(117, 37);
            this.buttonCompra.TabIndex = 4;
            this.buttonCompra.Text = "Comprar";
            this.buttonCompra.UseVisualStyleBackColor = true;
            this.buttonCompra.Click += new System.EventHandler(this.buttonCompra_Click);
            // 
            // labelNombreProducto
            // 
            this.labelNombreProducto.AutoSize = true;
            this.labelNombreProducto.Location = new System.Drawing.Point(24, 128);
            this.labelNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreProducto.Name = "labelNombreProducto";
            this.labelNombreProducto.Size = new System.Drawing.Size(129, 20);
            this.labelNombreProducto.TabIndex = 3;
            this.labelNombreProducto.Text = "NombreProducto";
            // 
            // labelIdProducto
            // 
            this.labelIdProducto.AutoSize = true;
            this.labelIdProducto.Location = new System.Drawing.Point(20, 51);
            this.labelIdProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdProducto.Name = "labelIdProducto";
            this.labelIdProducto.Size = new System.Drawing.Size(98, 20);
            this.labelIdProducto.TabIndex = 2;
            this.labelIdProducto.Text = "ID Producto:";
            // 
            // textBoxNombreProducto
            // 
            this.textBoxNombreProducto.Location = new System.Drawing.Point(24, 157);
            this.textBoxNombreProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNombreProducto.Name = "textBoxNombreProducto";
            this.textBoxNombreProducto.Size = new System.Drawing.Size(276, 26);
            this.textBoxNombreProducto.TabIndex = 1;
            // 
            // textBoxIdProducto
            // 
            this.textBoxIdProducto.Location = new System.Drawing.Point(24, 75);
            this.textBoxIdProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxIdProducto.Name = "textBoxIdProducto";
            this.textBoxIdProducto.Size = new System.Drawing.Size(276, 26);
            this.textBoxIdProducto.TabIndex = 0;
            // 
            // labelProductosDisponibles
            // 
            this.labelProductosDisponibles.AutoSize = true;
            this.labelProductosDisponibles.Location = new System.Drawing.Point(13, 13);
            this.labelProductosDisponibles.Name = "labelProductosDisponibles";
            this.labelProductosDisponibles.Size = new System.Drawing.Size(224, 20);
            this.labelProductosDisponibles.TabIndex = 4;
            this.labelProductosDisponibles.Text = "Lista de Productos disponibles";
            // 
            // labelProdEncargados
            // 
            this.labelProdEncargados.AutoSize = true;
            this.labelProdEncargados.Location = new System.Drawing.Point(13, 338);
            this.labelProdEncargados.Name = "labelProdEncargados";
            this.labelProdEncargados.Size = new System.Drawing.Size(139, 20);
            this.labelProdEncargados.TabIndex = 5;
            this.labelProdEncargados.Text = "Productos en Cola";
            // 
            // labelProdComprados
            // 
            this.labelProdComprados.AutoSize = true;
            this.labelProdComprados.Location = new System.Drawing.Point(421, 338);
            this.labelProdComprados.Name = "labelProdComprados";
            this.labelProdComprados.Size = new System.Drawing.Size(167, 20);
            this.labelProdComprados.TabIndex = 6;
            this.labelProdComprados.Text = "Productos Comprados";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(183, 229);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(117, 37);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // SupermercadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 643);
            this.Controls.Add(this.labelProdComprados);
            this.Controls.Add(this.labelProdEncargados);
            this.Controls.Add(this.labelProductosDisponibles);
            this.Controls.Add(this.groupBoxProducto);
            this.Controls.Add(this.richTextBoxMostrarDatos);
            this.Controls.Add(this.listBoxListaProductosComprados);
            this.Controls.Add(this.listBoxListaProductosStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupermercadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermercado Online";
            this.Load += new System.EventHandler(this.SupermercadoForm_Load);
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxListaProductosStock;
        private System.Windows.Forms.ListBox listBoxListaProductosComprados;
        private System.Windows.Forms.RichTextBox richTextBoxMostrarDatos;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.Button buttonCompra;
        private System.Windows.Forms.Label labelNombreProducto;
        private System.Windows.Forms.Label labelIdProducto;
        private System.Windows.Forms.TextBox textBoxNombreProducto;
        private System.Windows.Forms.TextBox textBoxIdProducto;
        private System.Windows.Forms.Label labelProductosDisponibles;
        private System.Windows.Forms.Label labelProdEncargados;
        private System.Windows.Forms.Label labelProdComprados;
        private System.Windows.Forms.Button buttonGuardar;
    }
}