using biblioteca.Models;

namespace biblioteca
{
    public partial class Form1 : Form
    {
        List<UserModel> LUser = new List<UserModel>();
        public Form1()
        {
            InitializeComponent();
            LUser.Add(new UserModel
            {
                nameuser = "Luis Lopez",
                password = "5678",
                description = "Administrador"
            });
            LUser.Add(new UserModel
            {
                nameuser = "Pepe Perez",
                password = "1234",
                description = "Bibliotecario"
            });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string User = txtUser.Text;
            string pwd = txtPassword.Text;

            foreach (UserModel admin in LUser)
            {
                if (admin.nameuser == User)
                {
                    if (admin.password == pwd)
                    {
                        cont++;
                    }
                }
            }
            if (cont == 1)
            {
                Home principal = new Home();
                principal.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
