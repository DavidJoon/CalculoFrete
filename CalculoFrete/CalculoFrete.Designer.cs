
namespace CalculoFrete
{
    partial class CalculoFrete
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelResul = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelFrete = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelFinal = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe Print", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(187, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(430, 51);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Cálculo de Frete por Estado";
            // 
            // labelNome
            // 
            this.labelNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelNome.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(170, 109);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(59, 23);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResul
            // 
            this.labelResul.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelResul.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResul.Location = new System.Drawing.Point(187, 319);
            this.labelResul.Name = "labelResul";
            this.labelResul.Size = new System.Drawing.Size(430, 92);
            this.labelResul.TabIndex = 6;
            this.labelResul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValor
            // 
            this.labelValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelValor.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValor.Location = new System.Drawing.Point(170, 151);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(59, 23);
            this.labelValor.TabIndex = 7;
            this.labelValor.Text = "Valor:";
            this.labelValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFrete
            // 
            this.labelFrete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelFrete.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFrete.Location = new System.Drawing.Point(170, 190);
            this.labelFrete.Name = "labelFrete";
            this.labelFrete.Size = new System.Drawing.Size(59, 23);
            this.labelFrete.TabIndex = 8;
            this.labelFrete.Text = "Frete:";
            this.labelFrete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEstado
            // 
            this.labelEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelEstado.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEstado.Location = new System.Drawing.Point(470, 151);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(59, 23);
            this.labelEstado.TabIndex = 9;
            this.labelEstado.Text = "Estado:";
            this.labelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 23);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 23);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(235, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(144, 23);
            this.textBox3.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AM",
            "MG",
            "RJ",
            "SP"});
            this.comboBox1.Location = new System.Drawing.Point(535, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // labelFinal
            // 
            this.labelFinal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelFinal.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFinal.Location = new System.Drawing.Point(187, 281);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(146, 23);
            this.labelFinal.TabIndex = 14;
            this.labelFinal.Text = "Valor Final:";
            this.labelFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.LightGreen;
            this.buttonCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCalcular.FlatAppearance.BorderSize = 2;
            this.buttonCalcular.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCalcular.Location = new System.Drawing.Point(517, 271);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(100, 33);
            this.buttonCalcular.TabIndex = 15;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonLimpar.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLimpar.Location = new System.Drawing.Point(396, 271);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(100, 33);
            this.buttonLimpar.TabIndex = 16;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // CalculoFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelFinal);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelFrete);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelResul);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelTitulo);
            this.Name = "CalculoFrete";
            this.ShowIcon = false;
            this.Text = "Sistema de Frete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelResul;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelFrete;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonLimpar;
    }
}

