using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class Registracija2 : System.Web.UI.Page
	{
		string connectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

		protected void buttonReg_Click(object sender, EventArgs e)
		{
			if (txbKorisnickoIme.Text == "" || txbLozinka.Text == "" || txbPunoIme.Text == "")
			{
				lblGreska.Text = "Popunite sva polja!";
				return;
			}

			if (txbLozinka.Text != txbPonovljenaLozinka.Text)
			{
				lblGreska.Text = "Lozinke se ne podudaraju!";
				return;
			}

			if (!CheckUser())
			{
				AddUser();
			}
			else
			{
				lblGreska.Text = "Korisnik već postoji!";
			}

		}

		private bool CheckUser()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand comm = new SqlCommand("SELECT * FROM Users WHERE username = @username", conn);
			comm.Parameters.AddWithValue("username", txbKorisnickoIme.Text);

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
				lblGreska.Text = "Došlo je do pogreške!";
				return false;
			}
			finally
			{
				conn.Close();
			}
		}

		private void AddUser()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand comm = new SqlCommand("INSERT INTO Users VALUES (@username, @password, @fullname ) ", conn);
			comm.Parameters.AddWithValue("username", txbKorisnickoIme.Text);
			comm.Parameters.AddWithValue("password", txbLozinka.Text);
			comm.Parameters.AddWithValue("fullname", txbPunoIme.Text);

			try
			{
				conn.Open();
				int result = comm.ExecuteNonQuery();
				if (result == 1)
				{
					Response.Redirect("Login.aspx");
				}
			}
			catch (Exception ex)
			{
				lblGreska.Text = "Došlo je do pogreške!";
			}
			finally
			{
				conn.Close();
			}
		}

		
	}
}