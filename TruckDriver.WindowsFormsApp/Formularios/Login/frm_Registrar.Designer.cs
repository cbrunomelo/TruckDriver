﻿namespace TruckDriver.WindowsFormsApp.Formularios.Login
{
    partial class frm_Registrar
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
            this.pnlSenha = new TruckDriver.WindowsFormsApp.Controls.TruckDriverPanelLogin();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.txtSenha = new TruckDriver.WindowsFormsApp.Controls.TruckDriverLoginTextBox();
            this.pnlLinhaSenha = new System.Windows.Forms.Panel();
            this.pnlUsuario = new TruckDriver.WindowsFormsApp.Controls.TruckDriverPanelLogin();
            this.txtUsuario = new TruckDriver.WindowsFormsApp.Controls.TruckDriverLoginTextBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.pnlLinhaUsuario = new System.Windows.Forms.Panel();
            this.pnlRepeteSenha = new TruckDriver.WindowsFormsApp.Controls.TruckDriverPanelLogin();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRepeteSenha = new TruckDriver.WindowsFormsApp.Controls.TruckDriverLoginTextBox();
            this.pnlLinhaRepeteSenha = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlRepeteSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSenha
            // 
            this.pnlSenha.Controls.Add(this.picSenha);
            this.pnlSenha.Controls.Add(this.txtSenha);
            this.pnlSenha.Controls.Add(this.pnlLinhaSenha);
            this.pnlSenha.Location = new System.Drawing.Point(63, 212);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(228, 45);
            this.pnlSenha.TabIndex = 16;
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
            this.txtSenha.Text = "Crie uma Senha";
            // 
            // pnlLinhaSenha
            // 
            this.pnlLinhaSenha.BackColor = System.Drawing.Color.White;
            this.pnlLinhaSenha.Location = new System.Drawing.Point(3, 25);
            this.pnlLinhaSenha.Name = "pnlLinhaSenha";
            this.pnlLinhaSenha.Size = new System.Drawing.Size(228, 1);
            this.pnlLinhaSenha.TabIndex = 8;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.txtUsuario);
            this.pnlUsuario.Controls.Add(this.picUsuario);
            this.pnlUsuario.Controls.Add(this.pnlLinhaUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(63, 165);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(228, 41);
            this.pnlUsuario.TabIndex = 15;
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
            // picUsuario
            // 
            this.picUsuario.Image = global::TruckDriver.WindowsFormsApp.Properties.Resources.user_login;
            this.picUsuario.Location = new System.Drawing.Point(0, 6);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(16, 16);
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
            // 
            // pnlLinhaUsuario
            // 
            this.pnlLinhaUsuario.BackColor = System.Drawing.Color.White;
            this.pnlLinhaUsuario.Location = new System.Drawing.Point(3, 28);
            this.pnlLinhaUsuario.Name = "pnlLinhaUsuario";
            this.pnlLinhaUsuario.Size = new System.Drawing.Size(228, 1);
            this.pnlLinhaUsuario.TabIndex = 7;
            // 
            // pnlRepeteSenha
            // 
            this.pnlRepeteSenha.Controls.Add(this.pictureBox1);
            this.pnlRepeteSenha.Controls.Add(this.txtRepeteSenha);
            this.pnlRepeteSenha.Controls.Add(this.pnlLinhaRepeteSenha);
            this.pnlRepeteSenha.Location = new System.Drawing.Point(63, 266);
            this.pnlRepeteSenha.Name = "pnlRepeteSenha";
            this.pnlRepeteSenha.Size = new System.Drawing.Size(228, 45);
            this.pnlRepeteSenha.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TruckDriver.WindowsFormsApp.Properties.Resources.padlock;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtRepeteSenha
            // 
            this.txtRepeteSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txtRepeteSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepeteSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeteSenha.ForeColor = System.Drawing.Color.White;
            this.txtRepeteSenha.Location = new System.Drawing.Point(28, 3);
            this.txtRepeteSenha.Name = "txtRepeteSenha";
            this.txtRepeteSenha.Size = new System.Drawing.Size(200, 19);
            this.txtRepeteSenha.TabIndex = 4;
            this.txtRepeteSenha.Text = "Repita a Senha";
            // 
            // pnlLinhaRepeteSenha
            // 
            this.pnlLinhaRepeteSenha.BackColor = System.Drawing.Color.White;
            this.pnlLinhaRepeteSenha.Location = new System.Drawing.Point(3, 25);
            this.pnlLinhaRepeteSenha.Name = "pnlLinhaRepeteSenha";
            this.pnlLinhaRepeteSenha.Size = new System.Drawing.Size(228, 1);
            this.pnlLinhaRepeteSenha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // frm_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlRepeteSenha);
            this.Controls.Add(this.pnlSenha);
            this.Controls.Add(this.pnlUsuario);
            this.Name = "frm_Registrar";
            this.Text = "Registrar";
            this.Controls.SetChildIndex(this.picLogo, 0);
            this.Controls.SetChildIndex(this.pnlUsuario, 0);
            this.Controls.SetChildIndex(this.pnlSenha, 0);
            this.Controls.SetChildIndex(this.pnlRepeteSenha, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlSenha.ResumeLayout(false);
            this.pnlSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlRepeteSenha.ResumeLayout(false);
            this.pnlRepeteSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TruckDriverPanelLogin pnlSenha;
        private System.Windows.Forms.PictureBox picSenha;
        private Controls.TruckDriverLoginTextBox txtSenha;
        private System.Windows.Forms.Panel pnlLinhaSenha;
        private Controls.TruckDriverPanelLogin pnlUsuario;
        private Controls.TruckDriverLoginTextBox txtUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Panel pnlLinhaUsuario;
        private Controls.TruckDriverPanelLogin pnlRepeteSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.TruckDriverLoginTextBox txtRepeteSenha;
        private System.Windows.Forms.Panel pnlLinhaRepeteSenha;
        private System.Windows.Forms.Label label1;
    }
}