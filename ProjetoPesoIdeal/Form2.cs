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
            double peso, altura, imc;

            peso = double.Parse(textBox2.Text);
            altura = double.Parse(textBox1.Text);

            imc = (peso / (altura * altura));

            label3.Text = Convert.ToString(imc);

        }//fim do botão calcular

        private void voltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();

        }// fim do voltar para primeira tela

        private void limpar_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();

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
    }//fim da classe
}//fim do projeto
