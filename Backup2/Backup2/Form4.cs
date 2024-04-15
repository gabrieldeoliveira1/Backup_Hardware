using Csharp_and_Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup2
{
    public partial class Form4 : Form
    {
        string produto;
        Classe_produto CP = new Classe_produto(); //Se precisar usar tá ai.

        public Form4(Classe_produto Produto, string dados)
        {
            CP = Produto;


            produto = dados;
            InitializeComponent();

            label2.Text = Produto.preco.ToString();

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = CP.imagem;
            comboBox1.Items.Add(produto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
