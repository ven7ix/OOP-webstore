namespace OOP_webstore
{
    partial class FormPayment
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
            this.buttonDeny = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDeny
            // 
            this.buttonDeny.Location = new System.Drawing.Point(188, 388);
            this.buttonDeny.Name = "buttonDeny";
            this.buttonDeny.Size = new System.Drawing.Size(170, 50);
            this.buttonDeny.TabIndex = 11;
            this.buttonDeny.Text = "Deny";
            this.buttonDeny.UseVisualStyleBackColor = true;
            this.buttonDeny.Click += new System.EventHandler(this.ButtonDeny_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(12, 388);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(170, 50);
            this.buttonConfirm.TabIndex = 10;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeny);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeny;
        private System.Windows.Forms.Button buttonConfirm;
    }
}