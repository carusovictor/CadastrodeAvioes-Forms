namespace SistemaCadastro
{
    partial class FrmLogin
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtuserlogin = new System.Windows.Forms.TextBox();
            this.txtuserpassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(700, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtuserlogin
            // 
            this.txtuserlogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtuserlogin.Location = new System.Drawing.Point(308, 150);
            this.txtuserlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuserlogin.Name = "txtuserlogin";
            this.txtuserlogin.Size = new System.Drawing.Size(197, 39);
            this.txtuserlogin.TabIndex = 19;
            // 
            // txtuserpassword
            // 
            this.txtuserpassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtuserpassword.Location = new System.Drawing.Point(308, 217);
            this.txtuserpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuserpassword.Name = "txtuserpassword";
            this.txtuserpassword.PasswordChar = '*';
            this.txtuserpassword.Size = new System.Drawing.Size(197, 39);
            this.txtuserpassword.TabIndex = 20;
            // 
            // BtnLogin
            // 
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.ForeColor = System.Drawing.Color.DimGray;
            this.BtnLogin.Image = global::SistemaCadastro.Properties.Resources.adicionar;
            this.BtnLogin.Location = new System.Drawing.Point(308, 294);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(197, 75);
            this.BtnLogin.TabIndex = 21;
            this.BtnLogin.Text = "Acessar";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.txtuserpassword);
            this.Controls.Add(this.txtuserlogin);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtuserlogin;
        private System.Windows.Forms.TextBox txtuserpassword;
        private System.Windows.Forms.Button BtnLogin;
    }
}