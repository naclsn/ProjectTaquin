﻿namespace App
{
    partial class SolverFormN
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
            this.solvingBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.solverSidePanel = new System.Windows.Forms.TableLayoutPanel();
            this.gameTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.solutionListBox = new System.Windows.Forms.ListBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.solverSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // solvingBackgroundWorker
            // 
            this.solvingBackgroundWorker.WorkerReportsProgress = true;
            this.solvingBackgroundWorker.WorkerSupportsCancellation = true;
            this.solvingBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.solvingBackgroundWorker_DoWork);
            this.solvingBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.solvingBackgroundWorker_ProgressChanged);
            this.solvingBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.solvingBackgroundWorker_RunWorkerCompleted);
            // 
            // solverSidePanel
            // 
            this.solverSidePanel.ColumnCount = 1;
            this.solverSidePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.solverSidePanel.Controls.Add(this.solutionListBox, 0, 0);
            this.solverSidePanel.Controls.Add(this.solveButton, 0, 1);
            this.solverSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.solverSidePanel.Location = new System.Drawing.Point(0, 0);
            this.solverSidePanel.Name = "solverSidePanel";
            this.solverSidePanel.RowCount = 2;
            this.solverSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.solverSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.solverSidePanel.Size = new System.Drawing.Size(120, 261);
            this.solverSidePanel.TabIndex = 0;
            // 
            // gameTablePanel
            // 
            this.gameTablePanel.ColumnCount = 1;
            this.gameTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gameTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTablePanel.Location = new System.Drawing.Point(120, 0);
            this.gameTablePanel.Name = "gameTablePanel";
            this.gameTablePanel.RowCount = 1;
            this.gameTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gameTablePanel.Size = new System.Drawing.Size(164, 261);
            this.gameTablePanel.TabIndex = 1;
            // 
            // solutionListBox
            // 
            this.solutionListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionListBox.FormattingEnabled = true;
            this.solutionListBox.Location = new System.Drawing.Point(3, 3);
            this.solutionListBox.Name = "solutionListBox";
            this.solutionListBox.Size = new System.Drawing.Size(114, 215);
            this.solutionListBox.TabIndex = 0;
            // 
            // solveButton
            // 
            this.solveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solveButton.Location = new System.Drawing.Point(3, 224);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(114, 34);
            this.solveButton.TabIndex = 1;
            this.solveButton.Text = "Résoudre";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // SolverFormN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gameTablePanel);
            this.Controls.Add(this.solverSidePanel);
            this.Name = "SolverFormN";
            this.Text = "SolverFormN";
            this.solverSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker solvingBackgroundWorker;
        private System.Windows.Forms.TableLayoutPanel solverSidePanel;
        private System.Windows.Forms.ListBox solutionListBox;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.TableLayoutPanel gameTablePanel;
    }
}