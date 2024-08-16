using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex4
{
    public partial class Insere : System.Web.UI.Page
    {
        protected void Button1_Click1(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;

            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sofia\Desktop\Ex4\App_Data\bd_biblioteca.mdf;Integrated Security=True";

            con = new SqlConnection(connetionString);

            con.Open();

            //Response.Write("Ligado com sucesso!");
            //con.Close();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into livro(nome, n_paginas, tamanho) values ('" +
             txt_nome.Text + "', " + txt_npag.Text + ", '" + txt_tam.Text + "')";

            command = new SqlCommand(sql, con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados",
                "alert('Dados inseridos com sucesso');window.location = 'Listagem_Simples.aspx';", true);
        }
    }
}
