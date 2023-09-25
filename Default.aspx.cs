using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Epicobox
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select IdEsperienza, Nome, DescrizioneBreve, Prezzo, ImageBox, NomeLocation from Esperienze INNER JOIN Location ON Esperienze.Location = Location.IdLocation ", conn);
            SqlDataReader sqlDataReader;

            conn.Open();

            List<Prodotto > esperienze = new List<Prodotto>();
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
                esperienze.Add(esperienza);

            }
            Repeater1.DataSource = esperienze;
            Repeater1.DataBind();
            conn.Close();
            cmd = new SqlCommand("select * from Categoria", conn);
            conn.Open();

            List<Prodotto> categorie = new List<Prodotto>();
            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Prodotto categoria = new Prodotto();
                categoria.Categoria = sqlDataReader["NomeCategoria"].ToString();
                categorie.Add(categoria);

            }
            Repeater2.DataSource = categorie;
            Repeater2.DataBind();
        }
    }

    public class Prodotto
    {
        public int IdEsperienza { get; set; }
        public string Nome { get; set; }
        public string DescrizioneBreve { get; set; }
        public string DescrizioneLunga { get; set; }
        public decimal Prezzo { get; set; }
        public string ImageBox { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public string Location { get; set; }
        public string Categoria { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public int Quantity { get; set; }
        public Prodotto() { }
        public Prodotto(int id,string nome, string descrizioneBreve, string descrizioneCompleta, decimal prezzo, string image, string location, string categoria, DateTime dataInizio, DateTime dataFine, string image1, string image2, string image3, string image4, int quantity)
        {
            IdEsperienza = id;
            Nome = nome;
            DescrizioneBreve = descrizioneBreve;
            DescrizioneLunga = descrizioneCompleta;
            Prezzo = prezzo;
            ImageBox = image;
            DataInizio = dataInizio;
            DataFine = dataFine;
            Location = location;
            Categoria = categoria;
            Image1 = image1;
            Image2 = image2;
            Image3 = image3;
            Image4 = image4;
            Quantity = quantity;
        }
    }
}