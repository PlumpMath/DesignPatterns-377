namespace DesignPatterns
{
    partial class FormPrincipal
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
            this.buttonISS = new System.Windows.Forms.Button();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonICMS = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonICCC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonArrojado = new System.Windows.Forms.Button();
            this.buttonModerado = new System.Windows.Forms.Button();
            this.buttonConservador = new System.Windows.Forms.Button();
            this.buttonDesconto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonISS
            // 
            this.buttonISS.Location = new System.Drawing.Point(6, 48);
            this.buttonISS.Name = "buttonISS";
            this.buttonISS.Size = new System.Drawing.Size(87, 23);
            this.buttonISS.TabIndex = 4;
            this.buttonISS.Text = "Testar ISS";
            this.buttonISS.UseVisualStyleBackColor = true;
            this.buttonISS.Click += new System.EventHandler(this.buttonISS_Click);
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(12, 26);
            this.textValor.Name = "textValor";
            this.textValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textValor.Size = new System.Drawing.Size(99, 20);
            this.textValor.TabIndex = 1;
            this.textValor.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor original";
            // 
            // buttonICMS
            // 
            this.buttonICMS.Location = new System.Drawing.Point(6, 18);
            this.buttonICMS.Name = "buttonICMS";
            this.buttonICMS.Size = new System.Drawing.Size(87, 23);
            this.buttonICMS.TabIndex = 3;
            this.buttonICMS.Text = "Testar ICMS";
            this.buttonICMS.UseVisualStyleBackColor = true;
            this.buttonICMS.Click += new System.EventHandler(this.buttonICMS_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(123, 24);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(87, 23);
            this.buttonSair.TabIndex = 13;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonICCC
            // 
            this.buttonICCC.Location = new System.Drawing.Point(6, 77);
            this.buttonICCC.Name = "buttonICCC";
            this.buttonICCC.Size = new System.Drawing.Size(87, 23);
            this.buttonICCC.TabIndex = 5;
            this.buttonICCC.Text = "Testar ICCC";
            this.buttonICCC.UseVisualStyleBackColor = true;
            this.buttonICCC.Click += new System.EventHandler(this.buttonICCC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonICCC);
            this.groupBox1.Controls.Add(this.buttonISS);
            this.groupBox1.Controls.Add(this.buttonICMS);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imposto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonArrojado);
            this.groupBox2.Controls.Add(this.buttonModerado);
            this.groupBox2.Controls.Add(this.buttonConservador);
            this.groupBox2.Location = new System.Drawing.Point(117, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 106);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Investimento";
            // 
            // buttonArrojado
            // 
            this.buttonArrojado.Location = new System.Drawing.Point(6, 77);
            this.buttonArrojado.Name = "buttonArrojado";
            this.buttonArrojado.Size = new System.Drawing.Size(87, 23);
            this.buttonArrojado.TabIndex = 9;
            this.buttonArrojado.Text = "Arrojado";
            this.buttonArrojado.UseVisualStyleBackColor = true;
            this.buttonArrojado.Click += new System.EventHandler(this.buttonArrojado_Click);
            // 
            // buttonModerado
            // 
            this.buttonModerado.Location = new System.Drawing.Point(6, 48);
            this.buttonModerado.Name = "buttonModerado";
            this.buttonModerado.Size = new System.Drawing.Size(87, 23);
            this.buttonModerado.TabIndex = 8;
            this.buttonModerado.Text = "Moderado";
            this.buttonModerado.UseVisualStyleBackColor = true;
            this.buttonModerado.Click += new System.EventHandler(this.buttonModerado_Click);
            // 
            // buttonConservador
            // 
            this.buttonConservador.Location = new System.Drawing.Point(6, 18);
            this.buttonConservador.Name = "buttonConservador";
            this.buttonConservador.Size = new System.Drawing.Size(87, 23);
            this.buttonConservador.TabIndex = 7;
            this.buttonConservador.Text = "Conservador";
            this.buttonConservador.UseVisualStyleBackColor = true;
            this.buttonConservador.Click += new System.EventHandler(this.buttonConservador_Click);
            // 
            // buttonDesconto
            // 
            this.buttonDesconto.AutoEllipsis = true;
            this.buttonDesconto.Location = new System.Drawing.Point(123, 162);
            this.buttonDesconto.Name = "buttonDesconto";
            this.buttonDesconto.Size = new System.Drawing.Size(87, 40);
            this.buttonDesconto.TabIndex = 12;
            this.buttonDesconto.Text = "Testar desconto";
            this.buttonDesconto.UseVisualStyleBackColor = true;
            this.buttonDesconto.Click += new System.EventHandler(this.buttonDesconto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantidade de itens";
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(12, 178);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textQuantidade.Size = new System.Drawing.Size(99, 20);
            this.textQuantidade.TabIndex = 11;
            this.textQuantidade.Text = "5";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 210);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.buttonDesconto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Formulário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonISS;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonICMS;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonICCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonArrojado;
        private System.Windows.Forms.Button buttonModerado;
        private System.Windows.Forms.Button buttonConservador;
        private System.Windows.Forms.Button buttonDesconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textQuantidade;
    }
}

