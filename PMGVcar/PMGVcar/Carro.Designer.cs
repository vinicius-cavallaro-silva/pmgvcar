namespace PMGVcar
{
    partial class Carro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carro));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtIdCarro = new System.Windows.Forms.TextBox();
            this.LbId_Carrro = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTipoServico = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 283);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(58, 30);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ano:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo Serviço:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(120, 46);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(120, 20);
            this.txtPlaca.TabIndex = 8;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(120, 74);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(120, 20);
            this.txtMarca.TabIndex = 9;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(120, 105);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(120, 20);
            this.txtModelo.TabIndex = 10;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(120, 132);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(120, 20);
            this.txtCor.TabIndex = 11;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(120, 159);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(120, 20);
            this.txtAno.TabIndex = 12;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(282, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(93, 36);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Cadastrar";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(282, 97);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(93, 33);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtIdCarro
            // 
            this.txtIdCarro.Location = new System.Drawing.Point(120, 17);
            this.txtIdCarro.Name = "txtIdCarro";
            this.txtIdCarro.Size = new System.Drawing.Size(120, 20);
            this.txtIdCarro.TabIndex = 15;
            this.txtIdCarro.TextChanged += new System.EventHandler(this.textBoxIdCarro_TextChanged);
            // 
            // LbId_Carrro
            // 
            this.LbId_Carrro.AutoSize = true;
            this.LbId_Carrro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbId_Carrro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbId_Carrro.Location = new System.Drawing.Point(16, 21);
            this.LbId_Carrro.Name = "LbId_Carrro";
            this.LbId_Carrro.Size = new System.Drawing.Size(62, 16);
            this.LbId_Carrro.TabIndex = 14;
            this.LbId_Carrro.Text = "Id_Carro:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(282, 54);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(93, 36);
            this.btnAtualizar.TabIndex = 16;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(282, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTipoServico
            // 
            this.txtTipoServico.Location = new System.Drawing.Point(120, 185);
            this.txtTipoServico.Name = "txtTipoServico";
            this.txtTipoServico.Size = new System.Drawing.Size(120, 20);
            this.txtTipoServico.TabIndex = 18;
            this.txtTipoServico.TextChanged += new System.EventHandler(this.txtTipoServico_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(282, 178);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 37);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 325);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtTipoServico);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtIdCarro);
            this.Controls.Add(this.LbId_Carrro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Carro";
            this.Text = "Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtIdCarro;
        private System.Windows.Forms.Label LbId_Carrro;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTipoServico;
        private System.Windows.Forms.Button btnLimpar;
    }
}