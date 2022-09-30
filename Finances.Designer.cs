namespace LoginSistem
{
    partial class Finances
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxNewBalance = new System.Windows.Forms.TextBox();
            this.dgwSalary = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dgwBalance = new System.Windows.Forms.DataGridView();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnterExpenses = new System.Windows.Forms.Button();
            this.txtboxExpenses = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseLoginDirector
            // 
            this.btnCloseLoginDirector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseLoginDirector.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLoginDirector.Location = new System.Drawing.Point(651, 377);
            this.btnCloseLoginDirector.Name = "btnCloseLoginDirector";
            this.btnCloseLoginDirector.Size = new System.Drawing.Size(137, 61);
            this.btnCloseLoginDirector.TabIndex = 9;
            this.btnCloseLoginDirector.Text = "Close";
            this.btnCloseLoginDirector.UseVisualStyleBackColor = false;
            this.btnCloseLoginDirector.Click += new System.EventHandler(this.btnCloseLoginDirector_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter your Current standing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxNewBalance
            // 
            this.txtboxNewBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNewBalance.Location = new System.Drawing.Point(325, 38);
            this.txtboxNewBalance.Name = "txtboxNewBalance";
            this.txtboxNewBalance.Size = new System.Drawing.Size(118, 27);
            this.txtboxNewBalance.TabIndex = 11;
            // 
            // dgwSalary
            // 
            this.dgwSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSalary.Location = new System.Drawing.Point(516, 159);
            this.dgwSalary.Name = "dgwSalary";
            this.dgwSalary.RowHeadersWidth = 51;
            this.dgwSalary.RowTemplate.Height = 24;
            this.dgwSalary.Size = new System.Drawing.Size(221, 80);
            this.dgwSalary.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Expenses for Salary";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(560, 119);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(129, 33);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "ViewSalary";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(69, 315);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 29);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Balance";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dgwBalance
            // 
            this.dgwBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBalance.Location = new System.Drawing.Point(197, 293);
            this.dgwBalance.Name = "dgwBalance";
            this.dgwBalance.RowHeadersWidth = 51;
            this.dgwBalance.RowTemplate.Height = 24;
            this.dgwBalance.Size = new System.Drawing.Size(221, 80);
            this.dgwBalance.TabIndex = 18;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(334, 71);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(103, 33);
            this.btnEnter.TabIndex = 19;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter your monthly expenses";
            // 
            // btnEnterExpenses
            // 
            this.btnEnterExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterExpenses.Location = new System.Drawing.Point(334, 174);
            this.btnEnterExpenses.Name = "btnEnterExpenses";
            this.btnEnterExpenses.Size = new System.Drawing.Size(103, 33);
            this.btnEnterExpenses.TabIndex = 22;
            this.btnEnterExpenses.Text = "Enter";
            this.btnEnterExpenses.UseVisualStyleBackColor = true;
            this.btnEnterExpenses.Click += new System.EventHandler(this.btnEnterExpenses_Click);
            // 
            // txtboxExpenses
            // 
            this.txtboxExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxExpenses.Location = new System.Drawing.Point(325, 141);
            this.txtboxExpenses.Name = "txtboxExpenses";
            this.txtboxExpenses.Size = new System.Drawing.Size(118, 27);
            this.txtboxExpenses.TabIndex = 21;
            // 
            // Finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnterExpenses);
            this.Controls.Add(this.txtboxExpenses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.dgwBalance);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwSalary);
            this.Controls.Add(this.txtboxNewBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseLoginDirector);
            this.Name = "Finances";
            this.Text = "Finances";
            ((System.ComponentModel.ISupportInitialize)(this.dgwSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseLoginDirector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxNewBalance;
        private System.Windows.Forms.DataGridView dgwSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dgwBalance;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnterExpenses;
        private System.Windows.Forms.TextBox txtboxExpenses;
    }
}