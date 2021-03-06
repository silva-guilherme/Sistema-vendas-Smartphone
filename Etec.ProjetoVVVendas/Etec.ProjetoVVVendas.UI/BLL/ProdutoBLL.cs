﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.ProjetoVVVendas.UI.DAO;
using Etec.ProjetoVVVendas.UI.DTO;

namespace Etec.ProjetoVVVendas.UI.BLL
{
    public class ProdutoBLL
    {
        DAO.ProdutoDAO produto = null;
        public ProdutoBLL()
        {

        }

        public DataTable selecionaProdutos()
        {
            DataTable dt = new DataTable();
            try
            {
                produto = new DAO.ProdutoDAO();
                dt = produto.SelectProduto();

            }
            catch(Exception erro)
            {
                erro.Message.ToString();
            }
            return dt;
        }

        public void NovoProdutoEntrada(Produto prod)
        {
             
            try
            {
                produto = new DAO.ProdutoDAO();
                produto.insertEntrada(prod);
                MessageBox.Show("Cadastrado com sucesso");
                
            }
            catch(Exception erro)
            {

            }
        }

        public void NovoProdutoSaida(Produto prod)
        {
            try
            {
                produto = new ProdutoDAO();
                produto.insertSaida(prod);
                MessageBox.Show("Cadastrado com sucesso");
            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possivel realizar o cadastro.");
                MessageBox.Show("Erro:" + erro);
            }
        }

        public void AlteraProduto(Produto prod)
        {
            try
            {
                produto = new DAO.ProdutoDAO();
                //produto.updateProduto(prod);
            }
            catch(Exception erro)
            {
                throw erro;
            }

        }

        public void ExcluirProduto(Produto prod)
        {
            try
            {
                produto = new DAO.ProdutoDAO();
                //produto.deleteProduto(prod);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public List<Produto> ListarProdutos()
        {
            try
            {
                produto = new DAO.ProdutoDAO();
                return produto.selectListProdutos();
            }
            catch(Exception erro)
            {
                throw erro;
            }
            
        }

       

    }
}
