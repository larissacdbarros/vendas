using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula31
{
    public partial class Form1 : Form
    {
        public double total { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnInsereProduto_Click(object sender, EventArgs e)
        {

           
            listBoxProduto.Items.Add(txtProduto.Text);
            listBoxPreco.Items.Add(txtPreco.Text);
            total += double.Parse(txtPreco.Text) ;
            lblTotal.Text = "R$" + total;

            listBoxProduto.Show();
            listBoxPreco.Show();
            txtProduto.Clear();
            txtPreco.Clear();


        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (listBoxProduto.SelectedIndex != -1)
            {
                
                int i = listBoxProduto.SelectedIndex;
                listBoxProduto.Items.RemoveAt(i);
                listBoxPreco.Items.RemoveAt(i);
                
                total -= double.Parse(listBoxPreco.Items[i].ToString());
                lblTotal.Text = "R$" + total;
            }
        }
    }
}
