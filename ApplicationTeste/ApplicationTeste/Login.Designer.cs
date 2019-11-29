using ApplicationTeste.Global;

namespace ApplicationTeste
{
    partial class Login
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
            this.txbUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadastrarSe = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUsuario
            // 
            this.txbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbUsuario.ForeColor = System.Drawing.Color.White;
            this.txbUsuario.HintForeColor = System.Drawing.Color.White;
            this.txbUsuario.HintText = "";
            this.txbUsuario.isPassword = false;
            this.txbUsuario.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txbUsuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbUsuario.LineThickness = 3;
            this.txbUsuario.Location = new System.Drawing.Point(76, 230);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(344, 41);
            this.txbUsuario.TabIndex = 0;
            this.txbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbUsuario.OnValueChanged += new System.EventHandler(this.TxbUsuario_OnValueChanged);
            // 
            // txbSenha
            // 
            this.txbSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txbSenha.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txbSenha.HintText = "";
            this.txbSenha.isPassword = false;
            this.txbSenha.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.txbSenha.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbSenha.LineThickness = 3;
            this.txbSenha.Location = new System.Drawing.Point(76, 341);
            this.txbSenha.Margin = new System.Windows.Forms.Padding(5);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(344, 41);
            this.txbSenha.TabIndex = 1;
            this.txbSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSenha.OnValueChanged += new System.EventHandler(this.TxbSenha_OnValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 480);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCadastrarSe
            // 
            this.btnCadastrarSe.Location = new System.Drawing.Point(241, 479);
            this.btnCadastrarSe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarSe.Name = "btnCadastrarSe";
            this.btnCadastrarSe.Size = new System.Drawing.Size(116, 36);
            this.btnCadastrarSe.TabIndex = 9;
            this.btnCadastrarSe.UseVisualStyleBackColor = true;
            this.btnCadastrarSe.Click += new System.EventHandler(this.BtnCadastrarSe_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ApplicationTeste.Properties.Resources.icons8_usuário_25;
            this.pictureBox3.Location = new System.Drawing.Point(35, 240);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 31);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ApplicationTeste.Properties.Resources.icons8_chave_25;
            this.pictureBox2.Location = new System.Drawing.Point(31, 351);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::ApplicationTeste.Properties.Resources.icons8_minimizar_janela_25;
            this.pictureBox8.Location = new System.Drawing.Point(387, 2);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(33, 31);
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ApplicationTeste.Properties.Resources.icons8_fechar_janela_25;
            this.pictureBox7.Location = new System.Drawing.Point(415, 2);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 31);
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.PictureBox7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplicationTeste.Properties.Resources.REDIMENS;
            this.pictureBox1.Location = new System.Drawing.Point(40, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 144);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(452, 624);
            this.Controls.Add(this.btnCadastrarSe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txbUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastrarSe;
    }
}

