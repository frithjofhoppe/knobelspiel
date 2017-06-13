namespace Knobelprogramm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlStickLeft = new System.Windows.Forms.Panel();
            this.btnGetLeft = new System.Windows.Forms.Button();
            this.btnGetMiddle = new System.Windows.Forms.Button();
            this.btnGetRight = new System.Windows.Forms.Button();
            this.btnSetLeft = new System.Windows.Forms.Button();
            this.gtnSetMiddle = new System.Windows.Forms.Button();
            this.btnSetRight = new System.Windows.Forms.Button();
            this.pnlAroundLeft = new System.Windows.Forms.Panel();
            this.pnlAroundMiddle = new System.Windows.Forms.Panel();
            this.pnlStickMiddle = new System.Windows.Forms.Panel();
            this.pnlAroundRight = new System.Windows.Forms.Panel();
            this.pnlStickRight = new System.Windows.Forms.Panel();
            this.lblMoveTxt = new System.Windows.Forms.Label();
            this.lblMoveEff = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.nUpDownRinge = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.pnlAroundLeft.SuspendLayout();
            this.pnlAroundMiddle.SuspendLayout();
            this.pnlAroundRight.SuspendLayout();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownRinge)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStickLeft
            // 
            this.pnlStickLeft.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlStickLeft.Location = new System.Drawing.Point(88, 3);
            this.pnlStickLeft.Name = "pnlStickLeft";
            this.pnlStickLeft.Size = new System.Drawing.Size(19, 402);
            this.pnlStickLeft.TabIndex = 0;
            // 
            // btnGetLeft
            // 
            this.btnGetLeft.Location = new System.Drawing.Point(74, 9);
            this.btnGetLeft.Name = "btnGetLeft";
            this.btnGetLeft.Size = new System.Drawing.Size(75, 23);
            this.btnGetLeft.TabIndex = 2;
            this.btnGetLeft.Text = "Aufnehmen";
            this.btnGetLeft.UseVisualStyleBackColor = true;
            // 
            // btnGetMiddle
            // 
            this.btnGetMiddle.Location = new System.Drawing.Point(285, 9);
            this.btnGetMiddle.Name = "btnGetMiddle";
            this.btnGetMiddle.Size = new System.Drawing.Size(75, 23);
            this.btnGetMiddle.TabIndex = 3;
            this.btnGetMiddle.Text = "Aufnehmen";
            this.btnGetMiddle.UseVisualStyleBackColor = true;
            // 
            // btnGetRight
            // 
            this.btnGetRight.Location = new System.Drawing.Point(495, 9);
            this.btnGetRight.Name = "btnGetRight";
            this.btnGetRight.Size = new System.Drawing.Size(75, 23);
            this.btnGetRight.TabIndex = 4;
            this.btnGetRight.Text = "Aufnehmen";
            this.btnGetRight.UseVisualStyleBackColor = true;
            // 
            // btnSetLeft
            // 
            this.btnSetLeft.Location = new System.Drawing.Point(74, 446);
            this.btnSetLeft.Name = "btnSetLeft";
            this.btnSetLeft.Size = new System.Drawing.Size(75, 23);
            this.btnSetLeft.TabIndex = 5;
            this.btnSetLeft.Text = "Ablegen";
            this.btnSetLeft.UseVisualStyleBackColor = true;
            this.btnSetLeft.Click += new System.EventHandler(this.btnSetLeft_Click);
            // 
            // gtnSetMiddle
            // 
            this.gtnSetMiddle.Location = new System.Drawing.Point(285, 446);
            this.gtnSetMiddle.Name = "gtnSetMiddle";
            this.gtnSetMiddle.Size = new System.Drawing.Size(75, 23);
            this.gtnSetMiddle.TabIndex = 6;
            this.gtnSetMiddle.Text = "Ablegen";
            this.gtnSetMiddle.UseVisualStyleBackColor = true;
            // 
            // btnSetRight
            // 
            this.btnSetRight.Location = new System.Drawing.Point(495, 446);
            this.btnSetRight.Name = "btnSetRight";
            this.btnSetRight.Size = new System.Drawing.Size(75, 23);
            this.btnSetRight.TabIndex = 7;
            this.btnSetRight.Text = "Ablegen";
            this.btnSetRight.UseVisualStyleBackColor = true;
            // 
            // pnlAroundLeft
            // 
            this.pnlAroundLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAroundLeft.Controls.Add(this.pnlStickLeft);
            this.pnlAroundLeft.Location = new System.Drawing.Point(12, 38);
            this.pnlAroundLeft.Name = "pnlAroundLeft";
            this.pnlAroundLeft.Size = new System.Drawing.Size(199, 405);
            this.pnlAroundLeft.TabIndex = 8;
            // 
            // pnlAroundMiddle
            // 
            this.pnlAroundMiddle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAroundMiddle.Controls.Add(this.pnlStickMiddle);
            this.pnlAroundMiddle.Location = new System.Drawing.Point(227, 38);
            this.pnlAroundMiddle.Name = "pnlAroundMiddle";
            this.pnlAroundMiddle.Size = new System.Drawing.Size(199, 405);
            this.pnlAroundMiddle.TabIndex = 9;
            // 
            // pnlStickMiddle
            // 
            this.pnlStickMiddle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlStickMiddle.Location = new System.Drawing.Point(88, 3);
            this.pnlStickMiddle.Name = "pnlStickMiddle";
            this.pnlStickMiddle.Size = new System.Drawing.Size(19, 402);
            this.pnlStickMiddle.TabIndex = 0;
            // 
            // pnlAroundRight
            // 
            this.pnlAroundRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAroundRight.Controls.Add(this.pnlStickRight);
            this.pnlAroundRight.Location = new System.Drawing.Point(432, 38);
            this.pnlAroundRight.Name = "pnlAroundRight";
            this.pnlAroundRight.Size = new System.Drawing.Size(199, 405);
            this.pnlAroundRight.TabIndex = 10;
            // 
            // pnlStickRight
            // 
            this.pnlStickRight.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlStickRight.Location = new System.Drawing.Point(88, 3);
            this.pnlStickRight.Name = "pnlStickRight";
            this.pnlStickRight.Size = new System.Drawing.Size(19, 402);
            this.pnlStickRight.TabIndex = 0;
            // 
            // lblMoveTxt
            // 
            this.lblMoveTxt.AutoSize = true;
            this.lblMoveTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveTxt.Location = new System.Drawing.Point(6, 25);
            this.lblMoveTxt.Name = "lblMoveTxt";
            this.lblMoveTxt.Size = new System.Drawing.Size(94, 24);
            this.lblMoveTxt.TabIndex = 11;
            this.lblMoveTxt.Text = "Spielzüge";
            // 
            // lblMoveEff
            // 
            this.lblMoveEff.AutoSize = true;
            this.lblMoveEff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveEff.Location = new System.Drawing.Point(104, 25);
            this.lblMoveEff.Name = "lblMoveEff";
            this.lblMoveEff.Size = new System.Drawing.Size(20, 24);
            this.lblMoveEff.TabIndex = 12;
            this.lblMoveEff.Text = "..";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.nUpDownRinge);
            this.grpMenu.Controls.Add(this.btnStart);
            this.grpMenu.Controls.Add(this.btnEnd);
            this.grpMenu.Controls.Add(this.lblMoveTxt);
            this.grpMenu.Controls.Add(this.lblMoveEff);
            this.grpMenu.Location = new System.Drawing.Point(652, 159);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(200, 169);
            this.grpMenu.TabIndex = 13;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menü";
            // 
            // nUpDownRinge
            // 
            this.nUpDownRinge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownRinge.Location = new System.Drawing.Point(10, 71);
            this.nUpDownRinge.Name = "nUpDownRinge";
            this.nUpDownRinge.Size = new System.Drawing.Size(173, 24);
            this.nUpDownRinge.TabIndex = 15;
            this.nUpDownRinge.ValueChanged += new System.EventHandler(this.nUpDownRinge_ValueChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(10, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(108, 118);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 13;
            this.btnEnd.Text = "Beenden";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 480);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.pnlAroundRight);
            this.Controls.Add(this.pnlAroundMiddle);
            this.Controls.Add(this.pnlAroundLeft);
            this.Controls.Add(this.btnSetRight);
            this.Controls.Add(this.gtnSetMiddle);
            this.Controls.Add(this.btnSetLeft);
            this.Controls.Add(this.btnGetRight);
            this.Controls.Add(this.btnGetMiddle);
            this.Controls.Add(this.btnGetLeft);
            this.Name = "Form1";
            this.Text = "Türme von Hanoi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlAroundLeft.ResumeLayout(false);
            this.pnlAroundMiddle.ResumeLayout(false);
            this.pnlAroundRight.ResumeLayout(false);
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownRinge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStickLeft;
        private System.Windows.Forms.Button btnGetLeft;
        private System.Windows.Forms.Button btnGetMiddle;
        private System.Windows.Forms.Button btnGetRight;
        private System.Windows.Forms.Button btnSetLeft;
        private System.Windows.Forms.Button gtnSetMiddle;
        private System.Windows.Forms.Button btnSetRight;
        private System.Windows.Forms.Panel pnlAroundLeft;
        private System.Windows.Forms.Panel pnlAroundMiddle;
        private System.Windows.Forms.Panel pnlStickMiddle;
        private System.Windows.Forms.Panel pnlAroundRight;
        private System.Windows.Forms.Panel pnlStickRight;
        private System.Windows.Forms.Label lblMoveTxt;
        private System.Windows.Forms.Label lblMoveEff;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.NumericUpDown nUpDownRinge;
    }
}

