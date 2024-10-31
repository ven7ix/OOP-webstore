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
    public partial class FormPayment : Form
    {
        public event Action<bool> OnDataSubmitted;

        public FormPayment()
        {
            InitializeComponent();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            OnDataSubmitted?.Invoke(true);
            Close();
        }

        private void ButtonDeny_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
