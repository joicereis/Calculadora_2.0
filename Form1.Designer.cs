namespace Calculadora
{
    partial class frmCalculadora
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnRaizQuadrada = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSubtrai = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnPorcento = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnFracao = new System.Windows.Forms.Button();
            this.txtOperacaoEmCurso = new System.Windows.Forms.TextBox();
            this.txtHistórico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizaHistorico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(80, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "CE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(148, 133);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 31);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Location = new System.Drawing.Point(216, 133);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(62, 31);
            this.btnBackSpace.TabIndex = 4;
            this.btnBackSpace.Text = "<-";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Location = new System.Drawing.Point(80, 175);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(62, 31);
            this.btnPotencia.TabIndex = 6;
            this.btnPotencia.Text = "x²";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnRaizQuadrada
            // 
            this.btnRaizQuadrada.Location = new System.Drawing.Point(148, 175);
            this.btnRaizQuadrada.Name = "btnRaizQuadrada";
            this.btnRaizQuadrada.Size = new System.Drawing.Size(62, 31);
            this.btnRaizQuadrada.TabIndex = 7;
            this.btnRaizQuadrada.Text = "²Vx";
            this.btnRaizQuadrada.UseVisualStyleBackColor = true;
            this.btnRaizQuadrada.Click += new System.EventHandler(this.btnRaizQuadrada_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(216, 175);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(62, 31);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 216);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(62, 31);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(80, 216);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(62, 31);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(148, 216);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(62, 31);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Location = new System.Drawing.Point(216, 216);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(62, 31);
            this.btnMultiplica.TabIndex = 12;
            this.btnMultiplica.Text = "x";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            this.btnMultiplica.Click += new System.EventHandler(this.btnMultiplica_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 255);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(62, 31);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(80, 255);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(62, 31);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(148, 255);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(62, 31);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnSubtrai
            // 
            this.btnSubtrai.Location = new System.Drawing.Point(216, 255);
            this.btnSubtrai.Name = "btnSubtrai";
            this.btnSubtrai.Size = new System.Drawing.Size(62, 31);
            this.btnSubtrai.TabIndex = 16;
            this.btnSubtrai.Text = "-";
            this.btnSubtrai.UseVisualStyleBackColor = true;
            this.btnSubtrai.Click += new System.EventHandler(this.btnSubtrai_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 295);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(62, 31);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(80, 295);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(62, 31);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(148, 295);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(62, 31);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click_1);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(216, 295);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(62, 31);
            this.btnSoma.TabIndex = 20;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.Location = new System.Drawing.Point(12, 332);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(62, 31);
            this.btnNegate.TabIndex = 21;
            this.btnNegate.Text = "+ -";
            this.btnNegate.UseVisualStyleBackColor = true;
            this.btnNegate.Click += new System.EventHandler(this.btnNegate_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(80, 332);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(62, 31);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Location = new System.Drawing.Point(148, 332);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(62, 31);
            this.btnVirgula.TabIndex = 23;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(216, 332);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(62, 31);
            this.btnResultado.TabIndex = 24;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnPorcento
            // 
            this.btnPorcento.Enabled = false;
            this.btnPorcento.Location = new System.Drawing.Point(12, 133);
            this.btnPorcento.Name = "btnPorcento";
            this.btnPorcento.Size = new System.Drawing.Size(62, 31);
            this.btnPorcento.TabIndex = 0;
            this.btnPorcento.Text = "%";
            this.btnPorcento.UseVisualStyleBackColor = true;
            this.btnPorcento.Click += new System.EventHandler(this.btnPorcento_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 57);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(266, 52);
            this.txtResultado.TabIndex = 25;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultado_KeyPress);
            // 
            // btnFracao
            // 
            this.btnFracao.Location = new System.Drawing.Point(12, 175);
            this.btnFracao.Name = "btnFracao";
            this.btnFracao.Size = new System.Drawing.Size(62, 31);
            this.btnFracao.TabIndex = 5;
            this.btnFracao.Text = "¹/x";
            this.btnFracao.UseVisualStyleBackColor = true;
            this.btnFracao.Click += new System.EventHandler(this.btnFracao_Click);
            // 
            // txtOperacaoEmCurso
            // 
            this.txtOperacaoEmCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperacaoEmCurso.Location = new System.Drawing.Point(12, 27);
            this.txtOperacaoEmCurso.Margin = new System.Windows.Forms.Padding(0);
            this.txtOperacaoEmCurso.Multiline = true;
            this.txtOperacaoEmCurso.Name = "txtOperacaoEmCurso";
            this.txtOperacaoEmCurso.ReadOnly = true;
            this.txtOperacaoEmCurso.Size = new System.Drawing.Size(266, 27);
            this.txtOperacaoEmCurso.TabIndex = 27;
            this.txtOperacaoEmCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHistórico
            // 
            this.txtHistórico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistórico.Location = new System.Drawing.Point(284, 57);
            this.txtHistórico.Multiline = true;
            this.txtHistórico.Name = "txtHistórico";
            this.txtHistórico.Size = new System.Drawing.Size(219, 306);
            this.txtHistórico.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Histórico";
            // 
            // btnAtualizaHistorico
            // 
            this.btnAtualizaHistorico.Location = new System.Drawing.Point(447, 38);
            this.btnAtualizaHistorico.Name = "btnAtualizaHistorico";
            this.btnAtualizaHistorico.Size = new System.Drawing.Size(55, 19);
            this.btnAtualizaHistorico.TabIndex = 30;
            this.btnAtualizaHistorico.Text = "Atualizar";
            this.btnAtualizaHistorico.UseVisualStyleBackColor = true;
            this.btnAtualizaHistorico.Click += new System.EventHandler(this.btnAtualizaHistorico_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 395);
            this.Controls.Add(this.btnAtualizaHistorico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHistórico);
            this.Controls.Add(this.txtOperacaoEmCurso);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnNegate);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSubtrai);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnRaizQuadrada);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnFracao);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPorcento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.Shown += new System.EventHandler(this.frmCalculadora_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnRaizQuadrada;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSubtrai;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnNegate;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnPorcento;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnFracao;
        private System.Windows.Forms.TextBox txtOperacaoEmCurso;
        private System.Windows.Forms.TextBox txtHistórico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizaHistorico;
    }
}

