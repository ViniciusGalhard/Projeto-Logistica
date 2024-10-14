namespace Projeto_Logistica
{
    partial class PaginaBuscaContratanteNovo
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
            this.btnBuscaContratanteCadastrarNovaRota = new System.Windows.Forms.Button();
            this.dvgBuscaContratante = new System.Windows.Forms.DataGridView();
            this.tbxBuscaContratanteCargamaxima = new System.Windows.Forms.TextBox();
            this.cbxBuscaContratanteTipocarga = new System.Windows.Forms.ComboBox();
            this.tbxBuscaContratanteDatachegada = new System.Windows.Forms.TextBox();
            this.tbxBuscaContratanteDatasaida = new System.Windows.Forms.TextBox();
            this.tbxBuscaContratanteDestino = new System.Windows.Forms.TextBox();
            this.tbxBuscaContratanteLocalpartida = new System.Windows.Forms.TextBox();
            this.lblBuscaContratanteCargamaxima = new System.Windows.Forms.Label();
            this.lblBuscaContratanteTipocarga = new System.Windows.Forms.Label();
            this.lblBuscaContratanteDatachegada = new System.Windows.Forms.Label();
            this.lblBuscaContratanteDatasaida = new System.Windows.Forms.Label();
            this.lblBuscaContratanteDestino = new System.Windows.Forms.Label();
            this.lblBuscaContratanteLocalpartida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBuscaContratante)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscaContratanteCadastrarNovaRota
            // 
            this.btnBuscaContratanteCadastrarNovaRota.Location = new System.Drawing.Point(15, 335);
            this.btnBuscaContratanteCadastrarNovaRota.Name = "btnBuscaContratanteCadastrarNovaRota";
            this.btnBuscaContratanteCadastrarNovaRota.Size = new System.Drawing.Size(100, 27);
            this.btnBuscaContratanteCadastrarNovaRota.TabIndex = 27;
            this.btnBuscaContratanteCadastrarNovaRota.Text = "Nova Rota";
            this.btnBuscaContratanteCadastrarNovaRota.UseVisualStyleBackColor = true;
            this.btnBuscaContratanteCadastrarNovaRota.Click += new System.EventHandler(this.btnBuscaContratanteCadastrarNovaRota_Click);
            // 
            // dvgBuscaContratante
            // 
            this.dvgBuscaContratante.BackgroundColor = System.Drawing.Color.White;
            this.dvgBuscaContratante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBuscaContratante.Location = new System.Drawing.Point(12, 66);
            this.dvgBuscaContratante.Name = "dvgBuscaContratante";
            this.dvgBuscaContratante.Size = new System.Drawing.Size(822, 263);
            this.dvgBuscaContratante.TabIndex = 26;
            this.dvgBuscaContratante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgBuscaContratante_CellContentClick);
            // 
            // tbxBuscaContratanteCargamaxima
            // 
            this.tbxBuscaContratanteCargamaxima.Location = new System.Drawing.Point(737, 39);
            this.tbxBuscaContratanteCargamaxima.Name = "tbxBuscaContratanteCargamaxima";
            this.tbxBuscaContratanteCargamaxima.Size = new System.Drawing.Size(100, 20);
            this.tbxBuscaContratanteCargamaxima.TabIndex = 25;
            this.tbxBuscaContratanteCargamaxima.TextChanged += new System.EventHandler(this.tbxBuscaContratanteCargamaxima_TextChanged);
            // 
            // cbxBuscaContratanteTipocarga
            // 
            this.cbxBuscaContratanteTipocarga.FormattingEnabled = true;
            this.cbxBuscaContratanteTipocarga.Items.AddRange(new object[] {
            "Carroceria Frigorífica",
            "Carroceria Graneleira",
            "Carroceria Sider",
            "Carroceria Plataforma",
            "Carroceria Balançada",
            "Carroceria Tanque",
            "Carroceria Carga Secas",
            "Carroceria Open Deck",
            "Carroceria de Transporte de Animais",
            "Caçamba Basculante",
            "Caçamba Graneleira",
            "Caçamba Hidráulica",
            "Caçamba Frontal",
            "Caçamba de Coleta de Resíduos",
            "Caçamba de Transporte de Entulho",
            "Caçamba Rebaixada",
            "Caçamba Alongada"});
            this.cbxBuscaContratanteTipocarga.Location = new System.Drawing.Point(587, 39);
            this.cbxBuscaContratanteTipocarga.Name = "cbxBuscaContratanteTipocarga";
            this.cbxBuscaContratanteTipocarga.Size = new System.Drawing.Size(121, 21);
            this.cbxBuscaContratanteTipocarga.TabIndex = 24;
            this.cbxBuscaContratanteTipocarga.SelectedIndexChanged += new System.EventHandler(this.cbxBuscaContratanteTipocarga_SelectedIndexChanged);
            // 
            // tbxBuscaContratanteDatachegada
            // 
            this.tbxBuscaContratanteDatachegada.Location = new System.Drawing.Point(425, 39);
            this.tbxBuscaContratanteDatachegada.Name = "tbxBuscaContratanteDatachegada";
            this.tbxBuscaContratanteDatachegada.Size = new System.Drawing.Size(126, 20);
            this.tbxBuscaContratanteDatachegada.TabIndex = 23;
            this.tbxBuscaContratanteDatachegada.TextChanged += new System.EventHandler(this.tbxBuscaContratanteDatachegada_TextChanged);
            // 
            // tbxBuscaContratanteDatasaida
            // 
            this.tbxBuscaContratanteDatasaida.Location = new System.Drawing.Point(300, 39);
            this.tbxBuscaContratanteDatasaida.Name = "tbxBuscaContratanteDatasaida";
            this.tbxBuscaContratanteDatasaida.Size = new System.Drawing.Size(100, 20);
            this.tbxBuscaContratanteDatasaida.TabIndex = 22;
            this.tbxBuscaContratanteDatasaida.TextChanged += new System.EventHandler(this.tbxBuscaContratanteDatasaida_TextChanged);
            // 
            // tbxBuscaContratanteDestino
            // 
            this.tbxBuscaContratanteDestino.Location = new System.Drawing.Point(167, 39);
            this.tbxBuscaContratanteDestino.Name = "tbxBuscaContratanteDestino";
            this.tbxBuscaContratanteDestino.Size = new System.Drawing.Size(97, 20);
            this.tbxBuscaContratanteDestino.TabIndex = 21;
            this.tbxBuscaContratanteDestino.TextChanged += new System.EventHandler(this.tbxBuscaContratanteDestino_TextChanged);
            // 
            // tbxBuscaContratanteLocalpartida
            // 
            this.tbxBuscaContratanteLocalpartida.Location = new System.Drawing.Point(15, 39);
            this.tbxBuscaContratanteLocalpartida.Name = "tbxBuscaContratanteLocalpartida";
            this.tbxBuscaContratanteLocalpartida.Size = new System.Drawing.Size(118, 20);
            this.tbxBuscaContratanteLocalpartida.TabIndex = 20;
            this.tbxBuscaContratanteLocalpartida.TextChanged += new System.EventHandler(this.tbxBuscaContratanteLocalpartida_TextChanged);
            // 
            // lblBuscaContratanteCargamaxima
            // 
            this.lblBuscaContratanteCargamaxima.AutoSize = true;
            this.lblBuscaContratanteCargamaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaContratanteCargamaxima.Location = new System.Drawing.Point(734, 9);
            this.lblBuscaContratanteCargamaxima.Name = "lblBuscaContratanteCargamaxima";
            this.lblBuscaContratanteCargamaxima.Size = new System.Drawing.Size(106, 16);
            this.lblBuscaContratanteCargamaxima.TabIndex = 19;
            this.lblBuscaContratanteCargamaxima.Text = "Carga Máxima";
            // 
            // lblBuscaContratanteTipocarga
            // 
            this.lblBuscaContratanteTipocarga.AutoSize = true;
            this.lblBuscaContratanteTipocarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaContratanteTipocarga.Location = new System.Drawing.Point(584, 9);
            this.lblBuscaContratanteTipocarga.Name = "lblBuscaContratanteTipocarga";
            this.lblBuscaContratanteTipocarga.Size = new System.Drawing.Size(107, 16);
            this.lblBuscaContratanteTipocarga.TabIndex = 18;
            this.lblBuscaContratanteTipocarga.Text = "Tipo de Carga";
            // 
            // lblBuscaContratanteDatachegada
            // 
            this.lblBuscaContratanteDatachegada.AutoSize = true;
            this.lblBuscaContratanteDatachegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaContratanteDatachegada.Location = new System.Drawing.Point(422, 9);
            this.lblBuscaContratanteDatachegada.Name = "lblBuscaContratanteDatachegada";
            this.lblBuscaContratanteDatachegada.Size = new System.Drawing.Size(129, 16);
            this.lblBuscaContratanteDatachegada.TabIndex = 17;
            this.lblBuscaContratanteDatachegada.Text = "Data de Chegada";
            // 
            // lblBuscaContratanteDatasaida
            // 
            this.lblBuscaContratanteDatasaida.AutoSize = true;
            this.lblBuscaContratanteDatasaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaContratanteDatasaida.Location = new System.Drawing.Point(297, 9);
            this.lblBuscaContratanteDatasaida.Name = "lblBuscaContratanteDatasaida";
            this.lblBuscaContratanteDatasaida.Size = new System.Drawing.Size(107, 16);
            this.lblBuscaContratanteDatasaida.TabIndex = 16;
            this.lblBuscaContratanteDatasaida.Text = "Data de Saida";
            // 
            // lblBuscaContratanteDestino
            // 
            this.lblBuscaContratanteDestino.AutoSize = true;
            this.lblBuscaContratanteDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaContratanteDestino.Location = new System.Drawing.Point(177, 9);
            this.lblBuscaContratanteDestino.Name = "lblBuscaContratanteDestino";
            this.lblBuscaContratanteDestino.Size = new System.Drawing.Size(60, 16);
            this.lblBuscaContratanteDestino.TabIndex = 15;
            this.lblBuscaContratanteDestino.Text = "Destino";
            // 
            // lblBuscaContratanteLocalpartida
            // 
            this.lblBuscaContratanteLocalpartida.AutoSize = true;
            this.lblBuscaContratanteLocalpartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaContratanteLocalpartida.Location = new System.Drawing.Point(12, 9);
            this.lblBuscaContratanteLocalpartida.Name = "lblBuscaContratanteLocalpartida";
            this.lblBuscaContratanteLocalpartida.Size = new System.Drawing.Size(121, 16);
            this.lblBuscaContratanteLocalpartida.TabIndex = 14;
            this.lblBuscaContratanteLocalpartida.Text = "Local de Partida";
            // 
            // PaginaBuscaContratanteNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Logistica.Properties.Resources.imagem2;
            this.ClientSize = new System.Drawing.Size(884, 363);
            this.Controls.Add(this.btnBuscaContratanteCadastrarNovaRota);
            this.Controls.Add(this.dvgBuscaContratante);
            this.Controls.Add(this.tbxBuscaContratanteCargamaxima);
            this.Controls.Add(this.cbxBuscaContratanteTipocarga);
            this.Controls.Add(this.tbxBuscaContratanteDatachegada);
            this.Controls.Add(this.tbxBuscaContratanteDatasaida);
            this.Controls.Add(this.tbxBuscaContratanteDestino);
            this.Controls.Add(this.tbxBuscaContratanteLocalpartida);
            this.Controls.Add(this.lblBuscaContratanteCargamaxima);
            this.Controls.Add(this.lblBuscaContratanteTipocarga);
            this.Controls.Add(this.lblBuscaContratanteDatachegada);
            this.Controls.Add(this.lblBuscaContratanteDatasaida);
            this.Controls.Add(this.lblBuscaContratanteDestino);
            this.Controls.Add(this.lblBuscaContratanteLocalpartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PaginaBuscaContratanteNovo";
            this.Text = "PaginaBuscaContratanteNovo";
            ((System.ComponentModel.ISupportInitialize)(this.dvgBuscaContratante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscaContratanteCadastrarNovaRota;
        private System.Windows.Forms.DataGridView dvgBuscaContratante;
        private System.Windows.Forms.TextBox tbxBuscaContratanteCargamaxima;
        private System.Windows.Forms.ComboBox cbxBuscaContratanteTipocarga;
        private System.Windows.Forms.TextBox tbxBuscaContratanteDatachegada;
        private System.Windows.Forms.TextBox tbxBuscaContratanteDatasaida;
        private System.Windows.Forms.TextBox tbxBuscaContratanteDestino;
        private System.Windows.Forms.TextBox tbxBuscaContratanteLocalpartida;
        private System.Windows.Forms.Label lblBuscaContratanteCargamaxima;
        private System.Windows.Forms.Label lblBuscaContratanteTipocarga;
        private System.Windows.Forms.Label lblBuscaContratanteDatachegada;
        private System.Windows.Forms.Label lblBuscaContratanteDatasaida;
        private System.Windows.Forms.Label lblBuscaContratanteDestino;
        private System.Windows.Forms.Label lblBuscaContratanteLocalpartida;
    }
}