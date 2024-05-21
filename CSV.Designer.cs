namespace csv
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
            this.button1 = new System.Windows.Forms.Button();
            this.Ime = new System.Windows.Forms.TextBox();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.GodinaRodjenja = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(306, 107);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(164, 26);
            this.Ime.TabIndex = 1;
            // 
            // Prezime
            // 
            this.Prezime.Location = new System.Drawing.Point(306, 158);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(164, 26);
            this.Prezime.TabIndex = 2;
            // 
            // GodinaRodjenja
            // 
            this.GodinaRodjenja.Location = new System.Drawing.Point(306, 209);
            this.GodinaRodjenja.Name = "GodinaRodjenja";
            this.GodinaRodjenja.Size = new System.Drawing.Size(164, 26);
            this.GodinaRodjenja.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(306, 260);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(164, 26);
            this.Email.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.GodinaRodjenja);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.TextBox Prezime;
        private System.Windows.Forms.TextBox GodinaRodjenja;
        private System.Windows.Forms.TextBox Email;
    }
}

