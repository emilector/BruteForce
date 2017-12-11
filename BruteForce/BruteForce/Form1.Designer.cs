namespace BruteForce
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
            this.UEstart = new System.Windows.Forms.Button();
            this.UEpassword = new System.Windows.Forms.TextBox();
            this.UEcounter = new System.Windows.Forms.Label();
            this.UEinfo = new System.Windows.Forms.Label();
            this.UEnumbersOnly = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UEstart
            // 
            this.UEstart.Location = new System.Drawing.Point(190, 279);
            this.UEstart.Name = "UEstart";
            this.UEstart.Size = new System.Drawing.Size(75, 24);
            this.UEstart.TabIndex = 0;
            this.UEstart.Text = "Start Attack";
            this.UEstart.UseVisualStyleBackColor = true;
            this.UEstart.Click += new System.EventHandler(this.UEstart_Click);
            // 
            // UEpassword
            // 
            this.UEpassword.Location = new System.Drawing.Point(179, 72);
            this.UEpassword.Name = "UEpassword";
            this.UEpassword.Size = new System.Drawing.Size(100, 20);
            this.UEpassword.TabIndex = 1;
            this.UEpassword.TextChanged += new System.EventHandler(this.UEpassword_TextChanged);
            // 
            // UEcounter
            // 
            this.UEcounter.AutoSize = true;
            this.UEcounter.Location = new System.Drawing.Point(290, 171);
            this.UEcounter.Name = "UEcounter";
            this.UEcounter.Size = new System.Drawing.Size(13, 13);
            this.UEcounter.TabIndex = 3;
            this.UEcounter.Text = "0";
            // 
            // UEinfo
            // 
            this.UEinfo.AutoSize = true;
            this.UEinfo.Location = new System.Drawing.Point(176, 226);
            this.UEinfo.Name = "UEinfo";
            this.UEinfo.Size = new System.Drawing.Size(121, 13);
            this.UEinfo.TabIndex = 5;
            this.UEinfo.Text = "Password not found yet!";
            // 
            // UEnumbersOnly
            // 
            this.UEnumbersOnly.AutoSize = true;
            this.UEnumbersOnly.Location = new System.Drawing.Point(179, 119);
            this.UEnumbersOnly.Name = "UEnumbersOnly";
            this.UEnumbersOnly.Size = new System.Drawing.Size(90, 17);
            this.UEnumbersOnly.TabIndex = 6;
            this.UEnumbersOnly.Text = "Numbers only";
            this.UEnumbersOnly.UseVisualStyleBackColor = true;
            this.UEnumbersOnly.CheckedChanged += new System.EventHandler(this.UEnumbersOnly_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tested combinations:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UEnumbersOnly);
            this.Controls.Add(this.UEinfo);
            this.Controls.Add(this.UEcounter);
            this.Controls.Add(this.UEpassword);
            this.Controls.Add(this.UEstart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BruteForce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UEstart;
        private System.Windows.Forms.TextBox UEpassword;
        private System.Windows.Forms.Label UEcounter;
        private System.Windows.Forms.Label UEinfo;
        private System.Windows.Forms.CheckBox UEnumbersOnly;
        private System.Windows.Forms.Label label1;
    }
}

