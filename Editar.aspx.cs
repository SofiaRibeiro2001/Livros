using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex4
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            // veja a imagem abaixo para saber onde vai buscar o caminho da conexão
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sofia\Desktop\Ex4\App_Data\bd_biblioteca.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            // Response.Write("Ligado com sucesso!");
            // a linha acima utilizo apenas para ver se a conexão é feita com sucesso
            
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            sql = "Select Id, nome, n_paginas, tamanho from livro";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            Response.Write("<h1>Editar Utilizadores</h1><br/>");
            Response.Write("<table border='1'>");
            //cria uma linha
            Response.Write("<tr>");
            //th é o cabeçalho da tabela
            Response.Write("<th>Id</th>");
            Response.Write("<th>Nome</th>");
            Response.Write("<th>Nº Pag.</th>");
            Response.Write("<th>Tamanho.</th>");
            Response.Write("<th>Ação</th>");
            Response.Write("</tr>");
            while (dataReader.Read())
            {
                Response.Write("<tr>");
                // table data (valor de uma celula)
                Response.Write("<td>" + dataReader.GetValue(0) + "</td>");
                Response.Write("<td>" + dataReader.GetValue(1) + "</td>");
                Response.Write("<td>" + dataReader.GetValue(2) + "</td>");
                Response.Write("<td>" + dataReader.GetValue(3) + "</td>");
                Response.Write("<td><input type= 'button' Value='Editar'onclick=window.open('Editar2.aspx?id=" + dataReader.GetValue(0) + "') />&nbsp<input type='button' Value='Eliminar' onclick=window.open('Eliminar.aspx?id=" + dataReader.GetValue(0) + "') /></td>");
                Response.Write("</tr>");
            }
            Response.Write("</table>");
            dataReader.Close();
            con.Close();
        }
    }
}