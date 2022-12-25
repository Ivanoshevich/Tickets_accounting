using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beltelekom.DBEntity;
using Beltelekom.Forms;

namespace Beltelekom
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text;
            string psw = textPsw.Text;
            using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
            {
                var user = db.User.Where(u => u.Login.Equals(login) && u.Password.Equals(psw)).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Неверный логин и/или пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Hide();
                    MainForm form = new MainForm();
                    form.ShowDialog();
                    Close();

                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
