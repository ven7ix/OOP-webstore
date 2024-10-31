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
        private readonly List<IProduct<float>> m_products = new List<IProduct<float>>();

        public FormMain()
        {
            InitializeComponent();

            m_products.Add(new ProductFood<float>(100.2f, 1, m_products.Count, DateTime.Now));
            m_products.Add(new ProductFood<float>(105.3f, 3, m_products.Count, DateTime.Now));
            m_products.Add(new ProductElectronics<float>(10100.4f, 6, m_products.Count, "Monitor"));
            m_products.Add(new ProductElectronics<float>(1100.0f, 4, m_products.Count, "Mouse"));
            m_products.Add(new ProductFood<float>(200.0f, 2, m_products.Count, DateTime.Now));

            foreach (IProduct<float> p in m_products)
                listBoxProducts.Items.Add(p.ProductID.ToString() + '\t' + p.Price.ToString() + '\t' + p.Quantity.ToString());
        }

        public void ButtonRegister_OnDataSubmitted(string name, string login, string password)
        {
            User newUser = new User(name, login, password);
            m_usersList.Add(newUser);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister(m_usersList);
            formRegister.OnDataSubmitted += ButtonRegister_OnDataSubmitted;
            formRegister.ShowDialog();
        }

        public void ButtonLogin_OnDataSubmitted(string name)
        {
            labelUserName.Text = name;
            buttonLogin.Text = "logout";
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (GetIndexOfCurrentUser() != -1)
            {
                m_usersList[GetIndexOfCurrentUser()].IsLoggedIn = false;

                labelUserName.Text = "not logged in";
                buttonLogin.Text = "login";
                return;
            }

            FormLogin formLogin = new FormLogin(m_usersList);
            formLogin.OnDataSubmitted += ButtonLogin_OnDataSubmitted;
            formLogin.ShowDialog();
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

        private void ButtonCart_OnDataSubmitted(List<IProduct<float>> products)
        {
            foreach (IProduct<float> productM in products)
            {
                foreach (IProduct<float> productS in m_products)
                {
                    if (productM.ProductID == productS.ProductID)
                        productM.Quantity = productS.Quantity;
                }
            }
        }

        private void ButtonCart_Click(object sender, EventArgs e)
        {
            try
            {
                FormUserCart formUserCart = new FormUserCart(m_usersList[GetIndexOfCurrentUser()], m_products);
                formUserCart.OnDataSubmitted += ButtonCart_OnDataSubmitted;
                formUserCart.ShowDialog();

                ListBoxProductsUpdate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            if (GetIndexOfCurrentUser() == -1)
                return;

            int selected = listBoxProducts.SelectedIndex;
            if (selected == -1)
                return;

            if (m_products[selected].Quantity < 1)
                return;

            IProduct<float> productToCart = null;

            if (m_products[selected] is ProductFood<float>)
            {
                ProductFood<float> food = m_products[selected] as ProductFood<float>;
                productToCart = new ProductFood<float>(food);
            }
            else if (m_products[selected] is ProductElectronics<float>)
            {
                ProductElectronics<float> electronics = m_products[selected] as ProductElectronics<float>;
                productToCart = new ProductElectronics<float>(electronics);
            }

            if (productToCart != null)
                AddProductToCart(selected, productToCart);

            ListBoxProductsUpdate();
        }

        private void AddProductToCart(int selected, IProduct<float> productToCart)
        {
            if (GetIndexOfProductInCart(productToCart) == -1)
            {
                productToCart.Quantity = 1;
                m_usersList[GetIndexOfCurrentUser()].Cart.Add(productToCart);
            }
            else
            {
                m_usersList[GetIndexOfCurrentUser()].Cart[GetIndexOfProductInCart(productToCart)].Quantity++;
            }

            m_products[selected].Quantity--;
        }

        private void ListBoxProductsUpdate()
        {
            int selected = listBoxProducts.SelectedIndex;
            if (selected == -1)
                return;

            listBoxProducts.Items.Clear();
            foreach (IProduct<float> p in m_products)
            {
                listBoxProducts.Items.Add(p.ProductID.ToString() + '\t' + p.Price.ToString() + '\t' + p.Quantity.ToString());
            }
            listBoxProducts.SetSelected(selected, true);
        }

        private int GetIndexOfProductInCart(IProduct<float> product)
        {
            foreach (IProduct<float> p in m_usersList[GetIndexOfCurrentUser()].Cart)
            {
                if (p.ProductID == product.ProductID)
                    return m_usersList[GetIndexOfCurrentUser()].Cart.IndexOf(p);
            }
            return -1;
        }
    }
}