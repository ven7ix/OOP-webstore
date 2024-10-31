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
    public partial class FormUserCart : Form
    {
        private readonly User LoggedUser;
        private readonly List<IProduct<float>> m_products = new List<IProduct<float>>();
        public event Action<List<IProduct<float>>> OnDataSubmitted;
        public bool m_confirmation = false;

        public FormUserCart(User user, List<IProduct<float>> products)
        {
            InitializeComponent();
            LoggedUser = user;
            foreach (IProduct<float> p in LoggedUser.Cart)
                listBoxUserCart.Items.Add(p.ProductID.ToString() + '\t' + p.Price.ToString() + '\t' + p.Quantity.ToString());

            m_products = products;
        }

        private void ButtonBuy_Click(object sender, EventArgs e)
        {
            FormPayment formPayment = new FormPayment();
            formPayment.OnDataSubmitted += Button_OnDataSubmitted;
            formPayment.ShowDialog();

            if (!m_confirmation)
                return;

            listBoxUserCart.Items.Clear();
            LoggedUser.Cart.Clear();
        }

        private void ButtonClearCart_Click(object sender, EventArgs e)
        {
            listBoxUserCart.Items.Clear();
            foreach (IProduct<float> productStore in m_products)
            {
                foreach (IProduct<float> productCart in LoggedUser.Cart)
                {
                    if (productStore.ProductID == productCart.ProductID)
                        productStore.Quantity += productCart.Quantity;
                }
            }
            LoggedUser.Cart.Clear();

            //MessageBox maybe
            OnDataSubmitted?.Invoke(m_products);
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_OnDataSubmitted(bool confirmation)
        {
            m_confirmation = confirmation;
        }
    }
}