using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicobox
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            


            if (!IsPostBack)
            {
               


                if ((string)Session["User"] != "Admin")
                {
                    Session["User"] = null;
                    Response.Redirect("../Login.aspx");
                    return; 
                }

                if (!string.IsNullOrEmpty(Request.QueryString["IdEsperienza"]))
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString.ToString();
                    SqlConnection conn = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand("select * from Esperienze WHERE IdEsperienza=@id", conn);
                    cmd.Parameters.AddWithValue("id", Request.QueryString["IdEsperienza"]);
                    conn.Open();
                    SqlDataReader sqlreader;
                    sqlreader = cmd.ExecuteReader();
                    while (sqlreader.Read())
                    {
                        nomeEsperienza.Text = sqlreader["Nome"].ToString();
                        prezzo.Text = sqlreader["Prezzo"].ToString();
                        descrizioneBreve.Text = sqlreader["descrizioneBreve"].ToString();
                        descrizioneLunga.Text = sqlreader["DescrizioneLunga"].ToString();
                        dataInizio.Text = Convert.ToDateTime(sqlreader["DataInizio"]).ToString("yyyy-MM-dd");
                        dataFine.Text = Convert.ToDateTime(sqlreader["DataFine"]).ToString("yyyy-MM-dd");
                        DropDownList2.SelectedValue = sqlreader["Location"].ToString();
                        DropDownList1.SelectedValue = sqlreader["Categoria"].ToString();
                    }

                    conn.Close();
                    aggiungi.Visible = false;
                }

                else
                {
                    modifica.Visible = false;
                    elimina.Visible = false;
                }
            }
        }


        protected void aggiungiEsperienza(object sender, EventArgs e)
        {
            string imagebox = "";
            string image1 = "";
            string image2 = "";
            string image3 = "";
            string image4 = "";
            string connectionString= ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString.ToString();
            SqlConnection conn=new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Esperienze Values ( @Nome, @Categoria, @Prezzo, @DescrizioneBreve, @DescrizioneLunga, @ImageBox, @Image1, @Image2, @Image3, @Image4, @Location, @DataInizio, @DataFine ) ";
            cmd.Parameters.AddWithValue("Nome", nomeEsperienza.Text);
            cmd.Parameters.AddWithValue("Categoria", DropDownList2.SelectedItem.Value);
            cmd.Parameters.AddWithValue("Prezzo", prezzo.Text);
            cmd.Parameters.AddWithValue("DescrizioneBreve", descrizioneBreve.Text);
            cmd.Parameters.AddWithValue("DescrizioneLunga", descrizioneLunga.Text);
            if (!fileUpload1.HasFile)
            {
                cmd.Parameters.AddWithValue("ImageBox", imagebox);
            }
            else
            {
                cmd.Parameters.AddWithValue("ImageBox", fileUpload1.FileName);
                fileUpload1.SaveAs(Server.MapPath($"../Content/Img/{fileUpload1.FileName}"));
            }

            if (!fileUpload2.HasFile)
            {
                cmd.Parameters.AddWithValue("Image1", image1);
            }
            else
            {
                cmd.Parameters.AddWithValue("Image1", fileUpload2.FileName);
                fileUpload2.SaveAs(Server.MapPath($"../Content/Img/{fileUpload2.FileName}"));
            }

            if (!fileUpload3.HasFile)
            {
                cmd.Parameters.AddWithValue("Image2", image2);
            }
            else
            {
                cmd.Parameters.AddWithValue("Image2", fileUpload3.FileName);
                fileUpload3.SaveAs(Server.MapPath($"../Content/Img/{fileUpload3.FileName}"));
            }

            if (!fileUpload4.HasFile)
            {
                cmd.Parameters.AddWithValue("Image3", image3);
            }
            else
            {
                cmd.Parameters.AddWithValue("Image3", fileUpload4.FileName);
                fileUpload4.SaveAs(Server.MapPath($"../Content/Img/{fileUpload4.FileName}"));
            }

            if (!fileUpload5.HasFile)
            {
                cmd.Parameters.AddWithValue("Image4", image4);
            }
            else
            {
                cmd.Parameters.AddWithValue("Image4", fileUpload5.FileName);
                fileUpload5.SaveAs(Server.MapPath($"../Content/Img/{fileUpload5.FileName}"));
            }
            cmd.Parameters.AddWithValue("Location", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("DataInizio", dataInizio.Text);
            cmd.Parameters.AddWithValue("DataFine", dataFine.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect(Request.RawUrl);

        }

        protected void modifica_Click(object sender, EventArgs e)
        {
            string imagebox = "";
            string image1 = "";
            string image2 = "";
            string image3 = "";
            string image4 = "";
            string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"]
          .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Esperienze WHERE IdEsperienza=@id";
            cmd.Parameters.AddWithValue("id", Request.QueryString["IdEsperienza"]);
            SqlDataReader sqlreader;
            conn.Open();
            sqlreader = cmd.ExecuteReader();
            while (sqlreader.Read())
            {
                imagebox = sqlreader["ImageBox"].ToString();
                image1 = sqlreader["Image1"].ToString();
                image2 = sqlreader["Image2"].ToString();
                image3 = sqlreader["Image3"].ToString();
                image4 = sqlreader["Image4"].ToString();
            }
            conn.Close();
            conn.Open();

            try { 
            cmd.CommandText = "UPDATE Esperienze SET Nome=@Nome, Categoria=@Categoria, Prezzo=@Prezzo, DescrizioneBreve=@DescrizioneBreve, DescrizioneLunga=@DescrizioneLunga, ImageBox=@ImageBox, Image1=@Image1, Image2=@Image2, Image3=@Image3, Image4=@Image4, Location=@Location, DataInizio=@DataInizio, DataFine=@DataFine where IdEsperienza=@id";
            cmd.Parameters.AddWithValue("Nome", nomeEsperienza.Text);
            cmd.Parameters.AddWithValue("DescrizioneBreve", descrizioneBreve.Text);
            cmd.Parameters.AddWithValue("DescrizioneLunga", descrizioneLunga.Text);
            decimal prezzoValue = Decimal.Parse(prezzo.Text);
            cmd.Parameters.AddWithValue("Prezzo", prezzoValue);
            cmd.Parameters.AddWithValue("DataInizio", dataInizio.Text);
            cmd.Parameters.AddWithValue("DataFine", dataFine.Text);
            cmd.Parameters.AddWithValue("Location", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("Categoria", DropDownList2.SelectedItem.Value);
            if (!fileUpload1.HasFile)
            {
                cmd.Parameters.AddWithValue("ImageBox", imagebox);
            }
            else
            {
                cmd.Parameters.AddWithValue("ImageBox", fileUpload1.FileName);
                fileUpload1.SaveAs(Server.MapPath($"../Content/Img/{fileUpload1.FileName}"));
            }

            if (!fileUpload2.HasFile)
            {
                cmd.Parameters.AddWithValue("Image1", image1);
            }
            else
            {
                cmd.Parameters.AddWithValue("Image1", fileUpload2.FileName);
                fileUpload2.SaveAs(Server.MapPath($"../Content/Img/{fileUpload2.FileName}"));
            }

            if (!fileUpload3.HasFile)
            {
                cmd.Parameters.AddWithValue("Image2", image2);
            }
            else
            {
                cmd.Parameters.AddWithValue("Image2", fileUpload3.FileName);
                fileUpload3.SaveAs(Server.MapPath($"../Content/Img/{fileUpload3.FileName}"));
            }

            if (!fileUpload4.HasFile)
            {
                cmd.Parameters.AddWithValue("Image3", image3);
            }
            else
            {
                cmd.Parameters.AddWithValue("Image3", fileUpload4.FileName);
                fileUpload4.SaveAs(Server.MapPath($"../Content/Img/{fileUpload4.FileName}"));
            }

            if (!fileUpload5.HasFile)
            {
                cmd.Parameters.AddWithValue("Image4", image4);
            }
            else
            {
                cmd.Parameters.AddWithValue("Image4", fileUpload5.FileName);
                fileUpload5.SaveAs(Server.MapPath($"../Content/Img/{fileUpload5.FileName}"));
            }

            cmd.ExecuteNonQuery();
                Label1.Visible = true;
            }
            catch
            {
                Response.Write("Modifica non riuscita");
            }
            finally
            {
                conn.Close();
                
                //Response.Redirect(Request.RawUrl);
            }

        }

      

        protected void elimina_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"]
           .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Esperienze where IdEsperienza=@id";
            cmd.Parameters.AddWithValue("id", Request.QueryString["IdEsperienza"]);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            Response.Redirect("../Default.aspx");
        }
    }
}

