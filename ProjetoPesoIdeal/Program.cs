using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPesoIdeal
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }//fim do método Main
        
        public static void DecNumer(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
                e.Handled = true;



            else if (e.KeyChar == 44)
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Contains(","))
                    e.Handled = true;
            }//fim if else

        }// fim metodo dc number

        
    }// fim da classe
}//fim do projeto
