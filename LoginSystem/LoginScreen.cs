using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibrarySystem
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("server=marmlap118; initial catalog=LibraryProjectWithLoginScreen; integrated security=SSPI");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbxUserName.Text))
                {
                    throw new Exception("Please enter a username!!");
                }
                else if (string.IsNullOrEmpty(tbxPassword.Text))
                {
                    throw new Exception("Please enter a passwd");
                }

                else
                {
                    connection.Open();
                    string UserName;
                    string Password;
                    UserName = tbxUserName.Text;
                    Password = tbxPassword.Text;

                    SqlCommand cmd = new SqlCommand("Select * from Admin where username='" + UserName + "' and password='" + Password + "'", connection);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        LibraryProject libraryProject = new LibraryProject();
                        this.Visible = false;
                        libraryProject.ShowDialog();
                        this.Visible = true;
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("incorrect username or passwd\nplease check username or passwd", "developer by oxyyylesnar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
