namespace Jogo
{
    partial class Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.Iniciar = new System.Windows.Forms.Button();
            this.ListaTerminal = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaAviao = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Andar = new System.Windows.Forms.Button();
            this.ListaCarro = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.painelCarro = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.painelCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // Iniciar
            // 
            this.Iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Iniciar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciar.Location = new System.Drawing.Point(2, 3);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(93, 31);
            this.Iniciar.TabIndex = 0;
            this.Iniciar.Text = "Iniciar o Jogo";
            this.Iniciar.UseVisualStyleBackColor = false;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // ListaTerminal
            // 
            this.ListaTerminal.Enabled = false;
            this.ListaTerminal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaTerminal.FormattingEnabled = true;
            this.ListaTerminal.ItemHeight = 15;
            this.ListaTerminal.Location = new System.Drawing.Point(32, 40);
            this.ListaTerminal.Name = "ListaTerminal";
            this.ListaTerminal.Size = new System.Drawing.Size(150, 139);
            this.ListaTerminal.TabIndex = 1;
            this.ListaTerminal.DoubleClick += new System.EventHandler(this.ListaTerminal_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Terminal";
            // 
            // ListaAviao
            // 
            this.ListaAviao.Enabled = false;
            this.ListaAviao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaAviao.FormattingEnabled = true;
            this.ListaAviao.ItemHeight = 15;
            this.ListaAviao.Location = new System.Drawing.Point(441, 40);
            this.ListaAviao.Name = "ListaAviao";
            this.ListaAviao.Size = new System.Drawing.Size(150, 139);
            this.ListaAviao.TabIndex = 3;
            this.ListaAviao.DoubleClick += new System.EventHandler(this.ListaAviao_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Avião";
            // 
            // Andar
            // 
            this.Andar.Enabled = false;
            this.Andar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.Andar.Location = new System.Drawing.Point(3, 95);
            this.Andar.Name = "Andar";
            this.Andar.Size = new System.Drawing.Size(105, 22);
            this.Andar.TabIndex = 5;
            this.Andar.Text = "Andar";
            this.Andar.UseVisualStyleBackColor = true;
            this.Andar.Click += new System.EventHandler(this.Andar_Click);
            // 
            // ListaCarro
            // 
            this.ListaCarro.Enabled = false;
            this.ListaCarro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.ListaCarro.FormattingEnabled = true;
            this.ListaCarro.ItemHeight = 15;
            this.ListaCarro.Location = new System.Drawing.Point(3, 31);
            this.ListaCarro.Name = "ListaCarro";
            this.ListaCarro.Size = new System.Drawing.Size(105, 64);
            this.ListaCarro.TabIndex = 6;
            this.ListaCarro.DoubleClick += new System.EventHandler(this.ListaCarro_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Carro";
            // 
            // painelCarro
            // 
            this.painelCarro.Controls.Add(this.label3);
            this.painelCarro.Controls.Add(this.Andar);
            this.painelCarro.Controls.Add(this.ListaCarro);
            this.painelCarro.Location = new System.Drawing.Point(188, 52);
            this.painelCarro.Name = "painelCarro";
            this.painelCarro.Size = new System.Drawing.Size(111, 127);
            this.painelCarro.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 208);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 218);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 460);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.painelCarro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListaAviao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaTerminal);
            this.Controls.Add(this.Iniciar);
            this.Name = "Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo";
            this.painelCarro.ResumeLayout(false);
            this.painelCarro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.ListBox ListaTerminal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListaAviao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Andar;
        private System.Windows.Forms.ListBox ListaCarro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel painelCarro;
        private System.Windows.Forms.TextBox textBox1;
    }
}

