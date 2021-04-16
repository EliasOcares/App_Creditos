
namespace App_Creditos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCuotas = new System.Windows.Forms.TextBox();
            this.buttonIniciarSolu = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCostoCuota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(33, 71);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(219, 20);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(33, 131);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(219, 20);
            this.textBoxApellido.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monto a Solicitar";
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(33, 194);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(219, 20);
            this.textBoxMonto.TabIndex = 4;
            this.textBoxMonto.TextChanged += new System.EventHandler(this.textBoxMonto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número de cuotas";
            // 
            // textBoxCuotas
            // 
            this.textBoxCuotas.Location = new System.Drawing.Point(33, 260);
            this.textBoxCuotas.Name = "textBoxCuotas";
            this.textBoxCuotas.Size = new System.Drawing.Size(219, 20);
            this.textBoxCuotas.TabIndex = 6;
            // 
            // buttonIniciarSolu
            // 
            this.buttonIniciarSolu.Location = new System.Drawing.Point(104, 351);
            this.buttonIniciarSolu.Name = "buttonIniciarSolu";
            this.buttonIniciarSolu.Size = new System.Drawing.Size(96, 29);
            this.buttonIniciarSolu.TabIndex = 8;
            this.buttonIniciarSolu.Text = "Iniciar Solucion";
            this.buttonIniciarSolu.UseVisualStyleBackColor = true;
            this.buttonIniciarSolu.Click += new System.EventHandler(this.buttonIniciarSolu_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Enabled = false;
            this.textBoxResultado.Location = new System.Drawing.Point(482, 82);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(219, 20);
            this.textBoxResultado.TabIndex = 9;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBoxResultado_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto total a pagar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Costo de cada cuota";
            // 
            // textBoxCostoCuota
            // 
            this.textBoxCostoCuota.Enabled = false;
            this.textBoxCostoCuota.Location = new System.Drawing.Point(482, 180);
            this.textBoxCostoCuota.Name = "textBoxCostoCuota";
            this.textBoxCostoCuota.Size = new System.Drawing.Size(219, 20);
            this.textBoxCostoCuota.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(773, 423);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCostoCuota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonIniciarSolu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCuotas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de cuotas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCuotas;
        private System.Windows.Forms.Button buttonIniciarSolu;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCostoCuota;
    }
}

