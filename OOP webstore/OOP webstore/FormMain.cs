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
    public partial class FormMain : Form
    {
        private readonly List<User> m_usersList = new List<User>();
        private readonly List<IProduct> m_products = new List<IProduct>();

        public FormMain()
        {
            InitializeComponent();

            m_products.Add(new ProductFood(100, 1, m_products.Count, DateTime.Now));
            m_products.Add(new ProductFood(105, 3, m_products.Count, DateTime.Now));
            m_products.Add(new ProductFood(101, 6, m_products.Count, DateTime.Now));
            m_products.Add(new ProductFood(110, 4, m_products.Count, DateTime.Now));
            m_products.Add(new ProductFood(200, 2, m_products.Count, DateTime.Now));

            foreach (IProduct p in m_products)
                listBoxProducts.Items.Add(p.ProductID.ToString() + '\t' + p.Price.ToString() + '\t' + p.Quantity.ToString());
        }

        public void ButtonRegister_OnDataSubmited(string name, string login, string password)
        {
            User newUser = new User(name, login, password);
            m_usersList.Add(newUser);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister(m_usersList);
            formRegister.OnDataSubmitted += ButtonRegister_OnDataSubmited;
            formRegister.ShowDialog();
        }

        public void ButtonLogin_OnDataSubmited(string name)
        {
            labelUserName.Text = name;
            buttonLogin.Text = "logout";
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (IsSomeoneLogged())
            {
                m_usersList[GetIndexOfCurrentUser()].IsLoggedIn = false;

                labelUserName.Text = "not logged in";
                buttonLogin.Text = "login";
                return;
            }

            FormLogin formLogin = new FormLogin(m_usersList);
            formLogin.OnDataSubmitted += ButtonLogin_OnDataSubmited;
            formLogin.ShowDialog();
        }

        private bool IsSomeoneLogged()
        {
            foreach (User user in m_usersList)
            {
                if (user.IsLoggedIn)
                    return true;
            }
            return false;
        }

        private int GetIndexOfCurrentUser()
        {
            foreach (User user in m_usersList)
            {
                if (user.IsLoggedIn)
                    return m_usersList.IndexOf(user);
            }
            return -1;
        }

        private void ButtonCart_Click(object sender, EventArgs e)
        {
            if (!IsSomeoneLogged())
                return;

            FormUserCart formUserCart = new FormUserCart(m_usersList[GetIndexOfCurrentUser()]);
            formUserCart.ShowDialog();
        }

        private void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            if (!IsSomeoneLogged())
                return;

            int selected = listBoxProducts.SelectedIndex;
            if (selected < 0)
                return;

            m_usersList[GetIndexOfCurrentUser()].Cart.Add(m_products[selected]);
        }
    }
}
