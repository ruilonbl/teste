namespace tarefa1
{
    partial class Cadastro
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.rb_masculino = new System.Windows.Forms.RadioButton();
            this.rb_feminino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cpf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(109, 39);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(152, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(109, 82);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(152, 20);
            this.txt_cpf.TabIndex = 5;
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.Location = new System.Drawing.Point(112, 181);
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Size = new System.Drawing.Size(73, 17);
            this.rb_masculino.TabIndex = 6;
            this.rb_masculino.TabStop = true;
            this.rb_masculino.Text = "Masculino";
            this.rb_masculino.UseVisualStyleBackColor = true;
            // 
            // rb_feminino
            // 
            this.rb_feminino.AutoSize = true;
            this.rb_feminino.Location = new System.Drawing.Point(203, 181);
            this.rb_feminino.Name = "rb_feminino";
            this.rb_feminino.Size = new System.Drawing.Size(67, 17);
            this.rb_feminino.TabIndex = 7;
            this.rb_feminino.TabStop = true;
            this.rb_feminino.Text = "Feminino";
            this.rb_feminino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Altura";
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(109, 115);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(152, 20);
            this.txt_altura.TabIndex = 9;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(109, 148);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(152, 20);
            this.txt_peso.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Peso";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(109, 250);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(106, 23);
            this.btn_registrar.TabIndex = 12;
            this.btn_registrar.Text = "registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(259, 250);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(106, 23);
            this.btn_voltar.TabIndex = 13;
            this.btn_voltar.Text = "voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 299);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_feminino);
            this.Controls.Add(this.rb_masculino);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.RadioButton rb_masculino;
        private System.Windows.Forms.RadioButton rb_feminino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_voltar;
    }
}