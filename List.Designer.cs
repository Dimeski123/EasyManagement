namespace LoginSistem
{
    partial class List
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
            this.dgwList = new System.Windows.Forms.DataGridView();
            this.btnShowList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxIDList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnListChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxIDChange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseLoginDirector
            // 
            this.btnCloseLoginDirector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseLoginDirector.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLoginDirector.Location = new System.Drawing.Point(698, 424);
            this.btnCloseLoginDirector.Name = "btnCloseLoginDirector";
            this.btnCloseLoginDirector.Size = new System.Drawing.Size(137, 61);
            this.btnCloseLoginDirector.TabIndex = 9;
            this.btnCloseLoginDirector.Text = "Close";
            this.btnCloseLoginDirector.UseVisualStyleBackColor = false;
            this.btnCloseLoginDirector.Click += new System.EventHandler(this.btnCloseLoginDirector_Click);
            // 
            // dgwList
            // 
            this.dgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwList.Location = new System.Drawing.Point(151, 12);
            this.dgwList.Name = "dgwList";
            this.dgwList.RowHeadersWidth = 51;
            this.dgwList.RowTemplate.Height = 24;
            this.dgwList.Size = new System.Drawing.Size(742, 287);
            this.dgwList.TabIndex = 10;
            this.dgwList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowList.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.Location = new System.Drawing.Point(8, 24);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(137, 61);
            this.btnShowList.TabIndex = 11;
            this.btnShowList.Text = "Show";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "To Delete an employee from the list, Write down his ID and press delete";
            // 
            // txtboxIDList
            // 
            this.txtboxIDList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxIDList.Location = new System.Drawing.Point(46, 460);
            this.txtboxIDList.Name = "txtboxIDList";
            this.txtboxIDList.Size = new System.Drawing.Size(58, 28);
            this.txtboxIDList.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID";
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteList.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteList.Location = new System.Drawing.Point(114, 445);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(137, 43);
            this.btnDeleteList.TabIndex = 15;
            this.btnDeleteList.Text = "Delete";
            this.btnDeleteList.UseVisualStyleBackColor = false;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // btnListChange
            // 
            this.btnListChange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnListChange.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListChange.Location = new System.Drawing.Point(434, 333);
            this.btnListChange.Name = "btnListChange";
            this.btnListChange.Size = new System.Drawing.Size(137, 43);
            this.btnListChange.TabIndex = 16;
            this.btnListChange.Text = "Change";
            this.btnListChange.UseVisualStyleBackColor = false;
            this.btnListChange.Click += new System.EventHandler(this.btnListChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID";
            // 
            // txtboxIDChange
            // 
            this.txtboxIDChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxIDChange.Location = new System.Drawing.Point(46, 348);
            this.txtboxIDChange.Name = "txtboxIDChange";
            this.txtboxIDChange.Size = new System.Drawing.Size(58, 28);
            this.txtboxIDChange.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "To Change an employees salary Write down their ID and new salary";
            // 
            // txtboxSalary
            // 
            this.txtboxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSalary.Location = new System.Drawing.Point(283, 348);
            this.txtboxSalary.Name = "txtboxSalary";
            this.txtboxSalary.Size = new System.Drawing.Size(112, 28);
            this.txtboxSalary.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "New Salary";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(905, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxIDChange);
            this.Controls.Add(this.btnListChange);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxIDList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.dgwList);
            this.Controls.Add(this.btnCloseLoginDirector);
            this.Name = "List";
            this.Text = "List";
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseLoginDirector;
        private System.Windows.Forms.DataGridView dgwList;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxIDList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Button btnListChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxIDChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxSalary;
        private System.Windows.Forms.Label label5;
    }
}