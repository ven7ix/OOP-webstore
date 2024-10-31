using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_webstore
{
    public partial class FormLogin : Form
    {
        private readonly List<User> m_usersList;
        public Action<string> OnDataSubmitted;

        public FormLogin(List<User> usersList)
        {
            m_usersList = usersList;
            InitializeComponent();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            foreach(User user in m_usersList)
            {
                if (User.GetHash(login) == user.Login && User.GetHash(password) == user.Password)
                {
                    user.IsLoggedIn = true;
                    OnDataSubmitted?.Invoke(user.Name);
                    Close();
                }
            }
            
        }

        private void ButtonDeny_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonShowPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
