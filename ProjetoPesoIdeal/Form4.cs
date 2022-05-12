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
    public partial class Form4 : Form
    {
        form3 inf;
        public Form4()
        {
            InitializeComponent();
            inf = new form3();
        }

        private void volt4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            inf.ShowDialog(); //mostrar a tela ao ser chamada 
            Visible = true;
        }
    }//fim da classe
}//fim do projeto
