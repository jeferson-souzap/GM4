using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GM4
{
    public partial class Form_janela_cad_prestadores : Form
    {
        public Form_janela_cad_prestadores()
        {
            InitializeComponent();
            Carregar_grid();
        }

        private void cadastro_executante(string nome)
        {

        }


        private int Validar_telefone(string telefone)
        {
            Regex telefone_rex = new Regex(@"(\+?55)?(0?(([14689][1-9])|(2[12478])|(3[1234578])|(5[1345])|(7[134579])))9[6-9][0-9]{7}");
            var tele_macht = telefone_rex.Match(telefone);

            if (tele_macht.Success)
            {
                return 1;                
            }
            return 0;

        }
        private int Validar_email(string email)
        {
            Regex telefone_rex = new Regex(@"/^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/");
            var tele_macht = telefone_rex.Match(email);

            if (tele_macht.Success)
            {
                return 1;
            }
            return 0;

        }
        private void Valida_campos()
        {
            if(text_empresa.Text == string.Empty && text_nome.Text == string.Empty && text_cargo.Text == string.Empty && text_telefone.Text == string.Empty && text_email.Text == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos!");
                return;
            }

            Salvar_prestador();

        }

        private void Carregar_prestadores(string id_prestadores)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_cad_prestadores where id_prestadores = " + Convert.ToInt32(id_prestadores) + "";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_empresa.Text = myreader["empresa"].ToString();
                    text_nome.Text = myreader["nome"].ToString();
                    text_telefone.Text = myreader["telefone"].ToString();
                    text_email.Text = myreader["email"].ToString(); ;
                    text_cargo.Text = myreader["funcao"].ToString();

                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_grid()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_cad_prestadores";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_cad_prestadores");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("status like '%{0}%'", status);
                Grid_cad_prestadores.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }       
        private void Salvar_prestador()
        {

            string empresa = text_empresa.Text;
            string nome = text_nome.Text;
            string telefone = text_telefone.Text;
            string email = text_email.Text;
            string funcao = text_cargo.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cad_prestadores(empresa, nome, telefone, email, funcao) VALUES('" + empresa + "','" + nome + "','"+ telefone + "','" + email+ "','"+ funcao + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Atualizar_prestadores(string id_prestadores)
        {

            string empresa = text_empresa.Text;
            string nome = text_nome.Text;
            string telefone = text_telefone.Text;
            string email = text_email.Text;
            string funcao = text_cargo.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cad_prestadores SET " +
                        "empresa='" + empresa +
                        "', nome='" + nome +
                        "', telefone='" + telefone +
                        "', email='" + email +
                        "', funcao='" + funcao +
                        "' WHERE id_prestadores=" + Convert.ToInt32( id_prestadores) + "";


                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Deletar_prestador(string id_prestadores)
        {            

            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cad_prestadores WHERE id_prestadores = '"+ Convert.ToInt32(id_prestadores) +"'";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void text_telefone_Leave(object sender, EventArgs e)
        {            
            if(Validar_telefone(text_telefone.Text) == 0)
            {
                MessageBox.Show("Telefone Invalido!");
            }
            
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Salvar como Executante ?", "Cadastro", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form_janela_executante cad_exe = new Form_janela_executante();
                cad_exe.Salvar_executante_terceiros(text_nome.Text, "10");

                Valida_campos();
                MessageBox.Show("Salvo com sucesso!");
                Carregar_grid();
            }
            else { 

            Valida_campos();
            MessageBox.Show("Salvo com sucesso!");
            Carregar_grid();
            }
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_prestadores(label_id_prestadores.Text);
            MessageBox.Show("Atualizado com sucesso!");
            Carregar_grid();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            Deletar_prestador(label_id_prestadores.Text);
            MessageBox.Show("Deletado com sucesso!");
            Carregar_grid();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_cad_prestadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id_prestadores.Text = Grid_cad_prestadores.CurrentRow.Cells[0].Value.ToString();
            Carregar_prestadores(label_id_prestadores.Text);
        }
    }
}
