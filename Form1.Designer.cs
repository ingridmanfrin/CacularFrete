namespace CacularFrete
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValorPorLitro = new System.Windows.Forms.Label();
            this.txtvalorCombustivel = new System.Windows.Forms.TextBox();
            this.checkBoxIdaVolta = new System.Windows.Forms.CheckBox();
            this.cbTabela = new System.Windows.Forms.ComboBox();
            this.LblTabela = new System.Windows.Forms.Label();
            this.LblValorCombustivel = new System.Windows.Forms.Label();
            this.LblDistancia = new System.Windows.Forms.Label();
            this.LblLocalidade = new System.Windows.Forms.Label();
            this.LblVeiculo = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtAutonomia = new System.Windows.Forms.TextBox();
            this.TxtBoxVeiculo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.LblConsumoCombust = new System.Windows.Forms.Label();
            this.LblDespesaCombust = new System.Windows.Forms.Label();
            this.LblKmRodado = new System.Windows.Forms.Label();
            this.LblCustoKm = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.txtConsumoCombustivel = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtCustoPorKm = new System.Windows.Forms.TextBox();
            this.txtKmRodado = new System.Windows.Forms.TextBox();
            this.txtDespesaCombustivel = new System.Windows.Forms.TextBox();
            this.ImgVeiculo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblValorPorLitro);
            this.panel1.Controls.Add(this.txtvalorCombustivel);
            this.panel1.Controls.Add(this.checkBoxIdaVolta);
            this.panel1.Controls.Add(this.cbTabela);
            this.panel1.Controls.Add(this.LblTabela);
            this.panel1.Controls.Add(this.LblValorCombustivel);
            this.panel1.Controls.Add(this.LblDistancia);
            this.panel1.Controls.Add(this.LblLocalidade);
            this.panel1.Controls.Add(this.LblVeiculo);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.txtDistancia);
            this.panel1.Controls.Add(this.txtAutonomia);
            this.panel1.Controls.Add(this.TxtBoxVeiculo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 157);
            this.panel1.TabIndex = 0;
            // 
            // lblValorPorLitro
            // 
            this.lblValorPorLitro.AutoSize = true;
            this.lblValorPorLitro.Location = new System.Drawing.Point(305, 65);
            this.lblValorPorLitro.Name = "lblValorPorLitro";
            this.lblValorPorLitro.Size = new System.Drawing.Size(68, 13);
            this.lblValorPorLitro.TabIndex = 11;
            this.lblValorPorLitro.Text = "Valor por litro";
            // 
            // txtvalorCombustivel
            // 
            this.txtvalorCombustivel.Location = new System.Drawing.Point(303, 91);
            this.txtvalorCombustivel.Name = "txtvalorCombustivel";
            this.txtvalorCombustivel.Size = new System.Drawing.Size(100, 20);
            this.txtvalorCombustivel.TabIndex = 10;
            // 
            // checkBoxIdaVolta
            // 
            this.checkBoxIdaVolta.AutoSize = true;
            this.checkBoxIdaVolta.Location = new System.Drawing.Point(303, 127);
            this.checkBoxIdaVolta.Name = "checkBoxIdaVolta";
            this.checkBoxIdaVolta.Size = new System.Drawing.Size(76, 17);
            this.checkBoxIdaVolta.TabIndex = 6;
            this.checkBoxIdaVolta.Text = "Ida / Volta";
            this.checkBoxIdaVolta.UseVisualStyleBackColor = true;
            // 
            // cbTabela
            // 
            this.cbTabela.FormattingEnabled = true;
            this.cbTabela.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbTabela.Location = new System.Drawing.Point(156, 88);
            this.cbTabela.Name = "cbTabela";
            this.cbTabela.Size = new System.Drawing.Size(121, 21);
            this.cbTabela.TabIndex = 5;
            // 
            // LblTabela
            // 
            this.LblTabela.AutoSize = true;
            this.LblTabela.Location = new System.Drawing.Point(156, 65);
            this.LblTabela.Name = "LblTabela";
            this.LblTabela.Size = new System.Drawing.Size(40, 13);
            this.LblTabela.TabIndex = 9;
            this.LblTabela.Text = "Tabela";
            // 
            // LblValorCombustivel
            // 
            this.LblValorCombustivel.AutoSize = true;
            this.LblValorCombustivel.Location = new System.Drawing.Point(23, 65);
            this.LblValorCombustivel.Name = "LblValorCombustivel";
            this.LblValorCombustivel.Size = new System.Drawing.Size(119, 13);
            this.LblValorCombustivel.TabIndex = 8;
            this.LblValorCombustivel.Text = "Autonomia Combustível";
            // 
            // LblDistancia
            // 
            this.LblDistancia.AutoSize = true;
            this.LblDistancia.Location = new System.Drawing.Point(282, 8);
            this.LblDistancia.Name = "LblDistancia";
            this.LblDistancia.Size = new System.Drawing.Size(51, 13);
            this.LblDistancia.TabIndex = 7;
            this.LblDistancia.Text = "Distância";
            // 
            // LblLocalidade
            // 
            this.LblLocalidade.AutoSize = true;
            this.LblLocalidade.Location = new System.Drawing.Point(156, 8);
            this.LblLocalidade.Name = "LblLocalidade";
            this.LblLocalidade.Size = new System.Drawing.Size(59, 13);
            this.LblLocalidade.TabIndex = 6;
            this.LblLocalidade.Text = "Localidade";
            // 
            // LblVeiculo
            // 
            this.LblVeiculo.AutoSize = true;
            this.LblVeiculo.Location = new System.Drawing.Point(23, 8);
            this.LblVeiculo.Name = "LblVeiculo";
            this.LblVeiculo.Size = new System.Drawing.Size(44, 13);
            this.LblVeiculo.TabIndex = 5;
            this.LblVeiculo.Text = "Veículo";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 20);
            this.textBox4.TabIndex = 2;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(285, 27);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(138, 20);
            this.txtDistancia.TabIndex = 3;
            // 
            // txtAutonomia
            // 
            this.txtAutonomia.Location = new System.Drawing.Point(23, 90);
            this.txtAutonomia.Name = "txtAutonomia";
            this.txtAutonomia.Size = new System.Drawing.Size(119, 20);
            this.txtAutonomia.TabIndex = 4;
            // 
            // TxtBoxVeiculo
            // 
            this.TxtBoxVeiculo.Location = new System.Drawing.Point(23, 27);
            this.TxtBoxVeiculo.Name = "TxtBoxVeiculo";
            this.TxtBoxVeiculo.Size = new System.Drawing.Size(119, 20);
            this.TxtBoxVeiculo.TabIndex = 1;
            this.TxtBoxVeiculo.Leave += new System.EventHandler(this.TxtBoxVeiculo_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CacularFrete.Properties.Resources.ImagemCaminhaoFrete;
            this.pictureBox1.Location = new System.Drawing.Point(465, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "SISTEMA CÁLCULO FRETE";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(30, 225);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(98, 37);
            this.BtnConfirmar.TabIndex = 3;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // LblConsumoCombust
            // 
            this.LblConsumoCombust.AutoSize = true;
            this.LblConsumoCombust.Location = new System.Drawing.Point(32, 289);
            this.LblConsumoCombust.Name = "LblConsumoCombust";
            this.LblConsumoCombust.Size = new System.Drawing.Size(113, 13);
            this.LblConsumoCombust.TabIndex = 4;
            this.LblConsumoCombust.Text = "Consumo Combustível";
            // 
            // LblDespesaCombust
            // 
            this.LblDespesaCombust.AutoSize = true;
            this.LblDespesaCombust.Location = new System.Drawing.Point(168, 289);
            this.LblDespesaCombust.Name = "LblDespesaCombust";
            this.LblDespesaCombust.Size = new System.Drawing.Size(126, 13);
            this.LblDespesaCombust.TabIndex = 5;
            this.LblDespesaCombust.Text = "Despesa de Combustível";
            // 
            // LblKmRodado
            // 
            this.LblKmRodado.AutoSize = true;
            this.LblKmRodado.Location = new System.Drawing.Point(38, 347);
            this.LblKmRodado.Name = "LblKmRodado";
            this.LblKmRodado.Size = new System.Drawing.Size(63, 13);
            this.LblKmRodado.TabIndex = 6;
            this.LblKmRodado.Text = "Km Rodado";
            // 
            // LblCustoKm
            // 
            this.LblCustoKm.AutoSize = true;
            this.LblCustoKm.Location = new System.Drawing.Point(171, 341);
            this.LblCustoKm.Name = "LblCustoKm";
            this.LblCustoKm.Size = new System.Drawing.Size(70, 13);
            this.LblCustoKm.TabIndex = 7;
            this.LblCustoKm.Text = "Custo por Km";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(317, 315);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(37, 13);
            this.LblTotal.TabIndex = 8;
            this.LblTotal.Text = "Total :";
            // 
            // txtConsumoCombustivel
            // 
            this.txtConsumoCombustivel.Location = new System.Drawing.Point(35, 307);
            this.txtConsumoCombustivel.Name = "txtConsumoCombustivel";
            this.txtConsumoCombustivel.Size = new System.Drawing.Size(119, 20);
            this.txtConsumoCombustivel.TabIndex = 7;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(315, 339);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(120, 20);
            this.txtValorTotal.TabIndex = 11;
            // 
            // txtCustoPorKm
            // 
            this.txtCustoPorKm.Location = new System.Drawing.Point(168, 365);
            this.txtCustoPorKm.Name = "txtCustoPorKm";
            this.txtCustoPorKm.Size = new System.Drawing.Size(124, 20);
            this.txtCustoPorKm.TabIndex = 10;
            // 
            // txtKmRodado
            // 
            this.txtKmRodado.Location = new System.Drawing.Point(35, 365);
            this.txtKmRodado.Name = "txtKmRodado";
            this.txtKmRodado.Size = new System.Drawing.Size(119, 20);
            this.txtKmRodado.TabIndex = 9;
            // 
            // txtDespesaCombustivel
            // 
            this.txtDespesaCombustivel.Location = new System.Drawing.Point(168, 307);
            this.txtDespesaCombustivel.Name = "txtDespesaCombustivel";
            this.txtDespesaCombustivel.Size = new System.Drawing.Size(123, 20);
            this.txtDespesaCombustivel.TabIndex = 8;
            // 
            // ImgVeiculo
            // 
            this.ImgVeiculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImgVeiculo.Location = new System.Drawing.Point(477, 237);
            this.ImgVeiculo.Name = "ImgVeiculo";
            this.ImgVeiculo.Size = new System.Drawing.Size(211, 148);
            this.ImgVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgVeiculo.TabIndex = 1;
            this.ImgVeiculo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 414);
            this.Controls.Add(this.txtDespesaCombustivel);
            this.Controls.Add(this.txtKmRodado);
            this.Controls.Add(this.txtCustoPorKm);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtConsumoCombustivel);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblCustoKm);
            this.Controls.Add(this.LblKmRodado);
            this.Controls.Add(this.LblDespesaCombust);
            this.Controls.Add(this.LblConsumoCombust);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImgVeiculo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxIdaVolta;
        private System.Windows.Forms.ComboBox cbTabela;
        private System.Windows.Forms.Label LblTabela;
        private System.Windows.Forms.Label LblValorCombustivel;
        private System.Windows.Forms.Label LblDistancia;
        private System.Windows.Forms.Label LblLocalidade;
        private System.Windows.Forms.Label LblVeiculo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtAutonomia;
        private System.Windows.Forms.TextBox TxtBoxVeiculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ImgVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Label LblConsumoCombust;
        private System.Windows.Forms.Label LblDespesaCombust;
        private System.Windows.Forms.Label LblKmRodado;
        private System.Windows.Forms.Label LblCustoKm;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox txtConsumoCombustivel;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtCustoPorKm;
        private System.Windows.Forms.TextBox txtKmRodado;
        private System.Windows.Forms.TextBox txtDespesaCombustivel;
        private System.Windows.Forms.Label lblValorPorLitro;
        private System.Windows.Forms.TextBox txtvalorCombustivel;
    }
}

