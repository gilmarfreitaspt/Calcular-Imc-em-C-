namespace WindowsFormsApp1
{
    partial class Form3
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
            this.Grelha = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classicacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grelha)).BeginInit();
            this.SuspendLayout();
            // 
            // Grelha
            // 
            this.Grelha.AllowUserToDeleteRows = false;
            this.Grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grelha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.sexo,
            this.peso,
            this.altura,
            this.imc,
            this.classicacao,
            this.data});
            this.Grelha.Location = new System.Drawing.Point(0, 0);
            this.Grelha.Name = "Grelha";
            this.Grelha.ReadOnly = true;
            this.Grelha.Size = new System.Drawing.Size(605, 150);
            this.Grelha.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.Width = 60;
            // 
            // altura
            // 
            this.altura.HeaderText = "Altura";
            this.altura.Name = "altura";
            this.altura.ReadOnly = true;
            // 
            // imc
            // 
            this.imc.HeaderText = "IMC";
            this.imc.Name = "imc";
            this.imc.ReadOnly = true;
            // 
            // classicacao
            // 
            this.classicacao.HeaderText = "Classificação";
            this.classicacao.Name = "classicacao";
            this.classicacao.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grelha);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grelha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grelha;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn imc;
        private System.Windows.Forms.DataGridViewTextBoxColumn classicacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.Button button1;
    }
}