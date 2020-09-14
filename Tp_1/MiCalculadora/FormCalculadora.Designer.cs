namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.labelIntroduccion = new System.Windows.Forms.Label();
            this.buttonOperar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonConvBinario = new System.Windows.Forms.Button();
            this.buttonConvDecimal = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelNroResult = new System.Windows.Forms.Label();
            this.comboBoxOperador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum1.Location = new System.Drawing.Point(37, 121);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(165, 38);
            this.textBoxNum1.TabIndex = 0;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum2.Location = new System.Drawing.Point(568, 121);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(165, 38);
            this.textBoxNum2.TabIndex = 2;
            // 
            // labelIntroduccion
            // 
            this.labelIntroduccion.AutoSize = true;
            this.labelIntroduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntroduccion.Location = new System.Drawing.Point(31, 54);
            this.labelIntroduccion.Name = "labelIntroduccion";
            this.labelIntroduccion.Size = new System.Drawing.Size(482, 31);
            this.labelIntroduccion.TabIndex = 3;
            this.labelIntroduccion.Text = "Ingrese dos numeros y una operacion: ";
            // 
            // buttonOperar
            // 
            this.buttonOperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperar.Location = new System.Drawing.Point(37, 238);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(165, 49);
            this.buttonOperar.TabIndex = 4;
            this.buttonOperar.Text = "Operar";
            this.buttonOperar.UseVisualStyleBackColor = true;
            this.buttonOperar.Click += new System.EventHandler(this.Operar_OnClick);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(313, 238);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(165, 49);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.Limpiar_OnClick);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.Location = new System.Drawing.Point(568, 238);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(165, 49);
            this.buttonCerrar.TabIndex = 6;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.Cerrar_OnClick);
            // 
            // buttonConvBinario
            // 
            this.buttonConvBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvBinario.Location = new System.Drawing.Point(37, 323);
            this.buttonConvBinario.Name = "buttonConvBinario";
            this.buttonConvBinario.Size = new System.Drawing.Size(320, 57);
            this.buttonConvBinario.TabIndex = 7;
            this.buttonConvBinario.Text = "Convertir a Binario";
            this.buttonConvBinario.UseVisualStyleBackColor = true;
            this.buttonConvBinario.Click += new System.EventHandler(this.ConvBin_OnClick);
            // 
            // buttonConvDecimal
            // 
            this.buttonConvDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvDecimal.Location = new System.Drawing.Point(422, 323);
            this.buttonConvDecimal.Name = "buttonConvDecimal";
            this.buttonConvDecimal.Size = new System.Drawing.Size(311, 57);
            this.buttonConvDecimal.TabIndex = 8;
            this.buttonConvDecimal.Text = "Convertir a Decimal";
            this.buttonConvDecimal.UseVisualStyleBackColor = true;
            this.buttonConvDecimal.Click += new System.EventHandler(this.ConvDeci_OnClick);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(40, 187);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(152, 31);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "Resultado: ";
            // 
            // labelNroResult
            // 
            this.labelNroResult.AutoSize = true;
            this.labelNroResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroResult.Location = new System.Drawing.Point(214, 187);
            this.labelNroResult.Name = "labelNroResult";
            this.labelNroResult.Size = new System.Drawing.Size(0, 31);
            this.labelNroResult.TabIndex = 10;
            // 
            // comboBoxOperador
            // 
            this.comboBoxOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperador.FormattingEnabled = true;
            this.comboBoxOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperador.Location = new System.Drawing.Point(298, 120);
            this.comboBoxOperador.Name = "comboBoxOperador";
            this.comboBoxOperador.Size = new System.Drawing.Size(165, 39);
            this.comboBoxOperador.TabIndex = 11;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxOperador);
            this.Controls.Add(this.labelNroResult);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonConvDecimal);
            this.Controls.Add(this.buttonConvBinario);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonOperar);
            this.Controls.Add(this.labelIntroduccion);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Alan Mengassini del Curso 2°C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Label labelIntroduccion;
        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonConvBinario;
        private System.Windows.Forms.Button buttonConvDecimal;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelNroResult;
        private System.Windows.Forms.ComboBox comboBoxOperador;
    }
}