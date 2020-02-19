namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPeso = new System.Windows.Forms.ComboBox();
            this.cbAltura = new System.Windows.Forms.ComboBox();
            this.lblImc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl1a = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl2a = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl3a = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4a = new System.Windows.Forms.Label();
            this.lbl5a = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.bttMais = new System.Windows.Forms.Button();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.BttListar = new System.Windows.Forms.Button();
            this.bttGravar = new System.Windows.Forms.Button();
            this.bttSair = new System.Windows.Forms.Button();
            this.bttResert = new System.Windows.Forms.Button();
            this.bttCalcular = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "peso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "O índice de massa corporal (IMC)é reconhecido como\r\npadrão internacional para ava" +
    "liar o grau de obesidade.\r\nO IMC é calculado dividindo om peso (em KG)pela altur" +
    "a\r\nao quadrado(em metros).\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ultilize os campos abaixo para calcular o IMC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Altura";
            // 
            // cbPeso
            // 
            this.cbPeso.FormattingEnabled = true;
            this.cbPeso.Location = new System.Drawing.Point(143, 168);
            this.cbPeso.Name = "cbPeso";
            this.cbPeso.Size = new System.Drawing.Size(121, 21);
            this.cbPeso.TabIndex = 4;
            // 
            // cbAltura
            // 
            this.cbAltura.FormattingEnabled = true;
            this.cbAltura.Location = new System.Drawing.Point(142, 208);
            this.cbAltura.Name = "cbAltura";
            this.cbAltura.Size = new System.Drawing.Size(121, 21);
            this.cbAltura.TabIndex = 5;
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Location = new System.Drawing.Point(209, 289);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(34, 13);
            this.lblImc.TabIndex = 9;
            this.lblImc.Text = "00,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "metros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(107, 332);
            this.label7.MaximumSize = new System.Drawing.Size(100, 20);
            this.label7.MinimumSize = new System.Drawing.Size(100, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "CATEGORIA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(232, 332);
            this.label8.MaximumSize = new System.Drawing.Size(100, 20);
            this.label8.MinimumSize = new System.Drawing.Size(100, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "IMC";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Aqua;
            this.lbl1.Location = new System.Drawing.Point(107, 362);
            this.lbl1.MaximumSize = new System.Drawing.Size(100, 20);
            this.lbl1.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 20);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "Abaixo do Peso";
            // 
            // lbl1a
            // 
            this.lbl1a.AutoSize = true;
            this.lbl1a.BackColor = System.Drawing.Color.Aqua;
            this.lbl1a.Location = new System.Drawing.Point(232, 362);
            this.lbl1a.MaximumSize = new System.Drawing.Size(100, 20);
            this.lbl1a.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl1a.Name = "lbl1a";
            this.lbl1a.Size = new System.Drawing.Size(100, 20);
            this.lbl1a.TabIndex = 16;
            this.lbl1a.Text = "Abaixo de 18,5";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Aqua;
            this.lbl2.Location = new System.Drawing.Point(107, 385);
            this.lbl2.MaximumSize = new System.Drawing.Size(100, 20);
            this.lbl2.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 20);
            this.lbl2.TabIndex = 17;
            this.lbl2.Text = "Peso Normal";
            // 
            // lbl2a
            // 
            this.lbl2a.AutoSize = true;
            this.lbl2a.BackColor = System.Drawing.Color.Aqua;
            this.lbl2a.Location = new System.Drawing.Point(232, 385);
            this.lbl2a.MaximumSize = new System.Drawing.Size(100, 20);
            this.lbl2a.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl2a.Name = "lbl2a";
            this.lbl2a.Size = new System.Drawing.Size(100, 20);
            this.lbl2a.TabIndex = 18;
            this.lbl2a.Text = "Abaixo de 18,,5 a 24,9";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Yellow;
            this.lbl3.Location = new System.Drawing.Point(107, 408);
            this.lbl3.MaximumSize = new System.Drawing.Size(100, 20);
            this.lbl3.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 20);
            this.lbl3.TabIndex = 19;
            this.lbl3.Text = "Sobre Peso";
            // 
            // lbl3a
            // 
            this.lbl3a.AutoSize = true;
            this.lbl3a.BackColor = System.Drawing.Color.Yellow;
            this.lbl3a.Location = new System.Drawing.Point(232, 408);
            this.lbl3a.MaximumSize = new System.Drawing.Size(100, 20);
            this.lbl3a.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl3a.Name = "lbl3a";
            this.lbl3a.Size = new System.Drawing.Size(100, 20);
            this.lbl3a.TabIndex = 20;
            this.lbl3a.Text = "25,0 a 29,9";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Yellow;
            this.lbl4.Location = new System.Drawing.Point(107, 431);
            this.lbl4.MaximumSize = new System.Drawing.Size(100, 20);
            this.lbl4.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(100, 20);
            this.lbl4.TabIndex = 21;
            this.lbl4.Text = "Obesidade Grau 1";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Yellow;
            this.lbl5.Location = new System.Drawing.Point(107, 454);
            this.lbl5.MaximumSize = new System.Drawing.Size(100, 20);
            this.lbl5.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(100, 20);
            this.lbl5.TabIndex = 22;
            this.lbl5.Text = "Obesidade Grau 2";
            // 
            // lbl4a
            // 
            this.lbl4a.AutoSize = true;
            this.lbl4a.BackColor = System.Drawing.Color.Yellow;
            this.lbl4a.Location = new System.Drawing.Point(232, 431);
            this.lbl4a.MaximumSize = new System.Drawing.Size(100, 20);
            this.lbl4a.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl4a.Name = "lbl4a";
            this.lbl4a.Size = new System.Drawing.Size(100, 20);
            this.lbl4a.TabIndex = 24;
            this.lbl4a.Text = "30 a 34,5";
            // 
            // lbl5a
            // 
            this.lbl5a.AutoSize = true;
            this.lbl5a.BackColor = System.Drawing.Color.Yellow;
            this.lbl5a.Location = new System.Drawing.Point(232, 454);
            this.lbl5a.MaximumSize = new System.Drawing.Size(100, 20);
            this.lbl5a.MinimumSize = new System.Drawing.Size(100, 20);
            this.lbl5a.Name = "lbl5a";
            this.lbl5a.Size = new System.Drawing.Size(100, 20);
            this.lbl5a.TabIndex = 25;
            this.lbl5a.Text = "35,5 a 39,9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Sexo ";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino "});
            this.cbSexo.Location = new System.Drawing.Point(142, 136);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 28;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(70, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Nome";
            // 
            // cbNome
            // 
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(143, 101);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(121, 21);
            this.cbNome.TabIndex = 30;
            // 
            // bttMais
            // 
            this.bttMais.BackColor = System.Drawing.Color.Yellow;
            this.bttMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMais.Location = new System.Drawing.Point(298, 99);
            this.bttMais.Name = "bttMais";
            this.bttMais.Size = new System.Drawing.Size(34, 33);
            this.bttMais.TabIndex = 31;
            this.bttMais.Text = "+";
            this.bttMais.UseVisualStyleBackColor = false;
            this.bttMais.Click += new System.EventHandler(this.bttMais_Click);
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(142, 251);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(200, 20);
            this.dtData.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Data";
            // 
            // BttListar
            // 
            this.BttListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttListar.Location = new System.Drawing.Point(173, 481);
            this.BttListar.Name = "BttListar";
            this.BttListar.Size = new System.Drawing.Size(72, 33);
            this.BttListar.TabIndex = 34;
            this.BttListar.Text = "Listar";
            this.BttListar.UseVisualStyleBackColor = true;
            this.BttListar.Click += new System.EventHandler(this.BttListar_Click);
            // 
            // bttGravar
            // 
            this.bttGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGravar.Location = new System.Drawing.Point(278, 481);
            this.bttGravar.Name = "bttGravar";
            this.bttGravar.Size = new System.Drawing.Size(72, 33);
            this.bttGravar.TabIndex = 35;
            this.bttGravar.Text = "Gravar";
            this.bttGravar.UseVisualStyleBackColor = true;
            this.bttGravar.Click += new System.EventHandler(this.bttGravar_Click);
            // 
            // bttSair
            // 
            this.bttSair.Image = global::WindowsFormsApp1.Properties.Resources.canc;
            this.bttSair.Location = new System.Drawing.Point(73, 477);
            this.bttSair.Name = "bttSair";
            this.bttSair.Size = new System.Drawing.Size(75, 37);
            this.bttSair.TabIndex = 12;
            this.bttSair.Text = "SAIR";
            this.bttSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttSair.UseVisualStyleBackColor = true;
            this.bttSair.Click += new System.EventHandler(this.bttSair_Click);
            // 
            // bttResert
            // 
            this.bttResert.Image = global::WindowsFormsApp1.Properties.Resources.recicle;
            this.bttResert.Location = new System.Drawing.Point(266, 277);
            this.bttResert.Name = "bttResert";
            this.bttResert.Size = new System.Drawing.Size(90, 37);
            this.bttResert.TabIndex = 8;
            this.bttResert.Text = "Resert";
            this.bttResert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttResert.UseVisualStyleBackColor = true;
            this.bttResert.Click += new System.EventHandler(this.bttResert_Click);
            // 
            // bttCalcular
            // 
            this.bttCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttCalcular.Image = global::WindowsFormsApp1.Properties.Resources.ok;
            this.bttCalcular.Location = new System.Drawing.Point(73, 277);
            this.bttCalcular.Name = "bttCalcular";
            this.bttCalcular.Size = new System.Drawing.Size(108, 37);
            this.bttCalcular.TabIndex = 6;
            this.bttCalcular.Text = "Calcular";
            this.bttCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bttCalcular.UseVisualStyleBackColor = false;
            this.bttCalcular.Click += new System.EventHandler(this.bttCalcular_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(298, 138);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 36;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 524);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.bttGravar);
            this.Controls.Add(this.BttListar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.bttMais);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl5a);
            this.Controls.Add(this.lbl4a);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3a);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2a);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1a);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttSair);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.bttResert);
            this.Controls.Add(this.bttCalcular);
            this.Controls.Add(this.cbAltura);
            this.Controls.Add(this.cbPeso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPeso;
        private System.Windows.Forms.ComboBox cbAltura;
        private System.Windows.Forms.Button bttCalcular;
        private System.Windows.Forms.Button bttResert;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttSair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl1a;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl2a;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl3a;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4a;
        private System.Windows.Forms.Label lbl5a;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.Button bttMais;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BttListar;
        private System.Windows.Forms.Button bttGravar;
        private System.Windows.Forms.Button buscar;
    }
}

