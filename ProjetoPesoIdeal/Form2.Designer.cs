
namespace ProjetoPesoIdeal
{
    partial class CalcIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcIMC));
            this.imc = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.voltarMenu = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.infoIMC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imc
            // 
            this.imc.AutoSize = true;
            this.imc.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imc.Location = new System.Drawing.Point(98, 12);
            this.imc.Name = "imc";
            this.imc.Size = new System.Drawing.Size(316, 31);
            this.imc.TabIndex = 0;
            this.imc.Text = "Vamos calcular o seu IMC?";
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.calcular.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(236, 299);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 29);
            this.calcular.TabIndex = 1;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Me informe a sua altura:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Me informe o seu Peso:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // voltarMenu
            // 
            this.voltarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.voltarMenu.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold);
            this.voltarMenu.Location = new System.Drawing.Point(475, 12);
            this.voltarMenu.Name = "voltarMenu";
            this.voltarMenu.Size = new System.Drawing.Size(59, 24);
            this.voltarMenu.TabIndex = 7;
            this.voltarMenu.Text = "Voltar";
            this.voltarMenu.UseVisualStyleBackColor = false;
            this.voltarMenu.Click += new System.EventHandler(this.voltarMenu_Click);
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.limpar.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Location = new System.Drawing.Point(12, 275);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(63, 29);
            this.limpar.TabIndex = 9;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 10;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "O seu IMC é de...";
            // 
            // infoIMC
            // 
            this.infoIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.infoIMC.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold);
            this.infoIMC.Location = new System.Drawing.Point(430, 415);
            this.infoIMC.Name = "infoIMC";
            this.infoIMC.Size = new System.Drawing.Size(104, 23);
            this.infoIMC.TabIndex = 12;
            this.infoIMC.Text = "Saiba Mais!";
            this.infoIMC.UseVisualStyleBackColor = false;
            this.infoIMC.Click += new System.EventHandler(this.infoIMC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjetoPesoIdeal.Properties.Resources._2906550;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(430, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 87);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "*Cálculos válidos apenas para pessoas adultas.";
            // 
            // CalcIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.infoIMC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.voltarMenu);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.imc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalcIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calcule o seu IMC!";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imc;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button voltarMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button infoIMC;
        private System.Windows.Forms.Label label5;
    }
}