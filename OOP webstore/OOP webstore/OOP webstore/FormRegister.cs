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
    public partial class FormRegister : Form
    {
        private readonly List<User> m_usersList = new List<User>();
        public event Action<string, string, string> OnDataSubmitted;

        public FormRegister(List<User> userList)
        {
            InitializeComponent();
            m_usersList = userList;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0)
                return;
            if (textBoxLogin.Text.Length == 0) 
                return;
            if (textBoxPassword.Text.Length == 0) 
                return;
            if (textBoxPasswordRepeat.Text.Length == 0) 
                return;
            
            if (textBoxPassword.Text != textBoxPasswordRepeat.Text) 
                return;

            foreach(User user in m_usersList)
            {
                if (user.Login == User.GetHash(textBoxLogin.Text))
                    return;
            }

            OnDataSubmitted?.Invoke(textBoxName.Text, User.GetHash(textBoxLogin.Text), User.GetHash(textBoxPassword.Text));

            Close();
        }

        private void ButtonDeny_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonShowPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPasswordRepeat.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPasswordRepeat.UseSystemPasswordChar = true;
            }
        }
    }
}
