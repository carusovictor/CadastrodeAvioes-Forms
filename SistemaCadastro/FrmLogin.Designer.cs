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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtuserlogin = new System.Windows.Forms.TextBox();
            this.txtuserpassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(700, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 47);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtuserlogin
            // 
            this.txtuserlogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtuserlogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtuserlogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtuserlogin.Location = new System.Drawing.Point(308, 242);
            this.txtuserlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuserlogin.Name = "txtuserlogin";
            this.txtuserlogin.Size = new System.Drawing.Size(197, 39);
            this.txtuserlogin.TabIndex = 19;
            this.txtuserlogin.TextChanged += new System.EventHandler(this.txtuserlogin_TextChanged);
            // 
            // txtuserpassword
            // 
            this.txtuserpassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtuserpassword.Location = new System.Drawing.Point(308, 312);
            this.txtuserpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuserpassword.Name = "txtuserpassword";
            this.txtuserpassword.PasswordChar = '*';
            this.txtuserpassword.Size = new System.Drawing.Size(197, 39);
            this.txtuserpassword.TabIndex = 20;
            this.txtuserpassword.TextChanged += new System.EventHandler(this.txtuserpassword_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.ForeColor = System.Drawing.Color.DimGray;
            this.BtnLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogin.Image")));
            this.BtnLogin.Location = new System.Drawing.Point(308, 361);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 450);
            this.panel1.TabIndex = 23;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.txtuserpassword);
            this.Controls.Add(this.txtuserlogin);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtuserlogin;
        private System.Windows.Forms.TextBox txtuserpassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}