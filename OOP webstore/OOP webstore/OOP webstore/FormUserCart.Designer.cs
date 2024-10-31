namespace OOP_webstore
{
    partial class FormUserCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxUserCart = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearCart = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUserCart
            // 
            this.listBoxUserCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxUserCart.FormattingEnabled = true;
            this.listBoxUserCart.Location = new System.Drawing.Point(0, 0);
            this.listBoxUserCart.Name = "listBoxUserCart";
            this.listBoxUserCart.Size = new System.Drawing.Size(800, 450);
            this.listBoxUserCart.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClearCart);
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Controls.Add(this.buttonBuy);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(600, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonClearCart
            // 
            this.buttonClearCart.Location = new System.Drawing.Point(16, 193);
            this.buttonClearCart.Name = "buttonClearCart";
            this.buttonClearCart.Size = new System.Drawing.Size(161, 80);
            this.buttonClearCart.TabIndex = 1;
            this.buttonClearCart.Text = "Clear cart";
            this.buttonClearCart.UseVisualStyleBackColor = true;
            this.buttonClearCart.Click += new System.EventHandler(this.ButtonClearCart_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(16, 279);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(161, 79);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(16, 364);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(161, 80);
            this.buttonBuy.TabIndex = 0;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // FormUserCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxUserCart);
            this.Name = "FormUserCart";
            this.Text = "FormUserCart";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUserCart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonClearCart;
        private System.Windows.Forms.Button buttonClose;
    }
}