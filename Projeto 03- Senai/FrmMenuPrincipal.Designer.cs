﻿namespace Projeto_03__Senai
{
    partial class FrmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblVisualizarDadosAlunos = new System.Windows.Forms.Label();
            this.lblGerenciarEmpresa = new System.Windows.Forms.Label();
            this.lblGerarRelatórioAlunos = new System.Windows.Forms.Label();
            this.lblGerarRelatorioEmpresa = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControlVisualizarDadosAlunos1 = new Projeto_03__Senai.UserControlVisualizarDadosAlunos();
            this.userControlGerarRelatorioAluno1 = new Projeto_03__Senai.UserControlGerarRelatorioAluno();
            this.userControlGerenciarEmpresa1 = new Projeto_03__Senai.UserControlGerenciarEmpresa();
            this.userControlGerarRelatorioEmpresa1 = new Projeto_03__Senai.UserControlGerarRelatorioEmpresa();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 38);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(12, 7);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(24, 25);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(578, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 25);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(608, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 25);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.lblVisualizarDadosAlunos);
            this.panelMenu.Controls.Add(this.lblGerenciarEmpresa);
            this.panelMenu.Controls.Add(this.lblGerarRelatórioAlunos);
            this.panelMenu.Controls.Add(this.lblGerarRelatorioEmpresa);
            this.panelMenu.Location = new System.Drawing.Point(0, 38);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(0, 306);
            this.panelMenu.TabIndex = 2;
            // 
            // lblVisualizarDadosAlunos
            // 
            this.lblVisualizarDadosAlunos.AutoSize = true;
            this.lblVisualizarDadosAlunos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizarDadosAlunos.ForeColor = System.Drawing.Color.Snow;
            this.lblVisualizarDadosAlunos.Location = new System.Drawing.Point(33, 13);
            this.lblVisualizarDadosAlunos.Name = "lblVisualizarDadosAlunos";
            this.lblVisualizarDadosAlunos.Size = new System.Drawing.Size(129, 36);
            this.lblVisualizarDadosAlunos.TabIndex = 0;
            this.lblVisualizarDadosAlunos.Text = "Visualizar Dados \r\ndos Alunos";
            this.lblVisualizarDadosAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVisualizarDadosAlunos.Click += new System.EventHandler(this.lblVisualizarDadosAlunos_Click);
            // 
            // lblGerenciarEmpresa
            // 
            this.lblGerenciarEmpresa.AutoSize = true;
            this.lblGerenciarEmpresa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciarEmpresa.ForeColor = System.Drawing.Color.Snow;
            this.lblGerenciarEmpresa.Location = new System.Drawing.Point(27, 223);
            this.lblGerenciarEmpresa.Name = "lblGerenciarEmpresa";
            this.lblGerenciarEmpresa.Size = new System.Drawing.Size(147, 54);
            this.lblGerenciarEmpresa.TabIndex = 4;
            this.lblGerenciarEmpresa.Text = "Gerenciar Cadastro\r\nde \r\nEmpresas";
            this.lblGerenciarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGerenciarEmpresa.Click += new System.EventHandler(this.lblGerenciarEmpresa_Click);
            // 
            // lblGerarRelatórioAlunos
            // 
            this.lblGerarRelatórioAlunos.AutoSize = true;
            this.lblGerarRelatórioAlunos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerarRelatórioAlunos.ForeColor = System.Drawing.Color.Snow;
            this.lblGerarRelatórioAlunos.Location = new System.Drawing.Point(30, 71);
            this.lblGerarRelatórioAlunos.Name = "lblGerarRelatórioAlunos";
            this.lblGerarRelatórioAlunos.Size = new System.Drawing.Size(134, 54);
            this.lblGerarRelatórioAlunos.TabIndex = 3;
            this.lblGerarRelatórioAlunos.Text = "Gerar Relatório \r\ndos\r\nDados dos Alunos";
            this.lblGerarRelatórioAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGerarRelatórioAlunos.Click += new System.EventHandler(this.lblGerarRelatórioAlunos_Click);
            // 
            // lblGerarRelatorioEmpresa
            // 
            this.lblGerarRelatorioEmpresa.AutoSize = true;
            this.lblGerarRelatorioEmpresa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerarRelatorioEmpresa.ForeColor = System.Drawing.Color.Snow;
            this.lblGerarRelatorioEmpresa.Location = new System.Drawing.Point(27, 147);
            this.lblGerarRelatorioEmpresa.Name = "lblGerarRelatorioEmpresa";
            this.lblGerarRelatorioEmpresa.Size = new System.Drawing.Size(140, 54);
            this.lblGerarRelatorioEmpresa.TabIndex = 1;
            this.lblGerarRelatorioEmpresa.Text = "Gerar Relatório \r\ndos\r\nDados da Empresa";
            this.lblGerarRelatorioEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGerarRelatorioEmpresa.Click += new System.EventHandler(this.lblGerarRelatorioEmpresa_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 38;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userControlVisualizarDadosAlunos1
            // 
            this.userControlVisualizarDadosAlunos1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControlVisualizarDadosAlunos1.Location = new System.Drawing.Point(0, 36);
            this.userControlVisualizarDadosAlunos1.Name = "userControlVisualizarDadosAlunos1";
            this.userControlVisualizarDadosAlunos1.Size = new System.Drawing.Size(640, 304);
            this.userControlVisualizarDadosAlunos1.TabIndex = 3;
            // 
            // userControlGerarRelatorioAluno1
            // 
            this.userControlGerarRelatorioAluno1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControlGerarRelatorioAluno1.Location = new System.Drawing.Point(-3, 24);
            this.userControlGerarRelatorioAluno1.Name = "userControlGerarRelatorioAluno1";
            this.userControlGerarRelatorioAluno1.Size = new System.Drawing.Size(640, 304);
            this.userControlGerarRelatorioAluno1.TabIndex = 4;
            // 
            // userControlGerenciarEmpresa1
            // 
            this.userControlGerenciarEmpresa1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControlGerenciarEmpresa1.Location = new System.Drawing.Point(0, 38);
            this.userControlGerenciarEmpresa1.Name = "userControlGerenciarEmpresa1";
            this.userControlGerenciarEmpresa1.Size = new System.Drawing.Size(640, 304);
            this.userControlGerenciarEmpresa1.TabIndex = 5;
            // 
            // userControlGerarRelatorioEmpresa1
            // 
            this.userControlGerarRelatorioEmpresa1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControlGerarRelatorioEmpresa1.Location = new System.Drawing.Point(0, 37);
            this.userControlGerarRelatorioEmpresa1.Name = "userControlGerarRelatorioEmpresa1";
            this.userControlGerarRelatorioEmpresa1.Size = new System.Drawing.Size(640, 303);
            this.userControlGerarRelatorioEmpresa1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "SENAI - Sistema FIEMG";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(640, 340);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlVisualizarDadosAlunos1);
            this.Controls.Add(this.userControlGerarRelatorioAluno1);
            this.Controls.Add(this.userControlGerenciarEmpresa1);
            this.Controls.Add(this.userControlGerarRelatorioEmpresa1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblGerarRelatórioAlunos;
        private System.Windows.Forms.Label lblGerarRelatorioEmpresa;
        private System.Windows.Forms.Label lblVisualizarDadosAlunos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblGerenciarEmpresa;
        private UserControlVisualizarDadosAlunos userControlVisualizarDadosAlunos1;
        private UserControlGerarRelatorioAluno userControlGerarRelatorioAluno1;
        private UserControlGerenciarEmpresa userControlGerenciarEmpresa1;
        private UserControlGerarRelatorioEmpresa userControlGerarRelatorioEmpresa1;
        private System.Windows.Forms.Label label1;
    }
}