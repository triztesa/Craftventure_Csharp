﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using GerenciadorDeEstoque.Apresentacao;
using GerenciadorDeEstoque.DAO;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEstoque.Apresentacao
{
    public partial class frmLogin : KryptonForm
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private DAO.Conexao conexao;
        private UsuarioVO usuarioVO;
        private Int32 catchRowIndex;

        private void txtNome_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            lblNome.Visible = false;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSenha.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            //pq não funciona????????
            /*conexao = new DAO.Conexao();
            usuarioVO = new UsuarioVO();
            string connectionString = conexao.getConnectionString();
            string query = "SELECT * FROM estoque";
            using (MySqlConnection conn = new MySqlConnection(connectionString))*/

            conexao = new DAO.Conexao();
            usuarioVO = new UsuarioVO();


            if (txtNome.Text == usuarioVO.Nome && txtSenha.Text == usuarioVO.Senha){
                frmMenuCadastro Menu = new frmMenuCadastro();

                Menu.Show();
            }

            else{
                MessageBox.Show("Login invalido");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();

            frmCadastro.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
