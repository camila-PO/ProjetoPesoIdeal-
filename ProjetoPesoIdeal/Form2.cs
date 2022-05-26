using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPesoIdeal
{
    public partial class CalcIMC : Form
    {
        form3 inf;
        public CalcIMC()        

        {
            InitializeComponent();
            inf = new form3();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)           
        {
            try
            {
                if(txtAlturaIMC.Text == "")
                {

                    MessageBox.Show("Algo deu errado! Por favor, insira uma Altura válida!");
                }

                if (txtPesoIMC.Text == "")
                {
                    MessageBox.Show("Algo deu errado! Por favor, insira um Peso válido!");

                }
                double peso, altura, imc;

                peso = double.Parse(txtPesoIMC.Text);
                altura = double.Parse(txtAlturaIMC.Text);

                imc = (peso / (altura * altura));

                label3.Text = Convert.ToString(imc);
            }

            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado! Por favor, insira dados válidos!\n\n" + erro);
            }

        }//fim do botão calcular


        private void voltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();

        }// fim do voltar para primeira tela

        private void limpar_Click(object sender, EventArgs e)
        {
            txtPesoIMC.Clear();
            txtAlturaIMC.Clear();

            label3.Text = "";   


        }// limpar 

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecNumer(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecNumer(sender, e);

        }// chamando método decimal/bloc carateres

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void infoIMC_Click(object sender, EventArgs e)
        {
            Visible = false;
            inf.ShowDialog(); //mostrar a tela ao ser chamada 
            Visible = true;
        }

        private void txtAlturaIMC_TextChanged(object sender, EventArgs e)
        {

        }
    }//fim da classe
}//fim do projeto
