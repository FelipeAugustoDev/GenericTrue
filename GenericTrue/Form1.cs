using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GenericTrue
{

    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JR3N1R7;Initial Catalog=ENTERPRISE;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        Log log = new Log();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txbCodigo.Enabled = false;
            txbNome.Text = "Felipe Augusto";
            txbCPF.Text = "352348534-x";
            txbEndereco.Text = "Rua Feliz";
            txbNascimento.Text = "24/04/2002";
            txbTelefone.Text = "1523-3322";
            txbEmail.Text = "Felipe@gmail.com";
            comando.Connection = conn;
            VerificarRepeticao();
            carregarLista();
        }
        public void LimparControles()
        {
            txbNome.Clear();
            txbCodigo.Clear();
            txbCPF.Clear();
            txbEndereco.Clear();
            txbNascimento.Clear();
            txbTelefone.Clear();
            txbEmail.Clear();
        }

        private void carregarLista() 
        {
            conn.Open();
            comando.CommandText = "select * from Clientes"; 
            dr = comando.ExecuteReader();	

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lboCodigo.Items.Add(dr[0].ToString());
                    lboNome.Items.Add(dr[1].ToString());
                    lboCPF.Items.Add(dr[2].ToString());
                    lboEndereco.Items.Add(dr[3].ToString());
                    lboNascimento.Items.Add(dr[4].ToString());
                    lboTelefone.Items.Add(dr[5].ToString());
                    lboEmail.Items.Add(dr[6].ToString());
                }
            }
            conn.Close();
        }
        public void LimparLista()
        {
            lboCodigo.Items.Clear();
            lboNome.Items.Clear();
            lboCPF.Items.Clear();
            lboEndereco.Items.Clear();
            lboNascimento.Items.Clear();
            lboTelefone.Items.Clear();
            lboEmail.Items.Clear();

        }
        public void VerificarRepeticao()
        {
            foreach (var item in lboCPF.Items)
            {
                int i = 0;
                if (lboCPF.Items[lboCPF.Items.Count - 1] == lboCPF.Items[i])
                {
                    MessageBox.Show("CPF INVÁLIDO!");
                }
                i++;
            }
        }
        public void Selecao(object sender)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lboCodigo.SelectedIndex = l.SelectedIndex;
                lboCPF.SelectedIndex = l.SelectedIndex;
                lboNome.SelectedIndex = l.SelectedIndex;
                lboEndereco.SelectedIndex = l.SelectedIndex;
                lboNascimento.SelectedIndex = l.SelectedIndex;
                lboTelefone.SelectedIndex = l.SelectedIndex;
                lboEmail.SelectedIndex = l.SelectedIndex;

                txbCodigo.Text = lboCodigo.SelectedItem.ToString();   //IMPRIMIR OS DADOS DO CLIENTE CLICADO NO TEXTBOX
                txbNome.Text = lboNome.SelectedItem.ToString();
                txbCPF.Text = lboCPF.SelectedItem.ToString();
                txbEndereco.Text = lboEndereco.SelectedItem.ToString();
                txbNascimento.Text = lboNascimento.SelectedItem.ToString();
                txbTelefone.Text = lboTelefone.SelectedItem.ToString();
                txbEmail.Text = lboEmail.SelectedItem.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            conn.Open();
            comando.CommandText = "insert into CLIENTES(nome, cpf, endereco, datanascimento,telefone,email) values ('" + txbNome.Text.ToUpper() + "','" + txbCPF.Text + "','" + txbEndereco.Text.ToUpper() + "','" + txbNascimento.Text + "','" + txbTelefone.Text + "','" + txbEmail.Text.ToUpper() + "')";
            comando.ExecuteNonQuery();
            conn.Close();
            LimparLista();
            carregarLista();
            log.logando(0, "Subindo new cliente");
            
        }



        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Você deseja excluir este elemento?", "Deseja Confirmar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                conn.Open();
                comando.CommandText = "delete from CLIENTES where id = '" + txbCodigo.Text + "'";
                comando.ExecuteNonQuery();
                conn.Close();
                LimparLista();
                carregarLista();
                MessageBox.Show("O Elemento foi Excluído com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                log.logando(1, "Cliente Removido");
            }
            else { MessageBox.Show("A operação foi cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }


        private void lboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selecao(sender);
        }

        private void lboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selecao(sender);
        }

        private void lboCPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selecao(sender);
        }

        private void lboEndereco_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selecao(sender);
        }

        private void lboNascimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selecao(sender);
        }

        private void lboTelefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selecao(sender);
        }

        private void lboEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selecao(sender);
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparControles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //PRECISA COLOCAR PRA SÓ CONSEGUIR EDITAR >CASO< TENHA ALGUM INDEX SELECIONADO 
            
            conn.Open();
            comando.CommandText = "update CLIENTES set nome ='" + txbNome.Text.ToUpper() + "',cpf ='" + txbCPF.Text + "',endereco='" + txbEndereco.Text.ToUpper() + "',datanascimento='" + txbNascimento.Text + "',telefone='" + txbTelefone.Text + "',email='" + txbEmail.Text.ToUpper() + "' where id='" + lboCodigo.SelectedItem.ToString() + "'";
            comando.ExecuteNonQuery();
            conn.Close();
            LimparLista();
            carregarLista();
            log.logando(1, "Cliente Editado");
        }
    }
}
