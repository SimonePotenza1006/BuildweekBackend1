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
    public partial class Details : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;




                string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString.ToString();
                SqlConnection conn = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand("SELECT Esperienze.*, NomeCategoria, NomeLocation FROM Esperienze " +
                                                "LEFT JOIN Categoria ON Esperienze.Categoria = Categoria.IdCategoria " +
                                                "LEFT JOIN Location ON Esperienze.Location = Location.IdLocation " +
                                                "WHERE IdEsperienza = @id", conn);
                cmd.Parameters.AddWithValue("id", Request.QueryString["IdEsperienza"]);
                conn.Open();
                SqlDataReader sqlreader;
                sqlreader = cmd.ExecuteReader();
                while (sqlreader.Read())
                {
                    Nome.InnerHtml = sqlreader["Nome"].ToString();
                    decimal prezzo = decimal.Parse(sqlreader["Prezzo"].ToString());
                    Prezzo.InnerHtml = prezzo.ToString("C");
                    DescrizioneLunga.InnerHtml = sqlreader["DescrizioneLunga"].ToString();
                    DateTime DataInizio = DateTime.Parse(sqlreader["DataInizio"].ToString());
                    dataInizio.InnerHtml = DataInizio.ToString("dd/MM/yyyy");
                    DateTime DataFine = DateTime.Parse(sqlreader["DataFine"].ToString());
                    dataFine.InnerHtml = DataFine.ToString("dd/MM/yyyy");
                    location.InnerHtml = sqlreader["NomeLocation"].ToString();
                    categoria.InnerHtml = sqlreader["NomeCategoria"].ToString();
                    imageBox.ImageUrl = $"Content/Img/{sqlreader["ImageBox"].ToString()}";
                    image1.ImageUrl = $"Content/Img/{sqlreader["Image1"].ToString()}";
                    image2.ImageUrl = $"Content/Img/{sqlreader["Image2"].ToString()}";
                    image3.ImageUrl = $"Content/Img/{sqlreader["Image3"].ToString()}";
                    image4.ImageUrl = $"Content/Img/{sqlreader["Image4"].ToString()}";     
                }

                conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Esperienze WHERE IdEsperienza = @id", conn);
            cmd.Parameters.AddWithValue("id", Request.QueryString["IdEsperienza"]);
            conn.Open();
            SqlDataReader sqlreader;
            sqlreader = cmd.ExecuteReader();
            Prodotto prodottoScelto = null;
            while (sqlreader.Read())
            {
                prodottoScelto = new Prodotto
                {
                    Nome = sqlreader["Nome"].ToString(),
                    Prezzo = decimal.Parse(sqlreader["Prezzo"].ToString()) * decimal.Parse(DropDownList1.SelectedItem.Value),
                    DescrizioneLunga = sqlreader["DescrizioneLunga"].ToString(),
                    DescrizioneBreve = sqlreader["DescrizioneBreve"].ToString(),
                    DataInizio = DateTime.Parse(sqlreader["DataInizio"].ToString()),
                    DataFine = DateTime.Parse(sqlreader["DataFine"].ToString()),
                    Location = sqlreader["Location"].ToString(),
                    Categoria = sqlreader["Categoria"].ToString(),
                    ImageBox = sqlreader["ImageBox"].ToString(),
                    Image1 = sqlreader["Image1"].ToString(),
                    Image2 = sqlreader["Image2"].ToString(),
                    Image3 = sqlreader["Image3"].ToString(),
                    Quantity = Convert.ToInt32(DropDownList1.SelectedItem.Value)
                };
            }

            conn.Close();
            List<Prodotto> carrello = Session["Carrello"] as List<Prodotto>;
            if (carrello == null)
            {
                carrello = new List<Prodotto>();
            }
            bool prodottoPresente = false;
            foreach(Prodotto prodotto in carrello)
            {
                if(prodotto.IdEsperienza == prodottoScelto.IdEsperienza)
                {
                    prodotto.Quantity += prodottoScelto.Quantity;
                    prodotto.Prezzo += prodottoScelto.Prezzo;
                    prodottoPresente = true;
                    break;
                }
            }
            if(!prodottoPresente)
            {
                carrello.Add(prodottoScelto);
            }
            Session["Carrello"] = carrello;
            Label1.Visible = true; 
        }
    }
}