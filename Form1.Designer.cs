namespace Aula31
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnInsereProduto = new System.Windows.Forms.Button();
            this.listBoxProduto = new System.Windows.Forms.ListBox();
            this.listBoxPreco = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(44, 36);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(65, 20);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(122, 36);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(157, 26);
            this.txtProduto.TabIndex = 1;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(329, 36);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 20);
            this.lblPreco.TabIndex = 0;
            this.lblPreco.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(407, 36);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(157, 26);
            this.txtPreco.TabIndex = 1;
            // 
            // btnInsereProduto
            // 
            this.btnInsereProduto.Location = new System.Drawing.Point(594, 36);
            this.btnInsereProduto.Name = "btnInsereProduto";
            this.btnInsereProduto.Size = new System.Drawing.Size(129, 32);
            this.btnInsereProduto.TabIndex = 2;
            this.btnInsereProduto.Text = "Insere Produto";
            this.btnInsereProduto.UseVisualStyleBackColor = true;
            this.btnInsereProduto.Click += new System.EventHandler(this.btnInsereProduto_Click);
            // 
            // listBoxProduto
            // 
            this.listBoxProduto.FormattingEnabled = true;
            this.listBoxProduto.ItemHeight = 20;
            this.listBoxProduto.Location = new System.Drawing.Point(48, 91);
            this.listBoxProduto.Name = "listBoxProduto";
            this.listBoxProduto.Size = new System.Drawing.Size(231, 244);
            this.listBoxProduto.TabIndex = 3;
            this.listBoxProduto.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxPreco
            // 
            this.listBoxPreco.FormattingEnabled = true;
            this.listBoxPreco.ItemHeight = 20;
            this.listBoxPreco.Location = new System.Drawing.Point(333, 91);
            this.listBoxPreco.Name = "listBoxPreco";
            this.listBoxPreco.Size = new System.Drawing.Size(231, 244);
            this.listBoxPreco.TabIndex = 3;
            this.listBoxPreco.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotal.Location = new System.Drawing.Point(589, 310);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(139, 25);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total Venda";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(140, 291);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(129, 35);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 356);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.listBoxPreco);
            this.Controls.Add(this.listBoxProduto);
            this.Controls.Add(this.btnInsereProduto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblProduto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnInsereProduto;
        private System.Windows.Forms.ListBox listBoxProduto;
        private System.Windows.Forms.ListBox listBoxPreco;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemover;
    }
}

