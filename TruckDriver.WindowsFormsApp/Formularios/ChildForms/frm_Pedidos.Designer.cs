namespace TruckDriver.WindowsFormsApp.Formularios.ChildForms
{
    partial class frm_Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_Motoristas = new System.Windows.Forms.GroupBox();
            this.dgv_pedidos = new System.Windows.Forms.DataGridView();
            this.btn_Adcionar = new System.Windows.Forms.Button();
            this.btn_Detalhar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.grp_filtros = new System.Windows.Forms.GroupBox();
            this.btn_limparFiltros = new System.Windows.Forms.Button();
            this.cmb_PedidoStatus = new System.Windows.Forms.ComboBox();
            this.bnt_filtrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BuscarPorPedido = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_NumeroDePaginas = new System.Windows.Forms.Label();
            this.btn_Anterior = new System.Windows.Forms.Button();
            this.btn_Proximo = new System.Windows.Forms.Button();
            this.btn_Ir = new System.Windows.Forms.Button();
            this.txt_Ir = new WindowsFormsApp1.Controls.TruckDriverTextBox();
            this.grp_Motoristas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).BeginInit();
            this.grp_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Motoristas
            // 
            this.grp_Motoristas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Motoristas.Controls.Add(this.dgv_pedidos);
            this.grp_Motoristas.Location = new System.Drawing.Point(3, 100);
            this.grp_Motoristas.Name = "grp_Motoristas";
            this.grp_Motoristas.Size = new System.Drawing.Size(1494, 503);
            this.grp_Motoristas.TabIndex = 0;
            this.grp_Motoristas.TabStop = false;
            this.grp_Motoristas.Text = "Motoristas";
            // 
            // dgv_pedidos
            // 
            this.dgv_pedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidos.Location = new System.Drawing.Point(3, 16);
            this.dgv_pedidos.Name = "dgv_pedidos";
            this.dgv_pedidos.Size = new System.Drawing.Size(1488, 484);
            this.dgv_pedidos.TabIndex = 0;
            this.dgv_pedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedidos_CellContentClick);
            this.dgv_pedidos.SizeChanged += new System.EventHandler(this.dgv_pedidos_SizeChanged);
            // 
            // btn_Adcionar
            // 
            this.btn_Adcionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Adcionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adcionar.Location = new System.Drawing.Point(1419, 626);
            this.btn_Adcionar.Name = "btn_Adcionar";
            this.btn_Adcionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adcionar.TabIndex = 1;
            this.btn_Adcionar.Text = "Adcionar";
            this.btn_Adcionar.UseVisualStyleBackColor = true;
            this.btn_Adcionar.Click += new System.EventHandler(this.btn_Adcionar_Click);
            // 
            // btn_Detalhar
            // 
            this.btn_Detalhar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Detalhar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Detalhar.Location = new System.Drawing.Point(1338, 626);
            this.btn_Detalhar.Name = "btn_Detalhar";
            this.btn_Detalhar.Size = new System.Drawing.Size(75, 23);
            this.btn_Detalhar.TabIndex = 2;
            this.btn_Detalhar.Text = "Detalhar";
            this.btn_Detalhar.UseVisualStyleBackColor = true;
            this.btn_Detalhar.Click += new System.EventHandler(this.btn_Detalhar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(1257, 626);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // grp_filtros
            // 
            this.grp_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_filtros.Controls.Add(this.btn_limparFiltros);
            this.grp_filtros.Controls.Add(this.cmb_PedidoStatus);
            this.grp_filtros.Controls.Add(this.bnt_filtrar);
            this.grp_filtros.Controls.Add(this.label2);
            this.grp_filtros.Controls.Add(this.txt_BuscarPorPedido);
            this.grp_filtros.Controls.Add(this.label1);
            this.grp_filtros.Location = new System.Drawing.Point(6, 12);
            this.grp_filtros.Name = "grp_filtros";
            this.grp_filtros.Size = new System.Drawing.Size(1565, 82);
            this.grp_filtros.TabIndex = 4;
            this.grp_filtros.TabStop = false;
            this.grp_filtros.Text = "Filtros";
            // 
            // btn_limparFiltros
            // 
            this.btn_limparFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_limparFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparFiltros.Location = new System.Drawing.Point(146, 53);
            this.btn_limparFiltros.Name = "btn_limparFiltros";
            this.btn_limparFiltros.Size = new System.Drawing.Size(90, 23);
            this.btn_limparFiltros.TabIndex = 6;
            this.btn_limparFiltros.Text = "Limpar Filtros";
            this.btn_limparFiltros.UseVisualStyleBackColor = true;
            this.btn_limparFiltros.Click += new System.EventHandler(this.btn_LimparFiltro_Click);
            // 
            // cmb_PedidoStatus
            // 
            this.cmb_PedidoStatus.FormattingEnabled = true;
            this.cmb_PedidoStatus.Location = new System.Drawing.Point(339, 21);
            this.cmb_PedidoStatus.Name = "cmb_PedidoStatus";
            this.cmb_PedidoStatus.Size = new System.Drawing.Size(121, 21);
            this.cmb_PedidoStatus.TabIndex = 5;
            this.cmb_PedidoStatus.SelectedValueChanged += new System.EventHandler(this.cmb_PedidoStatus_SelectedValueChanged);
            // 
            // bnt_filtrar
            // 
            this.bnt_filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnt_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_filtrar.Location = new System.Drawing.Point(9, 53);
            this.bnt_filtrar.Name = "bnt_filtrar";
            this.bnt_filtrar.Size = new System.Drawing.Size(75, 23);
            this.bnt_filtrar.TabIndex = 4;
            this.bnt_filtrar.Text = "Filtrar";
            this.bnt_filtrar.UseVisualStyleBackColor = true;
            this.bnt_filtrar.Click += new System.EventHandler(this.bnt_filtrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            // 
            // txt_BuscarPorPedido
            // 
            this.txt_BuscarPorPedido.Location = new System.Drawing.Point(146, 22);
            this.txt_BuscarPorPedido.Name = "txt_BuscarPorPedido";
            this.txt_BuscarPorPedido.Size = new System.Drawing.Size(124, 20);
            this.txt_BuscarPorPedido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por Número Pedido";
            // 
            // lbl_NumeroDePaginas
            // 
            this.lbl_NumeroDePaginas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_NumeroDePaginas.AutoSize = true;
            this.lbl_NumeroDePaginas.Location = new System.Drawing.Point(501, 603);
            this.lbl_NumeroDePaginas.Name = "lbl_NumeroDePaginas";
            this.lbl_NumeroDePaginas.Size = new System.Drawing.Size(83, 13);
            this.lbl_NumeroDePaginas.TabIndex = 5;
            this.lbl_NumeroDePaginas.Text = "1 de 25 páginas";
            // 
            // btn_Anterior
            // 
            this.btn_Anterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Anterior.Location = new System.Drawing.Point(464, 626);
            this.btn_Anterior.Name = "btn_Anterior";
            this.btn_Anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_Anterior.TabIndex = 6;
            this.btn_Anterior.Text = "Anterior";
            this.btn_Anterior.UseVisualStyleBackColor = true;
            this.btn_Anterior.Click += new System.EventHandler(this.btn_Anterior_Click);
            // 
            // btn_Proximo
            // 
            this.btn_Proximo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Proximo.Location = new System.Drawing.Point(545, 626);
            this.btn_Proximo.Name = "btn_Proximo";
            this.btn_Proximo.Size = new System.Drawing.Size(75, 23);
            this.btn_Proximo.TabIndex = 7;
            this.btn_Proximo.Text = "Próximo";
            this.btn_Proximo.UseVisualStyleBackColor = true;
            this.btn_Proximo.Click += new System.EventHandler(this.btn_Proximo_Click);
            // 
            // btn_Ir
            // 
            this.btn_Ir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Ir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ir.Location = new System.Drawing.Point(713, 625);
            this.btn_Ir.Name = "btn_Ir";
            this.btn_Ir.Size = new System.Drawing.Size(75, 23);
            this.btn_Ir.TabIndex = 8;
            this.btn_Ir.Text = "Ir";
            this.btn_Ir.UseVisualStyleBackColor = true;
            this.btn_Ir.Click += new System.EventHandler(this.btn_Ir_Click);
            // 
            // txt_Ir
            // 
            this.txt_Ir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Ir.Location = new System.Drawing.Point(669, 627);
            this.txt_Ir.Name = "txt_Ir";
            this.txt_Ir.Size = new System.Drawing.Size(38, 20);
            this.txt_Ir.TabIndex = 9;
            // 
            // frm_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1502, 661);
            this.Controls.Add(this.txt_Ir);
            this.Controls.Add(this.btn_Ir);
            this.Controls.Add(this.btn_Proximo);
            this.Controls.Add(this.btn_Anterior);
            this.Controls.Add(this.lbl_NumeroDePaginas);
            this.Controls.Add(this.grp_filtros);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Detalhar);
            this.Controls.Add(this.btn_Adcionar);
            this.Controls.Add(this.grp_Motoristas);
            this.Name = "frm_Pedidos";
            this.Text = "Motoristas";
            this.grp_Motoristas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).EndInit();
            this.grp_filtros.ResumeLayout(false);
            this.grp_filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Motoristas;
        private System.Windows.Forms.DataGridView dgv_pedidos;
        private System.Windows.Forms.Button btn_Adcionar;
        private System.Windows.Forms.Button btn_Detalhar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox grp_filtros;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApp1.Controls.TruckDriverTextBox txt_BuscarPorPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_filtrar;
        private System.Windows.Forms.ComboBox cmb_PedidoStatus;
        private System.Windows.Forms.Label lbl_NumeroDePaginas;
        private System.Windows.Forms.Button btn_Anterior;
        private System.Windows.Forms.Button btn_Proximo;
        private System.Windows.Forms.Button btn_Ir;
        private WindowsFormsApp1.Controls.TruckDriverTextBox txt_Ir;
        private System.Windows.Forms.Button btn_limparFiltros;
    }
}