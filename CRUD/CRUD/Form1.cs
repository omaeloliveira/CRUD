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
            // TODO: esta linha de código carrega dados na tabela 'cRUDDataSet.Cadastro'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroTableAdapter.Fill(this.cRUDDataSet.Cadastro);
            CarregarDados();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            conn.command = new SqlCommand("insert into Cadastro (Nome, Celular) " +
                "values (@nome, @celular)", conn.connection);
            conn.connect();

            try
            {
                conn.command.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                conn.command.Parameters.Add(new SqlParameter("@celular", mskCel.Text));
            }
            catch (SqlException)
            {

            }
            finally
            {
                conn.disconnect();
            }
        }

        private void MskCel_Enter(object sender, EventArgs e)
        {
            this.mskCel.Mask = "(00) 00000-0000";
        }

        private void MskCel_Leave(object sender, EventArgs e)
        {
            if (this.mskCel.Text == string.Empty)
                this.mskCel.Mask = "";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(this);
        }

        //private void LimparCampos()
        //{
        //    throw new NotImplementedException();
        //}

        private void CarregarDados()
        {
            conn.command = new SqlCommand("select Nome = @nome and Celular = @celular from Cadastro", conn.connection);

            try
            {
                conn.connect();
                conn.dr = conn.command.ExecuteReader();

                if (conn.dr.HasRows)
                {
                    conn.dt.Load(conn.dr);
                }
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

        public void LimparCampos(Control control)
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

        
    }
}
