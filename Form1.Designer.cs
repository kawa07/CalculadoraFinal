﻿namespace CalculadoraFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnZero = new Button();
            btnDivisao = new Button();
            btnMulti = new Button();
            btnSubtracao = new Button();
            btnSoma = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnLimpar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 15);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(263, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(16, 57);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(54, 48);
            btnSete.TabIndex = 1;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(76, 57);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(54, 48);
            btnOito.TabIndex = 2;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(136, 57);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(54, 48);
            btnNove.TabIndex = 3;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(16, 111);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(54, 48);
            btnQuatro.TabIndex = 4;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(76, 111);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(54, 48);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(136, 111);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(54, 48);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(16, 165);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(54, 48);
            btnUm.TabIndex = 7;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(76, 165);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(54, 48);
            btnDois.TabIndex = 8;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(136, 165);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(54, 48);
            btnTres.TabIndex = 9;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(76, 219);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(54, 48);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(214, 57);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(54, 48);
            btnDivisao.TabIndex = 11;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(214, 111);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(54, 48);
            btnMulti.TabIndex = 12;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(214, 165);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(54, 48);
            btnSubtracao.TabIndex = 13;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(214, 219);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(54, 48);
            btnSoma.TabIndex = 14;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(16, 219);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(54, 48);
            btnVirgula.TabIndex = 15;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(136, 219);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(54, 48);
            btnIgual.TabIndex = 16;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(16, 273);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(174, 48);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 356);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnSoma);
            Controls.Add(btnSubtracao);
            Controls.Add(btnMulti);
            Controls.Add(btnDivisao);
            Controls.Add(btnZero);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnZero;
        private Button btnDivisao;
        private Button btnMulti;
        private Button btnSubtracao;
        private Button btnSoma;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnLimpar;
        private Label label1;
    }
}
