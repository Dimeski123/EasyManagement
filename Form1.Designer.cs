namespace LoginSistem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoginDirector = new System.Windows.Forms.Button();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMainExplanation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoginDirector
            // 
            this.btnLoginDirector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoginDirector.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginDirector.Location = new System.Drawing.Point(220, 280);
            this.btnLoginDirector.Name = "btnLoginDirector";
            this.btnLoginDirector.Size = new System.Drawing.Size(151, 54);
            this.btnLoginDirector.TabIndex = 1;
            this.btnLoginDirector.Text = "Login";
            this.btnLoginDirector.UseVisualStyleBackColor = false;
            this.btnLoginDirector.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExitMain
            // 
            this.btnExitMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExitMain.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMain.Location = new System.Drawing.Point(644, 425);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(137, 61);
            this.btnExitMain.TabIndex = 2;
            this.btnExitMain.Text = "Exit";
            this.btnExitMain.UseVisualStyleBackColor = false;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblMainExplanation
            // 
            this.lblMainExplanation.AutoSize = true;
            this.lblMainExplanation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainExplanation.Location = new System.Drawing.Point(240, 182);
            this.lblMainExplanation.Name = "lblMainExplanation";
            this.lblMainExplanation.Size = new System.Drawing.Size(347, 24);
            this.lblMainExplanation.TabIndex = 4;
            this.lblMainExplanation.Text = "Welcome to the Managment application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "You can login as Director and see the list of your employees and contorl your inc" +
    "ome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(770, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Press the Login Button, and if you aren\'t registeret press the Register button on" +
    " Login Form";
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuide.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuide.Location = new System.Drawing.Point(456, 280);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(151, 54);
            this.btnGuide.TabIndex = 7;
            this.btnGuide.Text = "Guide";
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(824, 513);
            this.Controls.Add(this.btnGuide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMainExplanation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExitMain);
            this.Controls.Add(this.btnLoginDirector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoginDirector;
        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMainExplanation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuide;
    }
}

