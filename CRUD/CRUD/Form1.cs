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

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Connection conn = new Connection();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cRUDDataSet1.Cadastro'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroTableAdapter.Fill(this.cRUDDataSet1.Cadastro);
            CarregarDados();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            conn.command = new SqlCommand("select Nome, Celular, Telefone from Cadastro " +
                "where Nome = @nome and Celular = @cel and Telefone = @tel", conn.connection);
            conn.connect();
            conn.command.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            conn.command.Parameters.Add("@cel", SqlDbType.VarChar).Value = mskCel.Text;
            conn.command.Parameters.Add("@tel", SqlDbType.VarChar).Value = mskTel.Text;

            object verifica = conn.command.ExecuteScalar();

            if (verifica != null)
            {

            }
            else
            {
                conn.command = new SqlCommand("insert into Cadastro (Nome, Celular, Endereco, Telefone) " +
                    "values (@nome, @celular, @endereco, @telefone)", conn.connection);
                conn.connect();

                try
                {
                    conn.command.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                    conn.command.Parameters.Add(new SqlParameter("@celular", mskCel.Text));
                    conn.command.Parameters.Add(new SqlParameter("@endereco", txtEnd.Text));
                    conn.command.Parameters.Add(new SqlParameter("@telefone", mskTel.Text));
                }
                catch (SqlException)
                {

                }
                finally
                {
                    conn.disconnect();
                }
            }
        }

        private void MskCel_Enter(object sender, EventArgs e)
        {
            this.mskCel.Mask = "(00) 00000-0000";
        }

        private void MskCel_Leave(object sender, EventArgs e)
        {
            Mascaras(this.mskCel, this);
        }

        private void MskTel_Enter(object sender, EventArgs e)
        {
            this.mskTel.Mask = "(00) 0000-0000";
        }

        private void MskTel_Leave(object sender, EventArgs e)
        {
            Mascaras(this.mskTel, this);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(this);
        }

        private void Mascaras(MaskedTextBox msk, object sender)
        {
            if (msk.Text == string.Empty)
                msk.Mask = "";
        }

        private void CarregarDados()
        {
            conn.command = new SqlCommand("select Nome, Celular, Endereco, Telefone" +
                " from Cadastro", conn.connection); ;

            try
            {
                conn.connect();
                conn.command.CommandType = CommandType.Text;
                conn.da = new SqlDataAdapter(conn.command);
                conn.da.Fill(conn.dt);
                dgvDados.DataSource = conn.dt;
            }
            catch (SqlException msg)
            {
                MessageBox.Show(msg.Message);
            }
            finally
            {
                conn.disconnect();
            }
        }

        private void LimparCampos(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = string.Empty;
                }
                if(ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)(ctrl)).Text = string.Empty;
                    ((MaskedTextBox)(ctrl)).Mask = "";
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }        
    }
}
