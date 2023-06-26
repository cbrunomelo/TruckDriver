namespace TruckDriver.WindowsFormsApp.Formularios.ChildForms
{
    partial class frm_Motoristas
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
            this.grp_Motoristas = new System.Windows.Forms.GroupBox();
            this.dgv_Motoristas = new System.Windows.Forms.DataGridView();
            this.btn_Adcionar = new System.Windows.Forms.Button();
            this.btn_Exibir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.grp_Motoristas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Motoristas)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Motoristas
            // 
            this.grp_Motoristas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Motoristas.Controls.Add(this.dgv_Motoristas);
            this.grp_Motoristas.Location = new System.Drawing.Point(2, 12);
            this.grp_Motoristas.Name = "grp_Motoristas";
            this.grp_Motoristas.Size = new System.Drawing.Size(1325, 638);
            this.grp_Motoristas.TabIndex = 0;
            this.grp_Motoristas.TabStop = false;
            this.grp_Motoristas.Text = "Motoristas";
            // 
            // dgv_Motoristas
            // 
            this.dgv_Motoristas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Motoristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Motoristas.Location = new System.Drawing.Point(3, 16);
            this.dgv_Motoristas.Name = "dgv_Motoristas";
            this.dgv_Motoristas.Size = new System.Drawing.Size(1319, 619);
            this.dgv_Motoristas.TabIndex = 0;
            this.dgv_Motoristas.SizeChanged += new System.EventHandler(this.dgv_Motoristas_SizeChanged);
            // 
            // btn_Adcionar
            // 
            this.btn_Adcionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Adcionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adcionar.Location = new System.Drawing.Point(1245, 660);
            this.btn_Adcionar.Name = "btn_Adcionar";
            this.btn_Adcionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adcionar.TabIndex = 1;
            this.btn_Adcionar.Text = "Adcionar";
            this.btn_Adcionar.UseVisualStyleBackColor = true;
            this.btn_Adcionar.Click += new System.EventHandler(this.btn_Adcionar_Click);
            // 
            // btn_Exibir
            // 
            this.btn_Exibir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exibir.Location = new System.Drawing.Point(1164, 660);
            this.btn_Exibir.Name = "btn_Exibir";
            this.btn_Exibir.Size = new System.Drawing.Size(75, 23);
            this.btn_Exibir.TabIndex = 2;
            this.btn_Exibir.Text = "Exibir";
            this.btn_Exibir.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(1083, 660);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // frm_Motoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1332, 708);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Exibir);
            this.Controls.Add(this.btn_Adcionar);
            this.Controls.Add(this.grp_Motoristas);
            this.Name = "frm_Motoristas";
            this.Text = "Motoristas";
            this.grp_Motoristas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Motoristas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Motoristas;
        private System.Windows.Forms.DataGridView dgv_Motoristas;
        private System.Windows.Forms.Button btn_Adcionar;
        private System.Windows.Forms.Button btn_Exibir;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}