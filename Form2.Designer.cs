namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.bttFechar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.Location = new System.Drawing.Point(66, 207);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Size = new System.Drawing.Size(75, 23);
            this.bttAdicionar.TabIndex = 1;
            this.bttAdicionar.Text = "Adicionar";
            this.bttAdicionar.UseVisualStyleBackColor = true;
            this.bttAdicionar.Click += new System.EventHandler(this.bttAdicionar_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(190, 207);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttCancelar.TabIndex = 2;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            // 
            // bttFechar
            // 
            this.bttFechar.Location = new System.Drawing.Point(312, 207);
            this.bttFechar.Name = "bttFechar";
            this.bttFechar.Size = new System.Drawing.Size(75, 23);
            this.bttFechar.TabIndex = 3;
            this.bttFechar.Text = "Fechar";
            this.bttFechar.UseVisualStyleBackColor = true;
            this.bttFechar.Click += new System.EventHandler(this.bttFechar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(165, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.bttFechar);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttAdicionar);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttAdicionar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Button bttFechar;
        private System.Windows.Forms.TextBox txtNome;
    }
}