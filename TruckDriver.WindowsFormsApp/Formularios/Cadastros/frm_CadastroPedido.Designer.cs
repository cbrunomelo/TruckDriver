using WindowsFormsApp1.Controls;

namespace TruckDriver.WindowsFormsApp.Formularios.Cadastros
{
    partial class frm_CadastroPedido
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grp_EnderecoEntrega = new System.Windows.Forms.GroupBox();
            this.mtxt_CepEntrega = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Complemento = new System.Windows.Forms.Label();
            this.lbl_Logradouro = new System.Windows.Forms.Label();
            this.lbl_CEP = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.grpEnderecoColeta = new System.Windows.Forms.GroupBox();
            this.mtxt_CepColeta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_estadoColeta = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_CidadeColeta = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_BairroColeta = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_ComplementoColeta = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_LogradouroColeta = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_estadoEntrega = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_CidadeEntrega = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_BairroEntrega = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_ComplementoEntrega = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_LogradouroEntrega = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.grp_EnderecoEntrega.SuspendLayout();
            this.grpEnderecoColeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_EnderecoEntrega
            // 
            this.grp_EnderecoEntrega.Controls.Add(this.txt_estadoEntrega);
            this.grp_EnderecoEntrega.Controls.Add(this.mtxt_CepEntrega);
            this.grp_EnderecoEntrega.Controls.Add(this.txt_CidadeEntrega);
            this.grp_EnderecoEntrega.Controls.Add(this.lbl_Estado);
            this.grp_EnderecoEntrega.Controls.Add(this.lbl_Cidade);
            this.grp_EnderecoEntrega.Controls.Add(this.txt_BairroEntrega);
            this.grp_EnderecoEntrega.Controls.Add(this.lbl_Bairro);
            this.grp_EnderecoEntrega.Controls.Add(this.txt_ComplementoEntrega);
            this.grp_EnderecoEntrega.Controls.Add(this.lbl_Complemento);
            this.grp_EnderecoEntrega.Controls.Add(this.txt_LogradouroEntrega);
            this.grp_EnderecoEntrega.Controls.Add(this.lbl_Logradouro);
            this.grp_EnderecoEntrega.Controls.Add(this.lbl_CEP);
            this.grp_EnderecoEntrega.Location = new System.Drawing.Point(12, 260);
            this.grp_EnderecoEntrega.Name = "grp_EnderecoEntrega";
            this.grp_EnderecoEntrega.Size = new System.Drawing.Size(557, 223);
            this.grp_EnderecoEntrega.TabIndex = 1;
            this.grp_EnderecoEntrega.TabStop = false;
            this.grp_EnderecoEntrega.Text = "Endereço Entrega";
            // 
            // mtxt_CepEntrega
            // 
            this.mtxt_CepEntrega.Location = new System.Drawing.Point(9, 54);
            this.mtxt_CepEntrega.Mask = "00000-000";
            this.mtxt_CepEntrega.Name = "mtxt_CepEntrega";
            this.mtxt_CepEntrega.Size = new System.Drawing.Size(71, 20);
            this.mtxt_CepEntrega.TabIndex = 5;
            this.mtxt_CepEntrega.Leave += new System.EventHandler(this.mtxt_CEP_Leave);
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(199, 161);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(43, 13);
            this.lbl_Estado.TabIndex = 9;
            this.lbl_Estado.Text = "Estado:";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Location = new System.Drawing.Point(6, 161);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(43, 13);
            this.lbl_Cidade.TabIndex = 8;
            this.lbl_Cidade.Text = "Cidade:";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Location = new System.Drawing.Point(196, 96);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(37, 13);
            this.lbl_Bairro.TabIndex = 6;
            this.lbl_Bairro.Text = "Bairro:";
            // 
            // lbl_Complemento
            // 
            this.lbl_Complemento.AutoSize = true;
            this.lbl_Complemento.Location = new System.Drawing.Point(6, 96);
            this.lbl_Complemento.Name = "lbl_Complemento";
            this.lbl_Complemento.Size = new System.Drawing.Size(74, 13);
            this.lbl_Complemento.TabIndex = 4;
            this.lbl_Complemento.Text = "Complemento:";
            // 
            // lbl_Logradouro
            // 
            this.lbl_Logradouro.AutoSize = true;
            this.lbl_Logradouro.Location = new System.Drawing.Point(196, 31);
            this.lbl_Logradouro.Name = "lbl_Logradouro";
            this.lbl_Logradouro.Size = new System.Drawing.Size(67, 13);
            this.lbl_Logradouro.TabIndex = 2;
            this.lbl_Logradouro.Text = "Logradouro: ";
            // 
            // lbl_CEP
            // 
            this.lbl_CEP.AutoSize = true;
            this.lbl_CEP.Location = new System.Drawing.Point(6, 31);
            this.lbl_CEP.Name = "lbl_CEP";
            this.lbl_CEP.Size = new System.Drawing.Size(31, 13);
            this.lbl_CEP.TabIndex = 0;
            this.lbl_CEP.Text = "CEP:";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(487, 540);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 3;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(406, 540);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // grpEnderecoColeta
            // 
            this.grpEnderecoColeta.Controls.Add(this.txt_estadoColeta);
            this.grpEnderecoColeta.Controls.Add(this.mtxt_CepColeta);
            this.grpEnderecoColeta.Controls.Add(this.txt_CidadeColeta);
            this.grpEnderecoColeta.Controls.Add(this.label1);
            this.grpEnderecoColeta.Controls.Add(this.label2);
            this.grpEnderecoColeta.Controls.Add(this.txt_BairroColeta);
            this.grpEnderecoColeta.Controls.Add(this.label3);
            this.grpEnderecoColeta.Controls.Add(this.txt_ComplementoColeta);
            this.grpEnderecoColeta.Controls.Add(this.label4);
            this.grpEnderecoColeta.Controls.Add(this.txt_LogradouroColeta);
            this.grpEnderecoColeta.Controls.Add(this.label5);
            this.grpEnderecoColeta.Controls.Add(this.label6);
            this.grpEnderecoColeta.Location = new System.Drawing.Point(12, 12);
            this.grpEnderecoColeta.Name = "grpEnderecoColeta";
            this.grpEnderecoColeta.Size = new System.Drawing.Size(557, 223);
            this.grpEnderecoColeta.TabIndex = 5;
            this.grpEnderecoColeta.TabStop = false;
            this.grpEnderecoColeta.Text = "Endereço Coleta";
            // 
            // mtxt_CepColeta
            // 
            this.mtxt_CepColeta.Location = new System.Drawing.Point(9, 54);
            this.mtxt_CepColeta.Mask = "00000-000";
            this.mtxt_CepColeta.Name = "mtxt_CepColeta";
            this.mtxt_CepColeta.Size = new System.Drawing.Size(71, 20);
            this.mtxt_CepColeta.TabIndex = 0;
            this.mtxt_CepColeta.Leave += new System.EventHandler(this.mtxt_CepColeta_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bairro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Complemento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Logradouro: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CEP:";
            // 
            // txt_estadoColeta
            // 
            this.txt_estadoColeta.Location = new System.Drawing.Point(199, 184);
            this.txt_estadoColeta.Name = "txt_estadoColeta";
            this.txt_estadoColeta.ReadOnly = true;
            this.txt_estadoColeta.Size = new System.Drawing.Size(59, 20);
            this.txt_estadoColeta.TabIndex = 11;
            // 
            // txt_CidadeColeta
            // 
            this.txt_CidadeColeta.Location = new System.Drawing.Point(9, 184);
            this.txt_CidadeColeta.Name = "txt_CidadeColeta";
            this.txt_CidadeColeta.ReadOnly = true;
            this.txt_CidadeColeta.Size = new System.Drawing.Size(170, 20);
            this.txt_CidadeColeta.TabIndex = 9;
            // 
            // txt_BairroColeta
            // 
            this.txt_BairroColeta.Location = new System.Drawing.Point(199, 119);
            this.txt_BairroColeta.Name = "txt_BairroColeta";
            this.txt_BairroColeta.ReadOnly = true;
            this.txt_BairroColeta.Size = new System.Drawing.Size(131, 20);
            this.txt_BairroColeta.TabIndex = 8;
            // 
            // txt_ComplementoColeta
            // 
            this.txt_ComplementoColeta.Location = new System.Drawing.Point(9, 119);
            this.txt_ComplementoColeta.Name = "txt_ComplementoColeta";
            this.txt_ComplementoColeta.Size = new System.Drawing.Size(167, 20);
            this.txt_ComplementoColeta.TabIndex = 7;
            // 
            // txt_LogradouroColeta
            // 
            this.txt_LogradouroColeta.Location = new System.Drawing.Point(199, 54);
            this.txt_LogradouroColeta.Name = "txt_LogradouroColeta";
            this.txt_LogradouroColeta.ReadOnly = true;
            this.txt_LogradouroColeta.Size = new System.Drawing.Size(322, 20);
            this.txt_LogradouroColeta.TabIndex = 6;
            // 
            // txt_estadoEntrega
            // 
            this.txt_estadoEntrega.Location = new System.Drawing.Point(199, 184);
            this.txt_estadoEntrega.Name = "txt_estadoEntrega";
            this.txt_estadoEntrega.ReadOnly = true;
            this.txt_estadoEntrega.Size = new System.Drawing.Size(59, 20);
            this.txt_estadoEntrega.TabIndex = 11;
            // 
            // txt_CidadeEntrega
            // 
            this.txt_CidadeEntrega.Location = new System.Drawing.Point(9, 184);
            this.txt_CidadeEntrega.Name = "txt_CidadeEntrega";
            this.txt_CidadeEntrega.ReadOnly = true;
            this.txt_CidadeEntrega.Size = new System.Drawing.Size(170, 20);
            this.txt_CidadeEntrega.TabIndex = 9;
            // 
            // txt_BairroEntrega
            // 
            this.txt_BairroEntrega.Location = new System.Drawing.Point(199, 119);
            this.txt_BairroEntrega.Name = "txt_BairroEntrega";
            this.txt_BairroEntrega.ReadOnly = true;
            this.txt_BairroEntrega.Size = new System.Drawing.Size(131, 20);
            this.txt_BairroEntrega.TabIndex = 8;
            // 
            // txt_ComplementoEntrega
            // 
            this.txt_ComplementoEntrega.Location = new System.Drawing.Point(9, 119);
            this.txt_ComplementoEntrega.Name = "txt_ComplementoEntrega";
            this.txt_ComplementoEntrega.Size = new System.Drawing.Size(167, 20);
            this.txt_ComplementoEntrega.TabIndex = 7;
            // 
            // txt_LogradouroEntrega
            // 
            this.txt_LogradouroEntrega.Location = new System.Drawing.Point(199, 54);
            this.txt_LogradouroEntrega.Name = "txt_LogradouroEntrega";
            this.txt_LogradouroEntrega.ReadOnly = true;
            this.txt_LogradouroEntrega.Size = new System.Drawing.Size(322, 20);
            this.txt_LogradouroEntrega.TabIndex = 6;
            // 
            // frm_CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 587);
            this.Controls.Add(this.grpEnderecoColeta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.grp_EnderecoEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_CadastroPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro Pedido";
            this.grp_EnderecoEntrega.ResumeLayout(false);
            this.grp_EnderecoEntrega.PerformLayout();
            this.grpEnderecoColeta.ResumeLayout(false);
            this.grpEnderecoColeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grp_EnderecoEntrega;
        private System.Windows.Forms.Label lbl_CEP;
        private System.Windows.Forms.Label lbl_Complemento;
        private TruckDriverTextBox txt_LogradouroEntrega;
        private System.Windows.Forms.Label lbl_Logradouro;
        private TruckDriverTextBox txt_ComplementoEntrega;
        private TruckDriverTextBox txt_BairroEntrega;
        private System.Windows.Forms.Label lbl_Bairro;
        private TruckDriverTextBox txt_CidadeEntrega;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.MaskedTextBox mtxt_CepEntrega;
        private TruckDriverTextBox txt_estadoEntrega;
        private System.Windows.Forms.GroupBox grpEnderecoColeta;
        private TruckDriverTextBox txt_estadoColeta;
        private System.Windows.Forms.MaskedTextBox mtxt_CepColeta;
        private TruckDriverTextBox txt_CidadeColeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TruckDriverTextBox txt_BairroColeta;
        private System.Windows.Forms.Label label3;
        private TruckDriverTextBox txt_ComplementoColeta;
        private System.Windows.Forms.Label label4;
        private TruckDriverTextBox txt_LogradouroColeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}