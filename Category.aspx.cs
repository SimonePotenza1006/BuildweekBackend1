using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicobox
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string categoria = "";
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select IdEsperienza, Nome, DescrizioneBreve, Prezzo, ImageBox, NomeLocation, NomeCategoria from Esperienze INNER JOIN Location ON Esperienze.Location = Location.IdLocation " + "LEFT JOIN Categoria ON Esperienze.Categoria = Categoria.IdCategoria " + "WHERE NomeCategoria=@Categoria", conn);
            SqlDataReader sqlDataReader;
            cmd.Parameters.AddWithValue("Categoria", Request.QueryString["Categoria"]);
            conn.Open();

            List<Prodotto> esperienze = new List<Prodotto>();
            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Prodotto esperienza = new Prodotto();
                esperienza.IdEsperienza = Convert.ToInt32(sqlDataReader["IdEsperienza"]);
                esperienza.Nome = sqlDataReader["Nome"].ToString();
                esperienza.Location = sqlDataReader["NomeLocation"].ToString();
                esperienza.DescrizioneBreve = sqlDataReader["DescrizioneBreve"].ToString();
                esperienza.Prezzo = Convert.ToDecimal(sqlDataReader["Prezzo"]);
                esperienza.ImageBox = sqlDataReader["ImageBox"].ToString();
                esperienza.Categoria = sqlDataReader["NomeCategoria"].ToString();
                esperienze.Add(esperienza);
                categoria = sqlDataReader["NomeCategoria"].ToString();
            }
            Repeater1.DataSource = esperienze;
            Repeater1.DataBind();
        }
    }
}