using TruckDriver.WindowsFormsApp.Controls;
using TruckDriver.WindowsFormsApp.Formularios;

namespace TruckDriver.WindowsFormsApp.Formularios
{
    partial class frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaxMinSizeApp = new System.Windows.Forms.Button();
            this.btnMinizeApp = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnCloseChildren = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PanelChildren = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfiguracao = new TruckDriver.WindowsFormsApp.Controls.TruckDriverPanelButton();
            this.btnCaminhao = new TruckDriver.WindowsFormsApp.Controls.TruckDriverPanelButton();
            this.btnMotorista = new TruckDriver.WindowsFormsApp.Controls.TruckDriverPanelButton();
            this.btnPedidos = new TruckDriver.WindowsFormsApp.Controls.TruckDriverPanelButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.PanelChildren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnConfiguracao);
            this.panelMenu.Controls.Add(this.btnCaminhao);
            this.panelMenu.Controls.Add(this.btnMotorista);
            this.panelMenu.Controls.Add(this.btnPedidos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 691);
            this.panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(145, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 661);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bem vindo,  Biruleibe !";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.labelTitle);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(70, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(150, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Truck Driver 1.0.0";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.panelTitleBar.Controls.Add(this.btnMaxMinSizeApp);
            this.panelTitleBar.Controls.Add(this.btnMinizeApp);
            this.panelTitleBar.Controls.Add(this.btnCloseApp);
            this.panelTitleBar.Controls.Add(this.btnCloseChildren);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(834, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaxMinSizeApp
            // 
            this.btnMaxMinSizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMinSizeApp.FlatAppearance.BorderSize = 0;
            this.btnMaxMinSizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMinSizeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxMinSizeApp.ForeColor = System.Drawing.Color.White;
            this.btnMaxMinSizeApp.Location = new System.Drawing.Point(756, 3);
            this.btnMaxMinSizeApp.Name = "btnMaxMinSizeApp";
            this.btnMaxMinSizeApp.Size = new System.Drawing.Size(30, 30);
            this.btnMaxMinSizeApp.TabIndex = 4;
            this.btnMaxMinSizeApp.Text = "O";
            this.btnMaxMinSizeApp.UseVisualStyleBackColor = true;
            this.btnMaxMinSizeApp.Click += new System.EventHandler(this.btnMaxMinSizeApp_Click);
            // 
            // btnMinizeApp
            // 
            this.btnMinizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinizeApp.FlatAppearance.BorderSize = 0;
            this.btnMinizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinizeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinizeApp.ForeColor = System.Drawing.Color.White;
            this.btnMinizeApp.Location = new System.Drawing.Point(720, 3);
            this.btnMinizeApp.Name = "btnMinizeApp";
            this.btnMinizeApp.Size = new System.Drawing.Size(30, 30);
            this.btnMinizeApp.TabIndex = 3;
            this.btnMinizeApp.Text = "O";
            this.btnMinizeApp.UseVisualStyleBackColor = true;
            this.btnMinizeApp.Click += new System.EventHandler(this.btnMinizeApp_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Location = new System.Drawing.Point(792, 3);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(30, 30);
            this.btnCloseApp.TabIndex = 2;
            this.btnCloseApp.Text = "O";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // btnCloseChildren
            // 
            this.btnCloseChildren.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildren.FlatAppearance.BorderSize = 0;
            this.btnCloseChildren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildren.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildren.Image")));
            this.btnCloseChildren.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildren.Name = "btnCloseChildren";
            this.btnCloseChildren.Size = new System.Drawing.Size(89, 80);
            this.btnCloseChildren.TabIndex = 1;
            this.btnCloseChildren.UseVisualStyleBackColor = true;
            this.btnCloseChildren.Click += new System.EventHandler(this.btnCloseChildren_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(380, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelChildren
            // 
            this.PanelChildren.BackColor = System.Drawing.SystemColors.Control;
            this.PanelChildren.Controls.Add(this.pictureBox1);
            this.PanelChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChildren.Location = new System.Drawing.Point(250, 80);
            this.PanelChildren.Name = "PanelChildren";
            this.PanelChildren.Size = new System.Drawing.Size(834, 611);
            this.PanelChildren.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(346, 199);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(110, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracao.FlatAppearance.BorderSize = 0;
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracao.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracao.Image")));
            this.btnConfiguracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracao.Location = new System.Drawing.Point(0, 260);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnConfiguracao.Size = new System.Drawing.Size(250, 60);
            this.btnConfiguracao.TabIndex = 4;
            this.btnConfiguracao.Text = "    Configuração";
            this.btnConfiguracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracao.UseVisualStyleBackColor = true;
            // 
            // btnCaminhao
            // 
            this.btnCaminhao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaminhao.FlatAppearance.BorderSize = 0;
            this.btnCaminhao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaminhao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaminhao.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCaminhao.Image = ((System.Drawing.Image)(resources.GetObject("btnCaminhao.Image")));
            this.btnCaminhao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaminhao.Location = new System.Drawing.Point(0, 200);
            this.btnCaminhao.Name = "btnCaminhao";
            this.btnCaminhao.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCaminhao.Size = new System.Drawing.Size(250, 60);
            this.btnCaminhao.TabIndex = 3;
            this.btnCaminhao.Text = "    Caminhao";
            this.btnCaminhao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaminhao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaminhao.UseVisualStyleBackColor = true;
            // 
            // btnMotorista
            // 
            this.btnMotorista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMotorista.FlatAppearance.BorderSize = 0;
            this.btnMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotorista.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMotorista.Image = ((System.Drawing.Image)(resources.GetObject("btnMotorista.Image")));
            this.btnMotorista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotorista.Location = new System.Drawing.Point(0, 140);
            this.btnMotorista.Name = "btnMotorista";
            this.btnMotorista.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMotorista.Size = new System.Drawing.Size(250, 60);
            this.btnMotorista.TabIndex = 2;
            this.btnMotorista.Text = "    Motorista";
            this.btnMotorista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMotorista.UseVisualStyleBackColor = true;
            // 
            // btnPedidos
            // 
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(0, 80);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPedidos.Size = new System.Drawing.Size(250, 60);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "    Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 691);
            this.Controls.Add(this.PanelChildren);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 730);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truck Driver";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.PanelChildren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        //this.PanelChildren = new System.Windows.Forms.Panel();
        public System.Windows.Forms.Panel PanelChildren;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel panelTitleBar;
        public System.Windows.Forms.Panel panelLogo;
        public System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.Button btnCloseChildren;
        private TruckDriverPanelButton btnPedidos;
        private System.Windows.Forms.Label labelTitle;
        private TruckDriverPanelButton btnConfiguracao;
        private TruckDriverPanelButton btnCaminhao;
        private TruckDriverPanelButton btnMotorista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMaxMinSizeApp;
        private System.Windows.Forms.Button btnMinizeApp;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

