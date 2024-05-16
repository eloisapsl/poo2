namespace aula15_05_24elo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.Label();
            this.txbSobrenome = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 2;
            // 
            // txbNome
            // 
            this.txbNome.AutoSize = true;
            this.txbNome.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(44, 70);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(52, 19);
            this.txbNome.TabIndex = 4;
            this.txbNome.Text = "Nome:";
            this.txbNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.AutoSize = true;
            this.txbSobrenome.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSobrenome.Location = new System.Drawing.Point(44, 101);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(81, 19);
            this.txbSobrenome.TabIndex = 5;
            this.txbSobrenome.Text = "Sobrenome:";
            this.txbSobrenome.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.AutoSize = true;
            this.txbTelefone.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone.Location = new System.Drawing.Point(44, 135);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(68, 19);
            this.txbTelefone.TabIndex = 6;
            this.txbTelefone.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo:\r\n";
            // 
            // cbx1
            // 
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Location = new System.Drawing.Point(299, 134);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(112, 21);
            this.cbx1.TabIndex = 8;
            this.cbx1.SelectedIndexChanged += new System.EventHandler(this.cbx1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adicionar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(336, 161);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(502, 219);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Adicionar";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txbNome;
        private System.Windows.Forms.Label txbSobrenome;
        private System.Windows.Forms.Label txbTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionar;
    }
}