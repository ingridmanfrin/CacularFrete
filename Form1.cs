using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacularFrete
{
    public partial class Form1 : Form
    {
        float KmRodada = 0;
        float KmAutonomia = 0;
        float QtdCombustivel = 0;
        double ValorCombustivel, custoDeCombustivel;
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBoxVeiculo_Leave(object sender, EventArgs e)
        {
            if (TxtBoxVeiculo.Text == "carro")
            {
                ImgVeiculo.Image = CacularFrete.Properties.Resources.Carro;
            }
            else if (TxtBoxVeiculo.Text == "moto")
            {
                ImgVeiculo.Image = CacularFrete.Properties.Resources.Moto;
            }
            else if (TxtBoxVeiculo.Text == "caminhao")
            {
                ImgVeiculo.Image = CacularFrete.Properties.Resources.Caminhao;
            }
            else
            {
                MessageBox.Show("Ops! você não escolheu a opção correta.");
                TxtBoxVeiculo.Text = "";
                TxtBoxVeiculo.Focus();
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            KmRodada = float.Parse(txtDistancia.Text);

            float KmDobrado = 0;
            if (checkBoxIdaVolta.Checked == false)
            {
                KmDobrado = KmRodada * 1; //so ida
            }
            else if (checkBoxIdaVolta.Checked)
            {
                KmDobrado = KmRodada * 2; //ida e volta
            }

            //custo do combustivel

            QtdCombustivel = KmDobrado / float.Parse(txtAutonomia.Text);

            //custo do combustivel

            custoDeCombustivel = double.Parse (txtvalorCombustivel.Text) * QtdCombustivel;
            double valorTotal = (custoDeCombustivel * int.Parse(cbTabela.Text));

            txtConsumoCombustivel.Text = QtdCombustivel.ToString();
            txtDespesaCombustivel.Text = custoDeCombustivel.ToString();
            txtKmRodado.Text = KmDobrado.ToString();
            txtValorTotal.Text = valorTotal.ToString();
            txtCustoPorKm.Text = (valorTotal / KmDobrado).ToString();

        }

    }
}
