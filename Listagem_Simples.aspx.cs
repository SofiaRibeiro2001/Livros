using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex4
{
    public partial class Listagem_Simples : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            int numero = 0;
            // veja a imagem abaixo para saber onde vai buscar o caminho da conexão
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sofia\Desktop\Ex4\App_Data\bd_biblioteca.mdf;Integrated Security=True";

            con = new SqlConnection(connetionString);
            con.Open();

            // Response.Write("Ligado com sucesso!");
            // a linha acima utilizo apenas para ver se a conexão é feita com sucesso

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";

            //Select campo1, campo2,... from NOME_TABELA;
            sql = "Select Id, nome, n_paginas, tamanho from livro";

            command = new SqlCommand(sql, con);

            dataReader = command.ExecuteReader();
            Response.Write("<h1>Listagem dos livros</h1>");
            //Enquanto houver dados para ler
            while (dataReader.Read())
            { 
                Output = Output + dataReader.GetValue(0) + " --- " + dataReader.GetValue(1) + 
                    " --- " + dataReader.GetValue(2) + " --- " + dataReader.GetValue(3) + "</br>";
                numero = numero + 1;
            }
            Response.Write(Output); 
            dataReader.Close(); 
            con.Close();
            Response.Write("<h4>Nº de regitos na base de dados: " + numero + "</h4>");
        }

    }
}