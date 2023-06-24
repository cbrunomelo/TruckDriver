using WindowsFormsApp1.Controls;
namespace WindowsFormsApp1.Formularios.Cadastros
{
    partial class frm_CadastroMotorista
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
            this.grp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.mtxt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.lbl_CNH = new System.Windows.Forms.Label();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.lbl_Sobrenome = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grp_Endereco = new System.Windows.Forms.GroupBox();
            this.mtxt_CEP = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Complemento = new System.Windows.Forms.Label();
            this.lbl_Logradouro = new System.Windows.Forms.Label();
            this.lbl_CEP = new System.Windows.Forms.Label();
            this.grp_Telefone = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.lbl_TelefoneResidencial = new System.Windows.Forms.Label();
            this.lbl_Celular = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_estado = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_Cidade = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_Bairro = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_Complemento = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_Logradouro = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_NumeroCNH = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_Sobrenome = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.txt_NomeMotorista = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.grp_DadosPessoais.SuspendLayout();
            this.grp_Endereco.SuspendLayout();
            this.grp_Telefone.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_DadosPessoais
            // 
            this.grp_DadosPessoais.Controls.Add(this.mtxt_CPF);
            this.grp_DadosPessoais.Controls.Add(this.txt_NumeroCNH);
            this.grp_DadosPessoais.Controls.Add(this.lbl_CNH);
            this.grp_DadosPessoais.Controls.Add(this.lbl_Cpf);
            this.grp_DadosPessoais.Controls.Add(this.txt_Sobrenome);
            this.grp_DadosPessoais.Controls.Add(this.lbl_Sobrenome);
            this.grp_DadosPessoais.Controls.Add(this.lbl_Nome);
            this.grp_DadosPessoais.Controls.Add(this.txt_NomeMotorista);
            this.grp_DadosPessoais.Location = new System.Drawing.Point(6, 12);
            this.grp_DadosPessoais.Name = "grp_DadosPessoais";
            this.grp_DadosPessoais.Size = new System.Drawing.Size(557, 181);
            this.grp_DadosPessoais.TabIndex = 0;
            this.grp_DadosPessoais.TabStop = false;
            this.grp_DadosPessoais.Text = "Dados Pessoais";
            // 
            // mtxt_CPF
            // 
            this.mtxt_CPF.Location = new System.Drawing.Point(9, 119);
            this.mtxt_CPF.Mask = "000,000,000-00";
            this.mtxt_CPF.Name = "mtxt_CPF";
            this.mtxt_CPF.Size = new System.Drawing.Size(89, 20);
            this.mtxt_CPF.TabIndex = 3;
            // 
            // lbl_CNH
            // 
            this.lbl_CNH.AutoSize = true;
            this.lbl_CNH.Location = new System.Drawing.Point(196, 96);
            this.lbl_CNH.Name = "lbl_CNH";
            this.lbl_CNH.Size = new System.Drawing.Size(76, 13);
            this.lbl_CNH.TabIndex = 6;
            this.lbl_CNH.Text = "Número CNH: ";
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Location = new System.Drawing.Point(6, 96);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(33, 13);
            this.lbl_Cpf.TabIndex = 4;
            this.lbl_Cpf.Text = "CPF: ";
            // 
            // lbl_Sobrenome
            // 
            this.lbl_Sobrenome.AutoSize = true;
            this.lbl_Sobrenome.Location = new System.Drawing.Point(196, 31);
            this.lbl_Sobrenome.Name = "lbl_Sobrenome";
            this.lbl_Sobrenome.Size = new System.Drawing.Size(64, 13);
            this.lbl_Sobrenome.TabIndex = 2;
            this.lbl_Sobrenome.Text = "Sobrenome:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(6, 31);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome:";
            // 
            // grp_Endereco
            // 
            this.grp_Endereco.Controls.Add(this.txt_estado);
            this.grp_Endereco.Controls.Add(this.mtxt_CEP);
            this.grp_Endereco.Controls.Add(this.txt_Cidade);
            this.grp_Endereco.Controls.Add(this.lbl_Estado);
            this.grp_Endereco.Controls.Add(this.lbl_Cidade);
            this.grp_Endereco.Controls.Add(this.txt_Bairro);
            this.grp_Endereco.Controls.Add(this.lbl_Bairro);
            this.grp_Endereco.Controls.Add(this.txt_Complemento);
            this.grp_Endereco.Controls.Add(this.lbl_Complemento);
            this.grp_Endereco.Controls.Add(this.txt_Logradouro);
            this.grp_Endereco.Controls.Add(this.lbl_Logradouro);
            this.grp_Endereco.Controls.Add(this.lbl_CEP);
            this.grp_Endereco.Location = new System.Drawing.Point(6, 213);
            this.grp_Endereco.Name = "grp_Endereco";
            this.grp_Endereco.Size = new System.Drawing.Size(557, 223);
            this.grp_Endereco.TabIndex = 1;
            this.grp_Endereco.TabStop = false;
            this.grp_Endereco.Text = "Endereço";
            // 
            // mtxt_CEP
            // 
            this.mtxt_CEP.Location = new System.Drawing.Point(9, 54);
            this.mtxt_CEP.Mask = "00000-000";
            this.mtxt_CEP.Name = "mtxt_CEP";
            this.mtxt_CEP.Size = new System.Drawing.Size(71, 20);
            this.mtxt_CEP.TabIndex = 5;
            this.mtxt_CEP.Leave += new System.EventHandler(this.mtxt_CEP_Leave);
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
            // grp_Telefone
            // 
            this.grp_Telefone.Controls.Add(this.maskedTextBox1);
            this.grp_Telefone.Controls.Add(this.mtxt_Celular);
            this.grp_Telefone.Controls.Add(this.lbl_TelefoneResidencial);
            this.grp_Telefone.Controls.Add(this.lbl_Celular);
            this.grp_Telefone.Location = new System.Drawing.Point(6, 456);
            this.grp_Telefone.Name = "grp_Telefone";
            this.grp_Telefone.Size = new System.Drawing.Size(557, 103);
            this.grp_Telefone.TabIndex = 2;
            this.grp_Telefone.TabStop = false;
            this.grp_Telefone.Text = "Telefone";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(199, 54);
            this.maskedTextBox1.Mask = "(00)0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // mtxt_Celular
            // 
            this.mtxt_Celular.Location = new System.Drawing.Point(9, 54);
            this.mtxt_Celular.Mask = "(00)90000-0000";
            this.mtxt_Celular.Name = "mtxt_Celular";
            this.mtxt_Celular.Size = new System.Drawing.Size(100, 20);
            this.mtxt_Celular.TabIndex = 11;
            // 
            // lbl_TelefoneResidencial
            // 
            this.lbl_TelefoneResidencial.AutoSize = true;
            this.lbl_TelefoneResidencial.Location = new System.Drawing.Point(196, 32);
            this.lbl_TelefoneResidencial.Name = "lbl_TelefoneResidencial";
            this.lbl_TelefoneResidencial.Size = new System.Drawing.Size(62, 13);
            this.lbl_TelefoneResidencial.TabIndex = 3;
            this.lbl_TelefoneResidencial.Text = "Residencial";
            // 
            // lbl_Celular
            // 
            this.lbl_Celular.AutoSize = true;
            this.lbl_Celular.Location = new System.Drawing.Point(6, 31);
            this.lbl_Celular.Name = "lbl_Celular";
            this.lbl_Celular.Size = new System.Drawing.Size(42, 13);
            this.lbl_Celular.TabIndex = 0;
            this.lbl_Celular.Text = "Celular:";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(487, 587);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 3;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(406, 587);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(199, 184);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(59, 20);
            this.txt_estado.TabIndex = 11;
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(9, 184);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.ReadOnly = true;
            this.txt_Cidade.Size = new System.Drawing.Size(170, 20);
            this.txt_Cidade.TabIndex = 9;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(199, 119);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.ReadOnly = true;
            this.txt_Bairro.Size = new System.Drawing.Size(131, 20);
            this.txt_Bairro.TabIndex = 8;
            // 
            // txt_Complemento
            // 
            this.txt_Complemento.Location = new System.Drawing.Point(9, 119);
            this.txt_Complemento.Name = "txt_Complemento";
            this.txt_Complemento.Size = new System.Drawing.Size(167, 20);
            this.txt_Complemento.TabIndex = 7;
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Location = new System.Drawing.Point(199, 54);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.ReadOnly = true;
            this.txt_Logradouro.Size = new System.Drawing.Size(322, 20);
            this.txt_Logradouro.TabIndex = 6;
            // 
            // txt_NumeroCNH
            // 
            this.txt_NumeroCNH.Location = new System.Drawing.Point(199, 119);
            this.txt_NumeroCNH.Name = "txt_NumeroCNH";
            this.txt_NumeroCNH.Size = new System.Drawing.Size(135, 20);
            this.txt_NumeroCNH.TabIndex = 4;
            // 
            // txt_Sobrenome
            // 
            this.txt_Sobrenome.Location = new System.Drawing.Point(199, 54);
            this.txt_Sobrenome.Name = "txt_Sobrenome";
            this.txt_Sobrenome.Size = new System.Drawing.Size(226, 20);
            this.txt_Sobrenome.TabIndex = 2;
            // 
            // txt_NomeMotorista
            // 
            this.txt_NomeMotorista.Location = new System.Drawing.Point(9, 54);
            this.txt_NomeMotorista.Name = "txt_NomeMotorista";
            this.txt_NomeMotorista.Size = new System.Drawing.Size(167, 20);
            this.txt_NomeMotorista.TabIndex = 1;
            // 
            // frm_CadastroMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 630);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.grp_Telefone);
            this.Controls.Add(this.grp_Endereco);
            this.Controls.Add(this.grp_DadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_CadastroMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro Motorista";
            this.grp_DadosPessoais.ResumeLayout(false);
            this.grp_DadosPessoais.PerformLayout();
            this.grp_Endereco.ResumeLayout(false);
            this.grp_Endereco.PerformLayout();
            this.grp_Telefone.ResumeLayout(false);
            this.grp_Telefone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_DadosPessoais;
        private System.Windows.Forms.Label lbl_Cpf;
        private TruckDriverTextBox txt_Sobrenome;
        private System.Windows.Forms.Label lbl_Sobrenome;
        private System.Windows.Forms.Label lbl_Nome;
        private TruckDriverTextBox txt_NomeMotorista;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_CNH;
        private TruckDriverTextBox txt_NumeroCNH;
        private System.Windows.Forms.GroupBox grp_Endereco;
        private System.Windows.Forms.Label lbl_CEP;
        private System.Windows.Forms.Label lbl_Complemento;
        private TruckDriverTextBox txt_Logradouro;
        private System.Windows.Forms.Label lbl_Logradouro;
        private TruckDriverTextBox txt_Complemento;
        private TruckDriverTextBox txt_Bairro;
        private System.Windows.Forms.Label lbl_Bairro;
        private TruckDriverTextBox txt_Cidade;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.GroupBox grp_Telefone;
        private System.Windows.Forms.Label lbl_TelefoneResidencial;
        private System.Windows.Forms.Label lbl_Celular;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.MaskedTextBox mtxt_CPF;
        private System.Windows.Forms.MaskedTextBox mtxt_CEP;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox mtxt_Celular;
        private TruckDriverTextBox txt_estado;
    }
}