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
    public partial class Form1 : Form
     
    {
        Form4 inf2;
        CalcIMC imc;       

        public Form1()
        {
            InitializeComponent();
            imc = new CalcIMC();
            inf2 = new Form4();
            Visible = true;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Altura = 0, PesoIdeal = 0;
            Altura = double.Parse(txtAltura.Text);
            if (cmbSexo.Text == "Feminino")
            {
                PesoIdeal = (62.7 * Altura) - 44.7;
                MessageBox.Show(txtNome.Text +  ", o peso recomendado para você de acordo com as informações inseridas é: " + PesoIdeal.ToString(),
                "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbSexo.Text == "Masculino")
            {
                PesoIdeal = (72.7 * Altura) - 58;
                MessageBox.Show(txtNome.Text  + ", o peso recomendado para você de acordo com as informações inseridas é: " + PesoIdeal.ToString(),
                "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Escolha o sexo", "Peso Ideal", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbSexo.Text = " ";
            txtNome.Focus();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntIMC_Click(object sender, EventArgs e)
        {
            Visible = false;
            imc.ShowDialog(); //mostrar a tela ao ser chamada 
            Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecNumer(sender, e);

        }// chamando método decimal/bloc carateres

        private void cmbSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
           Program.DecNumer(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Visible = false;
            inf2.ShowDialog(); //mostrar a tela ao ser chamada 
            Visible = true;
        }
    }//fim da classe
    }//fim do projeto

