using Csharp_and_Database;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Backup2
{
    public partial class Form2 : Form
    {
        Classe_produto pct = new Classe_produto();

        Classe_produto CP = new Classe_produto();
        Connection cn = new Connection();

        double preco3;
        double desconto;
        public Form2(Classe_produto Produto, float tam, int cod)
        {
            InitializeComponent();
            pictureBox1.Image = Produto.imagem;
            label123.Text = Produto.nome;
            label123.Font = new Font(label123.Font.FontFamily, tam);
            preco.Text = Produto.preco.ToString();

            String[] itens = { "Pix", "Crédito", "Débito" };

            for (int i = 0; i < itens.Length; i++)
            {
                comboBox1.Items.Add(itens[i]);
            }
            DataTable dados;
            dados = cn.obterdados("Select * from produto where Cod_prod = " + cod);
            CP.nome = dados.Rows[0][1].ToString();
            CP.preco = float.Parse(dados.Rows[0][2].ToString());
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click_1(object sender, EventArgs e)
        {
            //Connection cn = new Connection();
            //string preco = cn.obterdados("Select produto.preco_prod from produto where Cod_prod = 1").ToString();
            //label123.Text = preco;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {

                preco3 = CP.preco;
                desconto = preco3 - preco3 * 0.05;

                MessageBox.Show("Detalhes do pedido: " + CP.nome);
                MessageBox.Show("Valor total com desconto: R$" + desconto);
            }
            else
            {
                desconto = preco3;
                MessageBox.Show("Detalhes do pedido: " + CP.nome);
                MessageBox.Show("Valor total sem desconto: R$" + CP.preco);
            }

            Form3 form3 = new Form3(pct);
            form3.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
