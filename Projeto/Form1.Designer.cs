
namespace Projeto
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
            this.txtVendaCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVendaEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdutoQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProdutoNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVendaId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProdutoVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProdutoDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvarVenda = new System.Windows.Forms.Button();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.dataGridVendas = new System.Windows.Forms.DataGridView();
            this.dataGridProdutos = new System.Windows.Forms.DataGridView();
            this.lblProdutoId = new System.Windows.Forms.Label();
            this.txtProdutoId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFinalizarId = new System.Windows.Forms.TextBox();
            this.txtLimparDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVendaCliente
            // 
            this.txtVendaCliente.Location = new System.Drawing.Point(41, 123);
            this.txtVendaCliente.Name = "txtVendaCliente";
            this.txtVendaCliente.Size = new System.Drawing.Size(130, 20);
            this.txtVendaCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Módulo Vendas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço";
            // 
            // txtVendaEndereco
            // 
            this.txtVendaEndereco.Location = new System.Drawing.Point(41, 177);
            this.txtVendaEndereco.Name = "txtVendaEndereco";
            this.txtVendaEndereco.Size = new System.Drawing.Size(130, 20);
            this.txtVendaEndereco.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade";
            // 
            // txtProdutoQuantidade
            // 
            this.txtProdutoQuantidade.Location = new System.Drawing.Point(41, 478);
            this.txtProdutoQuantidade.Name = "txtProdutoQuantidade";
            this.txtProdutoQuantidade.Size = new System.Drawing.Size(130, 20);
            this.txtProdutoQuantidade.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nome Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Módulo Produto";
            // 
            // txtProdutoNome
            // 
            this.txtProdutoNome.Location = new System.Drawing.Point(41, 424);
            this.txtProdutoNome.Name = "txtProdutoNome";
            this.txtProdutoNome.Size = new System.Drawing.Size(130, 20);
            this.txtProdutoNome.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Identificador";
            // 
            // txtVendaId
            // 
            this.txtVendaId.Location = new System.Drawing.Point(41, 71);
            this.txtVendaId.Name = "txtVendaId";
            this.txtVendaId.Size = new System.Drawing.Size(130, 20);
            this.txtVendaId.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Identificador da venda";
            // 
            // txtProdutoVenda
            // 
            this.txtProdutoVenda.Location = new System.Drawing.Point(41, 586);
            this.txtProdutoVenda.Name = "txtProdutoVenda";
            this.txtProdutoVenda.Size = new System.Drawing.Size(130, 20);
            this.txtProdutoVenda.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Descrição";
            // 
            // txtProdutoDescricao
            // 
            this.txtProdutoDescricao.Location = new System.Drawing.Point(41, 532);
            this.txtProdutoDescricao.Name = "txtProdutoDescricao";
            this.txtProdutoDescricao.Size = new System.Drawing.Size(130, 20);
            this.txtProdutoDescricao.TabIndex = 12;
            // 
            // btnSalvarVenda
            // 
            this.btnSalvarVenda.Location = new System.Drawing.Point(41, 212);
            this.btnSalvarVenda.Name = "btnSalvarVenda";
            this.btnSalvarVenda.Size = new System.Drawing.Size(130, 23);
            this.btnSalvarVenda.TabIndex = 16;
            this.btnSalvarVenda.Text = "Salvar Venda";
            this.btnSalvarVenda.UseVisualStyleBackColor = true;
            this.btnSalvarVenda.Click += new System.EventHandler(this.btnSalvarVenda_Click);
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Location = new System.Drawing.Point(41, 625);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(130, 25);
            this.btnSalvarProduto.TabIndex = 17;
            this.btnSalvarProduto.Text = "Salvar Produto";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // dataGridVendas
            // 
            this.dataGridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVendas.Location = new System.Drawing.Point(222, 71);
            this.dataGridVendas.Name = "dataGridVendas";
            this.dataGridVendas.Size = new System.Drawing.Size(540, 164);
            this.dataGridVendas.TabIndex = 18;
            // 
            // dataGridProdutos
            // 
            this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutos.Location = new System.Drawing.Point(222, 367);
            this.dataGridProdutos.Name = "dataGridProdutos";
            this.dataGridProdutos.Size = new System.Drawing.Size(540, 283);
            this.dataGridProdutos.TabIndex = 19;
            // 
            // lblProdutoId
            // 
            this.lblProdutoId.AutoSize = true;
            this.lblProdutoId.Location = new System.Drawing.Point(41, 348);
            this.lblProdutoId.Name = "lblProdutoId";
            this.lblProdutoId.Size = new System.Drawing.Size(65, 13);
            this.lblProdutoId.TabIndex = 21;
            this.lblProdutoId.Text = "Identificador";
            // 
            // txtProdutoId
            // 
            this.txtProdutoId.Location = new System.Drawing.Point(41, 367);
            this.txtProdutoId.Name = "txtProdutoId";
            this.txtProdutoId.Size = new System.Drawing.Size(130, 20);
            this.txtProdutoId.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 701);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Finalizar Vendas";
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Location = new System.Drawing.Point(368, 703);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(130, 25);
            this.btnFinalizarVenda.TabIndex = 25;
            this.btnFinalizarVenda.Text = "Finalizar";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 690);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Identificador da venda";
            // 
            // txtFinalizarId
            // 
            this.txtFinalizarId.Location = new System.Drawing.Point(222, 706);
            this.txtFinalizarId.Name = "txtFinalizarId";
            this.txtFinalizarId.Size = new System.Drawing.Size(130, 20);
            this.txtFinalizarId.TabIndex = 23;
            // 
            // txtLimparDados
            // 
            this.txtLimparDados.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLimparDados.Location = new System.Drawing.Point(632, 12);
            this.txtLimparDados.Name = "txtLimparDados";
            this.txtLimparDados.Size = new System.Drawing.Size(130, 25);
            this.txtLimparDados.TabIndex = 26;
            this.txtLimparDados.Text = "Excluír Dados";
            this.txtLimparDados.UseVisualStyleBackColor = false;
            this.txtLimparDados.Click += new System.EventHandler(this.txtLimparDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.txtLimparDados);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFinalizarId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblProdutoId);
            this.Controls.Add(this.txtProdutoId);
            this.Controls.Add(this.dataGridProdutos);
            this.Controls.Add(this.dataGridVendas);
            this.Controls.Add(this.btnSalvarProduto);
            this.Controls.Add(this.btnSalvarVenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProdutoVenda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProdutoDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVendaId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProdutoQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProdutoNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVendaEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVendaCliente);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVendaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVendaEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdutoQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProdutoNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVendaId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProdutoVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProdutoDescricao;
        private System.Windows.Forms.Button btnSalvarVenda;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.DataGridView dataGridVendas;
        private System.Windows.Forms.DataGridView dataGridProdutos;
        private System.Windows.Forms.Label lblProdutoId;
        private System.Windows.Forms.TextBox txtProdutoId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFinalizarId;
        private System.Windows.Forms.Button txtLimparDados;
    }
}

