namespace LoginSistem
{
    partial class DirectorMenu
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
            this.btnCloseLoginDirector = new System.Windows.Forms.Button();
            this.lblWelcomeDirector = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnFinances = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseLoginDirector
            // 
            this.btnCloseLoginDirector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseLoginDirector.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLoginDirector.Location = new System.Drawing.Point(637, 368);
            this.btnCloseLoginDirector.Name = "btnCloseLoginDirector";
            this.btnCloseLoginDirector.Size = new System.Drawing.Size(137, 61);
            this.btnCloseLoginDirector.TabIndex = 8;
            this.btnCloseLoginDirector.Text = "Close";
            this.btnCloseLoginDirector.UseVisualStyleBackColor = false;
            this.btnCloseLoginDirector.Click += new System.EventHandler(this.btnCloseLoginDirector_Click);
            // 
            // lblWelcomeDirector
            // 
            this.lblWelcomeDirector.AutoSize = true;
            this.lblWelcomeDirector.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeDirector.Location = new System.Drawing.Point(168, 9);
            this.lblWelcomeDirector.Name = "lblWelcomeDirector";
            this.lblWelcomeDirector.Size = new System.Drawing.Size(470, 46);
            this.lblWelcomeDirector.TabIndex = 9;
            this.lblWelcomeDirector.Text = "Welcome to your Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register new employee to your company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "See the list of all employees and their info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Control your finances and calculate your income";
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(586, 104);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(98, 31);
            this.btnReg.TabIndex = 13;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(586, 196);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(98, 31);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnFinances
            // 
            this.btnFinances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinances.Location = new System.Drawing.Point(586, 286);
            this.btnFinances.Name = "btnFinances";
            this.btnFinances.Size = new System.Drawing.Size(98, 31);
            this.btnFinances.TabIndex = 15;
            this.btnFinances.Text = "Finances";
            this.btnFinances.UseVisualStyleBackColor = true;
            this.btnFinances.Click += new System.EventHandler(this.btnFinances_Click);
            // 
            // DirectorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinances);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcomeDirector);
            this.Controls.Add(this.btnCloseLoginDirector);
            this.Name = "DirectorMenu";
            this.Text = "DirectorMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseLoginDirector;
        private System.Windows.Forms.Label lblWelcomeDirector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnFinances;
    }
}