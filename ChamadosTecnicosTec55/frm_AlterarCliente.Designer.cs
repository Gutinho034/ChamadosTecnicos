namespace ChamadosTecnicosTec55
{
    partial class frm_AlterarCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.txbOBS = new System.Windows.Forms.TextBox();
            this.txbSetor = new System.Windows.Forms.TextBox();
            this.txbProfissao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Cod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Alterar Cliente";
            // 
            // txbOBS
            // 
            this.txbOBS.Location = new System.Drawing.Point(13, 271);
            this.txbOBS.Multiline = true;
            this.txbOBS.Name = "txbOBS";
            this.txbOBS.Size = new System.Drawing.Size(368, 118);
            this.txbOBS.TabIndex = 73;
            // 
            // txbSetor
            // 
            this.txbSetor.Location = new System.Drawing.Point(13, 216);
            this.txbSetor.Name = "txbSetor";
            this.txbSetor.Size = new System.Drawing.Size(368, 20);
            this.txbSetor.TabIndex = 72;
            // 
            // txbProfissao
            // 
            this.txbProfissao.Location = new System.Drawing.Point(13, 160);
            this.txbProfissao.Name = "txbProfissao";
            this.txbProfissao.Size = new System.Drawing.Size(368, 20);
            this.txbProfissao.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "Observação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Setor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Profissão";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(368, 20);
            this.txtNome.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Nome";
            // 
            // txb_Cod
            // 
            this.txb_Cod.Location = new System.Drawing.Point(285, 15);
            this.txb_Cod.Name = "txb_Cod";
            this.txb_Cod.Size = new System.Drawing.Size(77, 20);
            this.txb_Cod.TabIndex = 78;
            // 
            // frm_AlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 431);
            this.Controls.Add(this.txb_Cod);
            this.Controls.Add(this.txbOBS);
            this.Controls.Add(this.txbSetor);
            this.Controls.Add(this.txbProfissao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frm_AlterarCliente";
            this.Text = "frm_AlterarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbOBS;
        private System.Windows.Forms.TextBox txbSetor;
        private System.Windows.Forms.TextBox txbProfissao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Cod;
    }
}