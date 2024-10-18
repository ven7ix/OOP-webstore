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
        private User LoggedUser;

        public FormUserCart(User user)
        {
            InitializeComponent();
            LoggedUser = user;

            foreach (IProduct p in LoggedUser.Cart)
                listBoxUserCart.Items.Add(p.ProductID.ToString() + '\t' + p.Price.ToString() + '\t' + p.Quantity.ToString());
        }


    }
}
