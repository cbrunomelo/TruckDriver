using TruckDriver.WindowsFormsApp.Controls;

namespace TruckDriver.WindowsFormsApp.Formularios.Login
{
    partial class beckup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(beckup));
            this.txtUsuario = new TruckDriverLoginTextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pnlLinhaUsuario = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.pnlUsuario = new TruckDriverPanelLogin();
            this.pnlSenha = new TruckDriver.WindowsFormsApp.Controls.TruckDriverPanelLogin();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.txtSenha = new TruckDriver.WindowsFormsApp.Controls.TruckDriverLoginTextBox();
            this.pnlLinhaSenha = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            this.pnlSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(28, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 19);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(62, 281);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(228, 38);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // pnlLinhaUsuario
            // 
            this.pnlLinhaUsuario.BackColor = System.Drawing.Color.White;
            this.pnlLinhaUsuario.Location = new System.Drawing.Point(3, 28);
            this.pnlLinhaUsuario.Name = "pnlLinhaUsuario";
            this.pnlLinhaUsuario.Size = new System.Drawing.Size(228, 1);
            this.pnlLinhaUsuario.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(62, 325);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(228, 38);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(322, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(27, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::TruckDriver.WindowsFormsApp.Properties.Resources.frontal_truck_white;
            this.picLogo.Location = new System.Drawing.Point(112, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(128, 128);
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // picUsuario
            // 
            this.picUsuario.Image = global::TruckDriver.WindowsFormsApp.Properties.Resources.user_login;
            this.picUsuario.Location = new System.Drawing.Point(0, 6);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(16, 16);
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.txtUsuario);
            this.pnlUsuario.Controls.Add(this.picUsuario);
            this.pnlUsuario.Controls.Add(this.pnlLinhaUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(62, 177);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(228, 41);
            this.pnlUsuario.TabIndex = 11;
            // 
            // pnlSenha
            // 
            this.pnlSenha.Controls.Add(this.picSenha);
            this.pnlSenha.Controls.Add(this.txtSenha);
            this.pnlSenha.Controls.Add(this.pnlLinhaSenha);
            this.pnlSenha.Location = new System.Drawing.Point(62, 224);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(228, 45);
            this.pnlSenha.TabIndex = 12;
            // 
            // picSenha
            // 
            this.picSenha.Image = global::TruckDriver.WindowsFormsApp.Properties.Resources.padlock;
            this.picSenha.Location = new System.Drawing.Point(0, 3);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(16, 16);
            this.picSenha.TabIndex = 3;
            this.picSenha.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(28, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(200, 19);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.Text = "Senha";
            // 
            // pnlLinhaSenha
            // 
            this.pnlLinhaSenha.BackColor = System.Drawing.Color.White;
            this.pnlLinhaSenha.Location = new System.Drawing.Point(3, 25);
            this.pnlLinhaSenha.Name = "pnlLinhaSenha";
            this.pnlLinhaSenha.Size = new System.Drawing.Size(228, 1);
            this.pnlLinhaSenha.TabIndex = 8;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(355, 422);
            this.Controls.Add(this.pnlSenha);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlSenha.ResumeLayout(false);
            this.pnlSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picUsuario;
        private TruckDriverLoginTextBox txtUsuario;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picSenha;
        private TruckDriverLoginTextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Panel pnlLinhaUsuario;
        private System.Windows.Forms.Panel pnlLinhaSenha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSair;
        private TruckDriverPanelLogin pnlUsuario;
        private TruckDriverPanelLogin pnlSenha;
    }
}