namespace OOP_webstore
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonCart = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(520, 23);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(207, 44);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(520, 73);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(207, 44);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(290, 23);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(68, 13);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "not logged in";
            // 
            // buttonCart
            // 
            this.buttonCart.Location = new System.Drawing.Point(12, 23);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(92, 44);
            this.buttonCart.TabIndex = 3;
            this.buttonCart.Text = "cart";
            this.buttonCart.UseVisualStyleBackColor = true;
            this.buttonCart.Click += new System.EventHandler(this.ButtonCart_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(37, 233);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(486, 186);
            this.listBoxProducts.TabIndex = 4;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(554, 235);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(172, 60);
            this.buttonAddToCart.TabIndex = 5;
            this.buttonAddToCart.Text = "add to cart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.ButtonAddToCart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.buttonCart);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonRegister);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonCart;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonAddToCart;
    }
}

