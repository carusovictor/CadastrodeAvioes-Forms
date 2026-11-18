namespace SistemaCadastro
{
    partial class FrmAddCompanhia
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.marcador = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.txtaddcompanhia = new System.Windows.Forms.TextBox();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 35);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(68, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 201);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.marcador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 415);
            this.panel1.TabIndex = 3;
            // 
            // marcador
            // 
            this.marcador.BackColor = System.Drawing.Color.White;
            this.marcador.Location = new System.Drawing.Point(1, 131);
            this.marcador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(15, 55);
            this.marcador.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adicionar Companhia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.DimGray;
            this.BtnConfirmaCadastro.Image = global::SistemaCadastro.Properties.Resources.adicionar;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(407, 352);
            this.BtnConfirmaCadastro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(197, 75);
            this.BtnConfirmaCadastro.TabIndex = 16;
            this.BtnConfirmaCadastro.Text = "&Cadastrar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // txtaddcompanhia
            // 
            this.txtaddcompanhia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtaddcompanhia.Location = new System.Drawing.Point(473, 182);
            this.txtaddcompanhia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtaddcompanhia.Name = "txtaddcompanhia";
            this.txtaddcompanhia.Size = new System.Drawing.Size(248, 39);
            this.txtaddcompanhia.TabIndex = 15;
            this.txtaddcompanhia.TextChanged += new System.EventHandler(this.txtmodelo_TextChanged);
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblmodelo.ForeColor = System.Drawing.Color.DimGray;
            this.lblmodelo.Location = new System.Drawing.Point(302, 188);
            this.lblmodelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(142, 29);
            this.lblmodelo.TabIndex = 14;
            this.lblmodelo.Text = "Companhia:";
            this.lblmodelo.Click += new System.EventHandler(this.lblmodelo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(713, 43);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 17;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmAddCompanhia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.BtnConfirmaCadastro);
            this.Controls.Add(this.txtaddcompanhia);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddCompanhia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddCompanhia";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel marcador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfirmaCadastro;
        private System.Windows.Forms.TextBox txtaddcompanhia;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Button btnFechar;
    }
}