using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class Login : System.Web.UI.Page
	{
		string connectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

		protected void buttonLogin_Click(object sender, EventArgs e)
		{
			if (txbKorisnickoIme.Text == "" || txbLozinka.Text == "")
			{
				lblGreska.Text = "Popunite sva polja!";
				return;
			}

			if (CheckUser())
			{
				Response.Redirect("Shop.aspx");
			}
			else
			{
				lblGreska.Text = "Korisnik ne postoji!";
			}
		}

		private bool CheckUser()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand comm = new SqlCommand("SELECT * FROM Users WHERE username = @username AND password = @password", conn);
			comm.Parameters.AddWithValue("username", txbKorisnickoIme.Text);
			comm.Parameters.AddWithValue("password", txbLozinka.Text);

			try
			{
				conn.Open();
				SqlDataReader reader = comm.ExecuteReader();
				if (reader.HasRows)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				lblGreska.Text = ex.Message;
				return false;
			}
			finally
			{
				conn.Close();
			}
		}
	}
}