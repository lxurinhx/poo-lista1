namespace Lista02Ex01
{
    partial class Form5
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNumParc = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnSolicit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "valor do empréstimo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "número de parcelas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "salário do solicitante:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(159, 32);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNumParc
            // 
            this.txtNumParc.Location = new System.Drawing.Point(159, 58);
            this.txtNumParc.Name = "txtNumParc";
            this.txtNumParc.Size = new System.Drawing.Size(100, 20);
            this.txtNumParc.TabIndex = 4;
            this.txtNumParc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(159, 84);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 5;
            this.txtSalario.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnSolicit
            // 
            this.btnSolicit.Location = new System.Drawing.Point(92, 120);
            this.btnSolicit.Name = "btnSolicit";
            this.btnSolicit.Size = new System.Drawing.Size(139, 23);
            this.btnSolicit.TabIndex = 6;
            this.btnSolicit.Text = "solicitar empréstimo";
            this.btnSolicit.UseVisualStyleBackColor = true;
            this.btnSolicit.Click += new System.EventHandler(this.btnSolicit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(65, 169);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(89, 23);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "situação:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 223);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSolicit);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNumParc);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNumParc;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnSolicit;
        private System.Windows.Forms.Label lblResult;
    }
}